using FactoryMethod.Models;

namespace FactoryMethod.Factories
{
    public class NotificareSMSFactory : NotificareFactory
    {
        public override Notificare CreareNotificare()
        {
            return new NotificareSMS();
        }
    }
}