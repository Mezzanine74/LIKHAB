using System;

namespace LIKHAB.BusinessLogic.Helpers
{
    public struct Numeric
    {
        public static bool IsNumeric(System.Object obj)
        {
            if (obj == null || obj is DateTime)
                return false;

            if (obj is Int16 || obj is Int32 || obj is Int64 || obj is Decimal || obj is Single || obj is Double)
                return true;

            try
            {
                if (obj is string)
                    Double.Parse(obj as string);
                else
                    Double.Parse(obj.ToString());
                return true;
            }
            catch { }

            return false;
        }
    }
}