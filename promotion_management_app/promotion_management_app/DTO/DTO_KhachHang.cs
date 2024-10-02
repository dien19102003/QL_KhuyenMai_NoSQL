using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app.DTO
{
    internal class DTO_KhachHang
    {
        public class KhachHang
        {
            public ObjectId _id { get; set; }
            public string MaKH { get; set; }
            public string TenKH { get; set; }
            public string SDT { get; set; }
            public string DiaChi { get; set; }

        }
    }
}
