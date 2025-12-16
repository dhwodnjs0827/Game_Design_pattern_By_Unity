namespace DecoratorPattern
{
    public interface IWeapon
    {
        public float Range { get; }
        public float Rate { get; }
        public float Strength { get; }
        public float Cooldown { get; }
    }
}