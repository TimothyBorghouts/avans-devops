namespace Avans_DevOps.Domain
{
    public interface IObservable
    {
        void subscribe();
        void unsubscribe();
        void notify();
    }
}
