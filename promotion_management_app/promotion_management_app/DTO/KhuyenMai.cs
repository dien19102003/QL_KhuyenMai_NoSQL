using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public override string ToString()
        {
            var quaTangInfo = QuaTang != null && QuaTang.Any()
                ? string.Join(", ", QuaTang.Select(q => q.TenSP))
                : "Không có quà tặng";

            var voucherInfo = Voucher != null
                ? Voucher.GiftCode
                : "Không có voucher";

            return $"Mã KM: {MaKM}, Tên KM: {TenKM}, Loại KM: {MaLoaiKM}, " +
                   $"Ngày bắt đầu: {NgayBatDau:yyyy/MM/dd}, Ngày kết thúc: {NgayKetThuc:yyyy/MM/dd}, " +
                   $"Giảm giá: {GiamGia}%, Điều kiện: {DieuKien}, " +
                   $"Quà tặng: {quaTangInfo}, Voucher: {voucherInfo}";
        }
    }
}
