// for loop




//ekrandan girilen sayıya kadarki olan tek sayıları yazdır

Console.WriteLine("Lütfen bir sayı giriniz:");

int sayi = Convert.ToInt32(Console.ReadLine());


for (int a = 1; a <= sayi; a++)
{
    if( a % 2 == 1 )
    Console.WriteLine(a);
    
}

// 1 ile 1000 dahil arasındaki tek ve çift sayıların toplamı

int tektoplam = 0;
int cifttoplam =0 ;

for (int i = 0; i <= 1000; i++)
{
    if( i % 2 == 1 )
    tektoplam += i;
    else 
    cifttoplam = cifttoplam +i;

}

    Console.WriteLine("tek sayıların toplamı: "+ tektoplam);
    Console.WriteLine("tek sayıların toplamı: "+ cifttoplam);

    for (int i =1; i <= 10; i++)
    {
        if( i == 4)
        break;
        Console.WriteLine(i);
    }

    for (int i =1; i <= 10; i++)
    {
        if( i == 4)
        continue;
        Console.WriteLine(i);
    }



int n = Convert.ToInt32(Console.ReadLine().Trim());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(n + " x " + i + " = " + (i*n));
}











 
Console.ReadLine();