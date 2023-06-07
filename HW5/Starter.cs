namespace Module2HW5
{
    public static class Starter
    {
        public static void Run()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = rand.Next(1, 4);
                switch (num)
                {
                    case 1:
                        try
                        {
                            Actions.First();
                        }
                        catch (Exception ex)
                        {
                            Logger log = Logger.Instance;
                            log.LogWrite(new LogType(LogType.Log.Error, $"Action failed by a reason : {ex.Message}"));
                        }

                        break;
                    case 2:
                        try
                        {
                            var res = Actions.Second();
                            if (res is BusinessException)
                            {
                                Logger log = Logger.Instance;
                                log.LogWrite(new LogType(LogType.Log.Warning, $"Action got this custom Exception : {res.Message}"));
                            }
                        }
                        catch (Exception ex)
                        {
                            Logger log = Logger.Instance;
                            log.LogWrite(new LogType(LogType.Log.Error, $"Action failed by a reason : {ex.Message}"));
                        }

                        break;
                    case 3:
                        try
                        {
                            Actions.Third();
                        }
                        catch (Exception ex)
                        {
                            Logger log = Logger.Instance;
                            log.LogWrite(new LogType(LogType.Log.Error, $"Action failed by a reason : {ex.Message}"));
                        }

                        break;
                }

                Thread.Sleep(50);
            }
        }
    }
}
