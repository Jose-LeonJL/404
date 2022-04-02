﻿using System;
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
using System.Threading.Tasks;
using _404_App.Formularios.Acciones;

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

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            var directorio = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404");
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
            var pdfdir = System.IO.Path.Combine(SpecialDirectories.MyDocuments, "404", $"Reporte-Usuarios-{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.pdf");
            PdfWriter pdfwrite = new PdfWriter(pdfdir);
            PdfDocument pdf = new PdfDocument(pdfwrite);
            Document document = new Document(pdf, PageSize.LETTER);

            document.SetMargins(60, 20, 55, 20);

            PdfFont fontCulumna = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontcontent = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            float[] tamanios = { 1, 1, 1, 1, 1, 1 };
            Table ta = new Table(UnitValue.CreatePercentArray(tamanios));
            ta.SetWidth(UnitValue.CreatePercentValue(100));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Correo").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Nombre").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Identidad").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Sueldo").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Telefono").SetFont(fontCulumna)));
            ta.AddHeaderCell(new Cell().Add(new Paragraph("Tipo").SetFont(fontCulumna)));

            foreach (var producto in Datos.Usuarios)
            {
                ta.AddCell(new Cell().Add(new Paragraph(producto.Correo)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Nombre)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Identidad)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Sueldo.ToString())).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Telefono)).SetFont(fontcontent));
                ta.AddCell(new Cell().Add(new Paragraph(producto.Tipo)).SetFont(fontcontent));
            }
            document.Add(ta);
            document.Close();
        }
    }
}
