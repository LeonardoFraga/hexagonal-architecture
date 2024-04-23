namespace Domain.Entities
{
    public class User
    {
        public User(int Id, string? Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        public int Id { get; private set; }

        public string? Name { get; private set; }
    }
}