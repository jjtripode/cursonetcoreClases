using System;

namespace Excepciones
{
    public class CalculadoraFaltaOperadorException : Exception
    {
        private static readonly string  DefaultMessage = "Ocurrio un Error Inesperado";

        public CalculadoraFaltaOperadorException():base(DefaultMessage)
        {
        }

        public CalculadoraFaltaOperadorException(string message):base(message)
        {
        }

        public CalculadoraFaltaOperadorException(string message, Exception innerException):base(message,innerException)
        {
        }
    }
}