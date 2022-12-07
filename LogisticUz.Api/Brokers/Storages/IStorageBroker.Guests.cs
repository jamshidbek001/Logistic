// =================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
// =================================================

using System.Threading.Tasks;
using LogisticUz.Api.Controllers.Foundations.Customers;

namespace LogisticUz.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}