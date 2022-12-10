using HW2.Models;
using HW2.ViewModels.Friend;

namespace HW2.Interfaces
{
    public interface IFriendService
    {
        public List<Friend> GetFriends();

        public Friend Details(int id);

        public void CreateFriend(CreateFriendRequest request);

        public void EditFriend(ChangeFriendRequest request);

        public void DeleteFriend(int id);
    }
}
