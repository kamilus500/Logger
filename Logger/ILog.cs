
namespace Logger
{
    interface ILog
    {
        void LogInfo(string str);
        void LogError(string str);
        void LogDebug(string str);
    }
}
