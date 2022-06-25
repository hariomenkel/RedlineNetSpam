using System;
using System.Runtime.InteropServices;

// Token: 0x02000041 RID: 65
public static class MemoryImport
{
	// Token: 0x0600012C RID: 300
	[DllImport("kernel32.dll", EntryPoint = "LoadLibraryA", SetLastError = true)]
	public static extern IntPtr LoadLibrary(string fileName);

	// Token: 0x0600012D RID: 301
	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	// Token: 0x0600012E RID: 302 RVA: 0x0000340E File Offset: 0x0000160E
	public static T Func<T>(IntPtr arg1) where T : class
	{
		return Marshal.GetDelegateForFunctionPointer(arg1, typeof(T)) as T;
	}
}
