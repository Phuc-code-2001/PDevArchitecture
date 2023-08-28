using System.Text.Json;

namespace PDevArchitecture.Extensions
{
    public static class FileExtensionMethods
    {
        public static async Task<byte[]?> GetBytesAsync(this IFormFile? file)
        {
            if (file == null) return null;
            if (file.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);
                    return ms.ToArray();
                }
            }

            return Array.Empty<byte>();
        }

        public static string? Serialize(this byte[]? bytes)
        {
            if (bytes == null) return null;
            return string.Join(",", bytes);
        }

        public static byte[]? Deserialize(this string? bytes)
        {
            if (bytes == null) return null;
            try
            {
                return bytes.Split(",").Select(x => byte.Parse(x)).ToArray();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string? ConvertToBase64String(this byte[]? bytes)
        {
            if (bytes == null) return null;
            return Convert.ToBase64String(bytes);
        }
    }
}
