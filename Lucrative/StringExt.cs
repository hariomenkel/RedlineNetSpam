using System;

// Token: 0x02000036 RID: 54
public static class StringExt
{
	// Token: 0x06000111 RID: 273 RVA: 0x0000337A File Offset: 0x0000157A
	public static T ChangeType<T>(this object @this)
	{
		return (T)((object)Convert.ChangeType(@this, typeof(T)));
	}

	// Token: 0x06000112 RID: 274 RVA: 0x00003391 File Offset: 0x00001591
	public static string StripQuotes(this string value)
	{
		return value.Replace("\"", string.Empty);
	}
}
