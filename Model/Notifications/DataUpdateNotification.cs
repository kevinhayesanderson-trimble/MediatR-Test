using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Notifications
{
    public class DataUpdateNotification : IDataUpdateNotification
    {
        public Guid Id { get; set; }
        public string  Item { get; set; }
    }
}
