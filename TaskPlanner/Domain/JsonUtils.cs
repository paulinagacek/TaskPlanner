using System.IO;
using Newtonsoft.Json;

namespace TaskPlanner.Utils
{
    public static class JsonExtensions
    {
        public static T ToObject<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }

        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static string ReadFileToString(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
