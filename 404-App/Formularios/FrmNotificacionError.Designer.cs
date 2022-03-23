
namespace _404_App.Formularios
{
    partial class FrmNotificacionError
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
            this.components = new System.ComponentModel.Container();
            this.LblError = new System.Windows.Forms.Label();
            this.GunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ProgresBar = new Guna.UI.WinForms.GunaProgressBar();
            this.TimerUpdateBar = new System.Windows.Forms.Timer(this.components);
            this.TimerOpenForm = new System.Windows.Forms.Timer(this.components);
            this.GunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblError
            // 
            this.LblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblError.Location = new System.Drawing.Point(110, 12);
            this.LblError.Name = "LblError";
            this.LblError.Size = new System.Drawing.Size(397, 82);
            this.LblError.TabIndex = 1;
            this.LblError.Text = "...";
            this.LblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GunaPanel1
            // 
            this.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(122)))), ((int)(((byte)(7)))));
            this.GunaPanel1.Controls.Add(this.iconPictureBox2);
            this.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.GunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.GunaPanel1.Name = "GunaPanel1";
            this.GunaPanel1.Size = new System.Drawing.Size(90, 103);
            this.GunaPanel1.TabIndex = 7;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(122)))), ((int)(((byte)(7)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 80;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 12);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Padding = new System.Windows.Forms.Padding(1, 4, 0, 0);
            this.iconPictureBox2.Size = new System.Drawing.Size(80, 82);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(513, 33);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            this.iconPictureBox1.MouseLeave += new System.EventHandler(this.iconPictureBox1_MouseLeave);
            this.iconPictureBox1.MouseHover += new System.EventHandler(this.iconPictureBox1_MouseHover);
            // 
            // ProgresBar
            // 
            this.ProgresBar.BorderColor = System.Drawing.Color.Black;
            this.ProgresBar.ColorStyle = Guna.UI.WinForms.ColorStyle.Transition;
            this.ProgresBar.IdleColor = System.Drawing.Color.Gainsboro;
            this.ProgresBar.Location = new System.Drawing.Point(90, 95);
            this.ProgresBar.Maximum = 5;
            this.ProgresBar.Name = "ProgresBar";
            this.ProgresBar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(122)))), ((int)(((byte)(7)))));
            this.ProgresBar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.ProgresBar.Size = new System.Drawing.Size(478, 5);
            this.ProgresBar.TabIndex = 9;
            // 
            // TimerUpdateBar
            // 
            this.TimerUpdateBar.Interval = 1000;
            this.TimerUpdateBar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerOpenForm
            // 
            this.TimerOpenForm.Interval = 1;
            this.TimerOpenForm.Tick += new System.EventHandler(this.TimerOpenForm_Tick);
            // 
            // FrmNotificacionError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 103);
            this.Controls.Add(this.ProgresBar);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.GunaPanel1);
            this.Controls.Add(this.LblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNotificacionError";
            this.Text = "FrmNotificacionError";
            this.GunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblError;
        internal Guna.UI.WinForms.GunaPanel GunaPanel1;
        internal FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        internal FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        internal Guna.UI.WinForms.GunaProgressBar ProgresBar;
        private System.Windows.Forms.Timer TimerUpdateBar;
        private System.Windows.Forms.Timer TimerOpenForm;
    }
}