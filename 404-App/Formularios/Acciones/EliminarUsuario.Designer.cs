namespace _404_App.Formularios.Acciones
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrear = new Guna.UI.WinForms.GunaButton();
            this.BtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estas Seguro De Eliminar\r\n           el Usuario?";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Animated = true;
            this.BtnCrear.AnimationHoverSpeed = 0.07F;
            this.BtnCrear.AnimationSpeed = 0.03F;
            this.BtnCrear.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(158)))), ((int)(((byte)(57)))));
            this.BtnCrear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(105)))), ((int)(((byte)(38)))));
            this.BtnCrear.BorderSize = 3;
            this.BtnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCrear.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.Black;
            this.BtnCrear.Image = null;
            this.BtnCrear.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnCrear.Location = new System.Drawing.Point(12, 184);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCrear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCrear.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCrear.OnHoverImage = null;
            this.BtnCrear.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCrear.Radius = 10;
            this.BtnCrear.Size = new System.Drawing.Size(116, 51);
            this.BtnCrear.TabIndex = 21;
            this.BtnCrear.Text = "Aceptar";
            this.BtnCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Animated = true;
            this.BtnCancelar.AnimationHoverSpeed = 0.07F;
            this.BtnCancelar.AnimationSpeed = 0.03F;
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.BtnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnCancelar.BorderSize = 3;
            this.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelar.Image = null;
            this.BtnCancelar.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnCancelar.Location = new System.Drawing.Point(230, 184);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnHoverImage = null;
            this.BtnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCancelar.Radius = 10;
            this.BtnCancelar.Size = new System.Drawing.Size(126, 56);
            this.BtnCancelar.TabIndex = 22;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(174)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(378, 265);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton BtnCrear;
        private Guna.UI.WinForms.GunaButton BtnCancelar;
    }
}