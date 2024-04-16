using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInterface.Controles
{
    public class PagoControl
    {
        // PaymentController.cs
        public class PaymentController : pagoControl
        {
            private readonly Pago _paymentService;

            public PaymentController(PagoControl paymentService)
            {
                _paymentService = paymentService;
            }

            public IActionResult ProcessPayment(Payment payment)
            {
                _paymentService.ProcessPayment(payment);
                return RedirectToAction("Index", "Home"); 
            }
        }
    }
}