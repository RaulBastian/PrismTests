using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalDelegateCommandsForContextMenu {
    public class DelegateCommandNode<T> : DelegateCommand<T>
    {
        public DelegateCommandNode(Action<T> executeMethod) : base(executeMethod) { Initialize(); }

        public DelegateCommandNode(Action<T> executeMethod, Func<T,bool> canExecuteMethod) :base(executeMethod, canExecuteMethod) { Initialize(); }

        private void Initialize() {
            Commands = new List<DelegateCommandNode<T>>(); 
        }

        public List<DelegateCommandNode<T>> Commands { get; private set; }

        public string Header { get; set; }

    }
}
