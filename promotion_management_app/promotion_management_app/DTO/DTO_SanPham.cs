using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace promotion_management_app.DTO
{
    public class DTO_SanPham
    {     
        public class SanPham
        {
            public ObjectId _id { get; set; }
            [BsonElement("MaSP")]
            public string MaSP { get; set; }
            [BsonElement("TenSP")]
            public string TenSP { get; set; }
            [BsonIgnoreIfNull]
            public string HinhAnh { get; set; }
            [BsonIgnoreIfNull]
            public string LoaiSP { get; set; }
            [BsonElement("GiaBan")]
            public int GiaBan { get; set; }
            [BsonIgnoreIfNull]
            public int? SoLuong { get; set; }
        }
    }
}
