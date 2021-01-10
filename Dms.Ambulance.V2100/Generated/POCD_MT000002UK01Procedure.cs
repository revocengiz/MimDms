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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_MT000002UK01.Procedure", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("POCD_MT000002UK01.Procedure", Namespace="urn:hl7-org:v3")]
    public partial class POCD_MT000002UK01Procedure {
        
        private CS[] realmCodeField;
        
        private POCD_MT000002UK01InfrastructureRoottypeId typeIdField;
        
        private II[] templateIdField;
        
        private TemplateContent contentIdField;
        
        private II[] idField;
        
        private CDNPfITCDAUrl codeField;
        
        private ED textField;
        
        private CS statusCodeField;
        
        private IVL_TS effectiveTimeField;
        
        private CENPfITCDAUrl priorityCodeField;
        
        private CS languageCodeField;
        
        private CENPfITCDAUrl[] methodCodeField;
        
        private CDNPfITCDAUrl[] approachSiteCodeField;
        
        private CDNPfITCDAUrl[] targetSiteCodeField;
        
        private POCD_MT000002UK01Subject subjectField;
        
        private POCD_MT000002UK01Specimen[] specimenField;
        
        private POCD_MT000002UK01Performer2[] performerField;
        
        private POCD_MT000002UK01Author[] authorField;
        
        private POCD_MT000002UK01Informant12[] informantField;
        
        private POCD_MT000002UK01Participant2[] participantField;
        
        private POCD_MT000002UK01EntryRelationship[] entryRelationshipField;
        
        private POCD_MT000002UK01Reference[] referenceField;
        
        private POCD_MT000002UK01Precondition[] preconditionField;
        
        private string cs_NullFlavorField;
        
        private string classCodeField;
        
        private x_DocumentProcedureMood moodCodeField;
        
        private bool negationIndField;
        
        private bool negationIndFieldSpecified;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
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
        
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public II[] id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public CDNPfITCDAUrl code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
        
        public ED text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        public CS statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
        
        public IVL_TS effectiveTime {
            get {
                return this.effectiveTimeField;
            }
            set {
                this.effectiveTimeField = value;
            }
        }
        
        public CENPfITCDAUrl priorityCode {
            get {
                return this.priorityCodeField;
            }
            set {
                this.priorityCodeField = value;
            }
        }
        
        public CS languageCode {
            get {
                return this.languageCodeField;
            }
            set {
                this.languageCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("methodCode")]
        public CENPfITCDAUrl[] methodCode {
            get {
                return this.methodCodeField;
            }
            set {
                this.methodCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("approachSiteCode")]
        public CDNPfITCDAUrl[] approachSiteCode {
            get {
                return this.approachSiteCodeField;
            }
            set {
                this.approachSiteCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("targetSiteCode")]
        public CDNPfITCDAUrl[] targetSiteCode {
            get {
                return this.targetSiteCodeField;
            }
            set {
                this.targetSiteCodeField = value;
            }
        }
        
        public POCD_MT000002UK01Subject subject {
            get {
                return this.subjectField;
            }
            set {
                this.subjectField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("specimen")]
        public POCD_MT000002UK01Specimen[] specimen {
            get {
                return this.specimenField;
            }
            set {
                this.specimenField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("performer")]
        public POCD_MT000002UK01Performer2[] performer {
            get {
                return this.performerField;
            }
            set {
                this.performerField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public POCD_MT000002UK01Author[] author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("informant")]
        public POCD_MT000002UK01Informant12[] informant {
            get {
                return this.informantField;
            }
            set {
                this.informantField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("participant")]
        public POCD_MT000002UK01Participant2[] participant {
            get {
                return this.participantField;
            }
            set {
                this.participantField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("entryRelationship")]
        public POCD_MT000002UK01EntryRelationship[] entryRelationship {
            get {
                return this.entryRelationshipField;
            }
            set {
                this.entryRelationshipField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("reference")]
        public POCD_MT000002UK01Reference[] reference {
            get {
                return this.referenceField;
            }
            set {
                this.referenceField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("precondition")]
        public POCD_MT000002UK01Precondition[] precondition {
            get {
                return this.preconditionField;
            }
            set {
                this.preconditionField = value;
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
        public string classCode {
            get {
                return this.classCodeField;
            }
            set {
                this.classCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public x_DocumentProcedureMood moodCode {
            get {
                return this.moodCodeField;
            }
            set {
                this.moodCodeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool negationInd {
            get {
                return this.negationIndField;
            }
            set {
                this.negationIndField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool negationIndSpecified {
            get {
                return this.negationIndFieldSpecified;
            }
            set {
                this.negationIndFieldSpecified = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(POCD_MT000002UK01Procedure));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current POCD_MT000002UK01Procedure object into an XML document
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
        /// Deserializes workflow markup into an POCD_MT000002UK01Procedure object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output POCD_MT000002UK01Procedure object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out POCD_MT000002UK01Procedure obj, out System.Exception exception) {
            exception = null;
            obj = default(POCD_MT000002UK01Procedure);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out POCD_MT000002UK01Procedure obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static POCD_MT000002UK01Procedure Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((POCD_MT000002UK01Procedure)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current POCD_MT000002UK01Procedure object into file
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
        /// Deserializes xml markup from file into an POCD_MT000002UK01Procedure object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output POCD_MT000002UK01Procedure object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out POCD_MT000002UK01Procedure obj, out System.Exception exception) {
            exception = null;
            obj = default(POCD_MT000002UK01Procedure);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out POCD_MT000002UK01Procedure obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static POCD_MT000002UK01Procedure LoadFromFile(string fileName) {
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
        /// Create a clone of this POCD_MT000002UK01Procedure object
        /// </summary>
        public virtual POCD_MT000002UK01Procedure Clone() {
            return ((POCD_MT000002UK01Procedure)(this.MemberwiseClone()));
        }
        #endregion
    }
}
