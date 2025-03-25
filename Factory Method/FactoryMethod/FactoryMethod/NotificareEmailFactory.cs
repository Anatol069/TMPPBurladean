using FactoryMethod.Models;

namespace FactoryMethod.Factories
{
    public class NotificareEmailFactory : NotificareFactory
    {
        public override Notificare CreareNotificare()
        {
            return new NotificareEmail();
        }
    }
}