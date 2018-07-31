using Northwind.Core.DataObjects;
using Northwind.Core.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalDelegateCommandsForContextMenu
{
    public class CustomerViewModelWithHierarchicalCommands:CustomerItemViewModel
    {
        public CustomerViewModelWithHierarchicalCommands(Customer customer):base(customer) {

            Commands = new List<DelegateCommandNode<CustomerItemViewModel>>();

            var command1 = new DelegateCommandNode<CustomerItemViewModel>(Execute) {
                Header = "Command 1",
            };

            command1.Commands.Add(new DelegateCommandNode<CustomerItemViewModel>(Execute) {
                Header = "Command 1, 1"
            });

            Commands.Add(command1);

            var command2 = new DelegateCommandNode<CustomerItemViewModel>(Execute) {
                Header = "Command 2",
            };

            command2.Commands.Add(new DelegateCommandNode<CustomerItemViewModel>(Execute) {
                Header = "Command 2, 1"
            });

            Commands.Add(command2);

            Commands.Add(new DelegateCommandNode<CustomerItemViewModel>(Execute) {
                Header = "Command 3",
            });
        }


        public List<DelegateCommandNode<CustomerItemViewModel>> Commands { get; private set; }

        public void Execute(CustomerItemViewModel customer) {

        }

    }
}
