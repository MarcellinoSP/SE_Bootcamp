using NLog;

namespace NLogTrial
{
	class Program
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();
		static void Main()
		{
			var currentDirectory = Directory.GetCurrentDirectory();
			var logConfigFile = Path.Combine(currentDirectory, "Nlog.config");
			LogManager.LoadConfiguration(logConfigFile);
			
			logger.Debug("This is debug message");
			logger.Trace("This is trace message");
			logger.Info("This is info message");
			logger.Warn("This is warning message");
			logger.Error("This is error message");
			logger.Fatal("This is fatal message");
			
			Console.ReadKey();
		}
	}
}
