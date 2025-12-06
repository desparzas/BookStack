using BookStack.Web.Models;

namespace BookStack.Web.Services;

public class AuthStateService
{
    private User? _currentUser;

    public event Action? OnAuthStateChanged;

    public User? CurrentUser
    {
        get => _currentUser;
        private set
        {
            _currentUser = value;
            OnAuthStateChanged?.Invoke();
        }
    }

    public bool IsAuthenticated => CurrentUser != null;

    public void Login(User user)
    {
        CurrentUser = user;
    }

    public void Logout()
    {
        CurrentUser = null;
    }
}
