namespace Eventos
{
    public class Numeros
    {
        private int num;

        public int Num { get => num; set => num = value; }

        public delegate void NumeroPar();

       public event NumeroPar EventoPar;
       }
}