using System;

namespace ejerc1A
{
    class Program
    {
        static void Main(string[] args)
        {   //declaracion de variables 

            int N1, impar, contnum, porcentajemaximo, porcentaje, numerogrupo, primo, posicionquesalio, div, contdiv, contadororden, orden, menor;
                // inicializacion de variables
            
                primo = 0;
                posicionquesalio = 0;
            
                porcentajemaximo = 0;
                porcentaje = 0;
                numerogrupo = 0;
                bool band = false;
                bool band2 = false;
                menor = 0;
                orden = 0;

                // inicia el ciclo for de 10 grupos

            for (int X = 0; X < 3; X++){
                impar = 0;
                contnum = 0;
                contadororden = 0;
                
                
                // pedimos el primer numero y lo guardamos en la variable N1  que seria el primer numero del grupo 
                    Console.WriteLine("ingrese PRIMER numero DE GRUPO");
                    N1 = int.Parse(Console.ReadLine());
                // con el numero ingresado y guardado en N1  ENTRAMOS AL WHILE 

                while (N1 != 0){
                    // CUENTA SOLO LOS NUMEROS QUE INGRESAN DISTINTO DE 0.

                    // PUNTO A
                     contnum ++;
                        if (N1 > 0){
                            if (N1 % 2 != 0) { 
                        impar ++;
                             }  
                        }
                        // PUNTO B
                        contdiv = 0;
                        div = 1;
                        while (div <= N1)
                        { if (N1 % div == 0){
                            contdiv ++; }
                             div++;
                        }

                        if(contdiv == 2){
                            primo = N1;
                            band = true;
                            posicionquesalio = contnum;
                        }

                        // PUNTO C
                        if(band2 == false){
                            menor = N1;
                            band2 = true;
                        }else{
                            if(N1 < menor){
                            menor = N1;
                            }else{
                                contadororden++;
                            }
                        }

                        

                        
                     // PEDIMOS NUEVAMENTE EL INGRESO DENTRO DEL WHILE 
                    Console.WriteLine("ingrese un numero DEL GRUPO");
                     N1 = int.Parse(Console.ReadLine()); 

                     } // ACA TERMINA NUESTRO WHILE FIN DEL WHILE

                     if (contadororden != 0){
                            orden++;
                        }

            
                    porcentaje = impar * 100 / contnum;
                    if(porcentaje > porcentajemaximo){
                    porcentajemaximo = porcentaje;
                    numerogrupo = X + 1;
                    }
                    
                    
                  if(band == false){
                    Console.WriteLine("no hay primos en este grupo");
                  }else{
                    Console.WriteLine(" el ultimo numero primo es: " + primo + " la posicion que salio es  " + posicionquesalio);
                  }

            }
                
            
                Console.WriteLine("el numero de grupo con mayor porcentaje de numeros impares positivos respecto al total de numeros que forman el grupo es: " + numerogrupo + " Y EL GRUPO QUE TUVO MAYOR PORCENTAJES DE IMPARES, TUVO UN PORCENTAJE DE: " + porcentajemaximo);
                Console.WriteLine("los grupos que estan ordenados de mayor a menor son: " + orden);


            
            
        }
    }
}
