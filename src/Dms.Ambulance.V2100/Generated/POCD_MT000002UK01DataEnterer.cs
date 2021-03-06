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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_MT000002UK01.DataEnterer", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("POCD_MT000002UK01.DataEnterer", Namespace="urn:hl7-org:v3")]
    public partial class POCD_MT000002UK01DataEnterer {
        
        private CS[] realmCodeField;
        
        private POCD_MT000002UK01InfrastructureRoottypeId typeIdField;
        
        private II[] templateIdField;
        
        private TemplateContent contentIdField;
        
        private TS timeField;
        
        private POCD_MT000002UK01AssignedEntity assignedEntityField;
        
        private string cs_NullFlavorField;
        
        private string typeCodeField;
        
        private string contextControlCodeField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public POCD_MT000002UK01DataEnterer() {
            this.typeCodeField = "ENT";
            this.contextControlCodeField = "OP";
        }
        
        [System.Xml.Serialization.XmlElementAttribute("realmCode")]
        public CS[] realmCode {
            get {
                return this.realmCodeField;
            }
            set {
                this.realmCodeField = value;
            }
        }
        
        public POCD_MT000002UK01InfrastructureRoottypeId typeId {
            get {
                return this.typeIdField;
            }
            set {
                this.typeIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("templateId")]
        public II[] templateId {
            get {
                return this.templateIdField;
            }
            set {
                this.templateIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Namespace="NPFIT:HL7:Localisation")]
        public TemplateContent contentId {
            get {
                return this.contentIdField;
            }
            set {
                this.contentIdField = value;
            }
        }
        
        public TS time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        public POCD_MT000002UK01AssignedEntity assignedEntity {
            get {
                return this.assignedEntityField;
            }
            set {
                this.assignedEntityField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cs_NullFlavor {
            get {
                return this.cs_NullFlavorField;
            }
            set {
                this.cs_NullFlavorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string typeCode {
            get {
                return this.typeCodeField;
            }
            set {
                this.typeCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string contextControlCode {
            get {
                return this.contextControlCodeField;
            }
            set {
                this.contextControlCodeField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(POCD_MT000002UK01DataEnterer));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current POCD_MT000002UK01DataEnterer object into an XML document
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
        /// Deserializes workflow markup into an POCD_MT000002UK01DataEnterer object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output POCD_MT000002UK01DataEnterer object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out POCD_MT000002UK01DataEnterer obj, out System.Exception exception) {
            exception = null;
            obj = default(POCD_MT000002UK01DataEnterer);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out POCD_MT000002UK01DataEnterer obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static POCD_MT000002UK01DataEnterer Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((POCD_MT000002UK01DataEnterer)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current POCD_MT000002UK01DataEnterer object into file
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
        /// Deserializes xml markup from file into an POCD_MT000002UK01DataEnterer object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output POCD_MT000002UK01DataEnterer object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out POCD_MT000002UK01DataEnterer obj, out System.Exception exception) {
            exception = null;
            obj = default(POCD_MT000002UK01DataEnterer);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out POCD_MT000002UK01DataEnterer obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static POCD_MT000002UK01DataEnterer LoadFromFile(string fileName) {
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
        /// Create a clone of this POCD_MT000002UK01DataEnterer object
        /// </summary>
        public virtual POCD_MT000002UK01DataEnterer Clone() {
            return ((POCD_MT000002UK01DataEnterer)(this.MemberwiseClone()));
        }
        #endregion
    }
}
