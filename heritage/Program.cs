namespace heritage
{
    public class Heritage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("héritage c#");

            Utilisateur user = new Utilisateur("Ligonese", "Jean");
            user.Afficher();

            Client client = new Client("De Ligonese", "Dupont", "Rue de la famille, Japon");
            client.Afficher();
            client.Afficher();

            Employe emp = new Employe("Durand", "Martin", "Directeur");
            emp.Afficher();
        }
    }
}
