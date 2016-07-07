
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
        public String Username { get; set; }
        [PasswordEditor, Required(true)]
        public String Password { get; set; }
        [PasswordEditor, OneWay, Required(true)]
        public String PasswordConfirm { get; set; }
        public String Ipaddress { get; set; }
    }
}