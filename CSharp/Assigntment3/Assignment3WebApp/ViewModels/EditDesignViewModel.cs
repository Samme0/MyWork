namespace Assignment3WebApp.ViewModels
{
    public class EditDesignViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        //public string Country { get; set; }
        public List<string> Countries { get; set; }
        public List<string> Gender { get; set; } = new List<string>() { "M", "F" };
        public List<Sports> SportsList { get; set; }
        public List<Friends> FriendList { get; set; }   
    }

    public class Sports
    {
        public string Football { get; set; }
        public string BasketBall { get; set; }
        public string Baseball { get; set; }
        public string Soccer { get; set; }
    }

    public class Friends
    {
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

}
