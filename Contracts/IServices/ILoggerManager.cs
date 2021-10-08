namespace Contracts.IServices
{
    public interface ILoggerManager
    {
        void LofInfo(string message);
        void LogWarn(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}