using System.Collections.Generic;
using Newtonsoft.Json;

namespace pcs.Components
{
    public class ObjectData
    {
        public Dictionary<string, object> Raw = new Dictionary<string, object>();

        public virtual bool Contains(string key)
        {
            return Raw.ContainsKey(key);
        }

        public virtual void Set(string key, object value)
        {
            if (Contains(key))
                Raw[key] = value;
            else
                Raw.Add(key, value);
        }

        public virtual void Remove(string key)
        {
            Raw.Remove(key);
        }

        public virtual object Get(string key)
        {
            if (Contains(key))
                return Raw[key];
            return null;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(Raw);
        }

        public static ObjectData FromString(string raw)
        {
            ObjectData od = new ObjectData();
            od.Raw = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw);
            return od;
        }
    }
}
