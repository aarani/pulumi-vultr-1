// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vultr

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Vultr private network.
//
// ## Example Usage
//
// Get the information for a private network by `description`:
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-vultr/sdk/go/vultr"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := vultr.LookupPrivateNetwork(ctx, &GetPrivateNetworkArgs{
// 			Filters: []GetPrivateNetworkFilter{
// 				GetPrivateNetworkFilter{
// 					Name: "description",
// 					Values: []string{
// 						"my-network-description",
// 					},
// 				},
// 			},
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupPrivateNetwork(ctx *pulumi.Context, args *LookupPrivateNetworkArgs, opts ...pulumi.InvokeOption) (*LookupPrivateNetworkResult, error) {
	var rv LookupPrivateNetworkResult
	err := ctx.Invoke("vultr:index/getPrivateNetwork:getPrivateNetwork", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPrivateNetwork.
type LookupPrivateNetworkArgs struct {
	// Query parameters for finding private networks.
	Filters []GetPrivateNetworkFilter `pulumi:"filters"`
}

// A collection of values returned by getPrivateNetwork.
type LookupPrivateNetworkResult struct {
	// The date the private network was added to your Vultr account.
	DateCreated string `pulumi:"dateCreated"`
	// The private network's description.
	Description string                    `pulumi:"description"`
	Filters     []GetPrivateNetworkFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The ID of the region that the private network is in.
	Region string `pulumi:"region"`
	// The IPv4 network address. For example: 10.1.1.0.
	V4Subnet string `pulumi:"v4Subnet"`
	// The number of bits for the netmask in CIDR notation. Example: 20
	V4SubnetMask int `pulumi:"v4SubnetMask"`
}

func LookupPrivateNetworkOutput(ctx *pulumi.Context, args LookupPrivateNetworkOutputArgs, opts ...pulumi.InvokeOption) LookupPrivateNetworkResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupPrivateNetworkResult, error) {
			args := v.(LookupPrivateNetworkArgs)
			r, err := LookupPrivateNetwork(ctx, &args, opts...)
			var s LookupPrivateNetworkResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupPrivateNetworkResultOutput)
}

// A collection of arguments for invoking getPrivateNetwork.
type LookupPrivateNetworkOutputArgs struct {
	// Query parameters for finding private networks.
	Filters GetPrivateNetworkFilterArrayInput `pulumi:"filters"`
}

func (LookupPrivateNetworkOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPrivateNetworkArgs)(nil)).Elem()
}

// A collection of values returned by getPrivateNetwork.
type LookupPrivateNetworkResultOutput struct{ *pulumi.OutputState }

func (LookupPrivateNetworkResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPrivateNetworkResult)(nil)).Elem()
}

func (o LookupPrivateNetworkResultOutput) ToLookupPrivateNetworkResultOutput() LookupPrivateNetworkResultOutput {
	return o
}

func (o LookupPrivateNetworkResultOutput) ToLookupPrivateNetworkResultOutputWithContext(ctx context.Context) LookupPrivateNetworkResultOutput {
	return o
}

// The date the private network was added to your Vultr account.
func (o LookupPrivateNetworkResultOutput) DateCreated() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) string { return v.DateCreated }).(pulumi.StringOutput)
}

// The private network's description.
func (o LookupPrivateNetworkResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o LookupPrivateNetworkResultOutput) Filters() GetPrivateNetworkFilterArrayOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) []GetPrivateNetworkFilter { return v.Filters }).(GetPrivateNetworkFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupPrivateNetworkResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) string { return v.Id }).(pulumi.StringOutput)
}

// The ID of the region that the private network is in.
func (o LookupPrivateNetworkResultOutput) Region() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) string { return v.Region }).(pulumi.StringOutput)
}

// The IPv4 network address. For example: 10.1.1.0.
func (o LookupPrivateNetworkResultOutput) V4Subnet() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) string { return v.V4Subnet }).(pulumi.StringOutput)
}

// The number of bits for the netmask in CIDR notation. Example: 20
func (o LookupPrivateNetworkResultOutput) V4SubnetMask() pulumi.IntOutput {
	return o.ApplyT(func(v LookupPrivateNetworkResult) int { return v.V4SubnetMask }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupPrivateNetworkResultOutput{})
}
