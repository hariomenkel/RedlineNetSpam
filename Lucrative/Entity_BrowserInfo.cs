using System;
using System.Runtime.Serialization;

// Token: 0x02000057 RID: 87
[DataContract(Name = "Entity4", Namespace = "Entity")]
[Serializable]
public class BrowserInfo
{
	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060001D5 RID: 469 RVA: 0x000038AB File Offset: 0x00001AAB
	// (set) Token: 0x060001D6 RID: 470 RVA: 0x000038B3 File Offset: 0x00001AB3
	[DataMember(Name = "Id1")]
	public string Name { get; set; }

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060001D7 RID: 471 RVA: 0x000038BC File Offset: 0x00001ABC
	// (set) Token: 0x060001D8 RID: 472 RVA: 0x000038C4 File Offset: 0x00001AC4
	[DataMember(Name = "Id2")]
	public string version { get; set; }

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x000038CD File Offset: 0x00001ACD
	// (set) Token: 0x060001DA RID: 474 RVA: 0x000038D5 File Offset: 0x00001AD5
	[DataMember(Name = "Id3")]
	public string Path { get; set; }
}
