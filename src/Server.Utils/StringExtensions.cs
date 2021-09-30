﻿using System;
using System.Text;

namespace Server.Utils
{
    public static class StringExtensions
    {
        public static string FromBase64(this string base64String)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(base64String));
        }
    }
}