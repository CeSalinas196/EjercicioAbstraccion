class Program
{
    static void Main(string[] args)
    {
        Triangulo triangulo = new Triangulo("Triángulo ABC", 5, 7, 8);
        Cuadrado cuadrado = new Cuadrado("Cuadrado A", 4);


        triangulo.MostrarDetalles();
        Console.WriteLine($"Área: {triangulo.CalcularArea()}, Perímetro: {triangulo.CalcularPerimetro()}");

        Console.WriteLine();

        cuadrado.MostrarDetalles();
        Console.WriteLine($"Área: {cuadrado.CalcularArea()}, Perímetro: {cuadrado.CalcularPerimetro()}");

        Console.ReadLine();
    }
}
