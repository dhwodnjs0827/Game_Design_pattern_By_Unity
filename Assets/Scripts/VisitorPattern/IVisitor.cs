namespace VisitorPattern
{
    public interface IVisitor
    {
        public void Visit(BikeShield bikeShield);
        public void Visit(BikeEngine bikeEngine);
        public void Visit(BikeWeapon bikeWeapon);
    }
}