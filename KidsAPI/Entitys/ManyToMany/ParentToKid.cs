namespace KidsAPI.Entitys.ManyToMany
{
    public class ParentToKid
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int ChildId { get; set; }
    }
}
