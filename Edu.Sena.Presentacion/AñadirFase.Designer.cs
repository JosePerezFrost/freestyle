namespace Edu.Sena.Presentacion
{
    partial class AñadirFase
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
            this.cancelarTorneoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarJuradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAggFase = new System.Windows.Forms.Label();
            this.lblNombreFase = new System.Windows.Forms.Label();
            this.txtNombreFase = new System.Windows.Forms.TextBox();
            this.btnAggFase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fasestorneosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_sifreestyleDataSet = new Edu.Sena.Presentacion.db_sifreestyleDataSet();
            this.fasestorneosTableAdapter = new Edu.Sena.Presentacion.db_sifreestyleDataSetTableAdapters.fasestorneosTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasestorneosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sifreestyleDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.registrarTorneoToolStripMenuItem1,
            this.cancelarTorneoToolStripMenuItem1});
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
            // cancelarTorneoToolStripMenuItem1
            // 
            this.cancelarTorneoToolStripMenuItem1.Name = "cancelarTorneoToolStripMenuItem1";
            this.cancelarTorneoToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.cancelarTorneoToolStripMenuItem1.Text = "Cancelar Torneo";
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
            // lblAggFase
            // 
            this.lblAggFase.AutoSize = true;
            this.lblAggFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAggFase.Location = new System.Drawing.Point(129, 40);
            this.lblAggFase.Name = "lblAggFase";
            this.lblAggFase.Size = new System.Drawing.Size(223, 39);
            this.lblAggFase.TabIndex = 3;
            this.lblAggFase.Text = "Agregar Fase";
            // 
            // lblNombreFase
            // 
            this.lblNombreFase.AutoSize = true;
            this.lblNombreFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFase.Location = new System.Drawing.Point(132, 115);
            this.lblNombreFase.Name = "lblNombreFase";
            this.lblNombreFase.Size = new System.Drawing.Size(84, 24);
            this.lblNombreFase.TabIndex = 8;
            this.lblNombreFase.Text = "Nombre:";
            // 
            // txtNombreFase
            // 
            this.txtNombreFase.Location = new System.Drawing.Point(286, 120);
            this.txtNombreFase.Name = "txtNombreFase";
            this.txtNombreFase.Size = new System.Drawing.Size(203, 20);
            this.txtNombreFase.TabIndex = 9;
            // 
            // btnAggFase
            // 
            this.btnAggFase.Location = new System.Drawing.Point(555, 118);
            this.btnAggFase.Name = "btnAggFase";
            this.btnAggFase.Size = new System.Drawing.Size(124, 23);
            this.btnAggFase.TabIndex = 10;
            this.btnAggFase.Text = "Agregar";
            this.btnAggFase.UseVisualStyleBackColor = true;
            this.btnAggFase.Click += new System.EventHandler(this.btnAggFase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFaseDataGridViewTextBoxColumn,
            this.nombreFasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fasestorneosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // idFaseDataGridViewTextBoxColumn
            // 
            this.idFaseDataGridViewTextBoxColumn.DataPropertyName = "idFase";
            this.idFaseDataGridViewTextBoxColumn.HeaderText = "idFase";
            this.idFaseDataGridViewTextBoxColumn.Name = "idFaseDataGridViewTextBoxColumn";
            this.idFaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreFasDataGridViewTextBoxColumn
            // 
            this.nombreFasDataGridViewTextBoxColumn.DataPropertyName = "nombreFas";
            this.nombreFasDataGridViewTextBoxColumn.HeaderText = "nombreFas";
            this.nombreFasDataGridViewTextBoxColumn.Name = "nombreFasDataGridViewTextBoxColumn";
            // 
            // fasestorneosBindingSource
            // 
            this.fasestorneosBindingSource.DataMember = "fasestorneos";
            this.fasestorneosBindingSource.DataSource = this.db_sifreestyleDataSet;
            // 
            // db_sifreestyleDataSet
            // 
            this.db_sifreestyleDataSet.DataSetName = "db_sifreestyleDataSet";
            this.db_sifreestyleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fasestorneosTableAdapter
            // 
            this.fasestorneosTableAdapter.ClearBeforeFill = true;
            // 
            // AñadirFase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAggFase);
            this.Controls.Add(this.txtNombreFase);
            this.Controls.Add(this.lblNombreFase);
            this.Controls.Add(this.lblAggFase);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AñadirFase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AñadirFase";
            this.Load += new System.EventHandler(this.AñadirFase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fasestorneosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sifreestyleDataSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem cancelarTorneoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem participantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarJuradoToolStripMenuItem;
        private System.Windows.Forms.Label lblAggFase;
        private System.Windows.Forms.Label lblNombreFase;
        private System.Windows.Forms.TextBox txtNombreFase;
        private System.Windows.Forms.Button btnAggFase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_sifreestyleDataSet db_sifreestyleDataSet;
        private System.Windows.Forms.BindingSource fasestorneosBindingSource;
        private db_sifreestyleDataSetTableAdapters.fasestorneosTableAdapter fasestorneosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFasDataGridViewTextBoxColumn;
    }
}