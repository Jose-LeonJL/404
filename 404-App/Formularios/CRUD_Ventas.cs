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
    public partial class CRUD_Ventas : Form
    {
        public CRUD_Ventas()
        {
            InitializeComponent();
        }

        private void PnShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CRUD_Ventas_Load(object sender, EventArgs e)
        {
            if (Datos.Ventas == null)
            {
                Datos.Ventas = new List<ClaseVentas>();
                var ventas = await Ventas.Obtener_Ventas(Datos.Token);
                foreach (var venta in ventas.data.sales)
                {
                    var ResultInventario = new ClaseVentas
                    {
                        id=venta.id,
                        Cliente = venta.Data.Cliente,
                        Codigo = venta.Data.Codigo,
                        Empleado = venta.Data.Empleado,
                        Fecha = venta.Data.Fecha,
                        IVS = venta.Data.IVS,
                        Productos = venta.Data.Productos,
                        Total = venta.Data.Total
                    };
                    var validar = new VentasValidator1();
                    ValidationResult Resultado = validar.Validate(ResultInventario);
                    if (Resultado.IsValid)
                    {
                        Datos.Ventas.Add(ResultInventario);
                    }else
                    {
                        var c = new FrmNotificacionError(Resultado.Errors[0].ToString());
                        c.showAlert();
                    }
                }

                var dato = (from vs in Datos.Ventas
                            group vs by vs into g
                            select new
                            {
                                id =g.Key.id,
                                CodigoVenta = g.Key.Codigo,
                                FechaVenta = g.Key.Fecha,
                                ISV = g.Key.IVS,
                                TotalVenta = g.Key.Total,

                                IdentidadCliente = g.Key.Cliente.Identidad,
                                NombreCliente = g.Key.Cliente.Nombre,
                                TelefonoCliente = g.Key.Cliente.Telefono,

                                CodigoEmpleado = g.Key.Empleado.Codigo,
                                IdentidadEmpleado = g.Key.Empleado.Identidad,
                                NombreEmpleado = g.Key.Empleado.Nombre,

                                Productos = g.Key.Productos.ToList()
                            }).ToList();

                //Carga de componentes
                indicadorcarga.Visible = false;
                LblCargando.Visible = false;

                tabla.DataSource = dato;
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
                var dato = (from vs in Datos.Ventas
                            group vs by vs into g
                            select new
                            {
                                id = g.Key.id,
                                CodigoVenta = g.Key.Codigo,
                                FechaVenta = g.Key.Fecha,
                                ISV = g.Key.IVS,
                                TotalVenta = g.Key.Total,

                                IdentidadCliente = g.Key.Cliente.Identidad,
                                NombreCliente = g.Key.Cliente.Nombre,
                                TelefonoCliente = g.Key.Cliente.Telefono,

                                CodigoEmpleado = g.Key.Empleado.Codigo,
                                IdentidadEmpleado = g.Key.Empleado.Identidad,
                                NombreEmpleado = g.Key.Empleado.Nombre,

                                Productos = g.Key.Productos.ToList()
                            }).ToList();
                //Carga de componentes
                indicadorcarga.Visible = false;
                LblCargando.Visible = false;

                tabla.DataSource = dato;
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

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            MenuPrincipal.ActiveForm.Enabled = false;
            var crear = new FrmCrear("Crear Venta");
            var resultado=  crear.ShowDialog();
            if(resultado == DialogResult.OK)
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
        private void ActualizarDatos()
        {
            var dato = (from vs in Datos.Ventas
                        group vs by vs into g
                        select new
                        {
                            id = g.Key.id,
                            CodigoVenta = g.Key.Codigo,
                            FechaVenta = g.Key.Fecha,
                            ISV = g.Key.IVS,
                            TotalVenta = g.Key.Total,

                            IdentidadCliente = g.Key.Cliente.Identidad,
                            NombreCliente = g.Key.Cliente.Nombre,
                            TelefonoCliente = g.Key.Cliente.Telefono,

                            CodigoEmpleado = g.Key.Empleado.Codigo,
                            IdentidadEmpleado = g.Key.Empleado.Identidad,
                            NombreEmpleado = g.Key.Empleado.Nombre,

                            Productos = g.Key.Productos.ToList()
                        }).ToList();
            tabla.DataSource = dato;

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            var dato = (from vs in Datos.Ventas
                        where vs.Codigo.Contains(txtbuscar.Text)
                        group vs by vs into g
                        select new
                        {
                            id = g.Key.id,
                            CodigoVenta = g.Key.Codigo,
                            FechaVenta = g.Key.Fecha,
                            ISV = g.Key.IVS,
                            TotalVenta = g.Key.Total,

                            IdentidadCliente = g.Key.Cliente.Identidad,
                            NombreCliente = g.Key.Cliente.Nombre,
                            TelefonoCliente = g.Key.Cliente.Telefono,

                            CodigoEmpleado = g.Key.Empleado.Codigo,
                            IdentidadEmpleado = g.Key.Empleado.Identidad,
                            NombreEmpleado = g.Key.Empleado.Nombre,

                            Productos = g.Key.Productos.ToList()
                        }).ToList();
            tabla.DataSource = dato;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
