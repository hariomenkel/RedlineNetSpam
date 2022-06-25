using System;
using System.Runtime.Serialization;

// Token: 0x0200005C RID: 92
[DataContract(Name = "LocalState")]
public class LocalState
{
	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000227 RID: 551 RVA: 0x00003A9B File Offset: 0x00001C9B
	// (set) Token: 0x06000228 RID: 552 RVA: 0x00003AA3 File Offset: 0x00001CA3
	[DataMember(Name = "os_crypt")]
	public OsCrypt os_crypt { get; set; }
}
