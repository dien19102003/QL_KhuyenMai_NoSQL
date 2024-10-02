using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace promotion_management_app.DTO
{
    public class DTO_LoaiSanPham
    {
        public class LoaiSanPham
        {
            public ObjectId _id { get; set; }
            public string MaLoaiSP { get; set; }
            public string TenLoaiSP { get; set; }
        }
    }
}