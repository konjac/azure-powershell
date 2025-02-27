// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.App.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Extensions;

    /// <summary>Rendering details of a diagnostics table</summary>
    public partial class DiagnosticRendering :
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticRendering,
        Microsoft.Azure.PowerShell.Cmdlets.App.Models.IDiagnosticRenderingInternal
    {

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>Description of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="IsVisible" /> property.</summary>
        private bool? _isVisible;

        /// <summary>Flag if the table should be rendered</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public bool? IsVisible { get => this._isVisible; set => this._isVisible = value; }

        /// <summary>Backing field for <see cref="Title" /> property.</summary>
        private string _title;

        /// <summary>Title of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public string Title { get => this._title; set => this._title = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private int? _type;

        /// <summary>Rendering type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Origin(Microsoft.Azure.PowerShell.Cmdlets.App.PropertyOrigin.Owned)]
        public int? Type { get => this._type; set => this._type = value; }

        /// <summary>Creates an new <see cref="DiagnosticRendering" /> instance.</summary>
        public DiagnosticRendering()
        {

        }
    }
    /// Rendering details of a diagnostics table
    public partial interface IDiagnosticRendering :
        Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.IJsonSerializable
    {
        /// <summary>Description of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Description of the table",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>Flag if the table should be rendered</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Flag if the table should be rendered",
        SerializedName = @"isVisible",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsVisible { get; set; }
        /// <summary>Title of the table</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Title of the table",
        SerializedName = @"title",
        PossibleTypes = new [] { typeof(string) })]
        string Title { get; set; }
        /// <summary>Rendering type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.App.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Rendering type",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(int) })]
        int? Type { get; set; }

    }
    /// Rendering details of a diagnostics table
    internal partial interface IDiagnosticRenderingInternal

    {
        /// <summary>Description of the table</summary>
        string Description { get; set; }
        /// <summary>Flag if the table should be rendered</summary>
        bool? IsVisible { get; set; }
        /// <summary>Title of the table</summary>
        string Title { get; set; }
        /// <summary>Rendering type</summary>
        int? Type { get; set; }

    }
}