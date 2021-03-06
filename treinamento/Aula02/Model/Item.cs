﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Model
{
    public class Item
    {
        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public override string ToString()
        {
            //var culture = CultureInfo.GetCultureInfo("jp-JP");

            return $"{Data.ToString("dd-MM-yyyy HH:mm:ss:ff")} - {Valor.ToString("C")}";
        }
    }
}
