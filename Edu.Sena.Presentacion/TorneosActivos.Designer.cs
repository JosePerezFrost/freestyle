namespace Edu.Sena.Presentacion
{
    partial class TorneosActivos
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
            this.torneosActivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTorneoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarJuradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.tableTorneos = new System.Windows.Forms.DataGridView();
            this.btnParticipantes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colCancelar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.batallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaBatallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTorneos)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(70, 450);
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
            this.torneosActivosToolStripMenuItem,
            this.registrarTorneoToolStripMenuItem1});
            this.todosLosTorneosToolStripMenuItem.Name = "todosLosTorneosToolStripMenuItem";
            this.todosLosTorneosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.todosLosTorneosToolStripMenuItem.Text = "Todos los Torneos";
            // 
            // torneosActivosToolStripMenuItem
            // 
            this.torneosActivosToolStripMenuItem.Name = "torneosActivosToolStripMenuItem";
            this.torneosActivosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.torneosActivosToolStripMenuItem.Text = "Torneos";
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
            this.participantesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.participantesToolStripMenuItem.Text = "Participantes";
            this.participantesToolStripMenuItem.Click += new System.EventHandler(this.participantesToolStripMenuItem_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(97, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 46);
            this.label8.TabIndex = 3;
            this.label8.Text = "Torneos";
            // 
            // tableTorneos
            // 
            this.tableTorneos.AllowUserToOrderColumns = true;
            this.tableTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTorneos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnParticipantes,
            this.colCancelar});
            this.tableTorneos.Location = new System.Drawing.Point(73, 160);
            this.tableTorneos.Name = "tableTorneos";
            this.tableTorneos.Size = new System.Drawing.Size(715, 243);
            this.tableTorneos.TabIndex = 4;
            this.tableTorneos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableTorneos_CellContentClick);
            // 
            // btnParticipantes
            // 
            this.btnParticipantes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.btnParticipantes.HeaderText = "Participantes";
            this.btnParticipantes.Name = "btnParticipantes";
            this.btnParticipantes.Width = 74;
            // 
            // colCancelar
            // 
            this.colCancelar.HeaderText = "Cancelar";
            this.colCancelar.Name = "colCancelar";
            // 
            // batallasToolStripMenuItem
            // 
            this.batallasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaBatallaToolStripMenuItem});
            this.batallasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batallasToolStripMenuItem.Name = "batallasToolStripMenuItem";
            this.batallasToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.batallasToolStripMenuItem.Text = "Batallas";
            // 
            // nuevaBatallaToolStripMenuItem
            // 
            this.nuevaBatallaToolStripMenuItem.Name = "nuevaBatallaToolStripMenuItem";
            this.nuevaBatallaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaBatallaToolStripMenuItem.Text = "Nueva Batalla";
            this.nuevaBatallaToolStripMenuItem.Click += new System.EventHandler(this.nuevaBatallaToolStripMenuItem_Click);
            // 
            // TorneosActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableTorneos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Name = "TorneosActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TorneosActivos";
            this.Load += new System.EventHandler(this.TorneosActivos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableTorneos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem torneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasTorneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirFaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosTorneosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torneosActivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTorneoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarJuradoToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tableTorneos;
        private System.Windows.Forms.DataGridViewButtonColumn btnParticipantes;
        private System.Windows.Forms.DataGridViewButtonColumn colCancelar;
        private System.Windows.Forms.ToolStripMenuItem batallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaBatallaToolStripMenuItem;
    }
}