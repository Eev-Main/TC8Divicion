using System;
using System.IO;

namespace TC8Divicion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce el valor a:");

                float a = float.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el valor a:");
                float b = float.Parse(Console.ReadLine());


                float result = a / b;
                Console.WriteLine($"{a} / {b} = {result}");
                
                //REQUIERE AGREGAR DIRECTIVA USING!
                using(StreamWriter sw = new StreamWriter("operacion.txt"))
                {
                    sw.WriteLine($"{a} / {b} = {result}");
                }
            }
            //catch (System.Exception) //atrapa cualquier exeption x
            catch (System.FormatException) //atrapar solamente las exeption que nos interesan
            {
                //si ocurre una exception en el try, se ejecuta el codigo en el catch
                Console.WriteLine("Error, porfavor introduce numeros validos");
                //throw;
            }
            finally
            {
                //lo que se encuentra en el finally siempre se muestra
                Console.WriteLine("Este mensaje siempre se muestra");
            }
        }
    }
}
