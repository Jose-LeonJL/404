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
namespace _404_App.Formularios.Acciones
{
    public partial class FrmCrearUsuarios : Form
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

        public FrmCrearUsuarios()
        {
            InitializeComponent();
           
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

       

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblName_Click(object sender, EventArgs e)
        {

        }

       
    }
}
