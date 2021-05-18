
namespace FormCantina
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.cmb_TipoBotella = new System.Windows.Forms.ComboBox();
            this.num_Contenido = new System.Windows.Forms.NumericUpDown();
            this.num_Capacidad = new System.Windows.Forms.NumericUpDown();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.rdn_Agua = new System.Windows.Forms.RadioButton();
            this.rdn_Cerveza = new System.Windows.Forms.RadioButton();
            this.lbl_Contenido = new System.Windows.Forms.Label();
            this.lbl_Capacidad = new System.Windows.Forms.Label();
            this.lbl_BotellaTipo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Contenido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Capacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(643, 374);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 39);
            this.btn_Agregar.TabIndex = 21;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // cmb_TipoBotella
            // 
            this.cmb_TipoBotella.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoBotella.FormattingEnabled = true;
            this.cmb_TipoBotella.Location = new System.Drawing.Point(463, 385);
            this.cmb_TipoBotella.Name = "cmb_TipoBotella";
            this.cmb_TipoBotella.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoBotella.TabIndex = 20;
            this.cmb_TipoBotella.SelectedIndexChanged += new System.EventHandler(this.cmb_TipoBotella_SelectedIndexChanged);
            // 
            // num_Contenido
            // 
            this.num_Contenido.Location = new System.Drawing.Point(391, 337);
            this.num_Contenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_Contenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Contenido.Name = "num_Contenido";
            this.num_Contenido.Size = new System.Drawing.Size(120, 20);
            this.num_Contenido.TabIndex = 19;
            this.num_Contenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // num_Capacidad
            // 
            this.num_Capacidad.Location = new System.Drawing.Point(226, 386);
            this.num_Capacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.num_Capacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Capacidad.Name = "num_Capacidad";
            this.num_Capacidad.Size = new System.Drawing.Size(120, 20);
            this.num_Capacidad.TabIndex = 18;
            this.num_Capacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(226, 334);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(100, 20);
            this.txt_Marca.TabIndex = 17;
            // 
            // rdn_Agua
            // 
            this.rdn_Agua.AutoSize = true;
            this.rdn_Agua.Location = new System.Drawing.Point(41, 385);
            this.rdn_Agua.Name = "rdn_Agua";
            this.rdn_Agua.Size = new System.Drawing.Size(50, 17);
            this.rdn_Agua.TabIndex = 16;
            this.rdn_Agua.TabStop = true;
            this.rdn_Agua.Text = "Agua";
            this.rdn_Agua.UseVisualStyleBackColor = true;
            // 
            // rdn_Cerveza
            // 
            this.rdn_Cerveza.AutoSize = true;
            this.rdn_Cerveza.Location = new System.Drawing.Point(41, 337);
            this.rdn_Cerveza.Name = "rdn_Cerveza";
            this.rdn_Cerveza.Size = new System.Drawing.Size(64, 17);
            this.rdn_Cerveza.TabIndex = 15;
            this.rdn_Cerveza.TabStop = true;
            this.rdn_Cerveza.Text = "Cerveza";
            this.rdn_Cerveza.UseVisualStyleBackColor = true;
            // 
            // lbl_Contenido
            // 
            this.lbl_Contenido.AutoSize = true;
            this.lbl_Contenido.Location = new System.Drawing.Point(391, 320);
            this.lbl_Contenido.Name = "lbl_Contenido";
            this.lbl_Contenido.Size = new System.Drawing.Size(55, 13);
            this.lbl_Contenido.TabIndex = 14;
            this.lbl_Contenido.Text = "Contenido";
            // 
            // lbl_Capacidad
            // 
            this.lbl_Capacidad.AutoSize = true;
            this.lbl_Capacidad.Location = new System.Drawing.Point(223, 369);
            this.lbl_Capacidad.Name = "lbl_Capacidad";
            this.lbl_Capacidad.Size = new System.Drawing.Size(58, 13);
            this.lbl_Capacidad.TabIndex = 13;
            this.lbl_Capacidad.Text = "Capacidad";
            // 
            // lbl_BotellaTipo
            // 
            this.lbl_BotellaTipo.AutoSize = true;
            this.lbl_BotellaTipo.Location = new System.Drawing.Point(391, 388);
            this.lbl_BotellaTipo.Name = "lbl_BotellaTipo";
            this.lbl_BotellaTipo.Size = new System.Drawing.Size(63, 13);
            this.lbl_BotellaTipo.TabIndex = 12;
            this.lbl_BotellaTipo.Text = "Botella Tipo";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(223, 317);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 11;
            this.lbl_Marca.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cmb_TipoBotella);
            this.Controls.Add(this.num_Contenido);
            this.Controls.Add(this.num_Capacidad);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.rdn_Agua);
            this.Controls.Add(this.rdn_Cerveza);
            this.Controls.Add(this.lbl_Contenido);
            this.Controls.Add(this.lbl_Capacidad);
            this.Controls.Add(this.lbl_BotellaTipo);
            this.Controls.Add(this.lbl_Marca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Contenido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Capacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.ComboBox cmb_TipoBotella;
        private System.Windows.Forms.NumericUpDown num_Contenido;
        private System.Windows.Forms.NumericUpDown num_Capacidad;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.RadioButton rdn_Agua;
        private System.Windows.Forms.RadioButton rdn_Cerveza;
        private System.Windows.Forms.Label lbl_Contenido;
        private System.Windows.Forms.Label lbl_Capacidad;
        private System.Windows.Forms.Label lbl_BotellaTipo;
        private System.Windows.Forms.Label lbl_Marca;
    }
}

