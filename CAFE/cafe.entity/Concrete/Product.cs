namespace cafe.entity.Concrete
{
    public class Product
    {
        public int ID { get; set; }
        public string BARCODE { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public decimal SALEPRICE { get; set; }
        public decimal PURCHASEPRICE { get; set; }
        public decimal AMOUNT { get; set; }
        public Unit UNIT { get; set; }
        public Category CATEGORY { get; set; }
        public Supplier SUPPLIER { get; set; }
        public string IMAGE { get; set; }
        public bool ISACTIVE { get; set; }
    }
}