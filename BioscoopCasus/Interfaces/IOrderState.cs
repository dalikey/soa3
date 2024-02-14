using BioscoopCasus.Domain;

namespace BioscoopCasus.Interfaces {
    public interface IOrderState {
        void Pay();
        void Change();
        void SendReminder();
        void Cancel();
    }
}