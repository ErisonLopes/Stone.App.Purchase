using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stone.App.Purchase.Infrastructure.MongoDB.Interfaces
{
    interface IStoneAppPurchaseDatabase
    {
        IMongoDatabase Database { get; }
    }
}
