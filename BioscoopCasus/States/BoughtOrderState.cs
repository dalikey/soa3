using BioscoopCasus.Interfaces;

namespace BioscoopCasus.States {
    public class BoughtOrderState : IOrderState {
        public void Cancel() {
            Console.WriteLine("Order has been canceled.");
        }

        public void Change() {
            Console.WriteLine("Order has been changed.");
        }

        public void Pay() {
            Console.WriteLine("Order has been payed.");
        }

        public void SendReminder() {
            Console.WriteLine("Payment Reminder: Please remember to complete your payment for the order.");
        }

        public void ProcessOrder() {
            DateTime orderStartTime = new DateTime(2024, 2, 14, 12, 0, 0);
            TimeSpan timeUntilStart = orderStartTime - DateTime.Now;
            bool paymentCompleted = true;

            // Check if the order is still provisional (24 hours before the start)
            if (timeUntilStart.TotalHours <= 24 && !paymentCompleted) {
                SendReminder();
            }

            // Check if the payment is not completed 12 hours before the start
            if (timeUntilStart.TotalHours <= 12 && !paymentCompleted) {
                Cancel();
                Console.WriteLine("Order automatically canceled due to non-payment. Seats are released.");
            }
        }
    }
}
