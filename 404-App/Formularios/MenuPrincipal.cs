using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _404_App.Formularios
{
    public partial class MenuPrincipal : Form
    {

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void PnBar_MouseMove(object sender, MouseEventArgs e)
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
        
        //Botones Barra
        private void BtnCerrar_MouseHover(object sender, EventArgs e)
        {
            BtnCerrar.BackColor = Color.Red;
        }
        private void BtnMinimizar_MouseHover(object sender, EventArgs e)
        {
            BtnMinimizar.BackColor = Color.DimGray;
        }
        private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        {
            BtnCerrar.BackColor = Color.Transparent;
        }
        private void BtnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimizar.BackColor = Color.Transparent;
        }
        
        //Boton Cerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Boton Minimizar
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
