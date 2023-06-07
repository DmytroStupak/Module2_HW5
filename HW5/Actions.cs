namespace Module2HW5
{
    public class Actions
    {
        public static bool First()
        {
            Logger log = Logger.Instance;
            log.LogWrite(new LogType(LogType.Log.Info, $"Start method : First "));
            return true;
        }

        public static BusinessException Second()
        {
            BusinessException businessException = new BusinessException("Skipped logic in method : Second");
            return businessException;
        }

        public static void Third()
        {
            throw new Exception("I broke a logic");
        }
    }
}