namespace Eventos
{
    public class Numeros
    {
        private int num;

        public int Num
        {
            get => num;
            set
            {
                  num = value;
                if (num % 2 == 0 && Evento_Par != null)
                {
                  Evento_Par();
                }
               
            }
        }

        public delegate void NumeroPar();

        public event NumeroPar Evento_Par;
    }
}