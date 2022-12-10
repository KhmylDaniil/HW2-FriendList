using HW2.Interfaces;
using HW2.Models;
using HW2.ViewModels.Friend;

namespace HW2.Logic
{
    public class FriendService : IFriendService
    {
        private readonly IApplicationContext _context;

        public FriendService(IApplicationContext applicationContext)
        {
            _context = applicationContext;
        }
        
        public List<Friend> GetFriends()
        {
            return _context.Friends.ToList();
        }

        public Friend Details(int id)
        {
            return _context.Friends.FirstOrDefault(x => x.FriendId == id) ?? throw new ArgumentException("no such id");
        }

        public void CreateFriend(CreateFriendRequest request)
        {
            _context.Friends.Add(new Friend() { FriendName = request.FriendName, Place = request.Place});

            _context.SaveChanges();
        }

        public void EditFriend(ChangeFriendRequest request)
        {
            Friend friend = _context.Friends.FirstOrDefault(x => x.FriendId == request.Id)
                ?? throw new ArgumentException("no such friend");

            friend.FriendName = request.FriendName;
            friend.Place = request.Place;

            _context.SaveChanges();
        }

        public void DeleteFriend(int id)
        {
            Friend friend = _context.Friends.FirstOrDefault(x => x.FriendId == id)
                ?? throw new ArgumentException("no such friend");

            _context.Friends.Remove(friend);
            _context.SaveChanges();
        }
    }
}
