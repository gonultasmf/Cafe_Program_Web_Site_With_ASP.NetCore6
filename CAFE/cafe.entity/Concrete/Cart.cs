using System.Collections.Generic;

namespace cafe.entity.Concrete
{
    public class Cart
    {
        public int ID { get; set; }
        public Table TABLE { get; set; }
        public virtual ICollection<Product> PRODUCTES { get; set; }
    }
}