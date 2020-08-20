﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DateLayer
{
    public class RegisterViewModel
    {
         [Display(Name="نام کاربری")]    [Required(ErrorMessage="لطفا {0} خود را وارد کنید")]
        public string UserName { get; set; }
         [Display(Name = "ایمیل")]
         [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
         [EmailAddress(ErrorMessage="ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }
         [Display(Name = "کلمه عبور")]
         [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
         [DataType(DataType.Password)]
        public string Password { get; set; }
         [Display(Name = "تکرار کلمه عبور")]
         [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
         [DataType(DataType.Password)]
         [Compare("Password" , ErrorMessage="کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }
    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string  Email { get; set; }
        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
    public class ForgotPasswordViewModel
    {
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        public string Email { get; set; }
    }

    public class RecoveyPasswordViewModel
    {
        [Display(Name = "کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = " تکرار کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }
    public class ChangePasswordViewModel
    {
        [Display(Name = "کلمه عبور قبلی")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Display(Name = "کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = " تکرار کلمه عبور جدید")]
        [Required(ErrorMessage = "لطفا {0} خود را وارد کنید")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "کلمه های عبور مغایرت دارند")]
        public string RePassword { get; set; }
    }
}
