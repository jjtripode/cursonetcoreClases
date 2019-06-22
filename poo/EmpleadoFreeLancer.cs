using System;

namespace poo
{
    public class EmpleadoFreeLancer : Empleado
    {
        public EmpleadoFreeLancer(string dni, string nombre, string apellido, double valorHora, int horasMensuales) : base(dni, nombre, apellido)
        {
            this.valorHora = valorHora;
            this.horasMensuales = horasMensuales;
        }

        public double valorHora ;
        public double horasMensuales ;

        public override double SueldoMensual()
        {
            Console.WriteLine($"Sueldo Mensual: {this.valorHora * horasMensuales}");
           return this.valorHora * horasMensuales;
        }
    }
}