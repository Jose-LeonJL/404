using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DVStudio.SDK.clases;
using FluentValidation;
using FluentValidation.Results;
using _404_App.Clases_Validaciones;
using _404_App.Formularios.Acciones;
using System.Threading.Tasks;

namespace _404_App.Formularios
{
    public partial class CRUD_Usuarios : Form
    {
        public CRUD_Usuarios()
        {
            InitializeComponent();
        }

        private void PnShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CRUD_Usuarios_Load(object sender, EventArgs e)
        {
            if (Datos.Usuarios == null)
            {
                await Task.Delay(new Random().Next(1, 3) * 1000);
                //Carga de componentes
                indicadorcarga.Visible = false;
                LblCargando.Visible = false;

                tabla.DataSource = Datos.Usuarios;
                LblUserNickName.Visible = true;
                txtbuscar.Visible = true;
                pictureBox1.Visible = true;
                tabla.Visible = true;
                BtnCrear.Visible = true;
                BtnActualizar.Visible = true;
                BtnEliminar.Visible = true;
                BtnReporte.Visible = true;
            }
            else
            {
                //Carga de componentes
                indicadorcarga.Visible = false;
                LblCargando.Visible = false;

                tabla.DataSource = Datos.Usuarios;
                LblUserNickName.Visible = true;
                txtbuscar.Visible = true;
                pictureBox1.Visible = true;
                tabla.Visible = true;
                BtnCrear.Visible = true;
                BtnActualizar.Visible = true;
                BtnEliminar.Visible = true;
                BtnReporte.Visible = true;
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var dato = (from vs in Datos.Usuarios
                        where vs.Nombre.Contains  (txtbuscar.Text)
                        select vs).ToList();
            tabla.DataSource = dato;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            MenuPrincipal.ActiveForm.Enabled = false;
            var crear = new FrmCrearUsuarios();
            var resultado = crear.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                MenuPrincipal.ActiveForm.Enabled = true;
            }
            else
            {
                MenuPrincipal.ActiveForm.Enabled = true;

            }
        }
        private void ActualizarDatos()
        {
            tabla.DataSource = Datos.Usuarios;
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow == null)
                {
                    throw new Exception("Seleccione un usuario a eliminar");
                }
                var dato = (from vs in Datos.Usuarios where vs.id == tabla.CurrentRow.Cells[0].Value.ToString() select vs).FirstOrDefault();
                if (dato == null)
                {
                    throw new Exception("No se encontro referencia");
                }
                MenuPrincipal.ActiveForm.Enabled = false;
                Form ActualizarUsuario = new Form1(dato);
                var Actualizar = ActualizarUsuario.ShowDialog();
                if (Actualizar == DialogResult.OK)
                {
                    MenuPrincipal.ActiveForm.Enabled = true;
                    ActualizarDatos();
                }
                else
                {
                    MenuPrincipal.ActiveForm.Enabled = true;
                    ActualizarDatos();
                }
            }
            catch (Exception ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
        }
       

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
