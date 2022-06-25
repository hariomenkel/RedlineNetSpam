using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Lucrative
{
    public class Faker
    {
        static Random rnd = new Random();
        
        static string[] first_names = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "static\\first-names.txt").ToArray();
        static string[] last_names = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "static\\last-names.txt").ToArray();
        static string[] possible_applications = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "static\\applications.txt").ToArray();
        static string[] possible_domains = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "static\\domains.txt").ToArray();
        static string[] possible_mail_domains = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "static\\mail-domains.txt").ToArray();
       
        

        public static string CreateFakeHWID()
        {
            Logger.Log("Creating Fake HWID");
            var bytes = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        public static string CreateFakeMonitorSize()
        {
            Logger.Log("Creating Fake Monitor Size");
            return rnd.Next(400, 2000).ToString() + " x " + rnd.Next(400, 2000).ToString();
        }

        public static string CreateFakeTimeZoneInfo()
        {
            Logger.Log("Creating Fake TimeZone Info");
            ReadOnlyCollection<TimeZoneInfo> tz = TimeZoneInfo.GetSystemTimeZones();
            TimeZoneInfo selected_tz = tz[rnd.Next(0, tz.Count - 1)];
            return selected_tz.DisplayName;
        }

        public static string CreateFakeUsername()
        {
            string rand_firstname = first_names[rnd.Next(0, first_names.Count() - 1)];
            string rand_lastname = last_names[rnd.Next(0, last_names.Count() - 1)];

            int option = rnd.Next(0, 3);
            switch (option){
                case 0: return rand_firstname + "." + rand_lastname;
                case 1: return rand_firstname[0] + rand_lastname;
                case 2: return rand_lastname + rand_firstname;
                case 3: return rand_firstname + rand_lastname[0];
            }

            return "";
        }

        public static string CreateFakeWindowsVersion()
        {
            Logger.Log("Creating Fake Windows Version");
            List<string> versions = new List<string> {
                "Windows 10 Enterprise",
                "Windows 10 Home",
                "Windows Server 2019",
                "Windows Server 2016",
                "Windows 8.1",
                "Windows Server 2012 R2",
                "Windows 8",
                "Windows Server 2012",
                "Windows 7",
                "Windows Server 2008 R2",
                "Windows Server 2008",
                "Windows Vista",
                "Windows Server 2003 R2",
                "Windows Server 2003",
                "Windows XP"
            };

            List<string> architectures = new List<string> { "x32", "x64" };

            return versions[rnd.Next(0, versions.Count() - 1)] + " " + architectures[rnd.Next(0, architectures.Count() -1)];
        }

        public static string CreateFakeInputLanguage()
        {
            Logger.Log("Creating Fake Input Language");
            CultureInfo[] cinfo = CultureInfo.GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures);
            CultureInfo ci = cinfo[rnd.Next(0, cinfo.Length - 1)];
            return ci.EnglishName;
        }

        public static string CreateFakeAppPath()
        {
            Logger.Log("Creating Fake App Path");
            string[] possible_pathes = new string[] { "Desktop", "Downloads", "Documents", "Office", "Shared" };
            return "C:\\Users\\" + first_names[rnd.Next(0, first_names.Count() - 1)] + "\\" + possible_pathes[rnd.Next(0, possible_pathes.Length - 1)] +
                "\\" + CreateRandomFileName();
        }

        public static string CreateRandomFileName()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[rnd.Next(8, 16)];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rnd.Next(chars.Length)];
            }

            return new String(stringChars) + ".exe";
        }

        public static List<Entity_HardwareInfo> CreateFakeProcessors()
        {
            Logger.Log("Creating Fake Processors");
            List<Entity_HardwareInfo> list = new List<Entity_HardwareInfo>();
            list.Add(new Entity_HardwareInfo
            {
                name = "Intel(R) Core(TM) i" + rnd.Next(3,7).ToString() + "-" + rnd.Next(1500,9600).ToString() + " CPU @ " + rnd.Next(1,4).ToString() +
                "." + rnd.Next(10,99).ToString() + "GHz",
                value = rnd.Next(2,32).ToString(),
                Id3 = Entity_HardwareType.Id1
            });
            return list;
        }
        
        public static Entity_HardwareInfo CreateFakeRAM()
        {
            Logger.Log("Creating Fake RAM");
            double sizeOfRam = rnd.Next(1024, 16384);
            Entity_HardwareInfo e = new Entity_HardwareInfo();
            e.name = "Total of RAM";
            e.Id3 = Entity_HardwareType.Id2;
            e.value = sizeOfRam.ToString() + "." + rnd.Next(10,99).ToString() + " MB or " + (sizeOfRam * 1024).ToString();
            return e;
        }

        public static List<BrowserInfo> CreateFakeBrowsers()
        {
            Logger.Log("Creating Fake Browsers");
            string[] possible_browsers = {"7Star",
                "360Browser",
                "Amigo",
                "Brave",
                "Bromium",
                "CentBrowser",
                "Chedot",
                "Chromium",
                "CocCoc",
                "ComodoDragon",
                "Cyberfox",
                "ElementsBrowser",
                "Epic",
                "FileZilla",
                "GoBrowser",
                "GoogleChrome",
                "GoogleChrome64",
                "IceDragon",
                "InternetExplorer",
                "InternetMailRu",
                "Kometa",
                "MicrosoftEdge",
                "MozillaFireFox",
                "Mustang",
                "Nichrome",
                "Opera",
                "Orbitum",
                "Outlook",
                "PaleMoon",
                "Pidgin",
                "Psi",
                "PsiPlus",
                "QIPSurf",
                "RockMelt",
                "SaferBrowser",
                "Sputnik",
                "Suhba",
                "Superbird",
                "ThunderBird",
                "TorBro",
                "Torch",
                "Uran",
                "Vivaldi",
                "Waterfox",
                "WinSCP",
                "YandexBrowser" };

            List<BrowserInfo> browsers = new List<BrowserInfo>();

            for (int i = 0; i<=rnd.Next(1,4); i++)
            {
                string selected_browser = possible_browsers[rnd.Next(0, possible_browsers.Length - 1)];
                BrowserInfo b = new BrowserInfo();
                b.Name = selected_browser;
                b.version = rnd.Next(1, 99).ToString() + "." + rnd.Next(0, 99).ToString() + "." + rnd.Next(800, 9999).ToString() + "."
                    + rnd.Next(1, 123).ToString();
                b.Path = "C:\\Program Files\\" + selected_browser + "\\" + selected_browser.ToLower() + ".exe";
                browsers.Add(b);
            }

            return browsers;
        }

        public static List<string> CreateFakePrograms()
        {
            Logger.Log("Creating Fake Programs");
            List<string> applications = new List<string>();
            for (int i = 0; i<=rnd.Next(20,60); i++)
            {
                applications.Add(possible_applications[rnd.Next(0, possible_applications.Length - 1)] + " [" +
                    rnd.Next(1, 10).ToString() + "." + rnd.Next(1, 100).ToString() + "." + rnd.Next(1, 10).ToString() + 
                    "." + rnd.Next(1, 1000).ToString() + "]");
            }

            return applications;
        }

        public static List<string> CreateFakeAV()
        {
            Logger.Log("Creating Fake AV");
            List<string> AVs = new List<string>();

            string[] possible_AVs = new string[]
            {
                "Windows Defender",
                "Avira",
                "Bitdefender",
                "Kaspersky",
                "Comodo",
            };

            AVs.Add(possible_AVs[rnd.Next(0, possible_AVs.Length - 1)]);
            return AVs;
        }

        public static List<string> CreateFakeProcesses()
        {
            Logger.Log("Creating Fake Processes");
            List<string> processes = new List<string>();

            for (int i=0; i<=rnd.Next(10,75); i++)
            {
                processes.Add("ID: " + rnd.Next(100, 9999).ToString() + ", Name: " + CreateRandomFileName() + ", " +
                    "Commandline: ");
            }

            return processes;
        }

        public static byte[] CreateRandomBytes()
        {
            Random rnd = new Random();
            byte[] b = new byte[rnd.Next(10,123) * 1024]; 
            rnd.NextBytes(b);
            return b;
        }

        public static string CreateFakeTelegramID()
        {
            Logger.Log("Creating Fake Telegram ID");
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[16];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rnd.Next(chars.Length)];
            }

            return new String(stringChars) + "s";
        }

        public static List<Entity_StolenFile> CreateFakeTelegramData()
        {
            Logger.Log("Creating Fake Telegram Data");
            string profile_id = CreateFakeTelegramID();

            List<Entity_StolenFile> telegram_files = new List<Entity_StolenFile>();

            Entity_StolenFile s1 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = CreateFakeTelegramID(),
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s1);

            Entity_StolenFile s2 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = CreateFakeTelegramID(),
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s2);

            Entity_StolenFile s3 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "countries",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s3);

            Entity_StolenFile s4 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = profile_id,
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s4);

            Entity_StolenFile s5 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "key_datas",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s5);

            Entity_StolenFile s6 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "prefix",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s6);

            Entity_StolenFile s7 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "settingss",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s7);

            Entity_StolenFile s8 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "shortcuts-custom.json",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s8);

            Entity_StolenFile s9 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "shortcuts-default.json",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s9);

            Entity_StolenFile s10 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "usertag",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s10);

            Entity_StolenFile s11 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "working",
                CompletePath = null,
                Path = "Profile_1",
                Id5 = "1"
            };
            telegram_files.Add(s11);

            Entity_StolenFile s12 = new Entity_StolenFile
            {
                Content = CreateRandomBytes(),
                FileName = "configs",
                CompletePath = null,
                Path = "Profile_1\\\\" + profile_id,
                Id5 = "1"
            };
            telegram_files.Add(s8);

            return telegram_files;
        }
   
        public static List<Entity_Browser> CreateFakeBrowserData(List<string> desired_browsers)
        {
            Logger.Log("Creating Fake Browser Data (Logins, Cookies etc.)");
            string[] possible_browsers = {"7Star",
                "360Browser",
                "Amigo",
                "Brave",
                "Bromium",
                "CentBrowser",
                "Chedot",
                "Chromium",
                "CocCoc",
                "ComodoDragon",
                "Cyberfox",
                "ElementsBrowser",
                "Epic",
                "FileZilla",
                "GoBrowser",
                "GoogleChrome",
                "GoogleChrome64",
                "IceDragon",
                "InternetExplorer",
                "InternetMailRu",
                "Kometa",
                "MicrosoftEdge",
                "MozillaFireFox",
                "Mustang",
                "Nichrome",
                "Opera",
                "Orbitum",
                "Outlook",
                "PaleMoon",
                "Pidgin",
                "Psi",
                "PsiPlus",
                "QIPSurf",
                "RockMelt",
                "SaferBrowser",
                "Sputnik",
                "Suhba",
                "Superbird",
                "ThunderBird",
                "TorBro",
                "Torch",
                "Uran",
                "Vivaldi",
                "Waterfox",
                "WinSCP",
                "YandexBrowser" };

            // We will only return a few of the desired browsers to not look too suspicious
            List<string> processed_browsers = new List<string>();
            List<Entity_Browser> browsers = new List<Entity_Browser>();

            foreach (string s in desired_browsers)
            {
                if (rnd.Next(0,4) == 1)
                {
                    processed_browsers.Add(s);
                }
            }

            foreach (string s in processed_browsers)
            {
                string[] possible_sites = new string[] { "/logon", "/login", "/home", "/" };
                Entity_Browser entity = new Entity_Browser();
                entity.NameOfBrowser = possible_browsers[rnd.Next(0, possible_browsers.Length - 1)];
                entity.ProfileOfBrowser = "Default";

                // Login Data
                List<Entity_LoginData> logindata = new List<Entity_LoginData>();
                Logger.Log("Creating Fake Login data");
                for (int i = 0; i <= rnd.Next(15, 45); i++)
                {
                    Entity_LoginData l = new Entity_LoginData
                    {
                        URL = "https://" + possible_domains[rnd.Next(0, possible_domains.Length - 1)] +
                        possible_sites[rnd.Next(0, possible_sites.Length - 1)],
                        Username = CreateFakeUsername() + "@" + possible_mail_domains[rnd.Next(0, possible_mail_domains.Length - 1)],
                        Password = CreateRandomFileName().Replace(".exe", String.Empty)
                    };
                    logindata.Add(l);
                }
                entity.LoginData = logindata;

                // Cookies
                Logger.Log("Creating Fake Cookies");
                List<Entity_Cookie> cookies = new List<Entity_Cookie>();

                for (int i = 0; i <= rnd.Next(30, 50); i++)
                {
                    string cookie_domain = possible_mail_domains[rnd.Next(0, possible_mail_domains.Length - 1)];
                    Entity_Cookie c = new Entity_Cookie
                    {
                        host_key = cookie_domain,
                        also_host_key = true,
                        path = "/",
                        is_secure = true,
                        expires_utc = Convert.ToInt64(DateTime.UtcNow.AddDays(rnd.Next(5, 30)).Subtract(new DateTime(1970, 1, 1)).TotalSeconds),
                        name = CreateRandomFileName().Replace(".exe", String.Empty),
                        encrypted_value = CreateRandomFileName().Replace(".exe", String.Empty)
                    };
                    cookies.Add(c);
                }
                entity.Cookies = cookies;

                // Auto Fills
                Logger.Log("Creating Fake AutoFills");
                List<Entity_AutoFill> autofills = new List<Entity_AutoFill>();
                for (int i = 0; i <= rnd.Next(15, 45); i++)
                {
                    Entity_AutoFill a = new Entity_AutoFill
                    {
                        Name = CreateRandomFileName().Replace(".exe", String.Empty),
                        Value = CreateRandomFileName().Replace(".exe", String.Empty),
                    };
                    autofills.Add(a);
                }
                entity.AutoFill = autofills;

                // CC
                Logger.Log("Creating Fake Credit Cards");
                List<Entity_CreditCard> ccs = new List<Entity_CreditCard>();
                for (int i = 0; i <= rnd.Next(0, 2); i++)
                {
                    string cn = "";
                    switch (rnd.Next(0,2))
                    {
                        case 0: cn = RandomCreditCardNumberGenerator.GenerateMasterCardNumber();
                            break;
                        case 1: cn = RandomCreditCardNumberGenerator.GenerateVISACardNumber();
                            break;
                        case 2: cn = RandomCreditCardNumberGenerator.GenerateAMEXCardNumber();
                            break;
                    }
                    Entity_CreditCard c = new Entity_CreditCard
                    {
                        NameOnCard = first_names[rnd.Next(0,first_names.Length - 1)] + " " + last_names[rnd.Next(0, last_names.Length - 1)],
                        Expiration_Month = rnd.Next(1,12),
                        Expiration_Year = rnd.Next(2023,2028),
                        CardNumber = cn,
                    };
                    ccs.Add(c);                    
                }
                entity.CreditCard = ccs;

                browsers.Add(entity);
            }

            return browsers;
        }

        public static List<Entity_StolenFile> CollectStolenFiles(List<string> patterns)
        {
            Logger.Log("Creating Fake Stolen Files");
            string[] random_extensions = new string[] { ".txt", ".doc", ".zip", ".docx", ".xls", ".xlsx" };
            List<Entity_StolenFile> list = new List<Entity_StolenFile>();
            foreach (string text in patterns)
            {
                string[] array = text.Split(new string[]
                    {
                        new string(new char[]
                        {
                            '|'
                        })
                    }, StringSplitOptions.RemoveEmptyEntries);
                if (array != null && array.Length > 2)
                {
                    string text2 = Environment.ExpandEnvironmentVariables(array[0]).Replace(Environment.UserName, CreateFakeUsername());
                    string[] searchPatterns = array[1].Split(new string[]
                    {
                            new string(new char[]
                            {
                                ','
                            })
                    }, StringSplitOptions.RemoveEmptyEntries);
                    string value = array[2];

                    for (int i =0; i<= rnd.Next(1,5); i++)
                    {
                        string filename = searchPatterns[rnd.Next(0, searchPatterns.Length - 1)].Replace("*", CreateRandomFileName().Replace(".exe", ""));
                        string extension = random_extensions[rnd.Next(0, random_extensions.Length - 1)];
                        Entity_StolenFile s = new Entity_StolenFile
                        {
                            Content = CreateRandomBytes(),
                            FileName = filename + extension,
                            CompletePath = text2 + "\\" + filename + extension,
                            Path = text2
                        };
                        list.Add(s);
                    }                    
                }
            }

            return list;
        }

        public static List<Entity_LoginData> CollectFilezillaCredentials()
        {
            Logger.Log("Creating Fake Filezilla Credentials");
            List<Entity_LoginData> list = new List<Entity_LoginData>();

            for (int i = 0; i<= rnd.Next(1,10); i++)
            {
                Entity_LoginData e = new Entity_LoginData { Password = CreateRandomFileName().Replace(".exe", ""),
                Username = CreateRandomFileName().Replace(".exe", ""),
                URL = possible_mail_domains[rnd.Next(0, possible_mail_domains.Length -1)] + ":21"
                };
                list.Add(e);
            }

            return list;
        }
    
        public static List<Entity_StolenFile> CollectWallets()
        {
            Logger.Log("Creating Fake Wallets");

            List<Entity_StolenFile> list = new List<Entity_StolenFile>();

            string path = "C:\\Users\\" + CreateFakeUsername() + "\\Desktop";
            Entity_StolenFile s = new Entity_StolenFile { 
                CompletePath =  path + "\\wallet_backup.zip",
                FileName = "wallet_backup.zip",
                Path = path,
                //Content = File.ReadAllBytes("static\\zipbomb_template.zip")
                Content = CreateRandomBytes()
                };
            list.Add(s);
            return list;
        }

        public static List<Entity_StolenFile> CollectDiscordToken()
        {
            Logger.Log("Creating Fake Discord Token");
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[61];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[rnd.Next(chars.Length)];
            }

            string token = new String(stringChars);

            List<Entity_StolenFile> files = new List<Entity_StolenFile>();
            files.Add(new Entity_StolenFile { FileName = "Tokens.txt", Content = Encoding.ASCII.GetBytes(token) });

            return files;
        }

        public static List<Entity_LoginData> CollectNordVPN()
        {
            Logger.Log("Creating Fake NordVPN");
            List<Entity_LoginData> list = new List<Entity_LoginData>();
            list.Add(new Entity_LoginData { 
                Username = CreateFakeUsername() + "@" + possible_mail_domains[rnd.Next(0, possible_mail_domains.Length -1)],
                Password = CreateRandomFileName().Replace(".exe", String.Empty)});
            return list;
        }

        public static List<Entity_StolenFile> CollectOpenVPN()
        {
            Logger.Log("Creating Fake OpenVPN");
            string selected_domain = possible_mail_domains[rnd.Next(0, possible_mail_domains.Length - 1)];
            string template = File.ReadAllText("static\\sample.ovpn").Replace("example.com", selected_domain);

            List<Entity_StolenFile> files = new List<Entity_StolenFile>();
            files.Add(new Entity_StolenFile { FileName = selected_domain + ".ovpn", Content = Encoding.ASCII.GetBytes(template) });

            return files;
        }

        public static string CollectRandomIP()
        {
            var random = new Random();
            return $"{random.Next(1, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}.{random.Next(0, 255)}";
        }
    }
}

