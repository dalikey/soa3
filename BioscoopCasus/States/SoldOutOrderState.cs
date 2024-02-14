using BioscoopCasus.Interfaces;

namespace BioscoopCasus.States {
    public class SoldOutOrderState : IOrderState {
        public void Cancel() {
            Console.WriteLine("Order sold out.");
        }

        public void Change() {
            Console.WriteLine("Order sold out.");
        }

        public void Pay() {
            Console.WriteLine("Order sold out.");
        }

        public void SendReminder() {
            Console.WriteLine("Order sold out.");
        }
    }
}
