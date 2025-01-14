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
    public static class GetUser
    {
        /// <summary>
        /// Get information about a Vultr user associated with your account. This data source provides the name, email, access control list, and API status for a Vultr user associated with your account.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for a user by `email`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myUser = Output.Create(Vultr.GetUser.InvokeAsync(new Vultr.GetUserArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetUserFilterArgs
        ///                 {
        ///                     Name = "email",
        ///                     Values = 
        ///                     {
        ///                         "jdoe@example.com",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// Get the information for a user by `name`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myUser = Output.Create(Vultr.GetUser.InvokeAsync(new Vultr.GetUserArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetUserFilterArgs
        ///                 {
        ///                     Name = "name",
        ///                     Values = 
        ///                     {
        ///                         "John Doe",
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
        public static Task<GetUserResult> InvokeAsync(GetUserArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetUserResult>("vultr:index/getUser:getUser", args ?? new GetUserArgs(), options.WithVersion());

        /// <summary>
        /// Get information about a Vultr user associated with your account. This data source provides the name, email, access control list, and API status for a Vultr user associated with your account.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for a user by `email`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myUser = Output.Create(Vultr.GetUser.InvokeAsync(new Vultr.GetUserArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetUserFilterArgs
        ///                 {
        ///                     Name = "email",
        ///                     Values = 
        ///                     {
        ///                         "jdoe@example.com",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// 
        /// Get the information for a user by `name`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myUser = Output.Create(Vultr.GetUser.InvokeAsync(new Vultr.GetUserArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetUserFilterArgs
        ///                 {
        ///                     Name = "name",
        ///                     Values = 
        ///                     {
        ///                         "John Doe",
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
        public static Output<GetUserResult> Invoke(GetUserInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetUserResult>("vultr:index/getUser:getUser", args ?? new GetUserInvokeArgs(), options.WithVersion());
    }


    public sealed class GetUserArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetUserFilterArgs>? _filters;

        /// <summary>
        /// Query parameters for finding users.
        /// </summary>
        public List<Inputs.GetUserFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetUserFilterArgs>());
            set => _filters = value;
        }

        public GetUserArgs()
        {
        }
    }

    public sealed class GetUserInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetUserFilterInputArgs>? _filters;

        /// <summary>
        /// Query parameters for finding users.
        /// </summary>
        public InputList<Inputs.GetUserFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetUserFilterInputArgs>());
            set => _filters = value;
        }

        public GetUserInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetUserResult
    {
        /// <summary>
        /// The access control list for the user.
        /// </summary>
        public readonly ImmutableArray<string> Acls;
        /// <summary>
        /// Whether API is enabled for the user.
        /// </summary>
        public readonly bool ApiEnabled;
        /// <summary>
        /// The email of the user.
        /// </summary>
        public readonly string Email;
        public readonly ImmutableArray<Outputs.GetUserFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the user.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetUserResult(
            ImmutableArray<string> acls,

            bool apiEnabled,

            string email,

            ImmutableArray<Outputs.GetUserFilterResult> filters,

            string id,

            string name)
        {
            Acls = acls;
            ApiEnabled = apiEnabled;
            Email = email;
            Filters = filters;
            Id = id;
            Name = name;
        }
    }
}
