using HW2.Interfaces;
using HW2.Models;

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

        public void CreateFriend(IFormCollection request)
        {
            CheckRequest(request, out string name, out string place);

            _context.Friends.Add(new Friend() { FriendName = name, Place = place});

            _context.SaveChanges();
        }

        public void EditFriend(int id, IFormCollection request)
        {
            CheckRequest(request, out string name, out string place);

            Friend friend = _context.Friends.FirstOrDefault(x => x.FriendId == id)
                ?? throw new ArgumentException("no such friend");

            friend.FriendName = name;
            friend.Place = place;

            _context.SaveChanges();
        }

        public void DeleteFriend(int id)
        {
            Friend friend = _context.Friends.FirstOrDefault(x => x.FriendId == id)
                ?? throw new ArgumentException("no such friend");

            _context.Friends.Remove(friend);
            _context.SaveChanges();
        }

        private static void CheckRequest(IFormCollection request, out string name, out string place)
        {
            if (request is null) throw new ArgumentNullException(nameof(request));

            name = request["FriendName"];
            place = request["Place"];
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(place)) throw new ArgumentException("invalid data");
        }
    }
}
