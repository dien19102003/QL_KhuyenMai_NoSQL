using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.DTO
{
    public class KhuyenMai
    {
        public ObjectId _id {  get; set; }
        public string MaKM {  get; set; }
        public string TenKM {  get; set; }
        public string MaLoaiKM {  get; set; }
        public DateTime NgayBatDau {  get; set; }
        public DateTime NgayKetThuc { get; set; }

        public double GiamGia {  get; set; }
        public  DieuKien  DieuKien {  get; set; }
        //Quà tặng
        [BsonIgnoreIfNull]
        public virtual ICollection<SanPham> QuaTang { get; set; }
        //Voucher
        [BsonIgnoreIfNull]
        public virtual Voucher  Voucher { get; set; }
    }
}
