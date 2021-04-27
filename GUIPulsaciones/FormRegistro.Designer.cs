
namespace GUIPulsaciones
{
    partial class FormRegistro
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.LblIdentificacion = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblEdad = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.LblPulsaciones = new System.Windows.Forms.Label();
            this.TxtIdentificacion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtPulsaciones = new System.Windows.Forms.TextBox();
            this.CmbSexo = new System.Windows.Forms.ComboBox();
            this.BtnCalcularGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProviderRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).BeginInit();
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
            this.panelTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(708, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(121, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "REGISTRO";
            // 
            // LblIdentificacion
            // 
            this.LblIdentificacion.AutoSize = true;
            this.LblIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblIdentificacion.Location = new System.Drawing.Point(566, 78);
            this.LblIdentificacion.Name = "LblIdentificacion";
            this.LblIdentificacion.Size = new System.Drawing.Size(121, 19);
            this.LblIdentificacion.TabIndex = 1;
            this.LblIdentificacion.Text = "Identificación";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblNombre.Location = new System.Drawing.Point(611, 115);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(76, 19);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // LblEdad
            // 
            this.LblEdad.AutoSize = true;
            this.LblEdad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblEdad.Location = new System.Drawing.Point(636, 153);
            this.LblEdad.Name = "LblEdad";
            this.LblEdad.Size = new System.Drawing.Size(51, 19);
            this.LblEdad.TabIndex = 3;
            this.LblEdad.Text = "Edad";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSexo.Location = new System.Drawing.Point(637, 197);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(50, 19);
            this.LblSexo.TabIndex = 4;
            this.LblSexo.Text = "Sexo";
            // 
            // LblPulsaciones
            // 
            this.LblPulsaciones.AutoSize = true;
            this.LblPulsaciones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblPulsaciones.Location = new System.Drawing.Point(562, 560);
            this.LblPulsaciones.Name = "LblPulsaciones";
            this.LblPulsaciones.Size = new System.Drawing.Size(107, 19);
            this.LblPulsaciones.TabIndex = 5;
            this.LblPulsaciones.Text = "Pulsaciones";
            // 
            // TxtIdentificacion
            // 
            this.TxtIdentificacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdentificacion.Location = new System.Drawing.Point(704, 74);
            this.TxtIdentificacion.Name = "TxtIdentificacion";
            this.TxtIdentificacion.Size = new System.Drawing.Size(193, 28);
            this.TxtIdentificacion.TabIndex = 6;
            this.TxtIdentificacion.Validating += new System.ComponentModel.CancelEventHandler(this.TxtIdentificacion_Validating);
            this.TxtIdentificacion.Validated += new System.EventHandler(this.TxtIdentificacion_Validated);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(704, 111);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(193, 28);
            this.TxtNombre.TabIndex = 7;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEdad.Location = new System.Drawing.Point(704, 149);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(193, 28);
            this.TxtEdad.TabIndex = 8;
            this.TxtEdad.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEdad_Validating);
            this.TxtEdad.Validated += new System.EventHandler(this.TxtEdad_Validated);
            // 
            // TxtPulsaciones
            // 
            this.TxtPulsaciones.Enabled = false;
            this.TxtPulsaciones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPulsaciones.Location = new System.Drawing.Point(704, 556);
            this.TxtPulsaciones.Name = "TxtPulsaciones";
            this.TxtPulsaciones.Size = new System.Drawing.Size(193, 28);
            this.TxtPulsaciones.TabIndex = 9;
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
            this.CmbSexo.Location = new System.Drawing.Point(704, 193);
            this.CmbSexo.Name = "CmbSexo";
            this.CmbSexo.Size = new System.Drawing.Size(193, 29);
            this.CmbSexo.TabIndex = 10;
            // 
            // BtnCalcularGuardar
            // 
            this.BtnCalcularGuardar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCalcularGuardar.Location = new System.Drawing.Point(704, 253);
            this.BtnCalcularGuardar.Name = "BtnCalcularGuardar";
            this.BtnCalcularGuardar.Size = new System.Drawing.Size(193, 40);
            this.BtnCalcularGuardar.TabIndex = 11;
            this.BtnCalcularGuardar.Text = "Calcular y Guardar";
            this.BtnCalcularGuardar.UseVisualStyleBackColor = true;
            this.BtnCalcularGuardar.Click += new System.EventHandler(this.BtnCalcularGuardar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(704, 616);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // errorProviderRegistro
            // 
            this.errorProviderRegistro.ContainerControl = this;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 877);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnCalcularGuardar);
            this.Controls.Add(this.CmbSexo);
            this.Controls.Add(this.TxtPulsaciones);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtIdentificacion);
            this.Controls.Add(this.LblPulsaciones);
            this.Controls.Add(this.LblSexo);
            this.Controls.Add(this.LblEdad);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblIdentificacion);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistro";
            this.Text = "FormRegistro";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label LblIdentificacion;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblEdad;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.Label LblPulsaciones;
        private System.Windows.Forms.TextBox TxtIdentificacion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtPulsaciones;
        private System.Windows.Forms.ComboBox CmbSexo;
        private System.Windows.Forms.Button BtnCalcularGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProviderRegistro;
    }
}