// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ProxmoxVE
{
    public static class GetDNS
    {
        public static Task<GetDNSResult> InvokeAsync(GetDNSArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDNSResult>("proxmoxve:index/getDNS:getDNS", args ?? new GetDNSArgs(), options.WithDefaults());

        public static Output<GetDNSResult> Invoke(GetDNSInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDNSResult>("proxmoxve:index/getDNS:getDNS", args ?? new GetDNSInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDNSArgs : global::Pulumi.InvokeArgs
    {
        [Input("nodeName", required: true)]
        public string NodeName { get; set; } = null!;

        public GetDNSArgs()
        {
        }
        public static new GetDNSArgs Empty => new GetDNSArgs();
    }

    public sealed class GetDNSInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("nodeName", required: true)]
        public Input<string> NodeName { get; set; } = null!;

        public GetDNSInvokeArgs()
        {
        }
        public static new GetDNSInvokeArgs Empty => new GetDNSInvokeArgs();
    }


    [OutputType]
    public sealed class GetDNSResult
    {
        public readonly string Domain;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string NodeName;
        public readonly ImmutableArray<string> Servers;

        [OutputConstructor]
        private GetDNSResult(
            string domain,

            string id,

            string nodeName,

            ImmutableArray<string> servers)
        {
            Domain = domain;
            Id = id;
            NodeName = nodeName;
            Servers = servers;
        }
    }
}
