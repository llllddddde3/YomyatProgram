namespace YomyatProgram.Models.Enums
{
    public enum ReceiptType
    {
        Post,
        Packages,
        Contracts,
        Others
    }
    public class ReceiptTypeArabic
    {
        public readonly static string[] Titles = {
         "منشور",
         "باقة",
         "عقود",
         "غير ذلك"
        };
    }
}
