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

            var interpreterSelectionView = new InterpreterSelectionView();

            var ddfGuide = new Core.DdfGuide(
                dtoProvider,
                userDataProvider,
                audioDramaListView,
                audioDramaView,
                rootForm,
                interpreterSelectionView);

            ddfGuide.Start();

            try
            {
                Application.Run(rootForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
