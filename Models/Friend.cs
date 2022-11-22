namespace HW2.Models
{
    public class Friend
    {
        public int FriendId { get; set; }

        public string FriendName { get; set; }

        public string Place { get; set; }

        public Friend()
        {
        }
        
        public Friend(string name, string place)
        {
            FriendId = FriendList.Count;
            FriendName = name;
            Place = place;
        }
    }
}
