using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using promotion_management_app.DTO;

namespace promotion_management_app.DAO
{
    public class DAO_LoaiSanPham
    {
        // Hàm kết nối đến MongoDB
        private IMongoCollection<DTO_LoaiSanPham.LoaiSanPham> GetCollectionLoaiSP()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<DTO_LoaiSanPham.LoaiSanPham>("LoaiSP"); 
        }

        internal List<KeyValuePair<string, string>> GetLoaiSanPham()
        {
            var collection = GetCollectionLoaiSP();
        
            var loaiSanPhamList = collection
                .Find(Builders<DTO_LoaiSanPham.LoaiSanPham>.Filter.Empty)
                .ToList() 
                .Select(x => new KeyValuePair<string, string>(x.MaLoaiSP, x.TenLoaiSP)) 
                .ToList();               
            return loaiSanPhamList;
        }

    }
}
