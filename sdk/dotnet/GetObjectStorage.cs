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
    public static class GetObjectStorage
    {
        /// <summary>
        /// Get information about an Object Storage subscription on Vultr.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for an object storage subscription by `label`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var s3 = Output.Create(Vultr.GetObjectStorage.InvokeAsync(new Vultr.GetObjectStorageArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetObjectStorageFilterArgs
        ///                 {
        ///                     Name = "label",
        ///                     Values = 
        ///                     {
        ///                         "my-s3",
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
        public static Task<GetObjectStorageResult> InvokeAsync(GetObjectStorageArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetObjectStorageResult>("vultr:index/getObjectStorage:getObjectStorage", args ?? new GetObjectStorageArgs(), options.WithVersion());

        /// <summary>
        /// Get information about an Object Storage subscription on Vultr.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for an object storage subscription by `label`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var s3 = Output.Create(Vultr.GetObjectStorage.InvokeAsync(new Vultr.GetObjectStorageArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetObjectStorageFilterArgs
        ///                 {
        ///                     Name = "label",
        ///                     Values = 
        ///                     {
        ///                         "my-s3",
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
        public static Output<GetObjectStorageResult> Invoke(GetObjectStorageInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetObjectStorageResult>("vultr:index/getObjectStorage:getObjectStorage", args ?? new GetObjectStorageInvokeArgs(), options.WithVersion());
    }


    public sealed class GetObjectStorageArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetObjectStorageFilterArgs>? _filters;

        /// <summary>
        /// Query parameters for finding operating systems.
        /// </summary>
        public List<Inputs.GetObjectStorageFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetObjectStorageFilterArgs>());
            set => _filters = value;
        }

        public GetObjectStorageArgs()
        {
        }
    }

    public sealed class GetObjectStorageInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetObjectStorageFilterInputArgs>? _filters;

        /// <summary>
        /// Query parameters for finding operating systems.
        /// </summary>
        public InputList<Inputs.GetObjectStorageFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetObjectStorageFilterInputArgs>());
            set => _filters = value;
        }

        public GetObjectStorageInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetObjectStorageResult
    {
        /// <summary>
        /// The identifying cluster ID.
        /// </summary>
        public readonly int ClusterId;
        /// <summary>
        /// Date of creation for the object storage subscription.
        /// </summary>
        public readonly string DateCreated;
        public readonly ImmutableArray<Outputs.GetObjectStorageFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The label of the object storage subscription.
        /// </summary>
        public readonly string Label;
        /// <summary>
        /// The location which this subscription resides in.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The region ID of the object storage subscription.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Your access key.
        /// </summary>
        public readonly string S3AccessKey;
        /// <summary>
        /// The hostname for this subscription.
        /// </summary>
        public readonly string S3Hostname;
        /// <summary>
        /// Your secret key.
        /// </summary>
        public readonly string S3SecretKey;
        /// <summary>
        /// Current status of this object storage subscription.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetObjectStorageResult(
            int clusterId,

            string dateCreated,

            ImmutableArray<Outputs.GetObjectStorageFilterResult> filters,

            string id,

            string label,

            string location,

            string region,

            string s3AccessKey,

            string s3Hostname,

            string s3SecretKey,

            string status)
        {
            ClusterId = clusterId;
            DateCreated = dateCreated;
            Filters = filters;
            Id = id;
            Label = label;
            Location = location;
            Region = region;
            S3AccessKey = s3AccessKey;
            S3Hostname = s3Hostname;
            S3SecretKey = s3SecretKey;
            Status = status;
        }
    }
}
