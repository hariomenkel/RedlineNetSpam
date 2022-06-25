using System;
using System.Runtime.Serialization;

// Token: 0x02000048 RID: 72
[DataContract(Name = "Entity12", Namespace = "Entity")]
[Serializable]
public class Entity_LoginData
{
	// Token: 0x1700001D RID: 29
	// (get) Token: 0x0600016C RID: 364 RVA: 0x0000359D File Offset: 0x0000179D
	// (set) Token: 0x0600016D RID: 365 RVA: 0x000035A5 File Offset: 0x000017A5
	[DataMember(Name = "Id1")]
	public string URL { get; set; }

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x0600016E RID: 366 RVA: 0x000035AE File Offset: 0x000017AE
	// (set) Token: 0x0600016F RID: 367 RVA: 0x000035B6 File Offset: 0x000017B6
	[DataMember(Name = "Id2")]
	public string Username { get; set; }

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000170 RID: 368 RVA: 0x000035BF File Offset: 0x000017BF
	// (set) Token: 0x06000171 RID: 369 RVA: 0x000035C7 File Offset: 0x000017C7
	[DataMember(Name = "Id3")]
	public string Password { get; set; }
}
