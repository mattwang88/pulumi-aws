// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package workspaces

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type DirectorySelfServicePermissions struct {
	// Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default `false`.
	ChangeComputeType *bool `pulumi:"changeComputeType"`
	// Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default `false`.
	IncreaseVolumeSize *bool `pulumi:"increaseVolumeSize"`
	// Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default `false`.
	RebuildWorkspace *bool `pulumi:"rebuildWorkspace"`
	// Whether WorkSpaces directory users can restart their workspace. Default `true`.
	RestartWorkspace *bool `pulumi:"restartWorkspace"`
	// Whether WorkSpaces directory users can switch the running mode of their workspace. Default `false`.
	SwitchRunningMode *bool `pulumi:"switchRunningMode"`
}

type DirectorySelfServicePermissionsInput interface {
	pulumi.Input

	ToDirectorySelfServicePermissionsOutput() DirectorySelfServicePermissionsOutput
	ToDirectorySelfServicePermissionsOutputWithContext(context.Context) DirectorySelfServicePermissionsOutput
}

type DirectorySelfServicePermissionsArgs struct {
	// Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default `false`.
	ChangeComputeType pulumi.BoolPtrInput `pulumi:"changeComputeType"`
	// Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default `false`.
	IncreaseVolumeSize pulumi.BoolPtrInput `pulumi:"increaseVolumeSize"`
	// Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default `false`.
	RebuildWorkspace pulumi.BoolPtrInput `pulumi:"rebuildWorkspace"`
	// Whether WorkSpaces directory users can restart their workspace. Default `true`.
	RestartWorkspace pulumi.BoolPtrInput `pulumi:"restartWorkspace"`
	// Whether WorkSpaces directory users can switch the running mode of their workspace. Default `false`.
	SwitchRunningMode pulumi.BoolPtrInput `pulumi:"switchRunningMode"`
}

func (DirectorySelfServicePermissionsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectorySelfServicePermissions)(nil)).Elem()
}

func (i DirectorySelfServicePermissionsArgs) ToDirectorySelfServicePermissionsOutput() DirectorySelfServicePermissionsOutput {
	return i.ToDirectorySelfServicePermissionsOutputWithContext(context.Background())
}

func (i DirectorySelfServicePermissionsArgs) ToDirectorySelfServicePermissionsOutputWithContext(ctx context.Context) DirectorySelfServicePermissionsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectorySelfServicePermissionsOutput)
}

func (i DirectorySelfServicePermissionsArgs) ToDirectorySelfServicePermissionsPtrOutput() DirectorySelfServicePermissionsPtrOutput {
	return i.ToDirectorySelfServicePermissionsPtrOutputWithContext(context.Background())
}

func (i DirectorySelfServicePermissionsArgs) ToDirectorySelfServicePermissionsPtrOutputWithContext(ctx context.Context) DirectorySelfServicePermissionsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectorySelfServicePermissionsOutput).ToDirectorySelfServicePermissionsPtrOutputWithContext(ctx)
}

type DirectorySelfServicePermissionsPtrInput interface {
	pulumi.Input

	ToDirectorySelfServicePermissionsPtrOutput() DirectorySelfServicePermissionsPtrOutput
	ToDirectorySelfServicePermissionsPtrOutputWithContext(context.Context) DirectorySelfServicePermissionsPtrOutput
}

type directorySelfServicePermissionsPtrType DirectorySelfServicePermissionsArgs

func DirectorySelfServicePermissionsPtr(v *DirectorySelfServicePermissionsArgs) DirectorySelfServicePermissionsPtrInput {
	return (*directorySelfServicePermissionsPtrType)(v)
}

func (*directorySelfServicePermissionsPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectorySelfServicePermissions)(nil)).Elem()
}

func (i *directorySelfServicePermissionsPtrType) ToDirectorySelfServicePermissionsPtrOutput() DirectorySelfServicePermissionsPtrOutput {
	return i.ToDirectorySelfServicePermissionsPtrOutputWithContext(context.Background())
}

func (i *directorySelfServicePermissionsPtrType) ToDirectorySelfServicePermissionsPtrOutputWithContext(ctx context.Context) DirectorySelfServicePermissionsPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DirectorySelfServicePermissionsPtrOutput)
}

type DirectorySelfServicePermissionsOutput struct{ *pulumi.OutputState }

func (DirectorySelfServicePermissionsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*DirectorySelfServicePermissions)(nil)).Elem()
}

func (o DirectorySelfServicePermissionsOutput) ToDirectorySelfServicePermissionsOutput() DirectorySelfServicePermissionsOutput {
	return o
}

func (o DirectorySelfServicePermissionsOutput) ToDirectorySelfServicePermissionsOutputWithContext(ctx context.Context) DirectorySelfServicePermissionsOutput {
	return o
}

func (o DirectorySelfServicePermissionsOutput) ToDirectorySelfServicePermissionsPtrOutput() DirectorySelfServicePermissionsPtrOutput {
	return o.ToDirectorySelfServicePermissionsPtrOutputWithContext(context.Background())
}

func (o DirectorySelfServicePermissionsOutput) ToDirectorySelfServicePermissionsPtrOutputWithContext(ctx context.Context) DirectorySelfServicePermissionsPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *DirectorySelfServicePermissions {
		return &v
	}).(DirectorySelfServicePermissionsPtrOutput)
}

// Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default `false`.
func (o DirectorySelfServicePermissionsOutput) ChangeComputeType() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.ChangeComputeType }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default `false`.
func (o DirectorySelfServicePermissionsOutput) IncreaseVolumeSize() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.IncreaseVolumeSize }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default `false`.
func (o DirectorySelfServicePermissionsOutput) RebuildWorkspace() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.RebuildWorkspace }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can restart their workspace. Default `true`.
func (o DirectorySelfServicePermissionsOutput) RestartWorkspace() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.RestartWorkspace }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can switch the running mode of their workspace. Default `false`.
func (o DirectorySelfServicePermissionsOutput) SwitchRunningMode() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.SwitchRunningMode }).(pulumi.BoolPtrOutput)
}

type DirectorySelfServicePermissionsPtrOutput struct{ *pulumi.OutputState }

func (DirectorySelfServicePermissionsPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DirectorySelfServicePermissions)(nil)).Elem()
}

func (o DirectorySelfServicePermissionsPtrOutput) ToDirectorySelfServicePermissionsPtrOutput() DirectorySelfServicePermissionsPtrOutput {
	return o
}

func (o DirectorySelfServicePermissionsPtrOutput) ToDirectorySelfServicePermissionsPtrOutputWithContext(ctx context.Context) DirectorySelfServicePermissionsPtrOutput {
	return o
}

func (o DirectorySelfServicePermissionsPtrOutput) Elem() DirectorySelfServicePermissionsOutput {
	return o.ApplyT(func(v *DirectorySelfServicePermissions) DirectorySelfServicePermissions { return *v }).(DirectorySelfServicePermissionsOutput)
}

// Whether WorkSpaces directory users can change the compute type (bundle) for their workspace. Default `false`.
func (o DirectorySelfServicePermissionsPtrOutput) ChangeComputeType() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.ChangeComputeType }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can increase the volume size of the drives on their workspace. Default `false`.
func (o DirectorySelfServicePermissionsPtrOutput) IncreaseVolumeSize() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.IncreaseVolumeSize }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can rebuild the operating system of a workspace to its original state. Default `false`.
func (o DirectorySelfServicePermissionsPtrOutput) RebuildWorkspace() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.RebuildWorkspace }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can restart their workspace. Default `true`.
func (o DirectorySelfServicePermissionsPtrOutput) RestartWorkspace() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.RestartWorkspace }).(pulumi.BoolPtrOutput)
}

// Whether WorkSpaces directory users can switch the running mode of their workspace. Default `false`.
func (o DirectorySelfServicePermissionsPtrOutput) SwitchRunningMode() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v DirectorySelfServicePermissions) *bool { return v.SwitchRunningMode }).(pulumi.BoolPtrOutput)
}

type IpGroupRule struct {
	// The description.
	Description *string `pulumi:"description"`
	// The IP address range, in CIDR notation, e.g. `10.0.0.0/16`
	Source string `pulumi:"source"`
}

type IpGroupRuleInput interface {
	pulumi.Input

	ToIpGroupRuleOutput() IpGroupRuleOutput
	ToIpGroupRuleOutputWithContext(context.Context) IpGroupRuleOutput
}

type IpGroupRuleArgs struct {
	// The description.
	Description pulumi.StringPtrInput `pulumi:"description"`
	// The IP address range, in CIDR notation, e.g. `10.0.0.0/16`
	Source pulumi.StringInput `pulumi:"source"`
}

func (IpGroupRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*IpGroupRule)(nil)).Elem()
}

func (i IpGroupRuleArgs) ToIpGroupRuleOutput() IpGroupRuleOutput {
	return i.ToIpGroupRuleOutputWithContext(context.Background())
}

func (i IpGroupRuleArgs) ToIpGroupRuleOutputWithContext(ctx context.Context) IpGroupRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpGroupRuleOutput)
}

type IpGroupRuleArrayInput interface {
	pulumi.Input

	ToIpGroupRuleArrayOutput() IpGroupRuleArrayOutput
	ToIpGroupRuleArrayOutputWithContext(context.Context) IpGroupRuleArrayOutput
}

type IpGroupRuleArray []IpGroupRuleInput

func (IpGroupRuleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]IpGroupRule)(nil)).Elem()
}

func (i IpGroupRuleArray) ToIpGroupRuleArrayOutput() IpGroupRuleArrayOutput {
	return i.ToIpGroupRuleArrayOutputWithContext(context.Background())
}

func (i IpGroupRuleArray) ToIpGroupRuleArrayOutputWithContext(ctx context.Context) IpGroupRuleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpGroupRuleArrayOutput)
}

type IpGroupRuleOutput struct{ *pulumi.OutputState }

func (IpGroupRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*IpGroupRule)(nil)).Elem()
}

func (o IpGroupRuleOutput) ToIpGroupRuleOutput() IpGroupRuleOutput {
	return o
}

func (o IpGroupRuleOutput) ToIpGroupRuleOutputWithContext(ctx context.Context) IpGroupRuleOutput {
	return o
}

// The description.
func (o IpGroupRuleOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v IpGroupRule) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// The IP address range, in CIDR notation, e.g. `10.0.0.0/16`
func (o IpGroupRuleOutput) Source() pulumi.StringOutput {
	return o.ApplyT(func(v IpGroupRule) string { return v.Source }).(pulumi.StringOutput)
}

type IpGroupRuleArrayOutput struct{ *pulumi.OutputState }

func (IpGroupRuleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]IpGroupRule)(nil)).Elem()
}

func (o IpGroupRuleArrayOutput) ToIpGroupRuleArrayOutput() IpGroupRuleArrayOutput {
	return o
}

func (o IpGroupRuleArrayOutput) ToIpGroupRuleArrayOutputWithContext(ctx context.Context) IpGroupRuleArrayOutput {
	return o
}

func (o IpGroupRuleArrayOutput) Index(i pulumi.IntInput) IpGroupRuleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) IpGroupRule {
		return vs[0].([]IpGroupRule)[vs[1].(int)]
	}).(IpGroupRuleOutput)
}

type GetBundleComputeType struct {
	// The name of the compute type.
	Name string `pulumi:"name"`
}

type GetBundleComputeTypeInput interface {
	pulumi.Input

	ToGetBundleComputeTypeOutput() GetBundleComputeTypeOutput
	ToGetBundleComputeTypeOutputWithContext(context.Context) GetBundleComputeTypeOutput
}

type GetBundleComputeTypeArgs struct {
	// The name of the compute type.
	Name pulumi.StringInput `pulumi:"name"`
}

func (GetBundleComputeTypeArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBundleComputeType)(nil)).Elem()
}

func (i GetBundleComputeTypeArgs) ToGetBundleComputeTypeOutput() GetBundleComputeTypeOutput {
	return i.ToGetBundleComputeTypeOutputWithContext(context.Background())
}

func (i GetBundleComputeTypeArgs) ToGetBundleComputeTypeOutputWithContext(ctx context.Context) GetBundleComputeTypeOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetBundleComputeTypeOutput)
}

type GetBundleComputeTypeArrayInput interface {
	pulumi.Input

	ToGetBundleComputeTypeArrayOutput() GetBundleComputeTypeArrayOutput
	ToGetBundleComputeTypeArrayOutputWithContext(context.Context) GetBundleComputeTypeArrayOutput
}

type GetBundleComputeTypeArray []GetBundleComputeTypeInput

func (GetBundleComputeTypeArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetBundleComputeType)(nil)).Elem()
}

func (i GetBundleComputeTypeArray) ToGetBundleComputeTypeArrayOutput() GetBundleComputeTypeArrayOutput {
	return i.ToGetBundleComputeTypeArrayOutputWithContext(context.Background())
}

func (i GetBundleComputeTypeArray) ToGetBundleComputeTypeArrayOutputWithContext(ctx context.Context) GetBundleComputeTypeArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetBundleComputeTypeArrayOutput)
}

type GetBundleComputeTypeOutput struct{ *pulumi.OutputState }

func (GetBundleComputeTypeOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBundleComputeType)(nil)).Elem()
}

func (o GetBundleComputeTypeOutput) ToGetBundleComputeTypeOutput() GetBundleComputeTypeOutput {
	return o
}

func (o GetBundleComputeTypeOutput) ToGetBundleComputeTypeOutputWithContext(ctx context.Context) GetBundleComputeTypeOutput {
	return o
}

// The name of the compute type.
func (o GetBundleComputeTypeOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetBundleComputeType) string { return v.Name }).(pulumi.StringOutput)
}

type GetBundleComputeTypeArrayOutput struct{ *pulumi.OutputState }

func (GetBundleComputeTypeArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetBundleComputeType)(nil)).Elem()
}

func (o GetBundleComputeTypeArrayOutput) ToGetBundleComputeTypeArrayOutput() GetBundleComputeTypeArrayOutput {
	return o
}

func (o GetBundleComputeTypeArrayOutput) ToGetBundleComputeTypeArrayOutputWithContext(ctx context.Context) GetBundleComputeTypeArrayOutput {
	return o
}

func (o GetBundleComputeTypeArrayOutput) Index(i pulumi.IntInput) GetBundleComputeTypeOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetBundleComputeType {
		return vs[0].([]GetBundleComputeType)[vs[1].(int)]
	}).(GetBundleComputeTypeOutput)
}

type GetBundleRootStorage struct {
	// The size of the user storage.
	Capacity string `pulumi:"capacity"`
}

type GetBundleRootStorageInput interface {
	pulumi.Input

	ToGetBundleRootStorageOutput() GetBundleRootStorageOutput
	ToGetBundleRootStorageOutputWithContext(context.Context) GetBundleRootStorageOutput
}

type GetBundleRootStorageArgs struct {
	// The size of the user storage.
	Capacity pulumi.StringInput `pulumi:"capacity"`
}

func (GetBundleRootStorageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBundleRootStorage)(nil)).Elem()
}

func (i GetBundleRootStorageArgs) ToGetBundleRootStorageOutput() GetBundleRootStorageOutput {
	return i.ToGetBundleRootStorageOutputWithContext(context.Background())
}

func (i GetBundleRootStorageArgs) ToGetBundleRootStorageOutputWithContext(ctx context.Context) GetBundleRootStorageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetBundleRootStorageOutput)
}

type GetBundleRootStorageArrayInput interface {
	pulumi.Input

	ToGetBundleRootStorageArrayOutput() GetBundleRootStorageArrayOutput
	ToGetBundleRootStorageArrayOutputWithContext(context.Context) GetBundleRootStorageArrayOutput
}

type GetBundleRootStorageArray []GetBundleRootStorageInput

func (GetBundleRootStorageArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetBundleRootStorage)(nil)).Elem()
}

func (i GetBundleRootStorageArray) ToGetBundleRootStorageArrayOutput() GetBundleRootStorageArrayOutput {
	return i.ToGetBundleRootStorageArrayOutputWithContext(context.Background())
}

func (i GetBundleRootStorageArray) ToGetBundleRootStorageArrayOutputWithContext(ctx context.Context) GetBundleRootStorageArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetBundleRootStorageArrayOutput)
}

type GetBundleRootStorageOutput struct{ *pulumi.OutputState }

func (GetBundleRootStorageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBundleRootStorage)(nil)).Elem()
}

func (o GetBundleRootStorageOutput) ToGetBundleRootStorageOutput() GetBundleRootStorageOutput {
	return o
}

func (o GetBundleRootStorageOutput) ToGetBundleRootStorageOutputWithContext(ctx context.Context) GetBundleRootStorageOutput {
	return o
}

// The size of the user storage.
func (o GetBundleRootStorageOutput) Capacity() pulumi.StringOutput {
	return o.ApplyT(func(v GetBundleRootStorage) string { return v.Capacity }).(pulumi.StringOutput)
}

type GetBundleRootStorageArrayOutput struct{ *pulumi.OutputState }

func (GetBundleRootStorageArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetBundleRootStorage)(nil)).Elem()
}

func (o GetBundleRootStorageArrayOutput) ToGetBundleRootStorageArrayOutput() GetBundleRootStorageArrayOutput {
	return o
}

func (o GetBundleRootStorageArrayOutput) ToGetBundleRootStorageArrayOutputWithContext(ctx context.Context) GetBundleRootStorageArrayOutput {
	return o
}

func (o GetBundleRootStorageArrayOutput) Index(i pulumi.IntInput) GetBundleRootStorageOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetBundleRootStorage {
		return vs[0].([]GetBundleRootStorage)[vs[1].(int)]
	}).(GetBundleRootStorageOutput)
}

type GetBundleUserStorage struct {
	// The size of the user storage.
	Capacity string `pulumi:"capacity"`
}

type GetBundleUserStorageInput interface {
	pulumi.Input

	ToGetBundleUserStorageOutput() GetBundleUserStorageOutput
	ToGetBundleUserStorageOutputWithContext(context.Context) GetBundleUserStorageOutput
}

type GetBundleUserStorageArgs struct {
	// The size of the user storage.
	Capacity pulumi.StringInput `pulumi:"capacity"`
}

func (GetBundleUserStorageArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBundleUserStorage)(nil)).Elem()
}

func (i GetBundleUserStorageArgs) ToGetBundleUserStorageOutput() GetBundleUserStorageOutput {
	return i.ToGetBundleUserStorageOutputWithContext(context.Background())
}

func (i GetBundleUserStorageArgs) ToGetBundleUserStorageOutputWithContext(ctx context.Context) GetBundleUserStorageOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetBundleUserStorageOutput)
}

type GetBundleUserStorageArrayInput interface {
	pulumi.Input

	ToGetBundleUserStorageArrayOutput() GetBundleUserStorageArrayOutput
	ToGetBundleUserStorageArrayOutputWithContext(context.Context) GetBundleUserStorageArrayOutput
}

type GetBundleUserStorageArray []GetBundleUserStorageInput

func (GetBundleUserStorageArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetBundleUserStorage)(nil)).Elem()
}

func (i GetBundleUserStorageArray) ToGetBundleUserStorageArrayOutput() GetBundleUserStorageArrayOutput {
	return i.ToGetBundleUserStorageArrayOutputWithContext(context.Background())
}

func (i GetBundleUserStorageArray) ToGetBundleUserStorageArrayOutputWithContext(ctx context.Context) GetBundleUserStorageArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(GetBundleUserStorageArrayOutput)
}

type GetBundleUserStorageOutput struct{ *pulumi.OutputState }

func (GetBundleUserStorageOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBundleUserStorage)(nil)).Elem()
}

func (o GetBundleUserStorageOutput) ToGetBundleUserStorageOutput() GetBundleUserStorageOutput {
	return o
}

func (o GetBundleUserStorageOutput) ToGetBundleUserStorageOutputWithContext(ctx context.Context) GetBundleUserStorageOutput {
	return o
}

// The size of the user storage.
func (o GetBundleUserStorageOutput) Capacity() pulumi.StringOutput {
	return o.ApplyT(func(v GetBundleUserStorage) string { return v.Capacity }).(pulumi.StringOutput)
}

type GetBundleUserStorageArrayOutput struct{ *pulumi.OutputState }

func (GetBundleUserStorageArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]GetBundleUserStorage)(nil)).Elem()
}

func (o GetBundleUserStorageArrayOutput) ToGetBundleUserStorageArrayOutput() GetBundleUserStorageArrayOutput {
	return o
}

func (o GetBundleUserStorageArrayOutput) ToGetBundleUserStorageArrayOutputWithContext(ctx context.Context) GetBundleUserStorageArrayOutput {
	return o
}

func (o GetBundleUserStorageArrayOutput) Index(i pulumi.IntInput) GetBundleUserStorageOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) GetBundleUserStorage {
		return vs[0].([]GetBundleUserStorage)[vs[1].(int)]
	}).(GetBundleUserStorageOutput)
}

func init() {
	pulumi.RegisterOutputType(DirectorySelfServicePermissionsOutput{})
	pulumi.RegisterOutputType(DirectorySelfServicePermissionsPtrOutput{})
	pulumi.RegisterOutputType(IpGroupRuleOutput{})
	pulumi.RegisterOutputType(IpGroupRuleArrayOutput{})
	pulumi.RegisterOutputType(GetBundleComputeTypeOutput{})
	pulumi.RegisterOutputType(GetBundleComputeTypeArrayOutput{})
	pulumi.RegisterOutputType(GetBundleRootStorageOutput{})
	pulumi.RegisterOutputType(GetBundleRootStorageArrayOutput{})
	pulumi.RegisterOutputType(GetBundleUserStorageOutput{})
	pulumi.RegisterOutputType(GetBundleUserStorageArrayOutput{})
}
