using Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Command
{
    public class SampleCommand : ICommand<SampleCommandComplete>
    {
        public string ToDoItem { get; set; }
    }

    public record SampleCommandComplete
    {
        public bool IsComplete { get; set; }
    }
}
