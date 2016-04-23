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
    public class MemoryModelController : TableController<MemoryModel>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            paulmemoryboxContext context = new paulmemoryboxContext();
            DomainManager = new EntityDomainManager<MemoryModel>(context, Request);
        }

        // GET tables/TodoItem
        public IQueryable<MemoryModel> GetAllTodoItems()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<MemoryModel> GetMemoryModel(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<MemoryModel> PatchTodoItem(string id, Delta<MemoryModel> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostTodoItem(MemoryModel item)
        {
            MemoryModel current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteTodoItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}