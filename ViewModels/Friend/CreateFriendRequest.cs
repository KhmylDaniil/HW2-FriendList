using System.ComponentModel.DataAnnotations;

namespace HW2.ViewModels.Friend
{
    public class CreateFriendRequest
    {
        [Required]
        public string FriendName { get; set; }

        [Required]
        public string Place { get; set; }
    }
}
