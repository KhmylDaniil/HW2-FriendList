using HW2.Interfaces;
using HW2.Models;

namespace HW2.Logic
{
    public class StubFriendservice : IFriendService
    {
        public void CreateFriend(IFormCollection request)
        {
            throw new NotImplementedException();
        }

        public void DeleteFriend(int id)
        {
        }

        public Friend Details(int id)
        {
            throw new NotImplementedException();
        }

        public void EditFriend(int id, IFormCollection request)
        {
        }

        public List<Friend> GetFriends()
        {
            return new List<Friend>();
        }
    }
}
