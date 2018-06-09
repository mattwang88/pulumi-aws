# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class VpnConnection(pulumi.CustomResource):
    """
    
    Provides a VPN connection connected to a VPC. These objects can be connected to customer gateways, and allow you to establish tunnels between your network and the VPC.
    
    ~> **Note:** All arguments including `tunnel1_preshared_key` and `tunnel2_preshared_key` will be stored in the raw state as plain-text.
    [Read more about sensitive data in state](/docs/state/sensitive-data.html).
    
    ~> **Note:** The CIDR blocks in the arguments `tunnel1_inside_cidr` and `tunnel2_inside_cidr` must have a prefix of /30 and be a part of a specific range.
    [Read more about this in the AWS documentation](https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_VpnTunnelOptionsSpecification.html).
    """
    def __init__(__self__, __name__, __opts__=None, customer_gateway_configuration=None, customer_gateway_id=None, routes=None, static_routes_only=None, tags=None, tunnel1_inside_cidr=None, tunnel1_preshared_key=None, tunnel2_inside_cidr=None, tunnel2_preshared_key=None, type=None, vgw_telemetries=None, vpn_gateway_id=None):
        """Create a VpnConnection resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if customer_gateway_configuration and not isinstance(customer_gateway_configuration, basestring):
            raise TypeError('Expected property customer_gateway_configuration to be a basestring')
        __self__.customer_gateway_configuration = customer_gateway_configuration
        """
        The configuration information for the VPN connection's customer gateway (in the native XML format).
        """
        __props__['customerGatewayConfiguration'] = customer_gateway_configuration

        if not customer_gateway_id:
            raise TypeError('Missing required property customer_gateway_id')
        elif not isinstance(customer_gateway_id, basestring):
            raise TypeError('Expected property customer_gateway_id to be a basestring')
        __self__.customer_gateway_id = customer_gateway_id
        """
        The ID of the customer gateway.
        """
        __props__['customerGatewayId'] = customer_gateway_id

        if routes and not isinstance(routes, list):
            raise TypeError('Expected property routes to be a list')
        __self__.routes = routes
        __props__['routes'] = routes

        if static_routes_only and not isinstance(static_routes_only, bool):
            raise TypeError('Expected property static_routes_only to be a bool')
        __self__.static_routes_only = static_routes_only
        """
        Whether the VPN connection uses static routes exclusively. Static routes must be used for devices that don't support BGP.
        """
        __props__['staticRoutesOnly'] = static_routes_only

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        Tags to apply to the connection.
        """
        __props__['tags'] = tags

        if tunnel1_inside_cidr and not isinstance(tunnel1_inside_cidr, basestring):
            raise TypeError('Expected property tunnel1_inside_cidr to be a basestring')
        __self__.tunnel1_inside_cidr = tunnel1_inside_cidr
        """
        The CIDR block of the inside IP addresses for the first VPN tunnel.
        """
        __props__['tunnel1InsideCidr'] = tunnel1_inside_cidr

        if tunnel1_preshared_key and not isinstance(tunnel1_preshared_key, basestring):
            raise TypeError('Expected property tunnel1_preshared_key to be a basestring')
        __self__.tunnel1_preshared_key = tunnel1_preshared_key
        """
        The preshared key of the first VPN tunnel.
        """
        __props__['tunnel1PresharedKey'] = tunnel1_preshared_key

        if tunnel2_inside_cidr and not isinstance(tunnel2_inside_cidr, basestring):
            raise TypeError('Expected property tunnel2_inside_cidr to be a basestring')
        __self__.tunnel2_inside_cidr = tunnel2_inside_cidr
        """
        The CIDR block of the second IP addresses for the first VPN tunnel.
        """
        __props__['tunnel2InsideCidr'] = tunnel2_inside_cidr

        if tunnel2_preshared_key and not isinstance(tunnel2_preshared_key, basestring):
            raise TypeError('Expected property tunnel2_preshared_key to be a basestring')
        __self__.tunnel2_preshared_key = tunnel2_preshared_key
        """
        The preshared key of the second VPN tunnel.
        ~> **Note:** The preshared key must be between 8 and 64 characters in length and cannot start with zero(0). Allowed characters are alphanumeric characters, periods(.) and underscores(_).
        """
        __props__['tunnel2PresharedKey'] = tunnel2_preshared_key

        if not type:
            raise TypeError('Missing required property type')
        elif not isinstance(type, basestring):
            raise TypeError('Expected property type to be a basestring')
        __self__.type = type
        """
        The type of VPN connection. The only type AWS supports at this time is "ipsec.1".
        """
        __props__['type'] = type

        if vgw_telemetries and not isinstance(vgw_telemetries, list):
            raise TypeError('Expected property vgw_telemetries to be a list')
        __self__.vgw_telemetries = vgw_telemetries
        __props__['vgwTelemetries'] = vgw_telemetries

        if not vpn_gateway_id:
            raise TypeError('Missing required property vpn_gateway_id')
        elif not isinstance(vpn_gateway_id, basestring):
            raise TypeError('Expected property vpn_gateway_id to be a basestring')
        __self__.vpn_gateway_id = vpn_gateway_id
        """
        The ID of the virtual private gateway.
        """
        __props__['vpnGatewayId'] = vpn_gateway_id

        __self__.tunnel1_address = pulumi.runtime.UNKNOWN
        """
        The public IP address of the first VPN tunnel.
        """
        __self__.tunnel1_bgp_asn = pulumi.runtime.UNKNOWN
        """
        The bgp asn number of the first VPN tunnel.
        """
        __self__.tunnel1_bgp_holdtime = pulumi.runtime.UNKNOWN
        """
        The bgp holdtime of the first VPN tunnel.
        """
        __self__.tunnel1_cgw_inside_address = pulumi.runtime.UNKNOWN
        """
        The RFC 6890 link-local address of the first VPN tunnel (Customer Gateway Side).
        """
        __self__.tunnel1_vgw_inside_address = pulumi.runtime.UNKNOWN
        """
        The RFC 6890 link-local address of the first VPN tunnel (VPN Gateway Side).
        """
        __self__.tunnel2_address = pulumi.runtime.UNKNOWN
        """
        The public IP address of the second VPN tunnel.
        """
        __self__.tunnel2_bgp_asn = pulumi.runtime.UNKNOWN
        """
        The bgp asn number of the second VPN tunnel.
        """
        __self__.tunnel2_bgp_holdtime = pulumi.runtime.UNKNOWN
        """
        The bgp holdtime of the second VPN tunnel.
        """
        __self__.tunnel2_cgw_inside_address = pulumi.runtime.UNKNOWN
        """
        The RFC 6890 link-local address of the second VPN tunnel (Customer Gateway Side).
        """
        __self__.tunnel2_vgw_inside_address = pulumi.runtime.UNKNOWN
        """
        The RFC 6890 link-local address of the second VPN tunnel (VPN Gateway Side).
        """

        super(VpnConnection, __self__).__init__(
            'aws:ec2/vpnConnection:VpnConnection',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'customerGatewayConfiguration' in outs:
            self.customer_gateway_configuration = outs['customerGatewayConfiguration']
        if 'customerGatewayId' in outs:
            self.customer_gateway_id = outs['customerGatewayId']
        if 'routes' in outs:
            self.routes = outs['routes']
        if 'staticRoutesOnly' in outs:
            self.static_routes_only = outs['staticRoutesOnly']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'tunnel1Address' in outs:
            self.tunnel1_address = outs['tunnel1Address']
        if 'tunnel1BgpAsn' in outs:
            self.tunnel1_bgp_asn = outs['tunnel1BgpAsn']
        if 'tunnel1BgpHoldtime' in outs:
            self.tunnel1_bgp_holdtime = outs['tunnel1BgpHoldtime']
        if 'tunnel1CgwInsideAddress' in outs:
            self.tunnel1_cgw_inside_address = outs['tunnel1CgwInsideAddress']
        if 'tunnel1InsideCidr' in outs:
            self.tunnel1_inside_cidr = outs['tunnel1InsideCidr']
        if 'tunnel1PresharedKey' in outs:
            self.tunnel1_preshared_key = outs['tunnel1PresharedKey']
        if 'tunnel1VgwInsideAddress' in outs:
            self.tunnel1_vgw_inside_address = outs['tunnel1VgwInsideAddress']
        if 'tunnel2Address' in outs:
            self.tunnel2_address = outs['tunnel2Address']
        if 'tunnel2BgpAsn' in outs:
            self.tunnel2_bgp_asn = outs['tunnel2BgpAsn']
        if 'tunnel2BgpHoldtime' in outs:
            self.tunnel2_bgp_holdtime = outs['tunnel2BgpHoldtime']
        if 'tunnel2CgwInsideAddress' in outs:
            self.tunnel2_cgw_inside_address = outs['tunnel2CgwInsideAddress']
        if 'tunnel2InsideCidr' in outs:
            self.tunnel2_inside_cidr = outs['tunnel2InsideCidr']
        if 'tunnel2PresharedKey' in outs:
            self.tunnel2_preshared_key = outs['tunnel2PresharedKey']
        if 'tunnel2VgwInsideAddress' in outs:
            self.tunnel2_vgw_inside_address = outs['tunnel2VgwInsideAddress']
        if 'type' in outs:
            self.type = outs['type']
        if 'vgwTelemetries' in outs:
            self.vgw_telemetries = outs['vgwTelemetries']
        if 'vpnGatewayId' in outs:
            self.vpn_gateway_id = outs['vpnGatewayId']
