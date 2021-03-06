﻿
namespace CICP.MobileUser.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MobileUser.RongTuo")]
    [BasedOnRow(typeof(Entities.RongTuoRow))]
    public class RongTuoColumns
    {
        [EditLink, AlignRight]
        public String Version { get; set; }
        public Int32 UserId { get; set; }
        public String Username { get; set; }
        public String Idnumber { get; set; }
        public String RespCode { get; set; }
        public String RespDesc { get; set; }
        public String Msg { get; set; }
        public String Success { get; set; }
    }
}