using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using paulmemoryboxService.DataObjects;
using paulmemoryboxService.Models;

namespace paulmemoryboxService.Controllers
{
    public class SerializedMemoryController : TableController<SerializedMemory>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            paulmemoryboxContext context = new paulmemoryboxContext();
            DomainManager = new EntityDomainManager<SerializedMemory>(context, Request);
        }

        // GET tables/SerializedMemory
        public IQueryable<SerializedMemory> GetAllSerializedMemory()
        {
            return Query(); 
        }

        // GET tables/SerializedMemory/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SerializedMemory> GetSerializedMemory(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/SerializedMemory/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SerializedMemory> PatchSerializedMemory(string id, Delta<SerializedMemory> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/SerializedMemory
        public async Task<IHttpActionResult> PostSerializedMemory(SerializedMemory item)
        {
            SerializedMemory current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/SerializedMemory/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSerializedMemory(string id)
        {
             return DeleteAsync(id);
        }
    }
}
