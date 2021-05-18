
namespace ControlesUsuario
{
    partial class FormBarra
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
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_TipoBotella = new System.Windows.Forms.Label();
            this.lbl_Capacidad = new System.Windows.Forms.Label();
            this.lbl_Contenido = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.cmb_TipoBotella = new System.Windows.Forms.ComboBox();
            this.num_Capacidad = new System.Windows.Forms.NumericUpDown();
            this.num_Contenido = new System.Windows.Forms.NumericUpDown();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.radio_Cerveza = new System.Windows.Forms.RadioButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.num_Capacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Contenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marca.Location = new System.Drawing.Point(226, 274);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(62, 24);
            this.lbl_Marca.TabIndex = 0;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_TipoBotella
            // 
            this.lbl_TipoBotella.AutoSize = true;
            this.lbl_TipoBotella.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TipoBotella.Location = new System.Drawing.Point(442, 274);
            this.lbl_TipoBotella.Name = "lbl_TipoBotella";
            this.lbl_TipoBotella.Size = new System.Drawing.Size(109, 24);
            this.lbl_TipoBotella.TabIndex = 1;
            this.lbl_TipoBotella.Text = "Botella Tipo";
            // 
            // lbl_Capacidad
            // 
            this.lbl_Capacidad.AutoSize = true;
            this.lbl_Capacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capacidad.Location = new System.Drawing.Point(226, 346);
            this.lbl_Capacidad.Name = "lbl_Capacidad";
            this.lbl_Capacidad.Size = new System.Drawing.Size(100, 24);
            this.lbl_Capacidad.TabIndex = 2;
            this.lbl_Capacidad.Text = "Capacidad";
            // 
            // lbl_Contenido
            // 
            this.lbl_Contenido.AutoSize = true;
            this.lbl_Contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contenido.Location = new System.Drawing.Point(454, 346);
            this.lbl_Contenido.Name = "lbl_Contenido";
            this.lbl_Contenido.Size = new System.Drawing.Size(97, 24);
            this.lbl_Contenido.TabIndex = 3;
            this.lbl_Contenido.Text = "Contenido";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(230, 301);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(100, 20);
            this.txt_Marca.TabIndex = 4;
            // 
            // cmb_TipoBotella
            // 
            this.cmb_TipoBotella.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TipoBotella.FormattingEnabled = true;
            this.cmb_TipoBotella.Location = new System.Drawing.Point(446, 299);
            this.cmb_TipoBotella.Name = "cmb_TipoBotella";
            this.cmb_TipoBotella.Size = new System.Drawing.Size(121, 21);
            this.cmb_TipoBotella.TabIndex = 5;
            // 
            // num_Capacidad
            // 
            this.num_Capacidad.Location = new System.Drawing.Point(230, 373);
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
            this.num_Capacidad.Size = new System.Drawing.Size(96, 20);
            this.num_Capacidad.TabIndex = 6;
            this.num_Capacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // num_Contenido
            // 
            this.num_Contenido.Location = new System.Drawing.Point(458, 373);
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
            this.num_Contenido.Size = new System.Drawing.Size(96, 20);
            this.num_Contenido.TabIndex = 7;
            this.num_Contenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(653, 384);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(95, 40);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // radio_Cerveza
            // 
            this.radio_Cerveza.AutoSize = true;
            this.radio_Cerveza.Location = new System.Drawing.Point(47, 304);
            this.radio_Cerveza.Name = "radio_Cerveza";
            this.radio_Cerveza.Size = new System.Drawing.Size(64, 17);
            this.radio_Cerveza.TabIndex = 9;
            this.radio_Cerveza.TabStop = true;
            this.radio_Cerveza.Text = "Cerveza";
            this.radio_Cerveza.UseVisualStyleBackColor = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(191, 230);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 10;
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(47, 353);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 11;
            this.radioAgua.TabStop = true;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            // 
            // FormBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioAgua);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.radio_Cerveza);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.num_Contenido);
            this.Controls.Add(this.num_Capacidad);
            this.Controls.Add(this.cmb_TipoBotella);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.lbl_Contenido);
            this.Controls.Add(this.lbl_Capacidad);
            this.Controls.Add(this.lbl_TipoBotella);
            this.Controls.Add(this.lbl_Marca);
            this.Name = "FormBarra";
            this.Text = "Denise Barra";
            this.Load += new System.EventHandler(this.FormBarra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Capacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Contenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_TipoBotella;
        private System.Windows.Forms.Label lbl_Capacidad;
        private System.Windows.Forms.Label lbl_Contenido;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.ComboBox cmb_TipoBotella;
        private System.Windows.Forms.NumericUpDown num_Capacidad;
        private System.Windows.Forms.NumericUpDown num_Contenido;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.RadioButton radio_Cerveza;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.RadioButton radioAgua;
    }
}