using LiquorStore.Models.Base;

namespace LiquorStore.Models
{
    public class Image: BaseEntity
    {
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public bool IsMain { get; set; }

    }
}
