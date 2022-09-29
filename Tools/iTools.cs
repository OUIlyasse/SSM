using System;

namespace Tools
{
    public class iTools
    {
        public static string getDate()
        {
            DateTime dt = DateTime.Now;
            return dt.ToString("dd/MM/yyyy");
        }
    }
}