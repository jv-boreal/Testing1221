
namespace ABMPersona
{
    partial class frmPersonas
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtModo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(613, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Nuevo";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboEmp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDni);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.dg1);
            this.panel1.Location = new System.Drawing.Point(12, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 494);
            this.panel1.TabIndex = 1;
            // 
            // cboEmp
            // 
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.cboEmp.Location = new System.Drawing.Point(55, 287);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(91, 28);
            this.cboEmp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Es empleado? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(55, 208);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(145, 26);
            this.txtDni.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(52, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(504, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido/s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre/s";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(52, 131);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(499, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // dg1
            // 
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Apellido,
            this.Nombre,
            this.Documento,
            this.Empleado});
            this.dg1.Location = new System.Drawing.Point(279, 461);
            this.dg1.Name = "dg1";
            this.dg1.ReadOnly = true;
            this.dg1.RowHeadersVisible = false;
            this.dg1.RowHeadersWidth = 62;
            this.dg1.RowTemplate.Height = 28;
            this.dg1.Size = new System.Drawing.Size(301, 30);
            this.dg1.TabIndex = 2;
            this.dg1.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 150;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 8;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.MinimumWidth = 8;
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            this.Documento.Width = 150;
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.MinimumWidth = 8;
            this.Empleado.Name = "Empleado";
            this.Empleado.ReadOnly = true;
            this.Empleado.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 65);
            this.panel2.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(601, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 32);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 26);
            this.txtID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID:";
            // 
            // btnModi
            // 
            this.btnModi.Location = new System.Drawing.Point(613, 188);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(126, 34);
            this.btnModi.TabIndex = 9;
            this.btnModi.Text = "Modificar";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(613, 240);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(613, 293);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(126, 34);
            this.btnGrabar.TabIndex = 7;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(613, 552);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 34);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(350, 546);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(0, 20);
            this.lblIndex.TabIndex = 9;
            // 
            // txtModo
            // 
            this.txtModo.Location = new System.Drawing.Point(389, 552);
            this.txtModo.Name = "txtModo";
            this.txtModo.Size = new System.Drawing.Size(49, 26);
            this.txtModo.TabIndex = 10;
            this.txtModo.Visible = false;
            // 
            // frmPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtModo);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmPersonas";
            this.Text = "Registro de personas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.TextBox txtModo;
        private System.Windows.Forms.Button btnBuscar;
    }
}

