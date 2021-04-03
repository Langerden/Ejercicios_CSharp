
namespace Ejercicio_23
{
    partial class ConversorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorForm));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.Lock = new System.Windows.Forms.ImageList(this.components);
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.lblEuro2 = new System.Windows.Forms.Label();
            this.lblPeso2 = new System.Windows.Forms.Label();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.txtEuroEuro = new System.Windows.Forms.TextBox();
            this.txtEuroDolar = new System.Windows.Forms.TextBox();
            this.txtEuroPeso = new System.Windows.Forms.TextBox();
            this.txtDolarEuro = new System.Windows.Forms.TextBox();
            this.txtPesoEuro = new System.Windows.Forms.TextBox();
            this.txtPesoDolar = new System.Windows.Forms.TextBox();
            this.txtDolarDolar = new System.Windows.Forms.TextBox();
            this.txtPesoPeso = new System.Windows.Forms.TextBox();
            this.txtDolarPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCotizacion.Location = new System.Drawing.Point(82, 60);
            this.lblCotizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(115, 27);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEuro.Location = new System.Drawing.Point(54, 206);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(49, 22);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDolar.Location = new System.Drawing.Point(54, 272);
            this.lblDolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(54, 22);
            this.lblDolar.TabIndex = 2;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPeso.Location = new System.Drawing.Point(54, 338);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(51, 22);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso";
            // 
            // txtEuro
            // 
            this.txtEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtEuro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEuro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEuro.Location = new System.Drawing.Point(170, 206);
            this.txtEuro.Margin = new System.Windows.Forms.Padding(4);
            this.txtEuro.Multiline = true;
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(139, 28);
            this.txtEuro.TabIndex = 4;
            this.txtEuro.MouseLeave += new System.EventHandler(this.txtEuro_MouseLeave);
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnCotizar.ImageKey = "bloqueado (1).png";
            this.btnCotizar.ImageList = this.Lock;
            this.btnCotizar.Location = new System.Drawing.Point(271, 54);
            this.btnCotizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(89, 33);
            this.btnCotizar.TabIndex = 5;
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // Lock
            // 
            this.Lock.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Lock.ImageStream")));
            this.Lock.TransparentColor = System.Drawing.Color.Transparent;
            this.Lock.Images.SetKeyName(0, "bloqueado (1).png");
            this.Lock.Images.SetKeyName(1, "bloqueado.png");
            // 
            // txtDolar
            // 
            this.txtDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDolar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDolar.Location = new System.Drawing.Point(170, 272);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolar.Multiline = true;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(139, 28);
            this.txtDolar.TabIndex = 6;
            this.txtDolar.MouseLeave += new System.EventHandler(this.txtDolar_MouseLeave);
            // 
            // txtPeso
            // 
            this.txtPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPeso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPeso.Location = new System.Drawing.Point(170, 338);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(139, 25);
            this.txtPeso.TabIndex = 7;
            this.txtPeso.MouseLeave += new System.EventHandler(this.txtPeso_MouseLeave);
            // 
            // btnEuro
            // 
            this.btnEuro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEuro.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEuro.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnEuro.Location = new System.Drawing.Point(341, 206);
            this.btnEuro.Margin = new System.Windows.Forms.Padding(4);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(68, 30);
            this.btnEuro.TabIndex = 8;
            this.btnEuro.Text = "->";
            this.btnEuro.UseVisualStyleBackColor = false;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDolar.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDolar.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDolar.Location = new System.Drawing.Point(341, 272);
            this.btnDolar.Margin = new System.Windows.Forms.Padding(4);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(68, 30);
            this.btnDolar.TabIndex = 11;
            this.btnDolar.Text = "->";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPeso.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeso.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnPeso.Location = new System.Drawing.Point(341, 336);
            this.btnPeso.Margin = new System.Windows.Forms.Padding(4);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(68, 30);
            this.btnPeso.TabIndex = 12;
            this.btnPeso.Text = "->";
            this.btnPeso.UseVisualStyleBackColor = false;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // lblEuro2
            // 
            this.lblEuro2.AutoSize = true;
            this.lblEuro2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEuro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblEuro2.Location = new System.Drawing.Point(495, 157);
            this.lblEuro2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEuro2.Name = "lblEuro2";
            this.lblEuro2.Size = new System.Drawing.Size(49, 22);
            this.lblEuro2.TabIndex = 13;
            this.lblEuro2.Text = "Euro";
            // 
            // lblPeso2
            // 
            this.lblPeso2.AutoSize = true;
            this.lblPeso2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPeso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblPeso2.Location = new System.Drawing.Point(796, 157);
            this.lblPeso2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPeso2.Name = "lblPeso2";
            this.lblPeso2.Size = new System.Drawing.Size(51, 22);
            this.lblPeso2.TabIndex = 15;
            this.lblPeso2.Text = "Peso";
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDolar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblDolar2.Location = new System.Drawing.Point(642, 157);
            this.lblDolar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(54, 22);
            this.lblDolar2.TabIndex = 14;
            this.lblDolar2.Text = "Dolar";
            // 
            // txtEuroEuro
            // 
            this.txtEuroEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtEuroEuro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEuroEuro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroEuro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEuroEuro.Location = new System.Drawing.Point(469, 206);
            this.txtEuroEuro.Margin = new System.Windows.Forms.Padding(4);
            this.txtEuroEuro.Multiline = true;
            this.txtEuroEuro.Name = "txtEuroEuro";
            this.txtEuroEuro.Size = new System.Drawing.Size(93, 28);
            this.txtEuroEuro.TabIndex = 16;
            // 
            // txtEuroDolar
            // 
            this.txtEuroDolar.BackColor = System.Drawing.SystemColors.Window;
            this.txtEuroDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEuroDolar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroDolar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEuroDolar.Location = new System.Drawing.Point(625, 206);
            this.txtEuroDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtEuroDolar.Multiline = true;
            this.txtEuroDolar.Name = "txtEuroDolar";
            this.txtEuroDolar.Size = new System.Drawing.Size(93, 28);
            this.txtEuroDolar.TabIndex = 17;
            // 
            // txtEuroPeso
            // 
            this.txtEuroPeso.BackColor = System.Drawing.SystemColors.Window;
            this.txtEuroPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEuroPeso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuroPeso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEuroPeso.Location = new System.Drawing.Point(777, 206);
            this.txtEuroPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtEuroPeso.Multiline = true;
            this.txtEuroPeso.Name = "txtEuroPeso";
            this.txtEuroPeso.Size = new System.Drawing.Size(93, 28);
            this.txtEuroPeso.TabIndex = 18;
            // 
            // txtDolarEuro
            // 
            this.txtDolarEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtDolarEuro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDolarEuro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarEuro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDolarEuro.Location = new System.Drawing.Point(469, 272);
            this.txtDolarEuro.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolarEuro.Multiline = true;
            this.txtDolarEuro.Name = "txtDolarEuro";
            this.txtDolarEuro.Size = new System.Drawing.Size(93, 28);
            this.txtDolarEuro.TabIndex = 19;
            // 
            // txtPesoEuro
            // 
            this.txtPesoEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesoEuro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesoEuro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoEuro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPesoEuro.Location = new System.Drawing.Point(469, 336);
            this.txtPesoEuro.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoEuro.Multiline = true;
            this.txtPesoEuro.Name = "txtPesoEuro";
            this.txtPesoEuro.Size = new System.Drawing.Size(93, 28);
            this.txtPesoEuro.TabIndex = 20;
            // 
            // txtPesoDolar
            // 
            this.txtPesoDolar.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesoDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesoDolar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoDolar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPesoDolar.Location = new System.Drawing.Point(625, 338);
            this.txtPesoDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoDolar.Multiline = true;
            this.txtPesoDolar.Name = "txtPesoDolar";
            this.txtPesoDolar.Size = new System.Drawing.Size(93, 28);
            this.txtPesoDolar.TabIndex = 22;
            // 
            // txtDolarDolar
            // 
            this.txtDolarDolar.BackColor = System.Drawing.SystemColors.Window;
            this.txtDolarDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDolarDolar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarDolar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDolarDolar.Location = new System.Drawing.Point(625, 272);
            this.txtDolarDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolarDolar.Multiline = true;
            this.txtDolarDolar.Name = "txtDolarDolar";
            this.txtDolarDolar.Size = new System.Drawing.Size(93, 28);
            this.txtDolarDolar.TabIndex = 21;
            // 
            // txtPesoPeso
            // 
            this.txtPesoPeso.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesoPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesoPeso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoPeso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPesoPeso.Location = new System.Drawing.Point(777, 336);
            this.txtPesoPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesoPeso.Multiline = true;
            this.txtPesoPeso.Name = "txtPesoPeso";
            this.txtPesoPeso.Size = new System.Drawing.Size(93, 28);
            this.txtPesoPeso.TabIndex = 24;
            // 
            // txtDolarPeso
            // 
            this.txtDolarPeso.BackColor = System.Drawing.SystemColors.Window;
            this.txtDolarPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDolarPeso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolarPeso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDolarPeso.Location = new System.Drawing.Point(777, 272);
            this.txtDolarPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtDolarPeso.Multiline = true;
            this.txtDolarPeso.Name = "txtDolarPeso";
            this.txtDolarPeso.Size = new System.Drawing.Size(93, 28);
            this.txtDolarPeso.TabIndex = 23;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.BackColor = System.Drawing.SystemColors.Window;
            this.txtCotizacionPeso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCotizacionPeso.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionPeso.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCotizacionPeso.Location = new System.Drawing.Point(777, 59);
            this.txtCotizacionPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCotizacionPeso.Multiline = true;
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(93, 28);
            this.txtCotizacionPeso.TabIndex = 27;
            this.txtCotizacionPeso.MouseLeave += new System.EventHandler(this.txtCotizacionPeso_MouseLeave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.BackColor = System.Drawing.SystemColors.Window;
            this.txtCotizacionDolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCotizacionDolar.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionDolar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(623, 59);
            this.txtCotizacionDolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCotizacionDolar.Multiline = true;
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(93, 28);
            this.txtCotizacionDolar.TabIndex = 26;
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.BackColor = System.Drawing.SystemColors.Window;
            this.txtCotizacionEuro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCotizacionEuro.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCotizacionEuro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCotizacionEuro.Location = new System.Drawing.Point(469, 59);
            this.txtCotizacionEuro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCotizacionEuro.Multiline = true;
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(93, 28);
            this.txtCotizacionEuro.TabIndex = 25;
            this.txtCotizacionEuro.MouseLeave += new System.EventHandler(this.txtCotizacionEuro_MouseLeave);
            // 
            // ConversorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 445);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtPesoPeso);
            this.Controls.Add(this.txtDolarPeso);
            this.Controls.Add(this.txtPesoDolar);
            this.Controls.Add(this.txtDolarDolar);
            this.Controls.Add(this.txtPesoEuro);
            this.Controls.Add(this.txtDolarEuro);
            this.Controls.Add(this.txtEuroPeso);
            this.Controls.Add(this.txtEuroDolar);
            this.Controls.Add(this.txtEuroEuro);
            this.Controls.Add(this.lblPeso2);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblEuro2);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(949, 488);
            this.Name = "ConversorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        #region Labels
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblEuro2;
        private System.Windows.Forms.Label lblPeso2;
        private System.Windows.Forms.Label lblDolar2;
        #endregion

        #region TextBox
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtEuroEuro;
        private System.Windows.Forms.TextBox txtEuroDolar;
        private System.Windows.Forms.TextBox txtEuroPeso;
        private System.Windows.Forms.TextBox txtDolarEuro;
        private System.Windows.Forms.TextBox txtPesoEuro;
        private System.Windows.Forms.TextBox txtPesoDolar;
        private System.Windows.Forms.TextBox txtDolarDolar;
        private System.Windows.Forms.TextBox txtPesoPeso;
        private System.Windows.Forms.TextBox txtDolarPeso;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        #endregion

        #region Button
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnPeso;
        #endregion

        private System.Windows.Forms.ImageList Lock;
    }
}

