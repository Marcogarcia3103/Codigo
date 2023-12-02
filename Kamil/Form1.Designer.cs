namespace Proyecto_Coppel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscarEmpleados = new System.Windows.Forms.Button();
            this.BtnAgregarEmpleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnBuscarDirectivo = new System.Windows.Forms.Button();
            this.BtnAgregarDirectivos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBuscarCentro = new System.Windows.Forms.Button();
            this.BtnAgregarCentro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(234, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu De Opciones Kamil";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnBuscarEmpleados);
            this.panel1.Controls.Add(this.BtnAgregarEmpleados);
            this.panel1.Controls.Add(this.BtnAgregarEmpleados);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 172);
            this.panel1.TabIndex = 2;
            this.panel1.BackColor = System.Drawing.Color.White;

            // 
            // BtnBuscarEmpleados
            // 
            this.BtnBuscarEmpleados.Location = new System.Drawing.Point(25, 121);
            this.BtnBuscarEmpleados.Name = "BtnBuscarEmpleados";
            this.BtnBuscarEmpleados.Size = new System.Drawing.Size(122, 37);
            this.BtnBuscarEmpleados.TabIndex = 3;
            this.BtnBuscarEmpleados.Text = "Buscar Empleado";
            this.BtnBuscarEmpleados.UseVisualStyleBackColor = true;
            this.BtnBuscarEmpleados.Click += new System.EventHandler(this.BtnBuscarEmpleados_Click);
            this.BtnBuscarEmpleados.BackColor = System.Drawing.Color.LightYellow;

            // 
            // BtnAgregarEmpleados
            // 
            this.BtnAgregarEmpleados.Location = new System.Drawing.Point(25, 62);
            this.BtnAgregarEmpleados.Name = "BtnAgregarEmpleados";
            this.BtnAgregarEmpleados.Size = new System.Drawing.Size(122, 37);
            this.BtnAgregarEmpleados.TabIndex = 2;
            this.BtnAgregarEmpleados.Text = "Ver Empleados";
            this.BtnAgregarEmpleados.UseVisualStyleBackColor = true;
            this.BtnAgregarEmpleados.Click += new System.EventHandler(this.BtnAgregarEmpleados_Click);
            this.BtnAgregarEmpleados.BackColor = System.Drawing.Color.LightYellow;

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empleados";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnBuscarDirectivo);
            this.panel2.Controls.Add(this.BtnAgregarDirectivos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(234, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 172);
            this.panel2.TabIndex = 3;
            this.panel2.BackColor = System.Drawing.Color.White;

            // 
            // BtnBuscarDirectivo
            // 
            this.BtnBuscarDirectivo.Location = new System.Drawing.Point(31, 121);
            this.BtnBuscarDirectivo.Name = "BtnBuscarDirectivo";
            this.BtnBuscarDirectivo.Size = new System.Drawing.Size(117, 37);
            this.BtnBuscarDirectivo.TabIndex = 5;
            this.BtnBuscarDirectivo.Text = "Buscar Directivo";
            this.BtnBuscarDirectivo.UseVisualStyleBackColor = true;
            this.BtnBuscarDirectivo.Click += new System.EventHandler(this.BtnBuscarDirectivo_Click);
            this.BtnBuscarDirectivo.BackColor = System.Drawing.Color.LightYellow;
            // 
            // BtnAgregarDirectivos
            // 
            this.BtnAgregarDirectivos.Location = new System.Drawing.Point(31, 62);
            this.BtnAgregarDirectivos.Name = "BtnAgregarDirectivos";
            this.BtnAgregarDirectivos.Size = new System.Drawing.Size(117, 37);
            this.BtnAgregarDirectivos.TabIndex = 4;
            this.BtnAgregarDirectivos.Text = "Ver Directivos";
            this.BtnAgregarDirectivos.UseVisualStyleBackColor = true;
            this.BtnAgregarDirectivos.Click += new System.EventHandler(this.BtnAgregarDirectivos_Click);
            this.BtnAgregarDirectivos.BackColor = System.Drawing.Color.LightYellow;

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Directivos";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnBuscarCentro);
            this.panel3.Controls.Add(this.BtnAgregarCentro);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(442, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(179, 172);
            this.panel3.TabIndex = 4;
            this.panel3.BackColor = System.Drawing.Color.White;

            // 
            // BtnBuscarCentro
            // 
            this.BtnBuscarCentro.Location = new System.Drawing.Point(35, 121);
            this.BtnBuscarCentro.Name = "BtnBuscarCentro";
            this.BtnBuscarCentro.Size = new System.Drawing.Size(111, 37);
            this.BtnBuscarCentro.TabIndex = 7;
            this.BtnBuscarCentro.Text = "Buscar Centro";
            this.BtnBuscarCentro.UseVisualStyleBackColor = true;
            this.BtnBuscarCentro.Click += new System.EventHandler(this.BtnBuscarCentro_Click);
            this.BtnBuscarCentro.BackColor = System.Drawing.Color.LightYellow;

            // 
            // BtnAgregarCentro
            // 
            this.BtnAgregarCentro.Location = new System.Drawing.Point(35, 62);
            this.BtnAgregarCentro.Name = "BtnAgregarCentro";
            this.BtnAgregarCentro.Size = new System.Drawing.Size(111, 37);
            this.BtnAgregarCentro.TabIndex = 6;
            this.BtnAgregarCentro.Text = "Ver Centros";
            this.BtnAgregarCentro.UseVisualStyleBackColor = true;
            this.BtnAgregarCentro.Click += new System.EventHandler(this.BtnAgregarCentro_Click);
            this.BtnAgregarCentro.BackColor = System.Drawing.Color.LightYellow;

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Centros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 322);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Proyecto Coppel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();   

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscarEmpleados;
        private System.Windows.Forms.Button BtnAgregarEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnBuscarDirectivo;
        private System.Windows.Forms.Button BtnAgregarDirectivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBuscarCentro;
        private System.Windows.Forms.Button BtnAgregarCentro;
        private System.Windows.Forms.Label label4;
    }
}

