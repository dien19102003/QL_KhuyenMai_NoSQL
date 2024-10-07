using MongoDB.Driver;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app.DAO
{
    public class DAO_LoaiKhuyenMai
    {
        // Hàm kết nối đến MongoDB
        private IMongoCollection<DTO_LoaiKhuyenMai.LoaiKhuyenMai> GetCollectionLoaiSP()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<DTO_LoaiKhuyenMai.LoaiKhuyenMai>("LoaiKM");
        }

        internal List<KeyValuePair<string, string>> GetLoaiKhuyenMai()
        {
            var collection = GetCollectionLoaiSP();

            var loaiKhuyenMaiList = collection
                .Find(Builders<DTO_LoaiKhuyenMai.LoaiKhuyenMai>.Filter.Empty)
                .ToList()
                .Select(x => new KeyValuePair<string, string>(x.MaLoaiKM, x.TenLoaiKM))
                .ToList();
            return loaiKhuyenMaiList;
        }
    }
}
