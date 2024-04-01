using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;

namespace MultiShop.WebUI.Services.Abstract
{
    public interface IIdentityService
    {
        Task<bool> SignIn(SignInDto signInDto);
    }
}
