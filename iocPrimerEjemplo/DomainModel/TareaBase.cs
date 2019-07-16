using System;

namespace iocPrimerEjemplo.DomainModel
{
  public abstract class TareaBase:ITarea
    {
        public Action<string> on_start;
        public On_Task_Started_Delegate On_Task_Start;
        public On_Task_Ended_Delegate On_Task_end;

        public string Info()
        {
            return (this.GetType().ToString());
        }
        public abstract void Realizar();

    }
}