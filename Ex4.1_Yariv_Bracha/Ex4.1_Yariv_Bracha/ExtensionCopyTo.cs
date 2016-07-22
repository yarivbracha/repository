using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4._1_Yariv_Bracha
{
    static class ExtensionCopyTo
    {
        public static void CopyTo(this object thisObject, object copyObject)
        {
            var properties = from thisProp in thisObject.GetType().GetProperties()
                             from copyProp in copyObject.GetType().GetProperties()
                             where thisProp.Name.Equals(copyProp.Name) &&
                             thisProp.CanRead &&
                             copyProp.CanWrite &&
                                 thisProp.PropertyType == copyProp.PropertyType
                             select new
                             {
                                 thisProperty = thisProp,
                                 copyProperty = copyProp
                             };
            foreach (var property in properties)
            {
                property.copyProperty.SetValue(copyObject, property.thisProperty.GetValue(thisObject, null), null);
            }
        }
    }
}
