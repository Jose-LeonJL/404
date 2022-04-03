using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DVStudio.SDK.Estructuras;
using DVStudio.SDK.clases;
using _404_App.Clases_Validaciones;
using FluentValidation.Results;
using DVStudio.SDK.Exceptions;

namespace _404_App.Formularios.Acciones
{
    public partial class FrmupdateUsuarios : Form
    {
        private string codigo;
        private ClaseUsuarios usuarios1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );

        public FrmupdateUsuarios( ClaseUsuarios usuarios)
        {
            InitializeComponent();
            codigo = System.Guid.NewGuid().ToString();
            txtCodigo.Text = codigo;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.usuarios1 = usuarios;
        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Clases_Validaciones.ClaseUsuarios
                {
                    id = System.Guid.NewGuid().ToString(),
                    Correo = txtCorreo.Text,
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Identidad = txtIdentidad.Text,
                    Sueldo = Int32.Parse(txtSueldo.Text),
                    Telefono = txtTelefono.Text,
                    Nick = txtNick.Text,
                    Tipo = CmbTipo.Text,
                    Contraseña = txtContra.Text
                };
                var validar1 = new UsuariosValidator();
                ValidationResult Resultado1 = validar1.Validate(usuario);
                if (!Resultado1.IsValid)
                {
                    throw new Exception(Resultado1.Errors[0].ToString());
                }
                var result = await Usuarios.Update_Usuario(new Struct_Usuarios
                {
                   Correo = usuario.Correo,
                   Codigo = usuario.Codigo,
                   Nombre = usuario.Nombre,
                   Identidad = usuario.Identidad,
                   Sueldo = usuario.Sueldo,
                   Telefono = usuario.Telefono,
                   Nick = usuario.Nick,
                   Tipo = usuario.Tipo,
                   Contraseña = usuario.Contraseña,


                },Datos.Token,usuarios1.id);
                if (result.status == "success")
                {
                    (from vs in Datos.Usuarios where vs.id == usuarios1.id select vs).FirstOrDefault().Identidad = txtIdentidad.Text;
                    (from vs in Datos.Usuarios where vs.id == usuarios1.id select vs).FirstOrDefault().Nick  = txtNick.Text;
                    (from vs in Datos.Usuarios where vs.id == usuarios1.id select vs).FirstOrDefault().Nombre = txtNombre.Text;
                    (from vs in Datos.Usuarios where vs.id == usuarios1.id select vs).FirstOrDefault().Sueldo = int.Parse(txtSueldo.Text);
                    (from vs in Datos.Usuarios where vs.id == usuarios1.id select vs).FirstOrDefault().Telefono = txtTelefono.Text;
                    (from vs in Datos.Usuarios where vs.id == usuarios1.id select vs).FirstOrDefault().Tipo= CmbTipo.Text;
                    this.DialogResult = DialogResult.OK;
                }
                

            }catch(ExceptionsResponse ex)
            {
                Console.WriteLine(ex.data.error);
                var error = new FrmNotificacionError(ex.data.error);
                error.showAlert();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                var error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
        }

        private void txtIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "1" | e.KeyChar.ToString() == "2" | e.KeyChar.ToString() == "3" | e.KeyChar.ToString() == "4" | e.KeyChar.ToString() == "5" | e.KeyChar.ToString() == "6" | e.KeyChar.ToString() == "7" | e.KeyChar.ToString() == "8" | e.KeyChar.ToString() == "9" | e.KeyChar.ToString() == "0" | e.KeyChar == Convert.ToChar(Keys.Delete) | e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if (txtIdentidad.Text.Length == 15 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                else if (txtIdentidad.Text.Length == 15 && e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    e.Handled = false;
                }
                else if (txtIdentidad.Text.Length <= 15)
                {
                    e.Handled = false;
                }

                if (txtIdentidad.Text.Length == 4 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    txtIdentidad.AppendText("-");
                }
                if (txtIdentidad.Text.Length == 9 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    txtIdentidad.AppendText("-");
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "1" | e.KeyChar.ToString() == "2" | e.KeyChar.ToString() == "3" | e.KeyChar.ToString() == "4" | e.KeyChar.ToString() == "5" | e.KeyChar.ToString() == "6" | e.KeyChar.ToString() == "7" | e.KeyChar.ToString() == "8" | e.KeyChar.ToString() == "9" | e.KeyChar.ToString() == "0" | e.KeyChar == Convert.ToChar(Keys.Delete) | e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if (txtTelefono.Text.Length == 9 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                else if (txtTelefono.Text.Length == 9 && e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    e.Handled = false;
                }
                else if (txtTelefono.Text.Length <= 9)
                {
                    e.Handled = false;
                }

                if (txtTelefono.Text.Length == 4 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    txtTelefono.AppendText("-");
                }

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
