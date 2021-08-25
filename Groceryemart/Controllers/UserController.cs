﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GroceryEmart.BusinessLayer.Interfaces;
using GroceryEmart.BusinessLayer.ViewModels;
using GroceryEmart.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryEmart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Creating referance variable of IUserGroceryServices and IAdminGroceryServices
        /// </summary>
        private readonly IUserGroceryServices _userGS;
        private readonly IAdminGroceryServices _adminGS;
        /// <summary>
        /// Injecting referance variable into UserController constructor
        /// </summary>
        public UserController(IUserGroceryServices userGroceryServices, IAdminGroceryServices adminGroceryServices)
        {
            _userGS = userGroceryServices;
            _adminGS = adminGroceryServices;
        }
        /// <summary>
        /// Get All registred user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<ApplicationUser>> AllUser()
        {
            return await _adminGS.GetAllUser();
        }
        /// <summary>
        /// Register new user and provide all information by applicationuser class object
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> AddNewUser([FromBody] UserViewModel model)
        {
            //Do code here
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update an existing User, get user first then update user info.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Updateuser/{UserId}")]
        public async Task<IActionResult> UpdateUser(int UserId, [FromBody] ApplicationUser user)
        {
            //Do code here
            throw new NotImplementedException();
        }
    }
}
