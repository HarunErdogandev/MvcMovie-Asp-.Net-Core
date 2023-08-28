using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieCastService
    {
        void Add(MovieCast movieCast);
        void Update(MovieCast movieCast);
        void Delete(MovieCast movieCast);   
    }
}
