using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VemDeZap.Domain.Commands
{
    public class Response
    {
        public Response(INotifiable notifiable)
        {
            this.Success = notifiable.IsInvalid();
            this.Notifications = notifiable.Notifications;
        }

        public Response(INotifiable notifiable, object data)
        {
            this.Success = notifiable.IsInvalid();
            this.Data = data;
            this.Notifications = notifiable.Notifications;
        }

        public IEnumerable<Notification> Notifications { get;  }
        public bool Success { get; private set; }
        public Object Data { get; private set; }
    }
}
 