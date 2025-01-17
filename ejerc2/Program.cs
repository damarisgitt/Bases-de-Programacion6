using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
          //Una compañía de electricidad necesita calcular anualmente el consumo que ha
          //registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
          //Para ello tiene un lote de registros por cada uno de los usuarios con los
          //siguientes datos:
          //• Zona (numérico entero).
          //• Número de cliente (número de cuatro dígitos no correlativos).
          //• Cantidad de kilovatios consumidos en el periodo.
          //El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
          //con zona igual a cero.
          //Se pide generar un listado con el siguiente formato:
          //Zona: XX
          //Cantidad de usuarios de la zona: XX
          //Total facturado en la zona: XX
          //Zona: XX
          //Cantidad de usuarios de la zona: XX
          //Total facturado en la zona: XX
          // El precio es escalonado según la siguiente escala:
          //• $ 0.10 por kv por los primeros 100 kv de consumo.
          //• $ 0.12 por kv por el consumo de 101 a 200 kvs.
          //• $ 0.15 por kv por el consumo de 201 kvs en adelante.

          int ZONA, NUMERODECLIENTE, CANTIDADKV, ZONAACTUAL, CONTADORUSUARIO, FACTURATOTAL;

           
            Console.WriteLine("INGRESE ZONA");
            ZONA = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE NUMERO DE CLIENTE");
            NUMERODECLIENTE = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE CANTIDAD DE KILOVATIOS");
            CANTIDADKV = int.Parse(Console.ReadLine());

            while(ZONA != 0)
            {
              ZONAACTUAL = ZONA;
              CONTADORUSUARIO = 0;
              FACTURATOTAL = 0;

              while(ZONA == ZONAACTUAL)
              { 
                CONTADORUSUARIO++;

                if(CANTIDADKV > 200){
                FACTURATOTAL = CANTIDADKV * 15;
                }
                if(CANTIDADKV < 100){
                  FACTURATOTAL = CANTIDADKV * 10;
                }else{
                  FACTURATOTAL = CANTIDADKV * 12;
                }

                Console.WriteLine("INGRESE ZONA");
                ZONA = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE NUMERO CLIENTE");
                NUMERODECLIENTE = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE CANTIDADKV");
                CANTIDADKV = int.Parse(Console.ReadLine());

                
              } 

            Console.WriteLine("ZONA: " + ZONAACTUAL);
            Console.WriteLine("CANTIDAD DE USUARIOS: " + CONTADORUSUARIO);
            Console.WriteLine("TOTAL FACTURADO DE LA ZONA: " + FACTURATOTAL);

          }

          Console.WriteLine("FIN DEL PROGRAMA");

      }
    }
}
