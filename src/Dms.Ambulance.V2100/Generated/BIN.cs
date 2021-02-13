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
    
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ensuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enprefix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(engiven))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enfamily))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(endelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpprecinct))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostBox))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcensusTract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcareOf))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdirection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumber))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostalCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcounty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcountry))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(thumbnail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.18239")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public abstract partial class BIN : ANY {
        
        private BinaryDataEncoding representationField;
        
        private string[] textField;
        
        private static System.Xml.Serialization.XmlSerializer serializer;
        
        public BIN() {
            this.representationField = BinaryDataEncoding.TXT;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public BinaryDataEncoding representation {
            get {
                return this.representationField;
            }
            set {
                this.representationField = value;
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
        
        private static System.Xml.Serialization.XmlSerializer Serializer {
            get {
                if ((serializer == null)) {
                    serializer = new System.Xml.Serialization.XmlSerializer(typeof(BIN));
                }
                return serializer;
            }
        }
        
        #region Serialize/Deserialize
        /// <summary>
        /// Serializes current BIN object into an XML document
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
        /// Deserializes workflow markup into an BIN object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output BIN object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool Deserialize(string xml, out BIN obj, out System.Exception exception) {
            exception = null;
            obj = default(BIN);
            try {
                obj = Deserialize(xml);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool Deserialize(string xml, out BIN obj) {
            System.Exception exception = null;
            return Deserialize(xml, out obj, out exception);
        }
        
        public static BIN Deserialize(string xml) {
            System.IO.StringReader stringReader = null;
            try {
                stringReader = new System.IO.StringReader(xml);
                return ((BIN)(Serializer.Deserialize(System.Xml.XmlReader.Create(stringReader))));
            }
            finally {
                if ((stringReader != null)) {
                    stringReader.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Serializes current BIN object into file
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
        /// Deserializes xml markup from file into an BIN object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output BIN object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>true if this XmlSerializer can deserialize the object; otherwise, false</returns>
        public static bool LoadFromFile(string fileName, out BIN obj, out System.Exception exception) {
            exception = null;
            obj = default(BIN);
            try {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (System.Exception ex) {
                exception = ex;
                return false;
            }
        }
        
        public static bool LoadFromFile(string fileName, out BIN obj) {
            System.Exception exception = null;
            return LoadFromFile(fileName, out obj, out exception);
        }
        
        public static BIN LoadFromFile(string fileName) {
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
        /// Create a clone of this BIN object
        /// </summary>
        public virtual BIN Clone() {
            return ((BIN)(this.MemberwiseClone()));
        }
        #endregion
    }
}