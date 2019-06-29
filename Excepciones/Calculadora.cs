using System;

namespace Excepciones
{
    public static class Calculadora
    {
        public static decimal Calcular( string op, int x , int y )
        {
            if(string.IsNullOrEmpty(op) )
            {
                 throw new ArgumentNullException(nameof(op));
            }

            if( op == "/" ) 
            {
                try
                {
                    return Division(x,y);
                }
                catch  (DivideByZeroException e)
                {
                    throw new InvalidOperationException("Operacion invalida",e) ;
                }
            }
            else
            {
                throw new CalculadoraFaltaOperadorException($"Operador {op} no soportado");
            }
        }

        private static decimal Division(int x, int y)
        {
           return x/y;
        }
    }
}