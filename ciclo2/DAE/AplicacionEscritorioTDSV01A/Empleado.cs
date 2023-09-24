using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorioTDSV01A
{
    internal class Empleado
    {
        private int id;
        private string nombres;
        private string apellidos;
        private double sueldoBase;
        private double sueldoNeto;
        private string sexo;
        private string direccion;
        private string profesion;
        public Empleado()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public double SueldoBase { get => sueldoBase; set => sueldoBase = value; }
        public double SueldoNeto { get => sueldoNeto; set => sueldoNeto = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Profesion { get => profesion; set => profesion = value; }

        public void calcularSalario()
        {
            this.sueldoNeto = this.sueldoBase - (this.sueldoBase * 0.10);
        }

        public double calcularISSS()
        {
            double aporteIsss = this.sueldoBase * 0.03;
            return aporteIsss;
        }
    }
}
