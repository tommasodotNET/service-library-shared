using System;

namespace ServiceLibrary.Model.Attributes
{
    /// <summary>
    /// Attribute used to describe an option class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class OptionAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName">The section name to be binded</param>
        public OptionAttribute(string sectionName = "")
        {
            SectionName = sectionName;
        }

        public string SectionName { get; set; }
    }
}