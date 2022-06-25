using System;
using System.Runtime.Serialization;

// Token: 0x0200005A RID: 90
[DataContract(Name = "Entity6", Namespace = "Entity")]
public class Entity_Task
{
	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000200 RID: 512 RVA: 0x00003958 File Offset: 0x00001B58
	// (set) Token: 0x06000201 RID: 513 RVA: 0x00003960 File Offset: 0x00001B60
	[DataMember(Name = "Id1")]
	public int Id1 { get; set; }

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000202 RID: 514 RVA: 0x00003969 File Offset: 0x00001B69
	// (set) Token: 0x06000203 RID: 515 RVA: 0x00003971 File Offset: 0x00001B71
	[DataMember(Name = "Id2")]
	public string Id2 { get; set; }

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000204 RID: 516 RVA: 0x0000397A File Offset: 0x00001B7A
	// (set) Token: 0x06000205 RID: 517 RVA: 0x00003982 File Offset: 0x00001B82
	[DataMember(Name = "Id3")]
	public Entity_UpdateAction Id3 { get; set; }

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000206 RID: 518 RVA: 0x0000398B File Offset: 0x00001B8B
	// (set) Token: 0x06000207 RID: 519 RVA: 0x00003993 File Offset: 0x00001B93
	[DataMember(Name = "Id4")]
	public string Id4 { get; set; }
}
