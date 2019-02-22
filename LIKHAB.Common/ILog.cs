using System;

namespace LIKHAB.Common
{
    public interface ILog
    {
        string TableName { get; set; }
        string LogString { get; set; }
        Nullable<System.DateTime> TimeStamp { get; set; }
    }
}