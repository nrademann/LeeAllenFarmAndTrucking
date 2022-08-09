﻿using LeeAllenFarmAndTrucking.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LeeAllenFarmAndTrucking.ViewModel
{
    public class OrderAddOrderViewModel
    {
        public Order Order { get; set; }
        public Client Client { get; set; }
        public SelectList ClientList { get; set; }
    }
}