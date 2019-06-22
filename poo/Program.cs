
using System;

namespace poo
{
    class Program
    {
        //herencia
        //polimorfismo
        //encasulamiento
        //
        static void Main(string[] args)
        {

Empleado emp = new EmpleadoFullTime("11233456","Raul", "Otero",30000);


Empleado empF = new EmpleadoFreeLancer("11233456","Raul", "Perez",534,160);

Console.WriteLine($"El empleado { emp.Nombre } cobra { emp.SueldoMensual() }");
Console.WriteLine($"El empleado { empF.Nombre } cobra { empF.SueldoMensual() }");


            // CuentaCorriente cc = new CuentaCorriente();

            // cc.Deposito(200.55);

            // cc.Deposito(200);

            // cc.Deposito(200.55, 600);

            // Coche coche = new Coche("AA111AA", "Blanco", "Chevrolet", "Onix");
            //    CocheInteligente coche = new CocheInteligente("AA111AA", "Blanco", "Chevrolet", "Onix");


            //     Console.WriteLine(" Marca: {0} Modelo. {1} color:{2} patente: {3}"
            //     , new[] { coche.marca, coche.modelo, coche.color, coche.patante });

            //     coche.Acelerar(100);

            //     coche.Frenar(100);

            //     Console.WriteLine($"Velocida actual {coche.Velocidad} km/h ");

            //     coche.Girar(45);

            //     coche.Estacionar();

        }
    }
}
