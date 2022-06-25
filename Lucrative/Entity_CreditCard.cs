using System;
using System.Runtime.Serialization;

// Token: 0x02000047 RID: 71
[DataContract(Name = "Entity11", Namespace = "Entity")]
[Serializable]
public class Entity_CreditCard
{
	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000163 RID: 355 RVA: 0x00003559 File Offset: 0x00001759
	// (set) Token: 0x06000164 RID: 356 RVA: 0x00003561 File Offset: 0x00001761
	[DataMember(Name = "Id1")]
	public string NameOnCard { get; set; }

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x06000165 RID: 357 RVA: 0x0000356A File Offset: 0x0000176A
	// (set) Token: 0x06000166 RID: 358 RVA: 0x00003572 File Offset: 0x00001772
	[DataMember(Name = "Id2")]
	public int Expiration_Month { get; set; }

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000167 RID: 359 RVA: 0x0000357B File Offset: 0x0000177B
	// (set) Token: 0x06000168 RID: 360 RVA: 0x00003583 File Offset: 0x00001783
	[DataMember(Name = "Id3")]
	public int Expiration_Year { get; set; }

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000169 RID: 361 RVA: 0x0000358C File Offset: 0x0000178C
	// (set) Token: 0x0600016A RID: 362 RVA: 0x00003594 File Offset: 0x00001794
	[DataMember(Name = "Id4")]
	public string CardNumber { get; set; }
}
