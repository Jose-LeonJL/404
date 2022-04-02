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
            MenuPrincipal.ActiveForm.Enabled = false;
            var crear = new FrmCrearInventario();
            var resultado = crear.ShowDialog();
            if (resultado == DialogResult.OK)
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
            tabla.DataSource = Datos.Inventario;
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            var directorio = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404");
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            var pdfdir = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404",$"Reporte-Inventario-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf");
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
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Precio").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Stock").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Categoria").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Marca").SetFont(fontCulumna)));
            
            foreach(var producto in Datos.Inventario)
            {
                ta.AddCell(new Cell().Add(new Paragraph(producto.Codigo)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Nombre)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Precio.ToString())).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Stock.ToString())).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Categoria)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Marca)).SetFont(fontcontent));
            }
            document.Add(ta);
            document.Close();
        }
    }
}
