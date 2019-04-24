using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DdfGuide.Core
{
    public class UserDataImportExport
    {
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;
        private readonly IClipboardService _clipboardService;
        private readonly IYesNoDialog _yesNoDialog;

        public UserDataImportExport(
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IClipboardService clipboardService,
            IYesNoDialog yesNoDialog)
        {
            _userDataCache = userDataCache;
            _clipboardService = clipboardService;
            _yesNoDialog = yesNoDialog;
        }

        public void ExportUserData()
        {
            var userData = _userDataCache.Load().ToList();
            var json = JsonConvert.SerializeObject(userData);

            _yesNoDialog.YesClicked += (sender, args) => { _clipboardService.SetClipboardText(json); };

            _yesNoDialog.Show(
                "In Zwischenablage exportieren?",
                $"Gehört: {userData.Count(x => x.Heard)}\n" +
                $"Favoriten: {userData.Count(x => x.IsFavorite)}");
        }
    }
}