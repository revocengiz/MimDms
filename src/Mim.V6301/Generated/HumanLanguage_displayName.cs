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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:hl7-org:v3", IsNullable=false)]
    public enum HumanLanguage_displayName {
        
        /// <remarks/>
        Braille,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("American Sign Language")]
        AmericanSignLanguage,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Australian.Sign Language")]
        AustralianSignLanguage,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("British Sign Language")]
        BritishSignLanguage,
        
        /// <remarks/>
        Makaton,
        
        /// <remarks/>
        Afar,
        
        /// <remarks/>
        Abkhazian,
        
        /// <remarks/>
        Afrikaans,
        
        /// <remarks/>
        Akan,
        
        /// <remarks/>
        Albanian,
        
        /// <remarks/>
        Amharic,
        
        /// <remarks/>
        Arabic,
        
        /// <remarks/>
        Aragonese,
        
        /// <remarks/>
        Armenian,
        
        /// <remarks/>
        Assamese,
        
        /// <remarks/>
        Avaric,
        
        /// <remarks/>
        Avestan,
        
        /// <remarks/>
        Aymara,
        
        /// <remarks/>
        Azerbaijani,
        
        /// <remarks/>
        Bashkir,
        
        /// <remarks/>
        Bambara,
        
        /// <remarks/>
        Basque,
        
        /// <remarks/>
        Belarusian,
        
        /// <remarks/>
        Bengali,
        
        /// <remarks/>
        Bihari,
        
        /// <remarks/>
        Bislama,
        
        /// <remarks/>
        Tibetan,
        
        /// <remarks/>
        Bosnian,
        
        /// <remarks/>
        Breton,
        
        /// <remarks/>
        Bulgarian,
        
        /// <remarks/>
        Burmese,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Catalan; Valencian")]
        CatalanValencian,
        
        /// <remarks/>
        Czech,
        
        /// <remarks/>
        Chamorro,
        
        /// <remarks/>
        Chechen,
        
        /// <remarks/>
        Chinese,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Church Slavic; Old Slavonic; Church Slavonic; Old Bulgarian; Old Church Slavonic")]
        ChurchSlavicOldSlavonicChurchSlavonicOldBulgarianOldChurchSlavonic,
        
        /// <remarks/>
        Chuvash,
        
        /// <remarks/>
        Cornish,
        
        /// <remarks/>
        Corsican,
        
        /// <remarks/>
        Cree,
        
        /// <remarks/>
        Welsh,
        
        /// <remarks/>
        Danish,
        
        /// <remarks/>
        German,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Divehi; Dhivehi; Maldivian")]
        DivehiDhivehiMaldivian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Dutch; Flemish")]
        DutchFlemish,
        
        /// <remarks/>
        Dzongkha,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Greek, Modern (1453-)")]
        GreekModern1453,
        
        /// <remarks/>
        English,
        
        /// <remarks/>
        Esperanto,
        
        /// <remarks/>
        Estonian,
        
        /// <remarks/>
        Ewe,
        
        /// <remarks/>
        Faroese,
        
        /// <remarks/>
        Persian,
        
        /// <remarks/>
        Fijian,
        
        /// <remarks/>
        Finnish,
        
        /// <remarks/>
        French,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Western Frisian")]
        WesternFrisian,
        
        /// <remarks/>
        Fulah,
        
        /// <remarks/>
        Georgian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Gaelic; Scottish Gaelic")]
        GaelicScottishGaelic,
        
        /// <remarks/>
        Irish,
        
        /// <remarks/>
        Galician,
        
        /// <remarks/>
        Manx,
        
        /// <remarks/>
        Guarani,
        
        /// <remarks/>
        Gujarati,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Haitian; Haitian Creole")]
        HaitianHaitianCreole,
        
        /// <remarks/>
        Hausa,
        
        /// <remarks/>
        Hebrew,
        
        /// <remarks/>
        Herero,
        
        /// <remarks/>
        Hindi,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Hiri Motu")]
        HiriMotu,
        
        /// <remarks/>
        Croatian,
        
        /// <remarks/>
        Hungarian,
        
        /// <remarks/>
        Igbo,
        
        /// <remarks/>
        Icelandic,
        
        /// <remarks/>
        Ido,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sichuan Yi")]
        SichuanYi,
        
        /// <remarks/>
        Inuktitut,
        
        /// <remarks/>
        Interlingue,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Interlingua (International Auxiliary Language Association)")]
        InterlinguaInternationalAuxiliaryLanguageAssociation,
        
        /// <remarks/>
        Indonesian,
        
        /// <remarks/>
        Inupiaq,
        
        /// <remarks/>
        Italian,
        
        /// <remarks/>
        Javanese,
        
        /// <remarks/>
        Japanese,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Kalaallisut; Greenlandic")]
        KalaallisutGreenlandic,
        
        /// <remarks/>
        Kannada,
        
        /// <remarks/>
        Kashmiri,
        
        /// <remarks/>
        Kanuri,
        
        /// <remarks/>
        Kazakh,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Central Khmer")]
        CentralKhmer,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Kikuyu; Gikuyu")]
        KikuyuGikuyu,
        
        /// <remarks/>
        Kinyarwanda,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Kirghiz; Kyrgyz")]
        KirghizKyrgyz,
        
        /// <remarks/>
        Komi,
        
        /// <remarks/>
        Kongo,
        
        /// <remarks/>
        Korean,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Kuanyama; Kwanyama")]
        KuanyamaKwanyama,
        
        /// <remarks/>
        Kurdish,
        
        /// <remarks/>
        Lao,
        
        /// <remarks/>
        Latin,
        
        /// <remarks/>
        Latvian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Limburgan; Limburger; Limburgish")]
        LimburganLimburgerLimburgish,
        
        /// <remarks/>
        Lingala,
        
        /// <remarks/>
        Lithuanian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Luxembourgish; Letzeburgesch")]
        LuxembourgishLetzeburgesch,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Luba-Katanga")]
        LubaKatanga,
        
        /// <remarks/>
        Ganda,
        
        /// <remarks/>
        Macedonian,
        
        /// <remarks/>
        Marshallese,
        
        /// <remarks/>
        Malayalam,
        
        /// <remarks/>
        Maori,
        
        /// <remarks/>
        Marathi,
        
        /// <remarks/>
        Malay,
        
        /// <remarks/>
        Malagasy,
        
        /// <remarks/>
        Maltese,
        
        /// <remarks/>
        Moldavian,
        
        /// <remarks/>
        Mongolian,
        
        /// <remarks/>
        Nauru,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Navajo; Navaho")]
        NavajoNavaho,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ndebele, South; South Ndebele")]
        NdebeleSouthSouthNdebele,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ndebele, North; North Ndebele")]
        NdebeleNorthNorthNdebele,
        
        /// <remarks/>
        Ndonga,
        
        /// <remarks/>
        Nepali,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Norwegian Nynorsk; Nynorsk, Norwegian")]
        NorwegianNynorskNynorskNorwegian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Bokmål, Norwegian; Norwegian Bokmål")]
        BokmålNorwegianNorwegianBokmål,
        
        /// <remarks/>
        Norwegian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Chichewa; Chewa; Nyanja")]
        ChichewaChewaNyanja,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Occitan (post1500); Provençal")]
        Occitanpost1500Provençal,
        
        /// <remarks/>
        Ojibwa,
        
        /// <remarks/>
        Oriya,
        
        /// <remarks/>
        Oromo,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Ossetian; Ossetic")]
        OssetianOssetic,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Panjabi; Punjabi")]
        PanjabiPunjabi,
        
        /// <remarks/>
        Pali,
        
        /// <remarks/>
        Polish,
        
        /// <remarks/>
        Portuguese,
        
        /// <remarks/>
        Pushto,
        
        /// <remarks/>
        Quechua,
        
        /// <remarks/>
        Romansh,
        
        /// <remarks/>
        Romanian,
        
        /// <remarks/>
        Rundi,
        
        /// <remarks/>
        Russian,
        
        /// <remarks/>
        Sango,
        
        /// <remarks/>
        Sanskrit,
        
        /// <remarks/>
        Serbian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sinhala; Sinhalese")]
        SinhalaSinhalese,
        
        /// <remarks/>
        Slovak,
        
        /// <remarks/>
        Slovenian,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Northern Sami")]
        NorthernSami,
        
        /// <remarks/>
        Samoan,
        
        /// <remarks/>
        Shona,
        
        /// <remarks/>
        Sindhi,
        
        /// <remarks/>
        Somali,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Sotho, Southern")]
        SothoSouthern,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Spanish; Castilian")]
        SpanishCastilian,
        
        /// <remarks/>
        Sardinian,
        
        /// <remarks/>
        Swati,
        
        /// <remarks/>
        Sundanese,
        
        /// <remarks/>
        Swahili,
        
        /// <remarks/>
        Swedish,
        
        /// <remarks/>
        Tahitian,
        
        /// <remarks/>
        Tamil,
        
        /// <remarks/>
        Tatar,
        
        /// <remarks/>
        Telugu,
        
        /// <remarks/>
        Tajik,
        
        /// <remarks/>
        Tagalog,
        
        /// <remarks/>
        Thai,
        
        /// <remarks/>
        Tigrinya,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Tonga (Tonga Islands)")]
        TongaTongaIslands,
        
        /// <remarks/>
        Tswana,
        
        /// <remarks/>
        Tsonga,
        
        /// <remarks/>
        Turkmen,
        
        /// <remarks/>
        Turkish,
        
        /// <remarks/>
        Twi,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Uighur; Uyghur")]
        UighurUyghur,
        
        /// <remarks/>
        Ukrainian,
        
        /// <remarks/>
        Urdu,
        
        /// <remarks/>
        Uzbek,
        
        /// <remarks/>
        Venda,
        
        /// <remarks/>
        Vietnamese,
        
        /// <remarks/>
        Volapük,
        
        /// <remarks/>
        Walloon,
        
        /// <remarks/>
        Wolof,
        
        /// <remarks/>
        Xhosa,
        
        /// <remarks/>
        Yiddish,
        
        /// <remarks/>
        Yoruba,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Zhuang; Chuang")]
        ZhuangChuang,
        
        /// <remarks/>
        Zulu,
    }
}
