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
using iText.IO.Image;
using System.Threading.Tasks;

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
            try
            {
                MenuPrincipal.ActiveForm.Enabled = false;
                var frmcrear = new FrmCrearInventario();
                var result = frmcrear.ShowDialog();
                if(result == DialogResult.OK)
                {

                    ActualizarDatos();
                    FrmNotificacionEXito eXito = new FrmNotificacionEXito("Se creo el nuevo registro!!!");
                    eXito.showAlert();
                }
                else
                {

                    ActualizarDatos();
                }
                MenuPrincipal.ActiveForm.Enabled = true;
            }catch(Exception ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow == null)
                {
                    throw new Exception("Seleccione un articulo a eliminar");
                }
                var dato = (from vs in Datos.Inventario where vs.id == tabla.CurrentRow.Cells[6].Value.ToString() select vs).FirstOrDefault();
                if (dato == null)
                {
                    throw new Exception("No se encontro referencia");
                }
                MenuPrincipal.ActiveForm.Enabled = false;
                Form ActualizarInventario = new EliminarInventario(dato);
                var Actualizar = ActualizarInventario.ShowDialog();
                if (Actualizar == DialogResult.OK)
                {
                    MenuPrincipal.ActiveForm.Enabled = true;
                    ActualizarDatos();
                    FrmNotificacionEXito eXito = new FrmNotificacionEXito("Se elimino el registro!!!");
                    eXito.showAlert();
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
        private void ActualizarDatos()
        {
            tabla.DataSource = Datos.Inventario;
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabla.CurrentRow == null)
                {
                    throw new Exception("Seleccione un articulo a actualizar");
                }
                var dato = (from vs in Datos.Inventario where vs.id == tabla.CurrentRow.Cells[6].Value.ToString() select vs).FirstOrDefault();
                if(dato == null)
                {
                    throw new Exception("No se encontro referencia");
                }
                MenuPrincipal.ActiveForm.Enabled = false;
                Form ActualizarInventario = new FrmActualizarInventario(dato);
                var Actualizar = ActualizarInventario.ShowDialog();
                if (Actualizar == DialogResult.OK)
                {
                    MenuPrincipal.ActiveForm.Enabled = true;
                    ActualizarDatos();
                    FrmNotificacionEXito eXito = new FrmNotificacionEXito("Se actualizo el registro!!!");
                    eXito.showAlert();
                }
                else
                {
                    MenuPrincipal.ActiveForm.Enabled = true;
                    ActualizarDatos();
                }
            }
            catch(Exception ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
        }

        private async void BtnReporte_Click(object sender, EventArgs e)
        {
            FrmNotificacionEXito eXito = new FrmNotificacionEXito("Creando reporte...");
            eXito.showAlert();
            var directorio = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404");
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            var pdfdir = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404",$"Reporte-Inventario-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf");

            Action task1 = (() =>
            {
                using (PdfWriter pdfwrite = new PdfWriter(pdfdir))
                using (PdfDocument pdf = new PdfDocument(pdfwrite))
                using (Document document = new Document(pdf, PageSize.LETTER))
                {
                    document.SetMargins(70, 20, 55, 20);
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

                    foreach (var producto in Datos.Inventario)
                    {
                        ta.AddCell(new Cell().Add(new Paragraph(producto.Codigo)).SetFont(fontcontent));
                        ta.AddCell(new Cell().Add(new Paragraph(producto.Nombre)).SetFont(fontcontent));
                        ta.AddCell(new Cell().Add(new Paragraph(producto.Precio.ToString())).SetFont(fontcontent));
                        ta.AddCell(new Cell().Add(new Paragraph(producto.Stock.ToString())).SetFont(fontcontent));
                        ta.AddCell(new Cell().Add(new Paragraph(producto.Categoria)).SetFont(fontcontent));
                        ta.AddCell(new Cell().Add(new Paragraph(producto.Marca)).SetFont(fontcontent));
                    }
                    document.Add(ta);
                }
            });

            Action task2 = (() =>
            {
                var LogoPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "DVStudio.png");
                var logo = new iText.Layout.Element.Image(ImageDataFactory.Create(LogoPath)).SetWidth(50);
                var plogo = new Paragraph("").Add(logo);
                var titulo = new Paragraph("Reporte de Inventario");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(12);
                var fecha = new Paragraph($"Fecha: {DateTime.Now.ToString("dd-MM-yyyy")}");
                fecha.SetFontSize(12);
                var pdfreader = new PdfReader(pdfdir);
                var pdfwritter = new PdfWriter(pdfdir + "x.pdf");
                using (PdfDocument pdfDoc = new PdfDocument(pdfreader, pdfwritter))
                using (Document doc = new Document(pdfDoc))
                {
                    var paginas = pdfDoc.GetNumberOfPages();
                    for (int i = 1; i <= paginas; i++)
                    {
                        var p = pdfDoc.GetPage(i);
                        float y = (pdfDoc.GetPage(i).GetPageSize().GetTop() - 15);
                        doc.ShowTextAligned(plogo, 40, y, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                        doc.ShowTextAligned(titulo, 150, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);
                        doc.ShowTextAligned(fecha, 520, y - 15, i, TextAlignment.CENTER, VerticalAlignment.TOP, 0);

                    }
                }
            });

            Action task3 = () =>
            {
                var pdfreader = new PdfReader(pdfdir + "x.pdf");
                var pdfwritter = new PdfWriter(pdfdir);
                using (PdfDocument pdfDoc = new PdfDocument(pdfreader, pdfwritter))
                using (Document doc = new Document(pdfDoc))
                {
                }
                File.Delete(pdfdir + "x.pdf");
            };
            await Task.Run(task1);
            await Task.Run(task2);
            await Task.Run(task3);


            eXito = new FrmNotificacionEXito("Se genero el reporte!!!");
            eXito.showAlert();
        }
    }
}
