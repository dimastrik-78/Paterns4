namespace Tsk.Bridge
{
    public class Client
    {
        public void Main()
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor=new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
}