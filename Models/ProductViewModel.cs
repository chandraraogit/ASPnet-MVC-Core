namespace mydemoproj.Models
{
    public class ProductViewModel
    {
        public int ProdID { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProdCode { get; set; }
       // public ProductManufactureDtls prodManDtls { get; set; } = null;
    }

    public class ProductManufactureDtls
    {
        public int ManID { get; set; }
        public string ManName { get; set; }
        public string ManAddress { get; set; }
    }
}
