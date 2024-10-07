using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app.DTO
{
    internal class DTO_LoaiKhuyenMai
    {
        public class LoaiKhuyenMai
        {
            public ObjectId _id { get; set; }
            public string MaLoaiKM { get; set; }
            public string TenLoaiKM { get; set; }
        }
     }
}
