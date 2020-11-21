using System;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceLibrary.Model.Attributes
{
    /// <summary>
    /// Attribute used to describe a service class.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ServiceAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="interfaceType">The interface that is being implemented</param>
        /// <param name="serviceLifetime">The service lifetime</param>
        public ServiceAttribute(Type interfaceType = null, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            InterfaceType = interfaceType;
            ServiceLifetime = serviceLifetime;
        }

        public Type InterfaceType { get; set; }
        public ServiceLifetime ServiceLifetime { get; set; }
    }
}