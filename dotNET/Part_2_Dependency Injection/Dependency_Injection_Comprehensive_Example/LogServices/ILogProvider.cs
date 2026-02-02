namespace LogServices
{
  
    public  interface ILogProvider
    {
        public void LogErroer(string message);
        public void LogInfo(string message);
    }
}
