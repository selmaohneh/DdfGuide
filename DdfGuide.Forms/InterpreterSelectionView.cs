using System;
using System.Windows.Forms;
using DdfGuide.Core;

namespace DdfGuide.Forms
{
    public partial class InterpreterSelectionView : UserControl,IInterpreterSelectionView
    {
        public InterpreterSelectionView()
        {
            InitializeComponent();
        }

        public event EventHandler BackClicked;
        public event EventHandler DieDreiFragezeichenClicked;
        public event EventHandler DieDreiClicked;
        public event EventHandler DieDreiFragezeichenKidsClicked;

        private void button1_Click(object sender, EventArgs e)
        {
            DieDreiFragezeichenClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
