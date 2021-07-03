
namespace Formularios
{
    partial class FrmPrincipal
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
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lstCobrado = new System.Windows.Forms.ListBox();
            this.lstAtendido = new System.Windows.Forms.ListBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(12, 41);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(187, 251);
            this.lstIngresado.TabIndex = 0;
            // 
            // lstCobrado
            // 
            this.lstCobrado.FormattingEnabled = true;
            this.lstCobrado.Location = new System.Drawing.Point(284, 41);
            this.lstCobrado.Name = "lstCobrado";
            this.lstCobrado.Size = new System.Drawing.Size(187, 251);
            this.lstCobrado.TabIndex = 1;
            // 
            // lstAtendido
            // 
            this.lstAtendido.FormattingEnabled = true;
            this.lstAtendido.Location = new System.Drawing.Point(558, 41);
            this.lstAtendido.Name = "lstAtendido";
            this.lstAtendido.Size = new System.Drawing.Size(187, 251);
            this.lstAtendido.TabIndex = 2;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(284, 334);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(183, 50);
            this.btnCobrar.TabIndex = 3;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lstAtendido);
            this.Controls.Add(this.lstCobrado);
            this.Controls.Add(this.lstIngresado);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.ListBox lstCobrado;
        private System.Windows.Forms.ListBox lstAtendido;
        private System.Windows.Forms.Button btnCobrar;
    }
}

