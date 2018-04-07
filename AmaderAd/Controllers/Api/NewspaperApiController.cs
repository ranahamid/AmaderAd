using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AmaderAd.Models;
using AmaderAd.DAL;

namespace AmaderAd.Controllers.Api
{
    public class NewspaperApiController : ApiController
    {
        private readonly INewspaperAccessRepository<Newspaper, int> _repository;

        public NewspaperApiController(INewspaperAccessRepository<Newspaper, int> r)
        {
            _repository = r;
        }


        [Route("api/NewspaperApi/")]
        // GET: api/NewspaperApi
        public IEnumerable<Newspaper> GetNewspapers()
        {
            return _repository.Get();
        }


        [Route("api/NewspaperApi/{id}")]
        // GET: api/NewspaperApi/5
        [ResponseType(typeof(Newspaper))]
        public IHttpActionResult GetNewspaper(int id)
        {
            var item = _repository.Get(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [Route("api/NewspaperApi/{id}")]
        // PUT: api/NewspaperApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNewspaper(int id, Newspaper entity)
        {
            _repository.Put(id, entity);
            return StatusCode(HttpStatusCode.NoContent);
        }

        [Route("api/NewspaperApi/")]
        // POST: api/NewspaperApi
        [ResponseType(typeof(Newspaper))]
        public IHttpActionResult PostNewspaper(Newspaper entity)
        {
            _repository.Post(entity);
            return Ok(entity);
        }

        [Route("api/NewspaperApi/{id}")]
        // DELETE: api/NewspaperApi/5
        [ResponseType(typeof(Newspaper))]
        public IHttpActionResult DeleteNewspaper(int id)
        {
            _repository.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}