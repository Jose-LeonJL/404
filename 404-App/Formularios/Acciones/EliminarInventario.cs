using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _404_App.Clases_Validaciones;
using DVStudio.SDK.clases;
using DVStudio.SDK.Exceptions;
using MoreLinq;
using System.Runtime.InteropServices;
namespace _404_App.Formularios.Acciones
{
    public partial class EliminarInventario : Form
    {
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
        private ClaseInventario inventario1;
        public EliminarInventario(ClaseInventario inventario)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.inventario1 = inventario;
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var result = await Inventario.Delete_Inventario(inventario1.id, Datos.Token);
                Console.WriteLine($"resultado {result.status}");
                if (result.status == "success")
                {
                    var newinventario = (from vs in Datos.Inventario where vs.id != inventario1.id select vs).ToList();
                    
                    Datos.Inventario = newinventario;
                    this.DialogResult = DialogResult.OK;
                }            
            }
            catch(ExceptionsResponse ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.data.error);
                error.showAlert();  
            }
            catch (Exception ex)
            {
                FrmNotificacionError error = new FrmNotificacionError(ex.Message);
                error.showAlert();
            }
            
        }

    }
}
