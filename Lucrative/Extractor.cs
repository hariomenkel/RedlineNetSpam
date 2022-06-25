using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x02000052 RID: 82
public abstract class Extractor
{
	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06000186 RID: 390 RVA: 0x00003647 File Offset: 0x00001847
	// (set) Token: 0x06000187 RID: 391 RVA: 0x0000364F File Offset: 0x0000184F
	public string Id1 { get; set; }

	// Token: 0x06000188 RID: 392
	public abstract string Id2(Entity_FileSearchInformation scannerArg, FileInfo filePath);

	// Token: 0x06000189 RID: 393
	public abstract IEnumerable<Entity_FileSearchInformation> Id3();
}
