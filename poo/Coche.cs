using System;
namespace poo
{
    public class Coche
    {
        public string patante;
        public string color;
        public string marca;
        public string modelo;
        protected double velocidad = 0;

public double Velocidad 
{ get {return velocidad;}  }

        public Coche(string patente,
         string color,
          string marca,
         string modelo)
        {
            this.patante = patente;
            this.color = color;
            this.marca = marca;
            this.modelo = modelo;
            this.velocidad = 0
            ;
        }


        public virtual void Acelerar(double incremento)
        {
            Console.WriteLine("Incrementando la velocidad {0} km/h", incremento);

            this.velocidad += incremento;

            Console.WriteLine($"velocidad {this.velocidad} km/h"  );

        }

        public void Girar(double cantidad)
        {
            Console.WriteLine("Girando {0} grados", cantidad);
        }

        public void Frenar(double cantidad)
        {
            Console.WriteLine("Frenando {0} km/h", cantidad);
        }

    }
}