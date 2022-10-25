using System;
namespace Library
{
    public class Datos
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

        public string Direccion ()
        {
        public string Pais { get; set; }
        public void IngresarPais()
        {
            Console.WriteLine("Ingrese su país: ");
            Pais = Console.ReadLine();
        }
        public string Departamento { get; set; }
        public void IngresarDepartamento()
        {
            Console.WriteLine("Ingrese su departamento: ");
            Departamento = Console.ReadLine();
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
