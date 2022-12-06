public class Complexs {
    public struct Complex {
        public double real { get; set; }
        public double imaginary { get; set; } 
    }
    Complex a = new Complex() {
        real = 1.0,
        imaginary = 2.0
    };
    Complex b = new Complex() {
        real = 3.0,
        imaginary = 4.0
    };
    Complex c = new Complex() {
        real = 5.0,
        imaginary = 6.0
    };
    // public static Complex operator +(Complex a, Complex b) => new Complex() {
    //     real = a.real + b.real,
    //     imaginary = a.imaginary + b.imaginary
    // }; 
    // error One of the parameters of a binary operator must be the containing type [C# Practice]csharp(CS0563)
}