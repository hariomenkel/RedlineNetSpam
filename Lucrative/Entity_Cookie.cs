using System;
using System.Runtime.Serialization;

// Token: 0x02000046 RID: 70
[DataContract(Name = "Entity10", Namespace = "Entity")]
[Serializable]
public class Entity_Cookie
{
	// Token: 0x06000153 RID: 339 RVA: 0x00002BB8 File Offset: 0x00000DB8
	public Entity_Cookie()
	{
	}

	// Token: 0x06000154 RID: 340 RVA: 0x000034CE File Offset: 0x000016CE
	public Entity_Cookie(string expires)
	{
		this.expires_utc = long.Parse(expires);
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000155 RID: 341 RVA: 0x000034E2 File Offset: 0x000016E2
	// (set) Token: 0x06000156 RID: 342 RVA: 0x000034EA File Offset: 0x000016EA
	[DataMember(Name = "Id1")]
	public string host_key { get; set; }

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x06000157 RID: 343 RVA: 0x000034F3 File Offset: 0x000016F3
	// (set) Token: 0x06000158 RID: 344 RVA: 0x000034FB File Offset: 0x000016FB
	[DataMember(Name = "Id2")]
	public bool also_host_key { get; set; }

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x06000159 RID: 345 RVA: 0x00003504 File Offset: 0x00001704
	// (set) Token: 0x0600015A RID: 346 RVA: 0x0000350C File Offset: 0x0000170C
	[DataMember(Name = "Id3")]
	public string path { get; set; }

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600015B RID: 347 RVA: 0x00003515 File Offset: 0x00001715
	// (set) Token: 0x0600015C RID: 348 RVA: 0x0000351D File Offset: 0x0000171D
	[DataMember(Name = "Id4")]
	public bool is_secure { get; set; }

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x0600015D RID: 349 RVA: 0x00003526 File Offset: 0x00001726
	// (set) Token: 0x0600015E RID: 350 RVA: 0x0000352E File Offset: 0x0000172E
	[DataMember(Name = "Id5")]
	public long expires_utc { get; set; }

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x0600015F RID: 351 RVA: 0x00003537 File Offset: 0x00001737
	// (set) Token: 0x06000160 RID: 352 RVA: 0x0000353F File Offset: 0x0000173F
	[DataMember(Name = "Id6")]
	public string name { get; set; }

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000161 RID: 353 RVA: 0x00003548 File Offset: 0x00001748
	// (set) Token: 0x06000162 RID: 354 RVA: 0x00003550 File Offset: 0x00001750
	[DataMember(Name = "Id7")]
	public string encrypted_value { get; set; }
}
