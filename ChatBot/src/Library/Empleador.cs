class Empleador
{
    private string SearchJobOffers{get; set;}
    
    private string SeeOffersUbication{get; set;}
    
    private string SeeOffersReputation{get; set;}
    
    public void ContactWorker()
    {
    }
   
    private double GradeWorker() : Administrador
    {
        double calificacion = Console.ReadLine("Ingrese la calificación del trabajador");
        return(calificacion)
        
        //double promedio += calificacion/cantidadDeEmpleadores //va en base de datos
    }


}
