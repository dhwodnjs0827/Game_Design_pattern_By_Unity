namespace VisitorPattern
{
    public interface IBikeElement
    {
        public void Accept(IVisitor visitor);
    }
}