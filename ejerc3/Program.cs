using System;

namespace ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {
          //Hacer un programa para ingresar los valores de los pesos de distintas
          //encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
          //ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
          //pueden transportar hasta 200 kilos en total.
          //Por ejemplo:
          //10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
          //Camión 1. Camión 2 Camión 3 Camión 4 Camión 5
          //Se pide determinar e informar:
          //a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
          //Camión 2: 170kg, etc.).
          //b. El número de camión que transporta mayor cantidad de encomiendas
          //(en el ejemplo anterior sería el camión 3 con 4 encomiendas).
          //c. La cantidad de camiones que se terminaron cargando.

          int PESO, PESOTOTAL, CAMION, MAXIMAECOMIENDA, ECOMIENDA, CAMIONMAXIMO;

          CAMION = 0;
          MAXIMAECOMIENDA = 0;
          CAMIONMAXIMO = 0;

          Console.WriteLine("INGRESE EL PASO DEL PAQUETE");
          PESO = int.Parse(Console.ReadLine());

          while (PESO > 0 )
          {
            PESOTOTAL = 0;
            ECOMIENDA = 0;
            CAMION++;
              while (PESO + PESOTOTAL <= 200)
              {
              PESOTOTAL += PESO;
              ECOMIENDA++;

              Console.WriteLine("INGRESE EL PESO DEL PAQUETE");
              PESO = int.Parse(Console.ReadLine());

              }

              // PUNTO A
            Console.WriteLine("CAMION NUMERO " + CAMION);
            Console.WriteLine("PESO TOTAL QUE VA A TRANSPORTAR ES : " + PESOTOTAL + "KILOS");

            if(ECOMIENDA > MAXIMAECOMIENDA)
            {
              MAXIMAECOMIENDA = ECOMIENDA;
              CAMIONMAXIMO = CAMION;
            }

            Console.WriteLine("INGRESE EL PESO DEL PAQUETE");
            PESO = int.Parse(Console.ReadLine());

          }
          // PUNTO B
          Console.WriteLine("EL CAMION NUMERO: " + CAMIONMAXIMO +  "  LLEVA  "  + MAXIMAECOMIENDA + " ENCOMIENDAS");
          // PUNTO C
          Console.WriteLine("LA CANTIDAD DE CAMIONES QUE SE CARGARON ES: " + CAMION);
        }
    }
}
