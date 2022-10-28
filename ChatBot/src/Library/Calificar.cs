namespace Library
{
    public class Calificar
    {
        public double Calificacion{get; set;}
        public string Comentario{get; set;}
        
        public Calificar(double calificacion, string comentario)
        {
            this.Calificacion = calificacion;
            this.Comentario = comentario;
        }
    
        public string comentario
        {
            get
            {
                return this.Comentario;
            }
            set
            {
                if(value.Length != 0)
                {
                    this.Comentario = value;
                }
                else
                {
                    throw new Exception("El comentario debe tener entre 1 y 100 caracteres");
                }
            }
        }
        public double calificacion
        {
            get
            {
                return this.Calificacion;
            }
            set
            {
                if(value > 0 && value  <=10)
                {
                    this.Calificacion = value;
                }
                else
                {
                    throw new Exception("La calificación debe ser entre 0 y 10");
                }
            }
        }

        public static double promedio(Datos datos)
        {
            double promedio = 0;
            foreach (Calificar calificar in datos.Reputacion)
            {
                promedio += calificar.Calificacion;
            }
            double promedioTotal = promedio / datos.Reputacion.Count;
            return promedioTotal;
        }
    }
}