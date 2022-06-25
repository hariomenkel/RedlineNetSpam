using System;
using System.Runtime.InteropServices;

// Token: 0x0200004D RID: 77
public struct BCRYPT_PSS_PADDING_INFO
{
	// Token: 0x06000177 RID: 375 RVA: 0x000035F3 File Offset: 0x000017F3
	public BCRYPT_PSS_PADDING_INFO(string pszAlgId, int cbSalt)
	{
		this.pszAlgId = pszAlgId;
		this.cbSalt = cbSalt;
	}

	// Token: 0x04000072 RID: 114
	[MarshalAs(UnmanagedType.LPWStr)]
	public string pszAlgId;

	// Token: 0x04000073 RID: 115
	public int cbSalt;
}
