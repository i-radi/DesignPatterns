using DesignPattern.Factory_Pattern;

namespace DesignPattern.AbstractFactory_Pattern
{
    public interface AbstractFactory
    {
        public Shape GetShape(string type);
    }
}