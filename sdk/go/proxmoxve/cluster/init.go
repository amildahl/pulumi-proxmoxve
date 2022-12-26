// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cluster

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/amildahl/pulumi-proxmoxve/sdk/v2/go/proxmoxve"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "proxmoxve:Cluster/clusterAlias:ClusterAlias":
		r = &ClusterAlias{}
	case "proxmoxve:Cluster/clusterIPSet:ClusterIPSet":
		r = &ClusterIPSet{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := proxmoxve.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"proxmoxve",
		"Cluster/clusterAlias",
		&module{version},
	)
	pulumi.RegisterResourceModule(
		"proxmoxve",
		"Cluster/clusterIPSet",
		&module{version},
	)
}
