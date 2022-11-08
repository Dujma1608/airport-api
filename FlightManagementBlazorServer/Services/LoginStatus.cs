using System;
namespace FlightManagementBlazorServer.Services
{
    public class LoginStatus
    {
        public string _role = "default";
        public event Action OnChange;
        public string Role
        {
            get { return _role; }
            set
            {
                if(_role != value)
                {
                    _role = value;
                    StateChanged();
                }
            }
        }
        private void StateChanged() => OnChange?.Invoke();
    }
}
