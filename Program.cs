 //git add Program.cs git commit -m "deyişiklik" git push
/* ödev1
Console.WriteLine("bir sayı gırın \n");
int sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
Console.WriteLine($" {i} x {sayi}={i*sayi}");


}
*/

/* ödev2
Console.WriteLine("bir sayı gırın");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("bir genişlik girin");
int genislik = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= genislik; i++)
{
    for (int j = 1; j <= x; j++)
    {
        Console.Write(x);
    }
    Console.WriteLine("");
}*/

/* ödev3
Console.WriteLine("bir sayi girin");
int sayi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
for (int j = 0; j < 3; j++)
{
Console.Write(sayi);
}
Console.WriteLine("");
}*/

/*ödev4
Console.WriteLine("bir sayı gırın");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("bir genişlik girin");
int genislik = Convert.ToInt32(Console.ReadLine());
int genişlikkopya = genislik ;
for (int i = 0; i < genislik; i++)
{
    for (int j = 0; j < genişlikkopya; j++)
    {
        Console.Write(x);
    }
    genişlikkopya--;
    Console.WriteLine("");
}*/

Console.WriteLine("bir sayı gırın");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("bir genişlik girin");
int genislik = Convert.ToInt32(Console.ReadLine());
int genişlikkopya = genislik ;
for (int i = 0; i < genislik; i++)
{
    for (int j = 0; j < genişlikkopya; j++)
    {
        Console.Write(x);
    }
    genişlikkopya -=4;
    Console.WriteLine("");
}