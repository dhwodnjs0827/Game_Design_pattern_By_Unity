namespace DecoratorPattern
{
    public class WeaponDecorator : IWeapon
    {
        private readonly IWeapon decoratedWeapon;
        private readonly WeaponAttachment attachment;

        public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
        {
            this.attachment = attachment;
            decoratedWeapon = weapon;
        }

        public float Range
        {
            get { return decoratedWeapon.Range + attachment.Range; }
        }

        public float Rate
        {
            get { return decoratedWeapon.Rate + attachment.Rate; }
        }

        public float Strength
        {
            get { return decoratedWeapon.Strength + attachment.Strength; }
        }

        public float Cooldown
        {
            get { return decoratedWeapon.Cooldown + attachment.Cooldown; }
        }
    }
}