namespace SortandWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 15, 9, 23, 2, 11 };
            Array.Sort(sayilar);
            int[] enler = new int[2];
            int enKucuk = sayilar[0];
            int enBuyuk = 0;
            for (int i = 1; i < sayilar.Length; i++)
            {
                enBuyuk = sayilar[i];
            }

            enler[0] = enKucuk;
            enler[1] = enBuyuk;

            Console.WriteLine(enler[0] + " " + enler[1]);
        }
    }
}