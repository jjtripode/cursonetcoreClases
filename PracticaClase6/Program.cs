using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticaClase6
{
    class Program
    {
        static void Main(string[] args)
        {
            var mec = new Mecanico();

            PoolDeTareas pool = new PoolDeTareas();

            mec.On_Task_Start += (string taskName) => {Console.WriteLine("----------------------"); Console.WriteLine($"{ taskName } inicio de la tarea"); };
            mec.on_start += (string task) => { };
            mec.On_Task_end += (string taskName) => { Console.WriteLine($"{ taskName } Fin de la tarea"); Console.WriteLine("----------------------");};

            var pin = new Pintor();

            pin.On_Task_Start += OnStart;
            pin.On_Task_end += OnEnd;

            for (int i=1; i < 50;i++ )
            {
                pool.TomarTarea(mec);
                mec.RealizarTarea();

                pool.TomarTarea(pin);
                pin.RealizarTarea();


            }
            Console.WriteLine("Fin de proceso");
            Console.ReadKey();
        }

        private static void OnStart(string taskName)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"{ taskName } inicio de la tarea");
        }

        private static void OnEnd(string taskName)
        {   
            Console.WriteLine($"{ taskName } fin de la tarea");
            Console.WriteLine("----------------------");
        }
    }
}
