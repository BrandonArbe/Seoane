namespace Seoane.Presentacion
{
    partial class FrmArticulo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkSelec = new System.Windows.Forms.CheckBox();
            this.btnElimina = new System.Windows.Forms.Button();
            this.btnDesactiva = new System.Windows.Forms.Button();
            this.btnActiva = new System.Windows.Forms.Button();
            this.lbltota = new System.Windows.Forms.Label();
            this.txtbusca = new System.Windows.Forms.TextBox();
            this.btmBusca = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListar = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).BeginInit();
            this.tab1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(198, 135);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(198, 59);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(39, 20);
            this.txtID.TabIndex = 0;
            // 
            // chkSelec
            // 
            this.chkSelec.AutoSize = true;
            this.chkSelec.Location = new System.Drawing.Point(27, 299);
            this.chkSelec.Name = "chkSelec";
            this.chkSelec.Size = new System.Drawing.Size(82, 17);
            this.chkSelec.TabIndex = 7;
            this.chkSelec.Text = "Seleccionar";
            this.chkSelec.UseVisualStyleBackColor = true;
            // 
            // btnElimina
            // 
            this.btnElimina.Location = new System.Drawing.Point(353, 293);
            this.btnElimina.Name = "btnElimina";
            this.btnElimina.Size = new System.Drawing.Size(75, 23);
            this.btnElimina.TabIndex = 6;
            this.btnElimina.Text = "Eliminar";
            this.btnElimina.UseVisualStyleBackColor = true;
            this.btnElimina.Visible = false;
            // 
            // btnDesactiva
            // 
            this.btnDesactiva.Location = new System.Drawing.Point(245, 293);
            this.btnDesactiva.Name = "btnDesactiva";
            this.btnDesactiva.Size = new System.Drawing.Size(75, 23);
            this.btnDesactiva.TabIndex = 5;
            this.btnDesactiva.Text = "Desactivar";
            this.btnDesactiva.UseVisualStyleBackColor = true;
            this.btnDesactiva.Visible = false;
            // 
            // btnActiva
            // 
            this.btnActiva.Location = new System.Drawing.Point(139, 293);
            this.btnActiva.Name = "btnActiva";
            this.btnActiva.Size = new System.Drawing.Size(75, 23);
            this.btnActiva.TabIndex = 4;
            this.btnActiva.Text = "Activar";
            this.btnActiva.UseVisualStyleBackColor = true;
            this.btnActiva.Visible = false;
            // 
            // lbltota
            // 
            this.lbltota.AutoSize = true;
            this.lbltota.Location = new System.Drawing.Point(597, 303);
            this.lbltota.Name = "lbltota";
            this.lbltota.Size = new System.Drawing.Size(31, 13);
            this.lbltota.TabIndex = 3;
            this.lbltota.Text = "Total";
            // 
            // txtbusca
            // 
            this.txtbusca.Location = new System.Drawing.Point(16, 18);
            this.txtbusca.Name = "txtbusca";
            this.txtbusca.Size = new System.Drawing.Size(373, 20);
            this.txtbusca.TabIndex = 2;
            // 
            // btmBusca
            // 
            this.btmBusca.Location = new System.Drawing.Point(430, 18);
            this.btmBusca.Name = "btmBusca";
            this.btmBusca.Size = new System.Drawing.Size(109, 23);
            this.btmBusca.TabIndex = 1;
            this.btmBusca.Text = "Buscar";
            this.btmBusca.UseVisualStyleBackColor = true;
            this.btmBusca.Click += new System.EventHandler(this.btmBusca_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(224, 172);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(123, 172);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre(*)";
            // 
            // dgvListar
            // 
            this.dgvListar.AllowUserToAddRows = false;
            this.dgvListar.AllowUserToDeleteRows = false;
            this.dgvListar.AllowUserToOrderColumns = true;
            this.dgvListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListar.Location = new System.Drawing.Point(6, 47);
            this.dgvListar.Name = "dgvListar";
            this.dgvListar.ReadOnly = true;
            this.dgvListar.Size = new System.Drawing.Size(703, 240);
            this.dgvListar.TabIndex = 0;
            this.dgvListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListar_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.btnCancelar);
            this.tab1.Controls.Add(this.btnActualizar);
            this.tab1.Controls.Add(this.btnInsertar);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Controls.Add(this.label1);
            this.tab1.Controls.Add(this.txtDescripcion);
            this.tab1.Controls.Add(this.txtNombre);
            this.tab1.Controls.Add(this.txtID);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(725, 339);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Mantenimiento";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(198, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkSelec);
            this.tabPage3.Controls.Add(this.btnElimina);
            this.tabPage3.Controls.Add(this.btnDesactiva);
            this.tabPage3.Controls.Add(this.btnActiva);
            this.tabPage3.Controls.Add(this.lbltota);
            this.tabPage3.Controls.Add(this.txtbusca);
            this.tabPage3.Controls.Add(this.btmBusca);
            this.tabPage3.Controls.Add(this.dgvListar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(725, 339);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Listado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPage3);
            this.tabGeneral.Controls.Add(this.tab1);
            this.tabGeneral.Location = new System.Drawing.Point(33, 12);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(733, 365);
            this.tabGeneral.TabIndex = 2;
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabGeneral);
            this.Name = "FrmArticulo";
            this.Text = "Mantenimiento Articulo";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListar)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkSelec;
        private System.Windows.Forms.Button btnElimina;
        private System.Windows.Forms.Button btnDesactiva;
        private System.Windows.Forms.Button btnActiva;
        private System.Windows.Forms.Label lbltota;
        private System.Windows.Forms.TextBox txtbusca;
        private System.Windows.Forms.Button btmBusca;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabGeneral;
    }
}