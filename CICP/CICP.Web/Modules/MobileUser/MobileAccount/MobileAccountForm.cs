
namespace CICP.MobileUser.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MobileUser.MobileAccount")]
    [BasedOnRow(typeof(Entities.MobileAccountRow))]
    public class MobileAccountForm
    {
        public String Name { get; set; }
        public String Tel { get; set; }
        public String Orderno { get; set; }
    }
}