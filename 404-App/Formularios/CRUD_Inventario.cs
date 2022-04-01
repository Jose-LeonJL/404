using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using _404_App.Clases_Validaciones;
using System.Windows.Forms;
using DVStudio.SDK.clases;
using FluentValidation;
using FluentValidation.Results;

namespace _404_App.Formularios
{
    public partial class CRUD_Inventario : Form
    {
        public CRUD_Inventario()
        {
            InitializeComponent();
        }

        private async void CRUD_Inventario_Load(object sender, EventArgs e)
        {
            if (Datos.Inventario == null)
            {
                Datos.Inventario = new List<Clases_Validaciones.ClaseInventario>();
                var inventarios = await Inventario.Obtener_Inventario(Datos.Token);
                foreach(var inventario in inventarios.data.products)
                {
                    var ResultInventario = new ClaseInventario
                    {
                        id = inventario.id,
                        Categoria = inventario.Data.Categoria,
                        Codigo = inventario.Data.Codigo,
                        Marca = inventario.Data.Marca,
                        Nombre = inventario.Data.Nombre,
                        Precio = inventario.Data.Precio,
                        Stock = inventario.Data.Stock
                    };
                    var validar = new Inventariovalidator();
                    ValidationResult Resultado = validar.Validate(ResultInventario);
                    if (Resultado.IsValid)
                    {
                        Datos.Inventario.Add(ResultInventario);
                    }
                }
                
                //Carga de componentes
                indicadorcarga.Visible = false;
                LblCargando.Visible = false;

                tabla.DataSource = Datos.Inventario;
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

                tabla.DataSource = Datos.Inventario;
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
            var dato = (from vs in Datos.Inventario
                        where vs.Nombre.Contains(txtbuscar.Text)
                        select vs).ToList();
            tabla.DataSource = dato;
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {

        }
    }
}
