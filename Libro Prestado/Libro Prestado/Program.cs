string tipoLibro = "No ficción";
bool disponible = true;
int edadUsuario = 19;
bool miembroPremium = false;
int librosPrestados = 2;

if ((tipoLibro == "Ficción" && disponible) ||
    (tipoLibro == "No ficción" && edadUsuario >= 18) ||
    (tipoLibro == "Relax" && miembroPremium) &&
    librosPrestados < 3)
{
    Console.WriteLine("El libro puede ser prestado.");
}
else
{
    Console.WriteLine("El libro no puede ser prestado.");

    if (tipoLibro != "Ficción" && !disponible)
    {
        Console.WriteLine(" - No es un libro de ficción o no está disponible.");
    }
    if (tipoLibro == "No ficción" && edadUsuario < 18)
    {
        Console.WriteLine(" -  No tienes la edad para ver libros de no ficción.");
    }
    if (tipoLibro == "Relax" && !miembroPremium)
    {
        Console.WriteLine(" -  No tienes los permisos para libros de Relax");
    }
    if (librosPrestados >= 3)
    {
        Console.WriteLine(" - Ya tienes el máximo de libros prestados.");
    }
}