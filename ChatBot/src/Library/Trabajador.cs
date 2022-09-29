class Trabajador
{
    private void SeeEmployeeReputation{get; set;}
    
    private string MakeOfferServices()
    {
        Console.WriteLine(Administrador.CategoriesList);
        Console.ReadLine("Indique su categoría");
    }
   
    public double GradeEmployee() : Administrador
    {
        double calificacionEmpleador = Console.ReadLine("Ingrese la calificación del Empleador:");
        return(calificacionEmpleador);
        
        //double promedio += calificacion/cantidadDeEmpleadores //va en base de datos
    }

}
