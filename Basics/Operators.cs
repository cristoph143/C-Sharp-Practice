public class Operators {
    public static async Task operators(){
        // overloadable operators Operators that don't return the same type (for
        // example, == and != can be overloaded, despite returning booleans)
        // + - * / % ++ -- == != > < >= <= && || ! ? : = += -= *= /= %= &= |= ^= <<= >>= ?? ??=
        // non-overloadable operators
        // . [] () -> :: ??
        // ternary operator
        int a = 5;
        int b = 10;
        int c = a > b ? a : b;
        System.Console.WriteLine("c = {0}", c);
        // null-coalescing operator
        int? d = null;
        int e = d ?? 5;
        System.Console.WriteLine("e = {0}", e);
        // null-conditional operator
        // int? f = null;
        // int g = f?.Value;
        // System.Console.WriteLine("g = {0}", g);
        // lambda operator
        Func<int, int> square = x => x * x;
        System.Console.WriteLine("square(5) = {0}", square(5));
        // sizeof operator
        System.Console.WriteLine("sizeof(int) = {0}", sizeof(int));
        // typeof operator
        System.Console.WriteLine("typeof(int) = {0}", typeof(int));
        // is operator
        System.Console.WriteLine("5 is int = {0}", 5 is int);
        // as operator
        object o = 5;
        int? h = o as int?;
        System.Console.WriteLine("h = {0}", h);
        // new operator
        // call complex
        Complexs.Complex complex = new Complexs.Complex() {
            real = 1.0,
            imaginary = 2.0
        };
        complex.real = 5;
        complex.imaginary = 10;
        System.Console.WriteLine("complex = {0} + {1}i", complex.real, complex.imaginary);
        // stackalloc operator
        // int* p = stackalloc int[10];
        // fixed operator
        // fixed (int* p = &a) {
        //     *p = 10;
        // }
        // await operator
        // call task
        await Task.Run(() => Console.WriteLine("Hello World!"));
        await Task.Delay(1000);
        
    }
}