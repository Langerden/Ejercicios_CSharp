
namespace MiniSupermercado
{
    partial class AltaUsuario
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lvlDNI = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.numDni = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.chkTarjeta = new System.Windows.Forms.CheckBox();
            this.chkEfectivo = new System.Windows.Forms.CheckBox();
            this.panelFormasPago = new System.Windows.Forms.Panel();
            this.goupBoxMediosDePago = new System.Windows.Forms.GroupBox();
            this.optEfectivo = new System.Windows.Forms.RadioButton();
            this.optTarjeta = new System.Windows.Forms.RadioButton();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).BeginInit();
            this.goupBoxMediosDePago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 49);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(37, 83);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lvlDNI
            // 
            this.lvlDNI.AutoSize = true;
            this.lvlDNI.Location = new System.Drawing.Point(37, 110);
            this.lvlDNI.Name = "lvlDNI";
            this.lvlDNI.Size = new System.Drawing.Size(26, 13);
            this.lvlDNI.TabIndex = 2;
            this.lvlDNI.Text = "DNI";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(130, 76);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // numDni
            // 
            this.numDni.Location = new System.Drawing.Point(130, 110);
            this.numDni.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDni.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDni.Name = "numDni";
            this.numDni.Size = new System.Drawing.Size(120, 20);
            this.numDni.TabIndex = 5;
            this.numDni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDni.ValueChanged += new System.EventHandler(this.numDni_ValueChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(259, 346);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(105, 30);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(37, 150);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(64, 13);
            this.lblFormaPago.TabIndex = 7;
            this.lblFormaPago.Text = "Forma Pago";
            this.lblFormaPago.Click += new System.EventHandler(this.lblFormaPago_Click);
            // 
            // chkTarjeta
            // 
            this.chkTarjeta.AutoSize = true;
            this.chkTarjeta.Location = new System.Drawing.Point(139, 149);
            this.chkTarjeta.Name = "chkTarjeta";
            this.chkTarjeta.Size = new System.Drawing.Size(59, 17);
            this.chkTarjeta.TabIndex = 8;
            this.chkTarjeta.Text = "Tarjeta";
            this.chkTarjeta.UseVisualStyleBackColor = true;
            this.chkTarjeta.CheckedChanged += new System.EventHandler(this.chkTarjeta_CheckedChanged);
            // 
            // chkEfectivo
            // 
            this.chkEfectivo.AutoSize = true;
            this.chkEfectivo.Location = new System.Drawing.Point(222, 149);
            this.chkEfectivo.Name = "chkEfectivo";
            this.chkEfectivo.Size = new System.Drawing.Size(65, 17);
            this.chkEfectivo.TabIndex = 9;
            this.chkEfectivo.Text = "Efectivo";
            this.chkEfectivo.UseVisualStyleBackColor = true;
            this.chkEfectivo.CheckedChanged += new System.EventHandler(this.chkEfectivo_CheckedChanged);
            // 
            // panelFormasPago
            // 
            this.panelFormasPago.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelFormasPago.Location = new System.Drawing.Point(130, 136);
            this.panelFormasPago.Name = "panelFormasPago";
            this.panelFormasPago.Size = new System.Drawing.Size(186, 49);
            this.panelFormasPago.TabIndex = 10;
            this.panelFormasPago.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormasPago_Paint);
            // 
            // goupBoxMediosDePago
            // 
            this.goupBoxMediosDePago.Controls.Add(this.optTarjeta);
            this.goupBoxMediosDePago.Controls.Add(this.optEfectivo);
            this.goupBoxMediosDePago.Location = new System.Drawing.Point(42, 209);
            this.goupBoxMediosDePago.Name = "goupBoxMediosDePago";
            this.goupBoxMediosDePago.Size = new System.Drawing.Size(244, 55);
            this.goupBoxMediosDePago.TabIndex = 11;
            this.goupBoxMediosDePago.TabStop = false;
            this.goupBoxMediosDePago.Text = "Medio de Pago";
            this.goupBoxMediosDePago.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // optEfectivo
            // 
            this.optEfectivo.AutoSize = true;
            this.optEfectivo.Location = new System.Drawing.Point(6, 32);
            this.optEfectivo.Name = "optEfectivo";
            this.optEfectivo.Size = new System.Drawing.Size(64, 17);
            this.optEfectivo.TabIndex = 0;
            this.optEfectivo.TabStop = true;
            this.optEfectivo.Text = "Efectivo";
            this.optEfectivo.UseVisualStyleBackColor = true;
            this.optEfectivo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // optTarjeta
            // 
            this.optTarjeta.AutoSize = true;
            this.optTarjeta.Location = new System.Drawing.Point(97, 32);
            this.optTarjeta.Name = "optTarjeta";
            this.optTarjeta.Size = new System.Drawing.Size(58, 17);
            this.optTarjeta.TabIndex = 1;
            this.optTarjeta.TabStop = true;
            this.optTarjeta.Text = "Tarjeta";
            this.optTarjeta.UseVisualStyleBackColor = true;
            this.optTarjeta.CheckedChanged += new System.EventHandler(this.optTarjeta_CheckedChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(40, 288);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 12;
            this.lblProvincia.Text = "Provincia";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Items.AddRange(new object[] {
            "Buenos Aires",
            "CABA",
            "Santiago del Estero",
            "Jujuy"});
            this.cmbProvincia.Location = new System.Drawing.Point(118, 285);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 13;
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // AltaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(462, 450);
            this.Controls.Add(this.cmbProvincia);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.goupBoxMediosDePago);
            this.Controls.Add(this.chkEfectivo);
            this.Controls.Add(this.chkTarjeta);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.numDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lvlDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panelFormasPago);
            this.Name = "AltaUsuario";
            this.Text = "AltaUsuario";
            this.Load += new System.EventHandler(this.AltaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDni)).EndInit();
            this.goupBoxMediosDePago.ResumeLayout(false);
            this.goupBoxMediosDePago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lvlDNI;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown numDni;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFormaPago;
        private System.Windows.Forms.CheckBox chkTarjeta;
        private System.Windows.Forms.CheckBox chkEfectivo;
        private System.Windows.Forms.Panel panelFormasPago;
        private System.Windows.Forms.GroupBox goupBoxMediosDePago;
        private System.Windows.Forms.RadioButton optEfectivo;
        private System.Windows.Forms.RadioButton optTarjeta;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbProvincia;
    }
}