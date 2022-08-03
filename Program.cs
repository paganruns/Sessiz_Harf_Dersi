internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Start();
    }

    public static void Start()
    {
        char[] silentLetter = {'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z',};
        try
        {
            Console.WriteLine("Lütfen kelimelerden oluşan ve kelimelerin arasında boşluk olan bir dizi giriniz: ");
            string[] strArray = Console.ReadLine().Split();

            foreach (var item in strArray)
            {
                char[] cArray = item.ToCharArray();

                bool constant = false;

                for (int i = 1; i < cArray.Length ; i++)
                {
                    if(silentLetter.Contains(cArray[i]) && silentLetter.Contains(cArray[i-1])) constant = true;
                }
                Console.Write("{0} ", constant);

            }

        }
        catch (System.Exception)
        {
            ErrorMessage();
            Start();
        }   

        EndingApp(); 
    }

    public static void ErrorMessage()
    {
        Console.WriteLine("Lütfen geçerli değer giriniz!");
    }

    public static void EndingApp()
    {
        Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz: \n" +
                          "********************************************************* \n" +
                          "(1) Programı sonlandır \n" +
                          "(2) Programı tekrar başlat \n");  

        string choice = Console.ReadLine();
        if(choice.Contains('1')) Environment.Exit(0);
        else if(choice.Contains('2')) Start();
        else {ErrorMessage(); EndingApp();}
    }
}