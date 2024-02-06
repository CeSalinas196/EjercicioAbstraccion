public abstract class Figura
{
    public string Nombre { get; set; }
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }

    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
    public abstract void MostrarDetalles();
}

public class Triangulo : Figura
{
    public Triangulo(string nombre, double lado1, double lado2, double lado3)
    {
        Nombre = nombre;
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
    }

    public override double CalcularArea()
    {
        double s = (Lado1 + Lado2 + Lado3) / 2;
        return Math.Sqrt(s * (s - Lado1) * (s - Lado2) * (s - Lado3));
    }

    public override double CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Triángulo - Nombre: {Nombre}, Lado1: {Lado1}, Lado2: {Lado2}, Lado3: {Lado3}");
    }
}

public class Cuadrado : Figura
{
    public Cuadrado(string nombre, double lado)
    {
        Nombre = nombre;
        Lado1 = Lado2 = Lado3 = lado;
    }

    public override double CalcularArea()
    {
        return Lado1 * Lado2;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado1;
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Cuadrado - Nombre: {Nombre}, Lado: {Lado1}");
    }
}
