namespace Dave.Objects
{
    public static class Logger
    {
        public static void Log(string path, string message)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.AppendAllText(path, message + "\n");
                }
                else
                {
                    File.Create(path);
                    File.AppendAllText(path, message + "\n");
                }
            }
            catch (Exception ex) { }
        }
    }
}
