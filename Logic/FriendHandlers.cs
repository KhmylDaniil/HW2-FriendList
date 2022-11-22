using HW2.Models;

namespace HW2.Logic
{
    public static class FriendHandlers
    {
        internal static Friend CreateFriend(IFormCollection request)
        {
            CheckRequest(request, out string name, out string place);

            return new(name, place);
        }

        internal static void EditFriend(int id, IFormCollection request)
        {
            CheckRequest(request, out string name, out string place);

            Friend friend = FriendList.Friends.FirstOrDefault(x => x.FriendId == id)
                ?? throw new ArgumentException("no such friend");

            friend.FriendName = name;
            friend.Place = place;
        }

        internal static void DeleteFriend(int id)
        {
            Friend friend = FriendList.Friends.FirstOrDefault(x => x.FriendId == id)
                ?? throw new ArgumentException("no such friend");

            FriendList.Friends.Remove(friend);
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
