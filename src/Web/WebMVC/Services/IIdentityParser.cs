namespace Microsoft.MPGC.WebMVC.Services;

public interface IIdentityParser<T>
{
    T Parse(IPrincipal principal);
}
