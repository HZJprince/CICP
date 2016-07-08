
namespace CICP.MobileUser.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MobileUser.MobileAccount")]
    [BasedOnRow(typeof(Entities.MobileAccountRow))]
    public class MobileAccountColumns
    {
        [EditLink]
        public String Name { get; set; }
        public String Tel { get; set; }
        public String Idnumber { get; set; }
        public String Orderno { get; set; }
    }
}