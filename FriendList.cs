using HW2.Models;

namespace HW2
{
    public static class FriendList
    {
        private static int _count;
        
        public static List<Friend> Friends = new List<Friend>
        {
            new Friend("Mike", "London"),
            new Friend("Chao", "Beijing")
        };

        public static int Count { get { return ++_count; } }
    }
}
