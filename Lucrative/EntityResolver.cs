using System;

// Token: 0x0200001E RID: 30
public abstract class EntityResolver
{
	// Token: 0x17000002 RID: 2
	// (get) Token: 0x060000BA RID: 186 RVA: 0x000031FA File Offset: 0x000013FA
	// (set) Token: 0x060000BB RID: 187 RVA: 0x00003201 File Offset: 0x00001401
	protected static Enter[] Main { get; set; }

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00003209 File Offset: 0x00001409
	// (set) Token: 0x060000BD RID: 189 RVA: 0x00003210 File Offset: 0x00001410
	protected static Enter[] First { get; set; }

	// Token: 0x060000BE RID: 190
	public abstract bool Invoker(ConnectionProvider connection, Entity_Settings settings, ref Entity_CollectedResults result);
}
