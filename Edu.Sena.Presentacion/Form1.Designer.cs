namespace Edu.Sena.Presentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasTorneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirFaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosTorneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTorneo = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTorneoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarTorneoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarJuradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Fox";
            this.notifyIcon1.Visible = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torneosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(70, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // torneosToolStripMenuItem
            // 
            this.torneosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasTorneosToolStripMenuItem,
            this.añadirFaseToolStripMenuItem,
            this.todosLosTorneosToolStripMenuItem});
            this.torneosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.torneosToolStripMenuItem.Name = "torneosToolStripMenuItem";
            this.torneosToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.torneosToolStripMenuItem.Text = "Torneos";
            // 
            // estadisticasTorneosToolStripMenuItem
            // 
            this.estadisticasTorneosToolStripMenuItem.Name = "estadisticasTorneosToolStripMenuItem";
            this.estadisticasTorneosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.estadisticasTorneosToolStripMenuItem.Text = "Estadisticas  Torneos";
            // 
            // añadirFaseToolStripMenuItem
            // 
            this.añadirFaseToolStripMenuItem.Name = "añadirFaseToolStripMenuItem";
            this.añadirFaseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.añadirFaseToolStripMenuItem.Text = "Añadir Fase";
            // 
            // todosLosTorneosToolStripMenuItem
            // 
            this.todosLosTorneosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTorneo,
            this.registrarTorneoToolStripMenuItem1,
            this.cancelarTorneoToolStripMenuItem1});
            this.todosLosTorneosToolStripMenuItem.Name = "todosLosTorneosToolStripMenuItem";
            this.todosLosTorneosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.todosLosTorneosToolStripMenuItem.Text = "Todos los Torneos";
            // 
            // MenuTorneo
            // 
            this.MenuTorneo.Name = "MenuTorneo";
            this.MenuTorneo.Size = new System.Drawing.Size(180, 22);
            this.MenuTorneo.Text = "Torneos";
            this.MenuTorneo.Click += new System.EventHandler(this.MenuTorneo_Click);
            // 
            // registrarTorneoToolStripMenuItem1
            // 
            this.registrarTorneoToolStripMenuItem1.Name = "registrarTorneoToolStripMenuItem1";
            this.registrarTorneoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.registrarTorneoToolStripMenuItem1.Text = "Registrar Torneo";
            this.registrarTorneoToolStripMenuItem1.Click += new System.EventHandler(this.registrarTorneoToolStripMenuItem1_Click);
            // 
            // cancelarTorneoToolStripMenuItem1
            // 
            this.cancelarTorneoToolStripMenuItem1.Name = "cancelarTorneoToolStripMenuItem1";
            this.cancelarTorneoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cancelarTorneoToolStripMenuItem1.Text = "Cancelar Torneo";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantesToolStripMenuItem,
            this.juradosToolStripMenuItem});
            this.usuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // participantesToolStripMenuItem
            // 
            this.participantesToolStripMenuItem.Name = "participantesToolStripMenuItem";
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.participantesToolStripMenuItem.Text = "Participantes";
            // 
            // juradosToolStripMenuItem
            // 
            this.juradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarJuradoToolStripMenuItem});
            this.juradosToolStripMenuItem.Name = "juradosToolStripMenuItem";
            this.juradosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.juradosToolStripMenuItem.Text = "Jurados";
            // 
            // asignarJuradoToolStripMenuItem
            // 
            this.asignarJuradoToolStripMenuItem.Name = "asignarJuradoToolStripMenuItem";
            this.asignarJuradoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asignarJuradoToolStripMenuItem.Text = "Asignar Jurado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasTorneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirFaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosTorneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTorneoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelarTorneoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarJuradoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTorneo;
    }
}

