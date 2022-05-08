namespace Infrastructure
{
	public static class TempDataHelper
	{
		static TempDataHelper()
		{
		}

		public static void Put<T>
			(this Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData, string key, T value) where T : class
		{
			tempData[key] =
				System.Text.Json.JsonSerializer.Serialize(value);
		}

		public static T? Get<T>
			(this Microsoft.AspNetCore.Mvc.ViewFeatures.ITempDataDictionary tempData, string key) where T : class
		{
			tempData.TryGetValue(key, out object? obj);

			if (obj == null)
			{
				return null;
			}

			var result =
				System.Text.Json.JsonSerializer.Deserialize<T>((string)obj);

			return result;
		}
	}
}
