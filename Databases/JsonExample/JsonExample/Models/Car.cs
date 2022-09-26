using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample.Models
{
    public class Car
    {
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("year")]
        public string Year { get; set; }
    }
}
