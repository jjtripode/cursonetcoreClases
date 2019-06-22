using System;

namespace poo
{
    public class EmpleadoFullTime : Empleado
    {
        public EmpleadoFullTime(string dni, string nombre, string apellido, double sueldo) : base(dni, nombre, apellido)
        {
            this.Sueldo = sueldo;
        }

        public double Sueldo ;

        public override double SueldoMensual()
        {
            Console.WriteLine($"Sueldo Mensual: {this.Sueldo}");
           return this.Sueldo;
        }
    }
}