using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Lucrative;
using Microsoft.CSharp.RuntimeBinder;

// Token: 0x02000017 RID: 23
public class PartsSender : EntityResolver
{
	// Token: 0x0600007C RID: 124 RVA: 0x00005FCC File Offset: 0x000041CC
	public PartsSender()
	{
		EntityResolver.Main = new Enter[]
		{
			new Enter(PartsSender.FAKE_CollectHardwareInfo),
			new Enter(PartsSender.FAKE_CollectBrowsers),
			new Enter(PartsSender.FAKE_CollectListOfPrograms),
			new Enter(PartsSender.FAKE_CollectInstalledAVs),
			new Enter(PartsSender.FAKE_CollectListOfProcesses),
			new Enter(PartsSender.FAKE_CollectAvailableLanguages),
			new Enter(PartsSender.FAKE_CollectTelegramFiles),
			new Enter(PartsSender.FAKE_CollectBrowserData),
			new Enter(PartsSender.FAKE_CollectFiles),
			new Enter(PartsSender.FAKE_CollectFilezilla),
			new Enter(PartsSender.FAKE_CollectWallets),
			new Enter(PartsSender.FAKE_CollectDiscord),
			// new Enter(PartsSender.CollectGameLaunchers),
			new Enter(PartsSender.FAKE_CollectVPN),
			new Enter(PartsSender.FAKE_CollectScreenshot)
		};
		EntityResolver.First = new Enter[]
		{
			new Enter(PartsSender.FAKE_CollectUsername),
			new Enter(PartsSender.FAKE_CollectMonitorSize),
			new Enter(PartsSender.FAKE_CollectWindowsInfo),
			new Enter(PartsSender.FAKE_CollectAppLocation),
			new Enter(PartsSender.FAKE_CreateUniqueID),
			new Enter(PartsSender.FAKE_CollectTimezone)
		};
		Random rnd = new Random();
		EntityResolver.Main = (from x in EntityResolver.Main
		orderby rnd.Next()
		select x).ToArray<Enter>();
		EntityResolver.First = (from x in EntityResolver.First
		orderby rnd.Next()
		select x).ToArray<Enter>();
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002E9E File Offset: 0x0000109E
	public override bool Invoker(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		return PartsSender.sdf9j3nasd(connection, settings, ref result);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00006188 File Offset: 0x00004388
	public static bool sdf9j3nasd(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		bool result2;
		try
		{
			result.StolenData = new Entity_StolenData
			{
				AvailableLanguages = new List<string>(),
				StolenBrowsers = new List<Entity_Browser>(),
				CollectFilezilla = new List<Entity_LoginData>(),
				DiscordTokens = new List<Entity_StolenFile>(),
				GameLaunchers = new List<Entity_StolenFile>(),
				Browsers = new List<BrowserInfo>(),
				TelegramFiles = new List<Entity_StolenFile>(),
				NordApp = new List<Entity_LoginData>(),
				OpenVPN = new List<Entity_StolenFile>(),
				RunningProcesses = new List<string>(),
				ProtonVPN = new List<Entity_StolenFile>(),
				GrabbedFiles = new List<Entity_StolenFile>(),
				Wallets = new List<Entity_StolenFile>(),
				InstalledAVs = new List<string>(),
				InstalledPrograms = new List<string>(),
				HardwareInfo = new List<Entity_HardwareInfo>()
			};
			result.PublicIP = Faker.CollectRandomIP();
			result.AlreadySeen = PartsSender.Visible();
			result.PreCheck();
			foreach (Enter enter in EntityResolver.First)
			{
				try
				{
					enter(connection, settings, ref result);
				}
				catch (InvalidOperationException ex)
				{
					throw ex;
				}
				catch (Exception)
				{
				}
			}
			if (connection.Id6(result) != Entity_ServerResponse.Id2)
			{
				throw new InvalidOperationException();
			}
			PartsSender.LSIDsd2(connection, settings, ref result);
			while (!connection.Id25())
			{
				if (!connection.Id3())
				{
					Thread.Sleep(1000);
				}
			}
			result2 = true;
		}
		catch (InvalidOperationException ex2)
		{
			throw ex2;
		}
		catch (Exception)
		{
			result2 = false;
		}
		return result2;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00006344 File Offset: 0x00004544
	public static bool Visible()
	{
		try
		{
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Yandex\\YaAddon");
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
				return false;
			}
			if (new DirectoryInfo(path).CreationTime < DateTime.Now.AddMonths(-3))
			{
				Directory.Delete(path);
				Directory.CreateDirectory(path);
				return false;
			}
			return true;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06000080 RID: 128 RVA: 0x000063C4 File Offset: 0x000045C4
	public static bool LSIDsd2(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		bool result2;
		try
		{
			foreach (Enter enter in EntityResolver.Main)
			{
				try
				{
					enter(connection, settings, ref result);
				}
				catch (InvalidOperationException ex)
				{
					throw ex;
				}
				catch (Exception)
				{
				}
			}
			result2 = true;
		}
		catch (InvalidOperationException ex2)
		{
			throw ex2;
		}
		catch (Exception)
		{
			result2 = false;
		}
		return result2;
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002EA8 File Offset: 0x000010A8
	public static void FAKE_CreateUniqueID(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.HWID = Faker.CreateFakeHWID();
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002ED8 File Offset: 0x000010D8
	public static void FAKE_CollectAppLocation(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.AppLocation = Faker.CreateFakeAppPath();
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002EEA File Offset: 0x000010EA
	public static void FAKE_CollectWindowsInfo(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.InputLanguage = Faker.CreateFakeInputLanguage();
		result.WindowsVersion = Faker.CreateFakeWindowsVersion();
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00006438 File Offset: 0x00004638
	public static void FAKE_CollectMonitorSize(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.MonitorSize = Faker.CreateFakeMonitorSize();
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002F0C File Offset: 0x0000110C
	public static void FAKE_CollectTimezone(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.TimeZone = Faker.CreateFakeTimeZoneInfo();
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002F1E File Offset: 0x0000111E
	public static void FAKE_CollectUsername(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.UserName = Faker.CreateFakeUsername();
	}

	// Token: 0x06000087 RID: 135 RVA: 0x000064DC File Offset: 0x000046DC
	public static void FAKE_CollectHardwareInfo(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		List<Entity_HardwareInfo> list = new List<Entity_HardwareInfo>();
		foreach (Entity_HardwareInfo item in Faker.CreateFakeProcessors())
		{
			list.Add(item);
		}

		// TODO: Need to test with a real graphics card
		foreach (Entity_HardwareInfo item2 in SystemInfoHelper.GetGraphicCards())
		{
			list.Add(item2);
		}
		list.Add(Faker.CreateFakeRAM());
		Entity_ServerResponse entity = connection.Id13(list);
		if (entity == Entity_ServerResponse.Id3)
		{
			PartsSender.FAKE_CollectHardwareInfo(connection, settings, ref result);
		}
		if (entity == Entity_ServerResponse.Id4)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002F2B File Offset: 0x0000112B
	public static void FAKE_CollectBrowsers(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		Entity_ServerResponse entity = connection.Id14(Faker.CreateFakeBrowsers());
		if (entity == Entity_ServerResponse.Id3)
		{
			PartsSender.FAKE_CollectBrowsers(connection, settings, ref result);
		}
		if (entity == Entity_ServerResponse.Id4)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002F4D File Offset: 0x0000114D
	public static void FAKE_CollectListOfPrograms(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		Entity_ServerResponse entity = connection.Id15(Faker.CreateFakePrograms());
		if (entity == Entity_ServerResponse.Id3)
		{
			PartsSender.FAKE_CollectListOfPrograms(connection, settings, ref result);
		}
		if (entity == Entity_ServerResponse.Id4)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002F6F File Offset: 0x0000116F
	public static void FAKE_CollectInstalledAVs(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		List<string> vs = Faker.CreateFakeAV();
		Entity_ServerResponse entity = connection.Id10((vs != null) ? vs.ToList<string>() : null);
		if (entity == Entity_ServerResponse.Id3)
		{
			PartsSender.FAKE_CollectInstalledAVs(connection, settings, ref result);
		}
		if (entity == Entity_ServerResponse.Id4)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002F9D File Offset: 0x0000119D
	public static void FAKE_CollectListOfProcesses(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		Entity_ServerResponse entity = connection.Id20(Faker.CreateFakeProcesses());
		if (entity == Entity_ServerResponse.Id3)
		{
			PartsSender.FAKE_CollectListOfProcesses(connection, settings, ref result);
		}
		if (entity == Entity_ServerResponse.Id4)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002FBF File Offset: 0x000011BF
	public static void FAKE_CollectAvailableLanguages(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		List<string> languages = new List<string>();
		languages.Add(Faker.CreateFakeInputLanguage());
		Entity_ServerResponse entity = connection.Id16(languages);
		if (entity == Entity_ServerResponse.Id3)
		{
			PartsSender.FAKE_CollectAvailableLanguages(connection, settings, ref result);
		}
		if (entity == Entity_ServerResponse.Id4)
		{
			throw new InvalidOperationException();
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002FE1 File Offset: 0x000011E1
	public static void FAKE_CollectScreenshot(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectScreenshot)
		{
			Entity_ServerResponse entity = connection.Id7(Faker.CreateRandomBytes());
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectScreenshot(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x000065D4 File Offset: 0x000047D4
	public static void FAKE_CollectTelegramFiles(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectTelegram)
		{
			List<Entity_StolenFile> result2 = Faker.CreateFakeTelegramData();
			Entity_ServerResponse entity = connection.Id24(result2);
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectTelegramFiles(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x0000661C File Offset: 0x0000481C
	public static void FAKE_CollectBrowserData(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectBrowsers)
		{
			Entity_ServerResponse entity = connection.Id8(Faker.CreateFakeBrowserData(settings.Id11));
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectBrowserData(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000300B File Offset: 0x0000120B
	public static void FAKE_CollectFiles(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.GrabFiles)
		{
			Entity_ServerResponse entity = connection.Id22(Faker.CollectStolenFiles(settings.AllowedFiles));
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectFiles(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000303B File Offset: 0x0000123B
	public static void FAKE_CollectFilezilla(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectFTP)
		{
			Entity_ServerResponse entity = connection.Id12(Faker.CollectFilezillaCredentials());
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectFilezilla(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00006678 File Offset: 0x00004878
	public static void FAKE_CollectWallets(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectWallets)
		{			
			Entity_ServerResponse entity = connection.Id9(Faker.CollectWallets());
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectWallets(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00003065 File Offset: 0x00001265
	public static void FAKE_CollectDiscord(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectDiscord)
		{
			Entity_ServerResponse entity = connection.Id11(Faker.CollectDiscordToken());
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.FAKE_CollectDiscord(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
		}
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000309B File Offset: 0x0000129B
	public static void CollectGameLaunchers(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectGameLaunchers)
		{
			/*
			Entity_ServerResponse entity = connection.Id23(FileScanning.Search(new Extractor[]
			{
				new GameLauncher()
			}));
			if (entity == Entity_ServerResponse.Id3)
			{
				PartsSender.CollectGameLaunchers(connection, settings, ref result);
			}
			if (entity == Entity_ServerResponse.Id4)
			{
				throw new InvalidOperationException();
			}
			*/
		}
	}

	// Token: 0x06000095 RID: 149 RVA: 0x000066E4 File Offset: 0x000048E4
	public static void FAKE_CollectVPN(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectVPN)
		{
			connection.Id18(Faker.CollectNordVPN());
			connection.Id19(Faker.CollectOpenVPN());
			connection.Id21(Faker.CollectOpenVPN()); // ProtonVPN seems to have the same format as OpenVPN
		}
	}
}
