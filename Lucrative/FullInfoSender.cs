using Lucrative;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

// Token: 0x0200001A RID: 26
public class FullInfoSender : EntityResolver
{
	// Token: 0x06000099 RID: 153 RVA: 0x0000673C File Offset: 0x0000493C
	public FullInfoSender()
	{		
		EntityResolver.Main = new Enter[]
		{			
			new Enter(FullInfoSender.FAKE_CollectHardwareInfo),
			new Enter(FullInfoSender.FAKE_CollectBrowsers),
			new Enter(FullInfoSender.FAKE_CollectListOfPrograms),
			new Enter(FullInfoSender.FAKE_CollectInstalledAVs),
			new Enter(FullInfoSender.FAKE_CollectListOfProcesses),
			new Enter(FullInfoSender.FAKE_CollectAvailableLanguages),
			new Enter(FullInfoSender.FAKE_CollectTelegramFiles),
			new Enter(FullInfoSender.FAKE_CollectBrowserData),
			new Enter(FullInfoSender.FAKE_CollectFiles),
			new Enter(FullInfoSender.FAKE_CollectFilezilla),
			new Enter(FullInfoSender.FAKE_CollectWallets),
			new Enter(FullInfoSender.FAKE_CollectDiscord),
			// new Enter(FullInfoSender.CollectGameLaunchers), Maybe added in a future version
			new Enter(FullInfoSender.FAKE_CollectVPN),
			new Enter(FullInfoSender.FAKE_CollectScreenshot)
			
		};
		EntityResolver.First = new Enter[]
		{
			new Enter(FullInfoSender.FAKE_CollectUsername),
			new Enter(FullInfoSender.FAKE_CollectMonitorSize),
			new Enter(FullInfoSender.FAKE_CollectWindowsInfo),
			new Enter(FullInfoSender.FAKE_GetAppLocation),
			new Enter(FullInfoSender.FAKE_CreateUniqueID),
			new Enter(FullInfoSender.FAKE_CollectTimeZone)
		};
		
		Random rnd = new Random();
		EntityResolver.Main = (from x in EntityResolver.Main
		orderby rnd.Next()
		select x).ToArray<Enter>();
		EntityResolver.First = (from x in EntityResolver.First
		orderby rnd.Next()
		select x).ToArray<Enter>();
	}

	// Token: 0x0600009A RID: 154 RVA: 0x000030E0 File Offset: 0x000012E0
	public override bool Invoker(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		return FullInfoSender.sdfk8h34(connection, settings, ref result);
	}

	public static bool sdfk8h34(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
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
			result.AlreadySeen = FullInfoSender.FAKE_AlreadySeen();
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
			
			FullInfoSender.send(connection, settings, ref result);

			Logger.Log("Sending data to server");
			connection.Id4(result);
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

	// Token: 0x0600009C RID: 156 RVA: 0x00006344 File Offset: 0x00004544
	public static bool FAKE_AlreadySeen()
	{		
		return false;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x000063C4 File Offset: 0x000045C4
	public static bool send(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
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

	// Token: 0x0600009E RID: 158 RVA: 0x00002EA8 File Offset: 0x000010A8
	public static void FAKE_CreateUniqueID(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.HWID = Faker.CreateFakeHWID();
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002ED8 File Offset: 0x000010D8
	public static void FAKE_GetAppLocation(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.AppLocation = Faker.CreateFakeAppPath();	
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002EEA File Offset: 0x000010EA
	public static void FAKE_CollectWindowsInfo(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		// result.InputLanguage = InputLanguage.CurrentInputLanguage.Culture.EnglishName;
		result.InputLanguage = Faker.CreateFakeInputLanguage();
		result.WindowsVersion = Faker.CreateFakeWindowsVersion();
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00006A90 File Offset: 0x00004C90
	public static void FAKE_CollectMonitorSize(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.MonitorSize = Faker.CreateFakeMonitorSize();
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002F0C File Offset: 0x0000110C
	public static void FAKE_CollectTimeZone(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.TimeZone = Faker.CreateFakeTimeZoneInfo();
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002F1E File Offset: 0x0000111E
	public static void FAKE_CollectUsername(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.UserName = Faker.CreateFakeUsername();
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00006B34 File Offset: 0x00004D34
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
		
		result.StolenData.HardwareInfo = list;
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x000030EA File Offset: 0x000012EA
	public static void FAKE_CollectBrowsers(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.StolenData.Browsers = Faker.CreateFakeBrowsers();
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x000030FC File Offset: 0x000012FC
	public static void FAKE_CollectListOfPrograms(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.StolenData.InstalledPrograms = Faker.CreateFakePrograms();
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x0000310E File Offset: 0x0000130E
	public static void FAKE_CollectInstalledAVs(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		Entity_StolenData id = result.StolenData;
		id.InstalledAVs = Faker.CreateFakeAV();
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x0000312C File Offset: 0x0000132C
	public static void FAKE_CollectListOfProcesses(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		result.StolenData.RunningProcesses = Faker.CreateFakeProcesses();
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x0000313E File Offset: 0x0000133E
	public static void FAKE_CollectAvailableLanguages(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		List<string> languages = new List<string>();
		languages.Add(Faker.CreateFakeInputLanguage());
		result.StolenData.AvailableLanguages = languages;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00003150 File Offset: 0x00001350
	public static void FAKE_CollectScreenshot(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectScreenshot)
		{
			result.Screenshot = Faker.CreateRandomBytes();
		}
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00006C1C File Offset: 0x00004E1C
	public static void FAKE_CollectTelegramFiles(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectTelegram)
		{			
			result.StolenData.TelegramFiles = Faker.CreateFakeTelegramData();
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00006C54 File Offset: 0x00004E54
	public static void FAKE_CollectBrowserData(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectBrowsers)
		{
			result.StolenData.StolenBrowsers = Faker.CreateFakeBrowserData(settings.Id11);
		}
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00003165 File Offset: 0x00001365
	public static void FAKE_CollectFiles(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.GrabFiles)
		{
			result.StolenData.GrabbedFiles = Faker.CollectStolenFiles(settings.AllowedFiles);
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00003185 File Offset: 0x00001385
	public static void FAKE_CollectFilezilla(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectFTP)
		{
			result.StolenData.CollectFilezilla = Faker.CollectFilezillaCredentials();
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00006CA0 File Offset: 0x00004EA0
	public static void FAKE_CollectWallets(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectWallets)
		{
			result.StolenData.Wallets = Faker.CollectWallets();
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x0000319F File Offset: 0x0000139F
	public static void FAKE_CollectDiscord(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectDiscord)
		{
			Entity_StolenData id = result.StolenData;
			id.DiscordTokens = Faker.CollectDiscordToken();
		}
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000031C5 File Offset: 0x000013C5
	public static void CollectGameLaunchers(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectGameLaunchers)
		{
			// Fake GameLauncher
		}
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00006CFC File Offset: 0x00004EFC
	public static void FAKE_CollectVPN(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result)
	{
		if (settings.CollectVPN)
		{
			result.StolenData.NordApp = Faker.CollectNordVPN();
			result.StolenData.OpenVPN = Faker.CollectOpenVPN();
			result.StolenData.ProtonVPN = Faker.CollectOpenVPN(); // Seems to have the same format as OpenVPN
		}
	}
}
