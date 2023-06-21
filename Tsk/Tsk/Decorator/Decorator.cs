namespace Tsk.Decorator
{
    // Слушит абстракции для базовой логики и расширением этой же логики
    public abstract class Decorator : Component
    {
        protected Component Component;
 
        public void SetComponent(Component component)
        {
            Component = component;
        }
 
        public override void Operation()
        {
            if (Component != null)
                Component.Operation();
        }
    }
}