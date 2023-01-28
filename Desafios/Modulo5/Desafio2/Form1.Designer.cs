namespace Desafio1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuadroNombre = new System.Windows.Forms.TextBox();
            this.calendario = new System.Windows.Forms.DateTimePicker();
            this.estado = new System.Windows.Forms.ComboBox();
            this.esExtranjero = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extranjero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.boxSexo = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.labelEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.boxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de registro:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado civil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Es Extranjero?";
            // 
            // cuadroNombre
            // 
            this.cuadroNombre.AccessibleName = "nombreTexto";
            this.cuadroNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cuadroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuadroNombre.Location = new System.Drawing.Point(88, 119);
            this.cuadroNombre.Multiline = true;
            this.cuadroNombre.Name = "cuadroNombre";
            this.cuadroNombre.Size = new System.Drawing.Size(214, 30);
            this.cuadroNombre.TabIndex = 5;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(88, 200);
            this.calendario.Name = "calendario";
            this.calendario.Size = new System.Drawing.Size(208, 20);
            this.calendario.TabIndex = 6;
            // 
            // estado
            // 
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Viudo",
            "Divorciado"});
            this.estado.Location = new System.Drawing.Point(88, 257);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(208, 33);
            this.estado.TabIndex = 8;
            this.estado.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // esExtranjero
            // 
            this.esExtranjero.AutoSize = true;
            this.esExtranjero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.esExtranjero.Location = new System.Drawing.Point(519, 223);
            this.esExtranjero.Name = "esExtranjero";
            this.esExtranjero.Size = new System.Drawing.Size(40, 22);
            this.esExtranjero.TabIndex = 11;
            this.esExtranjero.Text = "Si";
            this.esExtranjero.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 41);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agregar Alumno:";
            // 
            // agregar
            // 
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(513, 256);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(104, 36);
            this.agregar.TabIndex = 14;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // cerrar
            // 
            this.cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrar.Location = new System.Drawing.Point(629, 256);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(104, 36);
            this.cerrar.TabIndex = 16;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Fecha_De_Registro,
            this.EstadoCivil,
            this.Sexo,
            this.Extranjero});
            this.dataGridView1.Location = new System.Drawing.Point(135, 396);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 142);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Fecha_De_Registro
            // 
            this.Fecha_De_Registro.HeaderText = "Fecha_De_Registro";
            this.Fecha_De_Registro.Name = "Fecha_De_Registro";
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.HeaderText = "EstadoCivil";
            this.EstadoCivil.Name = "EstadoCivil";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Extranjero
            // 
            this.Extranjero.HeaderText = "Extranjero";
            this.Extranjero.Name = "Extranjero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Alumnos:";
            // 
            // boxSexo
            // 
            this.boxSexo.Controls.Add(this.radioButton3);
            this.boxSexo.Controls.Add(this.radioButton5);
            this.boxSexo.Location = new System.Drawing.Point(513, 119);
            this.boxSexo.Name = "boxSexo";
            this.boxSexo.Size = new System.Drawing.Size(164, 52);
            this.boxSexo.TabIndex = 19;
            this.boxSexo.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(7, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 22);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hombre";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(92, 13);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(63, 22);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Mujer";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(85, 305);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(409, 26);
            this.labelEstado.TabIndex = 20;
            this.labelEstado.Text = "Esperando la carga de un nuevo alumno!";
            this.labelEstado.Click += new System.EventHandler(this.labelEstado_Click_1);
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 603);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.boxSexo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.esExtranjero);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.cuadroNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.boxSexo.ResumeLayout(false);
            this.boxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        //incicio de inputs
        private System.Windows.Forms.TextBox cuadroNombre;
        private System.Windows.Forms.DateTimePicker calendario;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.CheckBox esExtranjero;
        //fin de inputs
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extranjero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox boxSexo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label labelEstado;
    }
}

