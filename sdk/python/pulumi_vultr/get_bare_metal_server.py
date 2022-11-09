# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetBareMetalServerResult',
    'AwaitableGetBareMetalServerResult',
    'get_bare_metal_server',
    'get_bare_metal_server_output',
]

@pulumi.output_type
class GetBareMetalServerResult:
    """
    A collection of values returned by getBareMetalServer.
    """
    def __init__(__self__, app_id=None, cpu_count=None, date_created=None, disk=None, features=None, filters=None, gateway_v4=None, id=None, image_id=None, label=None, mac_address=None, main_ip=None, netmask_v4=None, os=None, os_id=None, plan=None, ram=None, region=None, status=None, tag=None, tags=None, v6_main_ip=None, v6_network=None, v6_network_size=None):
        if app_id and not isinstance(app_id, int):
            raise TypeError("Expected argument 'app_id' to be a int")
        pulumi.set(__self__, "app_id", app_id)
        if cpu_count and not isinstance(cpu_count, int):
            raise TypeError("Expected argument 'cpu_count' to be a int")
        pulumi.set(__self__, "cpu_count", cpu_count)
        if date_created and not isinstance(date_created, str):
            raise TypeError("Expected argument 'date_created' to be a str")
        pulumi.set(__self__, "date_created", date_created)
        if disk and not isinstance(disk, str):
            raise TypeError("Expected argument 'disk' to be a str")
        pulumi.set(__self__, "disk", disk)
        if features and not isinstance(features, list):
            raise TypeError("Expected argument 'features' to be a list")
        pulumi.set(__self__, "features", features)
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if gateway_v4 and not isinstance(gateway_v4, str):
            raise TypeError("Expected argument 'gateway_v4' to be a str")
        pulumi.set(__self__, "gateway_v4", gateway_v4)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if image_id and not isinstance(image_id, str):
            raise TypeError("Expected argument 'image_id' to be a str")
        pulumi.set(__self__, "image_id", image_id)
        if label and not isinstance(label, str):
            raise TypeError("Expected argument 'label' to be a str")
        pulumi.set(__self__, "label", label)
        if mac_address and not isinstance(mac_address, int):
            raise TypeError("Expected argument 'mac_address' to be a int")
        pulumi.set(__self__, "mac_address", mac_address)
        if main_ip and not isinstance(main_ip, str):
            raise TypeError("Expected argument 'main_ip' to be a str")
        pulumi.set(__self__, "main_ip", main_ip)
        if netmask_v4 and not isinstance(netmask_v4, str):
            raise TypeError("Expected argument 'netmask_v4' to be a str")
        pulumi.set(__self__, "netmask_v4", netmask_v4)
        if os and not isinstance(os, str):
            raise TypeError("Expected argument 'os' to be a str")
        pulumi.set(__self__, "os", os)
        if os_id and not isinstance(os_id, int):
            raise TypeError("Expected argument 'os_id' to be a int")
        pulumi.set(__self__, "os_id", os_id)
        if plan and not isinstance(plan, str):
            raise TypeError("Expected argument 'plan' to be a str")
        pulumi.set(__self__, "plan", plan)
        if ram and not isinstance(ram, str):
            raise TypeError("Expected argument 'ram' to be a str")
        pulumi.set(__self__, "ram", ram)
        if region and not isinstance(region, str):
            raise TypeError("Expected argument 'region' to be a str")
        pulumi.set(__self__, "region", region)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if tag and not isinstance(tag, str):
            raise TypeError("Expected argument 'tag' to be a str")
        pulumi.set(__self__, "tag", tag)
        if tags and not isinstance(tags, list):
            raise TypeError("Expected argument 'tags' to be a list")
        pulumi.set(__self__, "tags", tags)
        if v6_main_ip and not isinstance(v6_main_ip, str):
            raise TypeError("Expected argument 'v6_main_ip' to be a str")
        pulumi.set(__self__, "v6_main_ip", v6_main_ip)
        if v6_network and not isinstance(v6_network, str):
            raise TypeError("Expected argument 'v6_network' to be a str")
        pulumi.set(__self__, "v6_network", v6_network)
        if v6_network_size and not isinstance(v6_network_size, int):
            raise TypeError("Expected argument 'v6_network_size' to be a int")
        pulumi.set(__self__, "v6_network_size", v6_network_size)

    @property
    @pulumi.getter(name="appId")
    def app_id(self) -> int:
        """
        The server's application ID.
        """
        return pulumi.get(self, "app_id")

    @property
    @pulumi.getter(name="cpuCount")
    def cpu_count(self) -> int:
        """
        The number of CPUs available on the server.
        """
        return pulumi.get(self, "cpu_count")

    @property
    @pulumi.getter(name="dateCreated")
    def date_created(self) -> str:
        """
        The date the server was added to your Vultr account.
        """
        return pulumi.get(self, "date_created")

    @property
    @pulumi.getter
    def disk(self) -> str:
        """
        The description of the disk(s) on the server.
        """
        return pulumi.get(self, "disk")

    @property
    @pulumi.getter
    def features(self) -> Sequence[str]:
        return pulumi.get(self, "features")

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetBareMetalServerFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter(name="gatewayV4")
    def gateway_v4(self) -> str:
        """
        The server's IPv4 gateway.
        """
        return pulumi.get(self, "gateway_v4")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="imageId")
    def image_id(self) -> str:
        """
        The Marketplace ID for this application.
        """
        return pulumi.get(self, "image_id")

    @property
    @pulumi.getter
    def label(self) -> str:
        """
        The server's label.
        """
        return pulumi.get(self, "label")

    @property
    @pulumi.getter(name="macAddress")
    def mac_address(self) -> int:
        return pulumi.get(self, "mac_address")

    @property
    @pulumi.getter(name="mainIp")
    def main_ip(self) -> str:
        """
        The server's main IP address.
        """
        return pulumi.get(self, "main_ip")

    @property
    @pulumi.getter(name="netmaskV4")
    def netmask_v4(self) -> str:
        """
        The server's IPv4 netmask.
        """
        return pulumi.get(self, "netmask_v4")

    @property
    @pulumi.getter
    def os(self) -> str:
        """
        The operating system of the server.
        """
        return pulumi.get(self, "os")

    @property
    @pulumi.getter(name="osId")
    def os_id(self) -> int:
        """
        The server's operating system ID.
        """
        return pulumi.get(self, "os_id")

    @property
    @pulumi.getter
    def plan(self) -> str:
        """
        The server's plan ID.
        """
        return pulumi.get(self, "plan")

    @property
    @pulumi.getter
    def ram(self) -> str:
        """
        The amount of memory available on the server in MB.
        """
        return pulumi.get(self, "ram")

    @property
    @pulumi.getter
    def region(self) -> str:
        """
        The region ID of the server.
        """
        return pulumi.get(self, "region")

    @property
    @pulumi.getter
    def status(self) -> str:
        """
        The status of the server's subscription.
        """
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def tag(self) -> str:
        """
        The server's tag.
        """
        return pulumi.get(self, "tag")

    @property
    @pulumi.getter
    def tags(self) -> Sequence[str]:
        """
        A list of tags applied to the server.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="v6MainIp")
    def v6_main_ip(self) -> str:
        return pulumi.get(self, "v6_main_ip")

    @property
    @pulumi.getter(name="v6Network")
    def v6_network(self) -> str:
        return pulumi.get(self, "v6_network")

    @property
    @pulumi.getter(name="v6NetworkSize")
    def v6_network_size(self) -> int:
        return pulumi.get(self, "v6_network_size")


class AwaitableGetBareMetalServerResult(GetBareMetalServerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetBareMetalServerResult(
            app_id=self.app_id,
            cpu_count=self.cpu_count,
            date_created=self.date_created,
            disk=self.disk,
            features=self.features,
            filters=self.filters,
            gateway_v4=self.gateway_v4,
            id=self.id,
            image_id=self.image_id,
            label=self.label,
            mac_address=self.mac_address,
            main_ip=self.main_ip,
            netmask_v4=self.netmask_v4,
            os=self.os,
            os_id=self.os_id,
            plan=self.plan,
            ram=self.ram,
            region=self.region,
            status=self.status,
            tag=self.tag,
            tags=self.tags,
            v6_main_ip=self.v6_main_ip,
            v6_network=self.v6_network,
            v6_network_size=self.v6_network_size)


def get_bare_metal_server(filters: Optional[Sequence[pulumi.InputType['GetBareMetalServerFilterArgs']]] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetBareMetalServerResult:
    """
    Get information about a Vultr bare metal server.

    ## Example Usage

    Get the information for a server by `label`:

    ```python
    import pulumi
    import pulumi_vultr as vultr

    my_server = vultr.get_bare_metal_server(filters=[vultr.GetBareMetalServerFilterArgs(
        name="label",
        values=["my-server-label"],
    )])
    ```


    :param Sequence[pulumi.InputType['GetBareMetalServerFilterArgs']] filters: Query parameters for finding servers.
    """
    __args__ = dict()
    __args__['filters'] = filters
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('vultr:index/getBareMetalServer:getBareMetalServer', __args__, opts=opts, typ=GetBareMetalServerResult).value

    return AwaitableGetBareMetalServerResult(
        app_id=__ret__.app_id,
        cpu_count=__ret__.cpu_count,
        date_created=__ret__.date_created,
        disk=__ret__.disk,
        features=__ret__.features,
        filters=__ret__.filters,
        gateway_v4=__ret__.gateway_v4,
        id=__ret__.id,
        image_id=__ret__.image_id,
        label=__ret__.label,
        mac_address=__ret__.mac_address,
        main_ip=__ret__.main_ip,
        netmask_v4=__ret__.netmask_v4,
        os=__ret__.os,
        os_id=__ret__.os_id,
        plan=__ret__.plan,
        ram=__ret__.ram,
        region=__ret__.region,
        status=__ret__.status,
        tag=__ret__.tag,
        tags=__ret__.tags,
        v6_main_ip=__ret__.v6_main_ip,
        v6_network=__ret__.v6_network,
        v6_network_size=__ret__.v6_network_size)


@_utilities.lift_output_func(get_bare_metal_server)
def get_bare_metal_server_output(filters: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetBareMetalServerFilterArgs']]]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetBareMetalServerResult]:
    """
    Get information about a Vultr bare metal server.

    ## Example Usage

    Get the information for a server by `label`:

    ```python
    import pulumi
    import pulumi_vultr as vultr

    my_server = vultr.get_bare_metal_server(filters=[vultr.GetBareMetalServerFilterArgs(
        name="label",
        values=["my-server-label"],
    )])
    ```


    :param Sequence[pulumi.InputType['GetBareMetalServerFilterArgs']] filters: Query parameters for finding servers.
    """
    ...
