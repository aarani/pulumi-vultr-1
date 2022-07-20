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
    public static class GetReservedIp
    {
        /// <summary>
        /// Get information about a Vultr reserved IP address.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for a reserved IP by `label`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myReservedIp = Output.Create(Vultr.GetReservedIp.InvokeAsync(new Vultr.GetReservedIpArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetReservedIpFilterArgs
        ///                 {
        ///                     Name = "label",
        ///                     Values = 
        ///                     {
        ///                         "my-reserved-ip-label",
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
        public static Task<GetReservedIpResult> InvokeAsync(GetReservedIpArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetReservedIpResult>("vultr:index/getReservedIp:getReservedIp", args ?? new GetReservedIpArgs(), options.WithVersion());

        /// <summary>
        /// Get information about a Vultr reserved IP address.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for a reserved IP by `label`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myReservedIp = Output.Create(Vultr.GetReservedIp.InvokeAsync(new Vultr.GetReservedIpArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetReservedIpFilterArgs
        ///                 {
        ///                     Name = "label",
        ///                     Values = 
        ///                     {
        ///                         "my-reserved-ip-label",
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
        public static Output<GetReservedIpResult> Invoke(GetReservedIpInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetReservedIpResult>("vultr:index/getReservedIp:getReservedIp", args ?? new GetReservedIpInvokeArgs(), options.WithVersion());
    }


    public sealed class GetReservedIpArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetReservedIpFilterArgs>? _filters;

        /// <summary>
        /// Query parameters for finding reserved IP addresses.
        /// </summary>
        public List<Inputs.GetReservedIpFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetReservedIpFilterArgs>());
            set => _filters = value;
        }

        public GetReservedIpArgs()
        {
        }
    }

    public sealed class GetReservedIpInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetReservedIpFilterInputArgs>? _filters;

        /// <summary>
        /// Query parameters for finding reserved IP addresses.
        /// </summary>
        public InputList<Inputs.GetReservedIpFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetReservedIpFilterInputArgs>());
            set => _filters = value;
        }

        public GetReservedIpInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetReservedIpResult
    {
        public readonly ImmutableArray<Outputs.GetReservedIpFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The ID of the VPS the reserved IP is attached to.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// The IP type of the reserved IP.
        /// </summary>
        public readonly string IpType;
        /// <summary>
        /// The label of the reserved IP.
        /// </summary>
        public readonly string Label;
        /// <summary>
        /// The ID of the region that the reserved IP is in.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// The subnet of the reserved IP.
        /// </summary>
        public readonly string Subnet;
        /// <summary>
        /// The subnet size of the reserved IP.
        /// </summary>
        public readonly int SubnetSize;

        [OutputConstructor]
        private GetReservedIpResult(
            ImmutableArray<Outputs.GetReservedIpFilterResult> filters,

            string id,

            string instanceId,

            string ipType,

            string label,

            string region,

            string subnet,

            int subnetSize)
        {
            Filters = filters;
            Id = id;
            InstanceId = instanceId;
            IpType = ipType;
            Label = label;
            Region = region;
            Subnet = subnet;
            SubnetSize = subnetSize;
        }
    }
}
