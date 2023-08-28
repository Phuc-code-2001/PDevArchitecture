namespace PDevArchitecture.Extensions
{
    public static class StringExtentionMethods
    {
        public static int CompareIgnoreCase(this string s1, string s2)
        {
            return s1.ToLower().CompareTo(s2.ToLower());
        }

        public static bool HasContainsIgnoreCase(this string s1, string s2)
        {
            return s1.ToLower().Contains(s2.ToLower());
        }

        public static string EmptyIfNull(this string? s)
        {
            return s ?? string.Empty;
        }

        public static bool IsEmpty(this string? s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }
    }
}
