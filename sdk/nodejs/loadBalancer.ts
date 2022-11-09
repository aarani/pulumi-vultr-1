// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "./types";
import * as utilities from "./utilities";

/**
 * Get information about a Vultr load balancer.
 *
 * ## Example Usage
 *
 * Create a new load balancer:
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as vultr from "@pulumi/vultr";
 *
 * const lb = new vultr.LoadBalancer("lb", {
 *     balancingAlgorithm: "roundrobin",
 *     forwardingRules: [{
 *         backendPort: 81,
 *         backendProtocol: "http",
 *         frontendPort: 82,
 *         frontendProtocol: "http",
 *     }],
 *     healthCheck: {
 *         checkInterval: 3,
 *         healthyThreshold: 4,
 *         path: "/test",
 *         port: 8080,
 *         protocol: "http",
 *         responseTimeout: 1,
 *         unhealthyThreshold: 2,
 *     },
 *     label: "terraform lb example",
 *     region: "ewr",
 * });
 * ```
 *
 * ## Import
 *
 * Load Balancers can be imported using the load balancer `ID`, e.g.
 *
 * ```sh
 *  $ pulumi import vultr:index/loadBalancer:LoadBalancer lb b6a859c5-b299-49dd-8888-b1abbc517d08
 * ```
 */
export class LoadBalancer extends pulumi.CustomResource {
    /**
     * Get an existing LoadBalancer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LoadBalancerState, opts?: pulumi.CustomResourceOptions): LoadBalancer {
        return new LoadBalancer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'vultr:index/loadBalancer:LoadBalancer';

    /**
     * Returns true if the given object is an instance of LoadBalancer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LoadBalancer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LoadBalancer.__pulumiType;
    }

    /**
     * Array of instances that are currently attached to the load balancer.
     */
    public readonly attachedInstances!: pulumi.Output<string[]>;
    /**
     * The balancing algorithm for your load balancer. Options are `roundrobin` or `leastconn`. Default value is `roundrobin`
     */
    public readonly balancingAlgorithm!: pulumi.Output<string>;
    /**
     * Name for your given sticky session.
     */
    public readonly cookieName!: pulumi.Output<string | undefined>;
    /**
     * Defines the firewall rules for a load balancer.
     */
    public readonly firewallRules!: pulumi.Output<outputs.LoadBalancerFirewallRule[] | undefined>;
    /**
     * List of forwarding rules for a load balancer. The configuration of a `forwardingRules` is listened below.
     */
    public readonly forwardingRules!: pulumi.Output<outputs.LoadBalancerForwardingRule[]>;
    /**
     * Boolean value that indicates if SSL is enabled.
     */
    public /*out*/ readonly hasSsl!: pulumi.Output<boolean>;
    /**
     * A block that defines the way load balancers should check for health. The configuration of a `healthCheck` is listed below.
     */
    public readonly healthCheck!: pulumi.Output<outputs.LoadBalancerHealthCheck>;
    /**
     * IPv4 address for your load balancer.
     */
    public /*out*/ readonly ipv4!: pulumi.Output<string>;
    /**
     * IPv6 address for your load balancer.
     */
    public /*out*/ readonly ipv6!: pulumi.Output<string>;
    /**
     * The load balancer's label.
     */
    public readonly label!: pulumi.Output<string | undefined>;
    /**
     * A private network ID that the load balancer should be attached to.
     *
     * @deprecated private_network is deprecated and should no longer be used. Instead, use vpc
     */
    public readonly privateNetwork!: pulumi.Output<string | undefined>;
    /**
     * Boolean value that indicates if Proxy Protocol is enabled.
     */
    public readonly proxyProtocol!: pulumi.Output<boolean | undefined>;
    /**
     * The region your load balancer is deployed in.
     */
    public readonly region!: pulumi.Output<string>;
    /**
     * A block that supplies your ssl configuration to be used with HTTPS. The configuration of a `ssl` is listed below.
     */
    public readonly ssl!: pulumi.Output<outputs.LoadBalancerSsl | undefined>;
    /**
     * Boolean value that indicates if HTTP calls will be redirected to HTTPS.
     */
    public readonly sslRedirect!: pulumi.Output<boolean | undefined>;
    /**
     * Current status for the load balancer
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * A VPC ID that the load balancer should be attached to.
     */
    public readonly vpc!: pulumi.Output<string | undefined>;

    /**
     * Create a LoadBalancer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LoadBalancerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LoadBalancerArgs | LoadBalancerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LoadBalancerState | undefined;
            resourceInputs["attachedInstances"] = state ? state.attachedInstances : undefined;
            resourceInputs["balancingAlgorithm"] = state ? state.balancingAlgorithm : undefined;
            resourceInputs["cookieName"] = state ? state.cookieName : undefined;
            resourceInputs["firewallRules"] = state ? state.firewallRules : undefined;
            resourceInputs["forwardingRules"] = state ? state.forwardingRules : undefined;
            resourceInputs["hasSsl"] = state ? state.hasSsl : undefined;
            resourceInputs["healthCheck"] = state ? state.healthCheck : undefined;
            resourceInputs["ipv4"] = state ? state.ipv4 : undefined;
            resourceInputs["ipv6"] = state ? state.ipv6 : undefined;
            resourceInputs["label"] = state ? state.label : undefined;
            resourceInputs["privateNetwork"] = state ? state.privateNetwork : undefined;
            resourceInputs["proxyProtocol"] = state ? state.proxyProtocol : undefined;
            resourceInputs["region"] = state ? state.region : undefined;
            resourceInputs["ssl"] = state ? state.ssl : undefined;
            resourceInputs["sslRedirect"] = state ? state.sslRedirect : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["vpc"] = state ? state.vpc : undefined;
        } else {
            const args = argsOrState as LoadBalancerArgs | undefined;
            if ((!args || args.forwardingRules === undefined) && !opts.urn) {
                throw new Error("Missing required property 'forwardingRules'");
            }
            if ((!args || args.region === undefined) && !opts.urn) {
                throw new Error("Missing required property 'region'");
            }
            resourceInputs["attachedInstances"] = args ? args.attachedInstances : undefined;
            resourceInputs["balancingAlgorithm"] = args ? args.balancingAlgorithm : undefined;
            resourceInputs["cookieName"] = args ? args.cookieName : undefined;
            resourceInputs["firewallRules"] = args ? args.firewallRules : undefined;
            resourceInputs["forwardingRules"] = args ? args.forwardingRules : undefined;
            resourceInputs["healthCheck"] = args ? args.healthCheck : undefined;
            resourceInputs["label"] = args ? args.label : undefined;
            resourceInputs["privateNetwork"] = args ? args.privateNetwork : undefined;
            resourceInputs["proxyProtocol"] = args ? args.proxyProtocol : undefined;
            resourceInputs["region"] = args ? args.region : undefined;
            resourceInputs["ssl"] = args ? args.ssl : undefined;
            resourceInputs["sslRedirect"] = args ? args.sslRedirect : undefined;
            resourceInputs["vpc"] = args ? args.vpc : undefined;
            resourceInputs["hasSsl"] = undefined /*out*/;
            resourceInputs["ipv4"] = undefined /*out*/;
            resourceInputs["ipv6"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LoadBalancer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LoadBalancer resources.
 */
export interface LoadBalancerState {
    /**
     * Array of instances that are currently attached to the load balancer.
     */
    attachedInstances?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The balancing algorithm for your load balancer. Options are `roundrobin` or `leastconn`. Default value is `roundrobin`
     */
    balancingAlgorithm?: pulumi.Input<string>;
    /**
     * Name for your given sticky session.
     */
    cookieName?: pulumi.Input<string>;
    /**
     * Defines the firewall rules for a load balancer.
     */
    firewallRules?: pulumi.Input<pulumi.Input<inputs.LoadBalancerFirewallRule>[]>;
    /**
     * List of forwarding rules for a load balancer. The configuration of a `forwardingRules` is listened below.
     */
    forwardingRules?: pulumi.Input<pulumi.Input<inputs.LoadBalancerForwardingRule>[]>;
    /**
     * Boolean value that indicates if SSL is enabled.
     */
    hasSsl?: pulumi.Input<boolean>;
    /**
     * A block that defines the way load balancers should check for health. The configuration of a `healthCheck` is listed below.
     */
    healthCheck?: pulumi.Input<inputs.LoadBalancerHealthCheck>;
    /**
     * IPv4 address for your load balancer.
     */
    ipv4?: pulumi.Input<string>;
    /**
     * IPv6 address for your load balancer.
     */
    ipv6?: pulumi.Input<string>;
    /**
     * The load balancer's label.
     */
    label?: pulumi.Input<string>;
    /**
     * A private network ID that the load balancer should be attached to.
     *
     * @deprecated private_network is deprecated and should no longer be used. Instead, use vpc
     */
    privateNetwork?: pulumi.Input<string>;
    /**
     * Boolean value that indicates if Proxy Protocol is enabled.
     */
    proxyProtocol?: pulumi.Input<boolean>;
    /**
     * The region your load balancer is deployed in.
     */
    region?: pulumi.Input<string>;
    /**
     * A block that supplies your ssl configuration to be used with HTTPS. The configuration of a `ssl` is listed below.
     */
    ssl?: pulumi.Input<inputs.LoadBalancerSsl>;
    /**
     * Boolean value that indicates if HTTP calls will be redirected to HTTPS.
     */
    sslRedirect?: pulumi.Input<boolean>;
    /**
     * Current status for the load balancer
     */
    status?: pulumi.Input<string>;
    /**
     * A VPC ID that the load balancer should be attached to.
     */
    vpc?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LoadBalancer resource.
 */
export interface LoadBalancerArgs {
    /**
     * Array of instances that are currently attached to the load balancer.
     */
    attachedInstances?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The balancing algorithm for your load balancer. Options are `roundrobin` or `leastconn`. Default value is `roundrobin`
     */
    balancingAlgorithm?: pulumi.Input<string>;
    /**
     * Name for your given sticky session.
     */
    cookieName?: pulumi.Input<string>;
    /**
     * Defines the firewall rules for a load balancer.
     */
    firewallRules?: pulumi.Input<pulumi.Input<inputs.LoadBalancerFirewallRule>[]>;
    /**
     * List of forwarding rules for a load balancer. The configuration of a `forwardingRules` is listened below.
     */
    forwardingRules: pulumi.Input<pulumi.Input<inputs.LoadBalancerForwardingRule>[]>;
    /**
     * A block that defines the way load balancers should check for health. The configuration of a `healthCheck` is listed below.
     */
    healthCheck?: pulumi.Input<inputs.LoadBalancerHealthCheck>;
    /**
     * The load balancer's label.
     */
    label?: pulumi.Input<string>;
    /**
     * A private network ID that the load balancer should be attached to.
     *
     * @deprecated private_network is deprecated and should no longer be used. Instead, use vpc
     */
    privateNetwork?: pulumi.Input<string>;
    /**
     * Boolean value that indicates if Proxy Protocol is enabled.
     */
    proxyProtocol?: pulumi.Input<boolean>;
    /**
     * The region your load balancer is deployed in.
     */
    region: pulumi.Input<string>;
    /**
     * A block that supplies your ssl configuration to be used with HTTPS. The configuration of a `ssl` is listed below.
     */
    ssl?: pulumi.Input<inputs.LoadBalancerSsl>;
    /**
     * Boolean value that indicates if HTTP calls will be redirected to HTTPS.
     */
    sslRedirect?: pulumi.Input<boolean>;
    /**
     * A VPC ID that the load balancer should be attached to.
     */
    vpc?: pulumi.Input<string>;
}