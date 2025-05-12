using System.Collections.Generic;

namespace ProductList.Models
    {
    public class ProductViewModel
        {
        public int SelectedCategoryId { get; set; }
        public int SelectedProductId { get; set; }
        public int SelectedSupplierId { get; set; } //created new one for supplier dropdown
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; } //created new one for supplier dropdown
    }
    }