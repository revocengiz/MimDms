// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.18239 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Dms.Ambulance.V2100</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Dms.Ambulance.V2100 {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.IO;
    using System.Text;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.18239")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:hl7-org:v3", IsNullable=false)]
    public enum RegisteringAuthorityType_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Strategic Health Authority")]
        StrategicHealthAuthority,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Director of Health and Social Care")]
        DirectorofHealthandSocialCare,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("NHS Trust")]
        NHSTrust,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("GP Practice")]
        GPPractice,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other NHS Organisation")]
        OtherNHSOrganisation,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Armed Forces")]
        ArmedForces,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("MOD Hospital")]
        MODHospital,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("IM&T Service")]
        IMTService,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Special Trustee")]
        SpecialTrustee,
        
        /// <remarks/>
        University,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other Statutory Authority")]
        OtherStatutoryAuthority,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("NHS Administration Unit")]
        NHSAdministrationUnit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Breast Screening Unit")]
        BreastScreeningUnit,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pathology Laboratory")]
        PathologyLaboratory,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Department of Health")]
        DepartmentofHealth,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other Government Department")]
        OtherGovernmentDepartment,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Registered non-NHS Provider")]
        RegisterednonNHSProvider,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Unregistered non-NHS Provider (except Local Authority)")]
        UnregisterednonNHSProviderexceptLocalAuthority,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Non-NHS Commissioner (except Local Authority)")]
        NonNHSCommissionerexceptLocalAuthority,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Local Authority")]
        LocalAuthority,
        
        /// <remarks/>
        Pharmacy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Appliance Contractor")]
        ApplianceContractor,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Specialised Services Commissioning Consortium")]
        SpecialisedServicesCommissioningConsortium,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Primary Care Trust")]
        PrimaryCareTrust,
        
        /// <remarks/>
        NHAIS,
    }
}
