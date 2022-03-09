
namespace _404_App.Formularios
{
    partial class GenerarReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarReporte));
            this.PnShow = new System.Windows.Forms.Panel();
            this.BtnVentas = new Guna.UI.WinForms.GunaButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.PnShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnShow
            // 
            this.PnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.PnShow.Controls.Add(this.LblTitle);
            this.PnShow.Controls.Add(this.BtnVentas);
            this.PnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnShow.Location = new System.Drawing.Point(0, 0);
            this.PnShow.Name = "PnShow";
            this.PnShow.Size = new System.Drawing.Size(1100, 781);
            this.PnShow.TabIndex = 3;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Animated = true;
            this.BtnVentas.AnimationHoverSpeed = 0.07F;
            this.BtnVentas.AnimationSpeed = 0.03F;
            this.BtnVentas.BackColor = System.Drawing.Color.Transparent;
            this.BtnVentas.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.BtnVentas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.BtnVentas.BorderSize = 3;
            this.BtnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnVentas.FocusedColor = System.Drawing.Color.Empty;
            this.BtnVentas.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.Color.Black;
            this.BtnVentas.Image = global::_404_App.Properties.Resources.icons8_fast_cart_48px_3;
            this.BtnVentas.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnVentas.Location = new System.Drawing.Point(425, 120);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnVentas.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnVentas.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnVentas.OnHoverImage = null;
            this.BtnVentas.OnPressedColor = System.Drawing.Color.Black;
            this.BtnVentas.Radius = 10;
            this.BtnVentas.Size = new System.Drawing.Size(232, 66);
            this.BtnVentas.TabIndex = 1;
            this.BtnVentas.Text = "Ventas";
            this.BtnVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(410, 28);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(238, 23);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Generar Reporte";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 781);
            this.Controls.Add(this.PnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarReporte";
            this.PnShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnShow;
        private Guna.UI.WinForms.GunaButton BtnVentas;
        private System.Windows.Forms.Label LblTitle;
    }
}