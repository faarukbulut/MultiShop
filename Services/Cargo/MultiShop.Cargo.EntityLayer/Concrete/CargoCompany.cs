﻿namespace MultiShop.Cargo.EntityLayer.Concrete
{
    public class CargoCompany
    {
        public int CargoCompanyID { get; set; }
        public string CargoCompanyName { get; set; }
        public List<CargoDetail> CargoDetails { get; set; }
    }
}
