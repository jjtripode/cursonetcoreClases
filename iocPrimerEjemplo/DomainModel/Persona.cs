using System;
using System.ComponentModel.DataAnnotations;
using iocPrimerEjemplo.DomainModel;

namespace iocPrimerEjemplo.DomainModel
{
    public abstract class  Persona<T> where T : TareaBase
    {
         public On_Task_Started_Delegate On_Task_Start;
         public On_Task_Ended_Delegate On_Task_end;

         public  Action<string> on_start;
        public string _profesion = string.Empty;
        private T _tarea;

[Key]
        public Guid Id {get;set;} 
        public string Nombre { get; set; }
         public string Apellido { get; set; }
         public string Documento { get;set; }


          public void RecibirTarea(T tarea)
          {
              tarea.on_start +=this.on_start;
              tarea.On_Task_Start+=this.On_Task_Start;
              tarea.On_Task_end+=this.On_Task_end;
              _tarea = tarea;
              
          }

         public void RealizarTarea()
         {
            if(_tarea!= null)
           {
               _tarea.Realizar();
           }
           _tarea=null;
         }

          public string Profesion()
          {
              return _profesion;
          } 
       
    }
}