public class Tableau
{
    string[] prenoms = { "Alice", "Bob", "Charlie", "Diana", "Ethan" };
    
    public void AfficherPrenoms()
    {
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }
    }
}