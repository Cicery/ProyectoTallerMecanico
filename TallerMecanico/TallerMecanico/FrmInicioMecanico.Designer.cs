
namespace TallerMecanico
{
    partial class FrmInicioMecanico
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
            this.btnIRMecanico = new System.Windows.Forms.Button();
            this.cbMecanico = new System.Windows.Forms.ComboBox();
            this.btnCerrarMecanico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIRMecanico
            // 
            this.btnIRMecanico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIRMecanico.Location = new System.Drawing.Point(372, 193);
            this.btnIRMecanico.Name = "btnIRMecanico";
            this.btnIRMecanico.Size = new System.Drawing.Size(75, 23);
            this.btnIRMecanico.TabIndex = 16;
            this.btnIRMecanico.Text = "IR";
            this.btnIRMecanico.UseVisualStyleBackColor = true;
            // 
            // cbMecanico
            // 
            this.cbMecanico.FormattingEnabled = true;
            this.cbMecanico.Items.AddRange(new object[] {
            "Modulo Inventario",
            "Modulo Mantenimiento",
            "Generar Reportes"});
            this.cbMecanico.Location = new System.Drawing.Point(226, 134);
            this.cbMecanico.Name = "cbMecanico";
            this.cbMecanico.Size = new System.Drawing.Size(366, 21);
            this.cbMecanico.TabIndex = 15;
            // 
            // btnCerrarMecanico
            // 
            this.btnCerrarMecanico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarMecanico.Location = new System.Drawing.Point(685, 12);
            this.btnCerrarMecanico.Name = "btnCerrarMecanico";
            this.btnCerrarMecanico.Size = new System.Drawing.Size(103, 23);
            this.btnCerrarMecanico.TabIndex = 14;
            this.btnCerrarMecanico.Text = "Cerrar Sesion";
            this.btnCerrarMecanico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(266, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "USUARIO MECANICO";
            // 
            // FrmInicioMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIRMecanico);
            this.Controls.Add(this.cbMecanico);
            this.Controls.Add(this.btnCerrarMecanico);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicioMecanico";
            this.Text = "FrmInicioMecanico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIRMecanico;
        private System.Windows.Forms.ComboBox cbMecanico;
        private System.Windows.Forms.Button btnCerrarMecanico;
        private System.Windows.Forms.Label label1;
    }
}