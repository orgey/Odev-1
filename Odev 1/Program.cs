Console.Title= "Odev 1";

var girdi = "";
int sayiyakadar;
int toplam;

Odev1();
Console.WriteLine();
Odev2();
Console.WriteLine();
Odev3();
Console.WriteLine();
Odev4();
Console.WriteLine();
Odev5();
Console.WriteLine();
Odev6();
Console.WriteLine();
Odev7();
Console.WriteLine();
Odev8();



void Odev1()
{
    sifirla();
    Console.WriteLine("Odev 1-1");

    for (byte i = 0; i < 10; i++)
    {
        Console.WriteLine((i + 1) + ". Merhaba");
    }
}
void Odev2()
{
    sifirla();
    Console.WriteLine("Odev 1-2");

    for (byte i = 0; i < 5; i++)
    {
        Console.Write((i + 1) + ". Degeri Girin Lutfen: ");
        girdi = Console.ReadLine();
        Console.WriteLine("**************");
        Console.WriteLine((i + 1) + ". Girdi: " + girdi);
    }
}
void Odev3()
{
    sifirla();
    Console.WriteLine("Odev 1-3");

    for (byte i = 0; i < 11; i++)
    {
        toplam += i;
    }
    Console.WriteLine("0 – 10 aralığındaki sayilarin toplami: " + toplam);
    Console.WriteLine("**************");
}
void Odev4()
{
    sifirla();
    Console.WriteLine("Odev 1-4");
    Console.Write("Bir Sayi Giriniz: ");
    girdi = Console.ReadLine();
    
    if (int.TryParse(girdi, out sayiyakadar) && sayiyakadar>0)
    {
        for (int i = 0; i < sayiyakadar; i++)
        {
            toplam += i;
        }
        Console.WriteLine(sayiyakadar + " - girien sayiya kadar olan sayilarin toplami : " + toplam);
    }
    else
    {
        Console.WriteLine("Girilen deger sayi degil ve ya istenen aralikta degil. Odev 1-4Tekrar Calisiyor.");
        Odev4();
        return;
    }

}
void Odev5()
{
    sifirla();
    Console.WriteLine("Odev 1-5");
    Console.Write("Bir Sayi Giriniz: ");
    girdi = Console.ReadLine();
    if (int.TryParse(girdi, out int kontrol))
    {
        if (kontrol % 2 == 0)
        {
            Console.WriteLine("Girilen Sayi Cift");
        }
        else if (kontrol % 2 == 1)
        {
            Console.WriteLine("Girilen Sayi Tek");
        }
    }
    else
    {
        Console.WriteLine("Girilen deger sayi degil ve ya istenen aralikta degil. Odev 1-5 Tekrar Calisiyor.");
        Odev5();
        
    }
}
void Odev6()
{
    sifirla();
    Console.WriteLine("Odev 1-6");
    int toplamtek = 0;
    int toplamcift = 0;
    Console.Write("Bir Sayi Giriniz: ");
    girdi = Console.ReadLine();
    if (int.TryParse(girdi, out sayiyakadar))
    {
        for (int i = 0; i < sayiyakadar; i++)
        {
            toplam += i;
            if (i % 2 == 0)
            {
                toplamcift += i;
            }
            else if (i % 2 == 1)
            {
                toplamtek += i;

            }
        }
        Console.WriteLine(sayiyakadar + " tek sayilarin toplami : " + toplamtek);
        Console.WriteLine(sayiyakadar + " cift sayilarin toplami : " + toplamcift);
        Console.WriteLine(sayiyakadar + " sayilarin toplami : " + toplam);
            }
    else
    {
        Console.WriteLine("Girilen deger sayi degil ve ya istenen aralikta degil. Odev 1-6 Tekrar Calisiyor.");
        Odev6();
        return;
    }


}
void Odev7()
{
    sifirla();
    Console.WriteLine("Odev 1-7");
    var ellidenkucuk = new List<int>();
    int yenigirdi;
    Console.WriteLine("Elliden Kucuk 10 sayi");
    for (byte i = 0; i < 10; i++)
    {
        Console.Write((i + 1) + ". Degeri Girin Lutfen: ");
        girdi = Console.ReadLine();
        if (int.TryParse(girdi, out yenigirdi))
        {
            if (yenigirdi < 50)
            {
                ellidenkucuk.Add(yenigirdi);
            }
        }
        else
        {
            Console.WriteLine("Girilen deger sayi degil ve ya istenen aralikta degil. Tekrar Deneyiniz.");
            i--;
        }
        Console.WriteLine("**************");
        
    }
    for (int i = 0; i < ellidenkucuk.Count; i++)
    {
        Console.WriteLine((i + 1) + ". Elliden Kucuk Deger: " + ellidenkucuk[i]);

    }
    
}
void Odev8()
{
    sifirla();
    Console.WriteLine("Odev 1-8");
    Console.WriteLine("Kac Adet Sayi Toplamak Istersin?");
    girdi = Console.ReadLine();
    if (int.TryParse(girdi, out sayiyakadar))
    {
        for (int i = 0; i < sayiyakadar; i++)
        {
            Console.WriteLine((i + 1) + ". Degeri Girin");
            girdi = Console.ReadLine();
            if(int.TryParse(girdi, out int sayi))
            {
                toplam += sayi;
            }
            else
            {
                Console.WriteLine("Girilen deger sayi degil ve ya istenen aralikta degil. Lutfen Tekrar Deneyiniz.");
                i--;
            }
        }
    }
    else
    {
        Console.WriteLine("Girilen deger sayi degil ve ya istenen aralikta degil. Odev 1-8 Tekrar Calisiyor.");
        Odev8();
        return;
    }




    Console.WriteLine("Sayilarin Toplami: " + toplam);
    Console.WriteLine("**************");
    Console.WriteLine("Bitti");
}
void sifirla()
{
    sayiyakadar = 0;
    toplam = 0;
}