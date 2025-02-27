// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Extensions;

    public partial class ConnectedMachineIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentity,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Models.IConnectedMachineIdentityInternal
    {

        /// <summary>Backing field for <see cref="ExtensionName" /> property.</summary>
        private string _extensionName;

        /// <summary>The name of the machine extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ExtensionName { get => this._extensionName; set => this._extensionName = value; }

        /// <summary>Backing field for <see cref="ExtensionType" /> property.</summary>
        private string _extensionType;

        /// <summary>The extensionType of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ExtensionType { get => this._extensionType; set => this._extensionType = value; }

        /// <summary>Backing field for <see cref="GroupName" /> property.</summary>
        private string _groupName;

        /// <summary>The name of the private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string GroupName { get => this._groupName; set => this._groupName = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="LicenseName" /> property.</summary>
        private string _licenseName;

        /// <summary>The name of the license.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string LicenseName { get => this._licenseName; set => this._licenseName = value; }

        /// <summary>Backing field for <see cref="LicenseProfileName" /> property.</summary>
        private string _licenseProfileName;

        /// <summary>The name of the license profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string LicenseProfileName { get => this._licenseProfileName; set => this._licenseProfileName = value; }

        /// <summary>Backing field for <see cref="Location" /> property.</summary>
        private string _location;

        /// <summary>The location of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Location { get => this._location; set => this._location = value; }

        /// <summary>Backing field for <see cref="MachineName" /> property.</summary>
        private string _machineName;

        /// <summary>The name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string MachineName { get => this._machineName; set => this._machineName = value; }

        /// <summary>Backing field for <see cref="MetadataName" /> property.</summary>
        private string _metadataName;

        /// <summary>Name of the HybridIdentityMetadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string MetadataName { get => this._metadataName; set => this._metadataName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>Defines the os type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="PerimeterName" /> property.</summary>
        private string _perimeterName;

        /// <summary>
        /// The name, in the format {perimeterGuid}.{associationName}, of the Network Security Perimeter resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string PerimeterName { get => this._perimeterName; set => this._perimeterName = value; }

        /// <summary>Backing field for <see cref="PrivateEndpointConnectionName" /> property.</summary>
        private string _privateEndpointConnectionName;

        /// <summary>The name of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string PrivateEndpointConnectionName { get => this._privateEndpointConnectionName; set => this._privateEndpointConnectionName = value; }

        /// <summary>Backing field for <see cref="PrivateLinkScopeId" /> property.</summary>
        private string _privateLinkScopeId;

        /// <summary>The id (Guid) of the Azure Arc PrivateLinkScope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string PrivateLinkScopeId { get => this._privateLinkScopeId; set => this._privateLinkScopeId = value; }

        /// <summary>Backing field for <see cref="Publisher" /> property.</summary>
        private string _publisher;

        /// <summary>The publisher of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Publisher { get => this._publisher; set => this._publisher = value; }

        /// <summary>Backing field for <see cref="ResourceGroupName" /> property.</summary>
        private string _resourceGroupName;

        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ResourceGroupName { get => this._resourceGroupName; set => this._resourceGroupName = value; }

        /// <summary>Backing field for <see cref="ResourceUri" /> property.</summary>
        private string _resourceUri;

        /// <summary>
        /// The fully qualified Azure Resource manager identifier of the resource to be connected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ResourceUri { get => this._resourceUri; set => this._resourceUri = value; }

        /// <summary>Backing field for <see cref="RunCommandName" /> property.</summary>
        private string _runCommandName;

        /// <summary>The name of the run command.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string RunCommandName { get => this._runCommandName; set => this._runCommandName = value; }

        /// <summary>Backing field for <see cref="ScopeName" /> property.</summary>
        private string _scopeName;

        /// <summary>The name of the Azure Arc PrivateLinkScope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string ScopeName { get => this._scopeName; set => this._scopeName = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private string _subscriptionId;

        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>The version of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PropertyOrigin.Owned)]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ConnectedMachineIdentity" /> instance.</summary>
        public ConnectedMachineIdentity()
        {

        }
    }
    public partial interface IConnectedMachineIdentity :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.IJsonSerializable
    {
        /// <summary>The name of the machine extension.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the machine extension.",
        SerializedName = @"extensionName",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionName { get; set; }
        /// <summary>The extensionType of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The extensionType of the Extension being received.",
        SerializedName = @"extensionType",
        PossibleTypes = new [] { typeof(string) })]
        string ExtensionType { get; set; }
        /// <summary>The name of the private link resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the private link resource.",
        SerializedName = @"groupName",
        PossibleTypes = new [] { typeof(string) })]
        string GroupName { get; set; }
        /// <summary>Resource identity path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Resource identity path",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>The name of the license.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the license.",
        SerializedName = @"licenseName",
        PossibleTypes = new [] { typeof(string) })]
        string LicenseName { get; set; }
        /// <summary>The name of the license profile.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the license profile.",
        SerializedName = @"licenseProfileName",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("default")]
        string LicenseProfileName { get; set; }
        /// <summary>The location of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The location of the Extension being received.",
        SerializedName = @"location",
        PossibleTypes = new [] { typeof(string) })]
        string Location { get; set; }
        /// <summary>The name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the hybrid machine.",
        SerializedName = @"machineName",
        PossibleTypes = new [] { typeof(string) })]
        string MachineName { get; set; }
        /// <summary>Name of the HybridIdentityMetadata.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Name of the HybridIdentityMetadata.",
        SerializedName = @"metadataName",
        PossibleTypes = new [] { typeof(string) })]
        string MetadataName { get; set; }
        /// <summary>The name of the hybrid machine.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the hybrid machine.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>Defines the os type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Defines the os type.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>
        /// The name, in the format {perimeterGuid}.{associationName}, of the Network Security Perimeter resource.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name, in the format {perimeterGuid}.{associationName}, of the Network Security Perimeter resource.",
        SerializedName = @"perimeterName",
        PossibleTypes = new [] { typeof(string) })]
        string PerimeterName { get; set; }
        /// <summary>The name of the private endpoint connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the private endpoint connection.",
        SerializedName = @"privateEndpointConnectionName",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>The id (Guid) of the Azure Arc PrivateLinkScope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The id (Guid) of the Azure Arc PrivateLinkScope resource.",
        SerializedName = @"privateLinkScopeId",
        PossibleTypes = new [] { typeof(string) })]
        string PrivateLinkScopeId { get; set; }
        /// <summary>The publisher of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The publisher of the Extension being received.",
        SerializedName = @"publisher",
        PossibleTypes = new [] { typeof(string) })]
        string Publisher { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the resource group. The name is case insensitive.",
        SerializedName = @"resourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The fully qualified Azure Resource manager identifier of the resource to be connected.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The fully qualified Azure Resource manager identifier of the resource to be connected.",
        SerializedName = @"resourceUri",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceUri { get; set; }
        /// <summary>The name of the run command.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the run command.",
        SerializedName = @"runCommandName",
        PossibleTypes = new [] { typeof(string) })]
        string RunCommandName { get; set; }
        /// <summary>The name of the Azure Arc PrivateLinkScope resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The name of the Azure Arc PrivateLinkScope resource.",
        SerializedName = @"scopeName",
        PossibleTypes = new [] { typeof(string) })]
        string ScopeName { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The ID of the target subscription.",
        SerializedName = @"subscriptionId",
        PossibleTypes = new [] { typeof(string) })]
        string SubscriptionId { get; set; }
        /// <summary>The version of the Extension being received.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The version of the Extension being received.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    internal partial interface IConnectedMachineIdentityInternal

    {
        /// <summary>The name of the machine extension.</summary>
        string ExtensionName { get; set; }
        /// <summary>The extensionType of the Extension being received.</summary>
        string ExtensionType { get; set; }
        /// <summary>The name of the private link resource.</summary>
        string GroupName { get; set; }
        /// <summary>Resource identity path</summary>
        string Id { get; set; }
        /// <summary>The name of the license.</summary>
        string LicenseName { get; set; }
        /// <summary>The name of the license profile.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedMachine.PSArgumentCompleterAttribute("default")]
        string LicenseProfileName { get; set; }
        /// <summary>The location of the Extension being received.</summary>
        string Location { get; set; }
        /// <summary>The name of the hybrid machine.</summary>
        string MachineName { get; set; }
        /// <summary>Name of the HybridIdentityMetadata.</summary>
        string MetadataName { get; set; }
        /// <summary>The name of the hybrid machine.</summary>
        string Name { get; set; }
        /// <summary>Defines the os type.</summary>
        string OSType { get; set; }
        /// <summary>
        /// The name, in the format {perimeterGuid}.{associationName}, of the Network Security Perimeter resource.
        /// </summary>
        string PerimeterName { get; set; }
        /// <summary>The name of the private endpoint connection.</summary>
        string PrivateEndpointConnectionName { get; set; }
        /// <summary>The id (Guid) of the Azure Arc PrivateLinkScope resource.</summary>
        string PrivateLinkScopeId { get; set; }
        /// <summary>The publisher of the Extension being received.</summary>
        string Publisher { get; set; }
        /// <summary>The name of the resource group. The name is case insensitive.</summary>
        string ResourceGroupName { get; set; }
        /// <summary>
        /// The fully qualified Azure Resource manager identifier of the resource to be connected.
        /// </summary>
        string ResourceUri { get; set; }
        /// <summary>The name of the run command.</summary>
        string RunCommandName { get; set; }
        /// <summary>The name of the Azure Arc PrivateLinkScope resource.</summary>
        string ScopeName { get; set; }
        /// <summary>The ID of the target subscription.</summary>
        string SubscriptionId { get; set; }
        /// <summary>The version of the Extension being received.</summary>
        string Version { get; set; }

    }
}