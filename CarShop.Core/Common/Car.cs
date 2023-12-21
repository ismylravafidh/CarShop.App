using CarShop.Core.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Core.Common
{
    public class Car:BaseEntity
    {
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
        public int ColorId { get; set; }
        public Color? Color { get; set; }
        public int ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string? Description { get; set; }
    }
}
