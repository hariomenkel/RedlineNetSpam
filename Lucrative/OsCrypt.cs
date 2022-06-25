using System;
using System.Runtime.Serialization;

// Token: 0x0200005D RID: 93
[DataContract(Name = "OsCrypt")]
public class OsCrypt
{
	// Token: 0x17000064 RID: 100
	// (get) Token: 0x0600022A RID: 554 RVA: 0x00003AAC File Offset: 0x00001CAC
	// (set) Token: 0x0600022B RID: 555 RVA: 0x00003AB4 File Offset: 0x00001CB4
	[DataMember(Name = "encrypted_key")]
	public string encrypted_key { get; set; }
}
