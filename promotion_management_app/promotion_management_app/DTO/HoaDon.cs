using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace promotion_management_app.DTO
{
    public class HoaDon
    {
        public HoaDon() 
        {
            MaHD =GenerateRandomMaHD();
        }
        public ObjectId _id { get; set; }
        public string MaHD {  get; set; }
        public double TongCong {  get; set; }
        public double TienKhuyenMai { get; set; } = 0;
        public double TongTien {  get; set; }
        public DateTime NgayLap { get; set; }
        public virtual ICollection<SanPhamMua> SanPhams { get; set; }
        [BsonIgnoreIfNull]
        public virtual KhuyenMai KhuyenMai { get; set; }

        private string GenerateRandomMaHD()
        {
            Random random = new Random();
            string randomNumber = random.Next(1000000000, int.MaxValue).ToString("D10");
            return "MAKM" + randomNumber;
        }
    }
}
