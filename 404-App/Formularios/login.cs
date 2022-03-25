using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DVStudio.SDK.clases;
using DVStudio.SDK.Estructuras;
using DVStudio.SDK.Exceptions;
using _404_App.Formularios;
using _404_App.Clases_Validaciones;
using FluentValidation;
using FluentValidation.Results;

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

        //Boton Mostrar Contraseña
        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if(iconPictureBox3.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.UseSystemPasswordChar= false;
            }
            else
            {
                iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        //Boton Login
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                circularProgressBar1.Visible = true;
                var login = new ClaseLogin()
                {
                    Correo=txtUser.Text,
                    Contraseña=txtPassword.Text

                  
                };
                var validar = new LoginValidator();
                ValidationResult Resultado = validar.Validate(login);

                if (!Resultado.IsValid)
                {
                    throw new Exception(Resultado.Errors[0].ToString());
                }

                var result = await Login.create_Login(new Struct_Login() 
                { 
                    Correo = login.Correo,
                    Contraseña = login.Contraseña
                });
                circularProgressBar1.Visible = false;
                if (result.data.login)
                {
                    MenuPrincipal menu = new Formularios.MenuPrincipal();
                    menu.Show();
                    this.Hide();
                }
            }catch(ExceptionsResponse ex)
            {
                circularProgressBar1.Visible = false;
                var ERROR = new FrmNotificacionError(ex.data.error);
                ERROR.showAlert();
            }catch(Exception ex)
            {
                circularProgressBar1.Visible = false;
                var ERROR = new FrmNotificacionError(ex.Message);
                ERROR.showAlert();
            }
            
        }

        //Botones de barra
        private void BtnCerrar_MouseHover(object sender, EventArgs e)
        {
            BtnCerrar.BackColor = Color.Red;
        }
        private void BtnMinimizar_MouseHover(object sender, EventArgs e)
        {
            BtnMinimizar.BackColor = Color.LightGray;
        }
        private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        {
            BtnCerrar.BackColor = Color.Transparent;
        }
        private void BtnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            BtnMinimizar.BackColor = Color.Transparent;
        }
        //Boton cerrar
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Boton Minimizar
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
    }
}
