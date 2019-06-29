namespace PracticaClase6
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Documento {get;set;}

        public abstract void Trabajar(ITarea tarea);

        public abstract string Profesion(); 

        public override string ToString()
        { 
            return $" nombre:{this.Nombre}  Apellido { Apellido } Documento { Documento } Profesion { Profesion() } "; 
        }
       
    }
}