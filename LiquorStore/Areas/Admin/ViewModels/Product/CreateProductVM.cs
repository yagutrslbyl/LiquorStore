namespace LiquorStore.Areas.Admin.ViewModels.Product
{
    public class CreateProductVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<int> TagIds { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
