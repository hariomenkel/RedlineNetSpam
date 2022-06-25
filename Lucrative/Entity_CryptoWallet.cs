using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

// Token: 0x02000053 RID: 83
[DataContract(Name = "Entity17", Namespace = "Entity")]
[Serializable]
public class Entity_CryptoWallet
{
	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600018B RID: 395 RVA: 0x00003658 File Offset: 0x00001858
	// (set) Token: 0x0600018C RID: 396 RVA: 0x00003660 File Offset: 0x00001860
	[DataMember(Name = "Id1")]
	public string Id1 { get; set; }

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x0600018D RID: 397 RVA: 0x00003669 File Offset: 0x00001869
	// (set) Token: 0x0600018E RID: 398 RVA: 0x00003671 File Offset: 0x00001871
	[DataMember(Name = "Id2")]
	public string Id2 { get; set; }

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x0600018F RID: 399 RVA: 0x0000367A File Offset: 0x0000187A
	// (set) Token: 0x06000190 RID: 400 RVA: 0x00003682 File Offset: 0x00001882
	[DataMember(Name = "Id3")]
	public IEnumerable<Entity_FileSearchInformation> Id3 { get; set; }
}
