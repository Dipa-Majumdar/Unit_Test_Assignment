using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryClass
{
    public class Product
    {
        public string name;
        public double price;
        public int quantity;
        public string type;

        public Product(string name, double price,int quantity, string type)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.type = type;
        }
    }
    public class ProductRepository
    {
        public List<Product> product_list_of_class = new List<Product>();
        
        public ProductRepository(List<Product> product_list)
        {
            this.product_list_of_class = product_list;
        }
       
        // Method 1: Create a method to return total number of products in list.
        public int TotalNumberOfProductsInList(List<Product> new_list)
        {
            int result;
            result = new_list.Count;
            return result;
        }
        //Method 2: Create a method to add new product in list and return the list with added product.
        public List<Product> AddNewProduct_ReturnList(string name, double price, int quantity, string type)
        {
            List<Product> new_product_list = new List<Product>();
            new_product_list = product_list_of_class;
            
            new_product_list.Add(new Product(name, price, quantity, type));
            
            return new_product_list;
        }
        //Method 3: Create a method to find products by its type and return found products list.
        public List<Product> FindProductByType_returnFoundProductList(string type)
        {
            List<Product> found_product_list = new List<Product>();
            foreach (Product prod in product_list_of_class)
            {
                bool check = string.Equals(prod.type, type, StringComparison.OrdinalIgnoreCase);
                if (check)
                {
                    found_product_list.Add(prod);
                }
            }
            return found_product_list;
        }
        //Method 4:Create a method to delete product by its name and return list with deleted product.
        public List<Product> FindProductByName_delete_returnNewProductList(string name)
        {
            List<Product> pr_list = new List<Product>();
            for (int i=0;i < product_list_of_class.Count;i++)
            {
                if (product_list_of_class[i].name!=name)
                {
                    pr_list.Add(product_list_of_class[i]);
                }
            }
            return pr_list;
        }
        // Method 5: Create a method to buy products by passing its name and quantity
        //and return total price of bought products.
        public double BuyProdByNameQuantity_returnTotalPrice(string name,double quantity)
        {
            double total_price=0.0;
            foreach (Product prod in product_list_of_class)
            {
                bool check = string.Equals(prod.name, name, StringComparison.CurrentCultureIgnoreCase);
                if(check)
                {
                    total_price = total_price + ( quantity * prod.price);
                }
            }
            return total_price;
        }
        
       

    }
}
