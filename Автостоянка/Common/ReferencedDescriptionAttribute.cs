using System;
using System.ComponentModel;

namespace Common
{

    /// <summary>
    /// ReferencedDescriptionAttribute shows the description of a specific property
    /// in an existing class (the "referenced type").
    /// </summary>
    public class ReferencedDescriptionAttribute : DescriptionAttribute
    {

        public ReferencedDescriptionAttribute(Type referencedType, string propertyName)
        {
            //	default description
            string result = "Referenced description not available";

            //	gets the properties of the referenced type
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(referencedType);

            if (properties != null)
            {
                // gets a PropertyDescriptor to the specific property.
                PropertyDescriptor property = properties[propertyName];
                if (property != null)
                {
                    //  gets the attributes of the required property
                    AttributeCollection attributes = property.Attributes;

                    // Gets the description attribute from the collection.
                    DescriptionAttribute descript = (DescriptionAttribute)attributes[typeof(DescriptionAttribute)];

                    // register the referenced description
                    if (!String.IsNullOrEmpty(descript.Description)) result = descript.Description;
                }
            }

            DescriptionValue = result;
        }

    }

}
