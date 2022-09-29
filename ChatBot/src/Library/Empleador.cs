class Empleador
{
    private string SearchJobOffers{get; set;}
    
    private string SeeOffersUbication{get; set;}
    
    private string SeeOffersReputation{get; set;}
    
    Register nuevoRegistroEmpleador = new Register("nuevoRegistroEmpleador")
    nuevoRegistroEmpleador.Nombre = new Nombre();
    // Lo mismo con cada dato; Apellido, driceccion, etc.
    
    public void ContactWorker()
    {
    }
   
    private double GradeWorker() : Administrador
    {
        double calificacionTrabajador = Console.ReadLine("Ingrese la calificación del trabajador");
        return(calificacionTrabajador)
        
        //double promedio += calificacion/cantidadDeEmpleadores //va en base de datos
    }


}
