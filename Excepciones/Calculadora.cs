using System;

namespace Excepciones
{
    public static class Calculadora
    {
        public static decimal Calcular( string op, int x , int y )
        {
            if( op == "/" ) 
            {
                return Division(x,y);
            }
            else
            {
                throw new Exception($"Operador {op} no soportado");
            }
        }

        private static decimal Division(int x, int y)
        {
           return x/y;
        }
    }
}