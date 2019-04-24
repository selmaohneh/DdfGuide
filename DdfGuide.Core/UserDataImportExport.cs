using System.Collections.Generic;
using Newtonsoft.Json;

namespace DdfGuide.Core
{
    public class UserDataImportExport
    {
        private readonly ICache<IEnumerable<AudioDramaUserData>> _userDataCache;
        private readonly IClipboardService _clipboardService;

        public UserDataImportExport(
            ICache<IEnumerable<AudioDramaUserData>> userDataCache,
            IClipboardService clipboardService)
        {
            _userDataCache = userDataCache;
            _clipboardService = clipboardService;
        }

        public void ExportUserData()
        {
            var userData = _userDataCache.Load();
            var json = JsonConvert.SerializeObject(userData);

            _clipboardService.SetClipboardText(json);
        }
    }
}