public class literal {
    public static void literals() {
        uint ui = 5U;
        int i = 5;
        sbyte sb = 127;
        decimal m = 30.5M;
        double d = 30.5D;
        float f = 30.5F;
        long l = 5L;
        ulong ul = 5UL;
        string s = "Hello World";
        string s1 = @"Hello World"; // @ is used to escape special characters
        char c = 'c';
        byte b = 0x2F; // 0x is used to represent hexadecimal
        short sh = 0x2F;
        ushort ush = 0x2F;
        bool bo = true;
        object o = new object();
        System.Console.WriteLine("uint: {0}", ui);
        System.Console.WriteLine("int: {0}", i);
        System.Console.WriteLine("sbyte: {0}", sb);
        System.Console.WriteLine("decimal: {0}", m);
        System.Console.WriteLine("double: {0}", d);
        System.Console.WriteLine("float: {0}", f);
        System.Console.WriteLine("long: {0}", l);
        System.Console.WriteLine("ulong: {0}", ul);
        System.Console.WriteLine("string: {0}", s);
        System.Console.WriteLine("string: {0}", s1);
        System.Console.WriteLine("char: {0}", c);
        System.Console.WriteLine("byte: {0}", b);
        System.Console.WriteLine("short: {0}", sh);
        System.Console.WriteLine("ushort: {0}", ush);
        System.Console.WriteLine("bool: {0}", bo);
        System.Console.WriteLine("object: {0}", o);
    }
}