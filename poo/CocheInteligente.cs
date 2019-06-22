using System;

namespace poo
{
    public class CocheInteligente : Coche
    {
        public CocheInteligente(string patente,
         string color, 
         string marca, 
         string modelo) : base(patente, color, marca, modelo)
        {
        }

        public void Estacionar()
        {
            Console.WriteLine("Estacionando el auto modo Automatico");
            velocidad=0;
            Console.WriteLine($"Velocida actual {Velocidad} km/h ");
        }

        public override void Acelerar(double incremento)
        {
            Console.WriteLine("Accionando mecanismo avanzado de Aceleracion");

             Console.WriteLine("Incrementando la velocidad {0} km/h", incremento);

            this.velocidad += incremento;

            Console.WriteLine($"velocidad {this.velocidad} km/h"  );
        }
    }
}