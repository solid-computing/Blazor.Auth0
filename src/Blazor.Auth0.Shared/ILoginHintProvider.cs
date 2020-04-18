using System.Threading.Tasks;

namespace Blazor.Auth0.Shared
{
    /// <summary>
    /// Returns the login_hint value for auth0 which can be used to pre-populate user email or name.
    /// </summary>
    public interface ILoginHintProvider
    {
        /// <summary>
        /// Try to get login_hint value. If unable to read then returns null.
        /// </summary>
        /// <returns> login_hint </returns>
        string Get();
    }

}
