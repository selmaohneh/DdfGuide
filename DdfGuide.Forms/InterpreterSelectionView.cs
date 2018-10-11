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
    }
}
