using System.Text.Json;

namespace Module2HW5
{
    public static class FileService
    {
        public static void CreateFile(string str, string projectPath)
        {
            try
            {
                string configFile = File.ReadAllText($"{projectPath}configs.json");
                Config? config = JsonSerializer.Deserialize<Config>(configFile);
                string dir = $"{projectPath}{config?.Logger?.DirectoryPath}";
                Directory.CreateDirectory(dir);
                string path = $"{dir}\\{DateTime.Now.ToString("HH.mm.ss dd.MM.yyyy")}{config?.Logger?.FileExtension}";
                using (FileStream fs = new FileStream(path, FileMode.Append))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes($"{str} \n");
                    fs.WriteAsync(array, 0, array.Length);
                }

                CheckNumberOfFiles(dir);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CheckNumberOfFiles(string path)
        {
            if (Directory.GetFiles(path).Length > 3)
            {
                File.Delete(Directory.GetFiles(path)[0]);
            }
        }
    }
}
