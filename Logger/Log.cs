namespace Logger
{
    public class Log : ILog
    {
        FileHelper fHelper;
        bool WriteConsole;

        public Log(string filePath,bool writeConsole)
        {
            WriteConsole = writeConsole;
            fHelper = new FileHelper(filePath);
        }

        public void LogDebug(string str)
        {
            if(WriteConsole)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Out.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.White;
            }

            fHelper.FileSave(LogType.DEBUG, str);
        }

        public void LogError(string str)
        {
            if(WriteConsole)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.White;
            }

            fHelper.FileSave(LogType.ERROR, str);
        }

        public void LogInfo(string str)
        {
            if(WriteConsole)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Out.WriteLine(str);
                Console.ForegroundColor = ConsoleColor.White;
            }

            fHelper.FileSave(LogType.INFO, str);
        }
    }
}
