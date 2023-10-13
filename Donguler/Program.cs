namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            // array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya Başlangıç İçin Temel Kurs", 
                "Java", "Pyhton" };

            Console.WriteLine("For");
            Console.WriteLine("");

            for (int i = 0; i < kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("");
            Console.WriteLine("Foreach");
            Console.WriteLine("");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("\nSayfa sonu");
        }
    }
}