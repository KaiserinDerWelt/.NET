using System;

namespace DPRN1_U2_A3_MALA
{
   public class TanqueDeGasolina //Creacion de clase.
    {//Declaracion de atributos de clase
        public double CapacidadMaxima, CantidadActual,Reserva;
      

        //Constructor Predeterminado
        public TanqueDeGasolina() {
            CapacidadMaxima = 42; //Declaracion de la cantidad Maxima en 42
            CantidadActual = 2;  //Declaracion de la cantidad 2
        }

        public void CapacidadTanque (){
            CantidadActual = CapacidadMaxima;
        }
        public void AjusteMax() {
            //Sentencia Condicional
            if (2 > CapacidadMaxima){
                CantidadActual = CapacidadMaxima;
            }
        //To-do el codigo demas perteneciente a la clase TanqueDeGasolina
    }
//La definicion de clases se hacer por arriba de la clase programa.
class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
}

