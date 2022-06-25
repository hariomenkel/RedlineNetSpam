using System;
using System.Runtime.InteropServices;

// Token: 0x0200004C RID: 76
public struct BCRYPT_OAEP_PADDING_INFO
{
	// Token: 0x06000176 RID: 374 RVA: 0x000035D8 File Offset: 0x000017D8
	public BCRYPT_OAEP_PADDING_INFO(string alg)
	{
		this.pszAlgId = alg;
		this.pbLabel = IntPtr.Zero;
		this.cbLabel = 0;
	}

	// Token: 0x0400006F RID: 111
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pszAlgId;

	// Token: 0x04000070 RID: 112
	public IntPtr pbLabel;

	// Token: 0x04000071 RID: 113
	public int cbLabel;
}
