public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("");

        byte b = 5; // 1 byte
        sbyte sb = -5; // 1 byte
        short s = 5; // 2 bytes
        ushort us = 5; // 2 bytes


        Int16 i16 = 5; // 2 bytes
        int i = 5; // 4 bytes
        Int32 i32 = 5; // 4 bytes
        Int64 i64 = 5; // 8 bytes
        uint ui = 5; // 4 bytes


        long l = 5; // 8 bytes
        ulong ul = 5; // 8 bytes


        float f = 5; // 4 bytes
        double d = 5; // 8 bytes
        decimal dec = 5; // 16 bytes


        char c = 'A'; // 2 bytes

        bool bo = true; // 1 byte

        string str = "Hello";
        object o = "Hello"; //(reference),tüm değişken türleri aslında birer objedir.

        DateTime dt = DateTime.Now; // 8 bytes


        string str2 = string.Empty; // boş string
        str2 = "Hello World";
        string ad = "Ali";
        string soyad = "Veli";
        string tamIsim = ad + " " + soyad; // concatenation


        int int1 = 5;
        int int2 = 3;
        int int3 = int1 * int2;

        bool bool1 = 10 < 2;


        string str20 = "20";
        int int20 = 20;
        string yeniDeger = str20 + int20.ToString(); // "2020"
        Console.WriteLine(yeniDeger); // 2020

        int int21 = int20 + Convert.ToInt32(str20); // 40
        Console.WriteLine(int21); // 40

        int int22 = int20 + int.Parse(str20); // 40
        Console.WriteLine(int22); // 40

        string datetime = DateTime.Now.ToString("dd.MM.yyyy");
        Console.WriteLine(datetime);

        string hour = DateTime.Now.ToString("HH:mm");
        Console.WriteLine(hour);

        int int23 = int20 + int.Parse(str20);
    }
}