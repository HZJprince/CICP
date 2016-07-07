
namespace CICP.MobileUser.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MobileUser.MobileUser")]
    [BasedOnRow(typeof(Entities.MobileUserRow))]
    public class MobileUserColumns
    {
        [EditLink, Width(150)]
        public String Username { get; set; }
        [Width(600)]
        public String Ipaddress { get; set; }
    }
}