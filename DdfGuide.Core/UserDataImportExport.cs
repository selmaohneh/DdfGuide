using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DdfGuide.Core
{
    public class UserDataImportExport : IUserDataImportExport
    {
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;
        private readonly IClipboardService _clipboardService;
        private readonly IYesNoDialog _yesNoDialog;
        private readonly IUserNotifier _userNotifier;

        public UserDataImportExport(
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IClipboardService clipboardService,
            IYesNoDialog yesNoDialog,
            IUserNotifier userNotifier)
        {
            _userDataCache = userDataCache;
            _clipboardService = clipboardService;
            _yesNoDialog = yesNoDialog;
            _userNotifier = userNotifier;
        }

        public void ExportUserData()
        {
            var userData = _userDataCache.Load().ToList();
            var json = JsonConvert.SerializeObject(userData);

            _yesNoDialog.YesClicked += (sender, args) =>
            {
                _clipboardService.SetClipboardText(json);
                _userNotifier.Notify("Daten erfolgreich in Zwischenablage kopiert.");
            };

            _yesNoDialog.Show(
                "In Zwischenablage exportieren?",
                $"Datensätze: {userData.Count}\n" +
                $"Als gehört markiert: {userData.Count(x => x.Heard)}\n" +
                $"Als Favorit markiert: {userData.Count(x => x.IsFavorite)}\n\n" +
                $"Dann kannst du deine Daten zum Sichern z.B. in einer Textdatei oder Email einfügen.");
        }
    }
}