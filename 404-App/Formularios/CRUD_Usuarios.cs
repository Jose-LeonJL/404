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
                actualizarDatos();
            }
            else
            {
                MenuPrincipal.ActiveForm.Enabled = true;
                actualizarDatos();

            }
        }
        private void actualizarDatos()
        {
            var dato = (from vs in Datos.Usuarios
                        group vs by vs into g
                        select new
                        {
                            id = g.Key.id,
                            Correo = g.Key.Correo,
                            Codigo = g.Key.Codigo,
                            Nombre = g.Key.Nombre,
                            Identidad = g.Key.Identidad,
                            Sueldo = g.Key.Sueldo,
                            Telefono = g.Key.Telefono,
                            Nick = g.Key.Nick,
                            Tipo = g.Key.Tipo,
                            Contraseña = g.Key.Contraseña,
                           
                            
                        }

                       ).ToList();
            tabla.DataSource = dato;
        }
    }
}
