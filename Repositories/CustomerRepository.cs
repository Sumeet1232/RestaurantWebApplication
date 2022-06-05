using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurant.Models;

namespace WebAppRestaurant.Repositories
{
    public class CustomerRepository
    {
        private RestaurantDBEntities objRestaurantDbEntities;
        public CustomerRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerID.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}