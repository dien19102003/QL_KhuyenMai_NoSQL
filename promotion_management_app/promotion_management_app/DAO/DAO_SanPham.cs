using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using static promotion_management_app.DTO.DTO_SanPham;

namespace promotion_management_app.DAO
{
    public class DAO_SanPham
    {
        internal IMongoCollection<SanPham> GetCollectionSanPham()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<SanPham>("SanPham");
        }

        // Phương thức mới để lấy danh sách sản phẩm
        internal List<SanPham> GetListSanPham()
        {
            var collection = GetCollectionSanPham();

            var projection = Builders<SanPham>.Projection
                .Include(x => x.TenSP)
                .Include(x => x.HinhAnh)
                .Include(x => x.GiaBan)
                .Include(x => x.SoLuong)
                .Include(x => x.LoaiSP)
                .Include(x => x.MaSP);

            var productList = collection
                .Find(Builders<SanPham>.Filter.Empty)
                .Project<SanPham>(projection)
                .ToList();

            return productList;
        }

        // Phương thức để lấy sản phẩm theo mã sản phẩm
        public async Task<SanPham> GetSanPhamByMaSP(string maSP)
        {
            var collection = GetCollectionSanPham();

            var filter = Builders<SanPham>.Filter.Eq("MaSP", maSP);
            return await collection.Find(filter).FirstOrDefaultAsync();
        }

        public List<SanPham> TimKiemSanPhamTheoTen(string tenSP)
        {
            var collection = GetCollectionSanPham();
          
            var filter = Builders<SanPham>.Filter.Regex("TenSP", new MongoDB.Bson.BsonRegularExpression(tenSP, "i"));           
            var sanPhamList = collection.Find(filter).ToList();

            return sanPhamList;
        }
    }
}