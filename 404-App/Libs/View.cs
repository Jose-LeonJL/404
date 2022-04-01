using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404_App.Libs
{
    public class View
    {
        private Form currentForm = null;
        public void OpenForm(Form ReceiveForm, Panel ReceivePanel)
        {
            if( currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = ReceiveForm;
            ReceiveForm.TopLevel = false;
            ReceiveForm.Dock = DockStyle.Fill;
            ReceivePanel.Controls.Add(ReceiveForm);
            ReceivePanel.Tag = ReceiveForm;
            ReceiveForm.BringToFront();
            ReceiveForm.Show();
        }
    }
}
