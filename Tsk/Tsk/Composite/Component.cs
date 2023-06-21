namespace Tsk.Composite
{
    // определяет интерфейс ослаьных компонентов
    public abstract class Component
    {
        protected readonly string name;
 
        public Component(string name)
        {
            this.name = name;
        }
 
        public abstract void Display();
        public abstract void Add(Component c); 
        public abstract void Remove(Component c);
    }
}