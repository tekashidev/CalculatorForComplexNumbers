using System;

class ComplexNumber
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public ComplexNumber Add(ComplexNumber other)
    {
        return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
    }

    public ComplexNumber Subtract(ComplexNumber other)
    {
        return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
    }

    public ComplexNumber Multiply(ComplexNumber other)
    {
        double newReal = Real * other.Real - Imaginary * other.Imaginary;
        double newImaginary = Real * other.Imaginary + Imaginary * other.Real;
        return new ComplexNumber(newReal, newImaginary);
    }

    public ComplexNumber Divide(ComplexNumber other)
    {
        double denominator = other.Real * other.Real + other.Imaginary * other.Imaginary;
        double newReal = (Real * other.Real + Imaginary * other.Imaginary) / denominator;
        double newImaginary = (Imaginary * other.Real - Real * other.Imaginary) / denominator;
        return new ComplexNumber(newReal, newImaginary);
    }

    public override string ToString()
    {
        return $"{Real:+0.000;-0.000} + i{Imaginary:+0.000;-0.000}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj część rzeczywistą pierwszej liczby zespolonej:");
        double real1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj część urojoną pierwszej liczby zespolonej:");
        double imaginary1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj część rzeczywista drugiej liczby zespolonej:");
        double real2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj część urojona drugiej liczby zespolonej:");
        double imaginary2 = double.Parse(Console.ReadLine());

        ComplexNumber firstNumber = new ComplexNumber(real1, imaginary1);
        ComplexNumber secondNumber = new ComplexNumber(real2, imaginary2);

        Console.WriteLine($"{firstNumber.ToString()} {secondNumber.ToString()}");

        ComplexNumber sum = firstNumber.Add(secondNumber);
        ComplexNumber difference = firstNumber.Subtract(secondNumber);
        ComplexNumber product = firstNumber.Multiply(secondNumber);
        ComplexNumber quotient = firstNumber.Divide(secondNumber);

        Console.WriteLine(sum.ToString());
        Console.WriteLine(difference.ToString());
        Console.WriteLine(product.ToString());
        Console.WriteLine(quotient.ToString());
    }
}
