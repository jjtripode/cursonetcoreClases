using System;

namespace poo
{
    public class CuentaCorriente
    {
        protected double saldo = 0;

        public double Saldo { get { return this.saldo; } }

        public bool Extraccion(double cantidad)
        {
            if (cantidad > 0)
            {
                this.saldo -= cantidad;
                return true;
            }
            return false;
        }

        public void Deposito( double cantidad, double dollares)
        {
            Console.WriteLine($" B - Depositando : {cantidad} - { dollares }");

            this.saldo += cantidad + dollares;

            Console.WriteLine($" Saldo actual  {this.Saldo} ");
        }

        public void Deposito( double cantidad)
        {
            Console.WriteLine($"  Depositando - double : {cantidad}");
            this.saldo += cantidad;

            Console.WriteLine($" Saldo actual  {this.Saldo} ");
        }

        public void Deposito( float cantidad)
        {
            Console.WriteLine($" Depositando -float- : {cantidad}");

            this.saldo += cantidad;

            Console.WriteLine($" Saldo actual  {this.Saldo} ");
        }

public static string Nombre;
        public void Deposito( int cantidad)
        {
            Console.WriteLine($" Depositando -int- : {cantidad}");

            this.saldo += cantidad;

            Console.WriteLine($" Saldo actual  {this.Saldo} ");
        }

        public static void SetearValor (string nuevo)
        {
            Nombre = nuevo;
        }
    }
}