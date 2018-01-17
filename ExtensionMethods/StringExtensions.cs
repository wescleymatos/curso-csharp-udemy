using System;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string FirstToUpper(this String str)
        {
            var p1 = str.Substring(0, 1);
            p1.ToUpper();

            var p2 = str.Substring(1);

            return p1 + p2;
        }
    }
}