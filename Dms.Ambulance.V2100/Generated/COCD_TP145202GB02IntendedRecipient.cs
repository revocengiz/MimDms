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
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="COCD_TP145202GB02.IntendedRecipient", Namespace="urn:hl7-org:v3")]
    public partial class COCD_TP145202GB02IntendedRecipient {
        
        private AD addrField;
        
        private IINPfIToidrequiredassigningAuthorityName[] idField;
        
        private CV recipientRoleCodeField;
        
        private TEL[] telecomField;
        
        private COCD_TP145202GB02IntendedRecipientTemplateId templateIdField;
        
        private COCD_TP145202GB02Person assignedPersonField;
        
        private COCD_TP145202GB02Organization representedOrganizationField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string classCodeField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public COCD_TP145202GB02IntendedRecipient() {
            this.classCodeField = "ASSIGNED";
        }
        
        public AD addr {
            get {
                return this.addrField;
            }
            set {
                this.addrField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public IINPfIToidrequiredassigningAuthorityName[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="NPFIT:HL7:Localisation")]
        public CV recipientRoleCode {
            get {
                return this.recipientRoleCodeField;
            }
            set {
                this.recipientRoleCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("telecom")]
        public TEL[] telecom {
            get {
                return this.telecomField;
            }
            set {
                this.telecomField = value;
            }
        }
        
        public COCD_TP145202GB02IntendedRecipientTemplateId templateId {
            get {
                return this.templateIdField;
            }
            set {
                this.templateIdField = value;
            }
        }
        
        public COCD_TP145202GB02Person assignedPerson {
            get {
                return this.assignedPersonField;
            }
            set {
                this.assignedPersonField = value;
            }
        }
        
        public COCD_TP145202GB02Organization representedOrganization {
            get {
                return this.representedOrganizationField;
            }
            set {
                this.representedOrganizationField = value;
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
        public string classCode {
            get {
                return this.classCodeField;
            }
            set {
                this.classCodeField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(COCD_TP145202GB02IntendedRecipient));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current COCD_TP145202GB02IntendedRecipient object into an XML document
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
        /// Deserializes workflow markup into an COCD_TP145202GB02IntendedRecipient object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output COCD_TP145202GB02IntendedRecipient object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out COCD_TP145202GB02IntendedRecipient obj, out System.Exception exception) {
            exception = null;
            obj = default(COCD_TP145202GB02IntendedRecipient);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out COCD_TP145202GB02IntendedRecipient obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static COCD_TP145202GB02IntendedRecipient Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((COCD_TP145202GB02IntendedRecipient)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current COCD_TP145202GB02IntendedRecipient object into file
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
        /// Deserializes xml markup from file into an COCD_TP145202GB02IntendedRecipient object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output COCD_TP145202GB02IntendedRecipient object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out COCD_TP145202GB02IntendedRecipient obj, out System.Exception exception) {
            exception = null;
            obj = default(COCD_TP145202GB02IntendedRecipient);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out COCD_TP145202GB02IntendedRecipient obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static COCD_TP145202GB02IntendedRecipient LoadFromFile(string fileName) {
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
        /// Create a clone of this COCD_TP145202GB02IntendedRecipient object
        /// </summary>
        public virtual COCD_TP145202GB02IntendedRecipient Clone() {
            return ((COCD_TP145202GB02IntendedRecipient)(this.MemberwiseClone()));
        }
        #endregion
    }
}
