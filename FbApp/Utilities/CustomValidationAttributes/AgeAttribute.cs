﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FbApp.Utilities.CustomValidationAttributes
{
    public class AgeAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            int age;

            try
            {
                age = int.Parse(value.ToString());
                if (age >= 12 && age <= 130)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Age should be a number between 12 and 130!");
                }
            }
            catch (Exception)
            {
                return new ValidationResult("Age should be a number between 12 and 130!");
            }
        }
    }
}