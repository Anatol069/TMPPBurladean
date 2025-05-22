using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OrderButton
    {
        private IOrderCommand _command;

        public void SetCommand(IOrderCommand command)
        {
            _command = command;
        }

        public void Press()
        {
            _command.Execute();
        }
    }
}

