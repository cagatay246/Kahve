class Program
{
    static void Main()
    {
        // Kahve isimlerini tutmak için bir liste oluşturuyoruz.
        List<string> kahveListesi = new List<string>();

        Console.WriteLine("Lütfen 5 kahve ismi giriniz:");

        // Kullanıcıdan 5 kahve ismi alıyoruz.
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahveIsmi = Console.ReadLine();
            kahveListesi.Add(kahveIsmi);
        }

        // Kahve isimlerini foreach döngüsüyle yazdırıyoruz.
        Console.WriteLine("\nGirdiğiniz kahve isimleri:");
        foreach (string kahve in kahveListesi)
        {
            Console.WriteLine(kahve);
        }
    }
}