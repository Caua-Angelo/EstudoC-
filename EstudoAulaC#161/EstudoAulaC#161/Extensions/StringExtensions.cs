﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAulaC_161.Extensions
{
    internal static class StringExtensions
    {
        public static string Cut(this string thisObj,int count)
        {
            if (thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0,count) + "...";
            }
        }


    }
}
