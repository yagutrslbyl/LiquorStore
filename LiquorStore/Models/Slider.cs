using LiquorStore.Models.Base;

namespace LiquorStore.Models
{
    public class Slider : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
