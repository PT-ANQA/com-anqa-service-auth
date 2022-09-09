﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Anqa.Service.Auth.Lib.Utilities.BaseClass
{
    public class BasicViewModel
    {
        public string UId { get; set; }
        public int Id { get; set; }
        public bool _IsDeleted { get; set; }
        public bool Active { get; set; }
        public DateTime _CreatedUtc { get; set; }
        public string _CreatedBy { get; set; }
        public string _CreatedAgent { get; set; }
        public DateTime _LastModifiedUtc { get; set; }
        public string _LastModifiedBy { get; set; }
        public string _LastModifiedAgent { get; set; }
    }
}
