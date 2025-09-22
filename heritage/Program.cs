namespace heritage
{
    public class Heritage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("héritage c#");

            Utilisateur user = new Utilisateur();
            user.Nom = "Ounissi";
            user.Prenom = "Badr";
            user.Afficher();
        }
    }
}
