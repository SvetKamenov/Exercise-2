﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    public interface IDeliveryService
    {
        bool IsCarInWarehouse(Car car);
        void DeliverCar(Car car);
    }
}
