using LIKHAB.Common;

namespace LIKHAB.DataLayer.Models
{
    using System;

    public partial class Log : IId, ILog
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public string LogString { get; set; }
        public Nullable<System.DateTime> TimeStamp { get; set; }

        public OperationResult Validate()
        {
            throw new NotImplementedException();
        }
    }

}