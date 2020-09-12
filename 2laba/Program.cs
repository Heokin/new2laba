using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue = true;
            bool isFalse = false;
            byte byte1 = 1;
            sbyte sbyte1 = -101;
            short isShort = -250;
            ushort isUshort = 250;
            int integer = -65;
            uint uInteger = 65;
            long long1 = -27;
            ulong ulong1 = 27;
            float float1 = 3.564f;
            double double1 = 5.6545454;
            decimal decimal1 = 5.644435m;
            char char1 = 'Ç';
            string hello = "world";
            object ob = 22;
            Console.WriteLine($"bool : {isTrue},{isFalse},byte :{byte1},{sbyte1}, short : {isShort},{isUshort} int : {integer},{uInteger} long : {long1} , {ulong1} float :{float1} double : {double1} decimal : {decimal1} char : {char1} string :{hello} object : {ob}");
            // Неявные преобразования

            int num = 2147;
            long bigNum = num;
            float floatNum = num;
            object obNum = num;
            double UDouble = num;

            //Явные преобразования

            integer = (int)long1;
            Console.WriteLine($"{integer}");
            double1 = (int)integer;
            Console.WriteLine($"{double1}");
            integer = (int)float1;
            Console.WriteLine($"{integer}");
            ulong1 = (uint)uInteger;
            ob = (int)integer;
            sbyte a = 5;
            byte but = (byte)a;

            //  boxing unboxing


            int i = 123;
            object o = i; //упаковка
            int y = (int)o; //распаковка


            //  неявно типизированной
            var qw = 5;
            var qwe = "hello";

            // Nullable

            int? Value = null;
            if ( Value != null)
            {
                Console.WriteLine($"value is : { Value}");

            } else
            {
                Console.WriteLine("Value is null");
            }

            Nullable<int> price = 123;
            if (price != null)
            {
                Console.WriteLine($"price is : { price}");

            }
            else
            {
                Console.WriteLine("price is null");
            }


        }
    }
}
