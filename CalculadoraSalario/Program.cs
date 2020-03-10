using System;
using CalculadoraSalario;

namespace CalculadoraSalario {   //Creacion Clase Salario
    class Salarios {
        //Declaracion de Atributos
        public string ID;
        public string Nombre;
        public string Departamento;
        public double HorasTrabajadas;
        public double TarifaHora;
        public double HorasExtra;

        //Creacion de Me-to-do que no Devuelve Restultados
        public Salarios (){
            Console.WriteLine("Another Assignment for my Github by KaiserinDerWelt" + DateTime.Now);
        }
         //Me-to-do que Calcula el Salario
            public double SalarioCalculo(int Horas){
                double SalarioCalculo;
                double SalarioAdicional = 0;
                if (Horas <= 80){
                    SalarioCalculo = Horas * TarifaHora;
                }
                else{
                    SalarioCalculo = 80 * TarifaHora;
                    SalarioAdicional = HorasExtra * 167;
                }

                return (SalarioCalculo + SalarioAdicional);
            }
    //Creacion de Me-to-do de Calculo Total de Salario restando porcentajes de Impuesto,Caja,Seguro
    public double Quincena(double SalarioCalculo, double SalarioAdicional){
        double Quincena;
            Quincena = (SalarioCalculo + SalarioAdicional * (100)) / 10;
        return Quincena;
    }

    class Program
    {
        static void Main(string[] args) {
            //Llamado de clase  Instanciada
            Salarios SalarioInstanciado;
            //Inputs de Usuario por Teclado
            Console.WriteLine("Bienvenido al Programa de Nomina");
            SalarioInstanciado = new Salarios();
            Console.WriteLine("Ingrese la Informacion Solicitada");
            Console.WriteLine("Ingrese ID:");
            SalarioInstanciado.ID = Console.ReadLine();
            Console.WriteLine("Ingrese Nombre:");
            SalarioInstanciado.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Departamento");
            SalarioInstanciado.Departamento = Console.ReadLine();
            Console.WriteLine("Ingrese las Horas Trabajadas Quincenalmente");
            //Parse Me-to-do para dato tipo double + Me-to-do Input
            SalarioInstanciado.HorasTrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Tarifa por Hora: ($125 Pesos)");
            //Parse Me-to-do para dato tipo double + Me-to-do Input
            SalarioInstanciado.TarifaHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa las Horas Extras Trabajadas:");
            SalarioInstanciado.HorasExtra = double.Parse(Console.ReadLine());
                //Bloque Switch para eleccion de Sexo
                Console.WriteLine("Elige tu Sex: Presiona 1 para Hombre, 2 para Mujer");
            int ValorSexo;
            ValorSexo = int.Parse(Console.ReadLine()); //Parse for Int
            switch(ValorSexo){
                case 1: Console.WriteLine("Hombre");
                    break;
                case 2: Console.WriteLine("Mujer");
                    break;
            }
                //Output del Programa usando DOT Notation
                Console.WriteLine("ID: " + SalarioInstanciado.ID + " " + "Nombre: " + SalarioInstanciado.Nombre + " " + "Departamento:" + SalarioInstanciado.Departamento);
                Console.WriteLine("Su Quincena Neta con Descuento de Impuestos, Caja de Ahorro y Seguro Social es de: ");
                Console.Write("Gracias por Trabajar con Nosotros");

    }
    }
}
}
