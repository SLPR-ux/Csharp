class Program
{
    public static void Main(string[] args)
    {
        Compte compte = new Compte();
        compte.Solde = 1500.75m;
        compte.AfficherDetails();
    }
}