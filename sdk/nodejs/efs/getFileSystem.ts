// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Provides information about an Elastic File System (EFS).
 */
export function getFileSystem(args?: GetFileSystemArgs): Promise<GetFileSystemResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:efs/getFileSystem:getFileSystem", {
        "creationToken": args.creationToken,
        "fileSystemId": args.fileSystemId,
        "tags": args.tags,
    });
}

/**
 * A collection of arguments for invoking getFileSystem.
 */
export interface GetFileSystemArgs {
    /**
     * Restricts the list to the file system with this creation token.
     */
    readonly creationToken?: pulumi.Input<string>;
    /**
     * The ID that identifies the file system (e.g. fs-ccfc0d65).
     */
    readonly fileSystemId?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * A collection of values returned by getFileSystem.
 */
export interface GetFileSystemResult {
    readonly creationToken: string;
    /**
     * The DNS name for the filesystem per [documented convention](http://docs.aws.amazon.com/efs/latest/ug/mounting-fs-mount-cmd-dns-name.html).
     */
    readonly dnsName: string;
    /**
     * Whether EFS is encrypted.
     */
    readonly encrypted: boolean;
    readonly fileSystemId: string;
    /**
     * The ARN for the KMS encryption key.
     */
    readonly kmsKeyId: string;
    /**
     * The PerformanceMode of the file system.
     */
    readonly performanceMode: string;
    /**
     * The list of tags assigned to the file system.
     */
    readonly tags: {[key: string]: any};
}
