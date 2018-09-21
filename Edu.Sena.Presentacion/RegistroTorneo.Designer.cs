namespace Edu.Sena.Presentacion
{
    partial class RegistroTorneo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.numCupos = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.ciudadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sifreestyleDataSet = new Edu.Sena.Presentacion.db_sifreestyleDataSet();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.tipotorneoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timeHora = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrearTorneo = new System.Windows.Forms.Button();
            this.listBoxFase = new System.Windows.Forms.CheckedListBox();
            this.fasestorneosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fasestorneosTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.fasestorneosTableAdapter();
            this.ciudadesTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.ciudadesTableAdapter();
            this.ciudadeshastorneoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ciudades_has_torneoTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.ciudades_has_torneoTableAdapter();
            this.tipotorneoTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.tipotorneoTableAdapter();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.batallasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaBatallaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sifreestyleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipotorneoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasestorneosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadeshastorneoBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nuevo Torneo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 137);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ciudad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha de Fin:";
            // 
            // dateInicio
            // 
            this.dateInicio.Location = new System.Drawing.Point(123, 219);
            this.dateInicio.MaxDate = new System.DateTime(2018, 12, 23, 0, 0, 0, 0);
            this.dateInicio.MinDate = new System.DateTime(2018, 9, 20, 0, 0, 0, 0);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(213, 20);
            this.dateInicio.TabIndex = 11;
            this.dateInicio.Value = new System.DateTime(2018, 9, 20, 15, 6, 15, 0);
            // 
            // dateFin
            // 
            this.dateFin.Location = new System.Drawing.Point(123, 308);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(213, 20);
            this.dateFin.TabIndex = 12;
            // 
            // numCupos
            // 
            this.numCupos.Location = new System.Drawing.Point(472, 137);
            this.numCupos.Name = "numCupos";
            this.numCupos.Size = new System.Drawing.Size(120, 20);
            this.numCupos.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cupos:";
            // 
            // cbCiudad
            // 
            this.cbCiudad.DataSource = this.ciudadesBindingSource;
            this.cbCiudad.DisplayMember = "nombre";
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(296, 137);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(121, 21);
            this.cbCiudad.TabIndex = 15;
            this.cbCiudad.ValueMember = "codigoCiudad";
            // 
            // ciudadesBindingSource
            // 
            this.ciudadesBindingSource.DataMember = "ciudades";
            this.ciudadesBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // db_sifreestyleDataSet
            // 
            this.db_sifreestyleDataSet.DataSetName = "db_sifreestyleDataSet";
            this.db_sifreestyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTipo
            // 
            this.cbTipo.DataSource = this.tipotorneoBindingSource;
            this.cbTipo.DisplayMember = "tipo";
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(650, 137);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 16;
            this.cbTipo.ValueMember = "idTipo";
            // 
            // tipotorneoBindingSource
            // 
            this.tipotorneoBindingSource.DataMember = "tipotorneo";
            this.tipotorneoBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hora de Inicio:";
            // 
            // timeHora
            // 
            this.timeHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHora.Location = new System.Drawing.Point(405, 219);
            this.timeHora.Name = "timeHora";
            this.timeHora.Size = new System.Drawing.Size(69, 20);
            this.timeHora.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fases:";
            // 
            // btnCrearTorneo
            // 
            this.btnCrearTorneo.Location = new System.Drawing.Point(385, 390);
            this.btnCrearTorneo.Name = "btnCrearTorneo";
            this.btnCrearTorneo.Size = new System.Drawing.Size(116, 23);
            this.btnCrearTorneo.TabIndex = 22;
            this.btnCrearTorneo.Text = "Crear Torneo";
            this.btnCrearTorneo.UseVisualStyleBackColor = true;
            this.btnCrearTorneo.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxFase
            // 
            this.listBoxFase.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.fasestorneosBindingSource, "idFase", true));
            this.listBoxFase.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fasestorneosBindingSource, "nombreFas", true));
            this.listBoxFase.FormattingEnabled = true;
            this.listBoxFase.Location = new System.Drawing.Point(567, 219);
            this.listBoxFase.Name = "listBoxFase";
            this.listBoxFase.Size = new System.Drawing.Size(120, 94);
            this.listBoxFase.TabIndex = 20;
            this.listBoxFase.SelectedIndexChanged += new System.EventHandler(this.listBoxFase_SelectedIndexChanged);
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
            // ciudadesTableAdapter
            // 
            this.ciudadesTableAdapter.ClearBeforeFill = true;
            // 
            // ciudadeshastorneoBindingSource
            // 
            this.ciudadeshastorneoBindingSource.DataMember = "ciudades_has_torneo";
            this.ciudadeshastorneoBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // ciudades_has_torneoTableAdapter
            // 
            this.ciudades_has_torneoTableAdapter.ClearBeforeFill = true;
            // 
            // tipotorneoTableAdapter
            // 
            this.tipotorneoTableAdapter.ClearBeforeFill = true;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(385, 308);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 23;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(382, 270);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(49, 17);
            this.lblLugar.TabIndex = 24;
            this.lblLugar.Text = "Lugar:";
            this.lblLugar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // RegistroTorneo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.txtLugar);
            this.Controls.Add(this.btnCrearTorneo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBoxFase);
            this.Controls.Add(this.timeHora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numCupos);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.dateInicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RegistroTorneo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroTorneo";
            this.Load += new System.EventHandler(this.RegistroTorneo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sifreestyleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipotorneoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasestorneosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadeshastorneoBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.NumericUpDown numCupos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker timeHora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCrearTorneo;
        private System.Windows.Forms.CheckedListBox listBoxFase;
        private db_sifreestyleDataSet db_sifreestyleDataSet;
        private System.Windows.Forms.BindingSource fasestorneosBindingSource;
        private db_sifreestyleDataSetTableAdapters.fasestorneosTableAdapter fasestorneosTableAdapter;
        private System.Windows.Forms.BindingSource ciudadesBindingSource;
        private db_sifreestyleDataSetTableAdapters.ciudadesTableAdapter ciudadesTableAdapter;
        private System.Windows.Forms.BindingSource ciudadeshastorneoBindingSource;
        private db_sifreestyleDataSetTableAdapters.ciudades_has_torneoTableAdapter ciudades_has_torneoTableAdapter;
        private System.Windows.Forms.BindingSource tipotorneoBindingSource;
        private db_sifreestyleDataSetTableAdapters.tipotorneoTableAdapter tipotorneoTableAdapter;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ToolStripMenuItem batallasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaBatallaToolStripMenuItem;
    }
}