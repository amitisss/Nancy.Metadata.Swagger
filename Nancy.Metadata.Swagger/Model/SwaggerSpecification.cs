﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nancy.Metadata.Swagger.Model
{
    public class SwaggerSpecification
    {
        [JsonProperty("swagger")]
        public string SwaggerVersion { get { return "2.0"; } }

        [JsonProperty("info")]
        public SwaggerApiInfo ApiInfo { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("basePath")]
        public string BasePath { get; set; }

        [JsonProperty("schemes")]
        public string[] Schemes { get; set; }

        [JsonProperty("paths")]
        public Dictionary<string, Dictionary<string, SwaggerEndpointInfo>> PathInfos { get; set; }

        [JsonProperty(SwaggerConstants.ModelDefinitionsKey)]
        public Dictionary<string, JObject> ModelDefinitions { get; set; }
    }
}