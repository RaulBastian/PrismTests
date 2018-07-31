using Northwind.Core.Abstractions;
using Northwind.Core.DataObjects;
using Northwind.Core.ViewModels;
using Northwind.Core.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalDelegateCommandsForContextMenu
{
    public class CustomerViewModelCollectionExt : Northwind.Core.ViewModels.CustomersCollectionViewModel {

        protected override NorthwindItemViewModelBase<Customer> GetNorthwindItemViewModel(Customer item, INorthwindServiceBase<Customer> service) {
            return new CustomerViewModelWithHierarchicalCommands(item);
        }

    }
}
