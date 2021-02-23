namespace TallerMecanico
{
    partial class FrmInicioAdministrador
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarAdmin = new System.Windows.Forms.Button();
            this.cbAdministrador = new System.Windows.Forms.ComboBox();
            this.btnIRAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "USUARIO ADMINISTRADOR";
            // 
            // btnCerrarAdmin
            // 
            this.btnCerrarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarAdmin.Location = new System.Drawing.Point(685, 12);
            this.btnCerrarAdmin.Name = "btnCerrarAdmin";
            this.btnCerrarAdmin.Size = new System.Drawing.Size(103, 23);
            this.btnCerrarAdmin.TabIndex = 6;
            this.btnCerrarAdmin.Text = "Cerrar Sesion";
            this.btnCerrarAdmin.UseVisualStyleBackColor = true;
            this.btnCerrarAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAdministrador
            // 
            this.cbAdministrador.FormattingEnabled = true;
            this.cbAdministrador.Items.AddRange(new object[] {
            "Modulo Administrador",
            "Modulo Inventario",
            "Modulo Reportes"});
            this.cbAdministrador.Location = new System.Drawing.Point(226, 134);
            this.cbAdministrador.Name = "cbAdministrador";
            this.cbAdministrador.Size = new System.Drawing.Size(366, 21);
            this.cbAdministrador.TabIndex = 7;
            // 
            // btnIRAdmin
            // 
            this.btnIRAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIRAdmin.Location = new System.Drawing.Point(372, 193);
            this.btnIRAdmin.Name = "btnIRAdmin";
            this.btnIRAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnIRAdmin.TabIndex = 8;
            this.btnIRAdmin.Text = "IR";
            this.btnIRAdmin.UseVisualStyleBackColor = true;
            this.btnIRAdmin.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmInicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIRAdmin);
            this.Controls.Add(this.cbAdministrador);
            this.Controls.Add(this.btnCerrarAdmin);
            this.Controls.Add(this.label1);
            this.Name = "FrmInicioAdministrador";
            this.Text = "FrmInicioAdministrador";
            this.Load += new System.EventHandler(this.FrmInicioAdministrador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarAdmin;
        private System.Windows.Forms.ComboBox cbAdministrador;
        private System.Windows.Forms.Button btnIRAdmin;
    }
}