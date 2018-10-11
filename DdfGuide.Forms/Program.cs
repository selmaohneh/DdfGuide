using System;
using System.Windows.Forms;
using DdfGuide.Core;

namespace DdfGuide.Forms
{
    public static class Program
    {
        public static RootForm RootForm { get; private set; }

            [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var rootForm = new RootForm();

            var dtoProvider = new BigSampleDtoProvider();
            var userDataProvider = new SampleUserDataProvider();
            
            var audioDramaView = new AudioDramaView();
            var audioDramaListView = new AudioDramaListView();

            var ddfGuide = new Core.DdfGuide(
                dtoProvider,
                userDataProvider,
                audioDramaListView,
                audioDramaView,
                rootForm);

            ddfGuide.Start();
            
            Application.Run(rootForm);
        }
    }
}
