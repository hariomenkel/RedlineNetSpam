using System;
using System.IO;
using System.Text;

// Token: 0x02000034 RID: 52
public static class FileExt
{
	// Token: 0x0600010C RID: 268 RVA: 0x00009834 File Offset: 0x00007A34
	public static byte[] ReadFile(this string filename)
	{
		try
		{
			if (File.Exists(filename))
			{
				using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(1251)))
					{
						return streamReader.CurrentEncoding.GetBytes(streamReader.ReadToEnd());
					}
				}
			}
		}
		catch
		{
		}
		return new byte[0];
	}

	// Token: 0x0600010D RID: 269 RVA: 0x000098C4 File Offset: 0x00007AC4
	public static string ReadFileAsText(this string filename)
	{
		try
		{
			if (File.Exists(filename))
			{
				using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				{
					using (StreamReader streamReader = new StreamReader(fileStream, Encoding.GetEncoding(1251)))
					{
						return streamReader.ReadToEnd();
					}
				}
			}
		}
		catch
		{
		}
		return null;
	}
}
