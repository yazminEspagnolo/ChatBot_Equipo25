using System;
namespace Library
{
    public class Register
    {
        public string Nombre { get; set; }
        public void IngresarNombre()
        {
            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
        }

        public string Apellido { get; set; }
        public void IngresarApellido()
        {
            Console.WriteLine("Ingrese su apellido: ");
            Apellido = Console.ReadLine();
        }

        public string Direccion { get; set; }
        public void IngresarDireccion()
        {
            Ubicacion ubicacion = new Ubicacion();
            ubicacion.IngresarPais();
            ubicacion.IngresarProvincia();
            ubicacion.IngresarCiudad();
            ubicacion.IngresarBarrio();
            ubicacion.IngresarCalle();
            ubicacion.IngresarNumero();
            Direccion = ubicacion.Direccion;
        }

        public string Telefono { get; set; }
        public void IngresarTelefono()
        {
            Console.WriteLine("Ingrese su teléfono: ");
            Telefono = Console.ReadLine();
        }

        public string Email { get; set; }
        public void IngresarEmail()
        {
            Console.WriteLine("Ingrese su email: ");
            Email = Console.ReadLine();
        }

        public string Cedula { get; set; }
        public void IngresarCedula()
        {
            Console.WriteLine("Ingrese su cédula sin puntos ni guiones: ");
            Cedula = Console.ReadLine();
        }

        public string FechaNacimiento { get; set; }
        public void IngresarFechaNacimiento()
        {
            Console.WriteLine("Ingrese su fecha de nacimiento: ");
            FechaNacimiento = Console.ReadLine();
        }
        
        public string Salario { get; set; }
        public void IngresarSalario()
        {
            Console.WriteLine("Ingrese su salario: ");
            Salario = Console.ReadLine();
        }

        public string Rubro { get; set; }
        public void IngresarRubro()
        {
            Console.WriteLine("Ingrese su rubro: ");
            Rubro = Console.ReadLine();
        }
        
        public string Experiencia { get; set; }
        public void IngresarExperiencia()
        {
            Console.WriteLine("Ingrese su experiencia: ");
            Experiencia = Console.ReadLine();
        }

        public string Referencias { get; set; }
        public void IngresarReferencias()
        {
            Console.WriteLine("Ingrese sus referencias: ");
            Referencias = Console.ReadLine();
        }

        public string Categorias { get; set; }
        public void IngresarCategorias()
        {
            Console.WriteLine("Ingrese las categorías: ");
            Categorias = Console.ReadLine();
        }

    }
}
