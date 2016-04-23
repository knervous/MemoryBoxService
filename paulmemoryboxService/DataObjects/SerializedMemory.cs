using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paulmemoryboxService.DataObjects
{
  
        class SerializedMemory
        {
            public string Data { get; set; }

            [Newtonsoft.Json.JsonProperty("Id")]
            public string Id { get; set; }
        }
 
}