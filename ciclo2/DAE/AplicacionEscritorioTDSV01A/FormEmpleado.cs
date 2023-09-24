using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscritorioTDSV01A
{
    public partial class FormEmpleado : Form
    {
        Empleado objEmpleado = new Empleado();
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            cmbProfesion.SelectedIndex = 0;
        }

        public void llenarDatosEmpleado()
        {
            objEmpleado.Id = int.Parse(txtIdEmpleado.Text);
            objEmpleado.Nombres = txtNombres.Text;
            objEmpleado.Apellidos = txtApellidos.Text;
            objEmpleado.SueldoBase = double.Parse(txtSueldoBase.Text);
            objEmpleado.Direccion = txtDireccion.Text;
            objEmpleado.Profesion = cmbProfesion.SelectedItem.ToString();
            if (radioMasculino.Checked)
            {
                objEmpleado.Sexo = "Masculino";
            }else if (radioFemenino.Checked)
            {
                objEmpleado.Sexo = "Femenino";
            }
            objEmpleado.calcularSalario();
            double aporteIsss = objEmpleado.calcularISSS();
            MessageBox.Show("Nombres: "+objEmpleado.Nombres+
                "\n Apellidos: "+objEmpleado.Apellidos+ 
                "\n Sueldo Neto: "+objEmpleado.SueldoNeto+
                "\n Profesion: "+objEmpleado.Profesion+ 
                "\n Sexo: "+objEmpleado.Sexo+
                "\n Direccion: "+objEmpleado.Direccion);
        }

        private void btnCalcularyMostrar_Click(object sender, EventArgs e)
        {
            this.llenarDatosEmpleado();
        }
    }
}
