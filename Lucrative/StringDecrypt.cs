using System;
using System.Text;

// Token: 0x02000012 RID: 18
public static class StringDecrypt
{
	// Token: 0x06000057 RID: 87 RVA: 0x00005778 File Offset: 0x00003978
	public static string Xor(string input, string stringKey)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < input.Length; i++)
		{
			int utf = (int)(input[i] ^ stringKey[i % stringKey.Length]);
			stringBuilder.AppendFormat("{0}", char.ConvertFromUtf32(utf));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002E04 File Offset: 0x00001004
	private static string FromBase64(string base64str)
	{
		return StringDecrypt.BytesToStringConverted(Convert.FromBase64CharArray(base64str.ToCharArray(), 0, base64str.Length));
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002E1D File Offset: 0x0000101D
	private static string BytesToStringConverted(byte[] bytes)
	{
		return Encoding.UTF8.GetString(bytes);
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000057CC File Offset: 0x000039CC
	public static string Read(string b64, string stringKey)
	{
		string result;
		try
		{
			if (string.IsNullOrWhiteSpace(b64))
			{
				result = string.Empty;
			}
			else
			{
				result = StringDecrypt.FromBase64(StringDecrypt.Xor(StringDecrypt.FromBase64(b64), stringKey));
			}
		}
		catch
		{
			result = b64;
		}
		return result;
	}
}
