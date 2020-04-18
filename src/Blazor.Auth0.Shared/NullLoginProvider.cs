namespace Blazor.Auth0.Shared
{
    public class NullLoginHintProvider : ILoginHintProvider
    {
        public string Get()
        {
            return null;
        }
    }
}
