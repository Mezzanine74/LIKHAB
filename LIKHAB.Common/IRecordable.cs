using System;

namespace LIKHAB.Common
{
    public interface IRecordable
    {
        string Uniqueidentifier { get; set; }
        string WhoCreated { get; set; }
        string WhoUpdated { get; set; }
        string WhoDeleted { get; set; }
        Nullable<System.DateTime> WhenCreated { get; set; }
        Nullable<System.DateTime> WhenUpdated { get; set; }
        Nullable<System.DateTime> WhenDeleted { get; set; }
    }
}