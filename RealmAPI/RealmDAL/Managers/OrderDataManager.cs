﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RealmDAL.DTOs;

namespace RealmDAL.DataAccessControllers
{
    public class OrderDataController
    {
        public List<OrderDTO> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetAllOrdersByOrderStatus(string OrderStatus)
        {
            throw new NotImplementedException();
        }

        public List<OrderDTO> GetAllOrdersByCustomerID(int CustomerID)
        {
            throw new NotImplementedException();
        }

        public int AddNewOrder(OrderDTO NewOrderDTO)
        {
            throw new NotImplementedException();
        }
    }
}
