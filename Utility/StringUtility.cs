namespace OOP_FileWriting_Example.Utility {
    static class StringUtility {

        internal static string ReplaceTRChars(string text) {
            return text.Replace('ş', 's')
                .Replace('İ', 'I')
                .Replace('ı', 'i')
                .Replace('ğ', 'g');
        }
    }
}
