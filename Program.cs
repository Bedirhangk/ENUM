namespace ENUM;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine(Gunler.Pazar);
       Console.WriteLine((int)Gunler.Pazar); 

       Console.WriteLine();

       int Sıcaklık=12;
       if(Sıcaklık<=(int)HavaDurumu.Normal && Sıcaklık>(int)HavaDurumu.Soğuk)
        Console.WriteLine("Hava Biraz Soğuk. Üstğne Hırka Alabilirsin.");
       else if(Sıcaklık>=(int)HavaDurumu.Sıcak)
        Console.WriteLine("Hava Çok Sıcak. Denize Atla.");
       else
        Console.WriteLine("Hava Çok Soğuk!!!!");
        
    }
}

enum Gunler 
{
    Pazartesi=1, // default olarak ilk yazılan 0 index numarasına sahip olur. Bunu =1 yaparak başlangıcı değiştirebilirsiniz.
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}

enum HavaDurumu
{
    Soğuk=5,
    Normal=20,
    Sıcak=35
}
