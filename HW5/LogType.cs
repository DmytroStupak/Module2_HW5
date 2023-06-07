namespace Module2HW5
{
    public class LogType
    {
        public LogType(Log type, string mes)
        {
            Time = DateTime.Now.ToString("HH:mm:ss dd.MM.yyyy");
            Mes = mes;
            Type = type;
        }

        public enum Log
        {
            Info,
            Warning,
            Error
        }

        public string Time { get; set; }
        public string Mes { get; set; }
        public Log Type { get; set; }
        public override string ToString()
        {
            return $"{Time} : {Type} : {Mes}";
        }
    }
}