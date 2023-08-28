using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MovieValidator:AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m=> m.MovieTitle).NotEmpty();
            RuleFor(m => m.MovieTitle).MinimumLength(2);

            RuleFor(m => m.Movieİmage).Must(imageFormat).WithMessage("Format Geçersiz");

        }

        private bool imageFormat(string arg)
        {
            string[] format = { "jpg", "png" };

            for (int i = 0; i < format.Length-1; i++)
            {
                if (arg.Contains(format[i]))
                {
                    return true;
                }
                
            }  
            return false;
        }
    }
}
