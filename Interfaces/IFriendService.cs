using HW2.Models;

namespace HW2.Interfaces
{
    public interface IFriendService
    {
        public List<Friend> GetFriends();

        public Friend Details(int id);

        public void CreateFriend(IFormCollection request);

        public void EditFriend(int id, IFormCollection request);

        public void DeleteFriend(int id);
    }
}
