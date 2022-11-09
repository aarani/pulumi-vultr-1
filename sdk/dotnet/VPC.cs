// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Vultr
{
    /// <summary>
    /// Provides a Vultr VPC resource. This can be used to create, read, and delete VPCs on your Vultr account.
    /// 
    /// ## Example Usage
    /// 
    /// Create a new VPC with an automatically generated CIDR block:
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Vultr = Pulumi.Vultr;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var myVpc = new Vultr.VPC("myVpc", new()
    ///     {
    ///         Description = "my vpc",
    ///         Region = "ewr",
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// Create a new VPC with a specified CIDR block:
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using Pulumi;
    /// using Vultr = Pulumi.Vultr;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var myVpc = new Vultr.VPC("myVpc", new()
    ///     {
    ///         Description = "my private vpc",
    ///         Region = "ewr",
    ///         V4Subnet = "10.0.0.0",
    ///         V4SubnetMask = 24,
    ///     });
    /// 
    /// });
    /// ```
    /// 
    /// ## Import
    /// 
    /// VPCs can be imported using the VPC `ID`, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import vultr:index/vPC:VPC my_vpc 0e04f918-575e-41cb-86f6-d729b354a5a1
    /// ```
    /// </summary>
    [VultrResourceType("vultr:index/vPC:VPC")]
    public partial class VPC : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The date that the VPC was added to your Vultr account.
        /// </summary>
        [Output("dateCreated")]
        public Output<string> DateCreated { get; private set; } = null!;

        /// <summary>
        /// The description you want to give your VPC.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The region ID that you want the VPC to be created in.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The IPv4 subnet to be used when attaching instances to this VPC.
        /// </summary>
        [Output("v4Subnet")]
        public Output<string> V4Subnet { get; private set; } = null!;

        /// <summary>
        /// The number of bits for the netmask in CIDR notation. Example: 32
        /// </summary>
        [Output("v4SubnetMask")]
        public Output<int> V4SubnetMask { get; private set; } = null!;


        /// <summary>
        /// Create a VPC resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VPC(string name, VPCArgs args, CustomResourceOptions? options = null)
            : base("vultr:index/vPC:VPC", name, args ?? new VPCArgs(), MakeResourceOptions(options, ""))
        {
        }

        private VPC(string name, Input<string> id, VPCState? state = null, CustomResourceOptions? options = null)
            : base("vultr:index/vPC:VPC", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VPC resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VPC Get(string name, Input<string> id, VPCState? state = null, CustomResourceOptions? options = null)
        {
            return new VPC(name, id, state, options);
        }
    }

    public sealed class VPCArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description you want to give your VPC.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The region ID that you want the VPC to be created in.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// The IPv4 subnet to be used when attaching instances to this VPC.
        /// </summary>
        [Input("v4Subnet")]
        public Input<string>? V4Subnet { get; set; }

        /// <summary>
        /// The number of bits for the netmask in CIDR notation. Example: 32
        /// </summary>
        [Input("v4SubnetMask")]
        public Input<int>? V4SubnetMask { get; set; }

        public VPCArgs()
        {
        }
        public static new VPCArgs Empty => new VPCArgs();
    }

    public sealed class VPCState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The date that the VPC was added to your Vultr account.
        /// </summary>
        [Input("dateCreated")]
        public Input<string>? DateCreated { get; set; }

        /// <summary>
        /// The description you want to give your VPC.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The region ID that you want the VPC to be created in.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The IPv4 subnet to be used when attaching instances to this VPC.
        /// </summary>
        [Input("v4Subnet")]
        public Input<string>? V4Subnet { get; set; }

        /// <summary>
        /// The number of bits for the netmask in CIDR notation. Example: 32
        /// </summary>
        [Input("v4SubnetMask")]
        public Input<int>? V4SubnetMask { get; set; }

        public VPCState()
        {
        }
        public static new VPCState Empty => new VPCState();
    }
}
