namespace Edu.Sena.Presentacion
{
    partial class RegistrarBatalla
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
            this.batallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaBatalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarBatalla = new System.Windows.Forms.Button();
            this.cbTorneo = new System.Windows.Forms.ComboBox();
            this.cbParticipante1 = new System.Windows.Forms.ComboBox();
            this.cbParticipante2 = new System.Windows.Forms.ComboBox();
            this.cbFase = new System.Windows.Forms.ComboBox();
            this.fechaBatalla = new System.Windows.Forms.DateTimePicker();
            this.db_sifreestyleDataSet = new Edu.Sena.Presentacion.db_sifreestyleDataSet();
            this.torneosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.torneosTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.torneosTableAdapter();
            this.fasestorneosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fasestorneosTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.fasestorneosTableAdapter();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.usuariosTableAdapter();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_sifreestyleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasestorneosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
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
            this.torneosToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
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
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva Batalla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Torneo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fase:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(232, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "1º Participante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(470, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "2º Participante:";
            // 
            // btnRegistrarBatalla
            // 
            this.btnRegistrarBatalla.Location = new System.Drawing.Point(396, 348);
            this.btnRegistrarBatalla.Name = "btnRegistrarBatalla";
            this.btnRegistrarBatalla.Size = new System.Drawing.Size(84, 23);
            this.btnRegistrarBatalla.TabIndex = 8;
            this.btnRegistrarBatalla.Text = "Crear";
            this.btnRegistrarBatalla.UseVisualStyleBackColor = true;
            this.btnRegistrarBatalla.Click += new System.EventHandler(this.btnRegistrarBatalla_Click);
            // 
            // cbTorneo
            // 
            this.cbTorneo.DataSource = this.torneosBindingSource;
            this.cbTorneo.DisplayMember = "nombreTorneo";
            this.cbTorneo.FormattingEnabled = true;
            this.cbTorneo.Location = new System.Drawing.Point(161, 186);
            this.cbTorneo.Name = "cbTorneo";
            this.cbTorneo.Size = new System.Drawing.Size(121, 21);
            this.cbTorneo.TabIndex = 9;
            this.cbTorneo.ValueMember = "idTorneo";
            // 
            // cbParticipante1
            // 
            this.cbParticipante1.DataSource = this.usuariosBindingSource;
            this.cbParticipante1.DisplayMember = "nombreArtistico";
            this.cbParticipante1.FormattingEnabled = true;
            this.cbParticipante1.Location = new System.Drawing.Point(236, 292);
            this.cbParticipante1.Name = "cbParticipante1";
            this.cbParticipante1.Size = new System.Drawing.Size(121, 21);
            this.cbParticipante1.TabIndex = 10;
            this.cbParticipante1.ValueMember = "cedula";
            // 
            // cbParticipante2
            // 
            this.cbParticipante2.DataSource = this.usuariosBindingSource1;
            this.cbParticipante2.DisplayMember = "nombreArtistico";
            this.cbParticipante2.FormattingEnabled = true;
            this.cbParticipante2.Location = new System.Drawing.Point(474, 292);
            this.cbParticipante2.Name = "cbParticipante2";
            this.cbParticipante2.Size = new System.Drawing.Size(121, 21);
            this.cbParticipante2.TabIndex = 11;
            this.cbParticipante2.ValueMember = "cedula";
            // 
            // cbFase
            // 
            this.cbFase.DataSource = this.fasestorneosBindingSource;
            this.cbFase.DisplayMember = "nombreFas";
            this.cbFase.FormattingEnabled = true;
            this.cbFase.Location = new System.Drawing.Point(359, 189);
            this.cbFase.Name = "cbFase";
            this.cbFase.Size = new System.Drawing.Size(121, 21);
            this.cbFase.TabIndex = 12;
            this.cbFase.ValueMember = "idFase";
            // 
            // fechaBatalla
            // 
            this.fechaBatalla.Location = new System.Drawing.Point(546, 190);
            this.fechaBatalla.Name = "fechaBatalla";
            this.fechaBatalla.Size = new System.Drawing.Size(200, 20);
            this.fechaBatalla.TabIndex = 13;
            // 
            // db_sifreestyleDataSet
            // 
            this.db_sifreestyleDataSet.DataSetName = "db_sifreestyleDataSet";
            this.db_sifreestyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // torneosBindingSource
            // 
            this.torneosBindingSource.DataMember = "torneos";
            this.torneosBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // torneosTableAdapter
            // 
            this.torneosTableAdapter.ClearBeforeFill = true;
            // 
            // fasestorneosBindingSource
            // 
            this.fasestorneosBindingSource.DataMember = "fasestorneos";
            this.fasestorneosBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // fasestorneosTableAdapter
            // 
            this.fasestorneosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "usuarios";
            this.usuariosBindingSource1.DataSource = this.db_sifreestyleDataSet;
            // 
            // RegistrarBatalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fechaBatalla);
            this.Controls.Add(this.cbFase);
            this.Controls.Add(this.cbParticipante2);
            this.Controls.Add(this.cbParticipante1);
            this.Controls.Add(this.cbTorneo);
            this.Controls.Add(this.btnRegistrarBatalla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RegistrarBatalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarBatalla";
            this.Load += new System.EventHandler(this.RegistrarBatalla_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_sifreestyleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torneosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasestorneosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem batallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaBatalaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrarBatalla;
        private System.Windows.Forms.ComboBox cbTorneo;
        private System.Windows.Forms.ComboBox cbParticipante1;
        private System.Windows.Forms.ComboBox cbParticipante2;
        private System.Windows.Forms.ComboBox cbFase;
        private System.Windows.Forms.DateTimePicker fechaBatalla;
        private db_sifreestyleDataSet db_sifreestyleDataSet;
        private System.Windows.Forms.BindingSource torneosBindingSource;
        private db_sifreestyleDataSetTableAdapters.torneosTableAdapter torneosTableAdapter;
        private System.Windows.Forms.BindingSource fasestorneosBindingSource;
        private db_sifreestyleDataSetTableAdapters.fasestorneosTableAdapter fasestorneosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private db_sifreestyleDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
    }
}