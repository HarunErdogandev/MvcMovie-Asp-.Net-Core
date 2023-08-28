using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class MovieCastManager : IMovieCastService
    {
        public IMovieCastDal _MovieCastDal;
        public MovieCastManager(IMovieCastDal movieCastDal)
        {
                _MovieCastDal= movieCastDal;
        }

        
        public void Add(MovieCast movieCast)
        {
            _MovieCastDal.Add(movieCast);
        }

        public void Delete(MovieCast movieCast)
        {
            _MovieCastDal.Delete(movieCast);
        }

        public void Update(MovieCast movieCast)
        {
            _MovieCastDal.Update(movieCast);
        }
    }
}
