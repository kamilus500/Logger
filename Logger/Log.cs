namespace Logger
{
    public class Log : ILog
    {
        FileHelper fHelper;

        public Log(string filePath)
        {
            fHelper = new FileHelper(filePath);
        }

        public void LogDebug(string str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Out.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;

            fHelper.FileSave(LogType.DEBUG, str);
        }

        public void LogError(string str)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Out.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;

            fHelper.FileSave(LogType.ERROR, str);
        }

        public void LogInfo(string str)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Out.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;

            fHelper.FileSave(LogType.INFO, str);
        }
    }
}
