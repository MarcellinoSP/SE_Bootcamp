using log4net;
using log4net.Config;

namespace Log4NetTrial;

internal class Program
{
	private static readonly ILog logger = LogManager.GetLogger(typeof(Program));
	static void Main()
	{
		XmlConfigurator.Configure(new FileInfo ("log4net.config"));
		
		logger.Info("Program begin...");
		logger.Debug("This message come as a debug");
	}
}