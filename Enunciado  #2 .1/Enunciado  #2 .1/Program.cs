int numero, suma = 0;

do
{
    Console.WriteLine("Introduzca un número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > 0)
    {
        suma += numero;
    }
} while (numero > 0);

Console.WriteLine("La suma es: " + suma);