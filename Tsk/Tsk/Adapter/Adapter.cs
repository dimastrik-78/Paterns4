namespace Tsk.Adapter
{
    // Позволяет работать с Adapt как с Target
    public class Adapter : Target
    {
        private readonly Adapt _adapt = new Adapt();
  
        public override void Request()
        {
            _adapt.SpecificRequest();
        }
    }
}