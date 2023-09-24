namespace AplicacionEscritorioTDSV01A
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
            groupBoxDatosGenerales = new GroupBox();
            label5 = new Label();
            radioFemenino = new RadioButton();
            radioMasculino = new RadioButton();
            cmbProfesion = new ComboBox();
            label4 = new Label();
            txtIdEmpleado = new TextBox();
            btnCalcularyMostrar = new Button();
            label3 = new Label();
            label2 = new Label();
            txtSueldoBase = new TextBox();
            txtApellidos = new TextBox();
            label1 = new Label();
            txtNombres = new TextBox();
            labelNombres = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            groupBoxDatosGenerales.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDatosGenerales
            // 
            groupBoxDatosGenerales.Controls.Add(txtDireccion);
            groupBoxDatosGenerales.Controls.Add(label6);
            groupBoxDatosGenerales.Controls.Add(label5);
            groupBoxDatosGenerales.Controls.Add(radioFemenino);
            groupBoxDatosGenerales.Controls.Add(radioMasculino);
            groupBoxDatosGenerales.Controls.Add(cmbProfesion);
            groupBoxDatosGenerales.Controls.Add(label4);
            groupBoxDatosGenerales.Controls.Add(txtIdEmpleado);
            groupBoxDatosGenerales.Controls.Add(btnCalcularyMostrar);
            groupBoxDatosGenerales.Controls.Add(label3);
            groupBoxDatosGenerales.Controls.Add(label2);
            groupBoxDatosGenerales.Controls.Add(txtSueldoBase);
            groupBoxDatosGenerales.Controls.Add(txtApellidos);
            groupBoxDatosGenerales.Controls.Add(label1);
            groupBoxDatosGenerales.Controls.Add(txtNombres);
            groupBoxDatosGenerales.Controls.Add(labelNombres);
            groupBoxDatosGenerales.Location = new Point(46, 63);
            groupBoxDatosGenerales.Name = "groupBoxDatosGenerales";
            groupBoxDatosGenerales.Size = new Size(957, 499);
            groupBoxDatosGenerales.TabIndex = 2;
            groupBoxDatosGenerales.TabStop = false;
            groupBoxDatosGenerales.Text = "Datos Generales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 225);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 14;
            label5.Text = "Sexo";
            // 
            // radioFemenino
            // 
            radioFemenino.AutoSize = true;
            radioFemenino.Location = new Point(676, 265);
            radioFemenino.Name = "radioFemenino";
            radioFemenino.Size = new Size(95, 24);
            radioFemenino.TabIndex = 13;
            radioFemenino.TabStop = true;
            radioFemenino.Text = "Femenino";
            radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            radioMasculino.AutoSize = true;
            radioMasculino.Location = new Point(512, 264);
            radioMasculino.Name = "radioMasculino";
            radioMasculino.Size = new Size(97, 24);
            radioMasculino.TabIndex = 12;
            radioMasculino.TabStop = true;
            radioMasculino.Text = "Masculino";
            radioMasculino.UseVisualStyleBackColor = true;
            // 
            // cmbProfesion
            // 
            cmbProfesion.FormattingEnabled = true;
            cmbProfesion.Items.AddRange(new object[] { "Desarrollador de Software", "DBA", "Analista de Datos", "QA" });
            cmbProfesion.Location = new Point(512, 89);
            cmbProfesion.Name = "cmbProfesion";
            cmbProfesion.Size = new Size(390, 28);
            cmbProfesion.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 56);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 10;
            label4.Text = "Profesion";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(40, 90);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(390, 27);
            txtIdEmpleado.TabIndex = 9;
            // 
            // btnCalcularyMostrar
            // 
            btnCalcularyMostrar.Location = new Point(762, 413);
            btnCalcularyMostrar.Name = "btnCalcularyMostrar";
            btnCalcularyMostrar.Size = new Size(140, 64);
            btnCalcularyMostrar.TabIndex = 8;
            btnCalcularyMostrar.Text = "Calcular y Mostrar";
            btnCalcularyMostrar.UseVisualStyleBackColor = true;
            btnCalcularyMostrar.Click += btnCalcularyMostrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 56);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 6;
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 225);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Sueldo Base";
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.Location = new Point(36, 264);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.Size = new Size(394, 27);
            txtSueldoBase.TabIndex = 4;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(512, 167);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(392, 27);
            txtApellidos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(510, 133);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "Apellidos";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(40, 167);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(390, 27);
            txtNombres.TabIndex = 1;
            // 
            // labelNombres
            // 
            labelNombres.AutoSize = true;
            labelNombres.Location = new Point(40, 130);
            labelNombres.Name = "labelNombres";
            labelNombres.Size = new Size(70, 20);
            labelNombres.TabIndex = 0;
            labelNombres.Text = "Nombres";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 328);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 15;
            label6.Text = "Direccion";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(36, 361);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(394, 116);
            txtDireccion.TabIndex = 16;
            // 
            // FormEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 637);
            Controls.Add(groupBoxDatosGenerales);
            Name = "FormEmpleado";
            Text = "FormEmpleado";
            Load += FormEmpleado_Load;
            groupBoxDatosGenerales.ResumeLayout(false);
            groupBoxDatosGenerales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxDatosGenerales;
        private Button btnCalcularyMostrar;
        private Label label3;
        private Label label2;
        private TextBox txtSueldoBase;
        private TextBox txtApellidos;
        private Label label1;
        private TextBox txtNombres;
        private Label labelNombres;
        private TextBox txtIdEmpleado;
        private ComboBox cmbProfesion;
        private Label label4;
        private Label label5;
        private RadioButton radioFemenino;
        private RadioButton radioMasculino;
        private TextBox txtDireccion;
        private Label label6;
    }
}