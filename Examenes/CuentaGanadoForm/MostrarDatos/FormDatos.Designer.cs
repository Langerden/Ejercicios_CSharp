
namespace MostrarDatos
{
    partial class FormDatos
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
            this.richTextBoxSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxSalidaDeTest
            // 
            this.richTextBoxSalidaDeTest.Location = new System.Drawing.Point(46, 53);
            this.richTextBoxSalidaDeTest.Name = "richTextBoxSalidaDeTest";
            this.richTextBoxSalidaDeTest.Size = new System.Drawing.Size(244, 249);
            this.richTextBoxSalidaDeTest.TabIndex = 0;
            this.richTextBoxSalidaDeTest.Text = "";
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 365);
            this.Controls.Add(this.richTextBoxSalidaDeTest);
            this.Name = "FormDatos";
            this.Text = "Datos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxSalidaDeTest;
    }
}

