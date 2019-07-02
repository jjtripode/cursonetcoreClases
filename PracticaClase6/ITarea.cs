using System;
using System.Threading;
using System.Threading.Tasks;

namespace PracticaClase6
{
    public delegate void On_Task_Started_Delegate(string taskName);
    public delegate void On_Task_Ended_Delegate(string taskName);

    public interface  ITarea
    {
        string Info();
        
        void Realizar();
    }

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
    public class Pintar : TareaBase
    {
        public override void Realizar()
        {
            if (this.On_Task_Start != null)
            {
                this.On_Task_Start(this.GetType().ToString());
            }

            Thread.Sleep(3000);

            if (this.On_Task_end != null)
            {
                this.On_Task_end(this.GetType().ToString());
            }
        }
    }

    public class RepararAuto : TareaBase
    {
        public override void Realizar()
        {
            if (this.On_Task_Start != null)
            {
                this.On_Task_Start(this.GetType().ToString());
            }

           Thread.Sleep(3000);

            if (this.On_Task_end != null)
            {
                this.On_Task_end(this.GetType().ToString());
            }
        }
    }

}