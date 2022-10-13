class Program
{
    static void Main(string[] args)
    {
        int heureJournee = DateTime.Now.Hour;
        int minutesJournee = DateTime.Now.Minute;

        if ((heureJournee >= 0 && minutesJournee >= 0) && (heureJournee <= 12 && minutesJournee >= 0))
        {
            Console.WriteLine("Bonjour");

        }
        else
        {
            Console.WriteLine("Bonsoir");
        }
    }
}