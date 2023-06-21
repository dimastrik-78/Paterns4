namespace Tsk.Adapter
{
    // Использует объект Target для конкретной задачи
    public class Client
    {
        // Вызов конкретного таргета
        public void Request(Target target)
        {
            target.Request();
        }
    }
}