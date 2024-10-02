using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using promotion_management_app.DTO;

namespace promotion_management_app.DAO
{
    internal class DAO_NhanVien
    {
        private IMongoCollection<DTO_NhanVien.NhanVien> _nhanVienCollection()
        {
            var client = new MongoClient(ConnectDatabase.connectionString);
            var database = client.GetDatabase(ConnectDatabase.databaseName);
            return database.GetCollection<DTO_NhanVien.NhanVien>("NhanVien"); // Tên collection
        }

        // Kiểm tra tồn tại tài khoản với username và password
        public async Task<bool> CheckUserCredentials(string username, string password)
        {
            var filter = Builders<DTO_NhanVien.NhanVien>.Filter.Eq("Username", username) &
                         Builders<DTO_NhanVien.NhanVien>.Filter.Eq("Password", password);
            var result = await _nhanVienCollection().Find(filter).FirstOrDefaultAsync();
            return result != null; 
        }

        // Lấy thông tin nhân viên dựa trên tên người dùng và mật khẩu
        public async Task<DTO_NhanVien.NhanVien> GetNhanVienByUsernameAndPassword(string username, string password)
        {
            var filter = Builders<DTO_NhanVien.NhanVien>.Filter.Eq("Username", username) &
                         Builders<DTO_NhanVien.NhanVien>.Filter.Eq("Password", password);
            return await _nhanVienCollection().Find(filter).FirstOrDefaultAsync();
        }
    }
}
