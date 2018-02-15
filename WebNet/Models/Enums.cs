using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebNet.Models
{
    enum TargetType : byte
    {
        Post = 1,
        Conversation = 2
    }

    enum ContentType
    {
        Text = 1,
        URL = 2
    }
}