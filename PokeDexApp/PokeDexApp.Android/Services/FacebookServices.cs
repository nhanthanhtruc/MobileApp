using System.Threading.Tasks;
using Plugin.CurrentActivity;
using PokeDexApp.Services;
using Xamarin.Facebook;
using Xamarin.Facebook.Login;
using Java.Lang;
using Xamarin.Forms; // phải thêm vào
using PokeDexApp.Droid.Services;

[assembly: Dependency(typeof(FacebookServices))] // phải thêm vào
namespace PokeDexApp.Droid.Services
{
    public class FacebookServices: Java.Lang.Object, IFacebookCallback, IFacebookService
    {
        private TaskCompletionSource<bool> _tcs;

        public FacebookServices()
        {
            CallbackManager = CallbackManagerFactory.Create();
            LoginManager.Instance.RegisterCallback(CallbackManager, this);
            Current = this;
        }

        public static FacebookServices Current { get; private set; }

        public ICallbackManager CallbackManager { get; }

        public bool IsProcess { get; set; }

        public void OnCancel()
        {
            _tcs.TrySetResult(false);
        }

        public void OnError(FacebookException error)
        {
            _tcs.TrySetResult(false);
        }

        public void OnSuccess(Object result)
        {
            if (result is LoginResult lr)
            {
                AccessToken = lr.AccessToken.Token;
                UserId = lr.AccessToken.UserId;
            }

            _tcs.TrySetResult(true);
        }


        public string UserId { get; private set; }

        public string AccessToken { get; private set; }

        public Task<bool> LoginAsync()
        {
            try
            {
                string[] scopes = { "email", "public_profile", "user_friends", "user_posts" };
                if (IsProcess)
                    return Task.FromResult(false);

                _tcs = new TaskCompletionSource<bool>();

                IsProcess = true;
                LoginManager.Instance.LogInWithReadPermissions(
                    CrossCurrentActivity.Current.Activity, scopes);

                return _tcs.Task;
            }
            catch (Exception)
            {
                //TODO: Log                
            }
            finally
            {
                IsProcess = false;
            }

            return Task.FromResult(false);
        }
    }
}