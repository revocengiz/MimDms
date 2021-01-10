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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="COCD_TP146332GB01.RequestMedicationSupply", Namespace="urn:hl7-org:v3")]
    public partial class COCD_TP146332GB01RequestMedicationSupply {
        
        private CDNPfITCDAUrl codeField;
        
        private IVL_TS effectiveTimeField;
        
        private IINPfITuuidmandatory idField;
        
        private PQ quantityField;
        
        private COCD_TP146332GB01RequestMedicationSupplyStatusCode statusCodeField;
        
        private COCD_TP146332GB01RequestMedicationSupplyTemplateId templateIdField;
        
        private COCD_TP146332GB01Author authorField;
        
        private COCD_TP146332GB01Component2 entryRelationshipField;
        
        private COCD_TP146332GB01Component entryRelationship1Field;
        
        private COCD_TP146332GB01Reference entryRelationship2Field;
        
        private COCD_TP146332GB01Location locationField;
        
        private COCD_TP146332GB01PrimaryInformationRecipient primaryInformationRecipientField;
        
        private COCD_TP146332GB01Product productField;
        
        private COCD_TP146332GB01Receiver receiverField;
        
        private COCD_TP146332GB01Tracker[] trackerField;
        
        private string nullFlavorField;
        
        private cs_UpdateMode updateModeField;
        
        private bool updateModeFieldSpecified;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public COCD_TP146332GB01RequestMedicationSupply() {
            this.classCodeField = "SPLY";
            this.moodCodeField = "RQO";
        }
        
        public CDNPfITCDAUrl code {
            get {
                return this.codeField;
            }
            set {
                this.codeField = value;
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
        
        public IINPfITuuidmandatory id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        public PQ quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
        
        public COCD_TP146332GB01RequestMedicationSupplyStatusCode statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
            }
        }
        
        public COCD_TP146332GB01RequestMedicationSupplyTemplateId templateId {
            get {
                return this.templateIdField;
            }
            set {
                this.templateIdField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public COCD_TP146332GB01Author author {
            get {
                return this.authorField;
            }
            set {
                this.authorField = value;
            }
        }
        
        public COCD_TP146332GB01Component2 entryRelationship {
            get {
                return this.entryRelationshipField;
            }
            set {
                this.entryRelationshipField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public COCD_TP146332GB01Component entryRelationship1 {
            get {
                return this.entryRelationship1Field;
            }
            set {
                this.entryRelationship1Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public COCD_TP146332GB01Reference entryRelationship2 {
            get {
                return this.entryRelationship2Field;
            }
            set {
                this.entryRelationship2Field = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public COCD_TP146332GB01Location location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public COCD_TP146332GB01PrimaryInformationRecipient primaryInformationRecipient {
            get {
                return this.primaryInformationRecipientField;
            }
            set {
                this.primaryInformationRecipientField = value;
            }
        }
        
        public COCD_TP146332GB01Product product {
            get {
                return this.productField;
            }
            set {
                this.productField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute()]
        public COCD_TP146332GB01Receiver receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("tracker")]
        public COCD_TP146332GB01Tracker[] tracker {
            get {
                return this.trackerField;
            }
            set {
                this.trackerField = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string moodCode {
            get {
                return this.moodCodeField;
            }
            set {
                this.moodCodeField = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(COCD_TP146332GB01RequestMedicationSupply));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current COCD_TP146332GB01RequestMedicationSupply object into an XML document
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
        /// Deserializes workflow markup into an COCD_TP146332GB01RequestMedicationSupply object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output COCD_TP146332GB01RequestMedicationSupply object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out COCD_TP146332GB01RequestMedicationSupply obj, out System.Exception exception) {
            exception = null;
            obj = default(COCD_TP146332GB01RequestMedicationSupply);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out COCD_TP146332GB01RequestMedicationSupply obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static COCD_TP146332GB01RequestMedicationSupply Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((COCD_TP146332GB01RequestMedicationSupply)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current COCD_TP146332GB01RequestMedicationSupply object into file
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
        /// Deserializes xml markup from file into an COCD_TP146332GB01RequestMedicationSupply object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output COCD_TP146332GB01RequestMedicationSupply object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out COCD_TP146332GB01RequestMedicationSupply obj, out System.Exception exception) {
            exception = null;
            obj = default(COCD_TP146332GB01RequestMedicationSupply);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out COCD_TP146332GB01RequestMedicationSupply obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static COCD_TP146332GB01RequestMedicationSupply LoadFromFile(string fileName) {
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
        /// Create a clone of this COCD_TP146332GB01RequestMedicationSupply object
        /// </summary>
        public virtual COCD_TP146332GB01RequestMedicationSupply Clone() {
            return ((COCD_TP146332GB01RequestMedicationSupply)(this.MemberwiseClone()));
        }
        #endregion
    }
}
