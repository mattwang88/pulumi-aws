// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Glue
{
    /// <summary>
    /// Provides a Glue Catalog Database Resource. You can refer to the [Glue Developer Guide](http://docs.aws.amazon.com/glue/latest/dg/populate-data-catalog.html) for a full explanation of the Glue Data Catalog functionality
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/glue_catalog_database.html.markdown.
    /// </summary>
    public partial class CatalogDatabase : Pulumi.CustomResource
    {
        /// <summary>
        /// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
        /// </summary>
        [Output("catalogId")]
        public Output<string> CatalogId { get; private set; } = null!;

        /// <summary>
        /// Description of the database.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The location of the database (for example, an HDFS path).
        /// </summary>
        [Output("locationUri")]
        public Output<string?> LocationUri { get; private set; } = null!;

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of key-value pairs that define parameters and properties of the database.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>?> Parameters { get; private set; } = null!;


        /// <summary>
        /// Create a CatalogDatabase resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CatalogDatabase(string name, CatalogDatabaseArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:glue/catalogDatabase:CatalogDatabase", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private CatalogDatabase(string name, Input<string> id, CatalogDatabaseState? state = null, CustomResourceOptions? options = null)
            : base("aws:glue/catalogDatabase:CatalogDatabase", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CatalogDatabase resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CatalogDatabase Get(string name, Input<string> id, CatalogDatabaseState? state = null, CustomResourceOptions? options = null)
        {
            return new CatalogDatabase(name, id, state, options);
        }
    }

    public sealed class CatalogDatabaseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
        /// </summary>
        [Input("catalogId")]
        public Input<string>? CatalogId { get; set; }

        /// <summary>
        /// Description of the database.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The location of the database (for example, an HDFS path).
        /// </summary>
        [Input("locationUri")]
        public Input<string>? LocationUri { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A list of key-value pairs that define parameters and properties of the database.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        public CatalogDatabaseArgs()
        {
        }
    }

    public sealed class CatalogDatabaseState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the Glue Catalog to create the database in. If omitted, this defaults to the AWS Account ID.
        /// </summary>
        [Input("catalogId")]
        public Input<string>? CatalogId { get; set; }

        /// <summary>
        /// Description of the database.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The location of the database (for example, an HDFS path).
        /// </summary>
        [Input("locationUri")]
        public Input<string>? LocationUri { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// A list of key-value pairs that define parameters and properties of the database.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        public CatalogDatabaseState()
        {
        }
    }
}
