﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.33440 using command:
//  xsd.exe "C:\Program Files\Microsoft SDKs\Azure\.NET SDK\v2.3\schemas\ServiceConfigurationSchema.xsd" 
//  /c /namespace:Microsoft.WindowsAzure.Commands.Utilities.Common.XmlSchema.ServiceConfigurationSchema  
//  /language:cs
//
namespace Microsoft.WindowsAzure.Commands.Utilities.Common.XmlSchema.ServiceConfigurationSchema
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration", IsNullable = false)]
    public partial class ServiceConfiguration
    {

        private RoleSettings[] roleField;

        private NetworkConfigurationElement networkConfigurationField;

        private GuestAgentSettingsElement guestAgentSettingsField;

        private string serviceNameField;

        private string osFamilyField;

        private string osVersionField;

        private SchemaVersion schemaVersionField;

        public ServiceConfiguration()
        {
            this.schemaVersionField = SchemaVersion.unspecified;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Role")]
        public RoleSettings[] Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        public NetworkConfigurationElement NetworkConfiguration
        {
            get
            {
                return this.networkConfigurationField;
            }
            set
            {
                this.networkConfigurationField = value;
            }
        }

        /// <remarks/>
        public GuestAgentSettingsElement GuestAgentSettings
        {
            get
            {
                return this.guestAgentSettingsField;
            }
            set
            {
                this.guestAgentSettingsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceName
        {
            get
            {
                return this.serviceNameField;
            }
            set
            {
                this.serviceNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string osFamily
        {
            get
            {
                return this.osFamilyField;
            }
            set
            {
                this.osFamilyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string osVersion
        {
            get
            {
                return this.osVersionField;
            }
            set
            {
                this.osVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SchemaVersion.unspecified)]
        public SchemaVersion schemaVersion
        {
            get
            {
                return this.schemaVersionField;
            }
            set
            {
                this.schemaVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class RoleSettings
    {

        private OsImageSetting osImageField;

        private ConfigurationSetting[] configurationSettingsField;

        private TargetSetting instancesField;

        private Certificate[] certificatesField;

        private string nameField;

        private string vmNameField;

        /// <remarks/>
        public OsImageSetting OsImage
        {
            get
            {
                return this.osImageField;
            }
            set
            {
                this.osImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Setting", IsNullable = false)]
        public ConfigurationSetting[] ConfigurationSettings
        {
            get
            {
                return this.configurationSettingsField;
            }
            set
            {
                this.configurationSettingsField = value;
            }
        }

        /// <remarks/>
        public TargetSetting Instances
        {
            get
            {
                return this.instancesField;
            }
            set
            {
                this.instancesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public Certificate[] Certificates
        {
            get
            {
                return this.certificatesField;
            }
            set
            {
                this.certificatesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vmName
        {
            get
            {
                return this.vmNameField;
            }
            set
            {
                this.vmNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class OsImageSetting
    {

        private string hrefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string href
        {
            get
            {
                return this.hrefField;
            }
            set
            {
                this.hrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class GuestAgentSettingsElement
    {

        private bool cleanupFirewallOnRoleRestartField;

        private bool allowRoleProcessLocalDumpsField;

        public GuestAgentSettingsElement()
        {
            this.cleanupFirewallOnRoleRestartField = true;
            this.allowRoleProcessLocalDumpsField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool cleanupFirewallOnRoleRestart
        {
            get
            {
                return this.cleanupFirewallOnRoleRestartField;
            }
            set
            {
                this.cleanupFirewallOnRoleRestartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool allowRoleProcessLocalDumps
        {
            get
            {
                return this.allowRoleProcessLocalDumpsField;
            }
            set
            {
                this.allowRoleProcessLocalDumpsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class RuleElement
    {

        private ushort orderField;

        private RuleAction actionField;

        private string remoteSubnetField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RuleAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string remoteSubnet
        {
            get
            {
                return this.remoteSubnetField;
            }
            set
            {
                this.remoteSubnetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public enum RuleAction
    {

        /// <remarks/>
        permit,

        /// <remarks/>
        deny,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class AccessControlElement
    {

        private RuleElement[] ruleField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rule")]
        public RuleElement[] Rule
        {
            get
            {
                return this.ruleField;
            }
            set
            {
                this.ruleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class ReservedIPElement
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class SubnetElement
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class InstanceAddressElement
    {

        private SubnetElement[] subnetsField;

        private string roleNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Subnet", IsNullable = false)]
        public SubnetElement[] Subnets
        {
            get
            {
                return this.subnetsField;
            }
            set
            {
                this.subnetsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string roleName
        {
            get
            {
                return this.roleNameField;
            }
            set
            {
                this.roleNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class AddressAssignmentsElement
    {

        private InstanceAddressElement[] instanceAddressField;

        private AddressAssignmentsElementReservedIPs reservedIPsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstanceAddress")]
        public InstanceAddressElement[] InstanceAddress
        {
            get
            {
                return this.instanceAddressField;
            }
            set
            {
                this.instanceAddressField = value;
            }
        }

        /// <remarks/>
        public AddressAssignmentsElementReservedIPs ReservedIPs
        {
            get
            {
                return this.reservedIPsField;
            }
            set
            {
                this.reservedIPsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class AddressAssignmentsElementReservedIPs
    {

        private ReservedIPElement reservedIPField;

        /// <remarks/>
        public ReservedIPElement ReservedIP
        {
            get
            {
                return this.reservedIPField;
            }
            set
            {
                this.reservedIPField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class VirtualNetworkSiteElement
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class DnsServerElement
    {

        private string nameField;

        private string iPAddressField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string IPAddress
        {
            get
            {
                return this.iPAddressField;
            }
            set
            {
                this.iPAddressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class DnsElement
    {

        private DnsServerElement[] dnsServersField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DnsServer", IsNullable = false)]
        public DnsServerElement[] DnsServers
        {
            get
            {
                return this.dnsServersField;
            }
            set
            {
                this.dnsServersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class NetworkConfigurationElement
    {

        private DnsElement dnsField;

        private VirtualNetworkSiteElement virtualNetworkSiteField;

        private AddressAssignmentsElement addressAssignmentsField;

        private AccessControlElement[] accessControlsField;

        private EndpointAclsElementEndpointAcl[] endpointAclsField;

        /// <remarks/>
        public DnsElement Dns
        {
            get
            {
                return this.dnsField;
            }
            set
            {
                this.dnsField = value;
            }
        }

        /// <remarks/>
        public VirtualNetworkSiteElement VirtualNetworkSite
        {
            get
            {
                return this.virtualNetworkSiteField;
            }
            set
            {
                this.virtualNetworkSiteField = value;
            }
        }

        /// <remarks/>
        public AddressAssignmentsElement AddressAssignments
        {
            get
            {
                return this.addressAssignmentsField;
            }
            set
            {
                this.addressAssignmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("AccessControl", IsNullable = false)]
        public AccessControlElement[] AccessControls
        {
            get
            {
                return this.accessControlsField;
            }
            set
            {
                this.accessControlsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EndpointAcl", IsNullable = false)]
        public EndpointAclsElementEndpointAcl[] EndpointAcls
        {
            get
            {
                return this.endpointAclsField;
            }
            set
            {
                this.endpointAclsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class EndpointAclsElementEndpointAcl
    {

        private string roleField;

        private string endPointField;

        private string accessControlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endPoint
        {
            get
            {
                return this.endPointField;
            }
            set
            {
                this.endPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string accessControl
        {
            get
            {
                return this.accessControlField;
            }
            set
            {
                this.accessControlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class Certificate
    {

        private string nameField;

        private string thumbprintField;

        private ThumbprintAlgorithmTypes thumbprintAlgorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string thumbprint
        {
            get
            {
                return this.thumbprintField;
            }
            set
            {
                this.thumbprintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ThumbprintAlgorithmTypes thumbprintAlgorithm
        {
            get
            {
                return this.thumbprintAlgorithmField;
            }
            set
            {
                this.thumbprintAlgorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public enum ThumbprintAlgorithmTypes
    {

        /// <remarks/>
        sha1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class TargetSetting
    {

        private int countField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int count
        {
            get
            {
                return this.countField;
            }
            set
            {
                this.countField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public partial class ConfigurationSetting
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.microsoft.com/ServiceHosting/2008/10/ServiceConfiguration")]
    public enum SchemaVersion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2014-01.2.3")]
        Item20140123,

        /// <remarks/>
        unspecified,
    }
}
