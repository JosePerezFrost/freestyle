﻿namespace Edu.Sena.Presentacion
{
    partial class Participantes
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
            this.tableParticipantes = new System.Windows.Forms.DataGridView();
            this.lblParticipante = new System.Windows.Forms.Label();
            this.batallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaBatallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableParticipantes)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(126, 450);
            this.menuStrip1.TabIndex = 1;
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
            this.MenuTorneo.Size = new System.Drawing.Size(161, 22);
            this.MenuTorneo.Text = "Torneos";
            this.MenuTorneo.Click += new System.EventHandler(this.MenuTorneo_Click);
            // 
            // registrarTorneoToolStripMenuItem1
            // 
            this.registrarTorneoToolStripMenuItem1.Name = "registrarTorneoToolStripMenuItem1";
            this.registrarTorneoToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
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
            // tableParticipantes
            // 
            this.tableParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableParticipantes.Location = new System.Drawing.Point(127, 144);
            this.tableParticipantes.Name = "tableParticipantes";
            this.tableParticipantes.Size = new System.Drawing.Size(566, 150);
            this.tableParticipantes.TabIndex = 4;
            // 
            // lblParticipante
            // 
            this.lblParticipante.AutoSize = true;
            this.lblParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipante.Location = new System.Drawing.Point(120, 23);
            this.lblParticipante.Name = "lblParticipante";
            this.lblParticipante.Size = new System.Drawing.Size(340, 39);
            this.lblParticipante.TabIndex = 3;
            this.lblParticipante.Text = "Participantes Torneo ";
            // 
            // batallasToolStripMenuItem
            // 
            this.batallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaBatallaToolStripMenuItem});
            this.batallasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batallasToolStripMenuItem.Name = "batallasToolStripMenuItem";
            this.batallasToolStripMenuItem.Size = new System.Drawing.Size(113, 19);
            this.batallasToolStripMenuItem.Text = "Batallas";
            // 
            // nuevaBatallaToolStripMenuItem
            // 
            this.nuevaBatallaToolStripMenuItem.Name = "nuevaBatallaToolStripMenuItem";
            this.nuevaBatallaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaBatallaToolStripMenuItem.Text = "Nueva Batalla";
            this.nuevaBatallaToolStripMenuItem.Click += new System.EventHandler(this.nuevaBatallaToolStripMenuItem_Click);
            // 
            // Participantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableParticipantes);
            this.Controls.Add(this.lblParticipante);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Participantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Participantes";
            this.Load += new System.EventHandler(this.Participantes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableParticipantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.DataGridView tableParticipantes;
        private System.Windows.Forms.Label lblParticipante;
        private System.Windows.Forms.ToolStripMenuItem batallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaBatallaToolStripMenuItem;
    }
}