string nombre = "Estudiante";
int[] notas = { 80, 75, 90, 85 };
double promedioGeneral = CalcularPromedio(notas);
bool sancionado = false;

double CalcularPromedio(int[] notas)
{
    double suma = 0;
    foreach (int nota in notas)
    {
        suma += nota;
    }
    return suma / notas.Length;
}

if (promedioGeneral >= 70 && !sancionado)
{
    Console.WriteLine("{0} Puede graduarse.", nombre);
}
else
{
    Console.WriteLine("{0} No puede graduarse.", nombre);

    if (promedioGeneral < 70)
    {
        Console.WriteLine(" - Promedio general inferior a 70 ({0}).", promedioGeneral);
    }
    if (sancionado)
    {
        Console.WriteLine(" - Reportado por mal portado.");
    }
}

bool AproboTodas(int[] notas)
{
    foreach (int nota in notas)
    {
        if (nota < 60)
        {
            return false;
        }
    }
    return true;
}