using System;
using System.IO;
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
using iText.Kernel.Pdf;
using Microsoft.VisualBasic.FileIO;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using _404_App.Formularios.Acciones;

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
                FrmNotificacionEXito eXito = new FrmNotificacionEXito("Se creo el nuevo registro!!!");
                eXito.showAlert();
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

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            var directorio = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404");
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            var pdfdir = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404", $"Reporte-Ventas-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf");
            PdfWriter pdfwrite = new PdfWriter(pdfdir);
            PdfDocument pdf = new PdfDocument(pdfwrite);
            Document document = new Document(pdf, PageSize.LETTER);

            document.SetMargins(60, 20, 55, 20);

            PdfFont fontCulumna = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontcontent = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            float[] tamanios = { 1, 1, 1, 1, 1, 1 };
            Table ta = new Table(UnitValue.CreatePercentArray(tamanios));
            ta.SetWidth(UnitValue.CreatePercentValue(100));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Codigo").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Fecha").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Cliente").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Empleado").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("ISV").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Total").SetFont(fontCulumna)));

            foreach (var producto in Datos.Ventas)
            {
                ta.AddCell(new Cell().Add(new Paragraph(producto.Codigo)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Fecha)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Cliente.Nombre)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Empleado.Nombre)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.IVS.ToString())).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Total.ToString())).SetFont(fontcontent));
            }
            document.Add(ta);
            document.Close();
            FrmNotificacionEXito eXito = new FrmNotificacionEXito("Se genero el reporte!!!");
            eXito.showAlert();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
