﻿using PurpleShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PurpleShop.Entities.Concrete
{
    public class Feature : IEntity
    {
        public Feature()
        {
            FeatureElectronics = new List<FeatureElectronic>();
        }
        public int Id { get; set; }
        public int Price { get; set; }
        public int UnitsInStock { get; set; }
        public string PaymentOptions { get; set; }
        public List<FeatureElectronic> FeatureElectronics { get; set; }

    }

    //Burada bir ayrım yapılmalı measurement vs

    //Elektronik Ürünler
    public class FeatureElectronic : IEntity
    {
        public int Id { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public string InternalMemory { get; set; }
        public string ScreenSize { get; set; }
        public string RAMCapacity { get; set; }
        public string BatteryPower { get; set; }
        public string CameraResolution { get; set; }
    }
}
