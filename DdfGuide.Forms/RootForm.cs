using System;
using System.Windows.Forms;
using DdfGuide.Core;

namespace DdfGuide.Forms
{
    public partial class RootForm : Form, IRootView
    {
        public RootForm()
        {
            InitializeComponent();
        }

        public void Show(IView view)
        {
            if (!(view is Control control))
            {
                throw new Exception("View need to be a control in a WinForms app.");
            }

            panelRoot.Controls.Clear();

            control.Dock = DockStyle.Fill;
            panelRoot.Controls.Add(control);
        }

        public event EventHandler BackClicked;
    }
}
