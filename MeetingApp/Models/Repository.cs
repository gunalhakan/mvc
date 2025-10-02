namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id = 1, Name = "Aysel Gürel", Email = "aysel@aysel.co", Phone = "5429854", WillAttend = false });
            _users.Add(new UserInfo() { Id = 2, Name = "Perran Kutman", Email = "perran@kutman.co", Phone = "98649854", WillAttend = true });
            _users.Add(new UserInfo() { Id = 3, Name = "Şevket Altuğ", Email = "sevket@altug.co", Phone = "12435365", WillAttend = true });
            _users.Add(new UserInfo() { Id = 4, Name = "Ferhan Şensoy", Email = "ferhan@sensoy.co", Phone = "965217530", WillAttend = false });
        }

        public static List<UserInfo> Users
        {
            get { return _users; }
        }


        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}