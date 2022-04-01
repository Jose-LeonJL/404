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
    public partial class FrmActualizarInventario : Form
    {
        private String codigo;
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


        public FrmActualizarInventario()
        {
            InitializeComponent();
            codigo = System.Guid.NewGuid().ToString();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var producto = new Clases_Validaciones.ClaseInventario
                {
                    Nombre = txtNombre.Text,
                    Precio = Int32.Parse(txtPrecio.Text),
                    Stock = Int32.Parse(txtStock.Text),
                    Categoria = txtCategoria.Text,
                    Marca = txtMarca.Text,
                    id = txtId.Text,
                    Codigo = codigo,
                };
                var validar1 = new Inventariovalidator();
                ValidationResult Resultado1 = validar1.Validate(producto);
                if (!Resultado1.IsValid)
                {
                    throw new Exception(Resultado1.Errors[0].ToString());
                }
                var Result = await Inventario.create_Inventario(new Struct_Inventario
                {
                    Nombre = producto.Nombre,
                    Precio = producto.Precio,
                    Stock = producto.Stock,
                    Categoria = producto.Categoria,
                    Marca = producto.Marca,

                },Datos.Token);
                if(Result.status == "Success")
                {
                    Datos.Inventario.Add(producto);
                    this.DialogResult = DialogResult.OK;
                }
            }

            catch (ExceptionsResponse ex)
            {
                var error = new FrmNotificacionError(ex.data.error);
                error.showAlert();
            }
            catch (Exception ex)
            {
                var error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
