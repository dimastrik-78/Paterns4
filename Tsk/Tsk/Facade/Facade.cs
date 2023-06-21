namespace Tsk.Facade
{
    // Предоставляет интерфейс клиенту для работы с компонентами
    public class Facade
    {
        readonly SubsystemA _subsystemA;
        readonly SubsystemB _subsystemB;
        readonly SubsystemC _subsystemC;
 
        public Facade(SubsystemA sa, SubsystemB sb, SubsystemC sc)
        {
            _subsystemA = sa;
            _subsystemB = sb;
            _subsystemC = sc;
        }
        public void Operation1()
        {
            _subsystemA.A1();
            _subsystemB.B1();
            _subsystemC.C1();
        }
        public void Operation2()
        {
            _subsystemB.B1();
            _subsystemC.C1();
        }
    }
}