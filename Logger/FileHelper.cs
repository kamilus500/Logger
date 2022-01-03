namespace Logger
{
    class FileHelper
    {
        private readonly string _fileLogPath;
        public FileHelper(string filePath)
        {
            _fileLogPath = filePath;
        }

        public async void FileSave(LogType LogInfo, string str)
        {
            DateTime nowDate = DateTime.Now;
            if (!File.Exists(_fileLogPath))
                await File.WriteAllTextAsync(_fileLogPath, nowDate.ToShortDateString() + " " + nowDate.ToLongTimeString() + " |" + LogInfo + "| " + str + "\n");
            else
                await File.AppendAllTextAsync(_fileLogPath, nowDate.ToShortDateString() + " " + nowDate.ToLongTimeString() + " |" + LogInfo + "| " + str + "\n");
        }
    }
}
