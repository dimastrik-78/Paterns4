using System;
using System.Collections.Generic;

namespace Tsk.Composite
{
    // Отдельный компонент, который может иметь другие компоненты
    public class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public Composite(string name) : base(name)
        {
            
        }
 
        public override void Add(Component component)
        {
            _children.Add(component);
        }
 
        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
 
        public override void Display()
        {
            Console.WriteLine(name);
 
            foreach (Component component in _children)
            {
                component.Display();
            }
        }
    }
}