namespace NossaTrip.model.domain.user
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string md5Password { get; set; }
    }
}
