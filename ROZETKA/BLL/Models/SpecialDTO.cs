﻿using ROZETKA.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace BLL.Models
{

    public class SpecialDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public BitmapImage ImageF { get; set; }
        public BitmapImage ImageS { get; set; }
        public BitmapImage ImageT { get; set; }
    }
}
