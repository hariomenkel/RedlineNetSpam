using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000054 RID: 84
[DataContract(Name = "Entity2", Namespace = "Entity")]
[Serializable]
public class Entity_Settings
{
	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000192 RID: 402 RVA: 0x0000368B File Offset: 0x0000188B
	// (set) Token: 0x06000193 RID: 403 RVA: 0x00003693 File Offset: 0x00001893
	[DataMember(Name = "Id1")]
	public bool CollectBrowsers { get; set; }

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000194 RID: 404 RVA: 0x0000369C File Offset: 0x0000189C
	// (set) Token: 0x06000195 RID: 405 RVA: 0x000036A4 File Offset: 0x000018A4
	[DataMember(Name = "Id2")]
	public bool GrabFiles { get; set; }

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000196 RID: 406 RVA: 0x000036AD File Offset: 0x000018AD
	// (set) Token: 0x06000197 RID: 407 RVA: 0x000036B5 File Offset: 0x000018B5
	[DataMember(Name = "Id3")]
	public bool CollectFTP { get; set; }

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000198 RID: 408 RVA: 0x000036BE File Offset: 0x000018BE
	// (set) Token: 0x06000199 RID: 409 RVA: 0x000036C6 File Offset: 0x000018C6
	[DataMember(Name = "Id4")]
	public bool CollectWallets { get; set; }

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600019A RID: 410 RVA: 0x000036CF File Offset: 0x000018CF
	// (set) Token: 0x0600019B RID: 411 RVA: 0x000036D7 File Offset: 0x000018D7
	[DataMember(Name = "Id5")]
	public bool CollectScreenshot { get; set; }

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600019C RID: 412 RVA: 0x000036E0 File Offset: 0x000018E0
	// (set) Token: 0x0600019D RID: 413 RVA: 0x000036E8 File Offset: 0x000018E8
	[DataMember(Name = "Id6")]
	public bool CollectTelegram { get; set; }

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600019E RID: 414 RVA: 0x000036F1 File Offset: 0x000018F1
	// (set) Token: 0x0600019F RID: 415 RVA: 0x000036F9 File Offset: 0x000018F9
	[DataMember(Name = "Id7")]
	public bool CollectVPN { get; set; }

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x00003702 File Offset: 0x00001902
	// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000370A File Offset: 0x0000190A
	[DataMember(Name = "Id8")]
	public bool CollectGameLaunchers { get; set; }

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x00003713 File Offset: 0x00001913
	// (set) Token: 0x060001A3 RID: 419 RVA: 0x0000371B File Offset: 0x0000191B
	[DataMember(Name = "Id9")]
	public bool CollectDiscord { get; set; }

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x00003724 File Offset: 0x00001924
	// (set) Token: 0x060001A5 RID: 421 RVA: 0x0000372C File Offset: 0x0000192C
	[DataMember(Name = "Id10")]
	public List<string> AllowedFiles { get; set; }

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x00003735 File Offset: 0x00001935
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000373D File Offset: 0x0000193D
	[DataMember(Name = "Id11")]
	public List<string> Id11 { get; set; }

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x00003746 File Offset: 0x00001946
	// (set) Token: 0x060001A9 RID: 425 RVA: 0x0000374E File Offset: 0x0000194E
	[DataMember(Name = "Id12")]
	public List<string> Id12 { get; set; }

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060001AA RID: 426 RVA: 0x00003757 File Offset: 0x00001957
	// (set) Token: 0x060001AB RID: 427 RVA: 0x0000375F File Offset: 0x0000195F
	[DataMember(Name = "Id13")]
	public List<Entity_CryptoWallet> Id13 { get; set; }
}
