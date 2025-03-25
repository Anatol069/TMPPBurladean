namespace FactoryMethod.Models
{
    public class NotificareEmail : Notificare
    {
        public override void Trimite(string mesaj)
        {
            Console.WriteLine($" Email trimis: {mesaj}");
        }
    }
}