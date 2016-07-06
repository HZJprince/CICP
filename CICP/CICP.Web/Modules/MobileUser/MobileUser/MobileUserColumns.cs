
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public String Username { get; set; }
        public String Password { get; set; }
    }
}