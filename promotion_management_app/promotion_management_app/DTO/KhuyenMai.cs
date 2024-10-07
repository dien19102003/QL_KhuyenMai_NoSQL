using System;
using System.Collections.Generic;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.DTO
{
    public class KhuyenMai
    {
        public string MaKM {  get; set; }
        public string TenKM {  get; set; }
        public string MaLoaiKM {  get; set; }
        public DateTime NgayBatDau {  get; set; }
        public DateTime NgayKetThuc { get; set; }
        public virtual  DieuKien  DieuKien {  get; set; }
        //Quà tặng
        public virtual ICollection<SanPham> QuaTang { get; set; }
        //Voucher
        public virtual Voucher  Voucher { get; set; }
    }
}
