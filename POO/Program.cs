class Ville
{
    public string? Nom { get; set; }
    public string? CodePostal { get; set; }

    public void Afficher()
    {
        Console.WriteLine($"Ville: {Nom}, Code Postal: {CodePostal}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Ville ville = new Ville
        {
            Nom = "Lyon",
            CodePostal = "69000"
        };

        ville.Afficher();
    }
}