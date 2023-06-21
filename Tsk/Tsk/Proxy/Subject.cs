namespace Tsk.Proxy
{
    // Определяет реализацию Proxy и RealSubject, позволяя менять их местами
    public abstract class Subject
    {
        public abstract void Request();
    }
}