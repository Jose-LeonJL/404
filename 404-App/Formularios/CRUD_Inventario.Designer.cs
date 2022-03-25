
namespace _404_App.Formularios
{
    partial class CRUD_Inventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnShow = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new Guna.UI2.WinForms.Guna2TextBox();
            this.LblUserNickName = new System.Windows.Forms.Label();
            this.tabla = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnReporte = new Guna.UI.WinForms.GunaButton();
            this.BtnEliminar = new Guna.UI.WinForms.GunaButton();
            this.BtnActualizar = new Guna.UI.WinForms.GunaButton();
            this.BtnCrear = new Guna.UI.WinForms.GunaButton();
            this.PnShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // PnShow
            // 
            this.PnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.PnShow.Controls.Add(this.pictureBox1);
            this.PnShow.Controls.Add(this.txtbuscar);
            this.PnShow.Controls.Add(this.LblUserNickName);
            this.PnShow.Controls.Add(this.tabla);
            this.PnShow.Controls.Add(this.BtnReporte);
            this.PnShow.Controls.Add(this.BtnEliminar);
            this.PnShow.Controls.Add(this.BtnActualizar);
            this.PnShow.Controls.Add(this.BtnCrear);
            this.PnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.PnShow.Location = new System.Drawing.Point(0, 0);
            this.PnShow.Name = "PnShow";
            this.PnShow.Size = new System.Drawing.Size(1100, 740);
            this.PnShow.TabIndex = 3;
            this.PnShow.Paint += new System.Windows.Forms.PaintEventHandler(this.PnShow_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::_404_App.Properties.Resources.icons8_search_100px;
            this.pictureBox1.Location = new System.Drawing.Point(1032, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Animated = true;
            this.txtbuscar.BorderThickness = 3;
            this.txtbuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbuscar.DefaultText = "Buscar";
            this.txtbuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbuscar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(122)))), ((int)(((byte)(131)))));
            this.txtbuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbuscar.Location = new System.Drawing.Point(797, 110);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.PasswordChar = '\0';
            this.txtbuscar.PlaceholderText = "";
            this.txtbuscar.SelectedText = "";
            this.txtbuscar.Size = new System.Drawing.Size(229, 43);
            this.txtbuscar.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtbuscar.TabIndex = 10;
            this.txtbuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblUserNickName
            // 
            this.LblUserNickName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserNickName.ForeColor = System.Drawing.Color.Black;
            this.LblUserNickName.Location = new System.Drawing.Point(408, 31);
            this.LblUserNickName.Name = "LblUserNickName";
            this.LblUserNickName.Size = new System.Drawing.Size(238, 23);
            this.LblUserNickName.TabIndex = 8;
            this.LblUserNickName.Text = "Inventario";
            this.LblUserNickName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabla
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla.EnableHeadersVisualStyles = false;
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla.Location = new System.Drawing.Point(12, 185);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersVisible = false;
            this.tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla.Size = new System.Drawing.Size(1074, 486);
            this.tabla.TabIndex = 7;
            this.tabla.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tabla.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabla.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabla.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabla.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabla.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.tabla.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tabla.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabla.ThemeStyle.HeaderStyle.Height = 23;
            this.tabla.ThemeStyle.ReadOnly = false;
            this.tabla.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tabla.ThemeStyle.RowsStyle.Height = 22;
            this.tabla.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            // 
            // BtnReporte
            // 
            this.BtnReporte.Animated = true;
            this.BtnReporte.AnimationHoverSpeed = 0.07F;
            this.BtnReporte.AnimationSpeed = 0.03F;
            this.BtnReporte.BackColor = System.Drawing.Color.Transparent;
            this.BtnReporte.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(181)))), ((int)(((byte)(189)))));
            this.BtnReporte.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.BtnReporte.BorderSize = 3;
            this.BtnReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReporte.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnReporte.FocusedColor = System.Drawing.Color.Empty;
            this.BtnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.ForeColor = System.Drawing.Color.Black;
            this.BtnReporte.Image = null;
            this.BtnReporte.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnReporte.Location = new System.Drawing.Point(915, 713);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnReporte.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnReporte.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnReporte.OnHoverImage = null;
            this.BtnReporte.OnPressedColor = System.Drawing.Color.Black;
            this.BtnReporte.Radius = 10;
            this.BtnReporte.Size = new System.Drawing.Size(171, 56);
            this.BtnReporte.TabIndex = 6;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Animated = true;
            this.BtnEliminar.AnimationHoverSpeed = 0.07F;
            this.BtnEliminar.AnimationSpeed = 0.03F;
            this.BtnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.BtnEliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnEliminar.BorderSize = 3;
            this.BtnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEliminar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminar.Image = null;
            this.BtnEliminar.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnEliminar.Location = new System.Drawing.Point(614, 713);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnEliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnEliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnEliminar.OnHoverImage = null;
            this.BtnEliminar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnEliminar.Radius = 10;
            this.BtnEliminar.Size = new System.Drawing.Size(171, 56);
            this.BtnEliminar.TabIndex = 5;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Animated = true;
            this.BtnActualizar.AnimationHoverSpeed = 0.07F;
            this.BtnActualizar.AnimationSpeed = 0.03F;
            this.BtnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.BtnActualizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.BtnActualizar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(59)))), ((int)(((byte)(62)))));
            this.BtnActualizar.BorderSize = 3;
            this.BtnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActualizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnActualizar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizar.Image = null;
            this.BtnActualizar.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnActualizar.Location = new System.Drawing.Point(313, 713);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnActualizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnActualizar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnActualizar.OnHoverImage = null;
            this.BtnActualizar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnActualizar.Radius = 10;
            this.BtnActualizar.Size = new System.Drawing.Size(171, 56);
            this.BtnActualizar.TabIndex = 4;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnCrear.Location = new System.Drawing.Point(12, 713);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCrear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCrear.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCrear.OnHoverImage = null;
            this.BtnCrear.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCrear.Radius = 10;
            this.BtnCrear.Size = new System.Drawing.Size(171, 56);
            this.BtnCrear.TabIndex = 3;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CRUD_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 740);
            this.Controls.Add(this.PnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD_Inventario";
            this.Text = "CRUD";
            this.PnShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnShow;
        private Guna.UI.WinForms.GunaDataGridView tabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private Guna.UI.WinForms.GunaButton BtnReporte;
        private Guna.UI.WinForms.GunaButton BtnEliminar;
        private Guna.UI.WinForms.GunaButton BtnActualizar;
        private Guna.UI.WinForms.GunaButton BtnCrear;
        private System.Windows.Forms.Label LblUserNickName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtbuscar;
    }
}