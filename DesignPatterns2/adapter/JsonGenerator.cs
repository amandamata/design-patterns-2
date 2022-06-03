using System;
using System.Text.Json;

namespace DesignPatterns2.adapter
{
    public class JsonGenerator
    {
        public String Json(object o)
        {
            return JsonSerializer.Serialize(o); ;
        }

    }
}
