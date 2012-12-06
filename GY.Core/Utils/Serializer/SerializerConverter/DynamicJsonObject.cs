using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using System.Collections;

namespace GY.Core.Utils.Serializer.SerializerConverter
{
    public class DynamicJsonObject : DynamicObject
    {
        private IDictionary<string, object> Dictionary { set; get; }

        public DynamicJsonObject(IDictionary<string, object> dictionary)
        {
            this.Dictionary = dictionary;

        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            result = this.Dictionary[binder.Name];

            if (result is IDictionary<string, object>)
            {
                result = new DynamicJsonObject(result as IDictionary<string, object>);

            }
            else if (result is IList<IDictionary<string, object>>)
            {
                result = new List<DynamicJsonObject>((result as IList<IDictionary<string, object>>)
                               .ToArray().Select(x => new DynamicJsonObject(x)));
            }
            else if (result is IList<object>)
            {

                result = result as IList<object>;
            }

            return this.Dictionary.ContainsKey(binder.Name);

        }


    }
}
