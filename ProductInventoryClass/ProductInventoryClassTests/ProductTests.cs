using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductInventoryClass;

namespace ProductInventoryClassTests
{
    [TestClass]
    public class ProductTests
    {
        //Method 1: 
        //1. IsTotalNumberOfProducts10
        [TestMethod]
        public void TestMethod1_IsTotalNumberOfProducts10()
        {
            int prodCount;
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "Marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            product_list.Add(new Product("yam", 30, 50, "Root"));
            product_list.Add(new Product("spinach", 10, 100, "Leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "Leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "Marrow"));
            ProductRepository objProdRepo = new ProductRepository(product_list);
            prodCount = objProdRepo.TotalNumberOfProductsInList(product_list);
            Assert.AreEqual(10, prodCount);
        }



        //2. Add one product using method 2. 
        //Then test should assert total number of products to be 11.
        [TestMethod]
        public void AddProduct_IsTotalNumberOfProducts11()
        {
            int prodCount;
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "Marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            product_list.Add(new Product("yam", 30, 50, "Root"));
            product_list.Add(new Product("spinach", 10, 100, "Leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "Leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "Marrow"));
            ProductRepository objProdRepo = new ProductRepository(product_list);
            var new_list = objProdRepo.AddNewProduct_ReturnList("newProduct", 10, 50, "Root");
            prodCount = objProdRepo.TotalNumberOfProductsInList(new_list);
            Assert.AreEqual(11, prodCount);
        }

        //3. Delete zucchini and broccoli using method 4.
        //Then test should assert total number of products to be 8.
        [TestMethod]
        public void DeleteZucchiniAndBroccoli_IsTotalNumberOfProducts8()
        {
            int prodCount;
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "Marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            product_list.Add(new Product("yam", 30, 50, "Root"));
            product_list.Add(new Product("spinach", 10, 100, "Leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "Leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "Marrow"));
            ProductRepository objProdRepo = new ProductRepository(product_list);
            List<Product> newList = objProdRepo.FindProductByName_delete_returnNewProductList("zucchini");
            ProductRepository objProdRepo1 = new ProductRepository(newList);
            List<Product> newList1 = objProdRepo1.FindProductByName_delete_returnNewProductList("broccoli");
            prodCount = objProdRepo.TotalNumberOfProductsInList(newList1);
            Assert.AreEqual(8, prodCount);
        }
        //Method 2. 
        //1. Add new product using method 2, then test should assert returned list length to be 11.
        [TestMethod]
        public void AddProd_IsListLength11()
        {
            int prodCount = 0;
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "Marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            product_list.Add(new Product("yam", 30, 50, "Root"));
            product_list.Add(new Product("spinach", 10, 100, "Leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "Leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "Marrow"));
            ProductRepository objProdRepo1 = new ProductRepository(product_list);
            objProdRepo1.AddNewProduct_ReturnList("NewProduct", 20, 40, "NewType");
            prodCount = objProdRepo1.TotalNumberOfProductsInList(objProdRepo1.product_list_of_class);
            Assert.AreEqual(11, prodCount);
        }
        //Method 2. 
        //2. Add new product using method 2, 
        //then test should assert newly added product to be at last position of list.
        [TestMethod]
        public void addprod_isLastPosition()
        {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "marrow"));
            product_list.Add(new Product("yam", 30, 50, "root"));
            product_list.Add(new Product("spinach", 10, 100, "leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "marrow"));
            ProductRepository objprodrepo1 = new ProductRepository(product_list);
            List<Product> newList = objprodrepo1.AddNewProduct_ReturnList("newproduct", 20, 40, "newtype");

            int lastindex = newList.Count - 1;
            string newProdName = "newproduct";
            int index = newList.FindIndex(a => a.name == newProdName);
            Assert.AreEqual(lastindex, index);

        }
        // Method 3:
        //1. Use method 3 to find Cruciferous products, 
        //then test should assert returned product list length to be 3.
        [TestMethod]
        public void FindCruciferous_isProdList3()
        {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "marrow"));
            product_list.Add(new Product("yam", 30, 50, "root"));
            product_list.Add(new Product("spinach", 10, 100, "leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "marrow"));
            ProductRepository objprodrepo = new ProductRepository(product_list);
            List<Product> newList = objprodrepo.FindProductByType_returnFoundProductList("cruciferous");
            int prodCount = objprodrepo.TotalNumberOfProductsInList(newList);
            Assert.AreEqual(3, prodCount);
        }
        //Method 3:
        //2. Use method 3 to find Marrow products,
        //then test should assert returned product list must only contain marrow product type.
        [TestMethod]
        public void FindMarrow_CheckMarrow()
        {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "marrow"));
            product_list.Add(new Product("yam", 30, 50, "root"));
            product_list.Add(new Product("spinach", 10, 100, "leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "marrow"));
            ProductRepository objprodrepo = new ProductRepository(product_list);
            List<Product> newList = objprodrepo.FindProductByType_returnFoundProductList("marrow");
            bool result = true;
            foreach (Product prod in newList)
            {
                if (prod.type != "marrow")
                {
                    result = false;
                }
            }
            Assert.AreEqual(result, true);
        }

        //Method 4:
        //1. Delete pumpkin using method 4,
        //then test should assert returned list length to be 9.
        [TestMethod]
        public void DeletePumpkin_IsLength9()
        {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "marrow"));
            product_list.Add(new Product("yam", 30, 50, "root"));
            product_list.Add(new Product("spinach", 10, 100, "leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "marrow"));
            ProductRepository objProdRepo = new ProductRepository(product_list);

            List<Product> newList = objProdRepo.FindProductByName_delete_returnNewProductList("pumpkin");
            int prodLength = objProdRepo.TotalNumberOfProductsInList(newList);
            Assert.AreEqual(9, prodLength);
        }

        //Method 4:
        //2. Delete cabbage using method 4, 
        //then test should assert returned list must not contain cabbage.
        [TestMethod]
        public void DeleteCabbage_IsNoCabbage()
        {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "marrow"));
            product_list.Add(new Product("yam", 30, 50, "root"));
            product_list.Add(new Product("spinach", 10, 100, "leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "marrow"));
            ProductRepository objProdRepo = new ProductRepository(product_list);
            bool Result = true;
            List<Product> newList = objProdRepo.FindProductByName_delete_returnNewProductList("cabbage");
            foreach (Product prod in newList)
            {
                bool com = string.Equals(prod.name, "cabbage", StringComparison.OrdinalIgnoreCase);
                if (com)
                {
                    Result = false;
                }
            }
            Assert.AreEqual(true, Result);
        }
        //Method 5:
        //1. Use method 5 to buy grocery for making salad of your like,
        //then test should assert total price to be x.
        [TestMethod]
        public void MakingSalad_totalPrice()
            {
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product("lettuce", 10.5, 50, "leafy green"));
            product_list.Add(new Product("cabbage", 20, 100, "cruciferous"));
            product_list.Add(new Product("pumpkin", 30, 30, "marrow"));
            product_list.Add(new Product("cauliflower", 10, 25, "cruciferous"));
            product_list.Add(new Product("zucchini", 20.5, 50, "marrow"));
            product_list.Add(new Product("yam", 30, 50, "root"));
            product_list.Add(new Product("spinach", 10, 100, "leafy green"));
            product_list.Add(new Product("broccoli", 20.2, 75, "cruciferous"));
            product_list.Add(new Product("garlic", 30, 20, "leafy green"));
            product_list.Add(new Product("silverbeet", 10, 50, "marrow"));
            ProductRepository objProdRepo = new ProductRepository(product_list);
            double totalPrice = 
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("pumpkin", 1) +
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("silverbeet",1)+
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("garlic", 2) +
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("broccoli", 1) +
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("cabbage", 1) +
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("lettuce", 1)+
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("cauliflower", 0.5) +
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("zucchini", 1)+
                objProdRepo.BuyProdByNameQuantity_returnTotalPrice("yam", 2);
            Assert.AreEqual(236.2,totalPrice);
        }

        }
}
