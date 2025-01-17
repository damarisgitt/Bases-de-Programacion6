using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una empresa registró las compras realizadas a sus distintos proveedores durante
            //todo el año anterior. Para cada compra se registraron los siguientes datos:
            //• Número de proveedor (número de cuatro cifras no correlativo).
            //• Día (1 a 31).
            //• Mes (1 a 12).
            //• Tipo de Factura (Responsable inscripto: "A",Consumidor Final: "B", o
            //Monotributo: "C").
            //• Número de Producto (número no correlativo).
            //• Cantidad comprada.
            //• Precio unitario del producto.
            //Este lote finaliza con un registro con número de proveedor igual a 0.
            //Los registros están agrupados por número de proveedor. En el lote anterior no aparecen
            //registros de los proveedores a los que que no se les hayan realizado compras.
            //   Se pide determinar e informar:
            //a. El monto máximo registrado en una sola compra por cada proveedor y el
            //número de proveedor al que se le compró.
            //b. La inversión total de todo el año discriminada por tipo de factura.
            //c. La compra con menor monto registrada durante el mes de Agosto junto al
            //número de producto comprado.
            //d. La cantidad de compras que se realizaron a cada proveedor.
            //e. El número de producto con mayor cantidad comprada en una sola compra y
            //en qué proveedor se compró.

            int numerodeproveedor, dia, mes, numerodeproducto, cantidadcomprada, preciounitariodelproducto, monto, maximom, maxinp, npactual;
            int acuma, acumb, acumc;
            char tipodefactura;

            Console.WriteLine("INGRESE EL NUMERO DE PROVEEDOR");
            numerodeproveedor = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL DIA");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL MES");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL TIPO DE FACTURA");
            tipodefactura = char.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL NUMERO DE PRODUCTO");
            numerodeproducto = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE LA CANTIDAD COMPRADA");
            cantidadcomprada = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE EL PRECIO UNITARIO DEL PRODUCTO");
            preciounitariodelproducto = int.Parse(Console.ReadLine());

            acuma = 0;
            acumb = 0;
            acumc = 0;
            maximom = 0;
            maxinp = 0;

            while (numerodeproveedor != 0){

                npactual = numerodeproveedor;
                

                while (numerodeproveedor == npactual){

                    monto = cantidadcomprada * preciounitariodelproducto;

                       if(monto > maximom){
                        maximom = monto;
                        maxinp = numerodeproveedor;
                        }

                        if(tipodefactura == "a"){
                            acuma += monto;
                        }
                        if(tipodefactura == "b"){
                            acumb += monto;
                        }
                        if(tipodefactura == "c"){
                            acumc += monto;
                        }
                    
                }
                
            }   Console.WriteLine("El monto máximo registrado en una sola compra fue de: " + maximom + " y el número de proveedor al que se le compró fue: " + maxinp);
                Console.WriteLine("La inversión total de todo el año de la factura A es: " + acuma);
                Console.WriteLine("La inversión total de todo el año de la factura B es: " + acumb);
                Console.WriteLine("La inversión total de todo el año de la factura C es: " + acumc);
            

            



        }
    }
}
