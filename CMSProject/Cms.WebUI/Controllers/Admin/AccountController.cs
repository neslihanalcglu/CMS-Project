using Cms.Bussiness.Email;
using Cms.WebUI.Identity;
using Cms.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cms.WebUI.Controllers.Login
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FullName = model.FullName
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var callbackUrl = Url.Action("ConfirmEmail", "Account", new
                {
                    userId = user.Id,
                    token = code
                }, protocol: HttpContext.Request.Scheme);
                Email mail = new Email();
                mail.Mail(model.Email, "Hesap Aktivasyon", callbackUrl, $"Lütfen hesabınızı aktif hale getirmek için linke <a href='{callbackUrl}'>tıklayınız.</a>");

                return RedirectToAction("login", "account");
            }

            ModelState.AddModelError("", "Bilinmeyen hata oluştu lütfen tekrar deneyiniz.");

            return View(model);
        }
        public IActionResult Login(string ReturnUrl =null)
        {
            return View(new LoginModel()
            {
                ReturnUrl = ReturnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(model);
            //}
            //var user = await _userManager.FindByEmailAsync(model.Email);

            //if (user == null)
            //{
            //    ModelState.AddModelError("", "Bu email ile daha önce hesap oluşturulmamış.");
            //    return View(model);
            //}

            //if (!await _userManager.IsEmailConfirmedAsync(user))
            //{
            //    ModelState.AddModelError("", "Lütfen hesabınızı email ile onaylayınız.");
            //    return View(model);
            //}


            //var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            //if (result.Succeeded)
            //{
            //    return Redirect(model.ReturnUrl ?? "~/");
            //}

            //ModelState.AddModelError("", "Email veya parola yanlış");
            //return View(model);

            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu email ile daha önce hesap oluşturulmamış.");
                return View(model);
            }

            if (await _userManager.IsEmailConfirmedAsync(user)) 
            {
                ModelState.AddModelError("", "Lütfen hesabınızı email ile onaylayınız.");
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (result.Succeeded)
            {
                return Redirect(model.ReturnUrl ?? "~/");
            }
            ModelState.AddModelError("", "Email veya parola yanlış");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("~/");
        }

        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                TempData["message"] = "Geçersiz token.";
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (userId != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    TempData["message"] = "Hesabınız onaylandı.";
                    return View();
                }

            }

            TempData["message"] = "Hesabınız onaylanmadı.";
            return View();
        }
    }
}
