namespace Odev_Array_EnBuyukEnKucuk
{
    internal class Program
    {
        static int[] EnleriBul(int[] sayilar)
        {
            int enBuyuk = 0;
            int enKucuk = sayilar[0];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayilar[i] > enBuyuk)
                { enBuyuk = sayilar[i]; }
                if (sayilar[i] <= enKucuk)
                { enKucuk=sayilar[i]; }
            }
            int[] enler = new int[2];
            enler[0] = enKucuk;
            enler[1] = enBuyuk;

            return enler;
        }

        static int[] DiziAl()
        {
            Console.Write("Kaç sayı girmek istediğinizi yazın: ");
            int dizi_boyu = int.Parse(Console.ReadLine());
            int[] dizi = new int[dizi_boyu];
            Console.WriteLine("Sayılarınızı girin");
            for (int i = 0; i < dizi_boyu; i++)
            {
                Console.Write(i+1 + ". Sayı: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }
            return dizi;
        }

        static void Main(string[] args)
        {
            int[] giris = DiziAl();
            int[] enler = EnleriBul(giris);

            Console.WriteLine("En Küçük Sayı = " + enler[0]);
            Console.WriteLine("En Büyük Sayı = " + enler[1]);
        }
    }
}