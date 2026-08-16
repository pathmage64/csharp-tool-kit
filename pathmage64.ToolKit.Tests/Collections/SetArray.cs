using pathmage64.ToolKit.Collections;

namespace pathmage64.ToolKit.Tests.Collections;

public class SetArray
{
	public static void From()
	{
		var set = SetArray<int>.NewFrom(1, 2, 3);

		set.Remove(1);
		set.TryRemove(1);
		set.TryRemove(2);

		foreach (var i in set)
		{
			print(i);
		}
	}
}
