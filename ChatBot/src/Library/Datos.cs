using System;
namespace Library
{
    public class Datos
    {
        public string Nombre { get; set; }
        public string Apellido {get; set;}

        public string Mail {get; set;}

        public string Celular {get; set;}

        public string Cédula {get; set;}

        public List<Calificar> Reputacion {get; set;}
        public Datos(string Nombre, string Celular, string Mail, string Cédula)
        {
            this.Nombre = Nombre;
            this.Celular = Celular;
            this.Mail = Mail;
            this.Cédula = Cédula;
            this.Reputacion = new List<Calificar>();
        }
        
    }
}
