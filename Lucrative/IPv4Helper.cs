using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

// Token: 0x0200003F RID: 63
public static class IPv4Helper
{
	// Token: 0x06000125 RID: 293 RVA: 0x00009FEC File Offset: 0x000081EC
	private static bool IsLocalIp(IPAddress ip)
	{
		int[] array = ip.ToString().Split(new string[]
		{
			"."
		}, StringSplitOptions.RemoveEmptyEntries).Select(new Func<string, int>(int.Parse)).ToArray<int>();
		return (array[0] == 192 && array[1] == 168) || (array[0] == 172 && array[1] >= 16 && array[1] <= 31) || array[0] == 10;
	}	

	// Token: 0x06000127 RID: 295 RVA: 0x0000A184 File Offset: 0x00008384
	private static string Request(string uri, int timeout)
	{
		string result;
		try
		{
			WebRequest webRequest = WebRequest.Create(uri);
			webRequest.Timeout = timeout;
			using (Stream responseStream = webRequest.GetResponse().GetResponseStream())
			{
				using (StreamReader streamReader = new StreamReader(responseStream))
				{
					result = streamReader.ReadToEnd().Trim();
				}
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}
}
