using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app.DTO
{
    internal class DTO_NhanVien
    {
        public class NhanVien
        {
            public ObjectId _id { get; set; }
            public string MaNV { get; set; }
            public string TenNV { get; set; }
            public string SDT { get; set; }
            public string DiaChi { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
