using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transport.Model;
using Transport.Views;

namespace Transport.Controllers
{
    public class TransportController
    {
        private Display display;
        private Transportt transport;
        public TransportController()
        {
            display = new Display();
            transport = new Transportt(display.Km, display.Time);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowPrice();
        }
    }
}
