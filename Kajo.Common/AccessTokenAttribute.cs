using System;
using Microsoft.Azure.WebJobs.Description;

namespace Kajo.Common
{
    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    [Binding]
    public sealed class AccessTokenAttribute : Attribute
    {
    }
}