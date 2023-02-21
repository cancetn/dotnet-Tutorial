namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        // Dizi Tanımlama

            string[] renkler = new string[5];

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim 
            renkler[0] = "Mavi";
            dizi[3] = 10;


            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            // Döngüler ve dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasını alan bir örnek

        Console.Write("Kac adet sayi gireceksiniz ? : ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] sayilar = new int[n];

        float toplam = 0;

        for(int i = 0; i<n; i++){

            Console.Write("Sayiyi giriniz : ");

            sayilar[i] = Convert.ToInt32(Console.ReadLine());

            toplam = toplam + sayilar[i];

        }

        Console.WriteLine("Ortalama : " + (float)(toplam/n));

        Console.WriteLine("Girilen sayilar listesi :");

        foreach(var sayi in sayilar){
            Console.WriteLine(sayi);
        }

    }
}
