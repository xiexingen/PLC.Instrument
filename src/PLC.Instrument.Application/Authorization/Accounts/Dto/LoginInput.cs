using Abp.Auditing;
using Abp.Authorization.Users;
using PLC.Instrument.Authorization.Users;
using PLC.Instrument.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLC.Instrument.Authorization.Accounts.Dto
{
    public class LoginInput
    {
        [Required]
        public string UsernameOrEmailAddress { get; set; }

        [Required]
        [StringLength(User.MaxPlainPasswordLength)]
        [DisableAuditing]
        public string Password { get; set; }

        public string TenancyName { get; set; }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (!UserName.IsNullOrEmpty())
        //    {
        //        if (!UserName.Equals(EmailAddress) && ValidationHelper.IsEmail(UserName))
        //        {
        //            yield return new ValidationResult("Username cannot be an email address unless it's same with your email address !");
        //        }
        //    }
        //}
    }
}
