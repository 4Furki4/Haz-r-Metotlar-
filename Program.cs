// See https://aka.ms/new-console-template for more information
string Kobay="Benim kedim çok tatlı";
Console.WriteLine(Kobay.ToUpper());
Console.WriteLine(Kobay.Replace("kedim","köpeğim"));
Console.WriteLine(Kobay.Contains("kedim"));
Console.WriteLine(Kobay.Insert(5," güzel"));

// DateTime Kütüphanesini Deniyorum...
/*Console.WriteLine(DateTime.Now);
Console.WriteLine(DateTime.Now.ToLongDateString());
Console.WriteLine(DateTime.Now.ToShortDateString());
Console.WriteLine(DateTime.Now.ToLongTimeString());
Console.WriteLine(DateTime.Now.ToShortTimeString());*/
Console.WriteLine(DateTime.Now.Millisecond);
Console.WriteLine(DateTime.Now.TimeOfDay);
Console.WriteLine(DateTime.Now.Millisecond);
Console.WriteLine(DateTime.Now.AddDays(2));
Console.WriteLine(DateTime.Now.AddHours(4));
Console.WriteLine(DateTime.Now.AddMinutes(10));
Console.WriteLine(DateTime.Now.ToString("ddd,MMM,yyyy"));

// Math... Math Kütüphanesi...

Console.WriteLine(Math.Abs(-44));
Console.WriteLine(Math.Sin(3.14));
Console.WriteLine(Math.Sin(30));
Console.WriteLine(Math.Ceiling(44.4));
Console.WriteLine(Math.Round(44.5));
Console.WriteLine(Math.Floor(44.4));
Console.WriteLine(Math.Sqrt(16));
Console.WriteLine(Math.Pow(4,4));
Console.WriteLine(Math.Max(Math.Pow(4,4),Math.Sqrt(16)));
Console.WriteLine(Math.Log10(9.99));
Console.WriteLine(Math.Exp(10));
Console.WriteLine(Math.Log(Math.Exp(1)));


