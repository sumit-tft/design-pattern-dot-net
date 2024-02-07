using System;
using System.IO;

public class Logger
{
    private static Logger instance;
    private static readonly object lockObject = new object();
    private StreamWriter logFile;

    // Private constructor to prevent instantiation from outside
    private Logger()
    {
        // Initialize log file
        logFile = new StreamWriter("logfile.txt");
    }

    // Method to get the singleton instance
    public static Logger GetInstance()
    {
        // Double-check locking for thread safety
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
        }
        return instance;
    }

    // Method to log a message
    public void Log(string message)
    {
        lock (lockObject)
        {
            logFile.WriteLine($"{DateTime.Now}: {message}");
            logFile.Flush();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Get the logger instance
        Logger logger = Logger.GetInstance();

        // Log some messages
        logger.Log("Log message 1");
        logger.Log("Log message 2");
        logger.Log("Log message 3");
    }
}
