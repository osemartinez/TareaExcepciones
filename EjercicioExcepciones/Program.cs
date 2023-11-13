// See https://aka.ms/new-console-template for more information
using EjercicioExcepciones;

Console.WriteLine("Hello, World!");

try
{
    //solicitar primer numero
    Console.WriteLine("Ingrase el primer número: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    //Solicitar segundo numero
    Console.WriteLine("Ingrese el segundo número");
    double num2 = Convert.ToDouble(Console.ReadLine());

    
    
    
    
    Operaciones operaciones = new Operaciones();

    // Realizar operaciones y mostrar resultados
    Console.WriteLine("Suma: " + operaciones.Sumar(num1, num2));
    Console.WriteLine("Resta: " + operaciones.Restar(num1, num2));
    Console.WriteLine("Multiplicación: " + operaciones.Multiplicar(num1, num2));

    try
    {
        Console.WriteLine("División: " + operaciones.Dividir(num1, num2));
    }

    // Aca manejamos la excepción de la división por cero
    catch (DivideByZeroException)
    {
        Console.WriteLine("No se puede dividir por cero.");
    }
}
    


    // Aca podeos manejar la excepción si el usuario no ingresa un número
    catch (FormatException)
    {
          Console.WriteLine("Error: Ingrese números válidos.");
    }
   


     
           
