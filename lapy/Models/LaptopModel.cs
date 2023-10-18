using lapy.data;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Sql;
using System.Linq;
using System.Web;

namespace lapy.Models
{
    public class LaptopModel
    {
        private tblLaptop lapyData;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Product { get; set; }
        public string price { get; set; }
        public string SPrice { get; set; }
        public string Date { get; set; }
        public string Model_no { get; set; }

        public string SaveLaptop(LaptopModel model)
        {
            string msg = "Add Information";
            dbShopkeeperEntities db = new dbShopkeeperEntities();
            {



                Id = model.Id;
                Name = model.Name;
                Product = model.Product;
                price = model.price;
                SPrice = model.SPrice;
                Date = model.Date;
                Model_no = model.Model_no;
            };
             db.tblLaptops.Add(lapyData);
            db.SaveChanges();
            return msg;




        }

    }
}