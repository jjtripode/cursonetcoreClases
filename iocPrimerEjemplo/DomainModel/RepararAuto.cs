using System.Threading;

namespace iocPrimerEjemplo.DomainModel
{
     public class RepararAuto : TareaBase
    {
        public override void Realizar()
        {
            if (this.On_Task_Start != null)
            {
                this.On_Task_Start(this.GetType().ToString());
            }

           Thread.Sleep(1500);

            if (this.On_Task_end != null)
            {
                this.On_Task_end(this.GetType().ToString());
            }
        }
    }
}