
namespace Ejercicio_24
{
    partial class FormTemperaturas
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
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblKevin = new System.Windows.Forms.Label();
            this.btnCelisus = new System.Windows.Forms.Button();
            this.btnFahrenheit = new System.Windows.Forms.Button();
            this.btnKelvin = new System.Windows.Forms.Button();
            this.txtFahrenheitTitle = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvinToFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusTitle = new System.Windows.Forms.Label();
            this.txtKelvinTitle = new System.Windows.Forms.Label();
            this.txtKelvinToCelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitToCelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusToCelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinToKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenheitToKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusToKelvin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.ForeColor = System.Drawing.Color.Navy;
            this.lblCelsius.Location = new System.Drawing.Point(31, 70);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(63, 20);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheit.ForeColor = System.Drawing.Color.Navy;
            this.lblFahrenheit.Location = new System.Drawing.Point(31, 124);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(89, 20);
            this.lblFahrenheit.TabIndex = 1;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblKevin
            // 
            this.lblKevin.AutoSize = true;
            this.lblKevin.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKevin.ForeColor = System.Drawing.Color.Navy;
            this.lblKevin.Location = new System.Drawing.Point(31, 172);
            this.lblKevin.Name = "lblKevin";
            this.lblKevin.Size = new System.Drawing.Size(55, 20);
            this.lblKevin.TabIndex = 2;
            this.lblKevin.Text = "Kelvin";
            // 
            // btnCelisus
            // 
            this.btnCelisus.AutoSize = true;
            this.btnCelisus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCelisus.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelisus.ForeColor = System.Drawing.Color.Navy;
            this.btnCelisus.Location = new System.Drawing.Point(245, 64);
            this.btnCelisus.Name = "btnCelisus";
            this.btnCelisus.Size = new System.Drawing.Size(76, 30);
            this.btnCelisus.TabIndex = 3;
            this.btnCelisus.Text = "Convert";
            this.btnCelisus.UseVisualStyleBackColor = false;
            this.btnCelisus.Click += new System.EventHandler(this.btnCelisus_Click);
            // 
            // btnFahrenheit
            // 
            this.btnFahrenheit.AutoSize = true;
            this.btnFahrenheit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnFahrenheit.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFahrenheit.ForeColor = System.Drawing.Color.Navy;
            this.btnFahrenheit.Location = new System.Drawing.Point(245, 114);
            this.btnFahrenheit.Name = "btnFahrenheit";
            this.btnFahrenheit.Size = new System.Drawing.Size(76, 30);
            this.btnFahrenheit.TabIndex = 4;
            this.btnFahrenheit.Text = "Convert";
            this.btnFahrenheit.UseVisualStyleBackColor = false;
            this.btnFahrenheit.Click += new System.EventHandler(this.btnFahrenheit_Click);
            // 
            // btnKelvin
            // 
            this.btnKelvin.AutoSize = true;
            this.btnKelvin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnKelvin.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelvin.ForeColor = System.Drawing.Color.Navy;
            this.btnKelvin.Location = new System.Drawing.Point(245, 167);
            this.btnKelvin.Name = "btnKelvin";
            this.btnKelvin.Size = new System.Drawing.Size(76, 30);
            this.btnKelvin.TabIndex = 5;
            this.btnKelvin.Text = "Convert";
            this.btnKelvin.UseVisualStyleBackColor = false;
            this.btnKelvin.Click += new System.EventHandler(this.btnKelvin_Click);
            // 
            // txtFahrenheitTitle
            // 
            this.txtFahrenheitTitle.AutoSize = true;
            this.txtFahrenheitTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrenheitTitle.ForeColor = System.Drawing.Color.Navy;
            this.txtFahrenheitTitle.Location = new System.Drawing.Point(359, 30);
            this.txtFahrenheitTitle.Name = "txtFahrenheitTitle";
            this.txtFahrenheitTitle.Size = new System.Drawing.Size(89, 20);
            this.txtFahrenheitTitle.TabIndex = 7;
            this.txtFahrenheitTitle.Text = "Fahrenheit";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(141, 69);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(81, 20);
            this.txtCelsius.TabIndex = 9;
            this.txtCelsius.MouseLeave += new System.EventHandler(this.txtCelsius_MouseLeave);
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(141, 124);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(81, 20);
            this.txtFahrenheit.TabIndex = 10;
            this.txtFahrenheit.MouseLeave += new System.EventHandler(this.txtFahrenheit_MouseLeave);
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(141, 172);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(81, 20);
            this.txtKelvin.TabIndex = 11;
            this.txtKelvin.MouseLeave += new System.EventHandler(this.txtKelvin_MouseLeave);
            // 
            // txtCelsiusToFahrenheit
            // 
            this.txtCelsiusToFahrenheit.Enabled = false;
            this.txtCelsiusToFahrenheit.Location = new System.Drawing.Point(354, 70);
            this.txtCelsiusToFahrenheit.Name = "txtCelsiusToFahrenheit";
            this.txtCelsiusToFahrenheit.Size = new System.Drawing.Size(103, 20);
            this.txtCelsiusToFahrenheit.TabIndex = 12;
            // 
            // txtFahrenheitToFahrenheit
            // 
            this.txtFahrenheitToFahrenheit.Enabled = false;
            this.txtFahrenheitToFahrenheit.Location = new System.Drawing.Point(354, 120);
            this.txtFahrenheitToFahrenheit.Name = "txtFahrenheitToFahrenheit";
            this.txtFahrenheitToFahrenheit.Size = new System.Drawing.Size(103, 20);
            this.txtFahrenheitToFahrenheit.TabIndex = 13;
            // 
            // txtKelvinToFahrenheit
            // 
            this.txtKelvinToFahrenheit.Enabled = false;
            this.txtKelvinToFahrenheit.Location = new System.Drawing.Point(354, 173);
            this.txtKelvinToFahrenheit.Name = "txtKelvinToFahrenheit";
            this.txtKelvinToFahrenheit.Size = new System.Drawing.Size(103, 20);
            this.txtKelvinToFahrenheit.TabIndex = 14;
            // 
            // txtCelsiusTitle
            // 
            this.txtCelsiusTitle.AutoSize = true;
            this.txtCelsiusTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelsiusTitle.ForeColor = System.Drawing.Color.Navy;
            this.txtCelsiusTitle.Location = new System.Drawing.Point(508, 30);
            this.txtCelsiusTitle.Name = "txtCelsiusTitle";
            this.txtCelsiusTitle.Size = new System.Drawing.Size(63, 20);
            this.txtCelsiusTitle.TabIndex = 6;
            this.txtCelsiusTitle.Text = "Celsius";
            // 
            // txtKelvinTitle
            // 
            this.txtKelvinTitle.AutoSize = true;
            this.txtKelvinTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelvinTitle.ForeColor = System.Drawing.Color.Navy;
            this.txtKelvinTitle.Location = new System.Drawing.Point(660, 30);
            this.txtKelvinTitle.Name = "txtKelvinTitle";
            this.txtKelvinTitle.Size = new System.Drawing.Size(55, 20);
            this.txtKelvinTitle.TabIndex = 8;
            this.txtKelvinTitle.Text = "Kelvin";
            // 
            // txtKelvinToCelsius
            // 
            this.txtKelvinToCelsius.Enabled = false;
            this.txtKelvinToCelsius.Location = new System.Drawing.Point(492, 173);
            this.txtKelvinToCelsius.Name = "txtKelvinToCelsius";
            this.txtKelvinToCelsius.Size = new System.Drawing.Size(103, 20);
            this.txtKelvinToCelsius.TabIndex = 17;
            // 
            // txtFahrenheitToCelsius
            // 
            this.txtFahrenheitToCelsius.Enabled = false;
            this.txtFahrenheitToCelsius.Location = new System.Drawing.Point(492, 120);
            this.txtFahrenheitToCelsius.Name = "txtFahrenheitToCelsius";
            this.txtFahrenheitToCelsius.Size = new System.Drawing.Size(103, 20);
            this.txtFahrenheitToCelsius.TabIndex = 16;
            // 
            // txtCelsiusToCelsius
            // 
            this.txtCelsiusToCelsius.Enabled = false;
            this.txtCelsiusToCelsius.Location = new System.Drawing.Point(492, 70);
            this.txtCelsiusToCelsius.Name = "txtCelsiusToCelsius";
            this.txtCelsiusToCelsius.Size = new System.Drawing.Size(103, 20);
            this.txtCelsiusToCelsius.TabIndex = 15;
            // 
            // txtKelvinToKelvin
            // 
            this.txtKelvinToKelvin.Enabled = false;
            this.txtKelvinToKelvin.Location = new System.Drawing.Point(635, 173);
            this.txtKelvinToKelvin.Name = "txtKelvinToKelvin";
            this.txtKelvinToKelvin.Size = new System.Drawing.Size(103, 20);
            this.txtKelvinToKelvin.TabIndex = 20;
            // 
            // txtFahrenheitToKelvin
            // 
            this.txtFahrenheitToKelvin.Enabled = false;
            this.txtFahrenheitToKelvin.Location = new System.Drawing.Point(635, 120);
            this.txtFahrenheitToKelvin.Name = "txtFahrenheitToKelvin";
            this.txtFahrenheitToKelvin.Size = new System.Drawing.Size(103, 20);
            this.txtFahrenheitToKelvin.TabIndex = 19;
            // 
            // txtCelsiusToKelvin
            // 
            this.txtCelsiusToKelvin.Enabled = false;
            this.txtCelsiusToKelvin.Location = new System.Drawing.Point(635, 70);
            this.txtCelsiusToKelvin.Name = "txtCelsiusToKelvin";
            this.txtCelsiusToKelvin.Size = new System.Drawing.Size(103, 20);
            this.txtCelsiusToKelvin.TabIndex = 18;
            // 
            // FormTemperaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(773, 223);
            this.Controls.Add(this.txtKelvinToKelvin);
            this.Controls.Add(this.txtFahrenheitToKelvin);
            this.Controls.Add(this.txtCelsiusToKelvin);
            this.Controls.Add(this.txtKelvinToCelsius);
            this.Controls.Add(this.txtFahrenheitToCelsius);
            this.Controls.Add(this.txtCelsiusToCelsius);
            this.Controls.Add(this.txtKelvinToFahrenheit);
            this.Controls.Add(this.txtFahrenheitToFahrenheit);
            this.Controls.Add(this.txtCelsiusToFahrenheit);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtKelvinTitle);
            this.Controls.Add(this.txtFahrenheitTitle);
            this.Controls.Add(this.txtCelsiusTitle);
            this.Controls.Add(this.btnKelvin);
            this.Controls.Add(this.btnFahrenheit);
            this.Controls.Add(this.btnCelisus);
            this.Controls.Add(this.lblKevin);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblCelsius);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTemperaturas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Temperaturas";
            this.Load += new System.EventHandler(this.FormTemperaturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblKevin;
        private System.Windows.Forms.Button btnCelisus;
        private System.Windows.Forms.Button btnFahrenheit;
        private System.Windows.Forms.Button btnKelvin;
        private System.Windows.Forms.Label txtFahrenheitTitle;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.TextBox txtCelsiusToFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitToFahrenheit;
        private System.Windows.Forms.TextBox txtKelvinToFahrenheit;
        private System.Windows.Forms.Label txtCelsiusTitle;
        private System.Windows.Forms.Label txtKelvinTitle;
        private System.Windows.Forms.TextBox txtKelvinToCelsius;
        private System.Windows.Forms.TextBox txtFahrenheitToCelsius;
        private System.Windows.Forms.TextBox txtCelsiusToCelsius;
        private System.Windows.Forms.TextBox txtKelvinToKelvin;
        private System.Windows.Forms.TextBox txtFahrenheitToKelvin;
        private System.Windows.Forms.TextBox txtCelsiusToKelvin;
    }
}

