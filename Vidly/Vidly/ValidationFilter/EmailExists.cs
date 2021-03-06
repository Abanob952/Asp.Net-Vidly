using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ValidationFilter
{
    public class EmailExists:ValidationAttribute
    {
       
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DBModel _context =(DBModel)validationContext.GetService(typeof(DBModel));
            if (value == null)
            {
                return new ValidationResult("The Email is Required");
            }
           var user = _context.Users.FirstOrDefault(c => c.Email == value);
            if (user == null)
            {
                return new ValidationResult("This Email doesn't exist");

            }
            return ValidationResult.Success;
        }
    }
}
