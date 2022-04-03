using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404_App.Formularios
{
    public partial class FrmNotificacionEXito : Form
    {
        //Variables
        private int SD, X, Y, MaxValue, Counter;

        //Importacion de  api win32
        [DllImport("user32", EntryPoint = "GetClassLongA")]
        private static extern int GetClassLong(IntPtr DT, int UI);
        [DllImport("user32")]
        private static extern int GetDesktopWindow();
        [DllImport("user32", EntryPoint = "SetClassLongA")]
        private static extern int SetClassLong(IntPtr DT, int IDF, int IGT);
        [DllImport("user32", EntryPoint = "SetWindowLongA")]
        private static extern int SetWindowLong(IntPtr WO, int Ni, int NK);
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int LR, int TR, int RR, int BR, int WE, int HE);

        public FrmNotificacionEXito(string Mensaje)
        {
            InitializeComponent();
            LblError.Text = Mensaje;
            SuspendLayout();
            const int CS_DROPSHADOW = 0x2000;
            SD = SetWindowLong(Handle, -8, GetDesktopWindow());
            SetClassLong(Handle, -26, GetClassLong(Handle, -26) | CS_DROPSHADOW);
            ResumeLayout(false);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 20, 20));
        }
        public void showAlert()
        {
            Opacity = 0.0d;
            StartPosition = FormStartPosition.Manual;
            TopMost = true;
            string fname;
            for (int i = 1; i <= 10 - 1; i++)
            {
                fname = "alert" + i.ToString();
                FrmNotificacionEXito frm = (FrmNotificacionEXito)Application.OpenForms[fname];
                if (frm is null)
                {
                    Name = fname;
                    X = Screen.PrimaryScreen.WorkingArea.Width - Width + 15;
                    Y = Screen.PrimaryScreen.WorkingArea.Height - Height * i - 5 * i;
                    Location = new Point(X, Y);
                    break;
                }
            }

            X = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;
            Show();
            TimerOpenForm.Interval = 1;
            TimerOpenForm.Start();
            TimerUpdateBar.Start();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgresBar.Value += 1;
            if(ProgresBar.Value == 5)
            {
                TimerUpdateBar.Stop();
                TimerUpdateBar.Dispose();
                Close();
            }
        }
        private void TimerOpenForm_Tick(object sender, EventArgs e)
        {
            Opacity += 0.1d;
            if (X < Location.X)
            {
                Left -= 1;
            }
        }


        private void iconPictureBox1_MouseHover(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.Red;
        }
        private void iconPictureBox1_MouseLeave(object sender, EventArgs e)
        {
            iconPictureBox1.IconColor = Color.Black;
        }
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
