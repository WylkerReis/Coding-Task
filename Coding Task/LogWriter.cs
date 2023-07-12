namespace LogUtils
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;

    public class LogWriter
    {
        // Create a data model to store log information. Since it is used only in this class it can be defined as internal

        internal class LogEntry
        {
            public DateTime Date { get; set; }
            public string Message { get; set; }
            public string AppLog { get; set; } 
            public string Method { get; set; }
        }
        // Singleton, used to acess funcionalities  of this class. Ensure that there's only one instance per application
        private static LogWriter instance;
        public static LogWriter Instance
        {
            get
            {
                if (instance == null)
                    instance = new LogWriter();
                return instance;
            }
        }
        // End Singleton declaration

        private Queue<LogEntry> LogPool;
        private Thread thread;
        //Store the local folder  of the application
        private string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "");

        public LogWriter()
        {
            // Creates queue of log entrys
            LogPool = new Queue<LogEntry>();
            // Creates saving responsible's thread in the arquive
            thread = new Thread(new ThreadStart(WriteOnDisk));

            thread.Start();
        }
        // Task to be executedby thread
        private void WriteOnDisk()
        {
            while (true) // execute indefinitely
            {
                if (LogPool.Count > 0) // check if there is log to save
                {
                    LogEntry entry = LogPool.Dequeue(); // Clear log queue 
                    // Format saving path of log file
                    string finalPath = Path.Combine(path, "Logs",entry.AppLog + "application" + ".log");
                    // Creates directory if doesn't exist
                    if (!Directory.Exists(Path.GetDirectoryName(finalPath)))
                        Directory.CreateDirectory(Path.GetDirectoryName(finalPath));

                    // Save log
                    using (StreamWriter sw = File.AppendText(finalPath))
                    // Format log message 
                    {
                        sw.WriteLine(string.Format("[{0}] [{1}] {2}", entry.Date, entry.Message, entry.Method, entry.AppLog));
                    }
                }
            }
        }

        public void WriteLog(string message, string method, string applog)
        {
            // Create an object LogEntry
            LogEntry entry = new LogEntry { Date = DateTime.Now, Method = method, Message = message };
            //Add entry to the queue
            LogPool.Enqueue(entry);
        }
    }
}