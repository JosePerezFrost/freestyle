namespace Edu.Sena.Presentacion
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.torneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasTorneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirFaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosTorneosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTorneo = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTorneoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarJuradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.batallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaBatalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Fox";
            this.notifyIcon1.Visible = true;
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
            this.añadirFaseToolStripMenuItem.Click += new System.EventHandler(this.añadirFaseToolStripMenuItem_Click);
            // 
            // todosLosTorneosToolStripMenuItem
            // 
            this.todosLosTorneosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTorneo,
            this.registrarTorneoToolStripMenuItem1});
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
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.participantesToolStripMenuItem.Text = "Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
            // 
            // juradosToolStripMenuItem
            // 
            this.juradosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarJuradoToolStripMenuItem});
            this.juradosToolStripMenuItem.Name = "juradosToolStripMenuItem";
            this.juradosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.juradosToolStripMenuItem.Text = "Jurados";
            // 
            // asignarJuradoToolStripMenuItem
            // 
            this.asignarJuradoToolStripMenuItem.Name = "asignarJuradoToolStripMenuItem";
            this.asignarJuradoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.asignarJuradoToolStripMenuItem.Text = "Asignar Jurado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.torneosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.batallasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(70, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipante.Location = new System.Drawing.Point(208, 67);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(415, 39);
            this.lblParticipante.TabIndex = 4;
            this.lblParticipante.Text = "Bienvenido Administrador ";
            // 
            // batallasToolStripMenuItem
            // 
            this.batallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaBatalaToolStripMenuItem});
            this.batallasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batallasToolStripMenuItem.Name = "batallasToolStripMenuItem";
            this.batallasToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.batallasToolStripMenuItem.Text = "Batallas";
            // 
            // nuevaBatalaToolStripMenuItem
            // 
            this.nuevaBatalaToolStripMenuItem.Name = "nuevaBatalaToolStripMenuItem";
            this.nuevaBatalaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaBatalaToolStripMenuItem.Text = "Nueva Batalla";
            this.nuevaBatalaToolStripMenuItem.Click += new System.EventHandler(this.nuevaBatalaToolStripMenuItem_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblParticipante);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasTorneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirFaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosTorneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuTorneo;
        private System.Windows.Forms.ToolStripMenuItem registrarTorneoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarJuradoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.ToolStripMenuItem batallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaBatalaToolStripMenuItem;
    }
}

