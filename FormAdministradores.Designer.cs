namespace WindowsFormsApp1
{
    partial class FormAdministradores
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarUsuarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desbloquearUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarCSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarCSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regresarASimuladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consultarCSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.borrarUsuarioToolStripMenuItem,
            this.regresarASimuladorToolStripMenuItem,
            this.cerrarAplicaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUsuarioToolStripMenuItem,
            this.borrarUsuarioToolStripMenuItem1,
            this.actualizarUsuarioToolStripMenuItem,
            this.desbloquearUsuarioToolStripMenuItem,
            this.consultarUsariosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 20);
            this.toolStripMenuItem1.Text = "Administrar Usuarios";
            // 
            // agregarUsuarioToolStripMenuItem
            // 
            this.agregarUsuarioToolStripMenuItem.Name = "agregarUsuarioToolStripMenuItem";
            this.agregarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.agregarUsuarioToolStripMenuItem.Text = "Agregar Usuario";
            this.agregarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuarioToolStripMenuItem_Click);
            // 
            // borrarUsuarioToolStripMenuItem1
            // 
            this.borrarUsuarioToolStripMenuItem1.Name = "borrarUsuarioToolStripMenuItem1";
            this.borrarUsuarioToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.borrarUsuarioToolStripMenuItem1.Text = "Borrar Usuario";
            this.borrarUsuarioToolStripMenuItem1.Click += new System.EventHandler(this.borrarUsuarioToolStripMenuItem1_Click);
            // 
            // actualizarUsuarioToolStripMenuItem
            // 
            this.actualizarUsuarioToolStripMenuItem.Name = "actualizarUsuarioToolStripMenuItem";
            this.actualizarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.actualizarUsuarioToolStripMenuItem.Text = "Actualizar Usuario";
            this.actualizarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.actualizarUsuarioToolStripMenuItem_Click);
            // 
            // desbloquearUsuarioToolStripMenuItem
            // 
            this.desbloquearUsuarioToolStripMenuItem.Name = "desbloquearUsuarioToolStripMenuItem";
            this.desbloquearUsuarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.desbloquearUsuarioToolStripMenuItem.Text = "Desbloquear Usuario";
            // 
            // consultarUsariosToolStripMenuItem
            // 
            this.consultarUsariosToolStripMenuItem.Name = "consultarUsariosToolStripMenuItem";
            this.consultarUsariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarUsariosToolStripMenuItem.Text = "Consultar usarios";
            this.consultarUsariosToolStripMenuItem.Click += new System.EventHandler(this.consultarUsariosToolStripMenuItem_Click);
            // 
            // borrarUsuarioToolStripMenuItem
            // 
            this.borrarUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCSAToolStripMenuItem,
            this.borrarCSAToolStripMenuItem,
            this.actualizarCSAToolStripMenuItem,
            this.consultarCSAToolStripMenuItem});
            this.borrarUsuarioToolStripMenuItem.Name = "borrarUsuarioToolStripMenuItem";
            this.borrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.borrarUsuarioToolStripMenuItem.Text = "Administrar CSA";
            // 
            // agregarCSAToolStripMenuItem
            // 
            this.agregarCSAToolStripMenuItem.Name = "agregarCSAToolStripMenuItem";
            this.agregarCSAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarCSAToolStripMenuItem.Text = "Agregar CSA";
            this.agregarCSAToolStripMenuItem.Click += new System.EventHandler(this.agregarCSAToolStripMenuItem_Click);
            // 
            // borrarCSAToolStripMenuItem
            // 
            this.borrarCSAToolStripMenuItem.Name = "borrarCSAToolStripMenuItem";
            this.borrarCSAToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.borrarCSAToolStripMenuItem.Text = "Borrar CSA";
            // 
            // actualizarCSAToolStripMenuItem
            // 
            this.actualizarCSAToolStripMenuItem.Name = "actualizarCSAToolStripMenuItem";
            this.actualizarCSAToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.actualizarCSAToolStripMenuItem.Text = "Actualizar CSA";
            // 
            // regresarASimuladorToolStripMenuItem
            // 
            this.regresarASimuladorToolStripMenuItem.Name = "regresarASimuladorToolStripMenuItem";
            this.regresarASimuladorToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.regresarASimuladorToolStripMenuItem.Text = "Regresar a Simulador";
            this.regresarASimuladorToolStripMenuItem.Click += new System.EventHandler(this.regresarASimuladorToolStripMenuItem_Click);
            // 
            // cerrarAplicaciónToolStripMenuItem
            // 
            this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
            this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación";
            this.cerrarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(714, 346);
            this.dataGridView1.TabIndex = 1;
            // 
            // consultarCSAToolStripMenuItem
            // 
            this.consultarCSAToolStripMenuItem.Name = "consultarCSAToolStripMenuItem";
            this.consultarCSAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarCSAToolStripMenuItem.Text = "Consultar CSA";
            this.consultarCSAToolStripMenuItem.Click += new System.EventHandler(this.consultarCSAToolStripMenuItem_Click);
            // 
            // FormAdministradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormAdministradores";
            this.Text = "FormAdministradores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarUsuarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desbloquearUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarCSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarCSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regresarASimuladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsariosToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem consultarCSAToolStripMenuItem;
    }
}