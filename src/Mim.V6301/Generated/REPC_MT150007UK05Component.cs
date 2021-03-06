// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.18239 Microsoft Reciprocal License (Ms-RL) 
//    <NameSpace>Mim.V6301</NameSpace><Collection>Array</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>True</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>True</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>True</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><OrderXMLAttrib>False</OrderXMLAttrib><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>True</ExcludeIncludedTypes><EnableInitializeFields>False</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace Mim.V6301 {
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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="REPC_MT150007UK05.Component", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("REPC_MT150007UK05.Component", Namespace="urn:hl7-org:v3")]
    public partial class REPC_MT150007UK05Component {
        
        private REPC_MT150007UK05ComponentTemplateId templateIdField;
        
        private REPC_MT150007UK05ComponentSeperatableInd seperatableIndField;
        
        private object itemField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string typeCodeField;
        
        private bool contextConductionIndField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public REPC_MT150007UK05Component() {
            this.typeCodeField = "COMP";
            this.contextConductionIndField = true;
        }
        
        public REPC_MT150007UK05ComponentTemplateId templateId {
            get {
                return this.templateIdField;
            }
            set {
                this.templateIdField = value;
            }
        }
        
        public REPC_MT150007UK05ComponentSeperatableInd seperatableInd {
            get {
                return this.seperatableIndField;
            }
            set {
                this.seperatableIndField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144035UK01.CareProfessionalDocumentation", typeof(UKCT_MT144035UK01CareProfessionalDocumentation))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144035UK01.PatientCarerCorrespondence", typeof(UKCT_MT144035UK01PatientCarerCorrespondence))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144035UK01.ThirdPartyCorrespondence", typeof(UKCT_MT144035UK01ThirdPartyCorrespondence))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144036UK01.AlcoholIntake", typeof(UKCT_MT144036UK01AlcoholIntake))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144036UK01.LifeStyle", typeof(UKCT_MT144036UK01LifeStyle))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144036UK01.Smoking", typeof(UKCT_MT144036UK01Smoking))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144036UK01.SocialOrPersonalCircumstance", typeof(UKCT_MT144036UK01SocialOrPersonalCircumstance))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144037UK01.CareEvent", typeof(UKCT_MT144037UK01CareEvent))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144038UK02.Problem", typeof(UKCT_MT144038UK02Problem))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144039UK02.LinkAssertion", typeof(UKCT_MT144039UK02LinkAssertion))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144039UK02.ProblemLinkAssertion", typeof(UKCT_MT144039UK02ProblemLinkAssertion))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144039UK02.ProblemMemberAssertion", typeof(UKCT_MT144039UK02ProblemMemberAssertion))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144040UK01.AcuteMedication", typeof(UKCT_MT144040UK01AcuteMedication))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144040UK01.CurrentRepeatMedication", typeof(UKCT_MT144040UK01CurrentRepeatMedication))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144040UK01.DiscontinuedRepeatMedication", typeof(UKCT_MT144040UK01DiscontinuedRepeatMedication))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144040UK01.MedicationAdministration", typeof(UKCT_MT144040UK01MedicationAdministration))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144041UK01.RiskToPerson", typeof(UKCT_MT144041UK01RiskToPerson))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144042UK01.Diagnosis", typeof(UKCT_MT144042UK01Diagnosis))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144043UK02.BloodPressure", typeof(UKCT_MT144043UK02BloodPressure))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144043UK02.Finding", typeof(UKCT_MT144043UK02Finding))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144043UK02.FindingOrganizer", typeof(UKCT_MT144043UK02FindingOrganizer))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144043UK02.Height", typeof(UKCT_MT144043UK02Height))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144043UK02.Temperature", typeof(UKCT_MT144043UK02Temperature))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144043UK02.Weight", typeof(UKCT_MT144043UK02Weight))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144044UK01.FamilyHistory", typeof(UKCT_MT144044UK01FamilyHistory))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144045UK01.Investigation", typeof(UKCT_MT144045UK01Investigation))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144046UK01.PersonalPreference", typeof(UKCT_MT144046UK01PersonalPreference))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144047UK01.Service", typeof(UKCT_MT144047UK01Service))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144048UK02.AllergyDE", typeof(UKCT_MT144048UK02AllergyDE))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144049UK01.ProvisionOfAdviceAndInformation", typeof(UKCT_MT144049UK01ProvisionOfAdviceAndInformation))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144050UK01.AdministrativeProcedure", typeof(UKCT_MT144050UK01AdministrativeProcedure))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144053UK02.Allergy", typeof(UKCT_MT144053UK02Allergy))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144054UK01.RiskToPatient", typeof(UKCT_MT144054UK01RiskToPatient))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144055UK01.Treatment", typeof(UKCT_MT144055UK01Treatment))]
        [System.Xml.Serialization.XmlElementAttribute("UKCT_MT144056UK01.Refusal", typeof(UKCT_MT144056UK01Refusal))]
        public object Item {
            get {
                return this.itemField;
            }
            set {
                this.itemField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nullFlavor {
            get {
                return this.nullFlavorField;
            }
            set {
                this.nullFlavorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public cs_UpdateMode updateMode {
            get {
                return this.updateModeField;
            }
            set {
                this.updateModeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool updateModeSpecified {
            get {
                return this.updateModeFieldSpecified;
            }
            set {
                this.updateModeFieldSpecified = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string typeCode {
            get {
                return this.typeCodeField;
            }
            set {
                this.typeCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool contextConductionInd {
            get {
                return this.contextConductionIndField;
            }
            set {
                this.contextConductionIndField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(REPC_MT150007UK05Component));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current REPC_MT150007UK05Component object into an XML document
        /// </summary>
        /// <returns>string XML value</returns>
        public virtual string Serialize() {
            System.IO.StreamReader streamReader = null;
            System.IO.MemoryStream memoryStream = null;
            try {
                memoryStream = new System.IO.MemoryStream();
                Serializer.Serialize(memoryStream, this);
                memoryStream.Seek(0, System.IO.SeekOrigin.Begin);
                streamReader = new System.IO.StreamReader(memoryStream);
                return streamReader.ReadToEnd();
            }
            finally {
                if ((streamReader != null)) {
                    streamReader.Dispose();
                }
                if ((memoryStream != null)) {
                    memoryStream.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes workflow markup into an REPC_MT150007UK05Component object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output REPC_MT150007UK05Component object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out REPC_MT150007UK05Component obj, out System.Exception exception) {
            exception = null;
            obj = default(REPC_MT150007UK05Component);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out REPC_MT150007UK05Component obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static REPC_MT150007UK05Component Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((REPC_MT150007UK05Component)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current REPC_MT150007UK05Component object into file
        /// </summary>
        /// <param name="fileName">full path of outupt xml file</param>
        /// <param name="exception">output Exception value if failed</param>
        /// <returns>true if can serialize and save into file; otherwise, false</returns>
        public virtual bool SaveToFile(string fileName, out System.Exception exception) {
            exception = null;
            try {
                SaveToFile(fileName);
                return true;
            }
            catch (System.Exception e) {
                exception = e;
                return false;
            }
        }
        
        public virtual void SaveToFile(string fileName) {
            System.IO.StreamWriter streamWriter = null;
            try {
                string xmlString = Serialize();
                System.IO.FileInfo xmlFile = new System.IO.FileInfo(fileName);
                streamWriter = xmlFile.CreateText();
                streamWriter.WriteLine(xmlString);
                streamWriter.Close();
            }
            finally {
                if ((streamWriter != null)) {
                    streamWriter.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Deserializes xml markup from file into an REPC_MT150007UK05Component object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output REPC_MT150007UK05Component object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out REPC_MT150007UK05Component obj, out System.Exception exception) {
            exception = null;
            obj = default(REPC_MT150007UK05Component);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out REPC_MT150007UK05Component obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static REPC_MT150007UK05Component LoadFromFile(string fileName) {
            System.IO.FileStream file = null;
            System.IO.StreamReader sr = null;
            try {
                file = new System.IO.FileStream(fileName, FileMode.Open, FileAccess.Read);
                sr = new System.IO.StreamReader(file);
                string xmlString = sr.ReadToEnd();
                sr.Close();
                file.Close();
                return Deserialize(xmlString);
            }
            finally {
                if ((file != null)) {
                    file.Dispose();
                }
                if ((sr != null)) {
                    sr.Dispose();
                }
            }
        }
        #endregion
        
        #region Clone method
        /// <summary>
        /// Create a clone of this REPC_MT150007UK05Component object
        /// </summary>
        public virtual REPC_MT150007UK05Component Clone() {
            return ((REPC_MT150007UK05Component)(this.MemberwiseClone()));
        }
        #endregion
    }
}
