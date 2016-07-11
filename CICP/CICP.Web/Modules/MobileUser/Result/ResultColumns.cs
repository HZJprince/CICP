
namespace CICP.MobileUser.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MobileUser.Result")]
    [BasedOnRow(typeof(Entities.ResultRow))]
    public class ResultColumns
    {
        public Int32 UserId { get; set; }
        [EditLink]
        public String Username { get; set; }
        public String Idnumber { get; set; }
        public String Data { get; set; }
        public String Msg { get; set; }
        public String Success { get; set; }
    }
}