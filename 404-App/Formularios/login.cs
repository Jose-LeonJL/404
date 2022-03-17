using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace _404_App.Formularios
{
    public partial class login : Form
    {
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public login()
        {
            InitializeComponent();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }

        private void PtbIcon_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xF012, 0);
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Formularios.MenuPrincipal menu = new Formularios.MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
