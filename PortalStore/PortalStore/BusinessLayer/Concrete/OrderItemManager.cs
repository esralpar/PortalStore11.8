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
    public class OrderItemManager : IOrderItemService
    {
        IOrderItemDal _orderItemDal;

        public OrderItemManager(IOrderItemDal orderItemDal)
        {
            _orderItemDal = orderItemDal;
        }

        public void TAdd(OrderItem t)
        {
            _orderItemDal.Insert(t);
        }

        public void TDElete(OrderItem t)
        {
            _orderItemDal.Delete(t);
        }

        public OrderItem TGetBYID(int id)
        {
            return _orderItemDal.GetByID(id);
        }

        public List<OrderItem> TGetList()
        {
            return _orderItemDal.GetList();
        }

        public void TUpdate(OrderItem t)
        {
            _orderItemDal.Update(t);
        }
    }
}
