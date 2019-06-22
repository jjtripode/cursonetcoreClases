namespace poo
{
    public abstract class Empleado
    {
        public int DNI {get;}
        public string Nombre { get;  }
        public string Apellido { get;  }

        public Empleado(string dni,string  nombre,string  apellido)
        {
        this.Nombre = nombre;
        }

        public abstract double SueldoMensual();
    }
}