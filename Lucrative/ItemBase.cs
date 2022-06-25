using System;

// Token: 0x0200001F RID: 31
public static class ItemBase
{
	// Token: 0x060000C0 RID: 192 RVA: 0x00003218 File Offset: 0x00001418
	public static T Extract<T>() where T : EntityResolver
	{
		if (Arguments.Version != 1)
		{
			return Activator.CreateInstance<FullInfoSender>() as T;
		}
		return Activator.CreateInstance<PartsSender>() as T;
	}
}
