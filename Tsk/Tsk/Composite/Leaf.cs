using System;

namespace Tsk.Composite
{
    // Отдельный компонент
    public class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
            
        }
 
        public override void Display()
        {
            Console.WriteLine(name);
        }
 
        public override void Add(Component component)
        {
            
        }
 
        public override void Remove(Component component)
        {
            
        }
    }
}