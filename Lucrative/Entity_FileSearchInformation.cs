using System;
using System.Runtime.Serialization;

// Token: 0x02000051 RID: 81
[DataContract(Name = "Entity16", Namespace = "Entity")]
[Serializable]
public class Entity_FileSearchInformation
{
	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600017D RID: 381 RVA: 0x00003603 File Offset: 0x00001803
	// (set) Token: 0x0600017E RID: 382 RVA: 0x0000360B File Offset: 0x0000180B
	[DataMember(Name = "Id5")]
	public string Id5 { get; set; }

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600017F RID: 383 RVA: 0x00003614 File Offset: 0x00001814
	// (set) Token: 0x06000180 RID: 384 RVA: 0x0000361C File Offset: 0x0000181C
	[DataMember(Name = "Id1")]
	public string Id1 { get; set; }

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06000181 RID: 385 RVA: 0x00003625 File Offset: 0x00001825
	// (set) Token: 0x06000182 RID: 386 RVA: 0x0000362D File Offset: 0x0000182D
	[DataMember(Name = "Id2")]
	public string Id2 { get; set; }

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x06000183 RID: 387 RVA: 0x00003636 File Offset: 0x00001836
	// (set) Token: 0x06000184 RID: 388 RVA: 0x0000363E File Offset: 0x0000183E
	[DataMember(Name = "Id3")]
	public bool Id3 { get; set; }
}
