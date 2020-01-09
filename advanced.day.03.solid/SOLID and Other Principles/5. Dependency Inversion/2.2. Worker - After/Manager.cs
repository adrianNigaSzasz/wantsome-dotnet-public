namespace DependencyInversionWorkerAfter
{
    public class Manager
    {
        private IWorker _worker;
        public Manager(IWorker worker)
        {
            this._worker = worker;
        }
        public void Manage()
        {
            this._worker.Work();
        }
    }
}
