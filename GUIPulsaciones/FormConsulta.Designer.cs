
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(914, 606);
            this.dataGridView1.TabIndex = 2;
            // 
            // CmbSexo
            // 
            this.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbSexo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbSexo.FormattingEnabled = true;
            this.CmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.CmbSexo.Location = new System.Drawing.Point(496, 89);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(193, 29);
            this.CmbSexo.TabIndex = 11;
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
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 877);
            this.Controls.Add(this.LblIdentificacion);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsulta";
            this.Text = "FormConsulta";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Label LblIdentificacion;
    }
}