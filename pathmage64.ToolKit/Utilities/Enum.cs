using pathmage64.ToolKit.Collections;

namespace pathmage64.ToolKit.Utilities;

public static class Enum<TEnum>
	where TEnum : struct, Enum
{
	public static EnumArray<TEnum, string> Names { get; } =
		new(Enum.GetNames<TEnum>());

	public static TEnum[] Values { get; } = Enum.GetValues<TEnum>();

	public static int Length { get; } = Values.Length;
}
