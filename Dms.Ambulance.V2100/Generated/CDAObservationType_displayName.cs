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
    public enum CDAObservationType_displayName {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("ReAdmission Flag")]
        ReAdmissionFlag,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Last Assessment Review")]
        LastAssessmentReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Planned Assessment Review")]
        PlannedAssessmentReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Copy Provided Flag")]
        CopyProvidedFlag,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Plan Agreement")]
        CarePlanAgreement,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Component Planned End Date")]
        ComponentPlannedEndDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Next Component Review")]
        NextComponentReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Last Component Review")]
        LastComponentReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CAF Information Set")]
        CAFInformationSet,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Component Text Heading Type")]
        ComponentTextHeadingType,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Estimated Discharge Date")]
        EstimatedDischargeDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Last Care Plan Review")]
        LastCarePlanReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Next Care Plan Review")]
        NextCarePlanReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Text Heading Type")]
        TextHeadingType,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Procedure Date Reported")]
        ProcedureDateReported,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("DI Report Status")]
        DIReportStatus,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Diagnostic Imaging Urgency Indicator")]
        DiagnosticImagingUrgencyIndicator,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Next Mental Health Act Tribunal Date")]
        NextMentalHealthActTribunalDate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("At Risk Register Entry")]
        AtRiskRegisterEntry,
        
        /// <remarks/>
        ProtectionRegisterCategory,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Process Date Commenced or First Review")]
        CareProcessDateCommencedorFirstReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Process Date Concluded or Most Recent Review")]
        CareProcessDateConcludedorMostRecentReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Process Administration")]
        CareProcessAdministration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Review Administration")]
        CareReviewAdministration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Process Date of Previous Review")]
        CareProcessDateofPreviousReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Process Date of Next Planned Review")]
        CareProcessDateofNextPlannedReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Other Entity Associated With Patient")]
        OtherEntityAssociatedWithPatient,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Care Review Status")]
        CareReviewStatus,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sampling Frequency")]
        SamplingFrequency,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Measurement Range Physical Quantity")]
        DeviceMeasurementRangePhysicalQuantity,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Measurement Range String")]
        DeviceMeasurementRangeString,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Resolution Physical Quantity")]
        DeviceResolutionPhysicalQuantity,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Resolution String")]
        DeviceResolutionString,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Accuracy Physical Quantity")]
        DeviceAccuracyPhysicalQuantity,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Accuracy String")]
        DeviceAccuracyString,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Waveform Sample Period Observation")]
        WaveformSamplePeriodObservation,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Test Result Observation Series")]
        TestResultObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood Pressure Observation Series")]
        BloodPressureObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("BMI Observation Series")]
        BMIObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Mean Blood Pressure Observation Series")]
        MeanBloodPressureObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Temperature Observation Series")]
        TemperatureObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Height Observation Series")]
        HeightObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Weight Observation Series")]
        WeightObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pulse Observation Series")]
        PulseObservationSeries,
        
        /// <remarks/>
        Threshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Threshold Rate")]
        ThresholdRate,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("DST Outcome")]
        DSTOutcome,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Checklist Outcome")]
        ChecklistOutcome,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("CHC Referral Status")]
        CHCReferralStatus,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("DST Eligibility Outcome")]
        DSTEligibilityOutcome,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Device Definition")]
        DeviceDefinition,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood Coagulation Observation Series")]
        BloodCoagulationObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood Glucose Observation Series")]
        BloodGlucoseObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood Pressure Observation Series")]
        BloodPressureObservationSeries1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Body Mass Index Observation Series")]
        BodyMassIndexObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Body Temperature Observation Series")]
        BodyTemperatureObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carbon Monoxide Observation Series")]
        CarbonMonoxideObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cholesterol Observation Series")]
        CholesterolObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Forced Expiratory Volume of an Observation Series")]
        ForcedExpiratoryVolumeofanObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Forced Vital Capacity Observation Series")]
        ForcedVitalCapacityObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Height Observation Series")]
        HeightObservationSeries1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Mean Blood Pressure Observation Series")]
        MeanBloodPressureObservationSeries1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Oxygen Saturation Observation Series")]
        OxygenSaturationObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Peak Flow Observation Series")]
        PeakFlowObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pulse Rate Observation Series")]
        PulseRateObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Triglycerides Observation Series")]
        TriglyceridesObservationSeries,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Weight Observation Series")]
        WeightObservationSeries1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Threshold Interpretation")]
        ThresholdInterpretation,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood Pressure Threshold")]
        BloodPressureThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Weight Threshold")]
        WeightThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pulse Rate Threshold")]
        PulseRateThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Mean Blood Pressure Threshold")]
        MeanBloodPressureThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood Glucose Threshold")]
        BloodGlucoseThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Peak Flow Threshold")]
        PeakFlowThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Forced Vital Capacity Threshold")]
        ForcedVitalCapacityThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Body Temperature Threshold")]
        BodyTemperatureThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Body Mass Index Threshold")]
        BodyMassIndexThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("FEV Threshold")]
        FEVThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Triglycerides Threshold")]
        TriglyceridesThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cholesterol Threshold")]
        CholesterolThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Oxygen Saturation Threshold")]
        OxygenSaturationThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carbon Monoxide Threshold")]
        CarbonMonoxideThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prothrombin Time Threshold")]
        ProthrombinTimeThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Activated Partial Thromboplastin Time Threshold")]
        ActivatedPartialThromboplastinTimeThreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cuff Size Observation")]
        CuffSizeObservation,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Gestational age")]
        Gestationalage,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Hips ultra sound outcome decision")]
        Hipsultrasoundoutcomedecision,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Expert management plan")]
        Expertmanagementplan,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Systolic rate of change threshold")]
        Systolicrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Diastolic rate of change threshold")]
        Diastolicrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("APTT rate of change threshold")]
        APTTrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Blood glucose rate of change threshold")]
        Bloodglucoserateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Body mass index rate of change threshold")]
        Bodymassindexrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Body temperature rate of change threshold")]
        Bodytemperaturerateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Carbon monoxide rate of change threshold")]
        Carbonmonoxiderateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Cholesterol rate of change threshold")]
        Cholesterolrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("FEV rate of change threshold")]
        FEVrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Forced vital capacity rate of change threshold")]
        Forcedvitalcapacityrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Mean blood pressure rate of change threshold")]
        Meanbloodpressurerateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Oxygen saturation rate of change threshold")]
        Oxygensaturationrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Peak flow rate of change")]
        Peakflowrateofchange,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Prothrombin time rate of change threshold")]
        Prothrombintimerateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Pulse rate rate of change threshold")]
        Pulseraterateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Triglycerides rate of change threshold")]
        Triglyceridesrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Weight rate of change threshold")]
        Weightrateofchangethreshold,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth finding type")]
        Telehealthfindingtype,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Alert reason text")]
        Alertreasontext,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Base value")]
        Basevalue,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Plan")]
        TelehealthPlan,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Plan Next Review")]
        TelehealthPlanNextReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Vital Signs Monitoring Frequency")]
        TelehealthVitalSignsMonitoringFrequency,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Vital Signs Monitoring Frequency Text")]
        TelehealthVitalSignsMonitoringFrequencyText,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Monitoring Duration")]
        TelehealthMonitoringDuration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Reporting Frequency")]
        TelehealthReportingFrequency,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Alert Care Contact Registration")]
        TelehealthAlertCareContactRegistration,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Vital Signs Monitoring Frequency PIVL")]
        TelehealthVitalSignsMonitoringFrequencyPIVL,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telehealth Vital Signs Monitoring Frequency EIVL")]
        TelehealthVitalSignsMonitoringFrequencyEIVL,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telecare Plan")]
        TelecarePlan,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telecare Plan Next Review")]
        TelecarePlanNextReview,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telecare Plan Service User Aware Of Referral")]
        TelecarePlanServiceUserAwareOfReferral,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Telecare Responders Contact Registration")]
        TelecareRespondersContactRegistration,
    }
}
