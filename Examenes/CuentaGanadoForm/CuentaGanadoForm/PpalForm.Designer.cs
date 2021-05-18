
namespace CuentaGanadoForm
{
    partial class FormContador
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
            this.lblEmpleados = new System.Windows.Forms.Label();
            this.lblGente = new System.Windows.Forms.Label();
            this.numEmpleados = new System.Windows.Forms.NumericUpDown();
            this.numGente = new System.Windows.Forms.NumericUpDown();
            this.btnInforme = new System.Windows.Forms.Button();
            this.richTxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleados
            // 
            this.lblEmpleados.AutoSize = true;
            this.lblEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleados.Location = new System.Drawing.Point(86, 118);
            this.lblEmpleados.Name = "lblEmpleados";
            this.lblEmpleados.Size = new System.Drawing.Size(119, 25);
            this.lblEmpleados.TabIndex = 0;
            this.lblEmpleados.Text = "Empleados";
            // 
            // lblGente
            // 
            this.lblGente.AutoSize = true;
            this.lblGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGente.Location = new System.Drawing.Point(86, 196);
            this.lblGente.Name = "lblGente";
            this.lblGente.Size = new System.Drawing.Size(70, 25);
            this.lblGente.TabIndex = 1;
            this.lblGente.Text = "Gente";
            // 
            // numEmpleados
            // 
            this.numEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEmpleados.Location = new System.Drawing.Point(284, 118);
            this.numEmpleados.Name = "numEmpleados";
            this.numEmpleados.Size = new System.Drawing.Size(120, 31);
            this.numEmpleados.TabIndex = 2;
            this.numEmpleados.ValueChanged += new System.EventHandler(this.numEmpleados_ValueChanged);
            // 
            // numGente
            // 
            this.numGente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numGente.Location = new System.Drawing.Point(284, 190);
            this.numGente.Name = "numGente";
            this.numGente.Size = new System.Drawing.Size(120, 31);
            this.numGente.TabIndex = 3;
            this.numGente.ValueChanged += new System.EventHandler(this.numGente_ValueChanged);
            // 
            // btnInforme
            // 
            this.btnInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInforme.Location = new System.Drawing.Point(398, 31);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(134, 50);
            this.btnInforme.TabIndex = 4;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // richTxt
            // 
            this.richTxt.Location = new System.Drawing.Point(48, 279);
            this.richTxt.Name = "richTxt";
            this.richTxt.Size = new System.Drawing.Size(500, 141);
            this.richTxt.TabIndex = 5;
            this.richTxt.Text = "";
            // 
            // FormContador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(586, 460);
            this.Controls.Add(this.richTxt);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.numGente);
            this.Controls.Add(this.numEmpleados);
            this.Controls.Add(this.lblGente);
            this.Controls.Add(this.lblEmpleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormContador";
            this.Text = "Contador Denise Langer";
            ((System.ComponentModel.ISupportInitialize)(this.numEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpleados;
        private System.Windows.Forms.Label lblGente;
        private System.Windows.Forms.NumericUpDown numEmpleados;
        private System.Windows.Forms.NumericUpDown numGente;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.RichTextBox richTxt;
    }
}

