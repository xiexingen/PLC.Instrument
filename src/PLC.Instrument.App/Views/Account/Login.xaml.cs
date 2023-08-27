using Abp.Dependency;
using Abp.UI;
using Microsoft.Extensions.Internal;
using PLC.Instrument.Authorization;
using PLC.Instrument.Authorization.Accounts;
using PLC.Instrument.Authorization.Users;
using PLC.Instrument.MultiTenancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PLC.Instrument.App.Account
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window, ISingletonDependency
    {
        private readonly IAccountAppService _accountAppService;
        public Login(IAccountAppService accountAppService)
        {
            _accountAppService= accountAppService;
            InitializeComponent();
        }

        public async Task LoginIn()
        {
            var result = await _accountAppService.Login(new Authorization.Accounts.Dto.LoginInput()
            {
                UsernameOrEmailAddress = "admin",
                Password = "Abcd1234",
            });
            Thread.CurrentPrincipal =new ClaimsPrincipal(result.Identity);
        }

        private void Close_Login_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        //public async Task<AjaxResponse> Authenticate(LoginModel loginModel)
        //{
        //    CheckModelState();

        //    var loginResult = await GetLoginResultAsync(
        //        loginModel.UsernameOrEmailAddress,
        //        loginModel.Password,
        //        loginModel.TenancyName
        //        );

        //    var ticket = new AuthenticationTicket(loginResult.Identity, new AuthenticationProperties());

        //    var currentUtc = new SystemClock().UtcNow;
        //    ticket.Properties.IssuedUtc = currentUtc;
        //    ticket.Properties.ExpiresUtc = currentUtc.Add(TimeSpan.FromMinutes(30));

        //    return new AjaxResponse(OAuthBearerOptions.AccessTokenFormat.Protect(ticket));
        //}


    }
}
