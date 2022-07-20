// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Vultr.Inputs
{

    public sealed class LoadBalancerSslGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The SSL Certificate.
        /// </summary>
        [Input("certificate", required: true)]
        public Input<string> Certificate { get; set; } = null!;

        /// <summary>
        /// The SSL certificate chain.
        /// </summary>
        [Input("chain")]
        public Input<string>? Chain { get; set; }

        /// <summary>
        /// The SSL certificates private key.
        /// </summary>
        [Input("privateKey", required: true)]
        public Input<string> PrivateKey { get; set; } = null!;

        public LoadBalancerSslGetArgs()
        {
        }
    }
}
