using System;
namespace Library
{
    public class Ubicacion
    {
        public string Pais { get; set; }
        public void IngresarPais()
        {
            Console.WriteLine("Ingrese su país: ");
            Pais = Console.ReadLine();
        }
        public string Provincia { get; set; }
        public void IngresarProvincia()
        {
            Console.WriteLine("Ingrese su provincia: ");
            Provincia = Console.ReadLine();
        }
        public string Ciudad { get; set; }
        public void IngresarCiudad()
        {
            Console.WriteLine("Ingrese su ciudad: ");
            Ciudad = Console.ReadLine();
        }
        public string Barrio { get; set; }
        public void IngresarBarrio()
        {
            Console.WriteLine("Ingrese su barrio: ");
            Barrio = Console.ReadLine();
        }
        public string Calle { get; set; }
        public void IngresarCalle()
        {
            Console.WriteLine("Ingrese su calle: ");
            Calle = Console.ReadLine();
        }
        public string Numero { get; set; }
        public void IngresarNumero()
        {
            Console.WriteLine("Ingrese su número: ");
            Numero = Console.ReadLine();
        }

        Direccion = Calle + " " + Numero + ", " + Barrio + ", " + Ciudad + ", " + Provincia + ", " + Pais;
    }
}