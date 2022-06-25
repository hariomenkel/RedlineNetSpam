using System;
using System.Runtime.Serialization;

// Token: 0x02000044 RID: 68
[DataContract(Name = "Entity8", Namespace = "Entity")]
[Serializable]
public class Entity_AutoFill
{
	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000140 RID: 320 RVA: 0x00003446 File Offset: 0x00001646
	// (set) Token: 0x06000141 RID: 321 RVA: 0x0000344E File Offset: 0x0000164E
	[DataMember(Name = "Id1")]
	public string Name { get; set; }

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000142 RID: 322 RVA: 0x00003457 File Offset: 0x00001657
	// (set) Token: 0x06000143 RID: 323 RVA: 0x0000345F File Offset: 0x0000165F
	[DataMember(Name = "Id2")]
	public string Value { get; set; }
}
