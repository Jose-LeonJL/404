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
    public partial class FrmCrear : Form
    {
        private double isv,total;
        private string codigo;
        private List<Productos> productos;
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
        public FrmCrear(string Titulo)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            LblName.Text = Titulo;
            codigo = System.Guid.NewGuid().ToString();
            LblVenta.Text = $"N° de Venta :{codigo}";
            LblEmpleado.Text = $"N° de Empleado :{Datos.Usuario.Codigo}";
            productos = new List<Productos>();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var venta = new Clases_Validaciones.ClaseVentas
                {
                    Cliente = new DVStudio.SDK.Estructuras.Struct_Cliente
                    {
                        Identidad = TxtClienteIdentidad.Text,
                        Nombre =TxtClienteNombre.Text,
                        Telefono = TxtClienteTelefono.Text
                    },
                    Codigo=codigo,
                    Empleado = new DVStudio.SDK.Estructuras.Struct_Usuarios
                    {
                        Codigo = Datos.Usuario.Codigo,
                        Identidad = Datos.Usuario.Identidad,
                        Contraseña = Datos.Usuario.Contraseña,
                        Correo = Datos.Usuario.Correo,
                        Nombre = Datos.Usuario.Nombre,
                        Nick = Datos.Usuario.Nick,
                        Sueldo = Datos.Usuario.Sueldo,
                        Telefono = Datos.Usuario.Telefono,
                        Tipo = Datos.Usuario.Tipo
                    },
                    id =System.Guid.NewGuid().ToString(),
                    Fecha = DateTime.Now.Date.ToString(),
                    IVS = isv,
                    Total = total,
                    Productos = productos.ToArray(),
                    
                };
                var validar1 = new VentasValidator1();
                var validar2 = new VentasValidator2();
                var validar3 = new VentasValidator3();
                var validar4 = new VentasValidator4();
                ValidationResult Resultado1 = validar1.Validate(venta);
                ValidationResult Resultado2 = validar2.Validate(venta.Cliente);
                ValidationResult Resultado3 = validar3.Validate(venta.Productos);
                ValidationResult Resultado4 = validar4.Validate(venta.Empleado);
                if (!Resultado1.IsValid )
                {
                    throw new Exception(Resultado1.Errors[0].ToString());
                }
                if (!Resultado2.IsValid)
                {
                    throw new Exception(Resultado2.Errors[0].ToString());
                }
                if (!Resultado3.IsValid)
                {
                    throw new Exception(Resultado3.Errors[0].ToString());
                }
                if (!Resultado4.IsValid)
                {
                    throw new Exception(Resultado4.Errors[0].ToString());
                }
                var result = await Ventas.create_Ventas(new Struct_Ventas
                {
                    Cliente = venta.Cliente,
                    Codigo = venta.Codigo,
                    Empleado = venta.Empleado,
                    Fecha = venta.Fecha,
                    IVS = venta.IVS,
                    Productos = venta.Productos,
                    Total = venta.Total
                },Datos.Token);
                if(result.status == "success")
                {
                    Datos.Ventas.Add(venta);
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

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if(ListInventario.SelectedItem != null)
            {
                ListProductos.Items.Add(ListInventario.SelectedItem.ToString());
                isv += (from ins in Datos.Inventario where ins.Nombre == ListInventario.SelectedItem.ToString() select ins.Precio ).FirstOrDefault() * 0.012;
                total += (from ins in Datos.Inventario where ins.Nombre == ListInventario.SelectedItem.ToString() select ins.Precio).FirstOrDefault();
                LblIsv.Text = $"ISV : {isv.ToString("0.0")}";
                LblTotal.Text = $"Total : {total.ToString("0.0")}";
                productos.Add(new Productos
                {
                    id = (from ins in Datos.Inventario where ins.Nombre == ListInventario.SelectedItem.ToString() select ins.id).FirstOrDefault()
                });
            }
        }

        private async void FrmCrear_Load(object sender, EventArgs e)
        {
            if (Datos.Inventario == null)
            {
                await Datos.SetInventarios();
            }
            foreach (var inventario in (from ins in Datos.Inventario select ins.Nombre).ToList())
            {
                ListInventario.Items.Add(inventario);
            }
        }

        private void TxtClienteIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar.ToString() == "1" | e.KeyChar.ToString() == "2" | e.KeyChar.ToString() == "3" | e.KeyChar.ToString() == "4" | e.KeyChar.ToString() == "5" | e.KeyChar.ToString() == "6" | e.KeyChar.ToString() == "7" | e.KeyChar.ToString() == "8" | e.KeyChar.ToString() == "9" | e.KeyChar.ToString() == "0" | e.KeyChar ==Convert.ToChar( Keys.Delete) | e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if(TxtClienteIdentidad.Text.Length == 15 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                else if (TxtClienteIdentidad.Text.Length == 15 && e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    e.Handled =false;
                }else if (TxtClienteIdentidad.Text.Length <= 15)
                {
                    e.Handled = false;
                }
                
                if(TxtClienteIdentidad.Text.Length == 4 &&  e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    TxtClienteIdentidad.AppendText("-");
                }
                if (TxtClienteIdentidad.Text.Length == 9 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    TxtClienteIdentidad.AppendText("-");
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "1" | e.KeyChar.ToString() == "2" | e.KeyChar.ToString() == "3" | e.KeyChar.ToString() == "4" | e.KeyChar.ToString() == "5" | e.KeyChar.ToString() == "6" | e.KeyChar.ToString() == "7" | e.KeyChar.ToString() == "8" | e.KeyChar.ToString() == "9" | e.KeyChar.ToString() == "0" | e.KeyChar == Convert.ToChar(Keys.Delete) | e.KeyChar == Convert.ToChar(Keys.Back))
            {
                if (TxtClienteTelefono.Text.Length == 9 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    e.Handled = true;
                }
                else if (TxtClienteTelefono.Text.Length == 9 && e.KeyChar == Convert.ToChar(Keys.Back))
                {
                    e.Handled = false;
                }
                else if (TxtClienteTelefono.Text.Length <= 9)
                {
                    e.Handled = false;
                }

                if (TxtClienteTelefono.Text.Length == 4 && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    TxtClienteTelefono.AppendText("-");
                }
               
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if(ListProductos.SelectedItem != null)
            {
                isv -= (from ins in Datos.Inventario where ins.Nombre == ListProductos.SelectedItem.ToString() select ins.Precio).FirstOrDefault() * 0.012;
                total -= (from ins in Datos.Inventario where ins.Nombre == ListProductos.SelectedItem.ToString() select ins.Precio).FirstOrDefault();
                LblIsv.Text = $"ISV : {isv.ToString("0.0")}";
                LblTotal.Text = $"Total : {total.ToString("0.0")}";
                ListProductos.Items.Remove(ListProductos.SelectedItem);
            }
        }
    }
}
