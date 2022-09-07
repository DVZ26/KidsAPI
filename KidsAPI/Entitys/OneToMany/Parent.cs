namespace KidsAPI.Entitys.OneToMany
{
    public class Parent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<Kid> Kids { get; set; }
    }
}
