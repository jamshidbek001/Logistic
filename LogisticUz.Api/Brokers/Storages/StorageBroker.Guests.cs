// =================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use Comfort And Peace
// =================================================

using LogisticUz.Api.Controllers.Foundations.Customers;
using Microsoft.EntityFrameworkCore;

namespace LogisticUz.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}