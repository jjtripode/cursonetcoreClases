using System;
using System.Threading;
using System.Threading.Tasks;

namespace iocPrimerEjemplo.DomainModel
{
    public delegate void On_Task_Started_Delegate(string taskName);
    public delegate void On_Task_Ended_Delegate(string taskName);

    public interface  ITarea
    {
        string Info();
        
        void Realizar();
    }
}