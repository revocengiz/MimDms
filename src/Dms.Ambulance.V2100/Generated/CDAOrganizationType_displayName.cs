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
    public enum CDAOrganizationType_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("General Medical Practice")]
        GeneralMedicalPractice,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("General Dental Practice")]
        GeneralDentalPractice,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Community Pharmacy")]
        CommunityPharmacy,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Community Opticians")]
        CommunityOpticians,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Primary Care Trust")]
        PrimaryCareTrust,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Strategic Health Authority")]
        StrategicHealthAuthority,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Special Health Authority")]
        SpecialHealthAuthority,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Acute Trust")]
        AcuteTrust,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Trust")]
        CareTrust,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Community Trust")]
        CommunityTrust,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Diagnostic and Investigation Centre")]
        DiagnosticandInvestigationCentre,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Walk-in Centre")]
        WalkinCentre,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("NHS Direct")]
        NHSDirect,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Local Authority Social Services Department")]
        LocalAuthoritySocialServicesDepartment,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nursing Home")]
        NursingHome,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Residential Home")]
        ResidentialHome,
        
        /// <remarks/>
        Hospice,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ambulance Trust")]
        AmbulanceTrust,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Private Hospital")]
        PrivateHospital,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("GMP Deputising Service")]
        GMPDeputisingService,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Nursing Agency")]
        NursingAgency,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Not specified")]
        Notspecified,
    }
}
