using System;
using System.Globalization;
using System.Windows.Forms;
using DdfGuide.Core;

namespace DdfGuide.Forms
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            CultureInfo.CurrentCulture = new CultureInfo("de-DE");

            var dtoProvider = new MultipleDtoProvider();
            var userDataProvider = new MultipleUserDataProvider();

            var audioDramaView = new AudioDramaView();
            var audioDramaListView = new AudioDramaListView();

            var ddfGuide = new Core.DdfGuide(
                dtoProvider,
                userDataProvider,
                audioDramaListView,
                audioDramaView);

            ddfGuide.Start();
            
            Application.Run();
        }
    }
}
