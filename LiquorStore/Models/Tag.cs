using LiquorStore.Models.Base;

namespace LiquorStore.Models
{
    public class Tag: BaseEntity
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
