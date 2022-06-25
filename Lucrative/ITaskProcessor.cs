using System;

// Token: 0x02000030 RID: 48
public interface ITaskProcessor
{
	// Token: 0x06000101 RID: 257
	bool IsValidAction(Entity_UpdateAction action);

	// Token: 0x06000102 RID: 258
	bool Process(Entity_Task updateTask);
}
