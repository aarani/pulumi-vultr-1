// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package vultr

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Get information about a Vultr backup. This data source provides a list of backups which contain the description, size, status, and the creation date for your Vultr backup.
//
// ## Example Usage
//
// Get the information for a backup by `description`:
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
// 		_, err := vultr.GetBackup(ctx, &GetBackupArgs{
// 			Filters: []GetBackupFilter{
// 				GetBackupFilter{
// 					Name: "description",
// 					Values: []string{
// 						"my-backup-description",
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
func GetBackup(ctx *pulumi.Context, args *GetBackupArgs, opts ...pulumi.InvokeOption) (*GetBackupResult, error) {
	var rv GetBackupResult
	err := ctx.Invoke("vultr:index/getBackup:getBackup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackup.
type GetBackupArgs struct {
	// Query parameters for finding backups.
	Filters []GetBackupFilter `pulumi:"filters"`
}

// A collection of values returned by getBackup.
type GetBackupResult struct {
	Backups []map[string]interface{} `pulumi:"backups"`
	Filters []GetBackupFilter        `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
}

func GetBackupOutput(ctx *pulumi.Context, args GetBackupOutputArgs, opts ...pulumi.InvokeOption) GetBackupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBackupResult, error) {
			args := v.(GetBackupArgs)
			r, err := GetBackup(ctx, &args, opts...)
			return *r, err
		}).(GetBackupResultOutput)
}

// A collection of arguments for invoking getBackup.
type GetBackupOutputArgs struct {
	// Query parameters for finding backups.
	Filters GetBackupFilterArrayInput `pulumi:"filters"`
}

func (GetBackupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupArgs)(nil)).Elem()
}

// A collection of values returned by getBackup.
type GetBackupResultOutput struct{ *pulumi.OutputState }

func (GetBackupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupResult)(nil)).Elem()
}

func (o GetBackupResultOutput) ToGetBackupResultOutput() GetBackupResultOutput {
	return o
}

func (o GetBackupResultOutput) ToGetBackupResultOutputWithContext(ctx context.Context) GetBackupResultOutput {
	return o
}

func (o GetBackupResultOutput) Backups() pulumi.MapArrayOutput {
	return o.ApplyT(func(v GetBackupResult) []map[string]interface{} { return v.Backups }).(pulumi.MapArrayOutput)
}

func (o GetBackupResultOutput) Filters() GetBackupFilterArrayOutput {
	return o.ApplyT(func(v GetBackupResult) []GetBackupFilter { return v.Filters }).(GetBackupFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBackupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupResult) string { return v.Id }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBackupResultOutput{})
}