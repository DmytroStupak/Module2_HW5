namespace Module2HW5
{
    public class Logger
    {
        private static Logger instance = new Logger();
        private static string _projectPath = "C:\\aLevel\\Module2_HW5\\HW5\\";

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public void LogWrite(LogType log)
        {
            Console.WriteLine(log.ToString());
            AddToLog(log.ToString());
        }

        public void ChangeProjectPath(string str)
        {
            _projectPath = str;
        }

        private static void AddToLog(string str)
        {
            FileService.CreateFile(str, _projectPath);
        }
    }
}
