using System;
using System.Web.Script.Serialization;

// Token: 0x02000035 RID: 53
public static class Json
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600010E RID: 270 RVA: 0x00003341 File Offset: 0x00001541
	public static JavaScriptSerializer JSON
	{
		get
		{
			JavaScriptSerializer result;
			if ((result = Json.json) == null)
			{
				JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
				javaScriptSerializer.MaxJsonLength = int.MaxValue;
				javaScriptSerializer.RecursionLimit = int.MaxValue;
				result = javaScriptSerializer;
				Json.json = javaScriptSerializer;
			}
			return result;
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00009944 File Offset: 0x00007B44
	public static T FromJSON<T>(this string @this)
	{
		T result;
		try
		{
			result = Json.JSON.Deserialize<T>(@this.Trim());
		}
		catch (Exception)
		{
			result = default(T);
		}
		return result;
	}

	// Token: 0x06000110 RID: 272 RVA: 0x0000336D File Offset: 0x0000156D
	public static string ToJSON(this object @this)
	{
		return Json.JSON.Serialize(@this);
	}

	// Token: 0x04000030 RID: 48
	private static JavaScriptSerializer json;
}
