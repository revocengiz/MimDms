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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public partial class AD : ANY {
        
        private ADXP[] itemsField;
        
        private SXCM_TS[] useablePeriodField;
        
        private string[] textField;
        
        private string[] useField;
        
        private bool isNotOrderedField;
        
        private bool isNotOrderedFieldSpecified;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        [System.Xml.Serialization.XmlElementAttribute("additionalLocator", typeof(adxpadditionalLocator))]
        [System.Xml.Serialization.XmlElementAttribute("buildingNumberSuffix", typeof(adxpbuildingNumberSuffix))]
        [System.Xml.Serialization.XmlElementAttribute("careOf", typeof(adxpcareOf))]
        [System.Xml.Serialization.XmlElementAttribute("censusTract", typeof(adxpcensusTract))]
        [System.Xml.Serialization.XmlElementAttribute("city", typeof(adxpcity))]
        [System.Xml.Serialization.XmlElementAttribute("country", typeof(adxpcountry))]
        [System.Xml.Serialization.XmlElementAttribute("county", typeof(adxpcounty))]
        [System.Xml.Serialization.XmlElementAttribute("delimiter", typeof(adxpdelimiter))]
        [System.Xml.Serialization.XmlElementAttribute("deliveryAddressLine", typeof(adxpdeliveryAddressLine))]
        [System.Xml.Serialization.XmlElementAttribute("deliveryInstallationArea", typeof(adxpdeliveryInstallationArea))]
        [System.Xml.Serialization.XmlElementAttribute("deliveryInstallationQualifier", typeof(adxpdeliveryInstallationQualifier))]
        [System.Xml.Serialization.XmlElementAttribute("deliveryInstallationType", typeof(adxpdeliveryInstallationType))]
        [System.Xml.Serialization.XmlElementAttribute("deliveryMode", typeof(adxpdeliveryMode))]
        [System.Xml.Serialization.XmlElementAttribute("deliveryModeIdentifier", typeof(adxpdeliveryModeIdentifier))]
        [System.Xml.Serialization.XmlElementAttribute("direction", typeof(adxpdirection))]
        [System.Xml.Serialization.XmlElementAttribute("houseNumber", typeof(adxphouseNumber))]
        [System.Xml.Serialization.XmlElementAttribute("houseNumberNumeric", typeof(adxphouseNumberNumeric))]
        [System.Xml.Serialization.XmlElementAttribute("postBox", typeof(adxppostBox))]
        [System.Xml.Serialization.XmlElementAttribute("postalCode", typeof(adxppostalCode))]
        [System.Xml.Serialization.XmlElementAttribute("precinct", typeof(adxpprecinct))]
        [System.Xml.Serialization.XmlElementAttribute("state", typeof(adxpstate))]
        [System.Xml.Serialization.XmlElementAttribute("streetAddressLine", typeof(adxpstreetAddressLine))]
        [System.Xml.Serialization.XmlElementAttribute("streetName", typeof(adxpstreetName))]
        [System.Xml.Serialization.XmlElementAttribute("streetNameBase", typeof(adxpstreetNameBase))]
        [System.Xml.Serialization.XmlElementAttribute("streetNameType", typeof(adxpstreetNameType))]
        [System.Xml.Serialization.XmlElementAttribute("unitID", typeof(adxpunitID))]
        [System.Xml.Serialization.XmlElementAttribute("unitType", typeof(adxpunitType))]
        public ADXP[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("useablePeriod")]
        public SXCM_TS[] useablePeriod {
            get {
                return this.useablePeriodField;
            }
            set {
                this.useablePeriodField = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text {
            get {
                return this.textField;
            }
            set {
                this.textField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string[] use {
            get {
                return this.useField;
            }
            set {
                this.useField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool isNotOrdered {
            get {
                return this.isNotOrderedField;
            }
            set {
                this.isNotOrderedField = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isNotOrderedSpecified {
            get {
                return this.isNotOrderedFieldSpecified;
            }
            set {
                this.isNotOrderedFieldSpecified = value;
            }
        }
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(AD));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current AD object into an XML document
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
        /// Deserializes workflow markup into an AD object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output AD object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out AD obj, out System.Exception exception) {
            exception = null;
            obj = default(AD);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out AD obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static AD Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((AD)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current AD object into file
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
        /// Deserializes xml markup from file into an AD object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output AD object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out AD obj, out System.Exception exception) {
            exception = null;
            obj = default(AD);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out AD obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static AD LoadFromFile(string fileName) {
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
        /// Create a clone of this AD object
        /// </summary>
        public virtual AD Clone() {
            return ((AD)(this.MemberwiseClone()));
        }
        #endregion
    }
}
