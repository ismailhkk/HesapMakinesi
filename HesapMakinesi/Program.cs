namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v1
            Console.WriteLine("Hoşgeldiniz");
            Console.Write("Kaç adet sayı toplamak istiyorsunuz:   ");
            int adet = int.Parse(Console.ReadLine());

            double toplam = 0;

            for (int i = 1; i <= adet; i++)
            {
                Console.Write($"{i}.rakamı girin:  ");
                double rakam = double.Parse(Console.ReadLine());
                toplam += rakam;
            }
            double ortalama = toplam / adet;
            Console.WriteLine($"toplam:  {toplam}, ortalama:  {ortalama}");
            //v2
            Console.WriteLine("   ");
            Console.WriteLine("********************");
            Console.WriteLine("   ");
            Console.WriteLine("Hangi işlemi yapmak istiyorsunuz?");
            string[] islemler = { "toplama", "çıkarma", "bölme", "çarpma" };

            Console.WriteLine("İşlem seçenekleri:");
            for (int i = 0; i < islemler.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {islemler[i]}");
            }

            Console.Write("Hangi işlemi yapmak istersiniz: ");
            int secimIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (secimIndex < 0 || secimIndex >= islemler.Length)
            {
                Console.WriteLine("Geçersiz işlem seçimi.");
                return;
            }

            string secilenIslem = islemler[secimIndex];
            Console.Write("Kaç adet sayı ile işlem yapmak istiyorsunuz: ");
            int adet1 = int.Parse(Console.ReadLine());

            double sonuc = 0;

            if (secilenIslem == "toplama")
            {
                for (int i = 0; i < adet; i++)
                {
                    Console.Write($"{i + 1}. rakamı girin: ");
                    double rakam = double.Parse(Console.ReadLine());
                    sonuc += rakam;
                }
            }
            else if (secilenIslem == "çıkarma")
            {
                Console.Write("1. rakamı girin: ");
                sonuc = double.Parse(Console.ReadLine());
                for (int i = 1; i < adet; i++)
                {
                    Console.Write($"{i + 1}. rakamı girin: ");
                    double rakam = double.Parse(Console.ReadLine());
                    sonuc -= rakam;
                }
            }
            else if (secilenIslem == "çarpma")
            {
                sonuc = 1;
                for (int i = 0; i < adet; i++)
                {
                    Console.Write($"{i + 1}. rakamı girin: ");
                    double rakam = double.Parse(Console.ReadLine());
                    sonuc *= rakam;
                }
            }
            else if (secilenIslem == "bölme")
            {
                Console.Write("1. rakamı girin: ");
                sonuc = double.Parse(Console.ReadLine());
                for (int i = 1; i < adet; i++)
                {
                    Console.Write($"{i + 1}. rakamı girin: ");
                    double rakam = double.Parse(Console.ReadLine());
                    sonuc /= rakam;
                }
            }

            Console.WriteLine($"İşlem sonucu: {sonuc}");
        }

    }
}



            ;



