using System;
using System.Collections.Generic;
using System.Linq;
using DdfGuide.Android;
using Newtonsoft.Json;

namespace DdfGuide.Core
{
    public class UserDataImportExport : IUserDataImportExport
    {
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;
        private readonly IClipboardService _clipboardService;
        private readonly IYesNoDialog _yesNoDialog;
        private readonly IUserNotifier _userNotifier;
        private readonly IOkDialog _okDialog;
        private string _jsonForSavingToClipboard;
        private List<AudioDramaUserData> _mergedUserDataForImporting;

        public event EventHandler UserDataImported;

        public UserDataImportExport(
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IClipboardService clipboardService,
            IYesNoDialog yesNoDialog,
            IUserNotifier userNotifier,
            IOkDialog okDialog)
        {
            _userDataCache = userDataCache;
            _clipboardService = clipboardService;
            _yesNoDialog = yesNoDialog;
            _userNotifier = userNotifier;
            _okDialog = okDialog;
        }

        public void ExportUserData()
        {
            var userData = _userDataCache.Load().ToList();
            _jsonForSavingToClipboard = JsonConvert.SerializeObject(userData);

            _yesNoDialog.YesClicked += SaveClipboardText();

            _yesNoDialog.Show(
                "In Zwischenablage exportieren?",
                $"Datensätze: {userData.Count}\n" +
                $"Als gehört markiert: {userData.Count(x => x.Heard)}\n" +
                $"Als Favorit markiert: {userData.Count(x => x.IsFavorite)}\n\n" +
                $"Dann kannst du deine Daten zum Sichern z.B. in einer Textdatei oder Email einfügen.");
        }

        private EventHandler SaveClipboardText()
        {
            return (sender, args) =>
            {
                _clipboardService.SetClipboardText(_jsonForSavingToClipboard);
                _userNotifier.Notify("Daten erfolgreich in Zwischenablage kopiert.");
                _yesNoDialog.YesClicked -= SaveClipboardText();
            };
        }

        public void ImportUserData()
        {
            var json = _clipboardService.GetTextFromClipboard();

            if (string.IsNullOrWhiteSpace(json))
            {
                _okDialog.Show("Zwischenablage ist leer", "Bitte kopiere zunächst deine exportieren Benutzerdaten.");
                return;
            }

            List<AudioDramaUserData> newUserData;
            try
            {
                newUserData = JsonConvert.DeserializeObject<List<AudioDramaUserData>>(json);
            }
            catch (JsonException)
            {
                _okDialog.Show("Zwischenablage fehlerhaft", "Der Text in der Zwischenablage ist nicht valide. " +
                                                            "Bitte überprüfe, ob du alles richtig kopiert hast.");
                return;
            }

            if (newUserData.GroupBy(x => x.Id).Any(x => x.Count() > 1))
            {
                _okDialog.Show("Zwischenablage fehlerhaft", "Der Text in der Zwischenablage enthält Duplikate. " +
                                                            "Bitte überprüfe, ob du alles richtig kopiert hast.");
            }

            var oldUserData = _userDataCache.Load();
            _mergedUserDataForImporting = new List<AudioDramaUserData>();

            foreach (var old in oldUserData)
            {
                if (newUserData.All(x => x.Id != old.Id))
                {
                    _mergedUserDataForImporting.Add(old);
                }
            }

            _mergedUserDataForImporting.AddRange(newUserData);

            _yesNoDialog.YesClicked += ImportDataFromClipboard();

            _yesNoDialog.Show(
                "Daten aus Zwischenablage importieren?",
                $"Datensätze: {newUserData.Count}\n" +
                $"Als gehört markiert: {newUserData.Count(x => x.Heard)}\n" +
                $"Als Favorit markiert: {newUserData.Count(x => x.IsFavorite)}");
        }

        private EventHandler ImportDataFromClipboard()
        {
            return (sender, args) =>
            {
                _userDataCache.Save(_mergedUserDataForImporting);

                UserDataImported?.Invoke(this, EventArgs.Empty);

                _userNotifier.Notify("Benutzerdaten erfolgreich importiert.");
                _yesNoDialog.YesClicked -= ImportDataFromClipboard();
            };
        }
    }
}