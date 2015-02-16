using System.Text;

namespace StringBuilderExtensions
{
    public static class TextRemove
    {
        public static StringBuilder RemoveText(this StringBuilder finalString, string text)
        {
            for (int character = 0; character <= finalString.Length - text.Length; character++)
            {
                string str = finalString.Substring(character, text.Length);

                if (finalString.Substring(character, text.Length) == text)
                {
                    finalString.Remove(character, text.Length);
                }
            }

            return finalString;
        }
    }
}
