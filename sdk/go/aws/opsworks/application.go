// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package opsworks

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides an OpsWorks application resource.
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/opsworks_application.html.markdown.
type Application struct {
	pulumi.CustomResourceState

	// SCM configuration of the app as described below.
	AppSources ApplicationAppSourceArrayOutput `pulumi:"appSources"`
	// Run bundle install when deploying for application of type `rails`.
	AutoBundleOnDeploy pulumi.StringPtrOutput `pulumi:"autoBundleOnDeploy"`
	// Specify activity and workflow workers for your app using the aws-flow gem.
	AwsFlowRubySettings pulumi.StringPtrOutput `pulumi:"awsFlowRubySettings"`
	// The data source's ARN.
	DataSourceArn pulumi.StringPtrOutput `pulumi:"dataSourceArn"`
	// The database name.
	DataSourceDatabaseName pulumi.StringPtrOutput `pulumi:"dataSourceDatabaseName"`
	// The data source's type one of `AutoSelectOpsworksMysqlInstance`, `OpsworksMysqlInstance`, or `RdsDbInstance`.
	DataSourceType pulumi.StringPtrOutput `pulumi:"dataSourceType"`
	// A description of the app.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Subfolder for the document root for application of type `rails`.
	DocumentRoot pulumi.StringPtrOutput `pulumi:"documentRoot"`
	// A list of virtual host alias.
	Domains pulumi.StringArrayOutput `pulumi:"domains"`
	// Whether to enable SSL for the app. This must be set in order to let `ssl_configuration.private_key`, `ssl_configuration.certificate` and `ssl_configuration.chain` take effect.
	EnableSsl pulumi.BoolPtrOutput `pulumi:"enableSsl"`
	// Object to define environment variables.  Object is described below.
	Environments ApplicationEnvironmentArrayOutput `pulumi:"environments"`
	// A human-readable name for the application.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the Rails environment for application of type `rails`.
	RailsEnv pulumi.StringPtrOutput `pulumi:"railsEnv"`
	// A short, machine-readable name for the application. This can only be defined on resource creation and ignored on resource update.
	ShortName pulumi.StringOutput `pulumi:"shortName"`
	// The SSL configuration of the app. Object is described below.
	SslConfigurations ApplicationSslConfigurationArrayOutput `pulumi:"sslConfigurations"`
	// The id of the stack the application will belong to.
	StackId pulumi.StringOutput `pulumi:"stackId"`
	// The type of source to use. For example, "archive".
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewApplication registers a new resource with the given unique name, arguments, and options.
func NewApplication(ctx *pulumi.Context,
	name string, args *ApplicationArgs, opts ...pulumi.ResourceOption) (*Application, error) {
	if args == nil || args.StackId == nil {
		return nil, errors.New("missing required argument 'StackId'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil {
		args = &ApplicationArgs{}
	}
	var resource Application
	err := ctx.RegisterResource("aws:opsworks/application:Application", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetApplication gets an existing Application resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetApplication(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ApplicationState, opts ...pulumi.ResourceOption) (*Application, error) {
	var resource Application
	err := ctx.ReadResource("aws:opsworks/application:Application", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Application resources.
type applicationState struct {
	// SCM configuration of the app as described below.
	AppSources []ApplicationAppSource `pulumi:"appSources"`
	// Run bundle install when deploying for application of type `rails`.
	AutoBundleOnDeploy *string `pulumi:"autoBundleOnDeploy"`
	// Specify activity and workflow workers for your app using the aws-flow gem.
	AwsFlowRubySettings *string `pulumi:"awsFlowRubySettings"`
	// The data source's ARN.
	DataSourceArn *string `pulumi:"dataSourceArn"`
	// The database name.
	DataSourceDatabaseName *string `pulumi:"dataSourceDatabaseName"`
	// The data source's type one of `AutoSelectOpsworksMysqlInstance`, `OpsworksMysqlInstance`, or `RdsDbInstance`.
	DataSourceType *string `pulumi:"dataSourceType"`
	// A description of the app.
	Description *string `pulumi:"description"`
	// Subfolder for the document root for application of type `rails`.
	DocumentRoot *string `pulumi:"documentRoot"`
	// A list of virtual host alias.
	Domains []string `pulumi:"domains"`
	// Whether to enable SSL for the app. This must be set in order to let `ssl_configuration.private_key`, `ssl_configuration.certificate` and `ssl_configuration.chain` take effect.
	EnableSsl *bool `pulumi:"enableSsl"`
	// Object to define environment variables.  Object is described below.
	Environments []ApplicationEnvironment `pulumi:"environments"`
	// A human-readable name for the application.
	Name *string `pulumi:"name"`
	// The name of the Rails environment for application of type `rails`.
	RailsEnv *string `pulumi:"railsEnv"`
	// A short, machine-readable name for the application. This can only be defined on resource creation and ignored on resource update.
	ShortName *string `pulumi:"shortName"`
	// The SSL configuration of the app. Object is described below.
	SslConfigurations []ApplicationSslConfiguration `pulumi:"sslConfigurations"`
	// The id of the stack the application will belong to.
	StackId *string `pulumi:"stackId"`
	// The type of source to use. For example, "archive".
	Type *string `pulumi:"type"`
}

type ApplicationState struct {
	// SCM configuration of the app as described below.
	AppSources ApplicationAppSourceArrayInput
	// Run bundle install when deploying for application of type `rails`.
	AutoBundleOnDeploy pulumi.StringPtrInput
	// Specify activity and workflow workers for your app using the aws-flow gem.
	AwsFlowRubySettings pulumi.StringPtrInput
	// The data source's ARN.
	DataSourceArn pulumi.StringPtrInput
	// The database name.
	DataSourceDatabaseName pulumi.StringPtrInput
	// The data source's type one of `AutoSelectOpsworksMysqlInstance`, `OpsworksMysqlInstance`, or `RdsDbInstance`.
	DataSourceType pulumi.StringPtrInput
	// A description of the app.
	Description pulumi.StringPtrInput
	// Subfolder for the document root for application of type `rails`.
	DocumentRoot pulumi.StringPtrInput
	// A list of virtual host alias.
	Domains pulumi.StringArrayInput
	// Whether to enable SSL for the app. This must be set in order to let `ssl_configuration.private_key`, `ssl_configuration.certificate` and `ssl_configuration.chain` take effect.
	EnableSsl pulumi.BoolPtrInput
	// Object to define environment variables.  Object is described below.
	Environments ApplicationEnvironmentArrayInput
	// A human-readable name for the application.
	Name pulumi.StringPtrInput
	// The name of the Rails environment for application of type `rails`.
	RailsEnv pulumi.StringPtrInput
	// A short, machine-readable name for the application. This can only be defined on resource creation and ignored on resource update.
	ShortName pulumi.StringPtrInput
	// The SSL configuration of the app. Object is described below.
	SslConfigurations ApplicationSslConfigurationArrayInput
	// The id of the stack the application will belong to.
	StackId pulumi.StringPtrInput
	// The type of source to use. For example, "archive".
	Type pulumi.StringPtrInput
}

func (ApplicationState) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationState)(nil)).Elem()
}

type applicationArgs struct {
	// SCM configuration of the app as described below.
	AppSources []ApplicationAppSource `pulumi:"appSources"`
	// Run bundle install when deploying for application of type `rails`.
	AutoBundleOnDeploy *string `pulumi:"autoBundleOnDeploy"`
	// Specify activity and workflow workers for your app using the aws-flow gem.
	AwsFlowRubySettings *string `pulumi:"awsFlowRubySettings"`
	// The data source's ARN.
	DataSourceArn *string `pulumi:"dataSourceArn"`
	// The database name.
	DataSourceDatabaseName *string `pulumi:"dataSourceDatabaseName"`
	// The data source's type one of `AutoSelectOpsworksMysqlInstance`, `OpsworksMysqlInstance`, or `RdsDbInstance`.
	DataSourceType *string `pulumi:"dataSourceType"`
	// A description of the app.
	Description *string `pulumi:"description"`
	// Subfolder for the document root for application of type `rails`.
	DocumentRoot *string `pulumi:"documentRoot"`
	// A list of virtual host alias.
	Domains []string `pulumi:"domains"`
	// Whether to enable SSL for the app. This must be set in order to let `ssl_configuration.private_key`, `ssl_configuration.certificate` and `ssl_configuration.chain` take effect.
	EnableSsl *bool `pulumi:"enableSsl"`
	// Object to define environment variables.  Object is described below.
	Environments []ApplicationEnvironment `pulumi:"environments"`
	// A human-readable name for the application.
	Name *string `pulumi:"name"`
	// The name of the Rails environment for application of type `rails`.
	RailsEnv *string `pulumi:"railsEnv"`
	// A short, machine-readable name for the application. This can only be defined on resource creation and ignored on resource update.
	ShortName *string `pulumi:"shortName"`
	// The SSL configuration of the app. Object is described below.
	SslConfigurations []ApplicationSslConfiguration `pulumi:"sslConfigurations"`
	// The id of the stack the application will belong to.
	StackId string `pulumi:"stackId"`
	// The type of source to use. For example, "archive".
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a Application resource.
type ApplicationArgs struct {
	// SCM configuration of the app as described below.
	AppSources ApplicationAppSourceArrayInput
	// Run bundle install when deploying for application of type `rails`.
	AutoBundleOnDeploy pulumi.StringPtrInput
	// Specify activity and workflow workers for your app using the aws-flow gem.
	AwsFlowRubySettings pulumi.StringPtrInput
	// The data source's ARN.
	DataSourceArn pulumi.StringPtrInput
	// The database name.
	DataSourceDatabaseName pulumi.StringPtrInput
	// The data source's type one of `AutoSelectOpsworksMysqlInstance`, `OpsworksMysqlInstance`, or `RdsDbInstance`.
	DataSourceType pulumi.StringPtrInput
	// A description of the app.
	Description pulumi.StringPtrInput
	// Subfolder for the document root for application of type `rails`.
	DocumentRoot pulumi.StringPtrInput
	// A list of virtual host alias.
	Domains pulumi.StringArrayInput
	// Whether to enable SSL for the app. This must be set in order to let `ssl_configuration.private_key`, `ssl_configuration.certificate` and `ssl_configuration.chain` take effect.
	EnableSsl pulumi.BoolPtrInput
	// Object to define environment variables.  Object is described below.
	Environments ApplicationEnvironmentArrayInput
	// A human-readable name for the application.
	Name pulumi.StringPtrInput
	// The name of the Rails environment for application of type `rails`.
	RailsEnv pulumi.StringPtrInput
	// A short, machine-readable name for the application. This can only be defined on resource creation and ignored on resource update.
	ShortName pulumi.StringPtrInput
	// The SSL configuration of the app. Object is described below.
	SslConfigurations ApplicationSslConfigurationArrayInput
	// The id of the stack the application will belong to.
	StackId pulumi.StringInput
	// The type of source to use. For example, "archive".
	Type pulumi.StringInput
}

func (ApplicationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*applicationArgs)(nil)).Elem()
}
