using System;
using System.Globalization; //Se importa la libreria para usar DateTime y CultureInfo


namespace DPRN1_U2_A2_MALA
{
    class estudiante
    {
        public string ObtenerNombreCompleto(string nombre, string apellidos)
        {
            string nombreCompleto = string.Empty;
            nombreCompleto = nombre + " " + apellidos;
            return nombreCompleto; //Aqui faltaba la sentencia return para devolver resultados solo del me-to-do en cuestion.
        }
        public void CalcularEdad(DateTime fechaNacimiento)
        {   
            int edadEstudiante = DateTime.Now.Year - fechaNacimiento.Year;
            int edadCalculada = DateTime.Now < fechaNacimiento.AddYears(edadEstudiante) ? edadEstudiante - 1 : edadEstudiante;
            Console.WriteLine("La edad del estudiante es: " + edadCalculada + " años"); //Aqui jale la edadCalculada se borra la variable edad que no existe.
        }

        class Program
    {
        static void Main(string[] args)
        {
            estudiante alumno = new estudiante();//Aqui se instancio la clase como objeto
            string nombre;
            string apellidos;//Apellidos debe ser string NO double
            DateTime fechaNac;

            Console.WriteLine("Capture el nombre del alumno: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Capture el apellido del alumno:");
            apellidos = Console.ReadLine();
                Console.WriteLine(alumno.ObtenerNombreCompleto(nombre, apellidos));//Se usa dot.notation nombre instancia.nombretributo

                Console.WriteLine("Indique la fecha de nacimiento (dd/mm/aaaa):");
                fechaNac = Convert.ToDateTime(Console.ReadLine(), new CultureInfo("fr-FR"));//Puse la clase Culture Info de francia por curiosidad.
                alumno.CalcularEdad(fechaNac); //Use dot notation accediendo a la instancia conectando con el me-to-do calcular edad.
                Console.ReadKey(); //Se pone esto para que cuando el usuario presione una tecla se acabe el programa porque ya no hay mas.

            }
        }
    }
}