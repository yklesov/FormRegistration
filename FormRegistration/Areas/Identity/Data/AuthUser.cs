﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FormRegistration.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AuthUser class
public class AuthUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName ="nvarchar(50)")]
    public string FirstName {  get; set; }
    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; }
}

