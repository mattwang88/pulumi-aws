// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * The ECR Repository data source allows the ARN, Repository URI and Registry ID to be retrieved for an ECR repository.
 */
export function getRepository(args: GetRepositoryArgs): Promise<GetRepositoryResult> {
    return pulumi.runtime.invoke("aws:ecr/getRepository:getRepository", {
        "name": args.name,
    });
}

/**
 * A collection of arguments for invoking getRepository.
 */
export interface GetRepositoryArgs {
    /**
     * The name of the ECR Repository.
     */
    readonly name: pulumi.Input<string>;
}

/**
 * A collection of values returned by getRepository.
 */
export interface GetRepositoryResult {
    /**
     * Full ARN of the repository.
     */
    readonly arn: string;
    /**
     * The registry ID where the repository was created.
     */
    readonly registryId: string;
    /**
     * The URL of the repository (in the form `aws_account_id.dkr.ecr.region.amazonaws.com/repositoryName`).
     */
    readonly repositoryUrl: string;
}
