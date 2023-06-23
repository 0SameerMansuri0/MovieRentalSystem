using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieRentalApp.Constants;
using MovieRentalApp.Context;
using MovieRentalApp.Models;
using System;
using System.Data;

namespace MovieRentalApp.Controllers
{
    
    public class UserController : Controller
    {
        readonly IMapper _mapper;
        readonly AppDbContext _appDbContext;


        readonly UserManager<User> _manager;
        readonly SignInManager<User> _signInManager;
        public UserController(UserManager<User> manager, SignInManager<User> signInManager, AppDbContext appDbContext)
        {
            _manager = manager;
            _signInManager = signInManager;
            _appDbContext = appDbContext;

        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Booking");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register user)
        {
            if (ModelState.IsValid)
            {
                var createdUser = new User { userId = user.userId, UserName = user.UserName, Email = user.Email, Location = user.Location };
                var result = await _manager.CreateAsync(createdUser, user.Password);
                if (result.Succeeded)
                {
                    await _manager.AddToRoleAsync(createdUser, Roles.User);
                    return RedirectToAction("LogIn");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(user);
        }

        [HttpGet]
        [Route("User/LogIn")]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
                User user = await _manager.FindByEmailAsync(loginModel.Email);
                if (result.Succeeded)
                {
                    if (isAdmin(loginModel.Email))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        Console.WriteLine(user.Id);
                      // HttpContext.Session.SetString("UserId", user.Id);
                        return RedirectToAction("Index", "Booking");
                    }
                }
                ModelState.AddModelError("", "Login Failed");
            }
            return View(loginModel);
        }

        public static bool isAdmin(string email)
        {
            if (email == "admin@gmail.com")
            {
                return true;
            }
            return false;
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("LogIn");
        }

        public async Task<IActionResult> GetUser(string id)
        {

            IdentityUser user = await _manager.FindByIdAsync(id);
            return View(user);
        }
    }
}
