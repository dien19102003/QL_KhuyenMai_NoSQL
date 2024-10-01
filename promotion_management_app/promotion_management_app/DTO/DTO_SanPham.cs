using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace promotion_management_app.DTO
{
    internal class DTO_SanPham
    {
        public IMongoCollection<SanPham> GetCollectionSanPham()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<SanPham>("SanPham");
        }
        public class SanPham
        {
            public ObjectId _id { get; set; }
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public string HinhAnh { get; set; } 
            public string LoaiSP { get; set; }
            public decimal GiaBan { get; set; }
            public int SoLuong { get; set; }
        }
    }
}
