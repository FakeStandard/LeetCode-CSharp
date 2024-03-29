﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Solution._1603.Design_parking_system
{
    public class _1603_Design_parking_system
    {
        /**
         * Your ParkingSystem object will be instantiated and called as such:
         * ParkingSystem obj = new ParkingSystem(big, medium, small);
         * bool param_1 = obj.AddCar(carType);
         */
        public class ParkingSystem
        {
            private int[] _arr;
            public ParkingSystem(int big, int medium, int small)
            {
                _arr = new int[3] { big, medium, small };
            }

            public bool AddCar(int carType)
            {
                if (_arr[carType - 1] > 0)
                {
                    _arr[carType - 1] -= 1;
                    return true;
                }

                return false;
            }

            //private int _big;
            //private int _medium;
            //private int _small;

            //public ParkingSystem(int big, int medium, int small)
            //{
            //    _big = big;
            //    _medium = medium;
            //    _small = small;
            //}

            //public bool AddCar(int carType)
            //{
            //    switch (carType)
            //    {
            //        case 1:
            //            if (_big > 0)
            //            {
            //                _big--;
            //                return true;
            //            }
            //            else return false;
            //            break;
            //        case 2:
            //            if (_medium > 0)
            //            {
            //                _medium--;
            //                return true;
            //            }
            //            else return false;
            //            break;
            //        case 3:
            //            if (_small > 0)
            //            {
            //                _small--;
            //                return true;
            //            }
            //            else return false;
            //            break;
            //        default:
            //            return false;
            //    }
            //}
        }
    }
}
