// *** WARNING: this file was generated by the Lumi Terraform Bridge (TFGEN) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as lumi from "@lumi/lumi";
import * as lumirt from "@lumi/lumirt";

import {RestApi} from "./restApi";

export class Method extends lumi.NamedResource implements MethodArgs {
    public readonly apiKeyRequired?: boolean;
    public readonly authorization: string;
    public readonly authorizerId?: string;
    public readonly httpMethod: string;
    public readonly requestModels?: {[key: string]: string};
    public readonly requestParameters?: {[key: string]: boolean};
    public readonly requestParametersInJson?: string;
    public readonly requestValidatorId?: string;
    public readonly resourceId: string;
    public readonly restApi: RestApi;

    constructor(name: string, args: MethodArgs) {
        super(name);
        this.apiKeyRequired = args.apiKeyRequired;
        if (lumirt.defaultIfComputed(args.authorization, "") === undefined) {
            throw new Error("Property argument 'authorization' is required, but was missing");
        }
        this.authorization = args.authorization;
        this.authorizerId = args.authorizerId;
        if (lumirt.defaultIfComputed(args.httpMethod, "") === undefined) {
            throw new Error("Property argument 'httpMethod' is required, but was missing");
        }
        this.httpMethod = args.httpMethod;
        this.requestModels = args.requestModels;
        this.requestParameters = args.requestParameters;
        this.requestParametersInJson = args.requestParametersInJson;
        this.requestValidatorId = args.requestValidatorId;
        if (lumirt.defaultIfComputed(args.resourceId, "") === undefined) {
            throw new Error("Property argument 'resourceId' is required, but was missing");
        }
        this.resourceId = args.resourceId;
        if (lumirt.defaultIfComputed(args.restApi, "") === undefined) {
            throw new Error("Property argument 'restApi' is required, but was missing");
        }
        this.restApi = args.restApi;
    }
}

export interface MethodArgs {
    readonly apiKeyRequired?: boolean;
    readonly authorization: string;
    readonly authorizerId?: string;
    readonly httpMethod: string;
    readonly requestModels?: {[key: string]: string};
    readonly requestParameters?: {[key: string]: boolean};
    readonly requestParametersInJson?: string;
    readonly requestValidatorId?: string;
    readonly resourceId: string;
    readonly restApi: RestApi;
}

