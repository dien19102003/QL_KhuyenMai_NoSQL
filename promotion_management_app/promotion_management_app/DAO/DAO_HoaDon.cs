using MongoDB.Driver;
using promotion_management_app.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promotion_management_app.DAO
{
    public class DAO_HoaDon
    {
        private readonly IMongoCollection<HoaDon> _hoaDonCollection;
        public DAO_HoaDon()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            _hoaDonCollection = database.GetCollection<HoaDon>("HoaDon"); // Tên collection
        }
        public IMongoCollection<HoaDon> GetCollectionHoaDon()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<HoaDon>("HoaDon");
        }
        public List<HoaDon> GetAllHoaDon()
        {
            var list= GetCollectionHoaDon();

            List<HoaDon> hoaDons = list.Find(_ => true).ToList();
            return hoaDons;
        }
        public async Task<bool> insertHoaDon(HoaDon hoaDon)
        {
            try
            {
                await _hoaDonCollection.InsertOneAsync(hoaDon);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while adding customer: {ex.Message}");
                return false;
            }
        }
    }
}
