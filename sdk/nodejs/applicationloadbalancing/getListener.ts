// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * ~> **Note:** `aws_alb_listener` is known as `aws_lb_listener`. The functionality is identical.
 * 
 * Provides information about a Load Balancer Listener.
 * 
 * This data source can prove useful when a module accepts an LB Listener as an
 * input variable and needs to know the LB it is attached to, or other
 * information specific to the listener in question.
 */
export function getListener(args?: GetListenerArgs): Promise<GetListenerResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:applicationloadbalancing/getListener:getListener", {
        "arn": args.arn,
        "loadBalancerArn": args.loadBalancerArn,
        "port": args.port,
    });
}

/**
 * A collection of arguments for invoking getListener.
 */
export interface GetListenerArgs {
    /**
     * The arn of the listener. Required if `load_balancer_arn` and `port` is not set.
     */
    readonly arn?: pulumi.Input<string>;
    /**
     * The arn of the load balander. Required if `arn` is not set.
     */
    readonly loadBalancerArn?: pulumi.Input<string>;
    /**
     * The port of the listener. Required if `arn` is not set.
     */
    readonly port?: pulumi.Input<number>;
}

/**
 * A collection of values returned by getListener.
 */
export interface GetListenerResult {
    readonly arn: string;
    readonly certificateArn: string;
    readonly defaultActions: { targetGroupArn: string, type: string }[];
    readonly loadBalancerArn: string;
    readonly port: number;
    readonly protocol: string;
    readonly sslPolicy: string;
}
