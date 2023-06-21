namespace Tsk.Proxy
{
    public class Client
    {
        void Main()
        {
            Subject subject = new Proxy();
            subject.Request();
        }
    }
}