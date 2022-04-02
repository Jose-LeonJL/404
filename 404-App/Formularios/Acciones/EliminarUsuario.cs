using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVStudio.SDK.clases;
using DVStudio.SDK.Exceptions;
using _404_App.Clases_Validaciones;

namespace _404_App.Formularios.Acciones
{
    public partial class Form1 : Form
    {
        private ClaseUsuarios usuario1;
        public Form1(ClaseUsuarios usuario)
        {
            InitializeComponent();
            this.usuario1 = usuario;
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await Usuarios.Delete_Usuario(usuario1.id, Datos.Token);
                Console.WriteLine($"resultado {result.status}");
                if (result.status == "success")
                {
                    var newinventario = (from vs in Datos.Usuarios where vs.id != usuario1.id select vs).ToList();

                    Datos.Usuarios = newinventario;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (ExceptionsResponse ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.data.error);
                error.showAlert();
            }
            catch (Exception ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
        }
    }
}
