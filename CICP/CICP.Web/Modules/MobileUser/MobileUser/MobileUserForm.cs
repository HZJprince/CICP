
namespace CICP.MobileUser.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MobileUser.MobileUser")]
    [BasedOnRow(typeof(Entities.MobileUserRow))]
    public class MobileUserForm
    {
        public String Password { get; set; }
    }
}