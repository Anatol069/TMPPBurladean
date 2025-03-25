namespace FactoryMethod.Models
{
    public class NotificareSMS : Notificare
    {
        public override void Trimite(string mesaj)
        {
            Console.WriteLine($" SMS trimis: {mesaj}");
        }
    }
}