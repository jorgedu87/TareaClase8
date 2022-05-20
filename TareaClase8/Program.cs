Console.Write("Ingrese la cantidad de filas que tendra la matriz: ");
// Determina las columnas
int cantidadFilas = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de columnas que tendra la matriz: ");
// Determina las filas
int cantidadColumnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas,cantidadColumnas];


for (int columna = 0; columna < cantidadColumnas; columna++)
{
    Console.WriteLine("=======================================");
    Console.WriteLine($"Numeros de la columna N° {columna + 1}: ");

    // Recorremos filas
    for (int fila = 0; fila < cantidadFilas; fila++)
    {
        Console.Write($"Cargue el numero de la fila N° {fila + 1}: ");
        numeros[fila, columna] = int.Parse(Console.ReadLine());
    }
}

double [] sumatoria = new double[2];


for (int columna = 0; columna < cantidadColumnas; columna++)
{

    Console.WriteLine();
    Console.WriteLine($"Numeros de la columna  N°: {columna + 1}: ");

    for (int fila = 0; fila < cantidadFilas; fila++)
    {
        Console.Write($"El numero de la fila numero {fila + 1}: ");
        Console.WriteLine(numeros[fila, columna]);
        sumatoria[columna] = sumatoria[columna] + numeros[fila, columna];
    }
    Console.WriteLine($"La sumatoria de la columna  N°: {columna + 1}: {sumatoria[columna]}");
}

double[] promedio = new double[2];
promedio[0] = sumatoria[0] / cantidadFilas;
promedio[1] = sumatoria[1] / cantidadFilas;

Console.WriteLine("=======================================");
Console.WriteLine("=======================================");
Console.WriteLine($"El promedio de la columna  N° 1: {promedio[0]}");
Console.WriteLine($"El promedio de la columna  N° 2: {promedio[1]}");



