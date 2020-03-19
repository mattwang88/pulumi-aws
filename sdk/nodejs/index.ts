// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// Export members:
export * from "./arn";
export * from "./getAmi";
export * from "./getAmiIds";
export * from "./getArn";
export * from "./getAutoscalingGroups";
export * from "./getAvailabilityZone";
export * from "./getAvailabilityZones";
export * from "./getBillingServiceAccount";
export * from "./getCallerIdentity";
export * from "./getCanonicalUserId";
export * from "./getElasticIp";
export * from "./getIpRanges";
export * from "./getPartition";
export * from "./getPrefixList";
export * from "./getRegion";
export * from "./provider";
export * from "./region";
export * from "./tags";
export * from "./utils";

// Export sub-modules:
import * as accessanalyzer from "./accessanalyzer/index";
import * as acm from "./acm/index";
import * as acmpca from "./acmpca/index";
import * as alb from "./alb/index";
import * as apigateway from "./apigateway/index";
import * as appautoscaling from "./appautoscaling/index";
import * as applicationloadbalancing from "./applicationloadbalancing/index";
import * as appmesh from "./appmesh/index";
import * as appsync from "./appsync/index";
import * as athena from "./athena/index";
import * as autoscaling from "./autoscaling/index";
import * as backup from "./backup/index";
import * as batch from "./batch/index";
import * as budgets from "./budgets/index";
import * as cfg from "./cfg/index";
import * as cloud9 from "./cloud9/index";
import * as cloudformation from "./cloudformation/index";
import * as cloudfront from "./cloudfront/index";
import * as cloudhsmv2 from "./cloudhsmv2/index";
import * as cloudtrail from "./cloudtrail/index";
import * as cloudwatch from "./cloudwatch/index";
import * as codebuild from "./codebuild/index";
import * as codecommit from "./codecommit/index";
import * as codedeploy from "./codedeploy/index";
import * as codepipeline from "./codepipeline/index";
import * as codestarnotifications from "./codestarnotifications/index";
import * as cognito from "./cognito/index";
import * as config from "./config/index";
import * as cur from "./cur/index";
import * as datapipeline from "./datapipeline/index";
import * as datasync from "./datasync/index";
import * as dax from "./dax/index";
import * as devicefarm from "./devicefarm/index";
import * as directconnect from "./directconnect/index";
import * as directoryservice from "./directoryservice/index";
import * as dlm from "./dlm/index";
import * as dms from "./dms/index";
import * as docdb from "./docdb/index";
import * as dynamodb from "./dynamodb/index";
import * as ebs from "./ebs/index";
import * as ec2 from "./ec2/index";
import * as ec2clientvpn from "./ec2clientvpn/index";
import * as ec2transitgateway from "./ec2transitgateway/index";
import * as ecr from "./ecr/index";
import * as ecs from "./ecs/index";
import * as efs from "./efs/index";
import * as eks from "./eks/index";
import * as elasticache from "./elasticache/index";
import * as elasticbeanstalk from "./elasticbeanstalk/index";
import * as elasticloadbalancing from "./elasticloadbalancing/index";
import * as elasticloadbalancingv2 from "./elasticloadbalancingv2/index";
import * as elasticsearch from "./elasticsearch/index";
import * as elastictranscoder from "./elastictranscoder/index";
import * as elb from "./elb/index";
import * as emr from "./emr/index";
import * as fms from "./fms/index";
import * as fsx from "./fsx/index";
import * as gamelift from "./gamelift/index";
import * as glacier from "./glacier/index";
import * as globalaccelerator from "./globalaccelerator/index";
import * as glue from "./glue/index";
import * as guardduty from "./guardduty/index";
import * as iam from "./iam/index";
import * as inspector from "./inspector/index";
import * as iot from "./iot/index";
import * as kinesis from "./kinesis/index";
import * as kms from "./kms/index";
import * as lambda from "./lambda/index";
import * as lb from "./lb/index";
import * as licensemanager from "./licensemanager/index";
import * as lightsail from "./lightsail/index";
import * as macie from "./macie/index";
import * as mediaconvert from "./mediaconvert/index";
import * as mediapackage from "./mediapackage/index";
import * as mediastore from "./mediastore/index";
import * as mq from "./mq/index";
import * as msk from "./msk/index";
import * as neptune from "./neptune/index";
import * as opsworks from "./opsworks/index";
import * as organizations from "./organizations/index";
import * as pinpoint from "./pinpoint/index";
import * as pricing from "./pricing/index";
import * as qldb from "./qldb/index";
import * as quicksight from "./quicksight/index";
import * as ram from "./ram/index";
import * as rds from "./rds/index";
import * as redshift from "./redshift/index";
import * as resourcegroups from "./resourcegroups/index";
import * as route53 from "./route53/index";
import * as s3 from "./s3/index";
import * as sagemaker from "./sagemaker/index";
import * as secretsmanager from "./secretsmanager/index";
import * as securityhub from "./securityhub/index";
import * as serverless from "./serverless/index";
import * as servicecatalog from "./servicecatalog/index";
import * as servicediscovery from "./servicediscovery/index";
import * as servicequotas from "./servicequotas/index";
import * as ses from "./ses/index";
import * as sfn from "./sfn/index";
import * as shield from "./shield/index";
import * as simpledb from "./simpledb/index";
import * as sns from "./sns/index";
import * as sqs from "./sqs/index";
import * as ssm from "./ssm/index";
import * as storagegateway from "./storagegateway/index";
import * as swf from "./swf/index";
import * as transfer from "./transfer/index";
import * as types from "./types/index";
import * as waf from "./waf/index";
import * as wafregional from "./wafregional/index";
import * as worklink from "./worklink/index";
import * as workspaces from "./workspaces/index";
import * as xray from "./xray/index";
export {accessanalyzer, acm, acmpca, alb, apigateway, appautoscaling, applicationloadbalancing, appmesh, appsync, athena, autoscaling, backup, batch, budgets, cfg, cloud9, cloudformation, cloudfront, cloudhsmv2, cloudtrail, cloudwatch, codebuild, codecommit, codedeploy, codepipeline, codestarnotifications, cognito, config, cur, datapipeline, datasync, dax, devicefarm, directconnect, directoryservice, dlm, dms, docdb, dynamodb, ebs, ec2, ec2clientvpn, ec2transitgateway, ecr, ecs, efs, eks, elasticache, elasticbeanstalk, elasticloadbalancing, elasticloadbalancingv2, elasticsearch, elastictranscoder, elb, emr, fms, fsx, gamelift, glacier, globalaccelerator, glue, guardduty, iam, inspector, iot, kinesis, kms, lambda, lb, licensemanager, lightsail, macie, mediaconvert, mediapackage, mediastore, mq, msk, neptune, opsworks, organizations, pinpoint, pricing, qldb, quicksight, ram, rds, redshift, resourcegroups, route53, s3, sagemaker, secretsmanager, securityhub, serverless, servicecatalog, servicediscovery, servicequotas, ses, sfn, shield, simpledb, sns, sqs, ssm, storagegateway, swf, transfer, types, waf, wafregional, worklink, workspaces, xray};
