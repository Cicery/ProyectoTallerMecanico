
namespace TallerMecanico
{
    partial class FrmInicioAsistente
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
            this.btnIRAsistente = new System.Windows.Forms.Button();
            this.cbAsistente = new System.Windows.Forms.ComboBox();
            this.btnCerrarAsis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIRAsistente
            // 
            this.btnIRAsistente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIRAsistente.Location = new System.Drawing.Point(372, 193);
            this.btnIRAsistente.Name = "btnIRAsistente";
            this.btnIRAsistente.Size = new System.Drawing.Size(75, 23);
            this.btnIRAsistente.TabIndex = 12;
            this.btnIRAsistente.Text = "IR";
            this.btnIRAsistente.UseVisualStyleBackColor = true;
            // 
            // cbAsistente
            // 
            this.cbAsistente.FormattingEnabled = true;
            this.cbAsistente.Items.AddRange(new object[] {
            "Modulo Inventario",
            "Modulo Mantenimiento",
            "Generar Reportes"});
            this.cbAsistente.Location = new System.Drawing.Point(226, 134);
            this.cbAsistente.Name = "cbAsistente";
            this.cbAsistente.Size = new System.Drawing.Size(366, 21);
            this.cbAsistente.TabIndex = 11;
            // 
            // btnCerrarAsis
            // 
            this.btnCerrarAsis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAsis.Location = new System.Drawing.Point(685, 12);
            this.btnCerrarAsis.Name = "btnCerrarAsis";
            this.btnCerrarAsis.Size = new System.Drawing.Size(103, 23);
            this.btnCerrarAsis.TabIndex = 10;
            this.btnCerrarAsis.Text = "Cerrar Sesion";
            this.btnCerrarAsis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(266, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "USUARIO ASISTENTE";
            // 
            // FrmInicioAsistente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIRAsistente);
            this.Controls.Add(this.cbAsistente);
            this.Controls.Add(this.btnCerrarAsis);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicioAsistente";
            this.Text = "FrmInicioAsistente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIRAsistente;
        private System.Windows.Forms.ComboBox cbAsistente;
        private System.Windows.Forms.Button btnCerrarAsis;
        private System.Windows.Forms.Label label1;
    }
}