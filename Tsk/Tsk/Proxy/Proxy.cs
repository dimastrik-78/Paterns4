namespace Tsk.Proxy
{
    // заместитель реального объекта
    public class Proxy : Subject
    {
        RealSubject _realSubject;
        public override void Request()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();
            _realSubject.Request();
        }
    }
}