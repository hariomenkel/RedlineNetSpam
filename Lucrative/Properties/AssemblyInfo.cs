using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;

[assembly: AssemblyVersion("0.0.0.0")]
[assembly: Obfuscation(Exclude = false, Feature = "packer:compressor")]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]
