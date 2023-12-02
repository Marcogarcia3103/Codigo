namespace Proyecto_Coppel
{
    partial class FormEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbPuesto = new System.Windows.Forms.ComboBox();
            this.cbCentroTrabajo = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtbRfc = new System.Windows.Forms.TextBox();
            this.txtbFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtbAMaterno = new System.Windows.Forms.TextBox();
            this.txtbAPaterno = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtbDirectivo = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtbDirectivo);
            this.panel1.Controls.Add(this.cbPuesto);
            this.panel1.Controls.Add(this.cbCentroTrabajo);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtbRfc);
            this.panel1.Controls.Add(this.txtbFechaNacimiento);
            this.panel1.Controls.Add(this.txtbAMaterno);
            this.panel1.Controls.Add(this.txtbAPaterno);
            this.panel1.Controls.Add(this.txtbNombre);
            this.panel1.Controls.Add(this.txtbNumero);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 162);
            this.panel1.TabIndex = 0;
            // 
            // cbPuesto
            // 
            this.cbPuesto.FormattingEnabled = true;
            this.cbPuesto.Location = new System.Drawing.Point(363, 69);
            this.cbPuesto.Name = "cbPuesto";
            this.cbPuesto.Size = new System.Drawing.Size(175, 21);
            this.cbPuesto.TabIndex = 23;
            // 
            // cbCentroTrabajo
            // 
            this.cbCentroTrabajo.FormattingEnabled = true;
            this.cbCentroTrabajo.Location = new System.Drawing.Point(401, 40);
            this.cbCentroTrabajo.Name = "cbCentroTrabajo";
            this.cbCentroTrabajo.Size = new System.Drawing.Size(137, 21);
            this.cbCentroTrabajo.TabIndex = 22;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(432, 136);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(351, 136);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(513, 136);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 21;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(270, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtbRfc
            // 
            this.txtbRfc.Location = new System.Drawing.Point(351, 11);
            this.txtbRfc.Name = "txtbRfc";
            this.txtbRfc.Size = new System.Drawing.Size(187, 20);
            this.txtbRfc.TabIndex = 14;
            // 
            // txtbFechaNacimiento
            // 
            this.txtbFechaNacimiento.Location = new System.Drawing.Point(131, 123);
            this.txtbFechaNacimiento.Name = "txtbFechaNacimiento";
            this.txtbFechaNacimiento.Size = new System.Drawing.Size(111, 20);
            this.txtbFechaNacimiento.TabIndex = 13;
            // 
            // txtbAMaterno
            // 
            this.txtbAMaterno.Location = new System.Drawing.Point(105, 99);
            this.txtbAMaterno.Name = "txtbAMaterno";
            this.txtbAMaterno.Size = new System.Drawing.Size(137, 20);
            this.txtbAMaterno.TabIndex = 12;
            // 
            // txtbAPaterno
            // 
            this.txtbAPaterno.Location = new System.Drawing.Point(105, 69);
            this.txtbAPaterno.Name = "txtbAPaterno";
            this.txtbAPaterno.Size = new System.Drawing.Size(137, 20);
            this.txtbAPaterno.TabIndex = 11;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Location = new System.Drawing.Point(65, 40);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(177, 20);
            this.txtbNombre.TabIndex = 10;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(65, 11);
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(177, 20);
            this.txtbNumero.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Directivo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Puesto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(298, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Centro De Trabajo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "RFC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha De Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Materno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 180);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(597, 143);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // txtbDirectivo
            // 
            this.txtbDirectivo.AutoSize = true;
            this.txtbDirectivo.Location = new System.Drawing.Point(363, 102);
            this.txtbDirectivo.Name = "txtbDirectivo";
            this.txtbDirectivo.Size = new System.Drawing.Size(144, 17);
            this.txtbDirectivo.TabIndex = 24;
            this.txtbDirectivo.Text = "Si eres directivo presiona";
            this.txtbDirectivo.UseVisualStyleBackColor = true;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 325);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmpleado";
            this.Text = "Formulario De Empleados";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtbRfc;
        private System.Windows.Forms.TextBox txtbFechaNacimiento;
        private System.Windows.Forms.TextBox txtbAMaterno;
        private System.Windows.Forms.TextBox txtbAPaterno;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPuesto;
        private System.Windows.Forms.ComboBox cbCentroTrabajo;
        private System.Windows.Forms.CheckBox txtbDirectivo;
    }
}