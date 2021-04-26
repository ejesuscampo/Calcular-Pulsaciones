
namespace GUIPulsaciones
{
    partial class FormConsulta
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.TblDatos = new System.Windows.Forms.DataGridView();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1764, 50);
            this.panelTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(701, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(135, 28);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "CONSULTA";
            // 
            // TblDatos
            // 
            this.TblDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TblDatos.Location = new System.Drawing.Point(318, 164);
            this.TblDatos.Name = "TblDatos";
            this.TblDatos.RowHeadersWidth = 51;
            this.TblDatos.RowTemplate.Height = 24;
            this.TblDatos.Size = new System.Drawing.Size(914, 606);
            this.TblDatos.TabIndex = 2;
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbFiltro.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Femenino",
            "Masculino"});
            this.CmbFiltro.Location = new System.Drawing.Point(496, 89);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(193, 29);
            this.CmbFiltro.TabIndex = 11;
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblIdentificacion.Location = new System.Drawing.Point(419, 93);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(50, 19);
            this.LblIdentificacion.TabIndex = 12;
            this.LblIdentificacion.Text = "Filtrar";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(745, 91);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 27);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "Buscar\r\n";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 877);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.LblIdentificacion);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.TblDatos);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView TblDatos;
        private System.Windows.Forms.ComboBox CmbFiltro;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.Button BtnBuscar;
    }
}