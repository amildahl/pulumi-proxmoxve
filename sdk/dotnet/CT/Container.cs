// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.ProxmoxVE.CT
{
    [ProxmoxVEResourceType("proxmoxve:CT/container:Container")]
    public partial class Container : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The cloning configuration
        /// </summary>
        [Output("clone")]
        public Output<Outputs.ContainerClone?> Clone { get; private set; } = null!;

        /// <summary>
        /// The console configuration
        /// </summary>
        [Output("console")]
        public Output<Outputs.ContainerConsole?> Console { get; private set; } = null!;

        /// <summary>
        /// The CPU allocation
        /// </summary>
        [Output("cpu")]
        public Output<Outputs.ContainerCpu?> Cpu { get; private set; } = null!;

        /// <summary>
        /// The description
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The disks
        /// </summary>
        [Output("disk")]
        public Output<Outputs.ContainerDisk?> Disk { get; private set; } = null!;

        /// <summary>
        /// The initialization configuration
        /// </summary>
        [Output("initialization")]
        public Output<Outputs.ContainerInitialization?> Initialization { get; private set; } = null!;

        /// <summary>
        /// The memory allocation
        /// </summary>
        [Output("memory")]
        public Output<Outputs.ContainerMemory?> Memory { get; private set; } = null!;

        /// <summary>
        /// The network interfaces
        /// </summary>
        [Output("networkInterfaces")]
        public Output<ImmutableArray<Outputs.ContainerNetworkInterface>> NetworkInterfaces { get; private set; } = null!;

        /// <summary>
        /// The node name
        /// </summary>
        [Output("nodeName")]
        public Output<string> NodeName { get; private set; } = null!;

        /// <summary>
        /// The operating system configuration
        /// </summary>
        [Output("operatingSystem")]
        public Output<Outputs.ContainerOperatingSystem?> OperatingSystem { get; private set; } = null!;

        /// <summary>
        /// The ID of the pool to assign the container to
        /// </summary>
        [Output("poolId")]
        public Output<string?> PoolId { get; private set; } = null!;

        /// <summary>
        /// Whether to start the container
        /// </summary>
        [Output("started")]
        public Output<bool?> Started { get; private set; } = null!;

        /// <summary>
        /// Whether to create a template
        /// </summary>
        [Output("template")]
        public Output<bool?> Template { get; private set; } = null!;

        /// <summary>
        /// The VM identifier
        /// </summary>
        [Output("vmId")]
        public Output<int?> VmId { get; private set; } = null!;


        /// <summary>
        /// Create a Container resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Container(string name, ContainerArgs args, CustomResourceOptions? options = null)
            : base("proxmoxve:CT/container:Container", name, args ?? new ContainerArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Container(string name, Input<string> id, ContainerState? state = null, CustomResourceOptions? options = null)
            : base("proxmoxve:CT/container:Container", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/amildahl/pulumi-proxmoxve",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Container resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Container Get(string name, Input<string> id, ContainerState? state = null, CustomResourceOptions? options = null)
        {
            return new Container(name, id, state, options);
        }
    }

    public sealed class ContainerArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The cloning configuration
        /// </summary>
        [Input("clone")]
        public Input<Inputs.ContainerCloneArgs>? Clone { get; set; }

        /// <summary>
        /// The console configuration
        /// </summary>
        [Input("console")]
        public Input<Inputs.ContainerConsoleArgs>? Console { get; set; }

        /// <summary>
        /// The CPU allocation
        /// </summary>
        [Input("cpu")]
        public Input<Inputs.ContainerCpuArgs>? Cpu { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The disks
        /// </summary>
        [Input("disk")]
        public Input<Inputs.ContainerDiskArgs>? Disk { get; set; }

        /// <summary>
        /// The initialization configuration
        /// </summary>
        [Input("initialization")]
        public Input<Inputs.ContainerInitializationArgs>? Initialization { get; set; }

        /// <summary>
        /// The memory allocation
        /// </summary>
        [Input("memory")]
        public Input<Inputs.ContainerMemoryArgs>? Memory { get; set; }

        [Input("networkInterfaces")]
        private InputList<Inputs.ContainerNetworkInterfaceArgs>? _networkInterfaces;

        /// <summary>
        /// The network interfaces
        /// </summary>
        public InputList<Inputs.ContainerNetworkInterfaceArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.ContainerNetworkInterfaceArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The node name
        /// </summary>
        [Input("nodeName", required: true)]
        public Input<string> NodeName { get; set; } = null!;

        /// <summary>
        /// The operating system configuration
        /// </summary>
        [Input("operatingSystem")]
        public Input<Inputs.ContainerOperatingSystemArgs>? OperatingSystem { get; set; }

        /// <summary>
        /// The ID of the pool to assign the container to
        /// </summary>
        [Input("poolId")]
        public Input<string>? PoolId { get; set; }

        /// <summary>
        /// Whether to start the container
        /// </summary>
        [Input("started")]
        public Input<bool>? Started { get; set; }

        /// <summary>
        /// Whether to create a template
        /// </summary>
        [Input("template")]
        public Input<bool>? Template { get; set; }

        /// <summary>
        /// The VM identifier
        /// </summary>
        [Input("vmId")]
        public Input<int>? VmId { get; set; }

        public ContainerArgs()
        {
        }
        public static new ContainerArgs Empty => new ContainerArgs();
    }

    public sealed class ContainerState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The cloning configuration
        /// </summary>
        [Input("clone")]
        public Input<Inputs.ContainerCloneGetArgs>? Clone { get; set; }

        /// <summary>
        /// The console configuration
        /// </summary>
        [Input("console")]
        public Input<Inputs.ContainerConsoleGetArgs>? Console { get; set; }

        /// <summary>
        /// The CPU allocation
        /// </summary>
        [Input("cpu")]
        public Input<Inputs.ContainerCpuGetArgs>? Cpu { get; set; }

        /// <summary>
        /// The description
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The disks
        /// </summary>
        [Input("disk")]
        public Input<Inputs.ContainerDiskGetArgs>? Disk { get; set; }

        /// <summary>
        /// The initialization configuration
        /// </summary>
        [Input("initialization")]
        public Input<Inputs.ContainerInitializationGetArgs>? Initialization { get; set; }

        /// <summary>
        /// The memory allocation
        /// </summary>
        [Input("memory")]
        public Input<Inputs.ContainerMemoryGetArgs>? Memory { get; set; }

        [Input("networkInterfaces")]
        private InputList<Inputs.ContainerNetworkInterfaceGetArgs>? _networkInterfaces;

        /// <summary>
        /// The network interfaces
        /// </summary>
        public InputList<Inputs.ContainerNetworkInterfaceGetArgs> NetworkInterfaces
        {
            get => _networkInterfaces ?? (_networkInterfaces = new InputList<Inputs.ContainerNetworkInterfaceGetArgs>());
            set => _networkInterfaces = value;
        }

        /// <summary>
        /// The node name
        /// </summary>
        [Input("nodeName")]
        public Input<string>? NodeName { get; set; }

        /// <summary>
        /// The operating system configuration
        /// </summary>
        [Input("operatingSystem")]
        public Input<Inputs.ContainerOperatingSystemGetArgs>? OperatingSystem { get; set; }

        /// <summary>
        /// The ID of the pool to assign the container to
        /// </summary>
        [Input("poolId")]
        public Input<string>? PoolId { get; set; }

        /// <summary>
        /// Whether to start the container
        /// </summary>
        [Input("started")]
        public Input<bool>? Started { get; set; }

        /// <summary>
        /// Whether to create a template
        /// </summary>
        [Input("template")]
        public Input<bool>? Template { get; set; }

        /// <summary>
        /// The VM identifier
        /// </summary>
        [Input("vmId")]
        public Input<int>? VmId { get; set; }

        public ContainerState()
        {
        }
        public static new ContainerState Empty => new ContainerState();
    }
}
