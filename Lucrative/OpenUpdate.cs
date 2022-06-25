using System;
using System.Diagnostics;

// Token: 0x02000031 RID: 49
public class OpenUpdate : ITaskProcessor
{
	// Token: 0x06000103 RID: 259 RVA: 0x00003324 File Offset: 0x00001524
	public bool IsValidAction(Entity_UpdateAction action)
	{
		return action == Entity_UpdateAction.Id4;
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000965C File Offset: 0x0000785C
	public bool Process(Entity_Task updateTask)
	{
		try
		{
			System.Diagnostics.Process.Start(updateTask.Id2);
		}
		catch
		{
		}
		return true;
	}
}
