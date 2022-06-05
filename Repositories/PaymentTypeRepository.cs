using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppRestaurant.Models;

namespace WebAppRestaurant.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDbEntities;
        public PaymentTypeRepository()
        {
            objRestaurantDbEntities = new RestaurantDBEntities();

        }

        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objRestaurantDbEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentType1,
                                      Value = obj.PaymentID.ToString(),
                                      Selected = true
                                  }).ToList();
        return objSelectListItems;
    }
    }
}