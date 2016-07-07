
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
        [EditLink, AlignRight, Width(150)]
        public String Username { get; set; }
        [Width(500)]
        public String Password { get; set; }
    }
}