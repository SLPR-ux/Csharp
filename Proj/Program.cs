namespace ExempleObjet
{
    public class Ville
    {
        public string Nom { get; set; }
        public string CodePostal { get; set; }
    }
    public class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public Ville Ville { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personne personne = new Personne
            {
                Nom = "Dupont",
                Prenom = "Jean",
                Ville = new Ville
                {
                    Nom = "Paris",
                    CodePostal = "75000"
                }
            };

            Console.WriteLine($"Nom: {personne.Nom}, Prénom: {personne.Prenom}, Ville: {personne.Ville.Nom}, Code Postal: {personne.Ville.CodePostal}");
        }
    }
}