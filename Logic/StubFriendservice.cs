using HW2.Interfaces;
using HW2.Models;
using HW2.ViewModels.Friend;

namespace HW2.Logic
{
    public class StubFriendservice : IFriendService
    {
        public void CreateFriend(CreateFriendRequest request)
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

        public void EditFriend(ChangeFriendRequest request)
        {
        }

        public List<Friend> GetFriends()
        {
            return new List<Friend>();
        }
    }
}
