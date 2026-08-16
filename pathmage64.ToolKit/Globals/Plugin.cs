using System.Threading;
using pathmage64.ToolKit.Debug;

namespace pathmage64.ToolKit.Globals;

public interface Plugin
{
	static ILogger Logger
	{
		get => _logger;
		set
		{
			lock (LoggerLock)
				_logger = value;
		}
	}
	private static ILogger _logger = new Logger(
		Console.Write,
		Console.WriteLine
	);
	static readonly Lock LoggerLock = new();
}
