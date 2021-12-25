namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log log;
        public string PropriedadeLog { get; set; }

        private Log()
        {
            
        }

        public static Log GetInstance()
        {
            if (log == null)
            {
                log = new Log();
            }
            return log;
        }
    }
}