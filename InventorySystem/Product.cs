namespace InventorySystem
{
    public class Product
    {
        private string name = string.Empty;
        private int quntityInStock = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Quantity
        {
            get { return quntityInStock; }
            set { quntityInStock = value; }
        }

        public Product(int quntity):this(quntity,"")
        {
            
        }
        public Product(int quntity,string name)
        {
            Quantity = quntity;
            Name = name;
        }
    }
   
}