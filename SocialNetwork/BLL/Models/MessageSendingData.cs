﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Models
{
    public class MessageSendingData
    {
        public int SenderID { get; set; }
        public string Content { get; set; }
        public string RecepientEmail { get; set; }
    }
}
