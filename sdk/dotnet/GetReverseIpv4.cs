// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi.Utilities;

namespace Pulumi.Vultr
{
    public static class GetReverseIpv4
    {
        /// <summary>
        /// Get information about a Vultr Reverse IPv4.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for an IPv4 reverse DNS record by `reverse`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myReverseIpv4 = Output.Create(Vultr.GetReverseIpv4.InvokeAsync(new Vultr.GetReverseIpv4Args
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetReverseIpv4FilterArgs
        ///                 {
        ///                     Name = "reverse",
        ///                     Values = 
        ///                     {
        ///                         "host.example.com",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetReverseIpv4Result> InvokeAsync(GetReverseIpv4Args? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetReverseIpv4Result>("vultr:index/getReverseIpv4:getReverseIpv4", args ?? new GetReverseIpv4Args(), options.WithVersion());

        /// <summary>
        /// Get information about a Vultr Reverse IPv4.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for an IPv4 reverse DNS record by `reverse`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myReverseIpv4 = Output.Create(Vultr.GetReverseIpv4.InvokeAsync(new Vultr.GetReverseIpv4Args
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetReverseIpv4FilterArgs
        ///                 {
        ///                     Name = "reverse",
        ///                     Values = 
        ///                     {
        ///                         "host.example.com",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetReverseIpv4Result> Invoke(GetReverseIpv4InvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetReverseIpv4Result>("vultr:index/getReverseIpv4:getReverseIpv4", args ?? new GetReverseIpv4InvokeArgs(), options.WithVersion());
    }


    public sealed class GetReverseIpv4Args : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetReverseIpv4FilterArgs>? _filters;

        /// <summary>
        /// Query parameters for finding IPv4 reverse DNS records.
        /// </summary>
        public List<Inputs.GetReverseIpv4FilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetReverseIpv4FilterArgs>());
            set => _filters = value;
        }

        public GetReverseIpv4Args()
        {
        }
    }

    public sealed class GetReverseIpv4InvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetReverseIpv4FilterInputArgs>? _filters;

        /// <summary>
        /// Query parameters for finding IPv4 reverse DNS records.
        /// </summary>
        public InputList<Inputs.GetReverseIpv4FilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetReverseIpv4FilterInputArgs>());
            set => _filters = value;
        }

        public GetReverseIpv4InvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetReverseIpv4Result
    {
        public readonly ImmutableArray<Outputs.GetReverseIpv4FilterResult> Filters;
        /// <summary>
        /// The gateway IP address.
        /// </summary>
        public readonly string Gateway;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The ID of the instance the IPv4 reverse DNS record was set for.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// The IPv4 address in canonical format used in the reverse DNS record.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// The IPv4 netmask in dot-decimal notation.
        /// </summary>
        public readonly string Netmask;
        /// <summary>
        /// The hostname used in the IPv4 reverse DNS record.
        /// </summary>
        public readonly string Reverse;

        [OutputConstructor]
        private GetReverseIpv4Result(
            ImmutableArray<Outputs.GetReverseIpv4FilterResult> filters,

            string gateway,

            string id,

            string instanceId,

            string ip,

            string netmask,

            string reverse)
        {
            Filters = filters;
            Gateway = gateway;
            Id = id;
            InstanceId = instanceId;
            Ip = ip;
            Netmask = netmask;
            Reverse = reverse;
        }
    }
}
