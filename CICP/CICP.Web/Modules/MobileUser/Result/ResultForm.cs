
namespace CICP.MobileUser.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("MobileUser.Result")]
    [BasedOnRow(typeof(Entities.ResultRow))]
    public class ResultForm
    {
        public Int32 UserId { get; set; }
        public String Username { get; set; }
        public String Idnumber { get; set; }
        public String Data { get; set; }
        public String Msg { get; set; }
        public String Success { get; set; }
    }
}