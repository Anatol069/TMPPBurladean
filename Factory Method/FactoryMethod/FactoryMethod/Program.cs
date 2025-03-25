using FactoryMethod.Models;
using FactoryMethod.Factories;

class Program
{
    static void Main()
    {
        NotificareFactory factoryEmail = new NotificareEmailFactory();
        Notificare notificare1 = factoryEmail.CreareNotificare();
        notificare1.Trimite("Salut! Acesta este un email.");

        NotificareFactory factorySMS = new NotificareSMSFactory();
        Notificare notificare2 = factorySMS.CreareNotificare();
        notificare2.Trimite("Salut! Acesta este un SMS.");
    }
}