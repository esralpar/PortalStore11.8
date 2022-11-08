﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abscract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal  _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TAdd(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TDElete(Order t)
        {
            _orderDal.Delete(t);
        }

        public Order TGetBYID(int id)
        {
            return _orderDal.GetByID(id);
        }

        public List<Order> TGetList()
        {
            return _orderDal.GetList();
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
