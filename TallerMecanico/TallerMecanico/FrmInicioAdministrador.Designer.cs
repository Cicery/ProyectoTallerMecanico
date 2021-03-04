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
            this.components = new System.ComponentModel.Container();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.styleManager2 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.btn_Gestionar_Usuario = new DevComponents.DotNetBar.ButtonX();
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavPanel2 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.Inventario = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavItem4 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.sideNav1.SuspendLayout();
            this.sideNavPanel2.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Text = "ribbonTabItem1";
            // 
            // styleManager2
            // 
            this.styleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager2.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // btn_Gestionar_Usuario
            // 
            this.btn_Gestionar_Usuario.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Gestionar_Usuario.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Gestionar_Usuario.Location = new System.Drawing.Point(14, 3);
            this.btn_Gestionar_Usuario.Name = "btn_Gestionar_Usuario";
            this.btn_Gestionar_Usuario.Size = new System.Drawing.Size(127, 29);
            this.btn_Gestionar_Usuario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Gestionar_Usuario.Symbol = "";
            this.btn_Gestionar_Usuario.TabIndex = 10;
            this.btn_Gestionar_Usuario.Text = "Gestionar";
            this.btn_Gestionar_Usuario.Click += new System.EventHandler(this.btn_Gestionar_Usuario_Click);
            // 
            // sideNav1
            // 
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Controls.Add(this.sideNavPanel2);
            this.sideNav1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.Inventario,
            this.separator1,
            this.sideNavItem2,
            this.sideNavItem4});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1);
            this.sideNav1.Size = new System.Drawing.Size(253, 450);
            this.sideNav1.TabIndex = 11;
            this.sideNav1.Text = "sideNav1";
            this.sideNav1.Click += new System.EventHandler(this.sideNav1_Click);
            // 
            // sideNavPanel2
            // 
            this.sideNavPanel2.Controls.Add(this.buttonX1);
            this.sideNavPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel2.Location = new System.Drawing.Point(92, 37);
            this.sideNavPanel2.Name = "sideNavPanel2";
            this.sideNavPanel2.Size = new System.Drawing.Size(156, 412);
            this.sideNavPanel2.TabIndex = 6;
            this.sideNavPanel2.Visible = false;
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Controls.Add(this.btn_Gestionar_Usuario);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(92, 37);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(156, 412);
            this.sideNavPanel1.TabIndex = 2;
            // 
            // Inventario
            // 
            this.Inventario.GlobalName = "Inventario";
            this.Inventario.IsSystemMenu = true;
            this.Inventario.Name = "Inventario";
            this.Inventario.Symbol = "";
            this.Inventario.Text = "Menu";
            this.Inventario.Click += new System.EventHandler(this.sideNavItem1_Click);
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem2
            // 
            this.sideNavItem2.Checked = true;
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel1;
            this.sideNavItem2.Symbol = "";
            this.sideNavItem2.Text = "Usuarios";
            this.sideNavItem2.Click += new System.EventHandler(this.sideNavItem2_Click);
            // 
            // sideNavItem4
            // 
            this.sideNavItem4.Name = "sideNavItem4";
            this.sideNavItem4.Panel = this.sideNavPanel2;
            this.sideNavItem4.Symbol = "";
            this.sideNavItem4.Text = "Reportes";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(17, 6);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(127, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 13;
            this.buttonX1.Text = "Generar";
            // 
            // FrmInicioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sideNav1);
            this.IsMdiContainer = true;
            this.Name = "FrmInicioAdministrador";
            this.Text = "FrmInicioAdministrador";
            this.Load += new System.EventHandler(this.FrmInicioAdministrador_Load);
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.sideNavPanel2.ResumeLayout(false);
            this.sideNavPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.StyleManager styleManager2;
        private DevComponents.DotNetBar.ButtonX btn_Gestionar_Usuario;
        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.Controls.SideNavItem Inventario;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel2;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem4;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}