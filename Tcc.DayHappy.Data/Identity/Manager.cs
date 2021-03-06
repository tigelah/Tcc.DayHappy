﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.DayHappy.Dominio.ContaUsuarios;

namespace Tcc.DayHappy.Data.Identity
{
    public class Manager : IManager
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
       // private readonly ApplicationDbContext _dbContext;

        public Manager(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager)
           // ApplicationDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
          //  _dbContext = dbContext;
        }

        public async Task<bool> CreateAsync(string email, string password, string role)
        {
            var user = new ApplicationUser { UserName = email, Email = email };
            var result = await _userManager.CreateAsync(user, password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, role);
                return true;
            }

            return false;
        }

        public List<IUser> ListAll()
        {
            throw new NotImplementedException();
        }
    }
}