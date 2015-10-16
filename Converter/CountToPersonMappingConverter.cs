using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CinemalyticsCSharpSDK.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CinemalyticsCSharpSDK.Converter
{
    class CountToPersonMappingConverter : JsonConverter
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream            
            JArray jArray = JArray.Load(reader);

            // Create target object based on JObject
            List<KeyValuePair<Int32, Person>> target = new List<KeyValuePair<Int32, Person>>();

            // Populate the object properties
            for (int i = 0; i < jArray.Count; i++)
            {               
                target.Add(new KeyValuePair<int, Person>(
                    Convert.ToInt32(jArray[i].ToString()), JsonConvert.DeserializeObject<Person>(jArray[++i].ToString())));
            }                     

            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(List<KeyValuePair<Int32, Person>>).IsAssignableFrom(objectType);
        }
    }
}
