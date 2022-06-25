using System;
using System.Runtime.Serialization;

// Token: 0x02000056 RID: 86
[DataContract(Name = "Entity3", Namespace = "Entity")]
[Serializable]
public class Entity_HardwareInfo
{
	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060001CE RID: 462 RVA: 0x00003878 File Offset: 0x00001A78
	// (set) Token: 0x060001CF RID: 463 RVA: 0x00003880 File Offset: 0x00001A80
	[DataMember(Name = "Id1")]
	public string name { get; set; }

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060001D0 RID: 464 RVA: 0x00003889 File Offset: 0x00001A89
	// (set) Token: 0x060001D1 RID: 465 RVA: 0x00003891 File Offset: 0x00001A91
	[DataMember(Name = "Id2")]
	public string value { get; set; }

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000389A File Offset: 0x00001A9A
	// (set) Token: 0x060001D3 RID: 467 RVA: 0x000038A2 File Offset: 0x00001AA2
	[DataMember(Name = "Id3")]
	public Entity_HardwareType Id3 { get; set; }
}
