using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample.InitialData
{
    public static class Samples
    {
        public static string SingleJson() =>           
            @"{
            ""name"": ""Vardenis Pavardenis"",
            ""courses"": [""C#"", ""Java"", ""T-SQL""],
            ""since"": ""2020-01-01T00:00:00"",
            ""happy"": true,
            ""issues"": null,
            ""car"": 
                {
                    ""model"": ""Enterprise"",
                    ""year"": ""2020""
                },
            ""authorRelationship"": 1
            }";
    }
}
