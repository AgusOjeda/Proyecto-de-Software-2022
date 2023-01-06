﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Authentication.Domain.DTOs.Request
{
    public class ResetPasswordRequest
    {
        [Required, MinLength(6)]
        public String Password { get; set; } = string.Empty;
    }
}
