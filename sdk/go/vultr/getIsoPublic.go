// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package vultr

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about an ISO file offered in the Vultr ISO library.
//
// ## Example Usage
//
// Get the information for a ISO file by `description`:
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
// 		_, err := vultr.GetIsoPublic(ctx, &GetIsoPublicArgs{
// 			Filters: []GetIsoPublicFilter{
// 				GetIsoPublicFilter{
// 					Name: "description",
// 					Values: []string{
// 						"iso-description",
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
func GetIsoPublic(ctx *pulumi.Context, args *GetIsoPublicArgs, opts ...pulumi.InvokeOption) (*GetIsoPublicResult, error) {
	var rv GetIsoPublicResult
	err := ctx.Invoke("vultr:index/getIsoPublic:getIsoPublic", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIsoPublic.
type GetIsoPublicArgs struct {
	// Query parameters for finding ISO files.
	Filters []GetIsoPublicFilter `pulumi:"filters"`
}

// A collection of values returned by getIsoPublic.
type GetIsoPublicResult struct {
	// The description of the ISO file.
	Description string               `pulumi:"description"`
	Filters     []GetIsoPublicFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The MD5Sum of the ISO file.
	Md5sum string `pulumi:"md5sum"`
	// The ISO file's name.
	Name string `pulumi:"name"`
}

func GetIsoPublicOutput(ctx *pulumi.Context, args GetIsoPublicOutputArgs, opts ...pulumi.InvokeOption) GetIsoPublicResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetIsoPublicResult, error) {
			args := v.(GetIsoPublicArgs)
			r, err := GetIsoPublic(ctx, &args, opts...)
			var s GetIsoPublicResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetIsoPublicResultOutput)
}

// A collection of arguments for invoking getIsoPublic.
type GetIsoPublicOutputArgs struct {
	// Query parameters for finding ISO files.
	Filters GetIsoPublicFilterArrayInput `pulumi:"filters"`
}

func (GetIsoPublicOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIsoPublicArgs)(nil)).Elem()
}

// A collection of values returned by getIsoPublic.
type GetIsoPublicResultOutput struct{ *pulumi.OutputState }

func (GetIsoPublicResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetIsoPublicResult)(nil)).Elem()
}

func (o GetIsoPublicResultOutput) ToGetIsoPublicResultOutput() GetIsoPublicResultOutput {
	return o
}

func (o GetIsoPublicResultOutput) ToGetIsoPublicResultOutputWithContext(ctx context.Context) GetIsoPublicResultOutput {
	return o
}

// The description of the ISO file.
func (o GetIsoPublicResultOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v GetIsoPublicResult) string { return v.Description }).(pulumi.StringOutput)
}

func (o GetIsoPublicResultOutput) Filters() GetIsoPublicFilterArrayOutput {
	return o.ApplyT(func(v GetIsoPublicResult) []GetIsoPublicFilter { return v.Filters }).(GetIsoPublicFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetIsoPublicResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetIsoPublicResult) string { return v.Id }).(pulumi.StringOutput)
}

// The MD5Sum of the ISO file.
func (o GetIsoPublicResultOutput) Md5sum() pulumi.StringOutput {
	return o.ApplyT(func(v GetIsoPublicResult) string { return v.Md5sum }).(pulumi.StringOutput)
}

// The ISO file's name.
func (o GetIsoPublicResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetIsoPublicResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetIsoPublicResultOutput{})
}
