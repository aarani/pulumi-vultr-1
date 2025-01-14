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
    public static class GetStartupScript
    {
        /// <summary>
        /// Get information about a Vultr startup script. This data source provides the name, script, type, creation date, and the last modification date for your Vultr startup script.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for a startup script by `name`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myStartupScript = Output.Create(Vultr.GetStartupScript.InvokeAsync(new Vultr.GetStartupScriptArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetStartupScriptFilterArgs
        ///                 {
        ///                     Name = "name",
        ///                     Values = 
        ///                     {
        ///                         "my-startup-script-name",
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
        public static Task<GetStartupScriptResult> InvokeAsync(GetStartupScriptArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetStartupScriptResult>("vultr:index/getStartupScript:getStartupScript", args ?? new GetStartupScriptArgs(), options.WithVersion());

        /// <summary>
        /// Get information about a Vultr startup script. This data source provides the name, script, type, creation date, and the last modification date for your Vultr startup script.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// Get the information for a startup script by `name`:
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Vultr = Pulumi.Vultr;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var myStartupScript = Output.Create(Vultr.GetStartupScript.InvokeAsync(new Vultr.GetStartupScriptArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Vultr.Inputs.GetStartupScriptFilterArgs
        ///                 {
        ///                     Name = "name",
        ///                     Values = 
        ///                     {
        ///                         "my-startup-script-name",
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
        public static Output<GetStartupScriptResult> Invoke(GetStartupScriptInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetStartupScriptResult>("vultr:index/getStartupScript:getStartupScript", args ?? new GetStartupScriptInvokeArgs(), options.WithVersion());
    }


    public sealed class GetStartupScriptArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetStartupScriptFilterArgs>? _filters;

        /// <summary>
        /// Query parameters for finding startup scripts.
        /// </summary>
        public List<Inputs.GetStartupScriptFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetStartupScriptFilterArgs>());
            set => _filters = value;
        }

        public GetStartupScriptArgs()
        {
        }
    }

    public sealed class GetStartupScriptInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetStartupScriptFilterInputArgs>? _filters;

        /// <summary>
        /// Query parameters for finding startup scripts.
        /// </summary>
        public InputList<Inputs.GetStartupScriptFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetStartupScriptFilterInputArgs>());
            set => _filters = value;
        }

        public GetStartupScriptInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetStartupScriptResult
    {
        /// <summary>
        /// The date the startup script was added to your Vultr account.
        /// </summary>
        public readonly string DateCreated;
        /// <summary>
        /// The date the startup script was last modified.
        /// </summary>
        public readonly string DateModified;
        public readonly ImmutableArray<Outputs.GetStartupScriptFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The name of the startup script.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The contents of the startup script base64 encoded.
        /// </summary>
        public readonly string Script;
        /// <summary>
        /// The type of the startup script.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetStartupScriptResult(
            string dateCreated,

            string dateModified,

            ImmutableArray<Outputs.GetStartupScriptFilterResult> filters,

            string id,

            string name,

            string script,

            string type)
        {
            DateCreated = dateCreated;
            DateModified = dateModified;
            Filters = filters;
            Id = id;
            Name = name;
            Script = script;
            Type = type;
        }
    }
}
