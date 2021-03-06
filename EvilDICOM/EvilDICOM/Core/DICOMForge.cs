﻿using EvilDICOM.Core.Element;

namespace EvilDICOM.Core
{
    /// <summary>
    ///     Class for creating strongly typed elements on the fly
    /// </summary>
    public class DICOMForge
    {
        public static UnsignedLong CommandLengthToEndRetired
        {
            get { return new UnsignedLong {Tag = new Tag("00000001")}; }
        }

        public static UniqueIdentifier AffectedSOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00000002")}; }
        }

        public static UniqueIdentifier RequestedSOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00000003")}; }
        }

        public static ShortString CommandRecognitionCodeRetired
        {
            get { return new ShortString {Tag = new Tag("00000010")}; }
        }

        public static UnsignedShort CommandField
        {
            get { return new UnsignedShort {Tag = new Tag("00000100")}; }
        }

        public static UnsignedShort MessageID
        {
            get { return new UnsignedShort {Tag = new Tag("00000110")}; }
        }

        public static UnsignedShort MessageIDBeingRespondedTo
        {
            get { return new UnsignedShort {Tag = new Tag("00000120")}; }
        }

        public static ApplicationEntity InitiatorRetired
        {
            get { return new ApplicationEntity {Tag = new Tag("00000200")}; }
        }

        public static ApplicationEntity ReceiverRetired
        {
            get { return new ApplicationEntity {Tag = new Tag("00000300")}; }
        }

        public static ApplicationEntity FindLocationRetired
        {
            get { return new ApplicationEntity {Tag = new Tag("00000400")}; }
        }

        public static ApplicationEntity MoveDestination
        {
            get { return new ApplicationEntity {Tag = new Tag("00000600")}; }
        }

        public static UnsignedShort Priority
        {
            get { return new UnsignedShort {Tag = new Tag("00000700")}; }
        }

        public static UnsignedShort CommandDataSetType
        {
            get { return new UnsignedShort {Tag = new Tag("00000800")}; }
        }

        public static UnsignedShort NumberOfMatchesRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00000850")}; }
        }

        public static UnsignedShort ResponseSequenceNumberRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00000860")}; }
        }

        public static UnsignedShort Status
        {
            get { return new UnsignedShort {Tag = new Tag("00000900")}; }
        }

        public static AttributeTag OffendingElement
        {
            get { return new AttributeTag {Tag = new Tag("00000901")}; }
        }

        public static LongString ErrorComment
        {
            get { return new LongString {Tag = new Tag("00000902")}; }
        }

        public static UnsignedShort ErrorID
        {
            get { return new UnsignedShort {Tag = new Tag("00000903")}; }
        }

        public static UniqueIdentifier AffectedSOPInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00001000")}; }
        }

        public static UniqueIdentifier RequestedSOPInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00001001")}; }
        }

        public static UnsignedShort EventTypeID
        {
            get { return new UnsignedShort {Tag = new Tag("00001002")}; }
        }

        public static AttributeTag AttributeIdentifierList
        {
            get { return new AttributeTag {Tag = new Tag("00001005")}; }
        }

        public static UnsignedShort ActionTypeID
        {
            get { return new UnsignedShort {Tag = new Tag("00001008")}; }
        }

        public static UnsignedShort NumberOfRemainingSuboperations
        {
            get { return new UnsignedShort {Tag = new Tag("00001020")}; }
        }

        public static UnsignedShort NumberOfCompletedSuboperations
        {
            get { return new UnsignedShort {Tag = new Tag("00001021")}; }
        }

        public static UnsignedShort NumberOfFailedSuboperations
        {
            get { return new UnsignedShort {Tag = new Tag("00001022")}; }
        }

        public static UnsignedShort NumberOfWarningSuboperations
        {
            get { return new UnsignedShort {Tag = new Tag("00001023")}; }
        }

        public static ApplicationEntity MoveOriginatorApplicationEntityTitle
        {
            get { return new ApplicationEntity {Tag = new Tag("00001030")}; }
        }

        public static UnsignedShort MoveOriginatorMessageID
        {
            get { return new UnsignedShort {Tag = new Tag("00001031")}; }
        }

        public static LongText DialogReceiverRetired
        {
            get { return new LongText {Tag = new Tag("00004000")}; }
        }

        public static LongText TerminalTypeRetired
        {
            get { return new LongText {Tag = new Tag("00004010")}; }
        }

        public static ShortString MessageSetIDRetired
        {
            get { return new ShortString {Tag = new Tag("00005010")}; }
        }

        public static ShortString EndMessageIDRetired
        {
            get { return new ShortString {Tag = new Tag("00005020")}; }
        }

        public static LongText DisplayFormatRetired
        {
            get { return new LongText {Tag = new Tag("00005110")}; }
        }

        public static LongText PagePositionIDRetired
        {
            get { return new LongText {Tag = new Tag("00005120")}; }
        }

        public static CodeString TextFormatIDRetired
        {
            get { return new CodeString {Tag = new Tag("00005130")}; }
        }

        public static CodeString NormalReverseRetired
        {
            get { return new CodeString {Tag = new Tag("00005140")}; }
        }

        public static CodeString AddGrayScaleRetired
        {
            get { return new CodeString {Tag = new Tag("00005150")}; }
        }

        public static CodeString BordersRetired
        {
            get { return new CodeString {Tag = new Tag("00005160")}; }
        }

        public static IntegerString CopiesRetired
        {
            get { return new IntegerString {Tag = new Tag("00005170")}; }
        }

        public static CodeString CommandMagnificationTypeRetired
        {
            get { return new CodeString {Tag = new Tag("00005180")}; }
        }

        public static CodeString EraseRetired
        {
            get { return new CodeString {Tag = new Tag("00005190")}; }
        }

        public static CodeString PrintRetired
        {
            get { return new CodeString {Tag = new Tag("000051A0")}; }
        }

        public static UnsignedShort OverlaysRetired
        {
            get { return new UnsignedShort {Tag = new Tag("000051B0")}; }
        }

        public static OtherByteString FileMetaInformationVersion
        {
            get { return new OtherByteString {Tag = new Tag("00020001")}; }
        }

        public static UniqueIdentifier MediaStorageSOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00020002")}; }
        }

        public static UniqueIdentifier MediaStorageSOPInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00020003")}; }
        }

        public static UniqueIdentifier TransferSyntaxUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00020010")}; }
        }

        public static UniqueIdentifier ImplementationClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00020012")}; }
        }

        public static ShortString ImplementationVersionName
        {
            get { return new ShortString {Tag = new Tag("00020013")}; }
        }

        public static ApplicationEntity SourceApplicationEntityTitle
        {
            get { return new ApplicationEntity {Tag = new Tag("00020016")}; }
        }

        public static UniqueIdentifier PrivateInformationCreatorUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00020100")}; }
        }

        public static OtherByteString PrivateInformation
        {
            get { return new OtherByteString {Tag = new Tag("00020102")}; }
        }

        public static CodeString FileSetID
        {
            get { return new CodeString {Tag = new Tag("00041130")}; }
        }

        public static CodeString FileSetDescriptorFileID
        {
            get { return new CodeString {Tag = new Tag("00041141")}; }
        }

        public static CodeString SpecificCharacterSetOfFileSetDescriptorFile
        {
            get { return new CodeString {Tag = new Tag("00041142")}; }
        }

        public static UnsignedLong OffsetOfTheFirstDirectoryRecordOfTheRootDirectoryEntity
        {
            get { return new UnsignedLong {Tag = new Tag("00041200")}; }
        }

        public static UnsignedLong OffsetOfTheLastDirectoryRecordOfTheRootDirectoryEntity
        {
            get { return new UnsignedLong {Tag = new Tag("00041202")}; }
        }

        public static UnsignedShort FileSetConsistencyFlag
        {
            get { return new UnsignedShort {Tag = new Tag("00041212")}; }
        }

        public static Sequence DirectoryRecordSequence
        {
            get { return new Sequence {Tag = new Tag("00041220")}; }
        }

        public static UnsignedLong OffsetOfTheNextDirectoryRecord
        {
            get { return new UnsignedLong {Tag = new Tag("00041400")}; }
        }

        public static UnsignedShort RecordInUseFlag
        {
            get { return new UnsignedShort {Tag = new Tag("00041410")}; }
        }

        public static UnsignedLong OffsetOfReferencedLowerLevelDirectoryEntity
        {
            get { return new UnsignedLong {Tag = new Tag("00041420")}; }
        }

        public static CodeString DirectoryRecordType
        {
            get { return new CodeString {Tag = new Tag("00041430")}; }
        }

        public static UniqueIdentifier PrivateRecordUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00041432")}; }
        }

        public static CodeString ReferencedFileID
        {
            get { return new CodeString {Tag = new Tag("00041500")}; }
        }

        public static UnsignedLong MRDRDirectoryRecordOffsetRetired
        {
            get { return new UnsignedLong {Tag = new Tag("00041504")}; }
        }

        public static UniqueIdentifier ReferencedSOPClassUIDInFile
        {
            get { return new UniqueIdentifier {Tag = new Tag("00041510")}; }
        }

        public static UniqueIdentifier ReferencedSOPInstanceUIDInFile
        {
            get { return new UniqueIdentifier {Tag = new Tag("00041511")}; }
        }

        public static UniqueIdentifier ReferencedTransferSyntaxUIDInFile
        {
            get { return new UniqueIdentifier {Tag = new Tag("00041512")}; }
        }

        public static UniqueIdentifier ReferencedRelatedGeneralSOPClassUIDInFile
        {
            get { return new UniqueIdentifier {Tag = new Tag("0004151A")}; }
        }

        public static UnsignedLong NumberOfReferencesRetired
        {
            get { return new UnsignedLong {Tag = new Tag("00041600")}; }
        }

        public static UnsignedLong LengthToEndRetired
        {
            get { return new UnsignedLong {Tag = new Tag("00080001")}; }
        }

        public static CodeString SpecificCharacterSet
        {
            get { return new CodeString {Tag = new Tag("00080005")}; }
        }

        public static Sequence LanguageCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00080006")}; }
        }

        public static CodeString ImageType
        {
            get { return new CodeString {Tag = new Tag("00080008")}; }
        }

        public static ShortString RecognitionCodeRetired
        {
            get { return new ShortString {Tag = new Tag("00080010")}; }
        }

        public static Date InstanceCreationDate
        {
            get { return new Date {Tag = new Tag("00080012")}; }
        }

        public static Time InstanceCreationTime
        {
            get { return new Time {Tag = new Tag("00080013")}; }
        }

        public static UniqueIdentifier InstanceCreatorUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00080014")}; }
        }

        public static UniqueIdentifier SOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00080016")}; }
        }

        public static UniqueIdentifier SOPInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00080018")}; }
        }

        public static UniqueIdentifier RelatedGeneralSOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0008001A")}; }
        }

        public static UniqueIdentifier OriginalSpecializedSOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0008001B")}; }
        }

        public static Date StudyDate
        {
            get { return new Date {Tag = new Tag("00080020")}; }
        }

        public static Date SeriesDate
        {
            get { return new Date {Tag = new Tag("00080021")}; }
        }

        public static Date AcquisitionDate
        {
            get { return new Date {Tag = new Tag("00080022")}; }
        }

        public static Date ContentDate
        {
            get { return new Date {Tag = new Tag("00080023")}; }
        }

        public static Date OverlayDateRetired
        {
            get { return new Date {Tag = new Tag("00080024")}; }
        }

        public static Date CurveDateRetired
        {
            get { return new Date {Tag = new Tag("00080025")}; }
        }

        public static Time StudyTime
        {
            get { return new Time {Tag = new Tag("00080030")}; }
        }

        public static Time SeriesTime
        {
            get { return new Time {Tag = new Tag("00080031")}; }
        }

        public static Time AcquisitionTime
        {
            get { return new Time {Tag = new Tag("00080032")}; }
        }

        public static Time ContentTime
        {
            get { return new Time {Tag = new Tag("00080033")}; }
        }

        public static Time OverlayTimeRetired
        {
            get { return new Time {Tag = new Tag("00080034")}; }
        }

        public static Time CurveTimeRetired
        {
            get { return new Time {Tag = new Tag("00080035")}; }
        }

        public static UnsignedShort DataSetTypeRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00080040")}; }
        }

        public static LongString DataSetSubtypeRetired
        {
            get { return new LongString {Tag = new Tag("00080041")}; }
        }

        public static CodeString NuclearMedicineSeriesTypeRetired
        {
            get { return new CodeString {Tag = new Tag("00080042")}; }
        }

        public static ShortString AccessionNumber
        {
            get { return new ShortString {Tag = new Tag("00080050")}; }
        }

        public static Sequence IssuerOfAccessionNumberSequence
        {
            get { return new Sequence {Tag = new Tag("00080051")}; }
        }

        public static CodeString QueryRetrieveLevel
        {
            get { return new CodeString {Tag = new Tag("00080052")}; }
        }

        public static ApplicationEntity RetrieveAETitle
        {
            get { return new ApplicationEntity {Tag = new Tag("00080054")}; }
        }

        public static CodeString InstanceAvailability
        {
            get { return new CodeString {Tag = new Tag("00080056")}; }
        }

        public static UniqueIdentifier FailedSOPInstanceUIDList
        {
            get { return new UniqueIdentifier {Tag = new Tag("00080058")}; }
        }

        public static CodeString Modality
        {
            get { return new CodeString {Tag = new Tag("00080060")}; }
        }

        public static CodeString ModalitiesInStudy
        {
            get { return new CodeString {Tag = new Tag("00080061")}; }
        }

        public static UniqueIdentifier SOPClassesInStudy
        {
            get { return new UniqueIdentifier {Tag = new Tag("00080062")}; }
        }

        public static CodeString ConversionType
        {
            get { return new CodeString {Tag = new Tag("00080064")}; }
        }

        public static CodeString PresentationIntentType
        {
            get { return new CodeString {Tag = new Tag("00080068")}; }
        }

        public static LongString Manufacturer
        {
            get { return new LongString {Tag = new Tag("00080070")}; }
        }

        public static LongString InstitutionName
        {
            get { return new LongString {Tag = new Tag("00080080")}; }
        }

        public static ShortText InstitutionAddress
        {
            get { return new ShortText {Tag = new Tag("00080081")}; }
        }

        public static Sequence InstitutionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00080082")}; }
        }

        public static PersonName ReferringPhysicianName
        {
            get { return new PersonName {Tag = new Tag("00080090")}; }
        }

        public static ShortText ReferringPhysicianAddress
        {
            get { return new ShortText {Tag = new Tag("00080092")}; }
        }

        public static ShortString ReferringPhysicianTelephoneNumbers
        {
            get { return new ShortString {Tag = new Tag("00080094")}; }
        }

        public static Sequence ReferringPhysicianIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00080096")}; }
        }

        public static ShortString CodeValue
        {
            get { return new ShortString {Tag = new Tag("00080100")}; }
        }

        public static ShortString CodingSchemeDesignator
        {
            get { return new ShortString {Tag = new Tag("00080102")}; }
        }

        public static ShortString CodingSchemeVersion
        {
            get { return new ShortString {Tag = new Tag("00080103")}; }
        }

        public static LongString CodeMeaning
        {
            get { return new LongString {Tag = new Tag("00080104")}; }
        }

        public static CodeString MappingResource
        {
            get { return new CodeString {Tag = new Tag("00080105")}; }
        }

        public static CodeString ContextGroupExtensionFlag
        {
            get { return new CodeString {Tag = new Tag("0008010B")}; }
        }

        public static UniqueIdentifier CodingSchemeUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0008010C")}; }
        }

        public static UniqueIdentifier ContextGroupExtensionCreatorUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0008010D")}; }
        }

        public static CodeString ContextIdentifier
        {
            get { return new CodeString {Tag = new Tag("0008010F")}; }
        }

        public static Sequence CodingSchemeIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00080110")}; }
        }

        public static LongString CodingSchemeRegistry
        {
            get { return new LongString {Tag = new Tag("00080112")}; }
        }

        public static ShortText CodingSchemeExternalID
        {
            get { return new ShortText {Tag = new Tag("00080114")}; }
        }

        public static ShortText CodingSchemeName
        {
            get { return new ShortText {Tag = new Tag("00080115")}; }
        }

        public static ShortText CodingSchemeResponsibleOrganization
        {
            get { return new ShortText {Tag = new Tag("00080116")}; }
        }

        public static UniqueIdentifier ContextUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00080117")}; }
        }

        public static ShortString TimezoneOffsetFromUTC
        {
            get { return new ShortString {Tag = new Tag("00080201")}; }
        }

        public static ApplicationEntity NetworkIDRetired
        {
            get { return new ApplicationEntity {Tag = new Tag("00081000")}; }
        }

        public static ShortString StationName
        {
            get { return new ShortString {Tag = new Tag("00081010")}; }
        }

        public static LongString StudyDescription
        {
            get { return new LongString {Tag = new Tag("00081030")}; }
        }

        public static Sequence ProcedureCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00081032")}; }
        }

        public static LongString SeriesDescription
        {
            get { return new LongString {Tag = new Tag("0008103E")}; }
        }

        public static Sequence SeriesDescriptionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0008103F")}; }
        }

        public static LongString InstitutionalDepartmentName
        {
            get { return new LongString {Tag = new Tag("00081040")}; }
        }

        public static PersonName PhysiciansOfRecord
        {
            get { return new PersonName {Tag = new Tag("00081048")}; }
        }

        public static Sequence PhysiciansOfRecordIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00081049")}; }
        }

        public static PersonName PerformingPhysicianName
        {
            get { return new PersonName {Tag = new Tag("00081050")}; }
        }

        public static Sequence PerformingPhysicianIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00081052")}; }
        }

        public static PersonName NameOfPhysiciansReadingStudy
        {
            get { return new PersonName {Tag = new Tag("00081060")}; }
        }

        public static Sequence PhysiciansReadingStudyIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00081062")}; }
        }

        public static PersonName OperatorsName
        {
            get { return new PersonName {Tag = new Tag("00081070")}; }
        }

        public static Sequence OperatorIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00081072")}; }
        }

        public static LongString AdmittingDiagnosesDescription
        {
            get { return new LongString {Tag = new Tag("00081080")}; }
        }

        public static Sequence AdmittingDiagnosesCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00081084")}; }
        }

        public static LongString ManufacturerModelName
        {
            get { return new LongString {Tag = new Tag("00081090")}; }
        }

        public static Sequence ReferencedResultsSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00081100")}; }
        }

        public static Sequence ReferencedStudySequence
        {
            get { return new Sequence {Tag = new Tag("00081110")}; }
        }

        public static Sequence ReferencedPerformedProcedureStepSequence
        {
            get { return new Sequence {Tag = new Tag("00081111")}; }
        }

        public static Sequence ReferencedSeriesSequence
        {
            get { return new Sequence {Tag = new Tag("00081115")}; }
        }

        public static Sequence ReferencedPatientSequence
        {
            get { return new Sequence {Tag = new Tag("00081120")}; }
        }

        public static Sequence ReferencedVisitSequence
        {
            get { return new Sequence {Tag = new Tag("00081125")}; }
        }

        public static Sequence ReferencedOverlaySequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00081130")}; }
        }

        public static Sequence ReferencedStereometricInstanceSequence
        {
            get { return new Sequence {Tag = new Tag("00081134")}; }
        }

        public static Sequence ReferencedWaveformSequence
        {
            get { return new Sequence {Tag = new Tag("0008113A")}; }
        }

        public static Sequence ReferencedImageSequence
        {
            get { return new Sequence {Tag = new Tag("00081140")}; }
        }

        public static Sequence ReferencedCurveSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00081145")}; }
        }

        public static Sequence ReferencedInstanceSequence
        {
            get { return new Sequence {Tag = new Tag("0008114A")}; }
        }

        public static Sequence ReferencedRealWorldValueMappingInstanceSequence
        {
            get { return new Sequence {Tag = new Tag("0008114B")}; }
        }

        public static UniqueIdentifier ReferencedSOPClassUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00081150")}; }
        }

        public static UniqueIdentifier ReferencedSOPInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00081155")}; }
        }

        public static UniqueIdentifier SOPClassesSupported
        {
            get { return new UniqueIdentifier {Tag = new Tag("0008115A")}; }
        }

        public static IntegerString ReferencedFrameNumber
        {
            get { return new IntegerString {Tag = new Tag("00081160")}; }
        }

        public static UnsignedLong SimpleFrameList
        {
            get { return new UnsignedLong {Tag = new Tag("00081161")}; }
        }

        public static UnsignedLong CalculatedFrameList
        {
            get { return new UnsignedLong {Tag = new Tag("00081162")}; }
        }

        public static FloatingPointDouble TimeRange
        {
            get { return new FloatingPointDouble {Tag = new Tag("00081163")}; }
        }

        public static Sequence FrameExtractionSequence
        {
            get { return new Sequence {Tag = new Tag("00081164")}; }
        }

        public static UniqueIdentifier MultiFrameSourceSOPInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00081167")}; }
        }

        public static UniqueIdentifier TransactionUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00081195")}; }
        }

        public static UnsignedShort FailureReason
        {
            get { return new UnsignedShort {Tag = new Tag("00081197")}; }
        }

        public static Sequence FailedSOPSequence
        {
            get { return new Sequence {Tag = new Tag("00081198")}; }
        }

        public static Sequence ReferencedSOPSequence
        {
            get { return new Sequence {Tag = new Tag("00081199")}; }
        }

        public static Sequence StudiesContainingOtherReferencedInstancesSequence
        {
            get { return new Sequence {Tag = new Tag("00081200")}; }
        }

        public static Sequence RelatedSeriesSequence
        {
            get { return new Sequence {Tag = new Tag("00081250")}; }
        }

        public static CodeString LossyImageCompressionRetired
        {
            get { return new CodeString {Tag = new Tag("00082110")}; }
        }

        public static ShortText DerivationDescription
        {
            get { return new ShortText {Tag = new Tag("00082111")}; }
        }

        public static Sequence SourceImageSequence
        {
            get { return new Sequence {Tag = new Tag("00082112")}; }
        }

        public static ShortString StageName
        {
            get { return new ShortString {Tag = new Tag("00082120")}; }
        }

        public static IntegerString StageNumber
        {
            get { return new IntegerString {Tag = new Tag("00082122")}; }
        }

        public static IntegerString NumberOfStages
        {
            get { return new IntegerString {Tag = new Tag("00082124")}; }
        }

        public static ShortString ViewName
        {
            get { return new ShortString {Tag = new Tag("00082127")}; }
        }

        public static IntegerString ViewNumber
        {
            get { return new IntegerString {Tag = new Tag("00082128")}; }
        }

        public static IntegerString NumberOfEventTimers
        {
            get { return new IntegerString {Tag = new Tag("00082129")}; }
        }

        public static IntegerString NumberOfViewsInStage
        {
            get { return new IntegerString {Tag = new Tag("0008212A")}; }
        }

        public static DecimalString EventElapsedTimes
        {
            get { return new DecimalString {Tag = new Tag("00082130")}; }
        }

        public static LongString EventTimerNames
        {
            get { return new LongString {Tag = new Tag("00082132")}; }
        }

        public static Sequence EventTimerSequence
        {
            get { return new Sequence {Tag = new Tag("00082133")}; }
        }

        public static FloatingPointDouble EventTimeOffset
        {
            get { return new FloatingPointDouble {Tag = new Tag("00082134")}; }
        }

        public static Sequence EventCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00082135")}; }
        }

        public static IntegerString StartTrim
        {
            get { return new IntegerString {Tag = new Tag("00082142")}; }
        }

        public static IntegerString StopTrim
        {
            get { return new IntegerString {Tag = new Tag("00082143")}; }
        }

        public static IntegerString RecommendedDisplayFrameRate
        {
            get { return new IntegerString {Tag = new Tag("00082144")}; }
        }

        public static CodeString TransducerPositionRetired
        {
            get { return new CodeString {Tag = new Tag("00082200")}; }
        }

        public static CodeString TransducerOrientationRetired
        {
            get { return new CodeString {Tag = new Tag("00082204")}; }
        }

        public static CodeString AnatomicStructureRetired
        {
            get { return new CodeString {Tag = new Tag("00082208")}; }
        }

        public static Sequence AnatomicRegionSequence
        {
            get { return new Sequence {Tag = new Tag("00082218")}; }
        }

        public static Sequence AnatomicRegionModifierSequence
        {
            get { return new Sequence {Tag = new Tag("00082220")}; }
        }

        public static Sequence PrimaryAnatomicStructureSequence
        {
            get { return new Sequence {Tag = new Tag("00082228")}; }
        }

        public static Sequence AnatomicStructureSpaceOrRegionSequence
        {
            get { return new Sequence {Tag = new Tag("00082229")}; }
        }

        public static Sequence PrimaryAnatomicStructureModifierSequence
        {
            get { return new Sequence {Tag = new Tag("00082230")}; }
        }

        public static Sequence TransducerPositionSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00082240")}; }
        }

        public static Sequence TransducerPositionModifierSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00082242")}; }
        }

        public static Sequence TransducerOrientationSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00082244")}; }
        }

        public static Sequence TransducerOrientationModifierSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00082246")}; }
        }

        public static Sequence AnatomicStructureSpaceOrRegionCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("00082251")}; }
        }

        public static Sequence AnatomicPortalOfEntranceCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("00082253")}; }
        }

        public static Sequence AnatomicApproachDirectionCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("00082255")}; }
        }

        public static ShortText AnatomicPerspectiveDescriptionTrialRetired
        {
            get { return new ShortText {Tag = new Tag("00082256")}; }
        }

        public static Sequence AnatomicPerspectiveCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("00082257")}; }
        }

        public static ShortText AnatomicLocationOfExaminingInstrumentDescriptionTrialRetired
        {
            get { return new ShortText {Tag = new Tag("00082258")}; }
        }

        public static Sequence AnatomicLocationOfExaminingInstrumentCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("00082259")}; }
        }

        public static Sequence AnatomicStructureSpaceOrRegionModifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0008225A")}; }
        }

        public static Sequence OnAxisBackgroundAnatomicStructureCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0008225C")}; }
        }

        public static Sequence AlternateRepresentationSequence
        {
            get { return new Sequence {Tag = new Tag("00083001")}; }
        }

        public static UniqueIdentifier IrradiationEventUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00083010")}; }
        }

        public static LongText IdentifyingCommentsRetired
        {
            get { return new LongText {Tag = new Tag("00084000")}; }
        }

        public static CodeString FrameType
        {
            get { return new CodeString {Tag = new Tag("00089007")}; }
        }

        public static Sequence ReferencedImageEvidenceSequence
        {
            get { return new Sequence {Tag = new Tag("00089092")}; }
        }

        public static Sequence ReferencedRawDataSequence
        {
            get { return new Sequence {Tag = new Tag("00089121")}; }
        }

        public static UniqueIdentifier CreatorVersionUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00089123")}; }
        }

        public static Sequence DerivationImageSequence
        {
            get { return new Sequence {Tag = new Tag("00089124")}; }
        }

        public static Sequence SourceImageEvidenceSequence
        {
            get { return new Sequence {Tag = new Tag("00089154")}; }
        }

        public static CodeString PixelPresentation
        {
            get { return new CodeString {Tag = new Tag("00089205")}; }
        }

        public static CodeString VolumetricProperties
        {
            get { return new CodeString {Tag = new Tag("00089206")}; }
        }

        public static CodeString VolumeBasedCalculationTechnique
        {
            get { return new CodeString {Tag = new Tag("00089207")}; }
        }

        public static CodeString ComplexImageComponent
        {
            get { return new CodeString {Tag = new Tag("00089208")}; }
        }

        public static CodeString AcquisitionContrast
        {
            get { return new CodeString {Tag = new Tag("00089209")}; }
        }

        public static Sequence DerivationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00089215")}; }
        }

        public static Sequence ReferencedPresentationStateSequence
        {
            get { return new Sequence {Tag = new Tag("00089237")}; }
        }

        public static Sequence ReferencedOtherPlaneSequence
        {
            get { return new Sequence {Tag = new Tag("00089410")}; }
        }

        public static Sequence FrameDisplaySequence
        {
            get { return new Sequence {Tag = new Tag("00089458")}; }
        }

        public static FloatingPointSingle RecommendedDisplayFrameRateInFloat
        {
            get { return new FloatingPointSingle {Tag = new Tag("00089459")}; }
        }

        public static CodeString SkipFrameRangeFlag
        {
            get { return new CodeString {Tag = new Tag("00089460")}; }
        }

        public static PersonName PatientName
        {
            get { return new PersonName {Tag = new Tag("00100010")}; }
        }

        public static LongString PatientID
        {
            get { return new LongString {Tag = new Tag("00100020")}; }
        }

        public static LongString IssuerOfPatientID
        {
            get { return new LongString {Tag = new Tag("00100021")}; }
        }

        public static CodeString TypeOfPatientID
        {
            get { return new CodeString {Tag = new Tag("00100022")}; }
        }

        public static Sequence IssuerOfPatientIDQualifiersSequence
        {
            get { return new Sequence {Tag = new Tag("00100024")}; }
        }

        public static Date PatientBirthDate
        {
            get { return new Date {Tag = new Tag("00100030")}; }
        }

        public static Time PatientBirthTime
        {
            get { return new Time {Tag = new Tag("00100032")}; }
        }

        public static CodeString PatientSex
        {
            get { return new CodeString {Tag = new Tag("00100040")}; }
        }

        public static Sequence PatientInsurancePlanCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00100050")}; }
        }

        public static Sequence PatientPrimaryLanguageCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00100101")}; }
        }

        public static Sequence PatientPrimaryLanguageModifierCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00100102")}; }
        }

        public static LongString OtherPatientIDs
        {
            get { return new LongString {Tag = new Tag("00101000")}; }
        }

        public static PersonName OtherPatientNames
        {
            get { return new PersonName {Tag = new Tag("00101001")}; }
        }

        public static Sequence OtherPatientIDsSequence
        {
            get { return new Sequence {Tag = new Tag("00101002")}; }
        }

        public static PersonName PatientBirthName
        {
            get { return new PersonName {Tag = new Tag("00101005")}; }
        }

        public static AgeString PatientAge
        {
            get { return new AgeString {Tag = new Tag("00101010")}; }
        }

        public static DecimalString PatientSize
        {
            get { return new DecimalString {Tag = new Tag("00101020")}; }
        }

        public static Sequence PatientSizeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00101021")}; }
        }

        public static DecimalString PatientWeight
        {
            get { return new DecimalString {Tag = new Tag("00101030")}; }
        }

        public static LongString PatientAddress
        {
            get { return new LongString {Tag = new Tag("00101040")}; }
        }

        public static LongString InsurancePlanIdentificationRetired
        {
            get { return new LongString {Tag = new Tag("00101050")}; }
        }

        public static PersonName PatientMotherBirthName
        {
            get { return new PersonName {Tag = new Tag("00101060")}; }
        }

        public static LongString MilitaryRank
        {
            get { return new LongString {Tag = new Tag("00101080")}; }
        }

        public static LongString BranchOfService
        {
            get { return new LongString {Tag = new Tag("00101081")}; }
        }

        public static LongString MedicalRecordLocator
        {
            get { return new LongString {Tag = new Tag("00101090")}; }
        }

        public static LongString MedicalAlerts
        {
            get { return new LongString {Tag = new Tag("00102000")}; }
        }

        public static LongString Allergies
        {
            get { return new LongString {Tag = new Tag("00102110")}; }
        }

        public static LongString CountryOfResidence
        {
            get { return new LongString {Tag = new Tag("00102150")}; }
        }

        public static LongString RegionOfResidence
        {
            get { return new LongString {Tag = new Tag("00102152")}; }
        }

        public static ShortString PatientTelephoneNumbers
        {
            get { return new ShortString {Tag = new Tag("00102154")}; }
        }

        public static ShortString EthnicGroup
        {
            get { return new ShortString {Tag = new Tag("00102160")}; }
        }

        public static ShortString Occupation
        {
            get { return new ShortString {Tag = new Tag("00102180")}; }
        }

        public static CodeString SmokingStatus
        {
            get { return new CodeString {Tag = new Tag("001021A0")}; }
        }

        public static LongText AdditionalPatientHistory
        {
            get { return new LongText {Tag = new Tag("001021B0")}; }
        }

        public static UnsignedShort PregnancyStatus
        {
            get { return new UnsignedShort {Tag = new Tag("001021C0")}; }
        }

        public static Date LastMenstrualDate
        {
            get { return new Date {Tag = new Tag("001021D0")}; }
        }

        public static LongString PatientReligiousPreference
        {
            get { return new LongString {Tag = new Tag("001021F0")}; }
        }

        public static LongString PatientSpeciesDescription
        {
            get { return new LongString {Tag = new Tag("00102201")}; }
        }

        public static Sequence PatientSpeciesCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00102202")}; }
        }

        public static CodeString PatientSexNeutered
        {
            get { return new CodeString {Tag = new Tag("00102203")}; }
        }

        public static CodeString AnatomicalOrientationType
        {
            get { return new CodeString {Tag = new Tag("00102210")}; }
        }

        public static LongString PatientBreedDescription
        {
            get { return new LongString {Tag = new Tag("00102292")}; }
        }

        public static Sequence PatientBreedCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00102293")}; }
        }

        public static Sequence BreedRegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("00102294")}; }
        }

        public static LongString BreedRegistrationNumber
        {
            get { return new LongString {Tag = new Tag("00102295")}; }
        }

        public static Sequence BreedRegistryCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00102296")}; }
        }

        public static PersonName ResponsiblePerson
        {
            get { return new PersonName {Tag = new Tag("00102297")}; }
        }

        public static CodeString ResponsiblePersonRole
        {
            get { return new CodeString {Tag = new Tag("00102298")}; }
        }

        public static LongString ResponsibleOrganization
        {
            get { return new LongString {Tag = new Tag("00102299")}; }
        }

        public static LongText PatientComments
        {
            get { return new LongText {Tag = new Tag("00104000")}; }
        }

        public static FloatingPointSingle ExaminedBodyThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("00109431")}; }
        }

        public static LongString ClinicalTrialSponsorName
        {
            get { return new LongString {Tag = new Tag("00120010")}; }
        }

        public static LongString ClinicalTrialProtocolID
        {
            get { return new LongString {Tag = new Tag("00120020")}; }
        }

        public static LongString ClinicalTrialProtocolName
        {
            get { return new LongString {Tag = new Tag("00120021")}; }
        }

        public static LongString ClinicalTrialSiteID
        {
            get { return new LongString {Tag = new Tag("00120030")}; }
        }

        public static LongString ClinicalTrialSiteName
        {
            get { return new LongString {Tag = new Tag("00120031")}; }
        }

        public static LongString ClinicalTrialSubjectID
        {
            get { return new LongString {Tag = new Tag("00120040")}; }
        }

        public static LongString ClinicalTrialSubjectReadingID
        {
            get { return new LongString {Tag = new Tag("00120042")}; }
        }

        public static LongString ClinicalTrialTimePointID
        {
            get { return new LongString {Tag = new Tag("00120050")}; }
        }

        public static ShortText ClinicalTrialTimePointDescription
        {
            get { return new ShortText {Tag = new Tag("00120051")}; }
        }

        public static LongString ClinicalTrialCoordinatingCenterName
        {
            get { return new LongString {Tag = new Tag("00120060")}; }
        }

        public static CodeString PatientIdentityRemoved
        {
            get { return new CodeString {Tag = new Tag("00120062")}; }
        }

        public static LongString DeidentificationMethod
        {
            get { return new LongString {Tag = new Tag("00120063")}; }
        }

        public static Sequence DeidentificationMethodCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00120064")}; }
        }

        public static LongString ClinicalTrialSeriesID
        {
            get { return new LongString {Tag = new Tag("00120071")}; }
        }

        public static LongString ClinicalTrialSeriesDescription
        {
            get { return new LongString {Tag = new Tag("00120072")}; }
        }

        public static LongString ClinicalTrialProtocolEthicsCommitteeName
        {
            get { return new LongString {Tag = new Tag("00120081")}; }
        }

        public static LongString ClinicalTrialProtocolEthicsCommitteeApprovalNumber
        {
            get { return new LongString {Tag = new Tag("00120082")}; }
        }

        public static Sequence ConsentForClinicalTrialUseSequence
        {
            get { return new Sequence {Tag = new Tag("00120083")}; }
        }

        public static CodeString DistributionType
        {
            get { return new CodeString {Tag = new Tag("00120084")}; }
        }

        public static CodeString ConsentForDistributionFlag
        {
            get { return new CodeString {Tag = new Tag("00120085")}; }
        }

        public static ShortText CADFileFormat
        {
            get { return new ShortText {Tag = new Tag("00140023")}; }
        }

        public static ShortText ComponentReferenceSystem
        {
            get { return new ShortText {Tag = new Tag("00140024")}; }
        }

        public static ShortText ComponentManufacturingProcedure
        {
            get { return new ShortText {Tag = new Tag("00140025")}; }
        }

        public static ShortText ComponentManufacturer
        {
            get { return new ShortText {Tag = new Tag("00140028")}; }
        }

        public static DecimalString MaterialThickness
        {
            get { return new DecimalString {Tag = new Tag("00140030")}; }
        }

        public static DecimalString MaterialPipeDiameter
        {
            get { return new DecimalString {Tag = new Tag("00140032")}; }
        }

        public static DecimalString MaterialIsolationDiameter
        {
            get { return new DecimalString {Tag = new Tag("00140034")}; }
        }

        public static ShortText MaterialGrade
        {
            get { return new ShortText {Tag = new Tag("00140042")}; }
        }

        public static ShortText MaterialPropertiesFileID
        {
            get { return new ShortText {Tag = new Tag("00140044")}; }
        }

        public static ShortText MaterialPropertiesFileFormat
        {
            get { return new ShortText {Tag = new Tag("00140045")}; }
        }

        public static LongText MaterialNotes
        {
            get { return new LongText {Tag = new Tag("00140046")}; }
        }

        public static CodeString ComponentShape
        {
            get { return new CodeString {Tag = new Tag("00140050")}; }
        }

        public static CodeString CurvatureType
        {
            get { return new CodeString {Tag = new Tag("00140052")}; }
        }

        public static DecimalString OuterDiameter
        {
            get { return new DecimalString {Tag = new Tag("00140054")}; }
        }

        public static DecimalString InnerDiameter
        {
            get { return new DecimalString {Tag = new Tag("00140056")}; }
        }

        public static ShortText ActualEnvironmentalConditions
        {
            get { return new ShortText {Tag = new Tag("00141010")}; }
        }

        public static Date ExpiryDate
        {
            get { return new Date {Tag = new Tag("00141020")}; }
        }

        public static ShortText EnvironmentalConditions
        {
            get { return new ShortText {Tag = new Tag("00141040")}; }
        }

        public static Sequence EvaluatorSequence
        {
            get { return new Sequence {Tag = new Tag("00142002")}; }
        }

        public static IntegerString EvaluatorNumber
        {
            get { return new IntegerString {Tag = new Tag("00142004")}; }
        }

        public static PersonName EvaluatorName
        {
            get { return new PersonName {Tag = new Tag("00142006")}; }
        }

        public static IntegerString EvaluationAttempt
        {
            get { return new IntegerString {Tag = new Tag("00142008")}; }
        }

        public static Sequence IndicationSequence
        {
            get { return new Sequence {Tag = new Tag("00142012")}; }
        }

        public static IntegerString IndicationNumber
        {
            get { return new IntegerString {Tag = new Tag("00142014")}; }
        }

        public static ShortString IndicationLabel
        {
            get { return new ShortString {Tag = new Tag("00142016")}; }
        }

        public static ShortText IndicationDescription
        {
            get { return new ShortText {Tag = new Tag("00142018")}; }
        }

        public static CodeString IndicationType
        {
            get { return new CodeString {Tag = new Tag("0014201A")}; }
        }

        public static CodeString IndicationDisposition
        {
            get { return new CodeString {Tag = new Tag("0014201C")}; }
        }

        public static Sequence IndicationROISequence
        {
            get { return new Sequence {Tag = new Tag("0014201E")}; }
        }

        public static Sequence IndicationPhysicalPropertySequence
        {
            get { return new Sequence {Tag = new Tag("00142030")}; }
        }

        public static ShortString PropertyLabel
        {
            get { return new ShortString {Tag = new Tag("00142032")}; }
        }

        public static IntegerString CoordinateSystemNumberOfAxes
        {
            get { return new IntegerString {Tag = new Tag("00142202")}; }
        }

        public static Sequence CoordinateSystemAxesSequence
        {
            get { return new Sequence {Tag = new Tag("00142204")}; }
        }

        public static ShortText CoordinateSystemAxisDescription
        {
            get { return new ShortText {Tag = new Tag("00142206")}; }
        }

        public static CodeString CoordinateSystemDataSetMapping
        {
            get { return new CodeString {Tag = new Tag("00142208")}; }
        }

        public static IntegerString CoordinateSystemAxisNumber
        {
            get { return new IntegerString {Tag = new Tag("0014220A")}; }
        }

        public static CodeString CoordinateSystemAxisType
        {
            get { return new CodeString {Tag = new Tag("0014220C")}; }
        }

        public static CodeString CoordinateSystemAxisUnits
        {
            get { return new CodeString {Tag = new Tag("0014220E")}; }
        }

        public static OtherByteString CoordinateSystemAxisValues
        {
            get { return new OtherByteString {Tag = new Tag("00142210")}; }
        }

        public static Sequence CoordinateSystemTransformSequence
        {
            get { return new Sequence {Tag = new Tag("00142220")}; }
        }

        public static ShortText TransformDescription
        {
            get { return new ShortText {Tag = new Tag("00142222")}; }
        }

        public static IntegerString TransformNumberOfAxes
        {
            get { return new IntegerString {Tag = new Tag("00142224")}; }
        }

        public static IntegerString TransformOrderOfAxes
        {
            get { return new IntegerString {Tag = new Tag("00142226")}; }
        }

        public static CodeString TransformedAxisUnits
        {
            get { return new CodeString {Tag = new Tag("00142228")}; }
        }

        public static DecimalString CoordinateSystemTransformRotationAndScaleMatrix
        {
            get { return new DecimalString {Tag = new Tag("0014222A")}; }
        }

        public static DecimalString CoordinateSystemTransformTranslationMatrix
        {
            get { return new DecimalString {Tag = new Tag("0014222C")}; }
        }

        public static DecimalString InternalDetectorFrameTime
        {
            get { return new DecimalString {Tag = new Tag("00143011")}; }
        }

        public static DecimalString NumberOfFramesIntegrated
        {
            get { return new DecimalString {Tag = new Tag("00143012")}; }
        }

        public static Sequence DetectorTemperatureSequence
        {
            get { return new Sequence {Tag = new Tag("00143020")}; }
        }

        public static DecimalString SensorName
        {
            get { return new DecimalString {Tag = new Tag("00143022")}; }
        }

        public static DecimalString HorizontalOffsetOfSensor
        {
            get { return new DecimalString {Tag = new Tag("00143024")}; }
        }

        public static DecimalString VerticalOffsetOfSensor
        {
            get { return new DecimalString {Tag = new Tag("00143026")}; }
        }

        public static DecimalString SensorTemperature
        {
            get { return new DecimalString {Tag = new Tag("00143028")}; }
        }

        public static Sequence DarkCurrentSequence
        {
            get { return new Sequence {Tag = new Tag("00143040")}; }
        }

        public static OtherByteString DarkCurrentCounts
        {
            get { return new OtherByteString {Tag = new Tag("00143050")}; }
        }

        public static Sequence GainCorrectionReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("00143060")}; }
        }

        public static OtherByteString AirCounts
        {
            get { return new OtherByteString {Tag = new Tag("00143070")}; }
        }

        public static DecimalString KVUsedInGainCalibration
        {
            get { return new DecimalString {Tag = new Tag("00143071")}; }
        }

        public static DecimalString MAUsedInGainCalibration
        {
            get { return new DecimalString {Tag = new Tag("00143072")}; }
        }

        public static DecimalString NumberOfFramesUsedForIntegration
        {
            get { return new DecimalString {Tag = new Tag("00143073")}; }
        }

        public static LongString FilterMaterialUsedInGainCalibration
        {
            get { return new LongString {Tag = new Tag("00143074")}; }
        }

        public static DecimalString FilterThicknessUsedInGainCalibration
        {
            get { return new DecimalString {Tag = new Tag("00143075")}; }
        }

        public static Date DateOfGainCalibration
        {
            get { return new Date {Tag = new Tag("00143076")}; }
        }

        public static Time TimeOfGainCalibration
        {
            get { return new Time {Tag = new Tag("00143077")}; }
        }

        public static OtherByteString BadPixelImage
        {
            get { return new OtherByteString {Tag = new Tag("00143080")}; }
        }

        public static LongText CalibrationNotes
        {
            get { return new LongText {Tag = new Tag("00143099")}; }
        }

        public static Sequence PulserEquipmentSequence
        {
            get { return new Sequence {Tag = new Tag("00144002")}; }
        }

        public static CodeString PulserType
        {
            get { return new CodeString {Tag = new Tag("00144004")}; }
        }

        public static LongText PulserNotes
        {
            get { return new LongText {Tag = new Tag("00144006")}; }
        }

        public static Sequence ReceiverEquipmentSequence
        {
            get { return new Sequence {Tag = new Tag("00144008")}; }
        }

        public static CodeString AmplifierType
        {
            get { return new CodeString {Tag = new Tag("0014400A")}; }
        }

        public static LongText ReceiverNotes
        {
            get { return new LongText {Tag = new Tag("0014400C")}; }
        }

        public static Sequence PreAmplifierEquipmentSequence
        {
            get { return new Sequence {Tag = new Tag("0014400E")}; }
        }

        public static LongText PreAmplifierNotes
        {
            get { return new LongText {Tag = new Tag("0014400F")}; }
        }

        public static Sequence TransmitTransducerSequence
        {
            get { return new Sequence {Tag = new Tag("00144010")}; }
        }

        public static Sequence ReceiveTransducerSequence
        {
            get { return new Sequence {Tag = new Tag("00144011")}; }
        }

        public static UnsignedShort NumberOfElements
        {
            get { return new UnsignedShort {Tag = new Tag("00144012")}; }
        }

        public static CodeString ElementShape
        {
            get { return new CodeString {Tag = new Tag("00144013")}; }
        }

        public static DecimalString ElementDimensionA
        {
            get { return new DecimalString {Tag = new Tag("00144014")}; }
        }

        public static DecimalString ElementDimensionB
        {
            get { return new DecimalString {Tag = new Tag("00144015")}; }
        }

        public static DecimalString ElementPitch
        {
            get { return new DecimalString {Tag = new Tag("00144016")}; }
        }

        public static DecimalString MeasuredBeamDimensionA
        {
            get { return new DecimalString {Tag = new Tag("00144017")}; }
        }

        public static DecimalString MeasuredBeamDimensionB
        {
            get { return new DecimalString {Tag = new Tag("00144018")}; }
        }

        public static DecimalString LocationOfMeasuredBeamDiameter
        {
            get { return new DecimalString {Tag = new Tag("00144019")}; }
        }

        public static DecimalString NominalFrequency
        {
            get { return new DecimalString {Tag = new Tag("0014401A")}; }
        }

        public static DecimalString MeasuredCenterFrequency
        {
            get { return new DecimalString {Tag = new Tag("0014401B")}; }
        }

        public static DecimalString MeasuredBandwidth
        {
            get { return new DecimalString {Tag = new Tag("0014401C")}; }
        }

        public static Sequence PulserSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144020")}; }
        }

        public static DecimalString PulseWidth
        {
            get { return new DecimalString {Tag = new Tag("00144022")}; }
        }

        public static DecimalString ExcitationFrequency
        {
            get { return new DecimalString {Tag = new Tag("00144024")}; }
        }

        public static CodeString ModulationType
        {
            get { return new CodeString {Tag = new Tag("00144026")}; }
        }

        public static DecimalString Damping
        {
            get { return new DecimalString {Tag = new Tag("00144028")}; }
        }

        public static Sequence ReceiverSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144030")}; }
        }

        public static DecimalString AcquiredSoundpathLength
        {
            get { return new DecimalString {Tag = new Tag("00144031")}; }
        }

        public static CodeString AcquisitionCompressionType
        {
            get { return new CodeString {Tag = new Tag("00144032")}; }
        }

        public static IntegerString AcquisitionSampleSize
        {
            get { return new IntegerString {Tag = new Tag("00144033")}; }
        }

        public static DecimalString RectifierSmoothing
        {
            get { return new DecimalString {Tag = new Tag("00144034")}; }
        }

        public static Sequence DACSequence
        {
            get { return new Sequence {Tag = new Tag("00144035")}; }
        }

        public static CodeString DACType
        {
            get { return new CodeString {Tag = new Tag("00144036")}; }
        }

        public static DecimalString DACGainPoints
        {
            get { return new DecimalString {Tag = new Tag("00144038")}; }
        }

        public static DecimalString DACTimePoints
        {
            get { return new DecimalString {Tag = new Tag("0014403A")}; }
        }

        public static DecimalString DACAmplitude
        {
            get { return new DecimalString {Tag = new Tag("0014403C")}; }
        }

        public static Sequence PreAmplifierSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144040")}; }
        }

        public static Sequence TransmitTransducerSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144050")}; }
        }

        public static Sequence ReceiveTransducerSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144051")}; }
        }

        public static DecimalString IncidentAngle
        {
            get { return new DecimalString {Tag = new Tag("00144052")}; }
        }

        public static ShortText CouplingTechnique
        {
            get { return new ShortText {Tag = new Tag("00144054")}; }
        }

        public static ShortText CouplingMedium
        {
            get { return new ShortText {Tag = new Tag("00144056")}; }
        }

        public static DecimalString CouplingVelocity
        {
            get { return new DecimalString {Tag = new Tag("00144057")}; }
        }

        public static DecimalString CrystalCenterLocationX
        {
            get { return new DecimalString {Tag = new Tag("00144058")}; }
        }

        public static DecimalString CrystalCenterLocationZ
        {
            get { return new DecimalString {Tag = new Tag("00144059")}; }
        }

        public static DecimalString SoundPathLength
        {
            get { return new DecimalString {Tag = new Tag("0014405A")}; }
        }

        public static ShortText DelayLawIdentifier
        {
            get { return new ShortText {Tag = new Tag("0014405C")}; }
        }

        public static Sequence GateSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144060")}; }
        }

        public static DecimalString GateThreshold
        {
            get { return new DecimalString {Tag = new Tag("00144062")}; }
        }

        public static DecimalString VelocityOfSound
        {
            get { return new DecimalString {Tag = new Tag("00144064")}; }
        }

        public static Sequence CalibrationSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("00144070")}; }
        }

        public static ShortText CalibrationProcedure
        {
            get { return new ShortText {Tag = new Tag("00144072")}; }
        }

        public static ShortString ProcedureVersion
        {
            get { return new ShortString {Tag = new Tag("00144074")}; }
        }

        public static Date ProcedureCreationDate
        {
            get { return new Date {Tag = new Tag("00144076")}; }
        }

        public static Date ProcedureExpirationDate
        {
            get { return new Date {Tag = new Tag("00144078")}; }
        }

        public static Date ProcedureLastModifiedDate
        {
            get { return new Date {Tag = new Tag("0014407A")}; }
        }

        public static Time CalibrationTime
        {
            get { return new Time {Tag = new Tag("0014407C")}; }
        }

        public static Date CalibrationDate
        {
            get { return new Date {Tag = new Tag("0014407E")}; }
        }

        public static IntegerString LINACEnergy
        {
            get { return new IntegerString {Tag = new Tag("00145002")}; }
        }

        public static IntegerString LINACOutput
        {
            get { return new IntegerString {Tag = new Tag("00145004")}; }
        }

        public static LongString ContrastBolusAgent
        {
            get { return new LongString {Tag = new Tag("00180010")}; }
        }

        public static Sequence ContrastBolusAgentSequence
        {
            get { return new Sequence {Tag = new Tag("00180012")}; }
        }

        public static Sequence ContrastBolusAdministrationRouteSequence
        {
            get { return new Sequence {Tag = new Tag("00180014")}; }
        }

        public static CodeString BodyPartExamined
        {
            get { return new CodeString {Tag = new Tag("00180015")}; }
        }

        public static CodeString ScanningSequence
        {
            get { return new CodeString {Tag = new Tag("00180020")}; }
        }

        public static CodeString SequenceVariant
        {
            get { return new CodeString {Tag = new Tag("00180021")}; }
        }

        public static CodeString ScanOptions
        {
            get { return new CodeString {Tag = new Tag("00180022")}; }
        }

        public static CodeString MRAcquisitionType
        {
            get { return new CodeString {Tag = new Tag("00180023")}; }
        }

        public static ShortString SequenceName
        {
            get { return new ShortString {Tag = new Tag("00180024")}; }
        }

        public static CodeString AngioFlag
        {
            get { return new CodeString {Tag = new Tag("00180025")}; }
        }

        public static Sequence InterventionDrugInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00180026")}; }
        }

        public static Time InterventionDrugStopTime
        {
            get { return new Time {Tag = new Tag("00180027")}; }
        }

        public static DecimalString InterventionDrugDose
        {
            get { return new DecimalString {Tag = new Tag("00180028")}; }
        }

        public static Sequence InterventionDrugCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00180029")}; }
        }

        public static Sequence AdditionalDrugSequence
        {
            get { return new Sequence {Tag = new Tag("0018002A")}; }
        }

        public static LongString RadionuclideRetired
        {
            get { return new LongString {Tag = new Tag("00180030")}; }
        }

        public static LongString Radiopharmaceutical
        {
            get { return new LongString {Tag = new Tag("00180031")}; }
        }

        public static DecimalString EnergyWindowCenterlineRetired
        {
            get { return new DecimalString {Tag = new Tag("00180032")}; }
        }

        public static DecimalString EnergyWindowTotalWidthRetired
        {
            get { return new DecimalString {Tag = new Tag("00180033")}; }
        }

        public static LongString InterventionDrugName
        {
            get { return new LongString {Tag = new Tag("00180034")}; }
        }

        public static Time InterventionDrugStartTime
        {
            get { return new Time {Tag = new Tag("00180035")}; }
        }

        public static Sequence InterventionSequence
        {
            get { return new Sequence {Tag = new Tag("00180036")}; }
        }

        public static CodeString TherapyTypeRetired
        {
            get { return new CodeString {Tag = new Tag("00180037")}; }
        }

        public static CodeString InterventionStatus
        {
            get { return new CodeString {Tag = new Tag("00180038")}; }
        }

        public static CodeString TherapyDescriptionRetired
        {
            get { return new CodeString {Tag = new Tag("00180039")}; }
        }

        public static ShortText InterventionDescription
        {
            get { return new ShortText {Tag = new Tag("0018003A")}; }
        }

        public static IntegerString CineRate
        {
            get { return new IntegerString {Tag = new Tag("00180040")}; }
        }

        public static CodeString InitialCineRunState
        {
            get { return new CodeString {Tag = new Tag("00180042")}; }
        }

        public static DecimalString SliceThickness
        {
            get { return new DecimalString {Tag = new Tag("00180050")}; }
        }

        public static DecimalString KVP
        {
            get { return new DecimalString {Tag = new Tag("00180060")}; }
        }

        public static IntegerString CountsAccumulated
        {
            get { return new IntegerString {Tag = new Tag("00180070")}; }
        }

        public static CodeString AcquisitionTerminationCondition
        {
            get { return new CodeString {Tag = new Tag("00180071")}; }
        }

        public static DecimalString EffectiveDuration
        {
            get { return new DecimalString {Tag = new Tag("00180072")}; }
        }

        public static CodeString AcquisitionStartCondition
        {
            get { return new CodeString {Tag = new Tag("00180073")}; }
        }

        public static IntegerString AcquisitionStartConditionData
        {
            get { return new IntegerString {Tag = new Tag("00180074")}; }
        }

        public static IntegerString AcquisitionTerminationConditionData
        {
            get { return new IntegerString {Tag = new Tag("00180075")}; }
        }

        public static DecimalString RepetitionTime
        {
            get { return new DecimalString {Tag = new Tag("00180080")}; }
        }

        public static DecimalString EchoTime
        {
            get { return new DecimalString {Tag = new Tag("00180081")}; }
        }

        public static DecimalString InversionTime
        {
            get { return new DecimalString {Tag = new Tag("00180082")}; }
        }

        public static DecimalString NumberOfAverages
        {
            get { return new DecimalString {Tag = new Tag("00180083")}; }
        }

        public static DecimalString ImagingFrequency
        {
            get { return new DecimalString {Tag = new Tag("00180084")}; }
        }

        public static ShortString ImagedNucleus
        {
            get { return new ShortString {Tag = new Tag("00180085")}; }
        }

        public static IntegerString EchoNumbers
        {
            get { return new IntegerString {Tag = new Tag("00180086")}; }
        }

        public static DecimalString MagneticFieldStrength
        {
            get { return new DecimalString {Tag = new Tag("00180087")}; }
        }

        public static DecimalString SpacingBetweenSlices
        {
            get { return new DecimalString {Tag = new Tag("00180088")}; }
        }

        public static IntegerString NumberOfPhaseEncodingSteps
        {
            get { return new IntegerString {Tag = new Tag("00180089")}; }
        }

        public static DecimalString DataCollectionDiameter
        {
            get { return new DecimalString {Tag = new Tag("00180090")}; }
        }

        public static IntegerString EchoTrainLength
        {
            get { return new IntegerString {Tag = new Tag("00180091")}; }
        }

        public static DecimalString PercentSampling
        {
            get { return new DecimalString {Tag = new Tag("00180093")}; }
        }

        public static DecimalString PercentPhaseFieldOfView
        {
            get { return new DecimalString {Tag = new Tag("00180094")}; }
        }

        public static DecimalString PixelBandwidth
        {
            get { return new DecimalString {Tag = new Tag("00180095")}; }
        }

        public static LongString DeviceSerialNumber
        {
            get { return new LongString {Tag = new Tag("00181000")}; }
        }

        public static UniqueIdentifier DeviceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00181002")}; }
        }

        public static LongString DeviceID
        {
            get { return new LongString {Tag = new Tag("00181003")}; }
        }

        public static LongString PlateID
        {
            get { return new LongString {Tag = new Tag("00181004")}; }
        }

        public static LongString GeneratorID
        {
            get { return new LongString {Tag = new Tag("00181005")}; }
        }

        public static LongString GridID
        {
            get { return new LongString {Tag = new Tag("00181006")}; }
        }

        public static LongString CassetteID
        {
            get { return new LongString {Tag = new Tag("00181007")}; }
        }

        public static LongString GantryID
        {
            get { return new LongString {Tag = new Tag("00181008")}; }
        }

        public static LongString SecondaryCaptureDeviceID
        {
            get { return new LongString {Tag = new Tag("00181010")}; }
        }

        public static LongString HardcopyCreationDeviceIDRetired
        {
            get { return new LongString {Tag = new Tag("00181011")}; }
        }

        public static Date DateOfSecondaryCapture
        {
            get { return new Date {Tag = new Tag("00181012")}; }
        }

        public static Time TimeOfSecondaryCapture
        {
            get { return new Time {Tag = new Tag("00181014")}; }
        }

        public static LongString SecondaryCaptureDeviceManufacturer
        {
            get { return new LongString {Tag = new Tag("00181016")}; }
        }

        public static LongString HardcopyDeviceManufacturerRetired
        {
            get { return new LongString {Tag = new Tag("00181017")}; }
        }

        public static LongString SecondaryCaptureDeviceManufacturerModelName
        {
            get { return new LongString {Tag = new Tag("00181018")}; }
        }

        public static LongString SecondaryCaptureDeviceSoftwareVersions
        {
            get { return new LongString {Tag = new Tag("00181019")}; }
        }

        public static LongString HardcopyDeviceSoftwareVersionRetired
        {
            get { return new LongString {Tag = new Tag("0018101A")}; }
        }

        public static LongString HardcopyDeviceManufacturerModelNameRetired
        {
            get { return new LongString {Tag = new Tag("0018101B")}; }
        }

        public static LongString SoftwareVersions
        {
            get { return new LongString {Tag = new Tag("00181020")}; }
        }

        public static ShortString VideoImageFormatAcquired
        {
            get { return new ShortString {Tag = new Tag("00181022")}; }
        }

        public static LongString DigitalImageFormatAcquired
        {
            get { return new LongString {Tag = new Tag("00181023")}; }
        }

        public static LongString ProtocolName
        {
            get { return new LongString {Tag = new Tag("00181030")}; }
        }

        public static LongString ContrastBolusRoute
        {
            get { return new LongString {Tag = new Tag("00181040")}; }
        }

        public static DecimalString ContrastBolusVolume
        {
            get { return new DecimalString {Tag = new Tag("00181041")}; }
        }

        public static Time ContrastBolusStartTime
        {
            get { return new Time {Tag = new Tag("00181042")}; }
        }

        public static Time ContrastBolusStopTime
        {
            get { return new Time {Tag = new Tag("00181043")}; }
        }

        public static DecimalString ContrastBolusTotalDose
        {
            get { return new DecimalString {Tag = new Tag("00181044")}; }
        }

        public static IntegerString SyringeCounts
        {
            get { return new IntegerString {Tag = new Tag("00181045")}; }
        }

        public static DecimalString ContrastFlowRate
        {
            get { return new DecimalString {Tag = new Tag("00181046")}; }
        }

        public static DecimalString ContrastFlowDuration
        {
            get { return new DecimalString {Tag = new Tag("00181047")}; }
        }

        public static CodeString ContrastBolusIngredient
        {
            get { return new CodeString {Tag = new Tag("00181048")}; }
        }

        public static DecimalString ContrastBolusIngredientConcentration
        {
            get { return new DecimalString {Tag = new Tag("00181049")}; }
        }

        public static DecimalString SpatialResolution
        {
            get { return new DecimalString {Tag = new Tag("00181050")}; }
        }

        public static DecimalString TriggerTime
        {
            get { return new DecimalString {Tag = new Tag("00181060")}; }
        }

        public static LongString TriggerSourceOrType
        {
            get { return new LongString {Tag = new Tag("00181061")}; }
        }

        public static IntegerString NominalInterval
        {
            get { return new IntegerString {Tag = new Tag("00181062")}; }
        }

        public static DecimalString FrameTime
        {
            get { return new DecimalString {Tag = new Tag("00181063")}; }
        }

        public static LongString CardiacFramingType
        {
            get { return new LongString {Tag = new Tag("00181064")}; }
        }

        public static DecimalString FrameTimeVector
        {
            get { return new DecimalString {Tag = new Tag("00181065")}; }
        }

        public static DecimalString FrameDelay
        {
            get { return new DecimalString {Tag = new Tag("00181066")}; }
        }

        public static DecimalString ImageTriggerDelay
        {
            get { return new DecimalString {Tag = new Tag("00181067")}; }
        }

        public static DecimalString MultiplexGroupTimeOffset
        {
            get { return new DecimalString {Tag = new Tag("00181068")}; }
        }

        public static DecimalString TriggerTimeOffset
        {
            get { return new DecimalString {Tag = new Tag("00181069")}; }
        }

        public static CodeString SynchronizationTrigger
        {
            get { return new CodeString {Tag = new Tag("0018106A")}; }
        }

        public static UnsignedShort SynchronizationChannel
        {
            get { return new UnsignedShort {Tag = new Tag("0018106C")}; }
        }

        public static UnsignedLong TriggerSamplePosition
        {
            get { return new UnsignedLong {Tag = new Tag("0018106E")}; }
        }

        public static LongString RadiopharmaceuticalRoute
        {
            get { return new LongString {Tag = new Tag("00181070")}; }
        }

        public static DecimalString RadiopharmaceuticalVolume
        {
            get { return new DecimalString {Tag = new Tag("00181071")}; }
        }

        public static Time RadiopharmaceuticalStartTime
        {
            get { return new Time {Tag = new Tag("00181072")}; }
        }

        public static Time RadiopharmaceuticalStopTime
        {
            get { return new Time {Tag = new Tag("00181073")}; }
        }

        public static DecimalString RadionuclideTotalDose
        {
            get { return new DecimalString {Tag = new Tag("00181074")}; }
        }

        public static DecimalString RadionuclideHalfLife
        {
            get { return new DecimalString {Tag = new Tag("00181075")}; }
        }

        public static DecimalString RadionuclidePositronFraction
        {
            get { return new DecimalString {Tag = new Tag("00181076")}; }
        }

        public static DecimalString RadiopharmaceuticalSpecificActivity
        {
            get { return new DecimalString {Tag = new Tag("00181077")}; }
        }

        public static CodeString BeatRejectionFlag
        {
            get { return new CodeString {Tag = new Tag("00181080")}; }
        }

        public static IntegerString LowRRValue
        {
            get { return new IntegerString {Tag = new Tag("00181081")}; }
        }

        public static IntegerString HighRRValue
        {
            get { return new IntegerString {Tag = new Tag("00181082")}; }
        }

        public static IntegerString IntervalsAcquired
        {
            get { return new IntegerString {Tag = new Tag("00181083")}; }
        }

        public static IntegerString IntervalsRejected
        {
            get { return new IntegerString {Tag = new Tag("00181084")}; }
        }

        public static LongString PVCRejection
        {
            get { return new LongString {Tag = new Tag("00181085")}; }
        }

        public static IntegerString SkipBeats
        {
            get { return new IntegerString {Tag = new Tag("00181086")}; }
        }

        public static IntegerString HeartRate
        {
            get { return new IntegerString {Tag = new Tag("00181088")}; }
        }

        public static IntegerString CardiacNumberOfImages
        {
            get { return new IntegerString {Tag = new Tag("00181090")}; }
        }

        public static IntegerString TriggerWindow
        {
            get { return new IntegerString {Tag = new Tag("00181094")}; }
        }

        public static DecimalString ReconstructionDiameter
        {
            get { return new DecimalString {Tag = new Tag("00181100")}; }
        }

        public static DecimalString DistanceSourceToDetector
        {
            get { return new DecimalString {Tag = new Tag("00181110")}; }
        }

        public static DecimalString DistanceSourceToPatient
        {
            get { return new DecimalString {Tag = new Tag("00181111")}; }
        }

        public static DecimalString EstimatedRadiographicMagnificationFactor
        {
            get { return new DecimalString {Tag = new Tag("00181114")}; }
        }

        public static DecimalString GantryDetectorTilt
        {
            get { return new DecimalString {Tag = new Tag("00181120")}; }
        }

        public static DecimalString GantryDetectorSlew
        {
            get { return new DecimalString {Tag = new Tag("00181121")}; }
        }

        public static DecimalString TableHeight
        {
            get { return new DecimalString {Tag = new Tag("00181130")}; }
        }

        public static DecimalString TableTraverse
        {
            get { return new DecimalString {Tag = new Tag("00181131")}; }
        }

        public static CodeString TableMotion
        {
            get { return new CodeString {Tag = new Tag("00181134")}; }
        }

        public static DecimalString TableVerticalIncrement
        {
            get { return new DecimalString {Tag = new Tag("00181135")}; }
        }

        public static DecimalString TableLateralIncrement
        {
            get { return new DecimalString {Tag = new Tag("00181136")}; }
        }

        public static DecimalString TableLongitudinalIncrement
        {
            get { return new DecimalString {Tag = new Tag("00181137")}; }
        }

        public static DecimalString TableAngle
        {
            get { return new DecimalString {Tag = new Tag("00181138")}; }
        }

        public static CodeString TableType
        {
            get { return new CodeString {Tag = new Tag("0018113A")}; }
        }

        public static CodeString RotationDirection
        {
            get { return new CodeString {Tag = new Tag("00181140")}; }
        }

        public static DecimalString AngularPositionRetired
        {
            get { return new DecimalString {Tag = new Tag("00181141")}; }
        }

        public static DecimalString RadialPosition
        {
            get { return new DecimalString {Tag = new Tag("00181142")}; }
        }

        public static DecimalString ScanArc
        {
            get { return new DecimalString {Tag = new Tag("00181143")}; }
        }

        public static DecimalString AngularStep
        {
            get { return new DecimalString {Tag = new Tag("00181144")}; }
        }

        public static DecimalString CenterOfRotationOffset
        {
            get { return new DecimalString {Tag = new Tag("00181145")}; }
        }

        public static DecimalString RotationOffsetRetired
        {
            get { return new DecimalString {Tag = new Tag("00181146")}; }
        }

        public static CodeString FieldOfViewShape
        {
            get { return new CodeString {Tag = new Tag("00181147")}; }
        }

        public static IntegerString FieldOfViewDimensions
        {
            get { return new IntegerString {Tag = new Tag("00181149")}; }
        }

        public static IntegerString ExposureTime
        {
            get { return new IntegerString {Tag = new Tag("00181150")}; }
        }

        public static IntegerString XRayTubeCurrent
        {
            get { return new IntegerString {Tag = new Tag("00181151")}; }
        }

        public static IntegerString Exposure
        {
            get { return new IntegerString {Tag = new Tag("00181152")}; }
        }

        public static IntegerString ExposureInuAs
        {
            get { return new IntegerString {Tag = new Tag("00181153")}; }
        }

        public static DecimalString AveragePulseWidth
        {
            get { return new DecimalString {Tag = new Tag("00181154")}; }
        }

        public static CodeString RadiationSetting
        {
            get { return new CodeString {Tag = new Tag("00181155")}; }
        }

        public static CodeString RectificationType
        {
            get { return new CodeString {Tag = new Tag("00181156")}; }
        }

        public static CodeString RadiationMode
        {
            get { return new CodeString {Tag = new Tag("0018115A")}; }
        }

        public static DecimalString ImageAndFluoroscopyAreaDoseProduct
        {
            get { return new DecimalString {Tag = new Tag("0018115E")}; }
        }

        public static ShortString FilterType
        {
            get { return new ShortString {Tag = new Tag("00181160")}; }
        }

        public static LongString TypeOfFilters
        {
            get { return new LongString {Tag = new Tag("00181161")}; }
        }

        public static DecimalString IntensifierSize
        {
            get { return new DecimalString {Tag = new Tag("00181162")}; }
        }

        public static DecimalString ImagerPixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("00181164")}; }
        }

        public static CodeString Grid
        {
            get { return new CodeString {Tag = new Tag("00181166")}; }
        }

        public static IntegerString GeneratorPower
        {
            get { return new IntegerString {Tag = new Tag("00181170")}; }
        }

        public static ShortString CollimatorGridName
        {
            get { return new ShortString {Tag = new Tag("00181180")}; }
        }

        public static CodeString CollimatorType
        {
            get { return new CodeString {Tag = new Tag("00181181")}; }
        }

        public static IntegerString FocalDistance
        {
            get { return new IntegerString {Tag = new Tag("00181182")}; }
        }

        public static DecimalString XFocusCenter
        {
            get { return new DecimalString {Tag = new Tag("00181183")}; }
        }

        public static DecimalString YFocusCenter
        {
            get { return new DecimalString {Tag = new Tag("00181184")}; }
        }

        public static DecimalString FocalSpots
        {
            get { return new DecimalString {Tag = new Tag("00181190")}; }
        }

        public static CodeString AnodeTargetMaterial
        {
            get { return new CodeString {Tag = new Tag("00181191")}; }
        }

        public static DecimalString BodyPartThickness
        {
            get { return new DecimalString {Tag = new Tag("001811A0")}; }
        }

        public static DecimalString CompressionForce
        {
            get { return new DecimalString {Tag = new Tag("001811A2")}; }
        }

        public static Date DateOfLastCalibration
        {
            get { return new Date {Tag = new Tag("00181200")}; }
        }

        public static Time TimeOfLastCalibration
        {
            get { return new Time {Tag = new Tag("00181201")}; }
        }

        public static ShortString ConvolutionKernel
        {
            get { return new ShortString {Tag = new Tag("00181210")}; }
        }

        public static IntegerString UpperLowerPixelValuesRetired
        {
            get { return new IntegerString {Tag = new Tag("00181240")}; }
        }

        public static IntegerString ActualFrameDuration
        {
            get { return new IntegerString {Tag = new Tag("00181242")}; }
        }

        public static IntegerString CountRate
        {
            get { return new IntegerString {Tag = new Tag("00181243")}; }
        }

        public static UnsignedShort PreferredPlaybackSequencing
        {
            get { return new UnsignedShort {Tag = new Tag("00181244")}; }
        }

        public static ShortString ReceiveCoilName
        {
            get { return new ShortString {Tag = new Tag("00181250")}; }
        }

        public static ShortString TransmitCoilName
        {
            get { return new ShortString {Tag = new Tag("00181251")}; }
        }

        public static ShortString PlateType
        {
            get { return new ShortString {Tag = new Tag("00181260")}; }
        }

        public static LongString PhosphorType
        {
            get { return new LongString {Tag = new Tag("00181261")}; }
        }

        public static DecimalString ScanVelocity
        {
            get { return new DecimalString {Tag = new Tag("00181300")}; }
        }

        public static CodeString WholeBodyTechnique
        {
            get { return new CodeString {Tag = new Tag("00181301")}; }
        }

        public static IntegerString ScanLength
        {
            get { return new IntegerString {Tag = new Tag("00181302")}; }
        }

        public static UnsignedShort AcquisitionMatrix
        {
            get { return new UnsignedShort {Tag = new Tag("00181310")}; }
        }

        public static CodeString InPlanePhaseEncodingDirection
        {
            get { return new CodeString {Tag = new Tag("00181312")}; }
        }

        public static DecimalString FlipAngle
        {
            get { return new DecimalString {Tag = new Tag("00181314")}; }
        }

        public static CodeString VariableFlipAngleFlag
        {
            get { return new CodeString {Tag = new Tag("00181315")}; }
        }

        public static DecimalString SAR
        {
            get { return new DecimalString {Tag = new Tag("00181316")}; }
        }

        public static DecimalString dBdt
        {
            get { return new DecimalString {Tag = new Tag("00181318")}; }
        }

        public static LongString AcquisitionDeviceProcessingDescription
        {
            get { return new LongString {Tag = new Tag("00181400")}; }
        }

        public static LongString AcquisitionDeviceProcessingCode
        {
            get { return new LongString {Tag = new Tag("00181401")}; }
        }

        public static CodeString CassetteOrientation
        {
            get { return new CodeString {Tag = new Tag("00181402")}; }
        }

        public static CodeString CassetteSize
        {
            get { return new CodeString {Tag = new Tag("00181403")}; }
        }

        public static UnsignedShort ExposuresOnPlate
        {
            get { return new UnsignedShort {Tag = new Tag("00181404")}; }
        }

        public static IntegerString RelativeXRayExposure
        {
            get { return new IntegerString {Tag = new Tag("00181405")}; }
        }

        public static DecimalString ExposureIndex
        {
            get { return new DecimalString {Tag = new Tag("00181411")}; }
        }

        public static DecimalString TargetExposureIndex
        {
            get { return new DecimalString {Tag = new Tag("00181412")}; }
        }

        public static DecimalString DeviationIndex
        {
            get { return new DecimalString {Tag = new Tag("00181413")}; }
        }

        public static DecimalString ColumnAngulation
        {
            get { return new DecimalString {Tag = new Tag("00181450")}; }
        }

        public static DecimalString TomoLayerHeight
        {
            get { return new DecimalString {Tag = new Tag("00181460")}; }
        }

        public static DecimalString TomoAngle
        {
            get { return new DecimalString {Tag = new Tag("00181470")}; }
        }

        public static DecimalString TomoTime
        {
            get { return new DecimalString {Tag = new Tag("00181480")}; }
        }

        public static CodeString TomoType
        {
            get { return new CodeString {Tag = new Tag("00181490")}; }
        }

        public static CodeString TomoClass
        {
            get { return new CodeString {Tag = new Tag("00181491")}; }
        }

        public static IntegerString NumberOfTomosynthesisSourceImages
        {
            get { return new IntegerString {Tag = new Tag("00181495")}; }
        }

        public static CodeString PositionerMotion
        {
            get { return new CodeString {Tag = new Tag("00181500")}; }
        }

        public static CodeString PositionerType
        {
            get { return new CodeString {Tag = new Tag("00181508")}; }
        }

        public static DecimalString PositionerPrimaryAngle
        {
            get { return new DecimalString {Tag = new Tag("00181510")}; }
        }

        public static DecimalString PositionerSecondaryAngle
        {
            get { return new DecimalString {Tag = new Tag("00181511")}; }
        }

        public static DecimalString PositionerPrimaryAngleIncrement
        {
            get { return new DecimalString {Tag = new Tag("00181520")}; }
        }

        public static DecimalString PositionerSecondaryAngleIncrement
        {
            get { return new DecimalString {Tag = new Tag("00181521")}; }
        }

        public static DecimalString DetectorPrimaryAngle
        {
            get { return new DecimalString {Tag = new Tag("00181530")}; }
        }

        public static DecimalString DetectorSecondaryAngle
        {
            get { return new DecimalString {Tag = new Tag("00181531")}; }
        }

        public static CodeString ShutterShape
        {
            get { return new CodeString {Tag = new Tag("00181600")}; }
        }

        public static IntegerString ShutterLeftVerticalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181602")}; }
        }

        public static IntegerString ShutterRightVerticalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181604")}; }
        }

        public static IntegerString ShutterUpperHorizontalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181606")}; }
        }

        public static IntegerString ShutterLowerHorizontalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181608")}; }
        }

        public static IntegerString CenterOfCircularShutter
        {
            get { return new IntegerString {Tag = new Tag("00181610")}; }
        }

        public static IntegerString RadiusOfCircularShutter
        {
            get { return new IntegerString {Tag = new Tag("00181612")}; }
        }

        public static IntegerString VerticesOfThePolygonalShutter
        {
            get { return new IntegerString {Tag = new Tag("00181620")}; }
        }

        public static UnsignedShort ShutterPresentationValue
        {
            get { return new UnsignedShort {Tag = new Tag("00181622")}; }
        }

        public static UnsignedShort ShutterOverlayGroup
        {
            get { return new UnsignedShort {Tag = new Tag("00181623")}; }
        }

        public static UnsignedShort ShutterPresentationColorCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00181624")}; }
        }

        public static CodeString CollimatorShape
        {
            get { return new CodeString {Tag = new Tag("00181700")}; }
        }

        public static IntegerString CollimatorLeftVerticalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181702")}; }
        }

        public static IntegerString CollimatorRightVerticalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181704")}; }
        }

        public static IntegerString CollimatorUpperHorizontalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181706")}; }
        }

        public static IntegerString CollimatorLowerHorizontalEdge
        {
            get { return new IntegerString {Tag = new Tag("00181708")}; }
        }

        public static IntegerString CenterOfCircularCollimator
        {
            get { return new IntegerString {Tag = new Tag("00181710")}; }
        }

        public static IntegerString RadiusOfCircularCollimator
        {
            get { return new IntegerString {Tag = new Tag("00181712")}; }
        }

        public static IntegerString VerticesOfThePolygonalCollimator
        {
            get { return new IntegerString {Tag = new Tag("00181720")}; }
        }

        public static CodeString AcquisitionTimeSynchronized
        {
            get { return new CodeString {Tag = new Tag("00181800")}; }
        }

        public static ShortString TimeSource
        {
            get { return new ShortString {Tag = new Tag("00181801")}; }
        }

        public static CodeString TimeDistributionProtocol
        {
            get { return new CodeString {Tag = new Tag("00181802")}; }
        }

        public static LongString NTPSourceAddress
        {
            get { return new LongString {Tag = new Tag("00181803")}; }
        }

        public static IntegerString PageNumberVector
        {
            get { return new IntegerString {Tag = new Tag("00182001")}; }
        }

        public static ShortString FrameLabelVector
        {
            get { return new ShortString {Tag = new Tag("00182002")}; }
        }

        public static DecimalString FramePrimaryAngleVector
        {
            get { return new DecimalString {Tag = new Tag("00182003")}; }
        }

        public static DecimalString FrameSecondaryAngleVector
        {
            get { return new DecimalString {Tag = new Tag("00182004")}; }
        }

        public static DecimalString SliceLocationVector
        {
            get { return new DecimalString {Tag = new Tag("00182005")}; }
        }

        public static ShortString DisplayWindowLabelVector
        {
            get { return new ShortString {Tag = new Tag("00182006")}; }
        }

        public static DecimalString NominalScannedPixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("00182010")}; }
        }

        public static CodeString DigitizingDeviceTransportDirection
        {
            get { return new CodeString {Tag = new Tag("00182020")}; }
        }

        public static DecimalString RotationOfScannedFilm
        {
            get { return new DecimalString {Tag = new Tag("00182030")}; }
        }

        public static CodeString IVUSAcquisition
        {
            get { return new CodeString {Tag = new Tag("00183100")}; }
        }

        public static DecimalString IVUSPullbackRate
        {
            get { return new DecimalString {Tag = new Tag("00183101")}; }
        }

        public static DecimalString IVUSGatedRate
        {
            get { return new DecimalString {Tag = new Tag("00183102")}; }
        }

        public static IntegerString IVUSPullbackStartFrameNumber
        {
            get { return new IntegerString {Tag = new Tag("00183103")}; }
        }

        public static IntegerString IVUSPullbackStopFrameNumber
        {
            get { return new IntegerString {Tag = new Tag("00183104")}; }
        }

        public static IntegerString LesionNumber
        {
            get { return new IntegerString {Tag = new Tag("00183105")}; }
        }

        public static LongText AcquisitionCommentsRetired
        {
            get { return new LongText {Tag = new Tag("00184000")}; }
        }

        public static ShortString OutputPower
        {
            get { return new ShortString {Tag = new Tag("00185000")}; }
        }

        public static LongString TransducerData
        {
            get { return new LongString {Tag = new Tag("00185010")}; }
        }

        public static DecimalString FocusDepth
        {
            get { return new DecimalString {Tag = new Tag("00185012")}; }
        }

        public static LongString ProcessingFunction
        {
            get { return new LongString {Tag = new Tag("00185020")}; }
        }

        public static LongString PostprocessingFunctionRetired
        {
            get { return new LongString {Tag = new Tag("00185021")}; }
        }

        public static DecimalString MechanicalIndex
        {
            get { return new DecimalString {Tag = new Tag("00185022")}; }
        }

        public static DecimalString BoneThermalIndex
        {
            get { return new DecimalString {Tag = new Tag("00185024")}; }
        }

        public static DecimalString CranialThermalIndex
        {
            get { return new DecimalString {Tag = new Tag("00185026")}; }
        }

        public static DecimalString SoftTissueThermalIndex
        {
            get { return new DecimalString {Tag = new Tag("00185027")}; }
        }

        public static DecimalString SoftTissueFocusThermalIndex
        {
            get { return new DecimalString {Tag = new Tag("00185028")}; }
        }

        public static DecimalString SoftTissueSurfaceThermalIndex
        {
            get { return new DecimalString {Tag = new Tag("00185029")}; }
        }

        public static DecimalString DynamicRangeRetired
        {
            get { return new DecimalString {Tag = new Tag("00185030")}; }
        }

        public static DecimalString TotalGainRetired
        {
            get { return new DecimalString {Tag = new Tag("00185040")}; }
        }

        public static IntegerString DepthOfScanField
        {
            get { return new IntegerString {Tag = new Tag("00185050")}; }
        }

        public static CodeString PatientPosition
        {
            get { return new CodeString {Tag = new Tag("00185100")}; }
        }

        public static CodeString ViewPosition
        {
            get { return new CodeString {Tag = new Tag("00185101")}; }
        }

        public static Sequence ProjectionEponymousNameCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00185104")}; }
        }

        public static DecimalString ImageTransformationMatrixRetired
        {
            get { return new DecimalString {Tag = new Tag("00185210")}; }
        }

        public static DecimalString ImageTranslationVectorRetired
        {
            get { return new DecimalString {Tag = new Tag("00185212")}; }
        }

        public static DecimalString Sensitivity
        {
            get { return new DecimalString {Tag = new Tag("00186000")}; }
        }

        public static Sequence SequenceOfUltrasoundRegions
        {
            get { return new Sequence {Tag = new Tag("00186011")}; }
        }

        public static UnsignedShort RegionSpatialFormat
        {
            get { return new UnsignedShort {Tag = new Tag("00186012")}; }
        }

        public static UnsignedShort RegionDataType
        {
            get { return new UnsignedShort {Tag = new Tag("00186014")}; }
        }

        public static UnsignedLong RegionFlags
        {
            get { return new UnsignedLong {Tag = new Tag("00186016")}; }
        }

        public static UnsignedLong RegionLocationMinX0
        {
            get { return new UnsignedLong {Tag = new Tag("00186018")}; }
        }

        public static UnsignedLong RegionLocationMinY0
        {
            get { return new UnsignedLong {Tag = new Tag("0018601A")}; }
        }

        public static UnsignedLong RegionLocationMaxX1
        {
            get { return new UnsignedLong {Tag = new Tag("0018601C")}; }
        }

        public static UnsignedLong RegionLocationMaxY1
        {
            get { return new UnsignedLong {Tag = new Tag("0018601E")}; }
        }

        public static SignedLong ReferencePixelX0
        {
            get { return new SignedLong {Tag = new Tag("00186020")}; }
        }

        public static SignedLong ReferencePixelY0
        {
            get { return new SignedLong {Tag = new Tag("00186022")}; }
        }

        public static UnsignedShort PhysicalUnitsXDirection
        {
            get { return new UnsignedShort {Tag = new Tag("00186024")}; }
        }

        public static UnsignedShort PhysicalUnitsYDirection
        {
            get { return new UnsignedShort {Tag = new Tag("00186026")}; }
        }

        public static FloatingPointDouble ReferencePixelPhysicalValueX
        {
            get { return new FloatingPointDouble {Tag = new Tag("00186028")}; }
        }

        public static FloatingPointDouble ReferencePixelPhysicalValueY
        {
            get { return new FloatingPointDouble {Tag = new Tag("0018602A")}; }
        }

        public static FloatingPointDouble PhysicalDeltaX
        {
            get { return new FloatingPointDouble {Tag = new Tag("0018602C")}; }
        }

        public static FloatingPointDouble PhysicalDeltaY
        {
            get { return new FloatingPointDouble {Tag = new Tag("0018602E")}; }
        }

        public static UnsignedLong TransducerFrequency
        {
            get { return new UnsignedLong {Tag = new Tag("00186030")}; }
        }

        public static CodeString TransducerType
        {
            get { return new CodeString {Tag = new Tag("00186031")}; }
        }

        public static UnsignedLong PulseRepetitionFrequency
        {
            get { return new UnsignedLong {Tag = new Tag("00186032")}; }
        }

        public static FloatingPointDouble DopplerCorrectionAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("00186034")}; }
        }

        public static FloatingPointDouble SteeringAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("00186036")}; }
        }

        public static UnsignedLong DopplerSampleVolumeXPositionRetired
        {
            get { return new UnsignedLong {Tag = new Tag("00186038")}; }
        }

        public static SignedLong DopplerSampleVolumeXPosition
        {
            get { return new SignedLong {Tag = new Tag("00186039")}; }
        }

        public static UnsignedLong DopplerSampleVolumeYPositionRetired
        {
            get { return new UnsignedLong {Tag = new Tag("0018603A")}; }
        }

        public static SignedLong DopplerSampleVolumeYPosition
        {
            get { return new SignedLong {Tag = new Tag("0018603B")}; }
        }

        public static UnsignedLong TMLinePositionX0Retired
        {
            get { return new UnsignedLong {Tag = new Tag("0018603C")}; }
        }

        public static SignedLong TMLinePositionX0
        {
            get { return new SignedLong {Tag = new Tag("0018603D")}; }
        }

        public static UnsignedLong TMLinePositionY0Retired
        {
            get { return new UnsignedLong {Tag = new Tag("0018603E")}; }
        }

        public static SignedLong TMLinePositionY0
        {
            get { return new SignedLong {Tag = new Tag("0018603F")}; }
        }

        public static UnsignedLong TMLinePositionX1Retired
        {
            get { return new UnsignedLong {Tag = new Tag("00186040")}; }
        }

        public static SignedLong TMLinePositionX1
        {
            get { return new SignedLong {Tag = new Tag("00186041")}; }
        }

        public static UnsignedLong TMLinePositionY1Retired
        {
            get { return new UnsignedLong {Tag = new Tag("00186042")}; }
        }

        public static SignedLong TMLinePositionY1
        {
            get { return new SignedLong {Tag = new Tag("00186043")}; }
        }

        public static UnsignedShort PixelComponentOrganization
        {
            get { return new UnsignedShort {Tag = new Tag("00186044")}; }
        }

        public static UnsignedLong PixelComponentMask
        {
            get { return new UnsignedLong {Tag = new Tag("00186046")}; }
        }

        public static UnsignedLong PixelComponentRangeStart
        {
            get { return new UnsignedLong {Tag = new Tag("00186048")}; }
        }

        public static UnsignedLong PixelComponentRangeStop
        {
            get { return new UnsignedLong {Tag = new Tag("0018604A")}; }
        }

        public static UnsignedShort PixelComponentPhysicalUnits
        {
            get { return new UnsignedShort {Tag = new Tag("0018604C")}; }
        }

        public static UnsignedShort PixelComponentDataType
        {
            get { return new UnsignedShort {Tag = new Tag("0018604E")}; }
        }

        public static UnsignedLong NumberOfTableBreakPoints
        {
            get { return new UnsignedLong {Tag = new Tag("00186050")}; }
        }

        public static UnsignedLong TableOfXBreakPoints
        {
            get { return new UnsignedLong {Tag = new Tag("00186052")}; }
        }

        public static FloatingPointDouble TableOfYBreakPoints
        {
            get { return new FloatingPointDouble {Tag = new Tag("00186054")}; }
        }

        public static UnsignedLong NumberOfTableEntries
        {
            get { return new UnsignedLong {Tag = new Tag("00186056")}; }
        }

        public static UnsignedLong TableOfPixelValues
        {
            get { return new UnsignedLong {Tag = new Tag("00186058")}; }
        }

        public static FloatingPointSingle TableOfParameterValues
        {
            get { return new FloatingPointSingle {Tag = new Tag("0018605A")}; }
        }

        public static FloatingPointSingle RWaveTimeVector
        {
            get { return new FloatingPointSingle {Tag = new Tag("00186060")}; }
        }

        public static CodeString DetectorConditionsNominalFlag
        {
            get { return new CodeString {Tag = new Tag("00187000")}; }
        }

        public static DecimalString DetectorTemperature
        {
            get { return new DecimalString {Tag = new Tag("00187001")}; }
        }

        public static CodeString DetectorType
        {
            get { return new CodeString {Tag = new Tag("00187004")}; }
        }

        public static CodeString DetectorConfiguration
        {
            get { return new CodeString {Tag = new Tag("00187005")}; }
        }

        public static LongText DetectorDescription
        {
            get { return new LongText {Tag = new Tag("00187006")}; }
        }

        public static LongText DetectorMode
        {
            get { return new LongText {Tag = new Tag("00187008")}; }
        }

        public static ShortString DetectorID
        {
            get { return new ShortString {Tag = new Tag("0018700A")}; }
        }

        public static Date DateOfLastDetectorCalibration
        {
            get { return new Date {Tag = new Tag("0018700C")}; }
        }

        public static Time TimeOfLastDetectorCalibration
        {
            get { return new Time {Tag = new Tag("0018700E")}; }
        }

        public static IntegerString ExposuresOnDetectorSinceLastCalibration
        {
            get { return new IntegerString {Tag = new Tag("00187010")}; }
        }

        public static IntegerString ExposuresOnDetectorSinceManufactured
        {
            get { return new IntegerString {Tag = new Tag("00187011")}; }
        }

        public static DecimalString DetectorTimeSinceLastExposure
        {
            get { return new DecimalString {Tag = new Tag("00187012")}; }
        }

        public static DecimalString DetectorActiveTime
        {
            get { return new DecimalString {Tag = new Tag("00187014")}; }
        }

        public static DecimalString DetectorActivationOffsetFromExposure
        {
            get { return new DecimalString {Tag = new Tag("00187016")}; }
        }

        public static DecimalString DetectorBinning
        {
            get { return new DecimalString {Tag = new Tag("0018701A")}; }
        }

        public static DecimalString DetectorElementPhysicalSize
        {
            get { return new DecimalString {Tag = new Tag("00187020")}; }
        }

        public static DecimalString DetectorElementSpacing
        {
            get { return new DecimalString {Tag = new Tag("00187022")}; }
        }

        public static CodeString DetectorActiveShape
        {
            get { return new CodeString {Tag = new Tag("00187024")}; }
        }

        public static DecimalString DetectorActiveDimensions
        {
            get { return new DecimalString {Tag = new Tag("00187026")}; }
        }

        public static DecimalString DetectorActiveOrigin
        {
            get { return new DecimalString {Tag = new Tag("00187028")}; }
        }

        public static LongString DetectorManufacturerName
        {
            get { return new LongString {Tag = new Tag("0018702A")}; }
        }

        public static LongString DetectorManufacturerModelName
        {
            get { return new LongString {Tag = new Tag("0018702B")}; }
        }

        public static DecimalString FieldOfViewOrigin
        {
            get { return new DecimalString {Tag = new Tag("00187030")}; }
        }

        public static DecimalString FieldOfViewRotation
        {
            get { return new DecimalString {Tag = new Tag("00187032")}; }
        }

        public static CodeString FieldOfViewHorizontalFlip
        {
            get { return new CodeString {Tag = new Tag("00187034")}; }
        }

        public static FloatingPointSingle PixelDataAreaOriginRelativeToFOV
        {
            get { return new FloatingPointSingle {Tag = new Tag("00187036")}; }
        }

        public static FloatingPointSingle PixelDataAreaRotationAngleRelativeToFOV
        {
            get { return new FloatingPointSingle {Tag = new Tag("00187038")}; }
        }

        public static LongText GridAbsorbingMaterial
        {
            get { return new LongText {Tag = new Tag("00187040")}; }
        }

        public static LongText GridSpacingMaterial
        {
            get { return new LongText {Tag = new Tag("00187041")}; }
        }

        public static DecimalString GridThickness
        {
            get { return new DecimalString {Tag = new Tag("00187042")}; }
        }

        public static DecimalString GridPitch
        {
            get { return new DecimalString {Tag = new Tag("00187044")}; }
        }

        public static IntegerString GridAspectRatio
        {
            get { return new IntegerString {Tag = new Tag("00187046")}; }
        }

        public static DecimalString GridPeriod
        {
            get { return new DecimalString {Tag = new Tag("00187048")}; }
        }

        public static DecimalString GridFocalDistance
        {
            get { return new DecimalString {Tag = new Tag("0018704C")}; }
        }

        public static CodeString FilterMaterial
        {
            get { return new CodeString {Tag = new Tag("00187050")}; }
        }

        public static DecimalString FilterThicknessMinimum
        {
            get { return new DecimalString {Tag = new Tag("00187052")}; }
        }

        public static DecimalString FilterThicknessMaximum
        {
            get { return new DecimalString {Tag = new Tag("00187054")}; }
        }

        public static FloatingPointSingle FilterBeamPathLengthMinimum
        {
            get { return new FloatingPointSingle {Tag = new Tag("00187056")}; }
        }

        public static FloatingPointSingle FilterBeamPathLengthMaximum
        {
            get { return new FloatingPointSingle {Tag = new Tag("00187058")}; }
        }

        public static CodeString ExposureControlMode
        {
            get { return new CodeString {Tag = new Tag("00187060")}; }
        }

        public static LongText ExposureControlModeDescription
        {
            get { return new LongText {Tag = new Tag("00187062")}; }
        }

        public static CodeString ExposureStatus
        {
            get { return new CodeString {Tag = new Tag("00187064")}; }
        }

        public static DecimalString PhototimerSetting
        {
            get { return new DecimalString {Tag = new Tag("00187065")}; }
        }

        public static DecimalString ExposureTimeInuS
        {
            get { return new DecimalString {Tag = new Tag("00188150")}; }
        }

        public static DecimalString XRayTubeCurrentInuA
        {
            get { return new DecimalString {Tag = new Tag("00188151")}; }
        }

        public static CodeString ContentQualification
        {
            get { return new CodeString {Tag = new Tag("00189004")}; }
        }

        public static ShortString PulseSequenceName
        {
            get { return new ShortString {Tag = new Tag("00189005")}; }
        }

        public static Sequence MRImagingModifierSequence
        {
            get { return new Sequence {Tag = new Tag("00189006")}; }
        }

        public static CodeString EchoPulseSequence
        {
            get { return new CodeString {Tag = new Tag("00189008")}; }
        }

        public static CodeString InversionRecovery
        {
            get { return new CodeString {Tag = new Tag("00189009")}; }
        }

        public static CodeString FlowCompensation
        {
            get { return new CodeString {Tag = new Tag("00189010")}; }
        }

        public static CodeString MultipleSpinEcho
        {
            get { return new CodeString {Tag = new Tag("00189011")}; }
        }

        public static CodeString MultiPlanarExcitation
        {
            get { return new CodeString {Tag = new Tag("00189012")}; }
        }

        public static CodeString PhaseContrast
        {
            get { return new CodeString {Tag = new Tag("00189014")}; }
        }

        public static CodeString TimeOfFlightContrast
        {
            get { return new CodeString {Tag = new Tag("00189015")}; }
        }

        public static CodeString Spoiling
        {
            get { return new CodeString {Tag = new Tag("00189016")}; }
        }

        public static CodeString SteadyStatePulseSequence
        {
            get { return new CodeString {Tag = new Tag("00189017")}; }
        }

        public static CodeString EchoPlanarPulseSequence
        {
            get { return new CodeString {Tag = new Tag("00189018")}; }
        }

        public static FloatingPointDouble TagAngleFirstAxis
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189019")}; }
        }

        public static CodeString MagnetizationTransfer
        {
            get { return new CodeString {Tag = new Tag("00189020")}; }
        }

        public static CodeString T2Preparation
        {
            get { return new CodeString {Tag = new Tag("00189021")}; }
        }

        public static CodeString BloodSignalNulling
        {
            get { return new CodeString {Tag = new Tag("00189022")}; }
        }

        public static CodeString SaturationRecovery
        {
            get { return new CodeString {Tag = new Tag("00189024")}; }
        }

        public static CodeString SpectrallySelectedSuppression
        {
            get { return new CodeString {Tag = new Tag("00189025")}; }
        }

        public static CodeString SpectrallySelectedExcitation
        {
            get { return new CodeString {Tag = new Tag("00189026")}; }
        }

        public static CodeString SpatialPresaturation
        {
            get { return new CodeString {Tag = new Tag("00189027")}; }
        }

        public static CodeString Tagging
        {
            get { return new CodeString {Tag = new Tag("00189028")}; }
        }

        public static CodeString OversamplingPhase
        {
            get { return new CodeString {Tag = new Tag("00189029")}; }
        }

        public static FloatingPointDouble TagSpacingFirstDimension
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189030")}; }
        }

        public static CodeString GeometryOfKSpaceTraversal
        {
            get { return new CodeString {Tag = new Tag("00189032")}; }
        }

        public static CodeString SegmentedKSpaceTraversal
        {
            get { return new CodeString {Tag = new Tag("00189033")}; }
        }

        public static CodeString RectilinearPhaseEncodeReordering
        {
            get { return new CodeString {Tag = new Tag("00189034")}; }
        }

        public static FloatingPointDouble TagThickness
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189035")}; }
        }

        public static CodeString PartialFourierDirection
        {
            get { return new CodeString {Tag = new Tag("00189036")}; }
        }

        public static CodeString CardiacSynchronizationTechnique
        {
            get { return new CodeString {Tag = new Tag("00189037")}; }
        }

        public static LongString ReceiveCoilManufacturerName
        {
            get { return new LongString {Tag = new Tag("00189041")}; }
        }

        public static Sequence MRReceiveCoilSequence
        {
            get { return new Sequence {Tag = new Tag("00189042")}; }
        }

        public static CodeString ReceiveCoilType
        {
            get { return new CodeString {Tag = new Tag("00189043")}; }
        }

        public static CodeString QuadratureReceiveCoil
        {
            get { return new CodeString {Tag = new Tag("00189044")}; }
        }

        public static Sequence MultiCoilDefinitionSequence
        {
            get { return new Sequence {Tag = new Tag("00189045")}; }
        }

        public static LongString MultiCoilConfiguration
        {
            get { return new LongString {Tag = new Tag("00189046")}; }
        }

        public static ShortString MultiCoilElementName
        {
            get { return new ShortString {Tag = new Tag("00189047")}; }
        }

        public static CodeString MultiCoilElementUsed
        {
            get { return new CodeString {Tag = new Tag("00189048")}; }
        }

        public static Sequence MRTransmitCoilSequence
        {
            get { return new Sequence {Tag = new Tag("00189049")}; }
        }

        public static LongString TransmitCoilManufacturerName
        {
            get { return new LongString {Tag = new Tag("00189050")}; }
        }

        public static CodeString TransmitCoilType
        {
            get { return new CodeString {Tag = new Tag("00189051")}; }
        }

        public static FloatingPointDouble SpectralWidth
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189052")}; }
        }

        public static FloatingPointDouble ChemicalShiftReference
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189053")}; }
        }

        public static CodeString VolumeLocalizationTechnique
        {
            get { return new CodeString {Tag = new Tag("00189054")}; }
        }

        public static UnsignedShort MRAcquisitionFrequencyEncodingSteps
        {
            get { return new UnsignedShort {Tag = new Tag("00189058")}; }
        }

        public static CodeString Decoupling
        {
            get { return new CodeString {Tag = new Tag("00189059")}; }
        }

        public static CodeString DecoupledNucleus
        {
            get { return new CodeString {Tag = new Tag("00189060")}; }
        }

        public static FloatingPointDouble DecouplingFrequency
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189061")}; }
        }

        public static CodeString DecouplingMethod
        {
            get { return new CodeString {Tag = new Tag("00189062")}; }
        }

        public static FloatingPointDouble DecouplingChemicalShiftReference
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189063")}; }
        }

        public static CodeString KSpaceFiltering
        {
            get { return new CodeString {Tag = new Tag("00189064")}; }
        }

        public static CodeString TimeDomainFiltering
        {
            get { return new CodeString {Tag = new Tag("00189065")}; }
        }

        public static UnsignedShort NumberOfZeroFills
        {
            get { return new UnsignedShort {Tag = new Tag("00189066")}; }
        }

        public static CodeString BaselineCorrection
        {
            get { return new CodeString {Tag = new Tag("00189067")}; }
        }

        public static FloatingPointDouble ParallelReductionFactorInPlane
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189069")}; }
        }

        public static FloatingPointDouble CardiacRRIntervalSpecified
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189070")}; }
        }

        public static FloatingPointDouble AcquisitionDuration
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189073")}; }
        }

        public static CodeString DiffusionDirectionality
        {
            get { return new CodeString {Tag = new Tag("00189075")}; }
        }

        public static Sequence DiffusionGradientDirectionSequence
        {
            get { return new Sequence {Tag = new Tag("00189076")}; }
        }

        public static CodeString ParallelAcquisition
        {
            get { return new CodeString {Tag = new Tag("00189077")}; }
        }

        public static CodeString ParallelAcquisitionTechnique
        {
            get { return new CodeString {Tag = new Tag("00189078")}; }
        }

        public static FloatingPointDouble InversionTimes
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189079")}; }
        }

        public static ShortText MetaboliteMapDescription
        {
            get { return new ShortText {Tag = new Tag("00189080")}; }
        }

        public static CodeString PartialFourier
        {
            get { return new CodeString {Tag = new Tag("00189081")}; }
        }

        public static FloatingPointDouble EffectiveEchoTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189082")}; }
        }

        public static Sequence MetaboliteMapCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00189083")}; }
        }

        public static Sequence ChemicalShiftSequence
        {
            get { return new Sequence {Tag = new Tag("00189084")}; }
        }

        public static CodeString CardiacSignalSource
        {
            get { return new CodeString {Tag = new Tag("00189085")}; }
        }

        public static FloatingPointDouble DiffusionBValue
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189087")}; }
        }

        public static FloatingPointDouble DiffusionGradientOrientation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189089")}; }
        }

        public static FloatingPointDouble VelocityEncodingDirection
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189090")}; }
        }

        public static FloatingPointDouble VelocityEncodingMinimumValue
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189091")}; }
        }

        public static Sequence VelocityEncodingAcquisitionSequence
        {
            get { return new Sequence {Tag = new Tag("00189092")}; }
        }

        public static UnsignedShort NumberOfKSpaceTrajectories
        {
            get { return new UnsignedShort {Tag = new Tag("00189093")}; }
        }

        public static CodeString CoverageOfKSpace
        {
            get { return new CodeString {Tag = new Tag("00189094")}; }
        }

        public static UnsignedLong SpectroscopyAcquisitionPhaseRows
        {
            get { return new UnsignedLong {Tag = new Tag("00189095")}; }
        }

        public static FloatingPointDouble ParallelReductionFactorInPlaneRetired
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189096")}; }
        }

        public static FloatingPointDouble TransmitterFrequency
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189098")}; }
        }

        public static CodeString ResonantNucleus
        {
            get { return new CodeString {Tag = new Tag("00189100")}; }
        }

        public static CodeString FrequencyCorrection
        {
            get { return new CodeString {Tag = new Tag("00189101")}; }
        }

        public static Sequence MRSpectroscopyFOVGeometrySequence
        {
            get { return new Sequence {Tag = new Tag("00189103")}; }
        }

        public static FloatingPointDouble SlabThickness
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189104")}; }
        }

        public static FloatingPointDouble SlabOrientation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189105")}; }
        }

        public static FloatingPointDouble MidSlabPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189106")}; }
        }

        public static Sequence MRSpatialSaturationSequence
        {
            get { return new Sequence {Tag = new Tag("00189107")}; }
        }

        public static Sequence MRTimingAndRelatedParametersSequence
        {
            get { return new Sequence {Tag = new Tag("00189112")}; }
        }

        public static Sequence MREchoSequence
        {
            get { return new Sequence {Tag = new Tag("00189114")}; }
        }

        public static Sequence MRModifierSequence
        {
            get { return new Sequence {Tag = new Tag("00189115")}; }
        }

        public static Sequence MRDiffusionSequence
        {
            get { return new Sequence {Tag = new Tag("00189117")}; }
        }

        public static Sequence CardiacSynchronizationSequence
        {
            get { return new Sequence {Tag = new Tag("00189118")}; }
        }

        public static Sequence MRAveragesSequence
        {
            get { return new Sequence {Tag = new Tag("00189119")}; }
        }

        public static Sequence MRFOVGeometrySequence
        {
            get { return new Sequence {Tag = new Tag("00189125")}; }
        }

        public static Sequence VolumeLocalizationSequence
        {
            get { return new Sequence {Tag = new Tag("00189126")}; }
        }

        public static UnsignedLong SpectroscopyAcquisitionDataColumns
        {
            get { return new UnsignedLong {Tag = new Tag("00189127")}; }
        }

        public static CodeString DiffusionAnisotropyType
        {
            get { return new CodeString {Tag = new Tag("00189147")}; }
        }

        public static Sequence MRMetaboliteMapSequence
        {
            get { return new Sequence {Tag = new Tag("00189152")}; }
        }

        public static FloatingPointDouble ParallelReductionFactorOutOfPlane
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189155")}; }
        }

        public static UnsignedLong SpectroscopyAcquisitionOutOfPlanePhaseSteps
        {
            get { return new UnsignedLong {Tag = new Tag("00189159")}; }
        }

        public static CodeString BulkMotionStatusRetired
        {
            get { return new CodeString {Tag = new Tag("00189166")}; }
        }

        public static FloatingPointDouble ParallelReductionFactorSecondInPlane
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189168")}; }
        }

        public static CodeString CardiacBeatRejectionTechnique
        {
            get { return new CodeString {Tag = new Tag("00189169")}; }
        }

        public static CodeString RespiratoryMotionCompensationTechnique
        {
            get { return new CodeString {Tag = new Tag("00189170")}; }
        }

        public static CodeString RespiratorySignalSource
        {
            get { return new CodeString {Tag = new Tag("00189171")}; }
        }

        public static CodeString BulkMotionCompensationTechnique
        {
            get { return new CodeString {Tag = new Tag("00189172")}; }
        }

        public static CodeString BulkMotionSignalSource
        {
            get { return new CodeString {Tag = new Tag("00189173")}; }
        }

        public static CodeString ApplicableSafetyStandardAgency
        {
            get { return new CodeString {Tag = new Tag("00189174")}; }
        }

        public static LongString ApplicableSafetyStandardDescription
        {
            get { return new LongString {Tag = new Tag("00189175")}; }
        }

        public static Sequence OperatingModeSequence
        {
            get { return new Sequence {Tag = new Tag("00189176")}; }
        }

        public static CodeString OperatingModeType
        {
            get { return new CodeString {Tag = new Tag("00189177")}; }
        }

        public static CodeString OperatingMode
        {
            get { return new CodeString {Tag = new Tag("00189178")}; }
        }

        public static CodeString SpecificAbsorptionRateDefinition
        {
            get { return new CodeString {Tag = new Tag("00189179")}; }
        }

        public static CodeString GradientOutputType
        {
            get { return new CodeString {Tag = new Tag("00189180")}; }
        }

        public static FloatingPointDouble SpecificAbsorptionRateValue
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189181")}; }
        }

        public static FloatingPointDouble GradientOutput
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189182")}; }
        }

        public static CodeString FlowCompensationDirection
        {
            get { return new CodeString {Tag = new Tag("00189183")}; }
        }

        public static FloatingPointDouble TaggingDelay
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189184")}; }
        }

        public static ShortText RespiratoryMotionCompensationTechniqueDescription
        {
            get { return new ShortText {Tag = new Tag("00189185")}; }
        }

        public static ShortString RespiratorySignalSourceID
        {
            get { return new ShortString {Tag = new Tag("00189186")}; }
        }

        public static FloatingPointDouble ChemicalShiftMinimumIntegrationLimitInHzRetired
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189195")}; }
        }

        public static FloatingPointDouble ChemicalShiftMaximumIntegrationLimitInHzRetired
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189196")}; }
        }

        public static Sequence MRVelocityEncodingSequence
        {
            get { return new Sequence {Tag = new Tag("00189197")}; }
        }

        public static CodeString FirstOrderPhaseCorrection
        {
            get { return new CodeString {Tag = new Tag("00189198")}; }
        }

        public static CodeString WaterReferencedPhaseCorrection
        {
            get { return new CodeString {Tag = new Tag("00189199")}; }
        }

        public static CodeString MRSpectroscopyAcquisitionType
        {
            get { return new CodeString {Tag = new Tag("00189200")}; }
        }

        public static CodeString RespiratoryCyclePosition
        {
            get { return new CodeString {Tag = new Tag("00189214")}; }
        }

        public static FloatingPointDouble VelocityEncodingMaximumValue
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189217")}; }
        }

        public static FloatingPointDouble TagSpacingSecondDimension
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189218")}; }
        }

        public static SignedShort TagAngleSecondAxis
        {
            get { return new SignedShort {Tag = new Tag("00189219")}; }
        }

        public static FloatingPointDouble FrameAcquisitionDuration
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189220")}; }
        }

        public static Sequence MRImageFrameTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189226")}; }
        }

        public static Sequence MRSpectroscopyFrameTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189227")}; }
        }

        public static UnsignedShort MRAcquisitionPhaseEncodingStepsInPlane
        {
            get { return new UnsignedShort {Tag = new Tag("00189231")}; }
        }

        public static UnsignedShort MRAcquisitionPhaseEncodingStepsOutOfPlane
        {
            get { return new UnsignedShort {Tag = new Tag("00189232")}; }
        }

        public static UnsignedLong SpectroscopyAcquisitionPhaseColumns
        {
            get { return new UnsignedLong {Tag = new Tag("00189234")}; }
        }

        public static CodeString CardiacCyclePosition
        {
            get { return new CodeString {Tag = new Tag("00189236")}; }
        }

        public static Sequence SpecificAbsorptionRateSequence
        {
            get { return new Sequence {Tag = new Tag("00189239")}; }
        }

        public static UnsignedShort RFEchoTrainLength
        {
            get { return new UnsignedShort {Tag = new Tag("00189240")}; }
        }

        public static UnsignedShort GradientEchoTrainLength
        {
            get { return new UnsignedShort {Tag = new Tag("00189241")}; }
        }

        public static CodeString ArterialSpinLabelingContrast
        {
            get { return new CodeString {Tag = new Tag("00189250")}; }
        }

        public static Sequence MRArterialSpinLabelingSequence
        {
            get { return new Sequence {Tag = new Tag("00189251")}; }
        }

        public static LongString ASLTechniqueDescription
        {
            get { return new LongString {Tag = new Tag("00189252")}; }
        }

        public static UnsignedShort ASLSlabNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00189253")}; }
        }

        public static FloatingPointDouble ASLSlabThickness
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189254")}; }
        }

        public static FloatingPointDouble ASLSlabOrientation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189255")}; }
        }

        public static FloatingPointDouble ASLMidSlabPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189256")}; }
        }

        public static CodeString ASLContext
        {
            get { return new CodeString {Tag = new Tag("00189257")}; }
        }

        public static UnsignedLong ASLPulseTrainDuration
        {
            get { return new UnsignedLong {Tag = new Tag("00189258")}; }
        }

        public static CodeString ASLCrusherFlag
        {
            get { return new CodeString {Tag = new Tag("00189259")}; }
        }

        public static FloatingPointDouble ASLCrusherFlow
        {
            get { return new FloatingPointDouble {Tag = new Tag("0018925A")}; }
        }

        public static LongString ASLCrusherDescription
        {
            get { return new LongString {Tag = new Tag("0018925B")}; }
        }

        public static CodeString ASLBolusCutoffFlag
        {
            get { return new CodeString {Tag = new Tag("0018925C")}; }
        }

        public static Sequence ASLBolusCutoffTimingSequence
        {
            get { return new Sequence {Tag = new Tag("0018925D")}; }
        }

        public static LongString ASLBolusCutoffTechnique
        {
            get { return new LongString {Tag = new Tag("0018925E")}; }
        }

        public static UnsignedLong ASLBolusCutoffDelayTime
        {
            get { return new UnsignedLong {Tag = new Tag("0018925F")}; }
        }

        public static Sequence ASLSlabSequence
        {
            get { return new Sequence {Tag = new Tag("00189260")}; }
        }

        public static FloatingPointDouble ChemicalShiftMinimumIntegrationLimitInppm
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189295")}; }
        }

        public static FloatingPointDouble ChemicalShiftMaximumIntegrationLimitInppm
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189296")}; }
        }

        public static Sequence CTAcquisitionTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189301")}; }
        }

        public static CodeString AcquisitionType
        {
            get { return new CodeString {Tag = new Tag("00189302")}; }
        }

        public static FloatingPointDouble TubeAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189303")}; }
        }

        public static Sequence CTAcquisitionDetailsSequence
        {
            get { return new Sequence {Tag = new Tag("00189304")}; }
        }

        public static FloatingPointDouble RevolutionTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189305")}; }
        }

        public static FloatingPointDouble SingleCollimationWidth
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189306")}; }
        }

        public static FloatingPointDouble TotalCollimationWidth
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189307")}; }
        }

        public static Sequence CTTableDynamicsSequence
        {
            get { return new Sequence {Tag = new Tag("00189308")}; }
        }

        public static FloatingPointDouble TableSpeed
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189309")}; }
        }

        public static FloatingPointDouble TableFeedPerRotation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189310")}; }
        }

        public static FloatingPointDouble SpiralPitchFactor
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189311")}; }
        }

        public static Sequence CTGeometrySequence
        {
            get { return new Sequence {Tag = new Tag("00189312")}; }
        }

        public static FloatingPointDouble DataCollectionCenterPatient
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189313")}; }
        }

        public static Sequence CTReconstructionSequence
        {
            get { return new Sequence {Tag = new Tag("00189314")}; }
        }

        public static CodeString ReconstructionAlgorithm
        {
            get { return new CodeString {Tag = new Tag("00189315")}; }
        }

        public static CodeString ConvolutionKernelGroup
        {
            get { return new CodeString {Tag = new Tag("00189316")}; }
        }

        public static FloatingPointDouble ReconstructionFieldOfView
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189317")}; }
        }

        public static FloatingPointDouble ReconstructionTargetCenterPatient
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189318")}; }
        }

        public static FloatingPointDouble ReconstructionAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189319")}; }
        }

        public static ShortString ImageFilter
        {
            get { return new ShortString {Tag = new Tag("00189320")}; }
        }

        public static Sequence CTExposureSequence
        {
            get { return new Sequence {Tag = new Tag("00189321")}; }
        }

        public static FloatingPointDouble ReconstructionPixelSpacing
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189322")}; }
        }

        public static CodeString ExposureModulationType
        {
            get { return new CodeString {Tag = new Tag("00189323")}; }
        }

        public static FloatingPointDouble EstimatedDoseSaving
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189324")}; }
        }

        public static Sequence CTXRayDetailsSequence
        {
            get { return new Sequence {Tag = new Tag("00189325")}; }
        }

        public static Sequence CTPositionSequence
        {
            get { return new Sequence {Tag = new Tag("00189326")}; }
        }

        public static FloatingPointDouble TablePosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189327")}; }
        }

        public static FloatingPointDouble ExposureTimeInms
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189328")}; }
        }

        public static Sequence CTImageFrameTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189329")}; }
        }

        public static FloatingPointDouble XRayTubeCurrentInmA
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189330")}; }
        }

        public static FloatingPointDouble ExposureInmAs
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189332")}; }
        }

        public static CodeString ConstantVolumeFlag
        {
            get { return new CodeString {Tag = new Tag("00189333")}; }
        }

        public static CodeString FluoroscopyFlag
        {
            get { return new CodeString {Tag = new Tag("00189334")}; }
        }

        public static FloatingPointDouble DistanceSourceToDataCollectionCenter
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189335")}; }
        }

        public static UnsignedShort ContrastBolusAgentNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00189337")}; }
        }

        public static Sequence ContrastBolusIngredientCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00189338")}; }
        }

        public static Sequence ContrastAdministrationProfileSequence
        {
            get { return new Sequence {Tag = new Tag("00189340")}; }
        }

        public static Sequence ContrastBolusUsageSequence
        {
            get { return new Sequence {Tag = new Tag("00189341")}; }
        }

        public static CodeString ContrastBolusAgentAdministered
        {
            get { return new CodeString {Tag = new Tag("00189342")}; }
        }

        public static CodeString ContrastBolusAgentDetected
        {
            get { return new CodeString {Tag = new Tag("00189343")}; }
        }

        public static CodeString ContrastBolusAgentPhase
        {
            get { return new CodeString {Tag = new Tag("00189344")}; }
        }

        public static FloatingPointDouble CTDIvol
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189345")}; }
        }

        public static Sequence CTDIPhantomTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00189346")}; }
        }

        public static FloatingPointSingle CalciumScoringMassFactorPatient
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189351")}; }
        }

        public static FloatingPointSingle CalciumScoringMassFactorDevice
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189352")}; }
        }

        public static FloatingPointSingle EnergyWeightingFactor
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189353")}; }
        }

        public static Sequence CTAdditionalXRaySourceSequence
        {
            get { return new Sequence {Tag = new Tag("00189360")}; }
        }

        public static Sequence ProjectionPixelCalibrationSequence
        {
            get { return new Sequence {Tag = new Tag("00189401")}; }
        }

        public static FloatingPointSingle DistanceSourceToIsocenter
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189402")}; }
        }

        public static FloatingPointSingle DistanceObjectToTableTop
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189403")}; }
        }

        public static FloatingPointSingle ObjectPixelSpacingInCenterOfBeam
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189404")}; }
        }

        public static Sequence PositionerPositionSequence
        {
            get { return new Sequence {Tag = new Tag("00189405")}; }
        }

        public static Sequence TablePositionSequence
        {
            get { return new Sequence {Tag = new Tag("00189406")}; }
        }

        public static Sequence CollimatorShapeSequence
        {
            get { return new Sequence {Tag = new Tag("00189407")}; }
        }

        public static CodeString PlanesInAcquisition
        {
            get { return new CodeString {Tag = new Tag("00189410")}; }
        }

        public static Sequence XAXRFFrameCharacteristicsSequence
        {
            get { return new Sequence {Tag = new Tag("00189412")}; }
        }

        public static Sequence FrameAcquisitionSequence
        {
            get { return new Sequence {Tag = new Tag("00189417")}; }
        }

        public static CodeString XRayReceptorType
        {
            get { return new CodeString {Tag = new Tag("00189420")}; }
        }

        public static LongString AcquisitionProtocolName
        {
            get { return new LongString {Tag = new Tag("00189423")}; }
        }

        public static LongText AcquisitionProtocolDescription
        {
            get { return new LongText {Tag = new Tag("00189424")}; }
        }

        public static CodeString ContrastBolusIngredientOpaque
        {
            get { return new CodeString {Tag = new Tag("00189425")}; }
        }

        public static FloatingPointSingle DistanceReceptorPlaneToDetectorHousing
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189426")}; }
        }

        public static CodeString IntensifierActiveShape
        {
            get { return new CodeString {Tag = new Tag("00189427")}; }
        }

        public static FloatingPointSingle IntensifierActiveDimensions
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189428")}; }
        }

        public static FloatingPointSingle PhysicalDetectorSize
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189429")}; }
        }

        public static FloatingPointSingle PositionOfIsocenterProjection
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189430")}; }
        }

        public static Sequence FieldOfViewSequence
        {
            get { return new Sequence {Tag = new Tag("00189432")}; }
        }

        public static LongString FieldOfViewDescription
        {
            get { return new LongString {Tag = new Tag("00189433")}; }
        }

        public static Sequence ExposureControlSensingRegionsSequence
        {
            get { return new Sequence {Tag = new Tag("00189434")}; }
        }

        public static CodeString ExposureControlSensingRegionShape
        {
            get { return new CodeString {Tag = new Tag("00189435")}; }
        }

        public static SignedShort ExposureControlSensingRegionLeftVerticalEdge
        {
            get { return new SignedShort {Tag = new Tag("00189436")}; }
        }

        public static SignedShort ExposureControlSensingRegionRightVerticalEdge
        {
            get { return new SignedShort {Tag = new Tag("00189437")}; }
        }

        public static SignedShort ExposureControlSensingRegionUpperHorizontalEdge
        {
            get { return new SignedShort {Tag = new Tag("00189438")}; }
        }

        public static SignedShort ExposureControlSensingRegionLowerHorizontalEdge
        {
            get { return new SignedShort {Tag = new Tag("00189439")}; }
        }

        public static SignedShort CenterOfCircularExposureControlSensingRegion
        {
            get { return new SignedShort {Tag = new Tag("00189440")}; }
        }

        public static UnsignedShort RadiusOfCircularExposureControlSensingRegion
        {
            get { return new UnsignedShort {Tag = new Tag("00189441")}; }
        }

        public static SignedShort VerticesOfThePolygonalExposureControlSensingRegion
        {
            get { return new SignedShort {Tag = new Tag("00189442")}; }
        }

        public static FloatingPointSingle ColumnAngulationPatient
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189447")}; }
        }

        public static FloatingPointSingle BeamAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189449")}; }
        }

        public static Sequence FrameDetectorParametersSequence
        {
            get { return new Sequence {Tag = new Tag("00189451")}; }
        }

        public static FloatingPointSingle CalculatedAnatomyThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189452")}; }
        }

        public static Sequence CalibrationSequence
        {
            get { return new Sequence {Tag = new Tag("00189455")}; }
        }

        public static Sequence ObjectThicknessSequence
        {
            get { return new Sequence {Tag = new Tag("00189456")}; }
        }

        public static CodeString PlaneIdentification
        {
            get { return new CodeString {Tag = new Tag("00189457")}; }
        }

        public static FloatingPointSingle FieldOfViewDimensionsInFloat
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189461")}; }
        }

        public static Sequence IsocenterReferenceSystemSequence
        {
            get { return new Sequence {Tag = new Tag("00189462")}; }
        }

        public static FloatingPointSingle PositionerIsocenterPrimaryAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189463")}; }
        }

        public static FloatingPointSingle PositionerIsocenterSecondaryAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189464")}; }
        }

        public static FloatingPointSingle PositionerIsocenterDetectorRotationAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189465")}; }
        }

        public static FloatingPointSingle TableXPositionToIsocenter
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189466")}; }
        }

        public static FloatingPointSingle TableYPositionToIsocenter
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189467")}; }
        }

        public static FloatingPointSingle TableZPositionToIsocenter
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189468")}; }
        }

        public static FloatingPointSingle TableHorizontalRotationAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189469")}; }
        }

        public static FloatingPointSingle TableHeadTiltAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189470")}; }
        }

        public static FloatingPointSingle TableCradleTiltAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189471")}; }
        }

        public static Sequence FrameDisplayShutterSequence
        {
            get { return new Sequence {Tag = new Tag("00189472")}; }
        }

        public static FloatingPointSingle AcquiredImageAreaDoseProduct
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189473")}; }
        }

        public static CodeString CArmPositionerTabletopRelationship
        {
            get { return new CodeString {Tag = new Tag("00189474")}; }
        }

        public static Sequence XRayGeometrySequence
        {
            get { return new Sequence {Tag = new Tag("00189476")}; }
        }

        public static Sequence IrradiationEventIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00189477")}; }
        }

        public static Sequence XRay3DFrameTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189504")}; }
        }

        public static Sequence ContributingSourcesSequence
        {
            get { return new Sequence {Tag = new Tag("00189506")}; }
        }

        public static Sequence XRay3DAcquisitionSequence
        {
            get { return new Sequence {Tag = new Tag("00189507")}; }
        }

        public static FloatingPointSingle PrimaryPositionerScanArc
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189508")}; }
        }

        public static FloatingPointSingle SecondaryPositionerScanArc
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189509")}; }
        }

        public static FloatingPointSingle PrimaryPositionerScanStartAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189510")}; }
        }

        public static FloatingPointSingle SecondaryPositionerScanStartAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189511")}; }
        }

        public static FloatingPointSingle PrimaryPositionerIncrement
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189514")}; }
        }

        public static FloatingPointSingle SecondaryPositionerIncrement
        {
            get { return new FloatingPointSingle {Tag = new Tag("00189515")}; }
        }

        public static LongString ApplicationName
        {
            get { return new LongString {Tag = new Tag("00189524")}; }
        }

        public static LongString ApplicationVersion
        {
            get { return new LongString {Tag = new Tag("00189525")}; }
        }

        public static LongString ApplicationManufacturer
        {
            get { return new LongString {Tag = new Tag("00189526")}; }
        }

        public static CodeString AlgorithmType
        {
            get { return new CodeString {Tag = new Tag("00189527")}; }
        }

        public static LongString AlgorithmDescription
        {
            get { return new LongString {Tag = new Tag("00189528")}; }
        }

        public static Sequence XRay3DReconstructionSequence
        {
            get { return new Sequence {Tag = new Tag("00189530")}; }
        }

        public static LongString ReconstructionDescription
        {
            get { return new LongString {Tag = new Tag("00189531")}; }
        }

        public static Sequence PerProjectionAcquisitionSequence
        {
            get { return new Sequence {Tag = new Tag("00189538")}; }
        }

        public static Sequence DiffusionBMatrixSequence
        {
            get { return new Sequence {Tag = new Tag("00189601")}; }
        }

        public static FloatingPointDouble DiffusionBValueXX
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189602")}; }
        }

        public static FloatingPointDouble DiffusionBValueXY
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189603")}; }
        }

        public static FloatingPointDouble DiffusionBValueXZ
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189604")}; }
        }

        public static FloatingPointDouble DiffusionBValueYY
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189605")}; }
        }

        public static FloatingPointDouble DiffusionBValueYZ
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189606")}; }
        }

        public static FloatingPointDouble DiffusionBValueZZ
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189607")}; }
        }

        public static FloatingPointDouble StartDensityThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189715")}; }
        }

        public static FloatingPointDouble StartRelativeDensityDifferenceThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189716")}; }
        }

        public static FloatingPointDouble StartCardiacTriggerCountThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189717")}; }
        }

        public static FloatingPointDouble StartRespiratoryTriggerCountThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189718")}; }
        }

        public static FloatingPointDouble TerminationCountsThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189719")}; }
        }

        public static FloatingPointDouble TerminationDensityThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189720")}; }
        }

        public static FloatingPointDouble TerminationRelativeDensityThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189721")}; }
        }

        public static FloatingPointDouble TerminationTimeThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189722")}; }
        }

        public static FloatingPointDouble TerminationCardiacTriggerCountThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189723")}; }
        }

        public static FloatingPointDouble TerminationRespiratoryTriggerCountThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189724")}; }
        }

        public static CodeString DetectorGeometry
        {
            get { return new CodeString {Tag = new Tag("00189725")}; }
        }

        public static FloatingPointDouble TransverseDetectorSeparation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189726")}; }
        }

        public static FloatingPointDouble AxialDetectorDimension
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189727")}; }
        }

        public static UnsignedShort RadiopharmaceuticalAgentNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00189729")}; }
        }

        public static Sequence PETFrameAcquisitionSequence
        {
            get { return new Sequence {Tag = new Tag("00189732")}; }
        }

        public static Sequence PETDetectorMotionDetailsSequence
        {
            get { return new Sequence {Tag = new Tag("00189733")}; }
        }

        public static Sequence PETTableDynamicsSequence
        {
            get { return new Sequence {Tag = new Tag("00189734")}; }
        }

        public static Sequence PETPositionSequence
        {
            get { return new Sequence {Tag = new Tag("00189735")}; }
        }

        public static Sequence PETFrameCorrectionFactorsSequence
        {
            get { return new Sequence {Tag = new Tag("00189736")}; }
        }

        public static Sequence RadiopharmaceuticalUsageSequence
        {
            get { return new Sequence {Tag = new Tag("00189737")}; }
        }

        public static CodeString AttenuationCorrectionSource
        {
            get { return new CodeString {Tag = new Tag("00189738")}; }
        }

        public static UnsignedShort NumberOfIterations
        {
            get { return new UnsignedShort {Tag = new Tag("00189739")}; }
        }

        public static UnsignedShort NumberOfSubsets
        {
            get { return new UnsignedShort {Tag = new Tag("00189740")}; }
        }

        public static Sequence PETReconstructionSequence
        {
            get { return new Sequence {Tag = new Tag("00189749")}; }
        }

        public static Sequence PETFrameTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189751")}; }
        }

        public static CodeString TimeOfFlightInformationUsed
        {
            get { return new CodeString {Tag = new Tag("00189755")}; }
        }

        public static CodeString ReconstructionType
        {
            get { return new CodeString {Tag = new Tag("00189756")}; }
        }

        public static CodeString DecayCorrected
        {
            get { return new CodeString {Tag = new Tag("00189758")}; }
        }

        public static CodeString AttenuationCorrected
        {
            get { return new CodeString {Tag = new Tag("00189759")}; }
        }

        public static CodeString ScatterCorrected
        {
            get { return new CodeString {Tag = new Tag("00189760")}; }
        }

        public static CodeString DeadTimeCorrected
        {
            get { return new CodeString {Tag = new Tag("00189761")}; }
        }

        public static CodeString GantryMotionCorrected
        {
            get { return new CodeString {Tag = new Tag("00189762")}; }
        }

        public static CodeString PatientMotionCorrected
        {
            get { return new CodeString {Tag = new Tag("00189763")}; }
        }

        public static CodeString CountLossNormalizationCorrected
        {
            get { return new CodeString {Tag = new Tag("00189764")}; }
        }

        public static CodeString RandomsCorrected
        {
            get { return new CodeString {Tag = new Tag("00189765")}; }
        }

        public static CodeString NonUniformRadialSamplingCorrected
        {
            get { return new CodeString {Tag = new Tag("00189766")}; }
        }

        public static CodeString SensitivityCalibrated
        {
            get { return new CodeString {Tag = new Tag("00189767")}; }
        }

        public static CodeString DetectorNormalizationCorrection
        {
            get { return new CodeString {Tag = new Tag("00189768")}; }
        }

        public static CodeString IterativeReconstructionMethod
        {
            get { return new CodeString {Tag = new Tag("00189769")}; }
        }

        public static CodeString AttenuationCorrectionTemporalRelationship
        {
            get { return new CodeString {Tag = new Tag("00189770")}; }
        }

        public static Sequence PatientPhysiologicalStateSequence
        {
            get { return new Sequence {Tag = new Tag("00189771")}; }
        }

        public static Sequence PatientPhysiologicalStateCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00189772")}; }
        }

        public static FloatingPointDouble DepthsOfFocus
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189801")}; }
        }

        public static Sequence ExcludedIntervalsSequence
        {
            get { return new Sequence {Tag = new Tag("00189803")}; }
        }

        public static FloatingPointDouble ExclusionDuration
        {
            get { return new FloatingPointDouble {Tag = new Tag("00189805")}; }
        }

        public static Sequence USImageDescriptionSequence
        {
            get { return new Sequence {Tag = new Tag("00189806")}; }
        }

        public static Sequence ImageDataTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00189807")}; }
        }

        public static CodeString DataType
        {
            get { return new CodeString {Tag = new Tag("00189808")}; }
        }

        public static Sequence TransducerScanPatternCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00189809")}; }
        }

        public static CodeString AliasedDataType
        {
            get { return new CodeString {Tag = new Tag("0018980B")}; }
        }

        public static CodeString PositionMeasuringDeviceUsed
        {
            get { return new CodeString {Tag = new Tag("0018980C")}; }
        }

        public static Sequence TransducerGeometryCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0018980D")}; }
        }

        public static Sequence TransducerBeamSteeringCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0018980E")}; }
        }

        public static Sequence TransducerApplicationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0018980F")}; }
        }

        public static Sequence ContributingEquipmentSequence
        {
            get { return new Sequence {Tag = new Tag("0018A001")}; }
        }

        public static ShortText ContributionDescription
        {
            get { return new ShortText {Tag = new Tag("0018A003")}; }
        }

        public static UniqueIdentifier StudyInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0020000D")}; }
        }

        public static UniqueIdentifier SeriesInstanceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0020000E")}; }
        }

        public static ShortString StudyID
        {
            get { return new ShortString {Tag = new Tag("00200010")}; }
        }

        public static IntegerString SeriesNumber
        {
            get { return new IntegerString {Tag = new Tag("00200011")}; }
        }

        public static IntegerString AcquisitionNumber
        {
            get { return new IntegerString {Tag = new Tag("00200012")}; }
        }

        public static IntegerString InstanceNumber
        {
            get { return new IntegerString {Tag = new Tag("00200013")}; }
        }

        public static IntegerString IsotopeNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200014")}; }
        }

        public static IntegerString PhaseNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200015")}; }
        }

        public static IntegerString IntervalNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200016")}; }
        }

        public static IntegerString TimeSlotNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200017")}; }
        }

        public static IntegerString AngleNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200018")}; }
        }

        public static IntegerString ItemNumber
        {
            get { return new IntegerString {Tag = new Tag("00200019")}; }
        }

        public static CodeString PatientOrientation
        {
            get { return new CodeString {Tag = new Tag("00200020")}; }
        }

        public static IntegerString OverlayNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200022")}; }
        }

        public static IntegerString CurveNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200024")}; }
        }

        public static IntegerString LUTNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("00200026")}; }
        }

        public static DecimalString ImagePositionRetired
        {
            get { return new DecimalString {Tag = new Tag("00200030")}; }
        }

        public static DecimalString ImagePositionPatient
        {
            get { return new DecimalString {Tag = new Tag("00200032")}; }
        }

        public static DecimalString ImageOrientationRetired
        {
            get { return new DecimalString {Tag = new Tag("00200035")}; }
        }

        public static DecimalString ImageOrientationPatient
        {
            get { return new DecimalString {Tag = new Tag("00200037")}; }
        }

        public static DecimalString LocationRetired
        {
            get { return new DecimalString {Tag = new Tag("00200050")}; }
        }

        public static UniqueIdentifier FrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00200052")}; }
        }

        public static CodeString Laterality
        {
            get { return new CodeString {Tag = new Tag("00200060")}; }
        }

        public static CodeString ImageLaterality
        {
            get { return new CodeString {Tag = new Tag("00200062")}; }
        }

        public static LongString ImageGeometryTypeRetired
        {
            get { return new LongString {Tag = new Tag("00200070")}; }
        }

        public static CodeString MaskingImageRetired
        {
            get { return new CodeString {Tag = new Tag("00200080")}; }
        }

        public static IntegerString ReportNumberRetired
        {
            get { return new IntegerString {Tag = new Tag("002000AA")}; }
        }

        public static IntegerString TemporalPositionIdentifier
        {
            get { return new IntegerString {Tag = new Tag("00200100")}; }
        }

        public static IntegerString NumberOfTemporalPositions
        {
            get { return new IntegerString {Tag = new Tag("00200105")}; }
        }

        public static DecimalString TemporalResolution
        {
            get { return new DecimalString {Tag = new Tag("00200110")}; }
        }

        public static UniqueIdentifier SynchronizationFrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00200200")}; }
        }

        public static UniqueIdentifier SOPInstanceUIDOfConcatenationSource
        {
            get { return new UniqueIdentifier {Tag = new Tag("00200242")}; }
        }

        public static IntegerString SeriesInStudyRetired
        {
            get { return new IntegerString {Tag = new Tag("00201000")}; }
        }

        public static IntegerString AcquisitionsInSeriesRetired
        {
            get { return new IntegerString {Tag = new Tag("00201001")}; }
        }

        public static IntegerString ImagesInAcquisition
        {
            get { return new IntegerString {Tag = new Tag("00201002")}; }
        }

        public static IntegerString ImagesInSeriesRetired
        {
            get { return new IntegerString {Tag = new Tag("00201003")}; }
        }

        public static IntegerString AcquisitionsInStudyRetired
        {
            get { return new IntegerString {Tag = new Tag("00201004")}; }
        }

        public static IntegerString ImagesInStudyRetired
        {
            get { return new IntegerString {Tag = new Tag("00201005")}; }
        }

        public static LongString ReferenceRetired
        {
            get { return new LongString {Tag = new Tag("00201020")}; }
        }

        public static LongString PositionReferenceIndicator
        {
            get { return new LongString {Tag = new Tag("00201040")}; }
        }

        public static DecimalString SliceLocation
        {
            get { return new DecimalString {Tag = new Tag("00201041")}; }
        }

        public static IntegerString OtherStudyNumbersRetired
        {
            get { return new IntegerString {Tag = new Tag("00201070")}; }
        }

        public static IntegerString NumberOfPatientRelatedStudies
        {
            get { return new IntegerString {Tag = new Tag("00201200")}; }
        }

        public static IntegerString NumberOfPatientRelatedSeries
        {
            get { return new IntegerString {Tag = new Tag("00201202")}; }
        }

        public static IntegerString NumberOfPatientRelatedInstances
        {
            get { return new IntegerString {Tag = new Tag("00201204")}; }
        }

        public static IntegerString NumberOfStudyRelatedSeries
        {
            get { return new IntegerString {Tag = new Tag("00201206")}; }
        }

        public static IntegerString NumberOfStudyRelatedInstances
        {
            get { return new IntegerString {Tag = new Tag("00201208")}; }
        }

        public static IntegerString NumberOfSeriesRelatedInstances
        {
            get { return new IntegerString {Tag = new Tag("00201209")}; }
        }

        public static CodeString SourceImageIDsRetired
        {
            get { return new CodeString {Tag = new Tag("002031xx")}; }
        }

        public static CodeString ModifyingDeviceIDRetired
        {
            get { return new CodeString {Tag = new Tag("00203401")}; }
        }

        public static CodeString ModifiedImageIDRetired
        {
            get { return new CodeString {Tag = new Tag("00203402")}; }
        }

        public static Date ModifiedImageDateRetired
        {
            get { return new Date {Tag = new Tag("00203403")}; }
        }

        public static LongString ModifyingDeviceManufacturerRetired
        {
            get { return new LongString {Tag = new Tag("00203404")}; }
        }

        public static Time ModifiedImageTimeRetired
        {
            get { return new Time {Tag = new Tag("00203405")}; }
        }

        public static LongString ModifiedImageDescriptionRetired
        {
            get { return new LongString {Tag = new Tag("00203406")}; }
        }

        public static LongText ImageComments
        {
            get { return new LongText {Tag = new Tag("00204000")}; }
        }

        public static AttributeTag OriginalImageIdentificationRetired
        {
            get { return new AttributeTag {Tag = new Tag("00205000")}; }
        }

        public static LongString OriginalImageIdentificationNomenclatureRetired
        {
            get { return new LongString {Tag = new Tag("00205002")}; }
        }

        public static ShortString StackID
        {
            get { return new ShortString {Tag = new Tag("00209056")}; }
        }

        public static UnsignedLong InStackPositionNumber
        {
            get { return new UnsignedLong {Tag = new Tag("00209057")}; }
        }

        public static Sequence FrameAnatomySequence
        {
            get { return new Sequence {Tag = new Tag("00209071")}; }
        }

        public static CodeString FrameLaterality
        {
            get { return new CodeString {Tag = new Tag("00209072")}; }
        }

        public static Sequence FrameContentSequence
        {
            get { return new Sequence {Tag = new Tag("00209111")}; }
        }

        public static Sequence PlanePositionSequence
        {
            get { return new Sequence {Tag = new Tag("00209113")}; }
        }

        public static Sequence PlaneOrientationSequence
        {
            get { return new Sequence {Tag = new Tag("00209116")}; }
        }

        public static UnsignedLong TemporalPositionIndex
        {
            get { return new UnsignedLong {Tag = new Tag("00209128")}; }
        }

        public static FloatingPointDouble NominalCardiacTriggerDelayTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209153")}; }
        }

        public static FloatingPointSingle NominalCardiacTriggerTimePriorToRPeak
        {
            get { return new FloatingPointSingle {Tag = new Tag("00209154")}; }
        }

        public static FloatingPointSingle ActualCardiacTriggerTimePriorToRPeak
        {
            get { return new FloatingPointSingle {Tag = new Tag("00209155")}; }
        }

        public static UnsignedShort FrameAcquisitionNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00209156")}; }
        }

        public static UnsignedLong DimensionIndexValues
        {
            get { return new UnsignedLong {Tag = new Tag("00209157")}; }
        }

        public static LongText FrameComments
        {
            get { return new LongText {Tag = new Tag("00209158")}; }
        }

        public static UniqueIdentifier ConcatenationUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00209161")}; }
        }

        public static UnsignedShort InConcatenationNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00209162")}; }
        }

        public static UnsignedShort InConcatenationTotalNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00209163")}; }
        }

        public static UniqueIdentifier DimensionOrganizationUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00209164")}; }
        }

        public static AttributeTag DimensionIndexPointer
        {
            get { return new AttributeTag {Tag = new Tag("00209165")}; }
        }

        public static AttributeTag FunctionalGroupPointer
        {
            get { return new AttributeTag {Tag = new Tag("00209167")}; }
        }

        public static LongString DimensionIndexPrivateCreator
        {
            get { return new LongString {Tag = new Tag("00209213")}; }
        }

        public static Sequence DimensionOrganizationSequence
        {
            get { return new Sequence {Tag = new Tag("00209221")}; }
        }

        public static Sequence DimensionIndexSequence
        {
            get { return new Sequence {Tag = new Tag("00209222")}; }
        }

        public static UnsignedLong ConcatenationFrameOffsetNumber
        {
            get { return new UnsignedLong {Tag = new Tag("00209228")}; }
        }

        public static LongString FunctionalGroupPrivateCreator
        {
            get { return new LongString {Tag = new Tag("00209238")}; }
        }

        public static FloatingPointSingle NominalPercentageOfCardiacPhase
        {
            get { return new FloatingPointSingle {Tag = new Tag("00209241")}; }
        }

        public static FloatingPointSingle NominalPercentageOfRespiratoryPhase
        {
            get { return new FloatingPointSingle {Tag = new Tag("00209245")}; }
        }

        public static FloatingPointSingle StartingRespiratoryAmplitude
        {
            get { return new FloatingPointSingle {Tag = new Tag("00209246")}; }
        }

        public static CodeString StartingRespiratoryPhase
        {
            get { return new CodeString {Tag = new Tag("00209247")}; }
        }

        public static FloatingPointSingle EndingRespiratoryAmplitude
        {
            get { return new FloatingPointSingle {Tag = new Tag("00209248")}; }
        }

        public static CodeString EndingRespiratoryPhase
        {
            get { return new CodeString {Tag = new Tag("00209249")}; }
        }

        public static CodeString RespiratoryTriggerType
        {
            get { return new CodeString {Tag = new Tag("00209250")}; }
        }

        public static FloatingPointDouble RRIntervalTimeNominal
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209251")}; }
        }

        public static FloatingPointDouble ActualCardiacTriggerDelayTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209252")}; }
        }

        public static Sequence RespiratorySynchronizationSequence
        {
            get { return new Sequence {Tag = new Tag("00209253")}; }
        }

        public static FloatingPointDouble RespiratoryIntervalTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209254")}; }
        }

        public static FloatingPointDouble NominalRespiratoryTriggerDelayTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209255")}; }
        }

        public static FloatingPointDouble RespiratoryTriggerDelayThreshold
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209256")}; }
        }

        public static FloatingPointDouble ActualRespiratoryTriggerDelayTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209257")}; }
        }

        public static FloatingPointDouble ImagePositionVolume
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209301")}; }
        }

        public static FloatingPointDouble ImageOrientationVolume
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209302")}; }
        }

        public static CodeString UltrasoundAcquisitionGeometry
        {
            get { return new CodeString {Tag = new Tag("00209307")}; }
        }

        public static FloatingPointDouble ApexPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209308")}; }
        }

        public static FloatingPointDouble VolumeToTransducerMappingMatrix
        {
            get { return new FloatingPointDouble {Tag = new Tag("00209309")}; }
        }

        public static FloatingPointDouble VolumeToTableMappingMatrix
        {
            get { return new FloatingPointDouble {Tag = new Tag("0020930A")}; }
        }

        public static CodeString PatientFrameOfReferenceSource
        {
            get { return new CodeString {Tag = new Tag("0020930C")}; }
        }

        public static FloatingPointDouble TemporalPositionTimeOffset
        {
            get { return new FloatingPointDouble {Tag = new Tag("0020930D")}; }
        }

        public static Sequence PlanePositionVolumeSequence
        {
            get { return new Sequence {Tag = new Tag("0020930E")}; }
        }

        public static Sequence PlaneOrientationVolumeSequence
        {
            get { return new Sequence {Tag = new Tag("0020930F")}; }
        }

        public static Sequence TemporalPositionSequence
        {
            get { return new Sequence {Tag = new Tag("00209310")}; }
        }

        public static CodeString DimensionOrganizationType
        {
            get { return new CodeString {Tag = new Tag("00209311")}; }
        }

        public static UniqueIdentifier VolumeFrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00209312")}; }
        }

        public static UniqueIdentifier TableFrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00209313")}; }
        }

        public static LongString DimensionDescriptionLabel
        {
            get { return new LongString {Tag = new Tag("00209421")}; }
        }

        public static Sequence PatientOrientationInFrameSequence
        {
            get { return new Sequence {Tag = new Tag("00209450")}; }
        }

        public static LongString FrameLabel
        {
            get { return new LongString {Tag = new Tag("00209453")}; }
        }

        public static UnsignedShort AcquisitionIndex
        {
            get { return new UnsignedShort {Tag = new Tag("00209518")}; }
        }

        public static Sequence ContributingSOPInstancesReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("00209529")}; }
        }

        public static UnsignedShort ReconstructionIndex
        {
            get { return new UnsignedShort {Tag = new Tag("00209536")}; }
        }

        public static UnsignedShort LightPathFilterPassThroughWavelength
        {
            get { return new UnsignedShort {Tag = new Tag("00220001")}; }
        }

        public static UnsignedShort LightPathFilterPassBand
        {
            get { return new UnsignedShort {Tag = new Tag("00220002")}; }
        }

        public static UnsignedShort ImagePathFilterPassThroughWavelength
        {
            get { return new UnsignedShort {Tag = new Tag("00220003")}; }
        }

        public static UnsignedShort ImagePathFilterPassBand
        {
            get { return new UnsignedShort {Tag = new Tag("00220004")}; }
        }

        public static CodeString PatientEyeMovementCommanded
        {
            get { return new CodeString {Tag = new Tag("00220005")}; }
        }

        public static Sequence PatientEyeMovementCommandCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00220006")}; }
        }

        public static FloatingPointSingle SphericalLensPower
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220007")}; }
        }

        public static FloatingPointSingle CylinderLensPower
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220008")}; }
        }

        public static FloatingPointSingle CylinderAxis
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220009")}; }
        }

        public static FloatingPointSingle EmmetropicMagnification
        {
            get { return new FloatingPointSingle {Tag = new Tag("0022000A")}; }
        }

        public static FloatingPointSingle IntraOcularPressure
        {
            get { return new FloatingPointSingle {Tag = new Tag("0022000B")}; }
        }

        public static FloatingPointSingle HorizontalFieldOfView
        {
            get { return new FloatingPointSingle {Tag = new Tag("0022000C")}; }
        }

        public static CodeString PupilDilated
        {
            get { return new CodeString {Tag = new Tag("0022000D")}; }
        }

        public static FloatingPointSingle DegreeOfDilation
        {
            get { return new FloatingPointSingle {Tag = new Tag("0022000E")}; }
        }

        public static FloatingPointSingle StereoBaselineAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220010")}; }
        }

        public static FloatingPointSingle StereoBaselineDisplacement
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220011")}; }
        }

        public static FloatingPointSingle StereoHorizontalPixelOffset
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220012")}; }
        }

        public static FloatingPointSingle StereoVerticalPixelOffset
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220013")}; }
        }

        public static FloatingPointSingle StereoRotation
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220014")}; }
        }

        public static Sequence AcquisitionDeviceTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00220015")}; }
        }

        public static Sequence IlluminationTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00220016")}; }
        }

        public static Sequence LightPathFilterTypeStackCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00220017")}; }
        }

        public static Sequence ImagePathFilterTypeStackCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00220018")}; }
        }

        public static Sequence LensesCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00220019")}; }
        }

        public static Sequence ChannelDescriptionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0022001A")}; }
        }

        public static Sequence RefractiveStateSequence
        {
            get { return new Sequence {Tag = new Tag("0022001B")}; }
        }

        public static Sequence MydriaticAgentCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0022001C")}; }
        }

        public static Sequence RelativeImagePositionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0022001D")}; }
        }

        public static FloatingPointSingle CameraAngleOfView
        {
            get { return new FloatingPointSingle {Tag = new Tag("0022001E")}; }
        }

        public static Sequence StereoPairsSequence
        {
            get { return new Sequence {Tag = new Tag("00220020")}; }
        }

        public static Sequence LeftImageSequence
        {
            get { return new Sequence {Tag = new Tag("00220021")}; }
        }

        public static Sequence RightImageSequence
        {
            get { return new Sequence {Tag = new Tag("00220022")}; }
        }

        public static FloatingPointSingle AxialLengthOfTheEye
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220030")}; }
        }

        public static Sequence OphthalmicFrameLocationSequence
        {
            get { return new Sequence {Tag = new Tag("00220031")}; }
        }

        public static FloatingPointSingle ReferenceCoordinates
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220032")}; }
        }

        public static FloatingPointSingle DepthSpatialResolution
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220035")}; }
        }

        public static FloatingPointSingle MaximumDepthDistortion
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220036")}; }
        }

        public static FloatingPointSingle AlongScanSpatialResolution
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220037")}; }
        }

        public static FloatingPointSingle MaximumAlongScanDistortion
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220038")}; }
        }

        public static CodeString OphthalmicImageOrientation
        {
            get { return new CodeString {Tag = new Tag("00220039")}; }
        }

        public static FloatingPointSingle DepthOfTransverseImage
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220041")}; }
        }

        public static Sequence MydriaticAgentConcentrationUnitsSequence
        {
            get { return new Sequence {Tag = new Tag("00220042")}; }
        }

        public static FloatingPointSingle AcrossScanSpatialResolution
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220048")}; }
        }

        public static FloatingPointSingle MaximumAcrossScanDistortion
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220049")}; }
        }

        public static DecimalString MydriaticAgentConcentration
        {
            get { return new DecimalString {Tag = new Tag("0022004E")}; }
        }

        public static FloatingPointSingle IlluminationWaveLength
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220055")}; }
        }

        public static FloatingPointSingle IlluminationPower
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220056")}; }
        }

        public static FloatingPointSingle IlluminationBandwidth
        {
            get { return new FloatingPointSingle {Tag = new Tag("00220057")}; }
        }

        public static Sequence MydriaticAgentSequence
        {
            get { return new Sequence {Tag = new Tag("00220058")}; }
        }

        public static Sequence OphthalmicAxialMeasurementsRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00221007")}; }
        }

        public static Sequence OphthalmicAxialMeasurementsLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00221008")}; }
        }

        public static CodeString OphthalmicAxialLengthMeasurementsType
        {
            get { return new CodeString {Tag = new Tag("00221010")}; }
        }

        public static FloatingPointSingle OphthalmicAxialLength
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221019")}; }
        }

        public static Sequence LensStatusCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221024")}; }
        }

        public static Sequence VitreousStatusCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221025")}; }
        }

        public static Sequence IOLFormulaCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221028")}; }
        }

        public static LongString IOLFormulaDetail
        {
            get { return new LongString {Tag = new Tag("00221029")}; }
        }

        public static FloatingPointSingle KeratometerIndex
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221033")}; }
        }

        public static Sequence SourceOfOphthalmicAxialLengthCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221035")}; }
        }

        public static FloatingPointSingle TargetRefraction
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221037")}; }
        }

        public static CodeString RefractiveProcedureOccurred
        {
            get { return new CodeString {Tag = new Tag("00221039")}; }
        }

        public static Sequence RefractiveSurgeryTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221040")}; }
        }

        public static Sequence OphthalmicUltrasoundAxialMeasurementsTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221044")}; }
        }

        public static Sequence OphthalmicAxialLengthMeasurementsSequence
        {
            get { return new Sequence {Tag = new Tag("00221050")}; }
        }

        public static FloatingPointSingle IOLPower
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221053")}; }
        }

        public static FloatingPointSingle PredictedRefractiveError
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221054")}; }
        }

        public static FloatingPointSingle OphthalmicAxialLengthVelocity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221059")}; }
        }

        public static LongString LensStatusDescription
        {
            get { return new LongString {Tag = new Tag("00221065")}; }
        }

        public static LongString VitreousStatusDescription
        {
            get { return new LongString {Tag = new Tag("00221066")}; }
        }

        public static Sequence IOLPowerSequence
        {
            get { return new Sequence {Tag = new Tag("00221090")}; }
        }

        public static Sequence LensConstantSequence
        {
            get { return new Sequence {Tag = new Tag("00221092")}; }
        }

        public static LongString IOLManufacturer
        {
            get { return new LongString {Tag = new Tag("00221093")}; }
        }

        public static LongString LensConstantDescription
        {
            get { return new LongString {Tag = new Tag("00221094")}; }
        }

        public static Sequence KeratometryMeasurementTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221096")}; }
        }

        public static Sequence ReferencedOphthalmicAxialMeasurementsSequence
        {
            get { return new Sequence {Tag = new Tag("00221100")}; }
        }

        public static Sequence OphthalmicAxialLengthMeasurementsSegmentNameCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221101")}; }
        }

        public static Sequence RefractiveErrorBeforeRefractiveSurgeryCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221103")}; }
        }

        public static FloatingPointSingle IOLPowerForExactEmmetropia
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221121")}; }
        }

        public static FloatingPointSingle IOLPowerForExactTargetRefraction
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221122")}; }
        }

        public static Sequence AnteriorChamberDepthDefinitionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221125")}; }
        }

        public static FloatingPointSingle LensThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221130")}; }
        }

        public static FloatingPointSingle AnteriorChamberDepth
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221131")}; }
        }

        public static Sequence SourceOfLensThicknessDataCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221132")}; }
        }

        public static Sequence SourceOfAnteriorChamberDepthDataCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221133")}; }
        }

        public static Sequence SourceOfRefractiveErrorDataCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221135")}; }
        }

        public static CodeString OphthalmicAxialLengthMeasurementModified
        {
            get { return new CodeString {Tag = new Tag("00221140")}; }
        }

        public static Sequence OphthalmicAxialLengthDataSourceCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221150")}; }
        }

        public static Sequence OphthalmicAxialLengthAcquisitionMethodCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221153")}; }
        }

        public static FloatingPointSingle SignalToNoiseRatio
        {
            get { return new FloatingPointSingle {Tag = new Tag("00221155")}; }
        }

        public static LongString OphthalmicAxialLengthDataSourceDescription
        {
            get { return new LongString {Tag = new Tag("00221159")}; }
        }

        public static Sequence OphthalmicAxialLengthMeasurementsTotalLengthSequence
        {
            get { return new Sequence {Tag = new Tag("00221210")}; }
        }

        public static Sequence OphthalmicAxialLengthMeasurementsSegmentalLengthSequence
        {
            get { return new Sequence {Tag = new Tag("00221211")}; }
        }

        public static Sequence OphthalmicAxialLengthMeasurementsLengthSummationSequence
        {
            get { return new Sequence {Tag = new Tag("00221212")}; }
        }

        public static Sequence UltrasoundOphthalmicAxialLengthMeasurementsSequence
        {
            get { return new Sequence {Tag = new Tag("00221220")}; }
        }

        public static Sequence OpticalOphthalmicAxialLengthMeasurementsSequence
        {
            get { return new Sequence {Tag = new Tag("00221225")}; }
        }

        public static Sequence UltrasoundSelectedOphthalmicAxialLengthSequence
        {
            get { return new Sequence {Tag = new Tag("00221230")}; }
        }

        public static Sequence OphthalmicAxialLengthSelectionMethodCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00221250")}; }
        }

        public static Sequence OpticalSelectedOphthalmicAxialLengthSequence
        {
            get { return new Sequence {Tag = new Tag("00221255")}; }
        }

        public static Sequence SelectedSegmentalOphthalmicAxialLengthSequence
        {
            get { return new Sequence {Tag = new Tag("00221257")}; }
        }

        public static Sequence SelectedTotalOphthalmicAxialLengthSequence
        {
            get { return new Sequence {Tag = new Tag("00221260")}; }
        }

        public static Sequence OphthalmicAxialLengthQualityMetricSequence
        {
            get { return new Sequence {Tag = new Tag("00221262")}; }
        }

        public static LongString OphthalmicAxialLengthQualityMetricTypeDescription
        {
            get { return new LongString {Tag = new Tag("00221273")}; }
        }

        public static Sequence IntraocularLensCalculationsRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00221300")}; }
        }

        public static Sequence IntraocularLensCalculationsLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00221310")}; }
        }

        public static Sequence ReferencedOphthalmicAxialLengthMeasurementQCImageSequence
        {
            get { return new Sequence {Tag = new Tag("00221330")}; }
        }

        public static FloatingPointSingle VisualFieldHorizontalExtent
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240010")}; }
        }

        public static FloatingPointSingle VisualFieldVerticalExtent
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240011")}; }
        }

        public static CodeString VisualFieldShape
        {
            get { return new CodeString {Tag = new Tag("00240012")}; }
        }

        public static Sequence ScreeningTestModeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00240016")}; }
        }

        public static FloatingPointSingle MaximumStimulusLuminance
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240018")}; }
        }

        public static FloatingPointSingle BackgroundLuminance
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240020")}; }
        }

        public static Sequence StimulusColorCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00240021")}; }
        }

        public static Sequence BackgroundIlluminationColorCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00240024")}; }
        }

        public static FloatingPointSingle StimulusArea
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240025")}; }
        }

        public static FloatingPointSingle StimulusPresentationTime
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240028")}; }
        }

        public static Sequence FixationSequence
        {
            get { return new Sequence {Tag = new Tag("00240032")}; }
        }

        public static Sequence FixationMonitoringCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00240033")}; }
        }

        public static Sequence VisualFieldCatchTrialSequence
        {
            get { return new Sequence {Tag = new Tag("00240034")}; }
        }

        public static UnsignedShort FixationCheckedQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240035")}; }
        }

        public static UnsignedShort PatientNotProperlyFixatedQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240036")}; }
        }

        public static CodeString PresentedVisualStimuliDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240037")}; }
        }

        public static UnsignedShort NumberOfVisualStimuli
        {
            get { return new UnsignedShort {Tag = new Tag("00240038")}; }
        }

        public static CodeString ExcessiveFixationLossesDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240039")}; }
        }

        public static CodeString ExcessiveFixationLosses
        {
            get { return new CodeString {Tag = new Tag("00240040")}; }
        }

        public static UnsignedShort StimuliRetestingQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240042")}; }
        }

        public static LongText CommentsOnPatientPerformanceOfVisualField
        {
            get { return new LongText {Tag = new Tag("00240044")}; }
        }

        public static CodeString FalseNegativesEstimateFlag
        {
            get { return new CodeString {Tag = new Tag("00240045")}; }
        }

        public static FloatingPointSingle FalseNegativesEstimate
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240046")}; }
        }

        public static UnsignedShort NegativeCatchTrialsQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240048")}; }
        }

        public static UnsignedShort FalseNegativesQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240050")}; }
        }

        public static CodeString ExcessiveFalseNegativesDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240051")}; }
        }

        public static CodeString ExcessiveFalseNegatives
        {
            get { return new CodeString {Tag = new Tag("00240052")}; }
        }

        public static CodeString FalsePositivesEstimateFlag
        {
            get { return new CodeString {Tag = new Tag("00240053")}; }
        }

        public static FloatingPointSingle FalsePositivesEstimate
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240054")}; }
        }

        public static CodeString CatchTrialsDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240055")}; }
        }

        public static UnsignedShort PositiveCatchTrialsQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240056")}; }
        }

        public static CodeString TestPointNormalsDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240057")}; }
        }

        public static Sequence TestPointNormalsSequence
        {
            get { return new Sequence {Tag = new Tag("00240058")}; }
        }

        public static CodeString GlobalDeviationProbabilityNormalsFlag
        {
            get { return new CodeString {Tag = new Tag("00240059")}; }
        }

        public static UnsignedShort FalsePositivesQuantity
        {
            get { return new UnsignedShort {Tag = new Tag("00240060")}; }
        }

        public static CodeString ExcessiveFalsePositivesDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240061")}; }
        }

        public static CodeString ExcessiveFalsePositives
        {
            get { return new CodeString {Tag = new Tag("00240062")}; }
        }

        public static CodeString VisualFieldTestNormalsFlag
        {
            get { return new CodeString {Tag = new Tag("00240063")}; }
        }

        public static Sequence ResultsNormalsSequence
        {
            get { return new Sequence {Tag = new Tag("00240064")}; }
        }

        public static Sequence AgeCorrectedSensitivityDeviationAlgorithmSequence
        {
            get { return new Sequence {Tag = new Tag("00240065")}; }
        }

        public static FloatingPointSingle GlobalDeviationFromNormal
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240066")}; }
        }

        public static Sequence GeneralizedDefectSensitivityDeviationAlgorithmSequence
        {
            get { return new Sequence {Tag = new Tag("00240067")}; }
        }

        public static FloatingPointSingle LocalizedDeviationfromNormal
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240068")}; }
        }

        public static LongString PatientReliabilityIndicator
        {
            get { return new LongString {Tag = new Tag("00240069")}; }
        }

        public static FloatingPointSingle VisualFieldMeanSensitivity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240070")}; }
        }

        public static FloatingPointSingle GlobalDeviationProbability
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240071")}; }
        }

        public static CodeString LocalDeviationProbabilityNormalsFlag
        {
            get { return new CodeString {Tag = new Tag("00240072")}; }
        }

        public static FloatingPointSingle LocalizedDeviationProbability
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240073")}; }
        }

        public static CodeString ShortTermFluctuationCalculated
        {
            get { return new CodeString {Tag = new Tag("00240074")}; }
        }

        public static FloatingPointSingle ShortTermFluctuation
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240075")}; }
        }

        public static CodeString ShortTermFluctuationProbabilityCalculated
        {
            get { return new CodeString {Tag = new Tag("00240076")}; }
        }

        public static FloatingPointSingle ShortTermFluctuationProbability
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240077")}; }
        }

        public static CodeString CorrectedLocalizedDeviationFromNormalCalculated
        {
            get { return new CodeString {Tag = new Tag("00240078")}; }
        }

        public static FloatingPointSingle CorrectedLocalizedDeviationFromNormal
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240079")}; }
        }

        public static CodeString CorrectedLocalizedDeviationFromNormalProbabilityCalculated
        {
            get { return new CodeString {Tag = new Tag("00240080")}; }
        }

        public static FloatingPointSingle CorrectedLocalizedDeviationFromNormalProbability
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240081")}; }
        }

        public static Sequence GlobalDeviationProbabilitySequence
        {
            get { return new Sequence {Tag = new Tag("00240083")}; }
        }

        public static Sequence LocalizedDeviationProbabilitySequence
        {
            get { return new Sequence {Tag = new Tag("00240085")}; }
        }

        public static CodeString FovealSensitivityMeasured
        {
            get { return new CodeString {Tag = new Tag("00240086")}; }
        }

        public static FloatingPointSingle FovealSensitivity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240087")}; }
        }

        public static FloatingPointSingle VisualFieldTestDuration
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240088")}; }
        }

        public static Sequence VisualFieldTestPointSequence
        {
            get { return new Sequence {Tag = new Tag("00240089")}; }
        }

        public static FloatingPointSingle VisualFieldTestPointXCoordinate
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240090")}; }
        }

        public static FloatingPointSingle VisualFieldTestPointYCoordinate
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240091")}; }
        }

        public static FloatingPointSingle AgeCorrectedSensitivityDeviationValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240092")}; }
        }

        public static CodeString StimulusResults
        {
            get { return new CodeString {Tag = new Tag("00240093")}; }
        }

        public static FloatingPointSingle SensitivityValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240094")}; }
        }

        public static CodeString RetestStimulusSeen
        {
            get { return new CodeString {Tag = new Tag("00240095")}; }
        }

        public static FloatingPointSingle RetestSensitivityValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240096")}; }
        }

        public static Sequence VisualFieldTestPointNormalsSequence
        {
            get { return new Sequence {Tag = new Tag("00240097")}; }
        }

        public static FloatingPointSingle QuantifiedDefect
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240098")}; }
        }

        public static FloatingPointSingle AgeCorrectedSensitivityDeviationProbabilityValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240100")}; }
        }

        public static CodeString GeneralizedDefectCorrectedSensitivityDeviationFlag
        {
            get { return new CodeString {Tag = new Tag("00240102")}; }
        }

        public static FloatingPointSingle GeneralizedDefectCorrectedSensitivityDeviationValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240103")}; }
        }

        public static FloatingPointSingle GeneralizedDefectCorrectedSensitivityDeviationProbabilityValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240104")}; }
        }

        public static FloatingPointSingle MinimumSensitivityValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240105")}; }
        }

        public static CodeString BlindSpotLocalized
        {
            get { return new CodeString {Tag = new Tag("00240106")}; }
        }

        public static FloatingPointSingle BlindSpotXCoordinate
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240107")}; }
        }

        public static FloatingPointSingle BlindSpotYCoordinate
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240108")}; }
        }

        public static Sequence VisualAcuityMeasurementSequence
        {
            get { return new Sequence {Tag = new Tag("00240110")}; }
        }

        public static Sequence RefractiveParametersUsedOnPatientSequence
        {
            get { return new Sequence {Tag = new Tag("00240112")}; }
        }

        public static CodeString MeasurementLaterality
        {
            get { return new CodeString {Tag = new Tag("00240113")}; }
        }

        public static Sequence OphthalmicPatientClinicalInformationLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00240114")}; }
        }

        public static Sequence OphthalmicPatientClinicalInformationRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00240115")}; }
        }

        public static CodeString FovealPointNormativeDataFlag
        {
            get { return new CodeString {Tag = new Tag("00240117")}; }
        }

        public static FloatingPointSingle FovealPointProbabilityValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240118")}; }
        }

        public static CodeString ScreeningBaselineMeasured
        {
            get { return new CodeString {Tag = new Tag("00240120")}; }
        }

        public static Sequence ScreeningBaselineMeasuredSequence
        {
            get { return new Sequence {Tag = new Tag("00240122")}; }
        }

        public static CodeString ScreeningBaselineType
        {
            get { return new CodeString {Tag = new Tag("00240124")}; }
        }

        public static FloatingPointSingle ScreeningBaselineValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240126")}; }
        }

        public static LongString AlgorithmSource
        {
            get { return new LongString {Tag = new Tag("00240202")}; }
        }

        public static LongString DataSetName
        {
            get { return new LongString {Tag = new Tag("00240306")}; }
        }

        public static LongString DataSetVersion
        {
            get { return new LongString {Tag = new Tag("00240307")}; }
        }

        public static LongString DataSetSource
        {
            get { return new LongString {Tag = new Tag("00240308")}; }
        }

        public static LongString DataSetDescription
        {
            get { return new LongString {Tag = new Tag("00240309")}; }
        }

        public static Sequence VisualFieldTestReliabilityGlobalIndexSequence
        {
            get { return new Sequence {Tag = new Tag("00240317")}; }
        }

        public static Sequence VisualFieldGlobalResultsIndexSequence
        {
            get { return new Sequence {Tag = new Tag("00240320")}; }
        }

        public static Sequence DataObservationSequence
        {
            get { return new Sequence {Tag = new Tag("00240325")}; }
        }

        public static CodeString IndexNormalsFlag
        {
            get { return new CodeString {Tag = new Tag("00240338")}; }
        }

        public static FloatingPointSingle IndexProbability
        {
            get { return new FloatingPointSingle {Tag = new Tag("00240341")}; }
        }

        public static Sequence IndexProbabilitySequence
        {
            get { return new Sequence {Tag = new Tag("00240344")}; }
        }

        public static UnsignedShort SamplesPerPixel
        {
            get { return new UnsignedShort {Tag = new Tag("00280002")}; }
        }

        public static UnsignedShort SamplesPerPixelUsed
        {
            get { return new UnsignedShort {Tag = new Tag("00280003")}; }
        }

        public static CodeString PhotometricInterpretation
        {
            get { return new CodeString {Tag = new Tag("00280004")}; }
        }

        public static UnsignedShort ImageDimensionsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280005")}; }
        }

        public static UnsignedShort PlanarConfiguration
        {
            get { return new UnsignedShort {Tag = new Tag("00280006")}; }
        }

        public static IntegerString NumberOfFrames
        {
            get { return new IntegerString {Tag = new Tag("00280008")}; }
        }

        public static AttributeTag FrameIncrementPointer
        {
            get { return new AttributeTag {Tag = new Tag("00280009")}; }
        }

        public static AttributeTag FrameDimensionPointer
        {
            get { return new AttributeTag {Tag = new Tag("0028000A")}; }
        }

        public static UnsignedShort Rows
        {
            get { return new UnsignedShort {Tag = new Tag("00280010")}; }
        }

        public static UnsignedShort Columns
        {
            get { return new UnsignedShort {Tag = new Tag("00280011")}; }
        }

        public static UnsignedShort PlanesRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280012")}; }
        }

        public static UnsignedShort UltrasoundColorDataPresent
        {
            get { return new UnsignedShort {Tag = new Tag("00280014")}; }
        }

        public static DecimalString PixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("00280030")}; }
        }

        public static DecimalString ZoomFactor
        {
            get { return new DecimalString {Tag = new Tag("00280031")}; }
        }

        public static DecimalString ZoomCenter
        {
            get { return new DecimalString {Tag = new Tag("00280032")}; }
        }

        public static IntegerString PixelAspectRatio
        {
            get { return new IntegerString {Tag = new Tag("00280034")}; }
        }

        public static CodeString ImageFormatRetired
        {
            get { return new CodeString {Tag = new Tag("00280040")}; }
        }

        public static LongString ManipulatedImageRetired
        {
            get { return new LongString {Tag = new Tag("00280050")}; }
        }

        public static CodeString CorrectedImage
        {
            get { return new CodeString {Tag = new Tag("00280051")}; }
        }

        public static LongString CompressionRecognitionCodeRetired
        {
            get { return new LongString {Tag = new Tag("0028005F")}; }
        }

        public static CodeString CompressionCodeRetired
        {
            get { return new CodeString {Tag = new Tag("00280060")}; }
        }

        public static ShortString CompressionOriginatorRetired
        {
            get { return new ShortString {Tag = new Tag("00280061")}; }
        }

        public static LongString CompressionLabelRetired
        {
            get { return new LongString {Tag = new Tag("00280062")}; }
        }

        public static ShortString CompressionDescriptionRetired
        {
            get { return new ShortString {Tag = new Tag("00280063")}; }
        }

        public static CodeString CompressionSequenceRetired
        {
            get { return new CodeString {Tag = new Tag("00280065")}; }
        }

        public static AttributeTag CompressionStepPointersRetired
        {
            get { return new AttributeTag {Tag = new Tag("00280066")}; }
        }

        public static UnsignedShort RepeatIntervalRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280068")}; }
        }

        public static UnsignedShort BitsGroupedRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280069")}; }
        }

        public static UnsignedShort PerimeterTableRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280070")}; }
        }

        public static UnsignedShort PerimeterValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280071")}; }
        }

        public static UnsignedShort PredictorRowsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280080")}; }
        }

        public static UnsignedShort PredictorColumnsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280081")}; }
        }

        public static UnsignedShort PredictorConstantsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280082")}; }
        }

        public static CodeString BlockedPixelsRetired
        {
            get { return new CodeString {Tag = new Tag("00280090")}; }
        }

        public static UnsignedShort BlockRowsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280091")}; }
        }

        public static UnsignedShort BlockColumnsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280092")}; }
        }

        public static UnsignedShort RowOverlapRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280093")}; }
        }

        public static UnsignedShort ColumnOverlapRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280094")}; }
        }

        public static UnsignedShort BitsAllocated
        {
            get { return new UnsignedShort {Tag = new Tag("00280100")}; }
        }

        public static UnsignedShort BitsStored
        {
            get { return new UnsignedShort {Tag = new Tag("00280101")}; }
        }

        public static UnsignedShort HighBit
        {
            get { return new UnsignedShort {Tag = new Tag("00280102")}; }
        }

        public static UnsignedShort PixelRepresentation
        {
            get { return new UnsignedShort {Tag = new Tag("00280103")}; }
        }

        public static UnsignedShort SmallestValidPixelValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280104")}; }
        }

        public static UnsignedShort LargestValidPixelValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280105")}; }
        }

        public static UnsignedShort SmallestImagePixelValue
        {
            get { return new UnsignedShort {Tag = new Tag("00280106")}; }
        }

        public static UnsignedShort LargestImagePixelValue
        {
            get { return new UnsignedShort {Tag = new Tag("00280107")}; }
        }

        public static UnsignedShort SmallestPixelValueInSeries
        {
            get { return new UnsignedShort {Tag = new Tag("00280108")}; }
        }

        public static UnsignedShort LargestPixelValueInSeries
        {
            get { return new UnsignedShort {Tag = new Tag("00280109")}; }
        }

        public static UnsignedShort SmallestImagePixelValueInPlaneRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280110")}; }
        }

        public static UnsignedShort LargestImagePixelValueInPlaneRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280111")}; }
        }

        public static UnsignedShort PixelPaddingValue
        {
            get { return new UnsignedShort {Tag = new Tag("00280120")}; }
        }

        public static UnsignedShort PixelPaddingRangeLimit
        {
            get { return new UnsignedShort {Tag = new Tag("00280121")}; }
        }

        public static UnsignedShort ImageLocationRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280200")}; }
        }

        public static CodeString QualityControlImage
        {
            get { return new CodeString {Tag = new Tag("00280300")}; }
        }

        public static CodeString BurnedInAnnotation
        {
            get { return new CodeString {Tag = new Tag("00280301")}; }
        }

        public static CodeString RecognizableVisualFeatures
        {
            get { return new CodeString {Tag = new Tag("00280302")}; }
        }

        public static CodeString LongitudinalTemporalInformationModified
        {
            get { return new CodeString {Tag = new Tag("00280303")}; }
        }

        public static LongString TransformLabelRetired
        {
            get { return new LongString {Tag = new Tag("00280400")}; }
        }

        public static LongString TransformVersionNumberRetired
        {
            get { return new LongString {Tag = new Tag("00280401")}; }
        }

        public static UnsignedShort NumberOfTransformStepsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280402")}; }
        }

        public static LongString SequenceOfCompressedDataRetired
        {
            get { return new LongString {Tag = new Tag("00280403")}; }
        }

        public static AttributeTag DetailsOfCoefficientsRetired
        {
            get { return new AttributeTag {Tag = new Tag("00280404")}; }
        }

        public static UnsignedShort RowsForNthOrderCoefficientsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("002804x0")}; }
        }

        public static UnsignedShort ColumnsForNthOrderCoefficientsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("002804x1")}; }
        }

        public static LongString CoefficientCodingRetired
        {
            get { return new LongString {Tag = new Tag("002804x2")}; }
        }

        public static AttributeTag CoefficientCodingPointersRetired
        {
            get { return new AttributeTag {Tag = new Tag("002804x3")}; }
        }

        public static LongString DCTLabelRetired
        {
            get { return new LongString {Tag = new Tag("00280700")}; }
        }

        public static CodeString DataBlockDescriptionRetired
        {
            get { return new CodeString {Tag = new Tag("00280701")}; }
        }

        public static AttributeTag DataBlockRetired
        {
            get { return new AttributeTag {Tag = new Tag("00280702")}; }
        }

        public static UnsignedShort NormalizationFactorFormatRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280710")}; }
        }

        public static UnsignedShort ZonalMapNumberFormatRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280720")}; }
        }

        public static AttributeTag ZonalMapLocationRetired
        {
            get { return new AttributeTag {Tag = new Tag("00280721")}; }
        }

        public static UnsignedShort ZonalMapFormatRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280722")}; }
        }

        public static UnsignedShort AdaptiveMapFormatRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280730")}; }
        }

        public static UnsignedShort CodeNumberFormatRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00280740")}; }
        }

        public static CodeString CodeLabelRetired
        {
            get { return new CodeString {Tag = new Tag("002808x0")}; }
        }

        public static UnsignedShort NumberOfTablesRetired
        {
            get { return new UnsignedShort {Tag = new Tag("002808x2")}; }
        }

        public static AttributeTag CodeTableLocationRetired
        {
            get { return new AttributeTag {Tag = new Tag("002808x3")}; }
        }

        public static UnsignedShort BitsForCodeWordRetired
        {
            get { return new UnsignedShort {Tag = new Tag("002808x4")}; }
        }

        public static AttributeTag ImageDataLocationRetired
        {
            get { return new AttributeTag {Tag = new Tag("002808x8")}; }
        }

        public static CodeString PixelSpacingCalibrationType
        {
            get { return new CodeString {Tag = new Tag("00280A02")}; }
        }

        public static LongString PixelSpacingCalibrationDescription
        {
            get { return new LongString {Tag = new Tag("00280A04")}; }
        }

        public static CodeString PixelIntensityRelationship
        {
            get { return new CodeString {Tag = new Tag("00281040")}; }
        }

        public static SignedShort PixelIntensityRelationshipSign
        {
            get { return new SignedShort {Tag = new Tag("00281041")}; }
        }

        public static DecimalString WindowCenter
        {
            get { return new DecimalString {Tag = new Tag("00281050")}; }
        }

        public static DecimalString WindowWidth
        {
            get { return new DecimalString {Tag = new Tag("00281051")}; }
        }

        public static DecimalString RescaleIntercept
        {
            get { return new DecimalString {Tag = new Tag("00281052")}; }
        }

        public static DecimalString RescaleSlope
        {
            get { return new DecimalString {Tag = new Tag("00281053")}; }
        }

        public static LongString RescaleType
        {
            get { return new LongString {Tag = new Tag("00281054")}; }
        }

        public static LongString WindowCenterWidthExplanation
        {
            get { return new LongString {Tag = new Tag("00281055")}; }
        }

        public static CodeString VOILUTFunction
        {
            get { return new CodeString {Tag = new Tag("00281056")}; }
        }

        public static CodeString GrayScaleRetired
        {
            get { return new CodeString {Tag = new Tag("00281080")}; }
        }

        public static CodeString RecommendedViewingMode
        {
            get { return new CodeString {Tag = new Tag("00281090")}; }
        }

        public static UnsignedShort GrayLookupTableDescriptorRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00281100")}; }
        }

        public static UnsignedShort RedPaletteColorLookupTableDescriptor
        {
            get { return new UnsignedShort {Tag = new Tag("00281101")}; }
        }

        public static UnsignedShort GreenPaletteColorLookupTableDescriptor
        {
            get { return new UnsignedShort {Tag = new Tag("00281102")}; }
        }

        public static UnsignedShort BluePaletteColorLookupTableDescriptor
        {
            get { return new UnsignedShort {Tag = new Tag("00281103")}; }
        }

        public static UnsignedShort AlphaPaletteColorLookupTableDescriptor
        {
            get { return new UnsignedShort {Tag = new Tag("00281104")}; }
        }

        public static UnsignedShort LargeRedPaletteColorLookupTableDescriptorRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00281111")}; }
        }

        public static UnsignedShort LargeGreenPaletteColorLookupTableDescriptorRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00281112")}; }
        }

        public static UnsignedShort LargeBluePaletteColorLookupTableDescriptorRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00281113")}; }
        }

        public static UniqueIdentifier PaletteColorLookupTableUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00281199")}; }
        }

        public static UnsignedShort GrayLookupTableDataRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00281200")}; }
        }

        public static OtherWordString RedPaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281201")}; }
        }

        public static OtherWordString GreenPaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281202")}; }
        }

        public static OtherWordString BluePaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281203")}; }
        }

        public static OtherWordString AlphaPaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281204")}; }
        }

        public static OtherWordString LargeRedPaletteColorLookupTableDataRetired
        {
            get { return new OtherWordString {Tag = new Tag("00281211")}; }
        }

        public static OtherWordString LargeGreenPaletteColorLookupTableDataRetired
        {
            get { return new OtherWordString {Tag = new Tag("00281212")}; }
        }

        public static OtherWordString LargeBluePaletteColorLookupTableDataRetired
        {
            get { return new OtherWordString {Tag = new Tag("00281213")}; }
        }

        public static UniqueIdentifier LargePaletteColorLookupTableUIDRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("00281214")}; }
        }

        public static OtherWordString SegmentedRedPaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281221")}; }
        }

        public static OtherWordString SegmentedGreenPaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281222")}; }
        }

        public static OtherWordString SegmentedBluePaletteColorLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281223")}; }
        }

        public static CodeString BreastImplantPresent
        {
            get { return new CodeString {Tag = new Tag("00281300")}; }
        }

        public static CodeString PartialView
        {
            get { return new CodeString {Tag = new Tag("00281350")}; }
        }

        public static ShortText PartialViewDescription
        {
            get { return new ShortText {Tag = new Tag("00281351")}; }
        }

        public static Sequence PartialViewCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00281352")}; }
        }

        public static CodeString SpatialLocationsPreserved
        {
            get { return new CodeString {Tag = new Tag("0028135A")}; }
        }

        public static Sequence DataFrameAssignmentSequence
        {
            get { return new Sequence {Tag = new Tag("00281401")}; }
        }

        public static CodeString DataPathAssignment
        {
            get { return new CodeString {Tag = new Tag("00281402")}; }
        }

        public static UnsignedShort BitsMappedToColorLookupTable
        {
            get { return new UnsignedShort {Tag = new Tag("00281403")}; }
        }

        public static Sequence BlendingLUT1Sequence
        {
            get { return new Sequence {Tag = new Tag("00281404")}; }
        }

        public static CodeString BlendingLUT1TransferFunction
        {
            get { return new CodeString {Tag = new Tag("00281405")}; }
        }

        public static FloatingPointDouble BlendingWeightConstant
        {
            get { return new FloatingPointDouble {Tag = new Tag("00281406")}; }
        }

        public static UnsignedShort BlendingLookupTableDescriptor
        {
            get { return new UnsignedShort {Tag = new Tag("00281407")}; }
        }

        public static OtherWordString BlendingLookupTableData
        {
            get { return new OtherWordString {Tag = new Tag("00281408")}; }
        }

        public static Sequence EnhancedPaletteColorLookupTableSequence
        {
            get { return new Sequence {Tag = new Tag("0028140B")}; }
        }

        public static Sequence BlendingLUT2Sequence
        {
            get { return new Sequence {Tag = new Tag("0028140C")}; }
        }

        public static CodeString BlendingLUT2TransferFunction
        {
            get { return new CodeString {Tag = new Tag("0028140D")}; }
        }

        public static CodeString DataPathID
        {
            get { return new CodeString {Tag = new Tag("0028140E")}; }
        }

        public static CodeString RGBLUTTransferFunction
        {
            get { return new CodeString {Tag = new Tag("0028140F")}; }
        }

        public static CodeString AlphaLUTTransferFunction
        {
            get { return new CodeString {Tag = new Tag("00281410")}; }
        }

        public static OtherByteString ICCProfile
        {
            get { return new OtherByteString {Tag = new Tag("00282000")}; }
        }

        public static CodeString LossyImageCompression
        {
            get { return new CodeString {Tag = new Tag("00282110")}; }
        }

        public static DecimalString LossyImageCompressionRatio
        {
            get { return new DecimalString {Tag = new Tag("00282112")}; }
        }

        public static CodeString LossyImageCompressionMethod
        {
            get { return new CodeString {Tag = new Tag("00282114")}; }
        }

        public static Sequence ModalityLUTSequence
        {
            get { return new Sequence {Tag = new Tag("00283000")}; }
        }

        public static UnsignedShort LUTDescriptor
        {
            get { return new UnsignedShort {Tag = new Tag("00283002")}; }
        }

        public static LongString LUTExplanation
        {
            get { return new LongString {Tag = new Tag("00283003")}; }
        }

        public static LongString ModalityLUTType
        {
            get { return new LongString {Tag = new Tag("00283004")}; }
        }

        public static UnsignedShort LUTData
        {
            get { return new UnsignedShort {Tag = new Tag("00283006")}; }
        }

        public static Sequence VOILUTSequence
        {
            get { return new Sequence {Tag = new Tag("00283010")}; }
        }

        public static Sequence SoftcopyVOILUTSequence
        {
            get { return new Sequence {Tag = new Tag("00283110")}; }
        }

        public static LongText ImagePresentationCommentsRetired
        {
            get { return new LongText {Tag = new Tag("00284000")}; }
        }

        public static Sequence BiPlaneAcquisitionSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00285000")}; }
        }

        public static UnsignedShort RepresentativeFrameNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00286010")}; }
        }

        public static UnsignedShort FrameNumbersOfInterest
        {
            get { return new UnsignedShort {Tag = new Tag("00286020")}; }
        }

        public static LongString FrameOfInterestDescription
        {
            get { return new LongString {Tag = new Tag("00286022")}; }
        }

        public static CodeString FrameOfInterestType
        {
            get { return new CodeString {Tag = new Tag("00286023")}; }
        }

        public static UnsignedShort MaskPointersRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00286030")}; }
        }

        public static UnsignedShort RWavePointer
        {
            get { return new UnsignedShort {Tag = new Tag("00286040")}; }
        }

        public static Sequence MaskSubtractionSequence
        {
            get { return new Sequence {Tag = new Tag("00286100")}; }
        }

        public static CodeString MaskOperation
        {
            get { return new CodeString {Tag = new Tag("00286101")}; }
        }

        public static UnsignedShort ApplicableFrameRange
        {
            get { return new UnsignedShort {Tag = new Tag("00286102")}; }
        }

        public static UnsignedShort MaskFrameNumbers
        {
            get { return new UnsignedShort {Tag = new Tag("00286110")}; }
        }

        public static UnsignedShort ContrastFrameAveraging
        {
            get { return new UnsignedShort {Tag = new Tag("00286112")}; }
        }

        public static FloatingPointSingle MaskSubPixelShift
        {
            get { return new FloatingPointSingle {Tag = new Tag("00286114")}; }
        }

        public static SignedShort TIDOffset
        {
            get { return new SignedShort {Tag = new Tag("00286120")}; }
        }

        public static ShortText MaskOperationExplanation
        {
            get { return new ShortText {Tag = new Tag("00286190")}; }
        }

        public static UnlimitedText PixelDataProviderURL
        {
            get { return new UnlimitedText {Tag = new Tag("00287FE0")}; }
        }

        public static UnsignedLong DataPointRows
        {
            get { return new UnsignedLong {Tag = new Tag("00289001")}; }
        }

        public static UnsignedLong DataPointColumns
        {
            get { return new UnsignedLong {Tag = new Tag("00289002")}; }
        }

        public static CodeString SignalDomainColumns
        {
            get { return new CodeString {Tag = new Tag("00289003")}; }
        }

        public static UnsignedShort LargestMonochromePixelValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00289099")}; }
        }

        public static CodeString DataRepresentation
        {
            get { return new CodeString {Tag = new Tag("00289108")}; }
        }

        public static Sequence PixelMeasuresSequence
        {
            get { return new Sequence {Tag = new Tag("00289110")}; }
        }

        public static Sequence FrameVOILUTSequence
        {
            get { return new Sequence {Tag = new Tag("00289132")}; }
        }

        public static Sequence PixelValueTransformationSequence
        {
            get { return new Sequence {Tag = new Tag("00289145")}; }
        }

        public static CodeString SignalDomainRows
        {
            get { return new CodeString {Tag = new Tag("00289235")}; }
        }

        public static FloatingPointSingle DisplayFilterPercentage
        {
            get { return new FloatingPointSingle {Tag = new Tag("00289411")}; }
        }

        public static Sequence FramePixelShiftSequence
        {
            get { return new Sequence {Tag = new Tag("00289415")}; }
        }

        public static UnsignedShort SubtractionItemID
        {
            get { return new UnsignedShort {Tag = new Tag("00289416")}; }
        }

        public static Sequence PixelIntensityRelationshipLUTSequence
        {
            get { return new Sequence {Tag = new Tag("00289422")}; }
        }

        public static Sequence FramePixelDataPropertiesSequence
        {
            get { return new Sequence {Tag = new Tag("00289443")}; }
        }

        public static CodeString GeometricalProperties
        {
            get { return new CodeString {Tag = new Tag("00289444")}; }
        }

        public static FloatingPointSingle GeometricMaximumDistortion
        {
            get { return new FloatingPointSingle {Tag = new Tag("00289445")}; }
        }

        public static CodeString ImageProcessingApplied
        {
            get { return new CodeString {Tag = new Tag("00289446")}; }
        }

        public static CodeString MaskSelectionMode
        {
            get { return new CodeString {Tag = new Tag("00289454")}; }
        }

        public static CodeString LUTFunction
        {
            get { return new CodeString {Tag = new Tag("00289474")}; }
        }

        public static FloatingPointSingle MaskVisibilityPercentage
        {
            get { return new FloatingPointSingle {Tag = new Tag("00289478")}; }
        }

        public static Sequence PixelShiftSequence
        {
            get { return new Sequence {Tag = new Tag("00289501")}; }
        }

        public static Sequence RegionPixelShiftSequence
        {
            get { return new Sequence {Tag = new Tag("00289502")}; }
        }

        public static SignedShort VerticesOfTheRegion
        {
            get { return new SignedShort {Tag = new Tag("00289503")}; }
        }

        public static Sequence MultiFramePresentationSequence
        {
            get { return new Sequence {Tag = new Tag("00289505")}; }
        }

        public static UnsignedShort PixelShiftFrameRange
        {
            get { return new UnsignedShort {Tag = new Tag("00289506")}; }
        }

        public static UnsignedShort LUTFrameRange
        {
            get { return new UnsignedShort {Tag = new Tag("00289507")}; }
        }

        public static DecimalString ImageToEquipmentMappingMatrix
        {
            get { return new DecimalString {Tag = new Tag("00289520")}; }
        }

        public static CodeString EquipmentCoordinateSystemIdentification
        {
            get { return new CodeString {Tag = new Tag("00289537")}; }
        }

        public static CodeString StudyStatusIDRetired
        {
            get { return new CodeString {Tag = new Tag("0032000A")}; }
        }

        public static CodeString StudyPriorityIDRetired
        {
            get { return new CodeString {Tag = new Tag("0032000C")}; }
        }

        public static LongString StudyIDIssuerRetired
        {
            get { return new LongString {Tag = new Tag("00320012")}; }
        }

        public static Date StudyVerifiedDateRetired
        {
            get { return new Date {Tag = new Tag("00320032")}; }
        }

        public static Time StudyVerifiedTimeRetired
        {
            get { return new Time {Tag = new Tag("00320033")}; }
        }

        public static Date StudyReadDateRetired
        {
            get { return new Date {Tag = new Tag("00320034")}; }
        }

        public static Time StudyReadTimeRetired
        {
            get { return new Time {Tag = new Tag("00320035")}; }
        }

        public static Date ScheduledStudyStartDateRetired
        {
            get { return new Date {Tag = new Tag("00321000")}; }
        }

        public static Time ScheduledStudyStartTimeRetired
        {
            get { return new Time {Tag = new Tag("00321001")}; }
        }

        public static Date ScheduledStudyStopDateRetired
        {
            get { return new Date {Tag = new Tag("00321010")}; }
        }

        public static Time ScheduledStudyStopTimeRetired
        {
            get { return new Time {Tag = new Tag("00321011")}; }
        }

        public static LongString ScheduledStudyLocationRetired
        {
            get { return new LongString {Tag = new Tag("00321020")}; }
        }

        public static ApplicationEntity ScheduledStudyLocationAETitleRetired
        {
            get { return new ApplicationEntity {Tag = new Tag("00321021")}; }
        }

        public static LongString ReasonForStudyRetired
        {
            get { return new LongString {Tag = new Tag("00321030")}; }
        }

        public static Sequence RequestingPhysicianIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00321031")}; }
        }

        public static PersonName RequestingPhysician
        {
            get { return new PersonName {Tag = new Tag("00321032")}; }
        }

        public static LongString RequestingService
        {
            get { return new LongString {Tag = new Tag("00321033")}; }
        }

        public static Sequence RequestingServiceCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00321034")}; }
        }

        public static Date StudyArrivalDateRetired
        {
            get { return new Date {Tag = new Tag("00321040")}; }
        }

        public static Time StudyArrivalTimeRetired
        {
            get { return new Time {Tag = new Tag("00321041")}; }
        }

        public static Date StudyCompletionDateRetired
        {
            get { return new Date {Tag = new Tag("00321050")}; }
        }

        public static Time StudyCompletionTimeRetired
        {
            get { return new Time {Tag = new Tag("00321051")}; }
        }

        public static CodeString StudyComponentStatusIDRetired
        {
            get { return new CodeString {Tag = new Tag("00321055")}; }
        }

        public static LongString RequestedProcedureDescription
        {
            get { return new LongString {Tag = new Tag("00321060")}; }
        }

        public static Sequence RequestedProcedureCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00321064")}; }
        }

        public static LongString RequestedContrastAgent
        {
            get { return new LongString {Tag = new Tag("00321070")}; }
        }

        public static LongText StudyCommentsRetired
        {
            get { return new LongText {Tag = new Tag("00324000")}; }
        }

        public static Sequence ReferencedPatientAliasSequence
        {
            get { return new Sequence {Tag = new Tag("00380004")}; }
        }

        public static CodeString VisitStatusID
        {
            get { return new CodeString {Tag = new Tag("00380008")}; }
        }

        public static LongString AdmissionID
        {
            get { return new LongString {Tag = new Tag("00380010")}; }
        }

        public static LongString IssuerOfAdmissionIDRetired
        {
            get { return new LongString {Tag = new Tag("00380011")}; }
        }

        public static Sequence IssuerOfAdmissionIDSequence
        {
            get { return new Sequence {Tag = new Tag("00380014")}; }
        }

        public static LongString RouteOfAdmissions
        {
            get { return new LongString {Tag = new Tag("00380016")}; }
        }

        public static Date ScheduledAdmissionDateRetired
        {
            get { return new Date {Tag = new Tag("0038001A")}; }
        }

        public static Time ScheduledAdmissionTimeRetired
        {
            get { return new Time {Tag = new Tag("0038001B")}; }
        }

        public static Date ScheduledDischargeDateRetired
        {
            get { return new Date {Tag = new Tag("0038001C")}; }
        }

        public static Time ScheduledDischargeTimeRetired
        {
            get { return new Time {Tag = new Tag("0038001D")}; }
        }

        public static LongString ScheduledPatientInstitutionResidenceRetired
        {
            get { return new LongString {Tag = new Tag("0038001E")}; }
        }

        public static Date AdmittingDate
        {
            get { return new Date {Tag = new Tag("00380020")}; }
        }

        public static Time AdmittingTime
        {
            get { return new Time {Tag = new Tag("00380021")}; }
        }

        public static Date DischargeDateRetired
        {
            get { return new Date {Tag = new Tag("00380030")}; }
        }

        public static Time DischargeTimeRetired
        {
            get { return new Time {Tag = new Tag("00380032")}; }
        }

        public static LongString DischargeDiagnosisDescriptionRetired
        {
            get { return new LongString {Tag = new Tag("00380040")}; }
        }

        public static Sequence DischargeDiagnosisCodeSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00380044")}; }
        }

        public static LongString SpecialNeeds
        {
            get { return new LongString {Tag = new Tag("00380050")}; }
        }

        public static LongString ServiceEpisodeID
        {
            get { return new LongString {Tag = new Tag("00380060")}; }
        }

        public static LongString IssuerOfServiceEpisodeIDRetired
        {
            get { return new LongString {Tag = new Tag("00380061")}; }
        }

        public static LongString ServiceEpisodeDescription
        {
            get { return new LongString {Tag = new Tag("00380062")}; }
        }

        public static Sequence IssuerOfServiceEpisodeIDSequence
        {
            get { return new Sequence {Tag = new Tag("00380064")}; }
        }

        public static Sequence PertinentDocumentsSequence
        {
            get { return new Sequence {Tag = new Tag("00380100")}; }
        }

        public static LongString CurrentPatientLocation
        {
            get { return new LongString {Tag = new Tag("00380300")}; }
        }

        public static LongString PatientInstitutionResidence
        {
            get { return new LongString {Tag = new Tag("00380400")}; }
        }

        public static LongString PatientState
        {
            get { return new LongString {Tag = new Tag("00380500")}; }
        }

        public static Sequence PatientClinicalTrialParticipationSequence
        {
            get { return new Sequence {Tag = new Tag("00380502")}; }
        }

        public static LongText VisitComments
        {
            get { return new LongText {Tag = new Tag("00384000")}; }
        }

        public static CodeString WaveformOriginality
        {
            get { return new CodeString {Tag = new Tag("003A0004")}; }
        }

        public static UnsignedShort NumberOfWaveformChannels
        {
            get { return new UnsignedShort {Tag = new Tag("003A0005")}; }
        }

        public static UnsignedLong NumberOfWaveformSamples
        {
            get { return new UnsignedLong {Tag = new Tag("003A0010")}; }
        }

        public static DecimalString SamplingFrequency
        {
            get { return new DecimalString {Tag = new Tag("003A001A")}; }
        }

        public static ShortString MultiplexGroupLabel
        {
            get { return new ShortString {Tag = new Tag("003A0020")}; }
        }

        public static Sequence ChannelDefinitionSequence
        {
            get { return new Sequence {Tag = new Tag("003A0200")}; }
        }

        public static IntegerString WaveformChannelNumber
        {
            get { return new IntegerString {Tag = new Tag("003A0202")}; }
        }

        public static ShortString ChannelLabel
        {
            get { return new ShortString {Tag = new Tag("003A0203")}; }
        }

        public static CodeString ChannelStatus
        {
            get { return new CodeString {Tag = new Tag("003A0205")}; }
        }

        public static Sequence ChannelSourceSequence
        {
            get { return new Sequence {Tag = new Tag("003A0208")}; }
        }

        public static Sequence ChannelSourceModifiersSequence
        {
            get { return new Sequence {Tag = new Tag("003A0209")}; }
        }

        public static Sequence SourceWaveformSequence
        {
            get { return new Sequence {Tag = new Tag("003A020A")}; }
        }

        public static LongString ChannelDerivationDescription
        {
            get { return new LongString {Tag = new Tag("003A020C")}; }
        }

        public static DecimalString ChannelSensitivity
        {
            get { return new DecimalString {Tag = new Tag("003A0210")}; }
        }

        public static Sequence ChannelSensitivityUnitsSequence
        {
            get { return new Sequence {Tag = new Tag("003A0211")}; }
        }

        public static DecimalString ChannelSensitivityCorrectionFactor
        {
            get { return new DecimalString {Tag = new Tag("003A0212")}; }
        }

        public static DecimalString ChannelBaseline
        {
            get { return new DecimalString {Tag = new Tag("003A0213")}; }
        }

        public static DecimalString ChannelTimeSkew
        {
            get { return new DecimalString {Tag = new Tag("003A0214")}; }
        }

        public static DecimalString ChannelSampleSkew
        {
            get { return new DecimalString {Tag = new Tag("003A0215")}; }
        }

        public static DecimalString ChannelOffset
        {
            get { return new DecimalString {Tag = new Tag("003A0218")}; }
        }

        public static UnsignedShort WaveformBitsStored
        {
            get { return new UnsignedShort {Tag = new Tag("003A021A")}; }
        }

        public static DecimalString FilterLowFrequency
        {
            get { return new DecimalString {Tag = new Tag("003A0220")}; }
        }

        public static DecimalString FilterHighFrequency
        {
            get { return new DecimalString {Tag = new Tag("003A0221")}; }
        }

        public static DecimalString NotchFilterFrequency
        {
            get { return new DecimalString {Tag = new Tag("003A0222")}; }
        }

        public static DecimalString NotchFilterBandwidth
        {
            get { return new DecimalString {Tag = new Tag("003A0223")}; }
        }

        public static FloatingPointSingle WaveformDataDisplayScale
        {
            get { return new FloatingPointSingle {Tag = new Tag("003A0230")}; }
        }

        public static UnsignedShort WaveformDisplayBackgroundCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("003A0231")}; }
        }

        public static Sequence WaveformPresentationGroupSequence
        {
            get { return new Sequence {Tag = new Tag("003A0240")}; }
        }

        public static UnsignedShort PresentationGroupNumber
        {
            get { return new UnsignedShort {Tag = new Tag("003A0241")}; }
        }

        public static Sequence ChannelDisplaySequence
        {
            get { return new Sequence {Tag = new Tag("003A0242")}; }
        }

        public static UnsignedShort ChannelRecommendedDisplayCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("003A0244")}; }
        }

        public static FloatingPointSingle ChannelPosition
        {
            get { return new FloatingPointSingle {Tag = new Tag("003A0245")}; }
        }

        public static CodeString DisplayShadingFlag
        {
            get { return new CodeString {Tag = new Tag("003A0246")}; }
        }

        public static FloatingPointSingle FractionalChannelDisplayScale
        {
            get { return new FloatingPointSingle {Tag = new Tag("003A0247")}; }
        }

        public static FloatingPointSingle AbsoluteChannelDisplayScale
        {
            get { return new FloatingPointSingle {Tag = new Tag("003A0248")}; }
        }

        public static Sequence MultiplexedAudioChannelsDescriptionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("003A0300")}; }
        }

        public static IntegerString ChannelIdentificationCode
        {
            get { return new IntegerString {Tag = new Tag("003A0301")}; }
        }

        public static CodeString ChannelMode
        {
            get { return new CodeString {Tag = new Tag("003A0302")}; }
        }

        public static ApplicationEntity ScheduledStationAETitle
        {
            get { return new ApplicationEntity {Tag = new Tag("00400001")}; }
        }

        public static Date ScheduledProcedureStepStartDate
        {
            get { return new Date {Tag = new Tag("00400002")}; }
        }

        public static Time ScheduledProcedureStepStartTime
        {
            get { return new Time {Tag = new Tag("00400003")}; }
        }

        public static Date ScheduledProcedureStepEndDate
        {
            get { return new Date {Tag = new Tag("00400004")}; }
        }

        public static Time ScheduledProcedureStepEndTime
        {
            get { return new Time {Tag = new Tag("00400005")}; }
        }

        public static PersonName ScheduledPerformingPhysicianName
        {
            get { return new PersonName {Tag = new Tag("00400006")}; }
        }

        public static LongString ScheduledProcedureStepDescription
        {
            get { return new LongString {Tag = new Tag("00400007")}; }
        }

        public static Sequence ScheduledProtocolCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00400008")}; }
        }

        public static ShortString ScheduledProcedureStepID
        {
            get { return new ShortString {Tag = new Tag("00400009")}; }
        }

        public static Sequence StageCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040000A")}; }
        }

        public static Sequence ScheduledPerformingPhysicianIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("0040000B")}; }
        }

        public static ShortString ScheduledStationName
        {
            get { return new ShortString {Tag = new Tag("00400010")}; }
        }

        public static ShortString ScheduledProcedureStepLocation
        {
            get { return new ShortString {Tag = new Tag("00400011")}; }
        }

        public static LongString PreMedication
        {
            get { return new LongString {Tag = new Tag("00400012")}; }
        }

        public static CodeString ScheduledProcedureStepStatus
        {
            get { return new CodeString {Tag = new Tag("00400020")}; }
        }

        public static Sequence OrderPlacerIdentifierSequence
        {
            get { return new Sequence {Tag = new Tag("00400026")}; }
        }

        public static Sequence OrderFillerIdentifierSequence
        {
            get { return new Sequence {Tag = new Tag("00400027")}; }
        }

        public static UnlimitedText LocalNamespaceEntityID
        {
            get { return new UnlimitedText {Tag = new Tag("00400031")}; }
        }

        public static UnlimitedText UniversalEntityID
        {
            get { return new UnlimitedText {Tag = new Tag("00400032")}; }
        }

        public static CodeString UniversalEntityIDType
        {
            get { return new CodeString {Tag = new Tag("00400033")}; }
        }

        public static CodeString IdentifierTypeCode
        {
            get { return new CodeString {Tag = new Tag("00400035")}; }
        }

        public static Sequence AssigningFacilitySequence
        {
            get { return new Sequence {Tag = new Tag("00400036")}; }
        }

        public static Sequence AssigningJurisdictionCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00400039")}; }
        }

        public static Sequence AssigningAgencyOrDepartmentCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040003A")}; }
        }

        public static Sequence ScheduledProcedureStepSequence
        {
            get { return new Sequence {Tag = new Tag("00400100")}; }
        }

        public static Sequence ReferencedNonImageCompositeSOPInstanceSequence
        {
            get { return new Sequence {Tag = new Tag("00400220")}; }
        }

        public static ApplicationEntity PerformedStationAETitle
        {
            get { return new ApplicationEntity {Tag = new Tag("00400241")}; }
        }

        public static ShortString PerformedStationName
        {
            get { return new ShortString {Tag = new Tag("00400242")}; }
        }

        public static ShortString PerformedLocation
        {
            get { return new ShortString {Tag = new Tag("00400243")}; }
        }

        public static Date PerformedProcedureStepStartDate
        {
            get { return new Date {Tag = new Tag("00400244")}; }
        }

        public static Time PerformedProcedureStepStartTime
        {
            get { return new Time {Tag = new Tag("00400245")}; }
        }

        public static Date PerformedProcedureStepEndDate
        {
            get { return new Date {Tag = new Tag("00400250")}; }
        }

        public static Time PerformedProcedureStepEndTime
        {
            get { return new Time {Tag = new Tag("00400251")}; }
        }

        public static CodeString PerformedProcedureStepStatus
        {
            get { return new CodeString {Tag = new Tag("00400252")}; }
        }

        public static ShortString PerformedProcedureStepID
        {
            get { return new ShortString {Tag = new Tag("00400253")}; }
        }

        public static LongString PerformedProcedureStepDescription
        {
            get { return new LongString {Tag = new Tag("00400254")}; }
        }

        public static LongString PerformedProcedureTypeDescription
        {
            get { return new LongString {Tag = new Tag("00400255")}; }
        }

        public static Sequence PerformedProtocolCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00400260")}; }
        }

        public static CodeString PerformedProtocolType
        {
            get { return new CodeString {Tag = new Tag("00400261")}; }
        }

        public static Sequence ScheduledStepAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("00400270")}; }
        }

        public static Sequence RequestAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("00400275")}; }
        }

        public static ShortText CommentsOnThePerformedProcedureStep
        {
            get { return new ShortText {Tag = new Tag("00400280")}; }
        }

        public static Sequence PerformedProcedureStepDiscontinuationReasonCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00400281")}; }
        }

        public static Sequence QuantitySequence
        {
            get { return new Sequence {Tag = new Tag("00400293")}; }
        }

        public static DecimalString Quantity
        {
            get { return new DecimalString {Tag = new Tag("00400294")}; }
        }

        public static Sequence MeasuringUnitsSequence
        {
            get { return new Sequence {Tag = new Tag("00400295")}; }
        }

        public static Sequence BillingItemSequence
        {
            get { return new Sequence {Tag = new Tag("00400296")}; }
        }

        public static UnsignedShort TotalTimeOfFluoroscopy
        {
            get { return new UnsignedShort {Tag = new Tag("00400300")}; }
        }

        public static UnsignedShort TotalNumberOfExposures
        {
            get { return new UnsignedShort {Tag = new Tag("00400301")}; }
        }

        public static UnsignedShort EntranceDose
        {
            get { return new UnsignedShort {Tag = new Tag("00400302")}; }
        }

        public static UnsignedShort ExposedArea
        {
            get { return new UnsignedShort {Tag = new Tag("00400303")}; }
        }

        public static DecimalString DistanceSourceToEntrance
        {
            get { return new DecimalString {Tag = new Tag("00400306")}; }
        }

        public static DecimalString DistanceSourceToSupportRetired
        {
            get { return new DecimalString {Tag = new Tag("00400307")}; }
        }

        public static Sequence ExposureDoseSequence
        {
            get { return new Sequence {Tag = new Tag("0040030E")}; }
        }

        public static ShortText CommentsOnRadiationDose
        {
            get { return new ShortText {Tag = new Tag("00400310")}; }
        }

        public static DecimalString XRayOutput
        {
            get { return new DecimalString {Tag = new Tag("00400312")}; }
        }

        public static DecimalString HalfValueLayer
        {
            get { return new DecimalString {Tag = new Tag("00400314")}; }
        }

        public static DecimalString OrganDose
        {
            get { return new DecimalString {Tag = new Tag("00400316")}; }
        }

        public static CodeString OrganExposed
        {
            get { return new CodeString {Tag = new Tag("00400318")}; }
        }

        public static Sequence BillingProcedureStepSequence
        {
            get { return new Sequence {Tag = new Tag("00400320")}; }
        }

        public static Sequence FilmConsumptionSequence
        {
            get { return new Sequence {Tag = new Tag("00400321")}; }
        }

        public static Sequence BillingSuppliesAndDevicesSequence
        {
            get { return new Sequence {Tag = new Tag("00400324")}; }
        }

        public static Sequence ReferencedProcedureStepSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00400330")}; }
        }

        public static Sequence PerformedSeriesSequence
        {
            get { return new Sequence {Tag = new Tag("00400340")}; }
        }

        public static LongText CommentsOnTheScheduledProcedureStep
        {
            get { return new LongText {Tag = new Tag("00400400")}; }
        }

        public static Sequence ProtocolContextSequence
        {
            get { return new Sequence {Tag = new Tag("00400440")}; }
        }

        public static Sequence ContentItemModifierSequence
        {
            get { return new Sequence {Tag = new Tag("00400441")}; }
        }

        public static Sequence ScheduledSpecimenSequence
        {
            get { return new Sequence {Tag = new Tag("00400500")}; }
        }

        public static LongString SpecimenAccessionNumberRetired
        {
            get { return new LongString {Tag = new Tag("0040050A")}; }
        }

        public static LongString ContainerIdentifier
        {
            get { return new LongString {Tag = new Tag("00400512")}; }
        }

        public static Sequence IssuerOfTheContainerIdentifierSequence
        {
            get { return new Sequence {Tag = new Tag("00400513")}; }
        }

        public static Sequence AlternateContainerIdentifierSequence
        {
            get { return new Sequence {Tag = new Tag("00400515")}; }
        }

        public static Sequence ContainerTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00400518")}; }
        }

        public static LongString ContainerDescription
        {
            get { return new LongString {Tag = new Tag("0040051A")}; }
        }

        public static Sequence ContainerComponentSequence
        {
            get { return new Sequence {Tag = new Tag("00400520")}; }
        }

        public static Sequence SpecimenSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00400550")}; }
        }

        public static LongString SpecimenIdentifier
        {
            get { return new LongString {Tag = new Tag("00400551")}; }
        }

        public static Sequence SpecimenDescriptionSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("00400552")}; }
        }

        public static ShortText SpecimenDescriptionTrialRetired
        {
            get { return new ShortText {Tag = new Tag("00400553")}; }
        }

        public static UniqueIdentifier SpecimenUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00400554")}; }
        }

        public static Sequence AcquisitionContextSequence
        {
            get { return new Sequence {Tag = new Tag("00400555")}; }
        }

        public static ShortText AcquisitionContextDescription
        {
            get { return new ShortText {Tag = new Tag("00400556")}; }
        }

        public static Sequence SpecimenDescriptionSequence
        {
            get { return new Sequence {Tag = new Tag("00400560")}; }
        }

        public static Sequence IssuerOfTheSpecimenIdentifierSequence
        {
            get { return new Sequence {Tag = new Tag("00400562")}; }
        }

        public static Sequence SpecimenTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040059A")}; }
        }

        public static LongString SpecimenShortDescription
        {
            get { return new LongString {Tag = new Tag("00400600")}; }
        }

        public static UnlimitedText SpecimenDetailedDescription
        {
            get { return new UnlimitedText {Tag = new Tag("00400602")}; }
        }

        public static Sequence SpecimenPreparationSequence
        {
            get { return new Sequence {Tag = new Tag("00400610")}; }
        }

        public static Sequence SpecimenPreparationStepContentItemSequence
        {
            get { return new Sequence {Tag = new Tag("00400612")}; }
        }

        public static Sequence SpecimenLocalizationContentItemSequence
        {
            get { return new Sequence {Tag = new Tag("00400620")}; }
        }

        public static LongString SlideIdentifierRetired
        {
            get { return new LongString {Tag = new Tag("004006FA")}; }
        }

        public static Sequence ImageCenterPointCoordinatesSequence
        {
            get { return new Sequence {Tag = new Tag("0040071A")}; }
        }

        public static DecimalString XOffsetInSlideCoordinateSystem
        {
            get { return new DecimalString {Tag = new Tag("0040072A")}; }
        }

        public static DecimalString YOffsetInSlideCoordinateSystem
        {
            get { return new DecimalString {Tag = new Tag("0040073A")}; }
        }

        public static DecimalString ZOffsetInSlideCoordinateSystem
        {
            get { return new DecimalString {Tag = new Tag("0040074A")}; }
        }

        public static Sequence PixelSpacingSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("004008D8")}; }
        }

        public static Sequence CoordinateSystemAxisCodeSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("004008DA")}; }
        }

        public static Sequence MeasurementUnitsCodeSequence
        {
            get { return new Sequence {Tag = new Tag("004008EA")}; }
        }

        public static Sequence VitalStainCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("004009F8")}; }
        }

        public static ShortString RequestedProcedureID
        {
            get { return new ShortString {Tag = new Tag("00401001")}; }
        }

        public static LongString ReasonForTheRequestedProcedure
        {
            get { return new LongString {Tag = new Tag("00401002")}; }
        }

        public static ShortString RequestedProcedurePriority
        {
            get { return new ShortString {Tag = new Tag("00401003")}; }
        }

        public static LongString PatientTransportArrangements
        {
            get { return new LongString {Tag = new Tag("00401004")}; }
        }

        public static LongString RequestedProcedureLocation
        {
            get { return new LongString {Tag = new Tag("00401005")}; }
        }

        public static ShortString PlacerOrderNumberProcedureRetired
        {
            get { return new ShortString {Tag = new Tag("00401006")}; }
        }

        public static ShortString FillerOrderNumberProcedureRetired
        {
            get { return new ShortString {Tag = new Tag("00401007")}; }
        }

        public static LongString ConfidentialityCode
        {
            get { return new LongString {Tag = new Tag("00401008")}; }
        }

        public static ShortString ReportingPriority
        {
            get { return new ShortString {Tag = new Tag("00401009")}; }
        }

        public static Sequence ReasonForRequestedProcedureCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040100A")}; }
        }

        public static PersonName NamesOfIntendedRecipientsOfResults
        {
            get { return new PersonName {Tag = new Tag("00401010")}; }
        }

        public static Sequence IntendedRecipientsOfResultsIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00401011")}; }
        }

        public static Sequence ReasonForPerformedProcedureCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00401012")}; }
        }

        public static LongString RequestedProcedureDescriptionTrialRetired
        {
            get { return new LongString {Tag = new Tag("00401060")}; }
        }

        public static Sequence PersonIdentificationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00401101")}; }
        }

        public static ShortText PersonAddress
        {
            get { return new ShortText {Tag = new Tag("00401102")}; }
        }

        public static LongString PersonTelephoneNumbers
        {
            get { return new LongString {Tag = new Tag("00401103")}; }
        }

        public static LongText RequestedProcedureComments
        {
            get { return new LongText {Tag = new Tag("00401400")}; }
        }

        public static LongString ReasonForTheImagingServiceRequestRetired
        {
            get { return new LongString {Tag = new Tag("00402001")}; }
        }

        public static Date IssueDateOfImagingServiceRequest
        {
            get { return new Date {Tag = new Tag("00402004")}; }
        }

        public static Time IssueTimeOfImagingServiceRequest
        {
            get { return new Time {Tag = new Tag("00402005")}; }
        }

        public static ShortString PlacerOrderNumberImagingServiceRequestRetired
        {
            get { return new ShortString {Tag = new Tag("00402006")}; }
        }

        public static ShortString FillerOrderNumberImagingServiceRequestRetired
        {
            get { return new ShortString {Tag = new Tag("00402007")}; }
        }

        public static PersonName OrderEnteredBy
        {
            get { return new PersonName {Tag = new Tag("00402008")}; }
        }

        public static ShortString OrderEntererLocation
        {
            get { return new ShortString {Tag = new Tag("00402009")}; }
        }

        public static ShortString OrderCallbackPhoneNumber
        {
            get { return new ShortString {Tag = new Tag("00402010")}; }
        }

        public static LongString PlacerOrderNumberImagingServiceRequest
        {
            get { return new LongString {Tag = new Tag("00402016")}; }
        }

        public static LongString FillerOrderNumberImagingServiceRequest
        {
            get { return new LongString {Tag = new Tag("00402017")}; }
        }

        public static LongText ImagingServiceRequestComments
        {
            get { return new LongText {Tag = new Tag("00402400")}; }
        }

        public static LongString ConfidentialityConstraintOnPatientDataDescription
        {
            get { return new LongString {Tag = new Tag("00403001")}; }
        }

        public static CodeString GeneralPurposeScheduledProcedureStepStatus
        {
            get { return new CodeString {Tag = new Tag("00404001")}; }
        }

        public static CodeString GeneralPurposePerformedProcedureStepStatus
        {
            get { return new CodeString {Tag = new Tag("00404002")}; }
        }

        public static CodeString GeneralPurposeScheduledProcedureStepPriority
        {
            get { return new CodeString {Tag = new Tag("00404003")}; }
        }

        public static Sequence ScheduledProcessingApplicationsCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404004")}; }
        }

        public static CodeString MultipleCopiesFlag
        {
            get { return new CodeString {Tag = new Tag("00404006")}; }
        }

        public static Sequence PerformedProcessingApplicationsCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404007")}; }
        }

        public static Sequence HumanPerformerCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404009")}; }
        }

        public static Sequence ResultingGeneralPurposePerformedProcedureStepsSequence
        {
            get { return new Sequence {Tag = new Tag("00404015")}; }
        }

        public static Sequence ReferencedGeneralPurposeScheduledProcedureStepSequence
        {
            get { return new Sequence {Tag = new Tag("00404016")}; }
        }

        public static Sequence ScheduledWorkitemCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404018")}; }
        }

        public static Sequence PerformedWorkitemCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404019")}; }
        }

        public static CodeString InputAvailabilityFlag
        {
            get { return new CodeString {Tag = new Tag("00404020")}; }
        }

        public static Sequence InputInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00404021")}; }
        }

        public static Sequence RelevantInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00404022")}; }
        }

        public static UniqueIdentifier ReferencedGeneralPurposeScheduledProcedureStepTransactionUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00404023")}; }
        }

        public static Sequence ScheduledStationNameCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404025")}; }
        }

        public static Sequence ScheduledStationClassCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404026")}; }
        }

        public static Sequence ScheduledStationGeographicLocationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404027")}; }
        }

        public static Sequence PerformedStationNameCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404028")}; }
        }

        public static Sequence PerformedStationClassCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404029")}; }
        }

        public static Sequence PerformedStationGeographicLocationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404030")}; }
        }

        public static Sequence RequestedSubsequentWorkitemCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404031")}; }
        }

        public static Sequence NonDICOMOutputCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00404032")}; }
        }

        public static Sequence OutputInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00404033")}; }
        }

        public static Sequence ScheduledHumanPerformersSequence
        {
            get { return new Sequence {Tag = new Tag("00404034")}; }
        }

        public static Sequence ActualHumanPerformersSequence
        {
            get { return new Sequence {Tag = new Tag("00404035")}; }
        }

        public static LongString HumanPerformerOrganization
        {
            get { return new LongString {Tag = new Tag("00404036")}; }
        }

        public static PersonName HumanPerformerName
        {
            get { return new PersonName {Tag = new Tag("00404037")}; }
        }

        public static CodeString RawDataHandling
        {
            get { return new CodeString {Tag = new Tag("00404040")}; }
        }

        public static CodeString InputReadinessState
        {
            get { return new CodeString {Tag = new Tag("00404041")}; }
        }

        public static DecimalString EntranceDoseInmGy
        {
            get { return new DecimalString {Tag = new Tag("00408302")}; }
        }

        public static Sequence ReferencedImageRealWorldValueMappingSequence
        {
            get { return new Sequence {Tag = new Tag("00409094")}; }
        }

        public static Sequence RealWorldValueMappingSequence
        {
            get { return new Sequence {Tag = new Tag("00409096")}; }
        }

        public static Sequence PixelValueMappingCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00409098")}; }
        }

        public static ShortString LUTLabel
        {
            get { return new ShortString {Tag = new Tag("00409210")}; }
        }

        public static UnsignedShort RealWorldValueLastValueMapped
        {
            get { return new UnsignedShort {Tag = new Tag("00409211")}; }
        }

        public static FloatingPointDouble RealWorldValueLUTData
        {
            get { return new FloatingPointDouble {Tag = new Tag("00409212")}; }
        }

        public static UnsignedShort RealWorldValueFirstValueMapped
        {
            get { return new UnsignedShort {Tag = new Tag("00409216")}; }
        }

        public static FloatingPointDouble RealWorldValueIntercept
        {
            get { return new FloatingPointDouble {Tag = new Tag("00409224")}; }
        }

        public static FloatingPointDouble RealWorldValueSlope
        {
            get { return new FloatingPointDouble {Tag = new Tag("00409225")}; }
        }

        public static CodeString FindingsFlagTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A007")}; }
        }

        public static CodeString RelationshipType
        {
            get { return new CodeString {Tag = new Tag("0040A010")}; }
        }

        public static Sequence FindingsSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A020")}; }
        }

        public static UniqueIdentifier FindingsGroupUIDTrialRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040A021")}; }
        }

        public static UniqueIdentifier ReferencedFindingsGroupUIDTrialRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040A022")}; }
        }

        public static Date FindingsGroupRecordingDateTrialRetired
        {
            get { return new Date {Tag = new Tag("0040A023")}; }
        }

        public static Time FindingsGroupRecordingTimeTrialRetired
        {
            get { return new Time {Tag = new Tag("0040A024")}; }
        }

        public static Sequence FindingsSourceCategoryCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A026")}; }
        }

        public static LongString VerifyingOrganization
        {
            get { return new LongString {Tag = new Tag("0040A027")}; }
        }

        public static Sequence DocumentingOrganizationIdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A028")}; }
        }

        public static CodeString ValueType
        {
            get { return new CodeString {Tag = new Tag("0040A040")}; }
        }

        public static Sequence ConceptNameCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A043")}; }
        }

        public static LongString MeasurementPrecisionDescriptionTrialRetired
        {
            get { return new LongString {Tag = new Tag("0040A047")}; }
        }

        public static CodeString ContinuityOfContent
        {
            get { return new CodeString {Tag = new Tag("0040A050")}; }
        }

        public static CodeString UrgencyOrPriorityAlertsTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A057")}; }
        }

        public static LongString SequencingIndicatorTrialRetired
        {
            get { return new LongString {Tag = new Tag("0040A060")}; }
        }

        public static Sequence DocumentIdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A066")}; }
        }

        public static PersonName DocumentAuthorTrialRetired
        {
            get { return new PersonName {Tag = new Tag("0040A067")}; }
        }

        public static Sequence DocumentAuthorIdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A068")}; }
        }

        public static Sequence IdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A070")}; }
        }

        public static Sequence VerifyingObserverSequence
        {
            get { return new Sequence {Tag = new Tag("0040A073")}; }
        }

        public static OtherByteString ObjectBinaryIdentifierTrialRetired
        {
            get { return new OtherByteString {Tag = new Tag("0040A074")}; }
        }

        public static PersonName VerifyingObserverName
        {
            get { return new PersonName {Tag = new Tag("0040A075")}; }
        }

        public static Sequence DocumentingObserverIdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A076")}; }
        }

        public static Sequence AuthorObserverSequence
        {
            get { return new Sequence {Tag = new Tag("0040A078")}; }
        }

        public static Sequence ParticipantSequence
        {
            get { return new Sequence {Tag = new Tag("0040A07A")}; }
        }

        public static Sequence CustodialOrganizationSequence
        {
            get { return new Sequence {Tag = new Tag("0040A07C")}; }
        }

        public static CodeString ParticipationType
        {
            get { return new CodeString {Tag = new Tag("0040A080")}; }
        }

        public static CodeString ObserverType
        {
            get { return new CodeString {Tag = new Tag("0040A084")}; }
        }

        public static Sequence ProcedureIdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A085")}; }
        }

        public static Sequence VerifyingObserverIdentificationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A088")}; }
        }

        public static OtherByteString ObjectDirectoryBinaryIdentifierTrialRetired
        {
            get { return new OtherByteString {Tag = new Tag("0040A089")}; }
        }

        public static Sequence EquivalentCDADocumentSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("0040A090")}; }
        }

        public static UnsignedShort ReferencedWaveformChannels
        {
            get { return new UnsignedShort {Tag = new Tag("0040A0B0")}; }
        }

        public static Date DateOfDocumentOrVerbalTransactionTrialRetired
        {
            get { return new Date {Tag = new Tag("0040A110")}; }
        }

        public static Time TimeOfDocumentCreationOrVerbalTransactionTrialRetired
        {
            get { return new Time {Tag = new Tag("0040A112")}; }
        }

        public static Date Date
        {
            get { return new Date {Tag = new Tag("0040A121")}; }
        }

        public static Time Time
        {
            get { return new Time {Tag = new Tag("0040A122")}; }
        }

        public static PersonName PersonName
        {
            get { return new PersonName {Tag = new Tag("0040A123")}; }
        }

        public static UniqueIdentifier UID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040A124")}; }
        }

        public static CodeString ReportStatusIDTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A125")}; }
        }

        public static CodeString TemporalRangeType
        {
            get { return new CodeString {Tag = new Tag("0040A130")}; }
        }

        public static UnsignedLong ReferencedSamplePositions
        {
            get { return new UnsignedLong {Tag = new Tag("0040A132")}; }
        }

        public static UnsignedShort ReferencedFrameNumbers
        {
            get { return new UnsignedShort {Tag = new Tag("0040A136")}; }
        }

        public static DecimalString ReferencedTimeOffsets
        {
            get { return new DecimalString {Tag = new Tag("0040A138")}; }
        }

        public static UnlimitedText TextValue
        {
            get { return new UnlimitedText {Tag = new Tag("0040A160")}; }
        }

        public static Sequence ObservationCategoryCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A167")}; }
        }

        public static Sequence ConceptCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A168")}; }
        }

        public static ShortText BibliographicCitationTrialRetired
        {
            get { return new ShortText {Tag = new Tag("0040A16A")}; }
        }

        public static Sequence PurposeOfReferenceCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A170")}; }
        }

        public static UniqueIdentifier ObservationUIDTrialRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040A171")}; }
        }

        public static UniqueIdentifier ReferencedObservationUIDTrialRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040A172")}; }
        }

        public static CodeString ReferencedObservationClassTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A173")}; }
        }

        public static CodeString ReferencedObjectObservationClassTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A174")}; }
        }

        public static UnsignedShort AnnotationGroupNumber
        {
            get { return new UnsignedShort {Tag = new Tag("0040A180")}; }
        }

        public static Date ObservationDateTrialRetired
        {
            get { return new Date {Tag = new Tag("0040A192")}; }
        }

        public static Time ObservationTimeTrialRetired
        {
            get { return new Time {Tag = new Tag("0040A193")}; }
        }

        public static CodeString MeasurementAutomationTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A194")}; }
        }

        public static Sequence ModifierCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A195")}; }
        }

        public static ShortText IdentificationDescriptionTrialRetired
        {
            get { return new ShortText {Tag = new Tag("0040A224")}; }
        }

        public static CodeString CoordinatesSetGeometricTypeTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A290")}; }
        }

        public static Sequence AlgorithmCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A296")}; }
        }

        public static ShortText AlgorithmDescriptionTrialRetired
        {
            get { return new ShortText {Tag = new Tag("0040A297")}; }
        }

        public static SignedLong PixelCoordinatesSetTrialRetired
        {
            get { return new SignedLong {Tag = new Tag("0040A29A")}; }
        }

        public static Sequence MeasuredValueSequence
        {
            get { return new Sequence {Tag = new Tag("0040A300")}; }
        }

        public static Sequence NumericValueQualifierCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A301")}; }
        }

        public static PersonName CurrentObserverTrialRetired
        {
            get { return new PersonName {Tag = new Tag("0040A307")}; }
        }

        public static DecimalString NumericValue
        {
            get { return new DecimalString {Tag = new Tag("0040A30A")}; }
        }

        public static Sequence ReferencedAccessionSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A313")}; }
        }

        public static ShortText ReportStatusCommentTrialRetired
        {
            get { return new ShortText {Tag = new Tag("0040A33A")}; }
        }

        public static Sequence ProcedureContextSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A340")}; }
        }

        public static PersonName VerbalSourceTrialRetired
        {
            get { return new PersonName {Tag = new Tag("0040A352")}; }
        }

        public static ShortText AddressTrialRetired
        {
            get { return new ShortText {Tag = new Tag("0040A353")}; }
        }

        public static LongString TelephoneNumberTrialRetired
        {
            get { return new LongString {Tag = new Tag("0040A354")}; }
        }

        public static Sequence VerbalSourceIdentifierCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A358")}; }
        }

        public static Sequence PredecessorDocumentsSequence
        {
            get { return new Sequence {Tag = new Tag("0040A360")}; }
        }

        public static Sequence ReferencedRequestSequence
        {
            get { return new Sequence {Tag = new Tag("0040A370")}; }
        }

        public static Sequence PerformedProcedureCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040A372")}; }
        }

        public static Sequence CurrentRequestedProcedureEvidenceSequence
        {
            get { return new Sequence {Tag = new Tag("0040A375")}; }
        }

        public static Sequence ReportDetailSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A380")}; }
        }

        public static Sequence PertinentOtherEvidenceSequence
        {
            get { return new Sequence {Tag = new Tag("0040A385")}; }
        }

        public static Sequence HL7StructuredDocumentReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("0040A390")}; }
        }

        public static UniqueIdentifier ObservationSubjectUIDTrialRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040A402")}; }
        }

        public static CodeString ObservationSubjectClassTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A403")}; }
        }

        public static Sequence ObservationSubjectTypeCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A404")}; }
        }

        public static CodeString CompletionFlag
        {
            get { return new CodeString {Tag = new Tag("0040A491")}; }
        }

        public static LongString CompletionFlagDescription
        {
            get { return new LongString {Tag = new Tag("0040A492")}; }
        }

        public static CodeString VerificationFlag
        {
            get { return new CodeString {Tag = new Tag("0040A493")}; }
        }

        public static CodeString ArchiveRequested
        {
            get { return new CodeString {Tag = new Tag("0040A494")}; }
        }

        public static CodeString PreliminaryFlag
        {
            get { return new CodeString {Tag = new Tag("0040A496")}; }
        }

        public static Sequence ContentTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("0040A504")}; }
        }

        public static Sequence IdenticalDocumentsSequence
        {
            get { return new Sequence {Tag = new Tag("0040A525")}; }
        }

        public static CodeString ObservationSubjectContextFlagTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A600")}; }
        }

        public static CodeString ObserverContextFlagTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A601")}; }
        }

        public static CodeString ProcedureContextFlagTrialRetired
        {
            get { return new CodeString {Tag = new Tag("0040A603")}; }
        }

        public static Sequence ContentSequence
        {
            get { return new Sequence {Tag = new Tag("0040A730")}; }
        }

        public static Sequence RelationshipSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A731")}; }
        }

        public static Sequence RelationshipTypeCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A732")}; }
        }

        public static Sequence LanguageCodeSequenceTrialRetired
        {
            get { return new Sequence {Tag = new Tag("0040A744")}; }
        }

        public static ShortText UniformResourceLocatorTrialRetired
        {
            get { return new ShortText {Tag = new Tag("0040A992")}; }
        }

        public static Sequence WaveformAnnotationSequence
        {
            get { return new Sequence {Tag = new Tag("0040B020")}; }
        }

        public static CodeString TemplateIdentifier
        {
            get { return new CodeString {Tag = new Tag("0040DB00")}; }
        }

        public static CodeString TemplateExtensionFlagRetired
        {
            get { return new CodeString {Tag = new Tag("0040DB0B")}; }
        }

        public static UniqueIdentifier TemplateExtensionOrganizationUIDRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040DB0C")}; }
        }

        public static UniqueIdentifier TemplateExtensionCreatorUIDRetired
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040DB0D")}; }
        }

        public static UnsignedLong ReferencedContentItemIdentifier
        {
            get { return new UnsignedLong {Tag = new Tag("0040DB73")}; }
        }

        public static ShortText HL7InstanceIdentifier
        {
            get { return new ShortText {Tag = new Tag("0040E001")}; }
        }

        public static Sequence HL7DocumentTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040E006")}; }
        }

        public static Sequence DocumentClassCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0040E008")}; }
        }

        public static UnlimitedText RetrieveURI
        {
            get { return new UnlimitedText {Tag = new Tag("0040E010")}; }
        }

        public static UniqueIdentifier RetrieveLocationUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040E011")}; }
        }

        public static CodeString TypeOfInstances
        {
            get { return new CodeString {Tag = new Tag("0040E020")}; }
        }

        public static Sequence DICOMRetrievalSequence
        {
            get { return new Sequence {Tag = new Tag("0040E021")}; }
        }

        public static Sequence DICOMMediaRetrievalSequence
        {
            get { return new Sequence {Tag = new Tag("0040E022")}; }
        }

        public static Sequence WADORetrievalSequence
        {
            get { return new Sequence {Tag = new Tag("0040E023")}; }
        }

        public static Sequence XDSRetrievalSequence
        {
            get { return new Sequence {Tag = new Tag("0040E024")}; }
        }

        public static UniqueIdentifier RepositoryUniqueID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040E030")}; }
        }

        public static UniqueIdentifier HomeCommunityID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0040E031")}; }
        }

        public static ShortText DocumentTitle
        {
            get { return new ShortText {Tag = new Tag("00420010")}; }
        }

        public static OtherByteString EncapsulatedDocument
        {
            get { return new OtherByteString {Tag = new Tag("00420011")}; }
        }

        public static LongString MIMETypeOfEncapsulatedDocument
        {
            get { return new LongString {Tag = new Tag("00420012")}; }
        }

        public static Sequence SourceInstanceSequence
        {
            get { return new Sequence {Tag = new Tag("00420013")}; }
        }

        public static LongString ListOfMIMETypes
        {
            get { return new LongString {Tag = new Tag("00420014")}; }
        }

        public static ShortText ProductPackageIdentifier
        {
            get { return new ShortText {Tag = new Tag("00440001")}; }
        }

        public static CodeString SubstanceAdministrationApproval
        {
            get { return new CodeString {Tag = new Tag("00440002")}; }
        }

        public static LongText ApprovalStatusFurtherDescription
        {
            get { return new LongText {Tag = new Tag("00440003")}; }
        }

        public static Sequence ProductTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00440007")}; }
        }

        public static LongString ProductName
        {
            get { return new LongString {Tag = new Tag("00440008")}; }
        }

        public static LongText ProductDescription
        {
            get { return new LongText {Tag = new Tag("00440009")}; }
        }

        public static LongString ProductLotIdentifier
        {
            get { return new LongString {Tag = new Tag("0044000A")}; }
        }

        public static LongString SubstanceAdministrationNotes
        {
            get { return new LongString {Tag = new Tag("00440011")}; }
        }

        public static LongString SubstanceAdministrationDeviceID
        {
            get { return new LongString {Tag = new Tag("00440012")}; }
        }

        public static Sequence ProductParameterSequence
        {
            get { return new Sequence {Tag = new Tag("00440013")}; }
        }

        public static Sequence SubstanceAdministrationParameterSequence
        {
            get { return new Sequence {Tag = new Tag("00440019")}; }
        }

        public static LongString LensDescription
        {
            get { return new LongString {Tag = new Tag("00460012")}; }
        }

        public static Sequence RightLensSequence
        {
            get { return new Sequence {Tag = new Tag("00460014")}; }
        }

        public static Sequence LeftLensSequence
        {
            get { return new Sequence {Tag = new Tag("00460015")}; }
        }

        public static Sequence UnspecifiedLateralityLensSequence
        {
            get { return new Sequence {Tag = new Tag("00460016")}; }
        }

        public static Sequence CylinderSequence
        {
            get { return new Sequence {Tag = new Tag("00460018")}; }
        }

        public static Sequence PrismSequence
        {
            get { return new Sequence {Tag = new Tag("00460028")}; }
        }

        public static FloatingPointDouble HorizontalPrismPower
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460030")}; }
        }

        public static CodeString HorizontalPrismBase
        {
            get { return new CodeString {Tag = new Tag("00460032")}; }
        }

        public static FloatingPointDouble VerticalPrismPower
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460034")}; }
        }

        public static CodeString VerticalPrismBase
        {
            get { return new CodeString {Tag = new Tag("00460036")}; }
        }

        public static CodeString LensSegmentType
        {
            get { return new CodeString {Tag = new Tag("00460038")}; }
        }

        public static FloatingPointDouble OpticalTransmittance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460040")}; }
        }

        public static FloatingPointDouble ChannelWidth
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460042")}; }
        }

        public static FloatingPointDouble PupilSize
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460044")}; }
        }

        public static FloatingPointDouble CornealSize
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460046")}; }
        }

        public static Sequence AutorefractionRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460050")}; }
        }

        public static Sequence AutorefractionLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460052")}; }
        }

        public static FloatingPointDouble DistancePupillaryDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460060")}; }
        }

        public static FloatingPointDouble NearPupillaryDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460062")}; }
        }

        public static FloatingPointDouble IntermediatePupillaryDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460063")}; }
        }

        public static FloatingPointDouble OtherPupillaryDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460064")}; }
        }

        public static Sequence KeratometryRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460070")}; }
        }

        public static Sequence KeratometryLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460071")}; }
        }

        public static Sequence SteepKeratometricAxisSequence
        {
            get { return new Sequence {Tag = new Tag("00460074")}; }
        }

        public static FloatingPointDouble RadiusOfCurvature
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460075")}; }
        }

        public static FloatingPointDouble KeratometricPower
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460076")}; }
        }

        public static FloatingPointDouble KeratometricAxis
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460077")}; }
        }

        public static Sequence FlatKeratometricAxisSequence
        {
            get { return new Sequence {Tag = new Tag("00460080")}; }
        }

        public static CodeString BackgroundColor
        {
            get { return new CodeString {Tag = new Tag("00460092")}; }
        }

        public static CodeString Optotype
        {
            get { return new CodeString {Tag = new Tag("00460094")}; }
        }

        public static CodeString OptotypePresentation
        {
            get { return new CodeString {Tag = new Tag("00460095")}; }
        }

        public static Sequence SubjectiveRefractionRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460097")}; }
        }

        public static Sequence SubjectiveRefractionLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460098")}; }
        }

        public static Sequence AddNearSequence
        {
            get { return new Sequence {Tag = new Tag("00460100")}; }
        }

        public static Sequence AddIntermediateSequence
        {
            get { return new Sequence {Tag = new Tag("00460101")}; }
        }

        public static Sequence AddOtherSequence
        {
            get { return new Sequence {Tag = new Tag("00460102")}; }
        }

        public static FloatingPointDouble AddPower
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460104")}; }
        }

        public static FloatingPointDouble ViewingDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460106")}; }
        }

        public static Sequence VisualAcuityTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00460121")}; }
        }

        public static Sequence VisualAcuityRightEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460122")}; }
        }

        public static Sequence VisualAcuityLeftEyeSequence
        {
            get { return new Sequence {Tag = new Tag("00460123")}; }
        }

        public static Sequence VisualAcuityBothEyesOpenSequence
        {
            get { return new Sequence {Tag = new Tag("00460124")}; }
        }

        public static CodeString ViewingDistanceType
        {
            get { return new CodeString {Tag = new Tag("00460125")}; }
        }

        public static SignedShort VisualAcuityModifiers
        {
            get { return new SignedShort {Tag = new Tag("00460135")}; }
        }

        public static FloatingPointDouble DecimalVisualAcuity
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460137")}; }
        }

        public static LongString OptotypeDetailedDefinition
        {
            get { return new LongString {Tag = new Tag("00460139")}; }
        }

        public static Sequence ReferencedRefractiveMeasurementsSequence
        {
            get { return new Sequence {Tag = new Tag("00460145")}; }
        }

        public static FloatingPointDouble SpherePower
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460146")}; }
        }

        public static FloatingPointDouble CylinderPower
        {
            get { return new FloatingPointDouble {Tag = new Tag("00460147")}; }
        }

        public static FloatingPointSingle ImagedVolumeWidth
        {
            get { return new FloatingPointSingle {Tag = new Tag("00480001")}; }
        }

        public static FloatingPointSingle ImagedVolumeHeight
        {
            get { return new FloatingPointSingle {Tag = new Tag("00480002")}; }
        }

        public static FloatingPointSingle ImagedVolumeDepth
        {
            get { return new FloatingPointSingle {Tag = new Tag("00480003")}; }
        }

        public static UnsignedLong TotalPixelMatrixColumns
        {
            get { return new UnsignedLong {Tag = new Tag("00480006")}; }
        }

        public static UnsignedLong TotalPixelMatrixRows
        {
            get { return new UnsignedLong {Tag = new Tag("00480007")}; }
        }

        public static Sequence TotalPixelMatrixOriginSequence
        {
            get { return new Sequence {Tag = new Tag("00480008")}; }
        }

        public static CodeString SpecimenLabelInImage
        {
            get { return new CodeString {Tag = new Tag("00480010")}; }
        }

        public static CodeString FocusMethod
        {
            get { return new CodeString {Tag = new Tag("00480011")}; }
        }

        public static CodeString ExtendedDepthOfField
        {
            get { return new CodeString {Tag = new Tag("00480012")}; }
        }

        public static UnsignedShort NumberOfFocalPlanes
        {
            get { return new UnsignedShort {Tag = new Tag("00480013")}; }
        }

        public static FloatingPointSingle DistanceBetweenFocalPlanes
        {
            get { return new FloatingPointSingle {Tag = new Tag("00480014")}; }
        }

        public static UnsignedShort RecommendedAbsentPixelCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00480015")}; }
        }

        public static Sequence IlluminatorTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00480100")}; }
        }

        public static DecimalString ImageOrientationSlide
        {
            get { return new DecimalString {Tag = new Tag("00480102")}; }
        }

        public static Sequence OpticalPathSequence
        {
            get { return new Sequence {Tag = new Tag("00480105")}; }
        }

        public static ShortString OpticalPathIdentifier
        {
            get { return new ShortString {Tag = new Tag("00480106")}; }
        }

        public static ShortText OpticalPathDescription
        {
            get { return new ShortText {Tag = new Tag("00480107")}; }
        }

        public static Sequence IlluminationColorCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00480108")}; }
        }

        public static Sequence SpecimenReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("00480110")}; }
        }

        public static DecimalString CondenserLensPower
        {
            get { return new DecimalString {Tag = new Tag("00480111")}; }
        }

        public static DecimalString ObjectiveLensPower
        {
            get { return new DecimalString {Tag = new Tag("00480112")}; }
        }

        public static DecimalString ObjectiveLensNumericalAperture
        {
            get { return new DecimalString {Tag = new Tag("00480113")}; }
        }

        public static Sequence PaletteColorLookupTableSequence
        {
            get { return new Sequence {Tag = new Tag("00480120")}; }
        }

        public static Sequence ReferencedImageNavigationSequence
        {
            get { return new Sequence {Tag = new Tag("00480200")}; }
        }

        public static UnsignedShort TopLeftHandCornerOfLocalizerArea
        {
            get { return new UnsignedShort {Tag = new Tag("00480201")}; }
        }

        public static UnsignedShort BottomRightHandCornerOfLocalizerArea
        {
            get { return new UnsignedShort {Tag = new Tag("00480202")}; }
        }

        public static Sequence OpticalPathIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00480207")}; }
        }

        public static Sequence PlanePositionSlideSequence
        {
            get { return new Sequence {Tag = new Tag("0048021A")}; }
        }

        public static SignedLong RowPositionInTotalImagePixelMatrix
        {
            get { return new SignedLong {Tag = new Tag("0048021E")}; }
        }

        public static SignedLong ColumnPositionInTotalImagePixelMatrix
        {
            get { return new SignedLong {Tag = new Tag("0048021F")}; }
        }

        public static CodeString PixelOriginInterpretation
        {
            get { return new CodeString {Tag = new Tag("00480301")}; }
        }

        public static CodeString CalibrationImage
        {
            get { return new CodeString {Tag = new Tag("00500004")}; }
        }

        public static Sequence DeviceSequence
        {
            get { return new Sequence {Tag = new Tag("00500010")}; }
        }

        public static Sequence ContainerComponentTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00500012")}; }
        }

        public static FloatingPointDouble ContainerComponentThickness
        {
            get { return new FloatingPointDouble {Tag = new Tag("00500013")}; }
        }

        public static DecimalString DeviceLength
        {
            get { return new DecimalString {Tag = new Tag("00500014")}; }
        }

        public static FloatingPointDouble ContainerComponentWidth
        {
            get { return new FloatingPointDouble {Tag = new Tag("00500015")}; }
        }

        public static DecimalString DeviceDiameter
        {
            get { return new DecimalString {Tag = new Tag("00500016")}; }
        }

        public static CodeString DeviceDiameterUnits
        {
            get { return new CodeString {Tag = new Tag("00500017")}; }
        }

        public static DecimalString DeviceVolume
        {
            get { return new DecimalString {Tag = new Tag("00500018")}; }
        }

        public static DecimalString InterMarkerDistance
        {
            get { return new DecimalString {Tag = new Tag("00500019")}; }
        }

        public static CodeString ContainerComponentMaterial
        {
            get { return new CodeString {Tag = new Tag("0050001A")}; }
        }

        public static LongString ContainerComponentID
        {
            get { return new LongString {Tag = new Tag("0050001B")}; }
        }

        public static FloatingPointDouble ContainerComponentLength
        {
            get { return new FloatingPointDouble {Tag = new Tag("0050001C")}; }
        }

        public static FloatingPointDouble ContainerComponentDiameter
        {
            get { return new FloatingPointDouble {Tag = new Tag("0050001D")}; }
        }

        public static LongString ContainerComponentDescription
        {
            get { return new LongString {Tag = new Tag("0050001E")}; }
        }

        public static LongString DeviceDescription
        {
            get { return new LongString {Tag = new Tag("00500020")}; }
        }

        public static FloatingPointSingle ContrastBolusIngredientPercentByVolume
        {
            get { return new FloatingPointSingle {Tag = new Tag("00520001")}; }
        }

        public static FloatingPointDouble OCTFocalDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520002")}; }
        }

        public static FloatingPointDouble BeamSpotSize
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520003")}; }
        }

        public static FloatingPointDouble EffectiveRefractiveIndex
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520004")}; }
        }

        public static CodeString OCTAcquisitionDomain
        {
            get { return new CodeString {Tag = new Tag("00520006")}; }
        }

        public static FloatingPointDouble OCTOpticalCenterWavelength
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520007")}; }
        }

        public static FloatingPointDouble AxialResolution
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520008")}; }
        }

        public static FloatingPointDouble RangingDepth
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520009")}; }
        }

        public static FloatingPointDouble ALineRate
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520011")}; }
        }

        public static UnsignedShort ALinesPerFrame
        {
            get { return new UnsignedShort {Tag = new Tag("00520012")}; }
        }

        public static FloatingPointDouble CatheterRotationalRate
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520013")}; }
        }

        public static FloatingPointDouble ALinePixelSpacing
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520014")}; }
        }

        public static Sequence ModeOfPercutaneousAccessSequence
        {
            get { return new Sequence {Tag = new Tag("00520016")}; }
        }

        public static Sequence IntravascularOCTFrameTypeSequence
        {
            get { return new Sequence {Tag = new Tag("00520025")}; }
        }

        public static CodeString OCTZOffsetApplied
        {
            get { return new CodeString {Tag = new Tag("00520026")}; }
        }

        public static Sequence IntravascularFrameContentSequence
        {
            get { return new Sequence {Tag = new Tag("00520027")}; }
        }

        public static FloatingPointDouble IntravascularLongitudinalDistance
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520028")}; }
        }

        public static Sequence IntravascularOCTFrameContentSequence
        {
            get { return new Sequence {Tag = new Tag("00520029")}; }
        }

        public static SignedShort OCTZOffsetCorrection
        {
            get { return new SignedShort {Tag = new Tag("00520030")}; }
        }

        public static CodeString CatheterDirectionOfRotation
        {
            get { return new CodeString {Tag = new Tag("00520031")}; }
        }

        public static FloatingPointDouble SeamLineLocation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520033")}; }
        }

        public static FloatingPointDouble FirstALineLocation
        {
            get { return new FloatingPointDouble {Tag = new Tag("00520034")}; }
        }

        public static UnsignedShort SeamLineIndex
        {
            get { return new UnsignedShort {Tag = new Tag("00520036")}; }
        }

        public static UnsignedShort NumberOfPaddedAlines
        {
            get { return new UnsignedShort {Tag = new Tag("00520038")}; }
        }

        public static CodeString InterpolationType
        {
            get { return new CodeString {Tag = new Tag("00520039")}; }
        }

        public static CodeString RefractiveIndexApplied
        {
            get { return new CodeString {Tag = new Tag("0052003A")}; }
        }

        public static UnsignedShort NumberOfEnergyWindows
        {
            get { return new UnsignedShort {Tag = new Tag("00540011")}; }
        }

        public static Sequence EnergyWindowInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540012")}; }
        }

        public static Sequence EnergyWindowRangeSequence
        {
            get { return new Sequence {Tag = new Tag("00540013")}; }
        }

        public static DecimalString EnergyWindowLowerLimit
        {
            get { return new DecimalString {Tag = new Tag("00540014")}; }
        }

        public static DecimalString EnergyWindowUpperLimit
        {
            get { return new DecimalString {Tag = new Tag("00540015")}; }
        }

        public static Sequence RadiopharmaceuticalInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540016")}; }
        }

        public static IntegerString ResidualSyringeCounts
        {
            get { return new IntegerString {Tag = new Tag("00540017")}; }
        }

        public static ShortString EnergyWindowName
        {
            get { return new ShortString {Tag = new Tag("00540018")}; }
        }

        public static UnsignedShort DetectorVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540020")}; }
        }

        public static UnsignedShort NumberOfDetectors
        {
            get { return new UnsignedShort {Tag = new Tag("00540021")}; }
        }

        public static Sequence DetectorInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540022")}; }
        }

        public static UnsignedShort PhaseVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540030")}; }
        }

        public static UnsignedShort NumberOfPhases
        {
            get { return new UnsignedShort {Tag = new Tag("00540031")}; }
        }

        public static Sequence PhaseInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540032")}; }
        }

        public static UnsignedShort NumberOfFramesInPhase
        {
            get { return new UnsignedShort {Tag = new Tag("00540033")}; }
        }

        public static IntegerString PhaseDelay
        {
            get { return new IntegerString {Tag = new Tag("00540036")}; }
        }

        public static IntegerString PauseBetweenFrames
        {
            get { return new IntegerString {Tag = new Tag("00540038")}; }
        }

        public static CodeString PhaseDescription
        {
            get { return new CodeString {Tag = new Tag("00540039")}; }
        }

        public static UnsignedShort RotationVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540050")}; }
        }

        public static UnsignedShort NumberOfRotations
        {
            get { return new UnsignedShort {Tag = new Tag("00540051")}; }
        }

        public static Sequence RotationInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540052")}; }
        }

        public static UnsignedShort NumberOfFramesInRotation
        {
            get { return new UnsignedShort {Tag = new Tag("00540053")}; }
        }

        public static UnsignedShort RRIntervalVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540060")}; }
        }

        public static UnsignedShort NumberOfRRIntervals
        {
            get { return new UnsignedShort {Tag = new Tag("00540061")}; }
        }

        public static Sequence GatedInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540062")}; }
        }

        public static Sequence DataInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540063")}; }
        }

        public static UnsignedShort TimeSlotVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540070")}; }
        }

        public static UnsignedShort NumberOfTimeSlots
        {
            get { return new UnsignedShort {Tag = new Tag("00540071")}; }
        }

        public static Sequence TimeSlotInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00540072")}; }
        }

        public static DecimalString TimeSlotTime
        {
            get { return new DecimalString {Tag = new Tag("00540073")}; }
        }

        public static UnsignedShort SliceVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540080")}; }
        }

        public static UnsignedShort NumberOfSlices
        {
            get { return new UnsignedShort {Tag = new Tag("00540081")}; }
        }

        public static UnsignedShort AngularViewVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540090")}; }
        }

        public static UnsignedShort TimeSliceVector
        {
            get { return new UnsignedShort {Tag = new Tag("00540100")}; }
        }

        public static UnsignedShort NumberOfTimeSlices
        {
            get { return new UnsignedShort {Tag = new Tag("00540101")}; }
        }

        public static DecimalString StartAngle
        {
            get { return new DecimalString {Tag = new Tag("00540200")}; }
        }

        public static CodeString TypeOfDetectorMotion
        {
            get { return new CodeString {Tag = new Tag("00540202")}; }
        }

        public static IntegerString TriggerVector
        {
            get { return new IntegerString {Tag = new Tag("00540210")}; }
        }

        public static UnsignedShort NumberOfTriggersInPhase
        {
            get { return new UnsignedShort {Tag = new Tag("00540211")}; }
        }

        public static Sequence ViewCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540220")}; }
        }

        public static Sequence ViewModifierCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540222")}; }
        }

        public static Sequence RadionuclideCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540300")}; }
        }

        public static Sequence AdministrationRouteCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540302")}; }
        }

        public static Sequence RadiopharmaceuticalCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540304")}; }
        }

        public static Sequence CalibrationDataSequence
        {
            get { return new Sequence {Tag = new Tag("00540306")}; }
        }

        public static UnsignedShort EnergyWindowNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00540308")}; }
        }

        public static ShortString ImageID
        {
            get { return new ShortString {Tag = new Tag("00540400")}; }
        }

        public static Sequence PatientOrientationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540410")}; }
        }

        public static Sequence PatientOrientationModifierCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540412")}; }
        }

        public static Sequence PatientGantryRelationshipCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00540414")}; }
        }

        public static CodeString SliceProgressionDirection
        {
            get { return new CodeString {Tag = new Tag("00540500")}; }
        }

        public static CodeString SeriesType
        {
            get { return new CodeString {Tag = new Tag("00541000")}; }
        }

        public static CodeString Units
        {
            get { return new CodeString {Tag = new Tag("00541001")}; }
        }

        public static CodeString CountsSource
        {
            get { return new CodeString {Tag = new Tag("00541002")}; }
        }

        public static CodeString ReprojectionMethod
        {
            get { return new CodeString {Tag = new Tag("00541004")}; }
        }

        public static CodeString SUVType
        {
            get { return new CodeString {Tag = new Tag("00541006")}; }
        }

        public static CodeString RandomsCorrectionMethod
        {
            get { return new CodeString {Tag = new Tag("00541100")}; }
        }

        public static LongString AttenuationCorrectionMethod
        {
            get { return new LongString {Tag = new Tag("00541101")}; }
        }

        public static CodeString DecayCorrection
        {
            get { return new CodeString {Tag = new Tag("00541102")}; }
        }

        public static LongString ReconstructionMethod
        {
            get { return new LongString {Tag = new Tag("00541103")}; }
        }

        public static LongString DetectorLinesOfResponseUsed
        {
            get { return new LongString {Tag = new Tag("00541104")}; }
        }

        public static LongString ScatterCorrectionMethod
        {
            get { return new LongString {Tag = new Tag("00541105")}; }
        }

        public static DecimalString AxialAcceptance
        {
            get { return new DecimalString {Tag = new Tag("00541200")}; }
        }

        public static IntegerString AxialMash
        {
            get { return new IntegerString {Tag = new Tag("00541201")}; }
        }

        public static IntegerString TransverseMash
        {
            get { return new IntegerString {Tag = new Tag("00541202")}; }
        }

        public static DecimalString DetectorElementSize
        {
            get { return new DecimalString {Tag = new Tag("00541203")}; }
        }

        public static DecimalString CoincidenceWindowWidth
        {
            get { return new DecimalString {Tag = new Tag("00541210")}; }
        }

        public static CodeString SecondaryCountsType
        {
            get { return new CodeString {Tag = new Tag("00541220")}; }
        }

        public static DecimalString FrameReferenceTime
        {
            get { return new DecimalString {Tag = new Tag("00541300")}; }
        }

        public static IntegerString PrimaryPromptsCountsAccumulated
        {
            get { return new IntegerString {Tag = new Tag("00541310")}; }
        }

        public static IntegerString SecondaryCountsAccumulated
        {
            get { return new IntegerString {Tag = new Tag("00541311")}; }
        }

        public static DecimalString SliceSensitivityFactor
        {
            get { return new DecimalString {Tag = new Tag("00541320")}; }
        }

        public static DecimalString DecayFactor
        {
            get { return new DecimalString {Tag = new Tag("00541321")}; }
        }

        public static DecimalString DoseCalibrationFactor
        {
            get { return new DecimalString {Tag = new Tag("00541322")}; }
        }

        public static DecimalString ScatterFractionFactor
        {
            get { return new DecimalString {Tag = new Tag("00541323")}; }
        }

        public static DecimalString DeadTimeFactor
        {
            get { return new DecimalString {Tag = new Tag("00541324")}; }
        }

        public static UnsignedShort ImageIndex
        {
            get { return new UnsignedShort {Tag = new Tag("00541330")}; }
        }

        public static CodeString CountsIncludedRetired
        {
            get { return new CodeString {Tag = new Tag("00541400")}; }
        }

        public static CodeString DeadTimeCorrectionFlagRetired
        {
            get { return new CodeString {Tag = new Tag("00541401")}; }
        }

        public static Sequence HistogramSequence
        {
            get { return new Sequence {Tag = new Tag("00603000")}; }
        }

        public static UnsignedShort HistogramNumberOfBins
        {
            get { return new UnsignedShort {Tag = new Tag("00603002")}; }
        }

        public static UnsignedShort HistogramFirstBinValue
        {
            get { return new UnsignedShort {Tag = new Tag("00603004")}; }
        }

        public static UnsignedShort HistogramLastBinValue
        {
            get { return new UnsignedShort {Tag = new Tag("00603006")}; }
        }

        public static UnsignedShort HistogramBinWidth
        {
            get { return new UnsignedShort {Tag = new Tag("00603008")}; }
        }

        public static LongString HistogramExplanation
        {
            get { return new LongString {Tag = new Tag("00603010")}; }
        }

        public static UnsignedLong HistogramData
        {
            get { return new UnsignedLong {Tag = new Tag("00603020")}; }
        }

        public static CodeString SegmentationType
        {
            get { return new CodeString {Tag = new Tag("00620001")}; }
        }

        public static Sequence SegmentSequence
        {
            get { return new Sequence {Tag = new Tag("00620002")}; }
        }

        public static Sequence SegmentedPropertyCategoryCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00620003")}; }
        }

        public static UnsignedShort SegmentNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00620004")}; }
        }

        public static LongString SegmentLabel
        {
            get { return new LongString {Tag = new Tag("00620005")}; }
        }

        public static ShortText SegmentDescription
        {
            get { return new ShortText {Tag = new Tag("00620006")}; }
        }

        public static CodeString SegmentAlgorithmType
        {
            get { return new CodeString {Tag = new Tag("00620008")}; }
        }

        public static LongString SegmentAlgorithmName
        {
            get { return new LongString {Tag = new Tag("00620009")}; }
        }

        public static Sequence SegmentIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("0062000A")}; }
        }

        public static UnsignedShort ReferencedSegmentNumber
        {
            get { return new UnsignedShort {Tag = new Tag("0062000B")}; }
        }

        public static UnsignedShort RecommendedDisplayGrayscaleValue
        {
            get { return new UnsignedShort {Tag = new Tag("0062000C")}; }
        }

        public static UnsignedShort RecommendedDisplayCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("0062000D")}; }
        }

        public static UnsignedShort MaximumFractionalValue
        {
            get { return new UnsignedShort {Tag = new Tag("0062000E")}; }
        }

        public static Sequence SegmentedPropertyTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0062000F")}; }
        }

        public static CodeString SegmentationFractionalType
        {
            get { return new CodeString {Tag = new Tag("00620010")}; }
        }

        public static Sequence DeformableRegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("00640002")}; }
        }

        public static UniqueIdentifier SourceFrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00640003")}; }
        }

        public static Sequence DeformableRegistrationGridSequence
        {
            get { return new Sequence {Tag = new Tag("00640005")}; }
        }

        public static UnsignedLong GridDimensions
        {
            get { return new UnsignedLong {Tag = new Tag("00640007")}; }
        }

        public static FloatingPointDouble GridResolution
        {
            get { return new FloatingPointDouble {Tag = new Tag("00640008")}; }
        }

        public static OtherFloatString VectorGridData
        {
            get { return new OtherFloatString {Tag = new Tag("00640009")}; }
        }

        public static Sequence PreDeformationMatrixRegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("0064000F")}; }
        }

        public static Sequence PostDeformationMatrixRegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("00640010")}; }
        }

        public static UnsignedLong NumberOfSurfaces
        {
            get { return new UnsignedLong {Tag = new Tag("00660001")}; }
        }

        public static Sequence SurfaceSequence
        {
            get { return new Sequence {Tag = new Tag("00660002")}; }
        }

        public static UnsignedLong SurfaceNumber
        {
            get { return new UnsignedLong {Tag = new Tag("00660003")}; }
        }

        public static LongText SurfaceComments
        {
            get { return new LongText {Tag = new Tag("00660004")}; }
        }

        public static CodeString SurfaceProcessing
        {
            get { return new CodeString {Tag = new Tag("00660009")}; }
        }

        public static FloatingPointSingle SurfaceProcessingRatio
        {
            get { return new FloatingPointSingle {Tag = new Tag("0066000A")}; }
        }

        public static LongString SurfaceProcessingDescription
        {
            get { return new LongString {Tag = new Tag("0066000B")}; }
        }

        public static FloatingPointSingle RecommendedPresentationOpacity
        {
            get { return new FloatingPointSingle {Tag = new Tag("0066000C")}; }
        }

        public static CodeString RecommendedPresentationType
        {
            get { return new CodeString {Tag = new Tag("0066000D")}; }
        }

        public static CodeString FiniteVolume
        {
            get { return new CodeString {Tag = new Tag("0066000E")}; }
        }

        public static CodeString Manifold
        {
            get { return new CodeString {Tag = new Tag("00660010")}; }
        }

        public static Sequence SurfacePointsSequence
        {
            get { return new Sequence {Tag = new Tag("00660011")}; }
        }

        public static Sequence SurfacePointsNormalsSequence
        {
            get { return new Sequence {Tag = new Tag("00660012")}; }
        }

        public static Sequence SurfaceMeshPrimitivesSequence
        {
            get { return new Sequence {Tag = new Tag("00660013")}; }
        }

        public static UnsignedLong NumberOfSurfacePoints
        {
            get { return new UnsignedLong {Tag = new Tag("00660015")}; }
        }

        public static OtherFloatString PointCoordinatesData
        {
            get { return new OtherFloatString {Tag = new Tag("00660016")}; }
        }

        public static FloatingPointSingle PointPositionAccuracy
        {
            get { return new FloatingPointSingle {Tag = new Tag("00660017")}; }
        }

        public static FloatingPointSingle MeanPointDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("00660018")}; }
        }

        public static FloatingPointSingle MaximumPointDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("00660019")}; }
        }

        public static FloatingPointSingle PointsBoundingBoxCoordinates
        {
            get { return new FloatingPointSingle {Tag = new Tag("0066001A")}; }
        }

        public static FloatingPointSingle AxisOfRotation
        {
            get { return new FloatingPointSingle {Tag = new Tag("0066001B")}; }
        }

        public static FloatingPointSingle CenterOfRotation
        {
            get { return new FloatingPointSingle {Tag = new Tag("0066001C")}; }
        }

        public static UnsignedLong NumberOfVectors
        {
            get { return new UnsignedLong {Tag = new Tag("0066001E")}; }
        }

        public static UnsignedShort VectorDimensionality
        {
            get { return new UnsignedShort {Tag = new Tag("0066001F")}; }
        }

        public static FloatingPointSingle VectorAccuracy
        {
            get { return new FloatingPointSingle {Tag = new Tag("00660020")}; }
        }

        public static OtherFloatString VectorCoordinateData
        {
            get { return new OtherFloatString {Tag = new Tag("00660021")}; }
        }

        public static OtherWordString TrianglePointIndexList
        {
            get { return new OtherWordString {Tag = new Tag("00660023")}; }
        }

        public static OtherWordString EdgePointIndexList
        {
            get { return new OtherWordString {Tag = new Tag("00660024")}; }
        }

        public static OtherWordString VertexPointIndexList
        {
            get { return new OtherWordString {Tag = new Tag("00660025")}; }
        }

        public static Sequence TriangleStripSequence
        {
            get { return new Sequence {Tag = new Tag("00660026")}; }
        }

        public static Sequence TriangleFanSequence
        {
            get { return new Sequence {Tag = new Tag("00660027")}; }
        }

        public static Sequence LineSequence
        {
            get { return new Sequence {Tag = new Tag("00660028")}; }
        }

        public static OtherWordString PrimitivePointIndexList
        {
            get { return new OtherWordString {Tag = new Tag("00660029")}; }
        }

        public static UnsignedLong SurfaceCount
        {
            get { return new UnsignedLong {Tag = new Tag("0066002A")}; }
        }

        public static Sequence ReferencedSurfaceSequence
        {
            get { return new Sequence {Tag = new Tag("0066002B")}; }
        }

        public static UnsignedLong ReferencedSurfaceNumber
        {
            get { return new UnsignedLong {Tag = new Tag("0066002C")}; }
        }

        public static Sequence SegmentSurfaceGenerationAlgorithmIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("0066002D")}; }
        }

        public static Sequence SegmentSurfaceSourceInstanceSequence
        {
            get { return new Sequence {Tag = new Tag("0066002E")}; }
        }

        public static Sequence AlgorithmFamilyCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0066002F")}; }
        }

        public static Sequence AlgorithmNameCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00660030")}; }
        }

        public static LongString AlgorithmVersion
        {
            get { return new LongString {Tag = new Tag("00660031")}; }
        }

        public static LongText AlgorithmParameters
        {
            get { return new LongText {Tag = new Tag("00660032")}; }
        }

        public static Sequence FacetSequence
        {
            get { return new Sequence {Tag = new Tag("00660034")}; }
        }

        public static Sequence SurfaceProcessingAlgorithmIdentificationSequence
        {
            get { return new Sequence {Tag = new Tag("00660035")}; }
        }

        public static LongString AlgorithmName
        {
            get { return new LongString {Tag = new Tag("00660036")}; }
        }

        public static LongString ImplantSize
        {
            get { return new LongString {Tag = new Tag("00686210")}; }
        }

        public static LongString ImplantTemplateVersion
        {
            get { return new LongString {Tag = new Tag("00686221")}; }
        }

        public static Sequence ReplacedImplantTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("00686222")}; }
        }

        public static CodeString ImplantType
        {
            get { return new CodeString {Tag = new Tag("00686223")}; }
        }

        public static Sequence DerivationImplantTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("00686224")}; }
        }

        public static Sequence OriginalImplantTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("00686225")}; }
        }

        public static Sequence ImplantTargetAnatomySequence
        {
            get { return new Sequence {Tag = new Tag("00686230")}; }
        }

        public static Sequence InformationFromManufacturerSequence
        {
            get { return new Sequence {Tag = new Tag("00686260")}; }
        }

        public static Sequence NotificationFromManufacturerSequence
        {
            get { return new Sequence {Tag = new Tag("00686265")}; }
        }

        public static ShortText InformationSummary
        {
            get { return new ShortText {Tag = new Tag("00686280")}; }
        }

        public static Sequence ImplantRegulatoryDisapprovalCodeSequence
        {
            get { return new Sequence {Tag = new Tag("006862A0")}; }
        }

        public static FloatingPointDouble OverallTemplateSpatialTolerance
        {
            get { return new FloatingPointDouble {Tag = new Tag("006862A5")}; }
        }

        public static Sequence HPGLDocumentSequence
        {
            get { return new Sequence {Tag = new Tag("006862C0")}; }
        }

        public static UnsignedShort HPGLDocumentID
        {
            get { return new UnsignedShort {Tag = new Tag("006862D0")}; }
        }

        public static LongString HPGLDocumentLabel
        {
            get { return new LongString {Tag = new Tag("006862D5")}; }
        }

        public static Sequence ViewOrientationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("006862E0")}; }
        }

        public static FloatingPointDouble ViewOrientationModifier
        {
            get { return new FloatingPointDouble {Tag = new Tag("006862F0")}; }
        }

        public static FloatingPointDouble HPGLDocumentScaling
        {
            get { return new FloatingPointDouble {Tag = new Tag("006862F2")}; }
        }

        public static OtherByteString HPGLDocument
        {
            get { return new OtherByteString {Tag = new Tag("00686300")}; }
        }

        public static UnsignedShort HPGLContourPenNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00686310")}; }
        }

        public static Sequence HPGLPenSequence
        {
            get { return new Sequence {Tag = new Tag("00686320")}; }
        }

        public static UnsignedShort HPGLPenNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00686330")}; }
        }

        public static LongString HPGLPenLabel
        {
            get { return new LongString {Tag = new Tag("00686340")}; }
        }

        public static ShortText HPGLPenDescription
        {
            get { return new ShortText {Tag = new Tag("00686345")}; }
        }

        public static FloatingPointDouble RecommendedRotationPoint
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686346")}; }
        }

        public static FloatingPointDouble BoundingRectangle
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686347")}; }
        }

        public static UnsignedShort ImplantTemplate3DModelSurfaceNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00686350")}; }
        }

        public static Sequence SurfaceModelDescriptionSequence
        {
            get { return new Sequence {Tag = new Tag("00686360")}; }
        }

        public static LongString SurfaceModelLabel
        {
            get { return new LongString {Tag = new Tag("00686380")}; }
        }

        public static FloatingPointDouble SurfaceModelScalingFactor
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686390")}; }
        }

        public static Sequence MaterialsCodeSequence
        {
            get { return new Sequence {Tag = new Tag("006863A0")}; }
        }

        public static Sequence CoatingMaterialsCodeSequence
        {
            get { return new Sequence {Tag = new Tag("006863A4")}; }
        }

        public static Sequence ImplantTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("006863A8")}; }
        }

        public static Sequence FixationMethodCodeSequence
        {
            get { return new Sequence {Tag = new Tag("006863AC")}; }
        }

        public static Sequence MatingFeatureSetsSequence
        {
            get { return new Sequence {Tag = new Tag("006863B0")}; }
        }

        public static UnsignedShort MatingFeatureSetID
        {
            get { return new UnsignedShort {Tag = new Tag("006863C0")}; }
        }

        public static LongString MatingFeatureSetLabel
        {
            get { return new LongString {Tag = new Tag("006863D0")}; }
        }

        public static Sequence MatingFeatureSequence
        {
            get { return new Sequence {Tag = new Tag("006863E0")}; }
        }

        public static UnsignedShort MatingFeatureID
        {
            get { return new UnsignedShort {Tag = new Tag("006863F0")}; }
        }

        public static Sequence MatingFeatureDegreeOfFreedomSequence
        {
            get { return new Sequence {Tag = new Tag("00686400")}; }
        }

        public static UnsignedShort DegreeOfFreedomID
        {
            get { return new UnsignedShort {Tag = new Tag("00686410")}; }
        }

        public static CodeString DegreeOfFreedomType
        {
            get { return new CodeString {Tag = new Tag("00686420")}; }
        }

        public static Sequence TwoDMatingFeatureCoordinatesSequence
        {
            get { return new Sequence {Tag = new Tag("00686430")}; }
        }

        public static UnsignedShort ReferencedHPGLDocumentID
        {
            get { return new UnsignedShort {Tag = new Tag("00686440")}; }
        }

        public static FloatingPointDouble TwoDMatingPoint
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686450")}; }
        }

        public static FloatingPointDouble TwoDMatingAxes
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686460")}; }
        }

        public static Sequence TwoDDegreeOfFreedomSequence
        {
            get { return new Sequence {Tag = new Tag("00686470")}; }
        }

        public static FloatingPointDouble ThreeDDegreeOfFreedomAxis
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686490")}; }
        }

        public static FloatingPointDouble RangeOfFreedom
        {
            get { return new FloatingPointDouble {Tag = new Tag("006864A0")}; }
        }

        public static FloatingPointDouble ThreeDMatingPoint
        {
            get { return new FloatingPointDouble {Tag = new Tag("006864C0")}; }
        }

        public static FloatingPointDouble ThreeDMatingAxes
        {
            get { return new FloatingPointDouble {Tag = new Tag("006864D0")}; }
        }

        public static FloatingPointDouble TwoDDegreeOfFreedomAxis
        {
            get { return new FloatingPointDouble {Tag = new Tag("006864F0")}; }
        }

        public static Sequence PlanningLandmarkPointSequence
        {
            get { return new Sequence {Tag = new Tag("00686500")}; }
        }

        public static Sequence PlanningLandmarkLineSequence
        {
            get { return new Sequence {Tag = new Tag("00686510")}; }
        }

        public static Sequence PlanningLandmarkPlaneSequence
        {
            get { return new Sequence {Tag = new Tag("00686520")}; }
        }

        public static UnsignedShort PlanningLandmarkID
        {
            get { return new UnsignedShort {Tag = new Tag("00686530")}; }
        }

        public static LongString PlanningLandmarkDescription
        {
            get { return new LongString {Tag = new Tag("00686540")}; }
        }

        public static Sequence PlanningLandmarkIdentificationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00686545")}; }
        }

        public static Sequence TwoDPointCoordinatesSequence
        {
            get { return new Sequence {Tag = new Tag("00686550")}; }
        }

        public static FloatingPointDouble TwoDPointCoordinates
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686560")}; }
        }

        public static FloatingPointDouble ThreeDPointCoordinates
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686590")}; }
        }

        public static Sequence TwoDLineCoordinatesSequence
        {
            get { return new Sequence {Tag = new Tag("006865A0")}; }
        }

        public static FloatingPointDouble TwoDLineCoordinates
        {
            get { return new FloatingPointDouble {Tag = new Tag("006865B0")}; }
        }

        public static FloatingPointDouble ThreeDLineCoordinates
        {
            get { return new FloatingPointDouble {Tag = new Tag("006865D0")}; }
        }

        public static Sequence TwoDPlaneCoordinatesSequence
        {
            get { return new Sequence {Tag = new Tag("006865E0")}; }
        }

        public static FloatingPointDouble TwoDPlaneIntersection
        {
            get { return new FloatingPointDouble {Tag = new Tag("006865F0")}; }
        }

        public static FloatingPointDouble ThreeDPlaneOrigin
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686610")}; }
        }

        public static FloatingPointDouble ThreeDPlaneNormal
        {
            get { return new FloatingPointDouble {Tag = new Tag("00686620")}; }
        }

        public static Sequence GraphicAnnotationSequence
        {
            get { return new Sequence {Tag = new Tag("00700001")}; }
        }

        public static CodeString GraphicLayer
        {
            get { return new CodeString {Tag = new Tag("00700002")}; }
        }

        public static CodeString BoundingBoxAnnotationUnits
        {
            get { return new CodeString {Tag = new Tag("00700003")}; }
        }

        public static CodeString AnchorPointAnnotationUnits
        {
            get { return new CodeString {Tag = new Tag("00700004")}; }
        }

        public static CodeString GraphicAnnotationUnits
        {
            get { return new CodeString {Tag = new Tag("00700005")}; }
        }

        public static ShortText UnformattedTextValue
        {
            get { return new ShortText {Tag = new Tag("00700006")}; }
        }

        public static Sequence TextObjectSequence
        {
            get { return new Sequence {Tag = new Tag("00700008")}; }
        }

        public static Sequence GraphicObjectSequence
        {
            get { return new Sequence {Tag = new Tag("00700009")}; }
        }

        public static FloatingPointSingle BoundingBoxTopLeftHandCorner
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700010")}; }
        }

        public static FloatingPointSingle BoundingBoxBottomRightHandCorner
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700011")}; }
        }

        public static CodeString BoundingBoxTextHorizontalJustification
        {
            get { return new CodeString {Tag = new Tag("00700012")}; }
        }

        public static FloatingPointSingle AnchorPoint
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700014")}; }
        }

        public static CodeString AnchorPointVisibility
        {
            get { return new CodeString {Tag = new Tag("00700015")}; }
        }

        public static UnsignedShort GraphicDimensions
        {
            get { return new UnsignedShort {Tag = new Tag("00700020")}; }
        }

        public static UnsignedShort NumberOfGraphicPoints
        {
            get { return new UnsignedShort {Tag = new Tag("00700021")}; }
        }

        public static FloatingPointSingle GraphicData
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700022")}; }
        }

        public static CodeString GraphicType
        {
            get { return new CodeString {Tag = new Tag("00700023")}; }
        }

        public static CodeString GraphicFilled
        {
            get { return new CodeString {Tag = new Tag("00700024")}; }
        }

        public static IntegerString ImageRotationRetired
        {
            get { return new IntegerString {Tag = new Tag("00700040")}; }
        }

        public static CodeString ImageHorizontalFlip
        {
            get { return new CodeString {Tag = new Tag("00700041")}; }
        }

        public static UnsignedShort ImageRotation
        {
            get { return new UnsignedShort {Tag = new Tag("00700042")}; }
        }

        public static UnsignedShort DisplayedAreaTopLeftHandCornerTrialRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00700050")}; }
        }

        public static UnsignedShort DisplayedAreaBottomRightHandCornerTrialRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00700051")}; }
        }

        public static SignedLong DisplayedAreaTopLeftHandCorner
        {
            get { return new SignedLong {Tag = new Tag("00700052")}; }
        }

        public static SignedLong DisplayedAreaBottomRightHandCorner
        {
            get { return new SignedLong {Tag = new Tag("00700053")}; }
        }

        public static Sequence DisplayedAreaSelectionSequence
        {
            get { return new Sequence {Tag = new Tag("0070005A")}; }
        }

        public static Sequence GraphicLayerSequence
        {
            get { return new Sequence {Tag = new Tag("00700060")}; }
        }

        public static IntegerString GraphicLayerOrder
        {
            get { return new IntegerString {Tag = new Tag("00700062")}; }
        }

        public static UnsignedShort GraphicLayerRecommendedDisplayGrayscaleValue
        {
            get { return new UnsignedShort {Tag = new Tag("00700066")}; }
        }

        public static UnsignedShort GraphicLayerRecommendedDisplayRGBValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("00700067")}; }
        }

        public static LongString GraphicLayerDescription
        {
            get { return new LongString {Tag = new Tag("00700068")}; }
        }

        public static CodeString ContentLabel
        {
            get { return new CodeString {Tag = new Tag("00700080")}; }
        }

        public static LongString ContentDescription
        {
            get { return new LongString {Tag = new Tag("00700081")}; }
        }

        public static Date PresentationCreationDate
        {
            get { return new Date {Tag = new Tag("00700082")}; }
        }

        public static Time PresentationCreationTime
        {
            get { return new Time {Tag = new Tag("00700083")}; }
        }

        public static PersonName ContentCreatorName
        {
            get { return new PersonName {Tag = new Tag("00700084")}; }
        }

        public static Sequence ContentCreatorIdentificationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00700086")}; }
        }

        public static Sequence AlternateContentDescriptionSequence
        {
            get { return new Sequence {Tag = new Tag("00700087")}; }
        }

        public static CodeString PresentationSizeMode
        {
            get { return new CodeString {Tag = new Tag("00700100")}; }
        }

        public static DecimalString PresentationPixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("00700101")}; }
        }

        public static IntegerString PresentationPixelAspectRatio
        {
            get { return new IntegerString {Tag = new Tag("00700102")}; }
        }

        public static FloatingPointSingle PresentationPixelMagnificationRatio
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700103")}; }
        }

        public static LongString GraphicGroupLabel
        {
            get { return new LongString {Tag = new Tag("00700207")}; }
        }

        public static ShortText GraphicGroupDescription
        {
            get { return new ShortText {Tag = new Tag("00700208")}; }
        }

        public static Sequence CompoundGraphicSequence
        {
            get { return new Sequence {Tag = new Tag("00700209")}; }
        }

        public static UnsignedLong CompoundGraphicInstanceID
        {
            get { return new UnsignedLong {Tag = new Tag("00700226")}; }
        }

        public static LongString FontName
        {
            get { return new LongString {Tag = new Tag("00700227")}; }
        }

        public static CodeString FontNameType
        {
            get { return new CodeString {Tag = new Tag("00700228")}; }
        }

        public static LongString CSSFontName
        {
            get { return new LongString {Tag = new Tag("00700229")}; }
        }

        public static FloatingPointDouble RotationAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("00700230")}; }
        }

        public static Sequence TextStyleSequence
        {
            get { return new Sequence {Tag = new Tag("00700231")}; }
        }

        public static Sequence LineStyleSequence
        {
            get { return new Sequence {Tag = new Tag("00700232")}; }
        }

        public static Sequence FillStyleSequence
        {
            get { return new Sequence {Tag = new Tag("00700233")}; }
        }

        public static Sequence GraphicGroupSequence
        {
            get { return new Sequence {Tag = new Tag("00700234")}; }
        }

        public static UnsignedShort TextColorCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00700241")}; }
        }

        public static CodeString HorizontalAlignment
        {
            get { return new CodeString {Tag = new Tag("00700242")}; }
        }

        public static CodeString VerticalAlignment
        {
            get { return new CodeString {Tag = new Tag("00700243")}; }
        }

        public static CodeString ShadowStyle
        {
            get { return new CodeString {Tag = new Tag("00700244")}; }
        }

        public static FloatingPointSingle ShadowOffsetX
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700245")}; }
        }

        public static FloatingPointSingle ShadowOffsetY
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700246")}; }
        }

        public static UnsignedShort ShadowColorCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00700247")}; }
        }

        public static CodeString Underlined
        {
            get { return new CodeString {Tag = new Tag("00700248")}; }
        }

        public static CodeString Bold
        {
            get { return new CodeString {Tag = new Tag("00700249")}; }
        }

        public static CodeString Italic
        {
            get { return new CodeString {Tag = new Tag("00700250")}; }
        }

        public static UnsignedShort PatternOnColorCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00700251")}; }
        }

        public static UnsignedShort PatternOffColorCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00700252")}; }
        }

        public static FloatingPointSingle LineThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700253")}; }
        }

        public static CodeString LineDashingStyle
        {
            get { return new CodeString {Tag = new Tag("00700254")}; }
        }

        public static UnsignedLong LinePattern
        {
            get { return new UnsignedLong {Tag = new Tag("00700255")}; }
        }

        public static OtherByteString FillPattern
        {
            get { return new OtherByteString {Tag = new Tag("00700256")}; }
        }

        public static CodeString FillMode
        {
            get { return new CodeString {Tag = new Tag("00700257")}; }
        }

        public static FloatingPointSingle ShadowOpacity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700258")}; }
        }

        public static FloatingPointSingle GapLength
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700261")}; }
        }

        public static FloatingPointSingle DiameterOfVisibility
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700262")}; }
        }

        public static FloatingPointSingle RotationPoint
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700273")}; }
        }

        public static CodeString TickAlignment
        {
            get { return new CodeString {Tag = new Tag("00700274")}; }
        }

        public static CodeString ShowTickLabel
        {
            get { return new CodeString {Tag = new Tag("00700278")}; }
        }

        public static CodeString TickLabelAlignment
        {
            get { return new CodeString {Tag = new Tag("00700279")}; }
        }

        public static CodeString CompoundGraphicUnits
        {
            get { return new CodeString {Tag = new Tag("00700282")}; }
        }

        public static FloatingPointSingle PatternOnOpacity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700284")}; }
        }

        public static FloatingPointSingle PatternOffOpacity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700285")}; }
        }

        public static Sequence MajorTicksSequence
        {
            get { return new Sequence {Tag = new Tag("00700287")}; }
        }

        public static FloatingPointSingle TickPosition
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700288")}; }
        }

        public static ShortString TickLabel
        {
            get { return new ShortString {Tag = new Tag("00700289")}; }
        }

        public static CodeString CompoundGraphicType
        {
            get { return new CodeString {Tag = new Tag("00700294")}; }
        }

        public static UnsignedLong GraphicGroupID
        {
            get { return new UnsignedLong {Tag = new Tag("00700295")}; }
        }

        public static CodeString ShapeType
        {
            get { return new CodeString {Tag = new Tag("00700306")}; }
        }

        public static Sequence RegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("00700308")}; }
        }

        public static Sequence MatrixRegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("00700309")}; }
        }

        public static Sequence MatrixSequence
        {
            get { return new Sequence {Tag = new Tag("0070030A")}; }
        }

        public static CodeString FrameOfReferenceTransformationMatrixType
        {
            get { return new CodeString {Tag = new Tag("0070030C")}; }
        }

        public static Sequence RegistrationTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0070030D")}; }
        }

        public static ShortText FiducialDescription
        {
            get { return new ShortText {Tag = new Tag("0070030F")}; }
        }

        public static ShortString FiducialIdentifier
        {
            get { return new ShortString {Tag = new Tag("00700310")}; }
        }

        public static Sequence FiducialIdentifierCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00700311")}; }
        }

        public static FloatingPointDouble ContourUncertaintyRadius
        {
            get { return new FloatingPointDouble {Tag = new Tag("00700312")}; }
        }

        public static Sequence UsedFiducialsSequence
        {
            get { return new Sequence {Tag = new Tag("00700314")}; }
        }

        public static Sequence GraphicCoordinatesDataSequence
        {
            get { return new Sequence {Tag = new Tag("00700318")}; }
        }

        public static UniqueIdentifier FiducialUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("0070031A")}; }
        }

        public static Sequence FiducialSetSequence
        {
            get { return new Sequence {Tag = new Tag("0070031C")}; }
        }

        public static Sequence FiducialSequence
        {
            get { return new Sequence {Tag = new Tag("0070031E")}; }
        }

        public static UnsignedShort GraphicLayerRecommendedDisplayCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00700401")}; }
        }

        public static Sequence BlendingSequence
        {
            get { return new Sequence {Tag = new Tag("00700402")}; }
        }

        public static FloatingPointSingle RelativeOpacity
        {
            get { return new FloatingPointSingle {Tag = new Tag("00700403")}; }
        }

        public static Sequence ReferencedSpatialRegistrationSequence
        {
            get { return new Sequence {Tag = new Tag("00700404")}; }
        }

        public static CodeString BlendingPosition
        {
            get { return new CodeString {Tag = new Tag("00700405")}; }
        }

        public static ShortString HangingProtocolName
        {
            get { return new ShortString {Tag = new Tag("00720002")}; }
        }

        public static LongString HangingProtocolDescription
        {
            get { return new LongString {Tag = new Tag("00720004")}; }
        }

        public static CodeString HangingProtocolLevel
        {
            get { return new CodeString {Tag = new Tag("00720006")}; }
        }

        public static LongString HangingProtocolCreator
        {
            get { return new LongString {Tag = new Tag("00720008")}; }
        }

        public static Sequence HangingProtocolDefinitionSequence
        {
            get { return new Sequence {Tag = new Tag("0072000C")}; }
        }

        public static Sequence HangingProtocolUserIdentificationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0072000E")}; }
        }

        public static LongString HangingProtocolUserGroupName
        {
            get { return new LongString {Tag = new Tag("00720010")}; }
        }

        public static Sequence SourceHangingProtocolSequence
        {
            get { return new Sequence {Tag = new Tag("00720012")}; }
        }

        public static UnsignedShort NumberOfPriorsReferenced
        {
            get { return new UnsignedShort {Tag = new Tag("00720014")}; }
        }

        public static Sequence ImageSetsSequence
        {
            get { return new Sequence {Tag = new Tag("00720020")}; }
        }

        public static Sequence ImageSetSelectorSequence
        {
            get { return new Sequence {Tag = new Tag("00720022")}; }
        }

        public static CodeString ImageSetSelectorUsageFlag
        {
            get { return new CodeString {Tag = new Tag("00720024")}; }
        }

        public static AttributeTag SelectorAttribute
        {
            get { return new AttributeTag {Tag = new Tag("00720026")}; }
        }

        public static UnsignedShort SelectorValueNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00720028")}; }
        }

        public static Sequence TimeBasedImageSetsSequence
        {
            get { return new Sequence {Tag = new Tag("00720030")}; }
        }

        public static UnsignedShort ImageSetNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00720032")}; }
        }

        public static CodeString ImageSetSelectorCategory
        {
            get { return new CodeString {Tag = new Tag("00720034")}; }
        }

        public static UnsignedShort RelativeTime
        {
            get { return new UnsignedShort {Tag = new Tag("00720038")}; }
        }

        public static CodeString RelativeTimeUnits
        {
            get { return new CodeString {Tag = new Tag("0072003A")}; }
        }

        public static SignedShort AbstractPriorValue
        {
            get { return new SignedShort {Tag = new Tag("0072003C")}; }
        }

        public static Sequence AbstractPriorCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0072003E")}; }
        }

        public static LongString ImageSetLabel
        {
            get { return new LongString {Tag = new Tag("00720040")}; }
        }

        public static CodeString SelectorAttributeVR
        {
            get { return new CodeString {Tag = new Tag("00720050")}; }
        }

        public static AttributeTag SelectorSequencePointer
        {
            get { return new AttributeTag {Tag = new Tag("00720052")}; }
        }

        public static LongString SelectorSequencePointerPrivateCreator
        {
            get { return new LongString {Tag = new Tag("00720054")}; }
        }

        public static LongString SelectorAttributePrivateCreator
        {
            get { return new LongString {Tag = new Tag("00720056")}; }
        }

        public static AttributeTag SelectorATValue
        {
            get { return new AttributeTag {Tag = new Tag("00720060")}; }
        }

        public static CodeString SelectorCSValue
        {
            get { return new CodeString {Tag = new Tag("00720062")}; }
        }

        public static IntegerString SelectorISValue
        {
            get { return new IntegerString {Tag = new Tag("00720064")}; }
        }

        public static LongString SelectorLOValue
        {
            get { return new LongString {Tag = new Tag("00720066")}; }
        }

        public static LongText SelectorLTValue
        {
            get { return new LongText {Tag = new Tag("00720068")}; }
        }

        public static PersonName SelectorPNValue
        {
            get { return new PersonName {Tag = new Tag("0072006A")}; }
        }

        public static ShortString SelectorSHValue
        {
            get { return new ShortString {Tag = new Tag("0072006C")}; }
        }

        public static ShortText SelectorSTValue
        {
            get { return new ShortText {Tag = new Tag("0072006E")}; }
        }

        public static UnlimitedText SelectorUTValue
        {
            get { return new UnlimitedText {Tag = new Tag("00720070")}; }
        }

        public static DecimalString SelectorDSValue
        {
            get { return new DecimalString {Tag = new Tag("00720072")}; }
        }

        public static FloatingPointDouble SelectorFDValue
        {
            get { return new FloatingPointDouble {Tag = new Tag("00720074")}; }
        }

        public static FloatingPointSingle SelectorFLValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("00720076")}; }
        }

        public static UnsignedLong SelectorULValue
        {
            get { return new UnsignedLong {Tag = new Tag("00720078")}; }
        }

        public static UnsignedShort SelectorUSValue
        {
            get { return new UnsignedShort {Tag = new Tag("0072007A")}; }
        }

        public static SignedLong SelectorSLValue
        {
            get { return new SignedLong {Tag = new Tag("0072007C")}; }
        }

        public static SignedShort SelectorSSValue
        {
            get { return new SignedShort {Tag = new Tag("0072007E")}; }
        }

        public static Sequence SelectorCodeSequenceValue
        {
            get { return new Sequence {Tag = new Tag("00720080")}; }
        }

        public static UnsignedShort NumberOfScreens
        {
            get { return new UnsignedShort {Tag = new Tag("00720100")}; }
        }

        public static Sequence NominalScreenDefinitionSequence
        {
            get { return new Sequence {Tag = new Tag("00720102")}; }
        }

        public static UnsignedShort NumberOfVerticalPixels
        {
            get { return new UnsignedShort {Tag = new Tag("00720104")}; }
        }

        public static UnsignedShort NumberOfHorizontalPixels
        {
            get { return new UnsignedShort {Tag = new Tag("00720106")}; }
        }

        public static FloatingPointDouble DisplayEnvironmentSpatialPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00720108")}; }
        }

        public static UnsignedShort ScreenMinimumGrayscaleBitDepth
        {
            get { return new UnsignedShort {Tag = new Tag("0072010A")}; }
        }

        public static UnsignedShort ScreenMinimumColorBitDepth
        {
            get { return new UnsignedShort {Tag = new Tag("0072010C")}; }
        }

        public static UnsignedShort ApplicationMaximumRepaintTime
        {
            get { return new UnsignedShort {Tag = new Tag("0072010E")}; }
        }

        public static Sequence DisplaySetsSequence
        {
            get { return new Sequence {Tag = new Tag("00720200")}; }
        }

        public static UnsignedShort DisplaySetNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00720202")}; }
        }

        public static LongString DisplaySetLabel
        {
            get { return new LongString {Tag = new Tag("00720203")}; }
        }

        public static UnsignedShort DisplaySetPresentationGroup
        {
            get { return new UnsignedShort {Tag = new Tag("00720204")}; }
        }

        public static LongString DisplaySetPresentationGroupDescription
        {
            get { return new LongString {Tag = new Tag("00720206")}; }
        }

        public static CodeString PartialDataDisplayHandling
        {
            get { return new CodeString {Tag = new Tag("00720208")}; }
        }

        public static Sequence SynchronizedScrollingSequence
        {
            get { return new Sequence {Tag = new Tag("00720210")}; }
        }

        public static UnsignedShort DisplaySetScrollingGroup
        {
            get { return new UnsignedShort {Tag = new Tag("00720212")}; }
        }

        public static Sequence NavigationIndicatorSequence
        {
            get { return new Sequence {Tag = new Tag("00720214")}; }
        }

        public static UnsignedShort NavigationDisplaySet
        {
            get { return new UnsignedShort {Tag = new Tag("00720216")}; }
        }

        public static UnsignedShort ReferenceDisplaySets
        {
            get { return new UnsignedShort {Tag = new Tag("00720218")}; }
        }

        public static Sequence ImageBoxesSequence
        {
            get { return new Sequence {Tag = new Tag("00720300")}; }
        }

        public static UnsignedShort ImageBoxNumber
        {
            get { return new UnsignedShort {Tag = new Tag("00720302")}; }
        }

        public static CodeString ImageBoxLayoutType
        {
            get { return new CodeString {Tag = new Tag("00720304")}; }
        }

        public static UnsignedShort ImageBoxTileHorizontalDimension
        {
            get { return new UnsignedShort {Tag = new Tag("00720306")}; }
        }

        public static UnsignedShort ImageBoxTileVerticalDimension
        {
            get { return new UnsignedShort {Tag = new Tag("00720308")}; }
        }

        public static CodeString ImageBoxScrollDirection
        {
            get { return new CodeString {Tag = new Tag("00720310")}; }
        }

        public static CodeString ImageBoxSmallScrollType
        {
            get { return new CodeString {Tag = new Tag("00720312")}; }
        }

        public static UnsignedShort ImageBoxSmallScrollAmount
        {
            get { return new UnsignedShort {Tag = new Tag("00720314")}; }
        }

        public static CodeString ImageBoxLargeScrollType
        {
            get { return new CodeString {Tag = new Tag("00720316")}; }
        }

        public static UnsignedShort ImageBoxLargeScrollAmount
        {
            get { return new UnsignedShort {Tag = new Tag("00720318")}; }
        }

        public static UnsignedShort ImageBoxOverlapPriority
        {
            get { return new UnsignedShort {Tag = new Tag("00720320")}; }
        }

        public static FloatingPointDouble CineRelativeToRealTime
        {
            get { return new FloatingPointDouble {Tag = new Tag("00720330")}; }
        }

        public static Sequence FilterOperationsSequence
        {
            get { return new Sequence {Tag = new Tag("00720400")}; }
        }

        public static CodeString FilterByCategory
        {
            get { return new CodeString {Tag = new Tag("00720402")}; }
        }

        public static CodeString FilterByAttributePresence
        {
            get { return new CodeString {Tag = new Tag("00720404")}; }
        }

        public static CodeString FilterByOperator
        {
            get { return new CodeString {Tag = new Tag("00720406")}; }
        }

        public static UnsignedShort StructuredDisplayBackgroundCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00720420")}; }
        }

        public static UnsignedShort EmptyImageBoxCIELabValue
        {
            get { return new UnsignedShort {Tag = new Tag("00720421")}; }
        }

        public static Sequence StructuredDisplayImageBoxSequence
        {
            get { return new Sequence {Tag = new Tag("00720422")}; }
        }

        public static Sequence StructuredDisplayTextBoxSequence
        {
            get { return new Sequence {Tag = new Tag("00720424")}; }
        }

        public static Sequence ReferencedFirstFrameSequence
        {
            get { return new Sequence {Tag = new Tag("00720427")}; }
        }

        public static Sequence ImageBoxSynchronizationSequence
        {
            get { return new Sequence {Tag = new Tag("00720430")}; }
        }

        public static UnsignedShort SynchronizedImageBoxList
        {
            get { return new UnsignedShort {Tag = new Tag("00720432")}; }
        }

        public static CodeString TypeOfSynchronization
        {
            get { return new CodeString {Tag = new Tag("00720434")}; }
        }

        public static CodeString BlendingOperationType
        {
            get { return new CodeString {Tag = new Tag("00720500")}; }
        }

        public static CodeString ReformattingOperationType
        {
            get { return new CodeString {Tag = new Tag("00720510")}; }
        }

        public static FloatingPointDouble ReformattingThickness
        {
            get { return new FloatingPointDouble {Tag = new Tag("00720512")}; }
        }

        public static FloatingPointDouble ReformattingInterval
        {
            get { return new FloatingPointDouble {Tag = new Tag("00720514")}; }
        }

        public static CodeString ReformattingOperationInitialViewDirection
        {
            get { return new CodeString {Tag = new Tag("00720516")}; }
        }

        public static CodeString ThreeDRenderingType
        {
            get { return new CodeString {Tag = new Tag("00720520")}; }
        }

        public static Sequence SortingOperationsSequence
        {
            get { return new Sequence {Tag = new Tag("00720600")}; }
        }

        public static CodeString SortByCategory
        {
            get { return new CodeString {Tag = new Tag("00720602")}; }
        }

        public static CodeString SortingDirection
        {
            get { return new CodeString {Tag = new Tag("00720604")}; }
        }

        public static CodeString DisplaySetPatientOrientation
        {
            get { return new CodeString {Tag = new Tag("00720700")}; }
        }

        public static CodeString VOIType
        {
            get { return new CodeString {Tag = new Tag("00720702")}; }
        }

        public static CodeString PseudoColorType
        {
            get { return new CodeString {Tag = new Tag("00720704")}; }
        }

        public static Sequence PseudoColorPaletteInstanceReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("00720705")}; }
        }

        public static CodeString ShowGrayscaleInverted
        {
            get { return new CodeString {Tag = new Tag("00720706")}; }
        }

        public static CodeString ShowImageTrueSizeFlag
        {
            get { return new CodeString {Tag = new Tag("00720710")}; }
        }

        public static CodeString ShowGraphicAnnotationFlag
        {
            get { return new CodeString {Tag = new Tag("00720712")}; }
        }

        public static CodeString ShowPatientDemographicsFlag
        {
            get { return new CodeString {Tag = new Tag("00720714")}; }
        }

        public static CodeString ShowAcquisitionTechniquesFlag
        {
            get { return new CodeString {Tag = new Tag("00720716")}; }
        }

        public static CodeString DisplaySetHorizontalJustification
        {
            get { return new CodeString {Tag = new Tag("00720717")}; }
        }

        public static CodeString DisplaySetVerticalJustification
        {
            get { return new CodeString {Tag = new Tag("00720718")}; }
        }

        public static FloatingPointDouble ContinuationStartMeterset
        {
            get { return new FloatingPointDouble {Tag = new Tag("00740120")}; }
        }

        public static FloatingPointDouble ContinuationEndMeterset
        {
            get { return new FloatingPointDouble {Tag = new Tag("00740121")}; }
        }

        public static CodeString ProcedureStepState
        {
            get { return new CodeString {Tag = new Tag("00741000")}; }
        }

        public static Sequence ProcedureStepProgressInformationSequence
        {
            get { return new Sequence {Tag = new Tag("00741002")}; }
        }

        public static DecimalString ProcedureStepProgress
        {
            get { return new DecimalString {Tag = new Tag("00741004")}; }
        }

        public static ShortText ProcedureStepProgressDescription
        {
            get { return new ShortText {Tag = new Tag("00741006")}; }
        }

        public static Sequence ProcedureStepCommunicationsURISequence
        {
            get { return new Sequence {Tag = new Tag("00741008")}; }
        }

        public static ShortText ContactURI
        {
            get { return new ShortText {Tag = new Tag("0074100a")}; }
        }

        public static LongString ContactDisplayName
        {
            get { return new LongString {Tag = new Tag("0074100c")}; }
        }

        public static Sequence ProcedureStepDiscontinuationReasonCodeSequence
        {
            get { return new Sequence {Tag = new Tag("0074100e")}; }
        }

        public static Sequence BeamTaskSequence
        {
            get { return new Sequence {Tag = new Tag("00741020")}; }
        }

        public static CodeString BeamTaskType
        {
            get { return new CodeString {Tag = new Tag("00741022")}; }
        }

        public static IntegerString BeamOrderIndexTrialRetired
        {
            get { return new IntegerString {Tag = new Tag("00741024")}; }
        }

        public static FloatingPointDouble TableTopVerticalAdjustedPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00741026")}; }
        }

        public static FloatingPointDouble TableTopLongitudinalAdjustedPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00741027")}; }
        }

        public static FloatingPointDouble TableTopLateralAdjustedPosition
        {
            get { return new FloatingPointDouble {Tag = new Tag("00741028")}; }
        }

        public static FloatingPointDouble PatientSupportAdjustedAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("0074102A")}; }
        }

        public static FloatingPointDouble TableTopEccentricAdjustedAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("0074102B")}; }
        }

        public static FloatingPointDouble TableTopPitchAdjustedAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("0074102C")}; }
        }

        public static FloatingPointDouble TableTopRollAdjustedAngle
        {
            get { return new FloatingPointDouble {Tag = new Tag("0074102D")}; }
        }

        public static Sequence DeliveryVerificationImageSequence
        {
            get { return new Sequence {Tag = new Tag("00741030")}; }
        }

        public static CodeString VerificationImageTiming
        {
            get { return new CodeString {Tag = new Tag("00741032")}; }
        }

        public static CodeString DoubleExposureFlag
        {
            get { return new CodeString {Tag = new Tag("00741034")}; }
        }

        public static CodeString DoubleExposureOrdering
        {
            get { return new CodeString {Tag = new Tag("00741036")}; }
        }

        public static DecimalString DoubleExposureMetersetTrialRetired
        {
            get { return new DecimalString {Tag = new Tag("00741038")}; }
        }

        public static DecimalString DoubleExposureFieldDeltaTrialRetired
        {
            get { return new DecimalString {Tag = new Tag("0074103A")}; }
        }

        public static Sequence RelatedReferenceRTImageSequence
        {
            get { return new Sequence {Tag = new Tag("00741040")}; }
        }

        public static Sequence GeneralMachineVerificationSequence
        {
            get { return new Sequence {Tag = new Tag("00741042")}; }
        }

        public static Sequence ConventionalMachineVerificationSequence
        {
            get { return new Sequence {Tag = new Tag("00741044")}; }
        }

        public static Sequence IonMachineVerificationSequence
        {
            get { return new Sequence {Tag = new Tag("00741046")}; }
        }

        public static Sequence FailedAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("00741048")}; }
        }

        public static Sequence OverriddenAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("0074104A")}; }
        }

        public static Sequence ConventionalControlPointVerificationSequence
        {
            get { return new Sequence {Tag = new Tag("0074104C")}; }
        }

        public static Sequence IonControlPointVerificationSequence
        {
            get { return new Sequence {Tag = new Tag("0074104E")}; }
        }

        public static Sequence AttributeOccurrenceSequence
        {
            get { return new Sequence {Tag = new Tag("00741050")}; }
        }

        public static AttributeTag AttributeOccurrencePointer
        {
            get { return new AttributeTag {Tag = new Tag("00741052")}; }
        }

        public static UnsignedLong AttributeItemSelector
        {
            get { return new UnsignedLong {Tag = new Tag("00741054")}; }
        }

        public static LongString AttributeOccurrencePrivateCreator
        {
            get { return new LongString {Tag = new Tag("00741056")}; }
        }

        public static IntegerString SelectorSequencePointerItems
        {
            get { return new IntegerString {Tag = new Tag("00741057")}; }
        }

        public static CodeString ScheduledProcedureStepPriority
        {
            get { return new CodeString {Tag = new Tag("00741200")}; }
        }

        public static LongString WorklistLabel
        {
            get { return new LongString {Tag = new Tag("00741202")}; }
        }

        public static LongString ProcedureStepLabel
        {
            get { return new LongString {Tag = new Tag("00741204")}; }
        }

        public static Sequence ScheduledProcessingParametersSequence
        {
            get { return new Sequence {Tag = new Tag("00741210")}; }
        }

        public static Sequence PerformedProcessingParametersSequence
        {
            get { return new Sequence {Tag = new Tag("00741212")}; }
        }

        public static Sequence UnifiedProcedureStepPerformedProcedureSequence
        {
            get { return new Sequence {Tag = new Tag("00741216")}; }
        }

        public static Sequence RelatedProcedureStepSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("00741220")}; }
        }

        public static LongString ProcedureStepRelationshipTypeRetired
        {
            get { return new LongString {Tag = new Tag("00741222")}; }
        }

        public static Sequence ReplacedProcedureStepSequence
        {
            get { return new Sequence {Tag = new Tag("00741224")}; }
        }

        public static LongString DeletionLock
        {
            get { return new LongString {Tag = new Tag("00741230")}; }
        }

        public static ApplicationEntity ReceivingAE
        {
            get { return new ApplicationEntity {Tag = new Tag("00741234")}; }
        }

        public static ApplicationEntity RequestingAE
        {
            get { return new ApplicationEntity {Tag = new Tag("00741236")}; }
        }

        public static LongText ReasonForCancellation
        {
            get { return new LongText {Tag = new Tag("00741238")}; }
        }

        public static CodeString SCPStatus
        {
            get { return new CodeString {Tag = new Tag("00741242")}; }
        }

        public static CodeString SubscriptionListStatus
        {
            get { return new CodeString {Tag = new Tag("00741244")}; }
        }

        public static CodeString UnifiedProcedureStepListStatus
        {
            get { return new CodeString {Tag = new Tag("00741246")}; }
        }

        public static UnsignedLong BeamOrderIndex
        {
            get { return new UnsignedLong {Tag = new Tag("00741324")}; }
        }

        public static FloatingPointDouble DoubleExposureMeterset
        {
            get { return new FloatingPointDouble {Tag = new Tag("00741338")}; }
        }

        public static FloatingPointDouble DoubleExposureFieldDelta
        {
            get { return new FloatingPointDouble {Tag = new Tag("0074133A")}; }
        }

        public static LongString ImplantAssemblyTemplateName
        {
            get { return new LongString {Tag = new Tag("00760001")}; }
        }

        public static LongString ImplantAssemblyTemplateIssuer
        {
            get { return new LongString {Tag = new Tag("00760003")}; }
        }

        public static LongString ImplantAssemblyTemplateVersion
        {
            get { return new LongString {Tag = new Tag("00760006")}; }
        }

        public static Sequence ReplacedImplantAssemblyTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("00760008")}; }
        }

        public static CodeString ImplantAssemblyTemplateType
        {
            get { return new CodeString {Tag = new Tag("0076000A")}; }
        }

        public static Sequence OriginalImplantAssemblyTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("0076000C")}; }
        }

        public static Sequence DerivationImplantAssemblyTemplateSequence
        {
            get { return new Sequence {Tag = new Tag("0076000E")}; }
        }

        public static Sequence ImplantAssemblyTemplateTargetAnatomySequence
        {
            get { return new Sequence {Tag = new Tag("00760010")}; }
        }

        public static Sequence ProcedureTypeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("00760020")}; }
        }

        public static LongString SurgicalTechnique
        {
            get { return new LongString {Tag = new Tag("00760030")}; }
        }

        public static Sequence ComponentTypesSequence
        {
            get { return new Sequence {Tag = new Tag("00760032")}; }
        }

        public static CodeString ComponentTypeCodeSequence
        {
            get { return new CodeString {Tag = new Tag("00760034")}; }
        }

        public static CodeString ExclusiveComponentType
        {
            get { return new CodeString {Tag = new Tag("00760036")}; }
        }

        public static CodeString MandatoryComponentType
        {
            get { return new CodeString {Tag = new Tag("00760038")}; }
        }

        public static Sequence ComponentSequence
        {
            get { return new Sequence {Tag = new Tag("00760040")}; }
        }

        public static UnsignedShort ComponentID
        {
            get { return new UnsignedShort {Tag = new Tag("00760055")}; }
        }

        public static Sequence ComponentAssemblySequence
        {
            get { return new Sequence {Tag = new Tag("00760060")}; }
        }

        public static UnsignedShort Component1ReferencedID
        {
            get { return new UnsignedShort {Tag = new Tag("00760070")}; }
        }

        public static UnsignedShort Component1ReferencedMatingFeatureSetID
        {
            get { return new UnsignedShort {Tag = new Tag("00760080")}; }
        }

        public static UnsignedShort Component1ReferencedMatingFeatureID
        {
            get { return new UnsignedShort {Tag = new Tag("00760090")}; }
        }

        public static UnsignedShort Component2ReferencedID
        {
            get { return new UnsignedShort {Tag = new Tag("007600A0")}; }
        }

        public static UnsignedShort Component2ReferencedMatingFeatureSetID
        {
            get { return new UnsignedShort {Tag = new Tag("007600B0")}; }
        }

        public static UnsignedShort Component2ReferencedMatingFeatureID
        {
            get { return new UnsignedShort {Tag = new Tag("007600C0")}; }
        }

        public static LongString ImplantTemplateGroupName
        {
            get { return new LongString {Tag = new Tag("00780001")}; }
        }

        public static ShortText ImplantTemplateGroupDescription
        {
            get { return new ShortText {Tag = new Tag("00780010")}; }
        }

        public static LongString ImplantTemplateGroupIssuer
        {
            get { return new LongString {Tag = new Tag("00780020")}; }
        }

        public static LongString ImplantTemplateGroupVersion
        {
            get { return new LongString {Tag = new Tag("00780024")}; }
        }

        public static Sequence ReplacedImplantTemplateGroupSequence
        {
            get { return new Sequence {Tag = new Tag("00780026")}; }
        }

        public static Sequence ImplantTemplateGroupTargetAnatomySequence
        {
            get { return new Sequence {Tag = new Tag("00780028")}; }
        }

        public static Sequence ImplantTemplateGroupMembersSequence
        {
            get { return new Sequence {Tag = new Tag("0078002A")}; }
        }

        public static UnsignedShort ImplantTemplateGroupMemberID
        {
            get { return new UnsignedShort {Tag = new Tag("0078002E")}; }
        }

        public static FloatingPointDouble ThreeDImplantTemplateGroupMemberMatchingPoint
        {
            get { return new FloatingPointDouble {Tag = new Tag("00780050")}; }
        }

        public static FloatingPointDouble ThreeDImplantTemplateGroupMemberMatchingAxes
        {
            get { return new FloatingPointDouble {Tag = new Tag("00780060")}; }
        }

        public static Sequence ImplantTemplateGroupMemberMatching2DCoordinatesSequence
        {
            get { return new Sequence {Tag = new Tag("00780070")}; }
        }

        public static FloatingPointDouble TwoDImplantTemplateGroupMemberMatchingPoint
        {
            get { return new FloatingPointDouble {Tag = new Tag("00780090")}; }
        }

        public static FloatingPointDouble TwoDImplantTemplateGroupMemberMatchingAxes
        {
            get { return new FloatingPointDouble {Tag = new Tag("007800A0")}; }
        }

        public static Sequence ImplantTemplateGroupVariationDimensionSequence
        {
            get { return new Sequence {Tag = new Tag("007800B0")}; }
        }

        public static LongString ImplantTemplateGroupVariationDimensionName
        {
            get { return new LongString {Tag = new Tag("007800B2")}; }
        }

        public static Sequence ImplantTemplateGroupVariationDimensionRankSequence
        {
            get { return new Sequence {Tag = new Tag("007800B4")}; }
        }

        public static UnsignedShort ReferencedImplantTemplateGroupMemberID
        {
            get { return new UnsignedShort {Tag = new Tag("007800B6")}; }
        }

        public static UnsignedShort ImplantTemplateGroupVariationDimensionRank
        {
            get { return new UnsignedShort {Tag = new Tag("007800B8")}; }
        }

        public static ShortString StorageMediaFileSetID
        {
            get { return new ShortString {Tag = new Tag("00880130")}; }
        }

        public static UniqueIdentifier StorageMediaFileSetUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("00880140")}; }
        }

        public static Sequence IconImageSequence
        {
            get { return new Sequence {Tag = new Tag("00880200")}; }
        }

        public static LongString TopicTitleRetired
        {
            get { return new LongString {Tag = new Tag("00880904")}; }
        }

        public static ShortText TopicSubjectRetired
        {
            get { return new ShortText {Tag = new Tag("00880906")}; }
        }

        public static LongString TopicAuthorRetired
        {
            get { return new LongString {Tag = new Tag("00880910")}; }
        }

        public static LongString TopicKeywordsRetired
        {
            get { return new LongString {Tag = new Tag("00880912")}; }
        }

        public static CodeString SOPInstanceStatus
        {
            get { return new CodeString {Tag = new Tag("01000410")}; }
        }

        public static LongText SOPAuthorizationComment
        {
            get { return new LongText {Tag = new Tag("01000424")}; }
        }

        public static LongString AuthorizationEquipmentCertificationNumber
        {
            get { return new LongString {Tag = new Tag("01000426")}; }
        }

        public static UnsignedShort MACIDNumber
        {
            get { return new UnsignedShort {Tag = new Tag("04000005")}; }
        }

        public static UniqueIdentifier MACCalculationTransferSyntaxUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("04000010")}; }
        }

        public static CodeString MACAlgorithm
        {
            get { return new CodeString {Tag = new Tag("04000015")}; }
        }

        public static AttributeTag DataElementsSigned
        {
            get { return new AttributeTag {Tag = new Tag("04000020")}; }
        }

        public static UniqueIdentifier DigitalSignatureUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("04000100")}; }
        }

        public static CodeString CertificateType
        {
            get { return new CodeString {Tag = new Tag("04000110")}; }
        }

        public static OtherByteString CertificateOfSigner
        {
            get { return new OtherByteString {Tag = new Tag("04000115")}; }
        }

        public static OtherByteString Signature
        {
            get { return new OtherByteString {Tag = new Tag("04000120")}; }
        }

        public static CodeString CertifiedTimestampType
        {
            get { return new CodeString {Tag = new Tag("04000305")}; }
        }

        public static OtherByteString CertifiedTimestamp
        {
            get { return new OtherByteString {Tag = new Tag("04000310")}; }
        }

        public static Sequence DigitalSignaturePurposeCodeSequence
        {
            get { return new Sequence {Tag = new Tag("04000401")}; }
        }

        public static Sequence ReferencedDigitalSignatureSequence
        {
            get { return new Sequence {Tag = new Tag("04000402")}; }
        }

        public static Sequence ReferencedSOPInstanceMACSequence
        {
            get { return new Sequence {Tag = new Tag("04000403")}; }
        }

        public static OtherByteString MAC
        {
            get { return new OtherByteString {Tag = new Tag("04000404")}; }
        }

        public static Sequence EncryptedAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("04000500")}; }
        }

        public static UniqueIdentifier EncryptedContentTransferSyntaxUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("04000510")}; }
        }

        public static OtherByteString EncryptedContent
        {
            get { return new OtherByteString {Tag = new Tag("04000520")}; }
        }

        public static Sequence ModifiedAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("04000550")}; }
        }

        public static Sequence OriginalAttributesSequence
        {
            get { return new Sequence {Tag = new Tag("04000561")}; }
        }

        public static LongString ModifyingSystem
        {
            get { return new LongString {Tag = new Tag("04000563")}; }
        }

        public static LongString SourceOfPreviousValues
        {
            get { return new LongString {Tag = new Tag("04000564")}; }
        }

        public static CodeString ReasonForTheAttributeModification
        {
            get { return new CodeString {Tag = new Tag("04000565")}; }
        }

        public static UnsignedShort EscapeTripletRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1000xxx0")}; }
        }

        public static UnsignedShort RunLengthTripletRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1000xxx1")}; }
        }

        public static UnsignedShort HuffmanTableSizeRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1000xxx2")}; }
        }

        public static UnsignedShort HuffmanTableTripletRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1000xxx3")}; }
        }

        public static UnsignedShort ShiftTableSizeRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1000xxx4")}; }
        }

        public static UnsignedShort ShiftTableTripletRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1000xxx5")}; }
        }

        public static UnsignedShort ZonalMapRetired
        {
            get { return new UnsignedShort {Tag = new Tag("1010xxxx")}; }
        }

        public static IntegerString NumberOfCopies
        {
            get { return new IntegerString {Tag = new Tag("20000010")}; }
        }

        public static Sequence PrinterConfigurationSequence
        {
            get { return new Sequence {Tag = new Tag("2000001E")}; }
        }

        public static CodeString PrintPriority
        {
            get { return new CodeString {Tag = new Tag("20000020")}; }
        }

        public static CodeString MediumType
        {
            get { return new CodeString {Tag = new Tag("20000030")}; }
        }

        public static CodeString FilmDestination
        {
            get { return new CodeString {Tag = new Tag("20000040")}; }
        }

        public static LongString FilmSessionLabel
        {
            get { return new LongString {Tag = new Tag("20000050")}; }
        }

        public static IntegerString MemoryAllocation
        {
            get { return new IntegerString {Tag = new Tag("20000060")}; }
        }

        public static IntegerString MaximumMemoryAllocation
        {
            get { return new IntegerString {Tag = new Tag("20000061")}; }
        }

        public static CodeString ColorImagePrintingFlagRetired
        {
            get { return new CodeString {Tag = new Tag("20000062")}; }
        }

        public static CodeString CollationFlagRetired
        {
            get { return new CodeString {Tag = new Tag("20000063")}; }
        }

        public static CodeString AnnotationFlagRetired
        {
            get { return new CodeString {Tag = new Tag("20000065")}; }
        }

        public static CodeString ImageOverlayFlagRetired
        {
            get { return new CodeString {Tag = new Tag("20000067")}; }
        }

        public static CodeString PresentationLUTFlagRetired
        {
            get { return new CodeString {Tag = new Tag("20000069")}; }
        }

        public static CodeString ImageBoxPresentationLUTFlagRetired
        {
            get { return new CodeString {Tag = new Tag("2000006A")}; }
        }

        public static UnsignedShort MemoryBitDepth
        {
            get { return new UnsignedShort {Tag = new Tag("200000A0")}; }
        }

        public static UnsignedShort PrintingBitDepth
        {
            get { return new UnsignedShort {Tag = new Tag("200000A1")}; }
        }

        public static Sequence MediaInstalledSequence
        {
            get { return new Sequence {Tag = new Tag("200000A2")}; }
        }

        public static Sequence OtherMediaAvailableSequence
        {
            get { return new Sequence {Tag = new Tag("200000A4")}; }
        }

        public static Sequence SupportedImageDisplayFormatsSequence
        {
            get { return new Sequence {Tag = new Tag("200000A8")}; }
        }

        public static Sequence ReferencedFilmBoxSequence
        {
            get { return new Sequence {Tag = new Tag("20000500")}; }
        }

        public static Sequence ReferencedStoredPrintSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("20000510")}; }
        }

        public static ShortText ImageDisplayFormat
        {
            get { return new ShortText {Tag = new Tag("20100010")}; }
        }

        public static CodeString AnnotationDisplayFormatID
        {
            get { return new CodeString {Tag = new Tag("20100030")}; }
        }

        public static CodeString FilmOrientation
        {
            get { return new CodeString {Tag = new Tag("20100040")}; }
        }

        public static CodeString FilmSizeID
        {
            get { return new CodeString {Tag = new Tag("20100050")}; }
        }

        public static CodeString PrinterResolutionID
        {
            get { return new CodeString {Tag = new Tag("20100052")}; }
        }

        public static CodeString DefaultPrinterResolutionID
        {
            get { return new CodeString {Tag = new Tag("20100054")}; }
        }

        public static CodeString MagnificationType
        {
            get { return new CodeString {Tag = new Tag("20100060")}; }
        }

        public static CodeString SmoothingType
        {
            get { return new CodeString {Tag = new Tag("20100080")}; }
        }

        public static CodeString DefaultMagnificationType
        {
            get { return new CodeString {Tag = new Tag("201000A6")}; }
        }

        public static CodeString OtherMagnificationTypesAvailable
        {
            get { return new CodeString {Tag = new Tag("201000A7")}; }
        }

        public static CodeString DefaultSmoothingType
        {
            get { return new CodeString {Tag = new Tag("201000A8")}; }
        }

        public static CodeString OtherSmoothingTypesAvailable
        {
            get { return new CodeString {Tag = new Tag("201000A9")}; }
        }

        public static CodeString BorderDensity
        {
            get { return new CodeString {Tag = new Tag("20100100")}; }
        }

        public static CodeString EmptyImageDensity
        {
            get { return new CodeString {Tag = new Tag("20100110")}; }
        }

        public static UnsignedShort MinDensity
        {
            get { return new UnsignedShort {Tag = new Tag("20100120")}; }
        }

        public static UnsignedShort MaxDensity
        {
            get { return new UnsignedShort {Tag = new Tag("20100130")}; }
        }

        public static CodeString Trim
        {
            get { return new CodeString {Tag = new Tag("20100140")}; }
        }

        public static ShortText ConfigurationInformation
        {
            get { return new ShortText {Tag = new Tag("20100150")}; }
        }

        public static LongText ConfigurationInformationDescription
        {
            get { return new LongText {Tag = new Tag("20100152")}; }
        }

        public static IntegerString MaximumCollatedFilms
        {
            get { return new IntegerString {Tag = new Tag("20100154")}; }
        }

        public static UnsignedShort Illumination
        {
            get { return new UnsignedShort {Tag = new Tag("2010015E")}; }
        }

        public static UnsignedShort ReflectedAmbientLight
        {
            get { return new UnsignedShort {Tag = new Tag("20100160")}; }
        }

        public static DecimalString PrinterPixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("20100376")}; }
        }

        public static Sequence ReferencedFilmSessionSequence
        {
            get { return new Sequence {Tag = new Tag("20100500")}; }
        }

        public static Sequence ReferencedImageBoxSequence
        {
            get { return new Sequence {Tag = new Tag("20100510")}; }
        }

        public static Sequence ReferencedBasicAnnotationBoxSequence
        {
            get { return new Sequence {Tag = new Tag("20100520")}; }
        }

        public static UnsignedShort ImageBoxPosition
        {
            get { return new UnsignedShort {Tag = new Tag("20200010")}; }
        }

        public static CodeString Polarity
        {
            get { return new CodeString {Tag = new Tag("20200020")}; }
        }

        public static DecimalString RequestedImageSize
        {
            get { return new DecimalString {Tag = new Tag("20200030")}; }
        }

        public static CodeString RequestedDecimateCropBehavior
        {
            get { return new CodeString {Tag = new Tag("20200040")}; }
        }

        public static CodeString RequestedResolutionID
        {
            get { return new CodeString {Tag = new Tag("20200050")}; }
        }

        public static CodeString RequestedImageSizeFlag
        {
            get { return new CodeString {Tag = new Tag("202000A0")}; }
        }

        public static CodeString DecimateCropResult
        {
            get { return new CodeString {Tag = new Tag("202000A2")}; }
        }

        public static Sequence BasicGrayscaleImageSequence
        {
            get { return new Sequence {Tag = new Tag("20200110")}; }
        }

        public static Sequence BasicColorImageSequence
        {
            get { return new Sequence {Tag = new Tag("20200111")}; }
        }

        public static Sequence ReferencedImageOverlayBoxSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("20200130")}; }
        }

        public static Sequence ReferencedVOILUTBoxSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("20200140")}; }
        }

        public static UnsignedShort AnnotationPosition
        {
            get { return new UnsignedShort {Tag = new Tag("20300010")}; }
        }

        public static LongString TextString
        {
            get { return new LongString {Tag = new Tag("20300020")}; }
        }

        public static Sequence ReferencedOverlayPlaneSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("20400010")}; }
        }

        public static UnsignedShort ReferencedOverlayPlaneGroupsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("20400011")}; }
        }

        public static Sequence OverlayPixelDataSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("20400020")}; }
        }

        public static CodeString OverlayMagnificationTypeRetired
        {
            get { return new CodeString {Tag = new Tag("20400060")}; }
        }

        public static CodeString OverlaySmoothingTypeRetired
        {
            get { return new CodeString {Tag = new Tag("20400070")}; }
        }

        public static CodeString OverlayOrImageMagnificationRetired
        {
            get { return new CodeString {Tag = new Tag("20400072")}; }
        }

        public static UnsignedShort MagnifyToNumberOfColumnsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("20400074")}; }
        }

        public static CodeString OverlayForegroundDensityRetired
        {
            get { return new CodeString {Tag = new Tag("20400080")}; }
        }

        public static CodeString OverlayBackgroundDensityRetired
        {
            get { return new CodeString {Tag = new Tag("20400082")}; }
        }

        public static CodeString OverlayModeRetired
        {
            get { return new CodeString {Tag = new Tag("20400090")}; }
        }

        public static CodeString ThresholdDensityRetired
        {
            get { return new CodeString {Tag = new Tag("20400100")}; }
        }

        public static Sequence ReferencedImageBoxSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("20400500")}; }
        }

        public static Sequence PresentationLUTSequence
        {
            get { return new Sequence {Tag = new Tag("20500010")}; }
        }

        public static CodeString PresentationLUTShape
        {
            get { return new CodeString {Tag = new Tag("20500020")}; }
        }

        public static Sequence ReferencedPresentationLUTSequence
        {
            get { return new Sequence {Tag = new Tag("20500500")}; }
        }

        public static ShortString PrintJobIDRetired
        {
            get { return new ShortString {Tag = new Tag("21000010")}; }
        }

        public static CodeString ExecutionStatus
        {
            get { return new CodeString {Tag = new Tag("21000020")}; }
        }

        public static CodeString ExecutionStatusInfo
        {
            get { return new CodeString {Tag = new Tag("21000030")}; }
        }

        public static Date CreationDate
        {
            get { return new Date {Tag = new Tag("21000040")}; }
        }

        public static Time CreationTime
        {
            get { return new Time {Tag = new Tag("21000050")}; }
        }

        public static ApplicationEntity Originator
        {
            get { return new ApplicationEntity {Tag = new Tag("21000070")}; }
        }

        public static ApplicationEntity DestinationAERetired
        {
            get { return new ApplicationEntity {Tag = new Tag("21000140")}; }
        }

        public static ShortString OwnerID
        {
            get { return new ShortString {Tag = new Tag("21000160")}; }
        }

        public static IntegerString NumberOfFilms
        {
            get { return new IntegerString {Tag = new Tag("21000170")}; }
        }

        public static Sequence ReferencedPrintJobSequencePullStoredPrintRetired
        {
            get { return new Sequence {Tag = new Tag("21000500")}; }
        }

        public static CodeString PrinterStatus
        {
            get { return new CodeString {Tag = new Tag("21100010")}; }
        }

        public static CodeString PrinterStatusInfo
        {
            get { return new CodeString {Tag = new Tag("21100020")}; }
        }

        public static LongString PrinterName
        {
            get { return new LongString {Tag = new Tag("21100030")}; }
        }

        public static ShortString PrintQueueIDRetired
        {
            get { return new ShortString {Tag = new Tag("21100099")}; }
        }

        public static CodeString QueueStatusRetired
        {
            get { return new CodeString {Tag = new Tag("21200010")}; }
        }

        public static Sequence PrintJobDescriptionSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21200050")}; }
        }

        public static Sequence ReferencedPrintJobSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21200070")}; }
        }

        public static Sequence PrintManagementCapabilitiesSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300010")}; }
        }

        public static Sequence PrinterCharacteristicsSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300015")}; }
        }

        public static Sequence FilmBoxContentSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300030")}; }
        }

        public static Sequence ImageBoxContentSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300040")}; }
        }

        public static Sequence AnnotationContentSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300050")}; }
        }

        public static Sequence ImageOverlayBoxContentSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300060")}; }
        }

        public static Sequence PresentationLUTContentSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("21300080")}; }
        }

        public static Sequence ProposedStudySequenceRetired
        {
            get { return new Sequence {Tag = new Tag("213000A0")}; }
        }

        public static Sequence OriginalImageSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("213000C0")}; }
        }

        public static CodeString LabelUsingInformationExtractedFromInstances
        {
            get { return new CodeString {Tag = new Tag("22000001")}; }
        }

        public static UnlimitedText LabelText
        {
            get { return new UnlimitedText {Tag = new Tag("22000002")}; }
        }

        public static CodeString LabelStyleSelection
        {
            get { return new CodeString {Tag = new Tag("22000003")}; }
        }

        public static LongText MediaDisposition
        {
            get { return new LongText {Tag = new Tag("22000004")}; }
        }

        public static LongText BarcodeValue
        {
            get { return new LongText {Tag = new Tag("22000005")}; }
        }

        public static CodeString BarcodeSymbology
        {
            get { return new CodeString {Tag = new Tag("22000006")}; }
        }

        public static CodeString AllowMediaSplitting
        {
            get { return new CodeString {Tag = new Tag("22000007")}; }
        }

        public static CodeString IncludeNonDICOMObjects
        {
            get { return new CodeString {Tag = new Tag("22000008")}; }
        }

        public static CodeString IncludeDisplayApplication
        {
            get { return new CodeString {Tag = new Tag("22000009")}; }
        }

        public static CodeString PreserveCompositeInstancesAfterMediaCreation
        {
            get { return new CodeString {Tag = new Tag("2200000A")}; }
        }

        public static UnsignedShort TotalNumberOfPiecesOfMediaCreated
        {
            get { return new UnsignedShort {Tag = new Tag("2200000B")}; }
        }

        public static LongString RequestedMediaApplicationProfile
        {
            get { return new LongString {Tag = new Tag("2200000C")}; }
        }

        public static Sequence ReferencedStorageMediaSequence
        {
            get { return new Sequence {Tag = new Tag("2200000D")}; }
        }

        public static AttributeTag FailureAttributes
        {
            get { return new AttributeTag {Tag = new Tag("2200000E")}; }
        }

        public static CodeString AllowLossyCompression
        {
            get { return new CodeString {Tag = new Tag("2200000F")}; }
        }

        public static CodeString RequestPriority
        {
            get { return new CodeString {Tag = new Tag("22000020")}; }
        }

        public static ShortString RTImageLabel
        {
            get { return new ShortString {Tag = new Tag("30020002")}; }
        }

        public static LongString RTImageName
        {
            get { return new LongString {Tag = new Tag("30020003")}; }
        }

        public static ShortText RTImageDescription
        {
            get { return new ShortText {Tag = new Tag("30020004")}; }
        }

        public static CodeString ReportedValuesOrigin
        {
            get { return new CodeString {Tag = new Tag("3002000A")}; }
        }

        public static CodeString RTImagePlane
        {
            get { return new CodeString {Tag = new Tag("3002000C")}; }
        }

        public static DecimalString XRayImageReceptorTranslation
        {
            get { return new DecimalString {Tag = new Tag("3002000D")}; }
        }

        public static DecimalString XRayImageReceptorAngle
        {
            get { return new DecimalString {Tag = new Tag("3002000E")}; }
        }

        public static DecimalString RTImageOrientation
        {
            get { return new DecimalString {Tag = new Tag("30020010")}; }
        }

        public static DecimalString ImagePlanePixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("30020011")}; }
        }

        public static DecimalString RTImagePosition
        {
            get { return new DecimalString {Tag = new Tag("30020012")}; }
        }

        public static ShortString RadiationMachineName
        {
            get { return new ShortString {Tag = new Tag("30020020")}; }
        }

        public static DecimalString RadiationMachineSAD
        {
            get { return new DecimalString {Tag = new Tag("30020022")}; }
        }

        public static DecimalString RadiationMachineSSD
        {
            get { return new DecimalString {Tag = new Tag("30020024")}; }
        }

        public static DecimalString RTImageSID
        {
            get { return new DecimalString {Tag = new Tag("30020026")}; }
        }

        public static DecimalString SourceToReferenceObjectDistance
        {
            get { return new DecimalString {Tag = new Tag("30020028")}; }
        }

        public static IntegerString FractionNumber
        {
            get { return new IntegerString {Tag = new Tag("30020029")}; }
        }

        public static Sequence ExposureSequence
        {
            get { return new Sequence {Tag = new Tag("30020030")}; }
        }

        public static DecimalString MetersetExposure
        {
            get { return new DecimalString {Tag = new Tag("30020032")}; }
        }

        public static DecimalString DiaphragmPosition
        {
            get { return new DecimalString {Tag = new Tag("30020034")}; }
        }

        public static Sequence FluenceMapSequence
        {
            get { return new Sequence {Tag = new Tag("30020040")}; }
        }

        public static CodeString FluenceDataSource
        {
            get { return new CodeString {Tag = new Tag("30020041")}; }
        }

        public static DecimalString FluenceDataScale
        {
            get { return new DecimalString {Tag = new Tag("30020042")}; }
        }

        public static Sequence PrimaryFluenceModeSequence
        {
            get { return new Sequence {Tag = new Tag("30020050")}; }
        }

        public static CodeString FluenceMode
        {
            get { return new CodeString {Tag = new Tag("30020051")}; }
        }

        public static ShortString FluenceModeID
        {
            get { return new ShortString {Tag = new Tag("30020052")}; }
        }

        public static CodeString DVHType
        {
            get { return new CodeString {Tag = new Tag("30040001")}; }
        }

        public static CodeString DoseUnits
        {
            get { return new CodeString {Tag = new Tag("30040002")}; }
        }

        public static CodeString DoseType
        {
            get { return new CodeString {Tag = new Tag("30040004")}; }
        }

        public static LongString DoseComment
        {
            get { return new LongString {Tag = new Tag("30040006")}; }
        }

        public static DecimalString NormalizationPoint
        {
            get { return new DecimalString {Tag = new Tag("30040008")}; }
        }

        public static CodeString DoseSummationType
        {
            get { return new CodeString {Tag = new Tag("3004000A")}; }
        }

        public static DecimalString GridFrameOffsetVector
        {
            get { return new DecimalString {Tag = new Tag("3004000C")}; }
        }

        public static DecimalString DoseGridScaling
        {
            get { return new DecimalString {Tag = new Tag("3004000E")}; }
        }

        public static Sequence RTDoseROISequence
        {
            get { return new Sequence {Tag = new Tag("30040010")}; }
        }

        public static DecimalString DoseValue
        {
            get { return new DecimalString {Tag = new Tag("30040012")}; }
        }

        public static CodeString TissueHeterogeneityCorrection
        {
            get { return new CodeString {Tag = new Tag("30040014")}; }
        }

        public static DecimalString DVHNormalizationPoint
        {
            get { return new DecimalString {Tag = new Tag("30040040")}; }
        }

        public static DecimalString DVHNormalizationDoseValue
        {
            get { return new DecimalString {Tag = new Tag("30040042")}; }
        }

        public static Sequence DVHSequence
        {
            get { return new Sequence {Tag = new Tag("30040050")}; }
        }

        public static DecimalString DVHDoseScaling
        {
            get { return new DecimalString {Tag = new Tag("30040052")}; }
        }

        public static CodeString DVHVolumeUnits
        {
            get { return new CodeString {Tag = new Tag("30040054")}; }
        }

        public static IntegerString DVHNumberOfBins
        {
            get { return new IntegerString {Tag = new Tag("30040056")}; }
        }

        public static DecimalString DVHData
        {
            get { return new DecimalString {Tag = new Tag("30040058")}; }
        }

        public static Sequence DVHReferencedROISequence
        {
            get { return new Sequence {Tag = new Tag("30040060")}; }
        }

        public static CodeString DVHROIContributionType
        {
            get { return new CodeString {Tag = new Tag("30040062")}; }
        }

        public static DecimalString DVHMinimumDose
        {
            get { return new DecimalString {Tag = new Tag("30040070")}; }
        }

        public static DecimalString DVHMaximumDose
        {
            get { return new DecimalString {Tag = new Tag("30040072")}; }
        }

        public static DecimalString DVHMeanDose
        {
            get { return new DecimalString {Tag = new Tag("30040074")}; }
        }

        public static ShortString StructureSetLabel
        {
            get { return new ShortString {Tag = new Tag("30060002")}; }
        }

        public static LongString StructureSetName
        {
            get { return new LongString {Tag = new Tag("30060004")}; }
        }

        public static ShortText StructureSetDescription
        {
            get { return new ShortText {Tag = new Tag("30060006")}; }
        }

        public static Date StructureSetDate
        {
            get { return new Date {Tag = new Tag("30060008")}; }
        }

        public static Time StructureSetTime
        {
            get { return new Time {Tag = new Tag("30060009")}; }
        }

        public static Sequence ReferencedFrameOfReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("30060010")}; }
        }

        public static Sequence RTReferencedStudySequence
        {
            get { return new Sequence {Tag = new Tag("30060012")}; }
        }

        public static Sequence RTReferencedSeriesSequence
        {
            get { return new Sequence {Tag = new Tag("30060014")}; }
        }

        public static Sequence ContourImageSequence
        {
            get { return new Sequence {Tag = new Tag("30060016")}; }
        }

        public static Sequence StructureSetROISequence
        {
            get { return new Sequence {Tag = new Tag("30060020")}; }
        }

        public static IntegerString ROINumber
        {
            get { return new IntegerString {Tag = new Tag("30060022")}; }
        }

        public static UniqueIdentifier ReferencedFrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("30060024")}; }
        }

        public static LongString ROIName
        {
            get { return new LongString {Tag = new Tag("30060026")}; }
        }

        public static ShortText ROIDescription
        {
            get { return new ShortText {Tag = new Tag("30060028")}; }
        }

        public static IntegerString ROIDisplayColor
        {
            get { return new IntegerString {Tag = new Tag("3006002A")}; }
        }

        public static DecimalString ROIVolume
        {
            get { return new DecimalString {Tag = new Tag("3006002C")}; }
        }

        public static Sequence RTRelatedROISequence
        {
            get { return new Sequence {Tag = new Tag("30060030")}; }
        }

        public static CodeString RTROIRelationship
        {
            get { return new CodeString {Tag = new Tag("30060033")}; }
        }

        public static CodeString ROIGenerationAlgorithm
        {
            get { return new CodeString {Tag = new Tag("30060036")}; }
        }

        public static LongString ROIGenerationDescription
        {
            get { return new LongString {Tag = new Tag("30060038")}; }
        }

        public static Sequence ROIContourSequence
        {
            get { return new Sequence {Tag = new Tag("30060039")}; }
        }

        public static Sequence ContourSequence
        {
            get { return new Sequence {Tag = new Tag("30060040")}; }
        }

        public static CodeString ContourGeometricType
        {
            get { return new CodeString {Tag = new Tag("30060042")}; }
        }

        public static DecimalString ContourSlabThickness
        {
            get { return new DecimalString {Tag = new Tag("30060044")}; }
        }

        public static DecimalString ContourOffsetVector
        {
            get { return new DecimalString {Tag = new Tag("30060045")}; }
        }

        public static IntegerString NumberOfContourPoints
        {
            get { return new IntegerString {Tag = new Tag("30060046")}; }
        }

        public static IntegerString ContourNumber
        {
            get { return new IntegerString {Tag = new Tag("30060048")}; }
        }

        public static IntegerString AttachedContours
        {
            get { return new IntegerString {Tag = new Tag("30060049")}; }
        }

        public static DecimalString ContourData
        {
            get { return new DecimalString {Tag = new Tag("30060050")}; }
        }

        public static Sequence RTROIObservationsSequence
        {
            get { return new Sequence {Tag = new Tag("30060080")}; }
        }

        public static IntegerString ObservationNumber
        {
            get { return new IntegerString {Tag = new Tag("30060082")}; }
        }

        public static IntegerString ReferencedROINumber
        {
            get { return new IntegerString {Tag = new Tag("30060084")}; }
        }

        public static ShortString ROIObservationLabel
        {
            get { return new ShortString {Tag = new Tag("30060085")}; }
        }

        public static Sequence RTROIIdentificationCodeSequence
        {
            get { return new Sequence {Tag = new Tag("30060086")}; }
        }

        public static ShortText ROIObservationDescription
        {
            get { return new ShortText {Tag = new Tag("30060088")}; }
        }

        public static Sequence RelatedRTROIObservationsSequence
        {
            get { return new Sequence {Tag = new Tag("300600A0")}; }
        }

        public static CodeString RTROIInterpretedType
        {
            get { return new CodeString {Tag = new Tag("300600A4")}; }
        }

        public static PersonName ROIInterpreter
        {
            get { return new PersonName {Tag = new Tag("300600A6")}; }
        }

        public static Sequence ROIPhysicalPropertiesSequence
        {
            get { return new Sequence {Tag = new Tag("300600B0")}; }
        }

        public static CodeString ROIPhysicalProperty
        {
            get { return new CodeString {Tag = new Tag("300600B2")}; }
        }

        public static DecimalString ROIPhysicalPropertyValue
        {
            get { return new DecimalString {Tag = new Tag("300600B4")}; }
        }

        public static Sequence ROIElementalCompositionSequence
        {
            get { return new Sequence {Tag = new Tag("300600B6")}; }
        }

        public static UnsignedShort ROIElementalCompositionAtomicNumber
        {
            get { return new UnsignedShort {Tag = new Tag("300600B7")}; }
        }

        public static FloatingPointSingle ROIElementalCompositionAtomicMassFraction
        {
            get { return new FloatingPointSingle {Tag = new Tag("300600B8")}; }
        }

        public static Sequence FrameOfReferenceRelationshipSequence
        {
            get { return new Sequence {Tag = new Tag("300600C0")}; }
        }

        public static UniqueIdentifier RelatedFrameOfReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("300600C2")}; }
        }

        public static CodeString FrameOfReferenceTransformationType
        {
            get { return new CodeString {Tag = new Tag("300600C4")}; }
        }

        public static DecimalString FrameOfReferenceTransformationMatrix
        {
            get { return new DecimalString {Tag = new Tag("300600C6")}; }
        }

        public static LongString FrameOfReferenceTransformationComment
        {
            get { return new LongString {Tag = new Tag("300600C8")}; }
        }

        public static Sequence MeasuredDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("30080010")}; }
        }

        public static ShortText MeasuredDoseDescription
        {
            get { return new ShortText {Tag = new Tag("30080012")}; }
        }

        public static CodeString MeasuredDoseType
        {
            get { return new CodeString {Tag = new Tag("30080014")}; }
        }

        public static DecimalString MeasuredDoseValue
        {
            get { return new DecimalString {Tag = new Tag("30080016")}; }
        }

        public static Sequence TreatmentSessionBeamSequence
        {
            get { return new Sequence {Tag = new Tag("30080020")}; }
        }

        public static Sequence TreatmentSessionIonBeamSequence
        {
            get { return new Sequence {Tag = new Tag("30080021")}; }
        }

        public static IntegerString CurrentFractionNumber
        {
            get { return new IntegerString {Tag = new Tag("30080022")}; }
        }

        public static Date TreatmentControlPointDate
        {
            get { return new Date {Tag = new Tag("30080024")}; }
        }

        public static Time TreatmentControlPointTime
        {
            get { return new Time {Tag = new Tag("30080025")}; }
        }

        public static CodeString TreatmentTerminationStatus
        {
            get { return new CodeString {Tag = new Tag("3008002A")}; }
        }

        public static ShortString TreatmentTerminationCode
        {
            get { return new ShortString {Tag = new Tag("3008002B")}; }
        }

        public static CodeString TreatmentVerificationStatus
        {
            get { return new CodeString {Tag = new Tag("3008002C")}; }
        }

        public static Sequence ReferencedTreatmentRecordSequence
        {
            get { return new Sequence {Tag = new Tag("30080030")}; }
        }

        public static DecimalString SpecifiedPrimaryMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080032")}; }
        }

        public static DecimalString SpecifiedSecondaryMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080033")}; }
        }

        public static DecimalString DeliveredPrimaryMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080036")}; }
        }

        public static DecimalString DeliveredSecondaryMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080037")}; }
        }

        public static DecimalString SpecifiedTreatmentTime
        {
            get { return new DecimalString {Tag = new Tag("3008003A")}; }
        }

        public static DecimalString DeliveredTreatmentTime
        {
            get { return new DecimalString {Tag = new Tag("3008003B")}; }
        }

        public static Sequence ControlPointDeliverySequence
        {
            get { return new Sequence {Tag = new Tag("30080040")}; }
        }

        public static Sequence IonControlPointDeliverySequence
        {
            get { return new Sequence {Tag = new Tag("30080041")}; }
        }

        public static DecimalString SpecifiedMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080042")}; }
        }

        public static DecimalString DeliveredMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080044")}; }
        }

        public static FloatingPointSingle MetersetRateSet
        {
            get { return new FloatingPointSingle {Tag = new Tag("30080045")}; }
        }

        public static FloatingPointSingle MetersetRateDelivered
        {
            get { return new FloatingPointSingle {Tag = new Tag("30080046")}; }
        }

        public static FloatingPointSingle ScanSpotMetersetsDelivered
        {
            get { return new FloatingPointSingle {Tag = new Tag("30080047")}; }
        }

        public static DecimalString DoseRateDelivered
        {
            get { return new DecimalString {Tag = new Tag("30080048")}; }
        }

        public static Sequence TreatmentSummaryCalculatedDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("30080050")}; }
        }

        public static DecimalString CumulativeDoseToDoseReference
        {
            get { return new DecimalString {Tag = new Tag("30080052")}; }
        }

        public static Date FirstTreatmentDate
        {
            get { return new Date {Tag = new Tag("30080054")}; }
        }

        public static Date MostRecentTreatmentDate
        {
            get { return new Date {Tag = new Tag("30080056")}; }
        }

        public static IntegerString NumberOfFractionsDelivered
        {
            get { return new IntegerString {Tag = new Tag("3008005A")}; }
        }

        public static Sequence OverrideSequence
        {
            get { return new Sequence {Tag = new Tag("30080060")}; }
        }

        public static AttributeTag ParameterSequencePointer
        {
            get { return new AttributeTag {Tag = new Tag("30080061")}; }
        }

        public static AttributeTag OverrideParameterPointer
        {
            get { return new AttributeTag {Tag = new Tag("30080062")}; }
        }

        public static IntegerString ParameterItemIndex
        {
            get { return new IntegerString {Tag = new Tag("30080063")}; }
        }

        public static IntegerString MeasuredDoseReferenceNumber
        {
            get { return new IntegerString {Tag = new Tag("30080064")}; }
        }

        public static AttributeTag ParameterPointer
        {
            get { return new AttributeTag {Tag = new Tag("30080065")}; }
        }

        public static ShortText OverrideReason
        {
            get { return new ShortText {Tag = new Tag("30080066")}; }
        }

        public static Sequence CorrectedParameterSequence
        {
            get { return new Sequence {Tag = new Tag("30080068")}; }
        }

        public static FloatingPointSingle CorrectionValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("3008006A")}; }
        }

        public static Sequence CalculatedDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("30080070")}; }
        }

        public static IntegerString CalculatedDoseReferenceNumber
        {
            get { return new IntegerString {Tag = new Tag("30080072")}; }
        }

        public static ShortText CalculatedDoseReferenceDescription
        {
            get { return new ShortText {Tag = new Tag("30080074")}; }
        }

        public static DecimalString CalculatedDoseReferenceDoseValue
        {
            get { return new DecimalString {Tag = new Tag("30080076")}; }
        }

        public static DecimalString StartMeterset
        {
            get { return new DecimalString {Tag = new Tag("30080078")}; }
        }

        public static DecimalString EndMeterset
        {
            get { return new DecimalString {Tag = new Tag("3008007A")}; }
        }

        public static Sequence ReferencedMeasuredDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("30080080")}; }
        }

        public static IntegerString ReferencedMeasuredDoseReferenceNumber
        {
            get { return new IntegerString {Tag = new Tag("30080082")}; }
        }

        public static Sequence ReferencedCalculatedDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("30080090")}; }
        }

        public static IntegerString ReferencedCalculatedDoseReferenceNumber
        {
            get { return new IntegerString {Tag = new Tag("30080092")}; }
        }

        public static Sequence BeamLimitingDeviceLeafPairsSequence
        {
            get { return new Sequence {Tag = new Tag("300800A0")}; }
        }

        public static Sequence RecordedWedgeSequence
        {
            get { return new Sequence {Tag = new Tag("300800B0")}; }
        }

        public static Sequence RecordedCompensatorSequence
        {
            get { return new Sequence {Tag = new Tag("300800C0")}; }
        }

        public static Sequence RecordedBlockSequence
        {
            get { return new Sequence {Tag = new Tag("300800D0")}; }
        }

        public static Sequence TreatmentSummaryMeasuredDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("300800E0")}; }
        }

        public static Sequence RecordedSnoutSequence
        {
            get { return new Sequence {Tag = new Tag("300800F0")}; }
        }

        public static Sequence RecordedRangeShifterSequence
        {
            get { return new Sequence {Tag = new Tag("300800F2")}; }
        }

        public static Sequence RecordedLateralSpreadingDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300800F4")}; }
        }

        public static Sequence RecordedRangeModulatorSequence
        {
            get { return new Sequence {Tag = new Tag("300800F6")}; }
        }

        public static Sequence RecordedSourceSequence
        {
            get { return new Sequence {Tag = new Tag("30080100")}; }
        }

        public static LongString SourceSerialNumber
        {
            get { return new LongString {Tag = new Tag("30080105")}; }
        }

        public static Sequence TreatmentSessionApplicationSetupSequence
        {
            get { return new Sequence {Tag = new Tag("30080110")}; }
        }

        public static CodeString ApplicationSetupCheck
        {
            get { return new CodeString {Tag = new Tag("30080116")}; }
        }

        public static Sequence RecordedBrachyAccessoryDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("30080120")}; }
        }

        public static IntegerString ReferencedBrachyAccessoryDeviceNumber
        {
            get { return new IntegerString {Tag = new Tag("30080122")}; }
        }

        public static Sequence RecordedChannelSequence
        {
            get { return new Sequence {Tag = new Tag("30080130")}; }
        }

        public static DecimalString SpecifiedChannelTotalTime
        {
            get { return new DecimalString {Tag = new Tag("30080132")}; }
        }

        public static DecimalString DeliveredChannelTotalTime
        {
            get { return new DecimalString {Tag = new Tag("30080134")}; }
        }

        public static IntegerString SpecifiedNumberOfPulses
        {
            get { return new IntegerString {Tag = new Tag("30080136")}; }
        }

        public static IntegerString DeliveredNumberOfPulses
        {
            get { return new IntegerString {Tag = new Tag("30080138")}; }
        }

        public static DecimalString SpecifiedPulseRepetitionInterval
        {
            get { return new DecimalString {Tag = new Tag("3008013A")}; }
        }

        public static DecimalString DeliveredPulseRepetitionInterval
        {
            get { return new DecimalString {Tag = new Tag("3008013C")}; }
        }

        public static Sequence RecordedSourceApplicatorSequence
        {
            get { return new Sequence {Tag = new Tag("30080140")}; }
        }

        public static IntegerString ReferencedSourceApplicatorNumber
        {
            get { return new IntegerString {Tag = new Tag("30080142")}; }
        }

        public static Sequence RecordedChannelShieldSequence
        {
            get { return new Sequence {Tag = new Tag("30080150")}; }
        }

        public static IntegerString ReferencedChannelShieldNumber
        {
            get { return new IntegerString {Tag = new Tag("30080152")}; }
        }

        public static Sequence BrachyControlPointDeliveredSequence
        {
            get { return new Sequence {Tag = new Tag("30080160")}; }
        }

        public static Date SafePositionExitDate
        {
            get { return new Date {Tag = new Tag("30080162")}; }
        }

        public static Time SafePositionExitTime
        {
            get { return new Time {Tag = new Tag("30080164")}; }
        }

        public static Date SafePositionReturnDate
        {
            get { return new Date {Tag = new Tag("30080166")}; }
        }

        public static Time SafePositionReturnTime
        {
            get { return new Time {Tag = new Tag("30080168")}; }
        }

        public static CodeString CurrentTreatmentStatus
        {
            get { return new CodeString {Tag = new Tag("30080200")}; }
        }

        public static ShortText TreatmentStatusComment
        {
            get { return new ShortText {Tag = new Tag("30080202")}; }
        }

        public static Sequence FractionGroupSummarySequence
        {
            get { return new Sequence {Tag = new Tag("30080220")}; }
        }

        public static IntegerString ReferencedFractionNumber
        {
            get { return new IntegerString {Tag = new Tag("30080223")}; }
        }

        public static CodeString FractionGroupType
        {
            get { return new CodeString {Tag = new Tag("30080224")}; }
        }

        public static CodeString BeamStopperPosition
        {
            get { return new CodeString {Tag = new Tag("30080230")}; }
        }

        public static Sequence FractionStatusSummarySequence
        {
            get { return new Sequence {Tag = new Tag("30080240")}; }
        }

        public static Date TreatmentDate
        {
            get { return new Date {Tag = new Tag("30080250")}; }
        }

        public static Time TreatmentTime
        {
            get { return new Time {Tag = new Tag("30080251")}; }
        }

        public static ShortString RTPlanLabel
        {
            get { return new ShortString {Tag = new Tag("300A0002")}; }
        }

        public static LongString RTPlanName
        {
            get { return new LongString {Tag = new Tag("300A0003")}; }
        }

        public static ShortText RTPlanDescription
        {
            get { return new ShortText {Tag = new Tag("300A0004")}; }
        }

        public static Date RTPlanDate
        {
            get { return new Date {Tag = new Tag("300A0006")}; }
        }

        public static Time RTPlanTime
        {
            get { return new Time {Tag = new Tag("300A0007")}; }
        }

        public static LongString TreatmentProtocols
        {
            get { return new LongString {Tag = new Tag("300A0009")}; }
        }

        public static CodeString PlanIntent
        {
            get { return new CodeString {Tag = new Tag("300A000A")}; }
        }

        public static LongString TreatmentSites
        {
            get { return new LongString {Tag = new Tag("300A000B")}; }
        }

        public static CodeString RTPlanGeometry
        {
            get { return new CodeString {Tag = new Tag("300A000C")}; }
        }

        public static ShortText PrescriptionDescription
        {
            get { return new ShortText {Tag = new Tag("300A000E")}; }
        }

        public static Sequence DoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("300A0010")}; }
        }

        public static IntegerString DoseReferenceNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0012")}; }
        }

        public static UniqueIdentifier DoseReferenceUID
        {
            get { return new UniqueIdentifier {Tag = new Tag("300A0013")}; }
        }

        public static CodeString DoseReferenceStructureType
        {
            get { return new CodeString {Tag = new Tag("300A0014")}; }
        }

        public static CodeString NominalBeamEnergyUnit
        {
            get { return new CodeString {Tag = new Tag("300A0015")}; }
        }

        public static LongString DoseReferenceDescription
        {
            get { return new LongString {Tag = new Tag("300A0016")}; }
        }

        public static DecimalString DoseReferencePointCoordinates
        {
            get { return new DecimalString {Tag = new Tag("300A0018")}; }
        }

        public static DecimalString NominalPriorDose
        {
            get { return new DecimalString {Tag = new Tag("300A001A")}; }
        }

        public static CodeString DoseReferenceType
        {
            get { return new CodeString {Tag = new Tag("300A0020")}; }
        }

        public static DecimalString ConstraintWeight
        {
            get { return new DecimalString {Tag = new Tag("300A0021")}; }
        }

        public static DecimalString DeliveryWarningDose
        {
            get { return new DecimalString {Tag = new Tag("300A0022")}; }
        }

        public static DecimalString DeliveryMaximumDose
        {
            get { return new DecimalString {Tag = new Tag("300A0023")}; }
        }

        public static DecimalString TargetMinimumDose
        {
            get { return new DecimalString {Tag = new Tag("300A0025")}; }
        }

        public static DecimalString TargetPrescriptionDose
        {
            get { return new DecimalString {Tag = new Tag("300A0026")}; }
        }

        public static DecimalString TargetMaximumDose
        {
            get { return new DecimalString {Tag = new Tag("300A0027")}; }
        }

        public static DecimalString TargetUnderdoseVolumeFraction
        {
            get { return new DecimalString {Tag = new Tag("300A0028")}; }
        }

        public static DecimalString OrganAtRiskFullVolumeDose
        {
            get { return new DecimalString {Tag = new Tag("300A002A")}; }
        }

        public static DecimalString OrganAtRiskLimitDose
        {
            get { return new DecimalString {Tag = new Tag("300A002B")}; }
        }

        public static DecimalString OrganAtRiskMaximumDose
        {
            get { return new DecimalString {Tag = new Tag("300A002C")}; }
        }

        public static DecimalString OrganAtRiskOverdoseVolumeFraction
        {
            get { return new DecimalString {Tag = new Tag("300A002D")}; }
        }

        public static Sequence ToleranceTableSequence
        {
            get { return new Sequence {Tag = new Tag("300A0040")}; }
        }

        public static IntegerString ToleranceTableNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0042")}; }
        }

        public static ShortString ToleranceTableLabel
        {
            get { return new ShortString {Tag = new Tag("300A0043")}; }
        }

        public static DecimalString GantryAngleTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A0044")}; }
        }

        public static DecimalString BeamLimitingDeviceAngleTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A0046")}; }
        }

        public static Sequence BeamLimitingDeviceToleranceSequence
        {
            get { return new Sequence {Tag = new Tag("300A0048")}; }
        }

        public static DecimalString BeamLimitingDevicePositionTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A004A")}; }
        }

        public static FloatingPointSingle SnoutPositionTolerance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A004B")}; }
        }

        public static DecimalString PatientSupportAngleTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A004C")}; }
        }

        public static DecimalString TableTopEccentricAngleTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A004E")}; }
        }

        public static FloatingPointSingle TableTopPitchAngleTolerance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A004F")}; }
        }

        public static FloatingPointSingle TableTopRollAngleTolerance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0050")}; }
        }

        public static DecimalString TableTopVerticalPositionTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A0051")}; }
        }

        public static DecimalString TableTopLongitudinalPositionTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A0052")}; }
        }

        public static DecimalString TableTopLateralPositionTolerance
        {
            get { return new DecimalString {Tag = new Tag("300A0053")}; }
        }

        public static CodeString RTPlanRelationship
        {
            get { return new CodeString {Tag = new Tag("300A0055")}; }
        }

        public static Sequence FractionGroupSequence
        {
            get { return new Sequence {Tag = new Tag("300A0070")}; }
        }

        public static IntegerString FractionGroupNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0071")}; }
        }

        public static LongString FractionGroupDescription
        {
            get { return new LongString {Tag = new Tag("300A0072")}; }
        }

        public static IntegerString NumberOfFractionsPlanned
        {
            get { return new IntegerString {Tag = new Tag("300A0078")}; }
        }

        public static IntegerString NumberOfFractionPatternDigitsPerDay
        {
            get { return new IntegerString {Tag = new Tag("300A0079")}; }
        }

        public static IntegerString RepeatFractionCycleLength
        {
            get { return new IntegerString {Tag = new Tag("300A007A")}; }
        }

        public static LongText FractionPattern
        {
            get { return new LongText {Tag = new Tag("300A007B")}; }
        }

        public static IntegerString NumberOfBeams
        {
            get { return new IntegerString {Tag = new Tag("300A0080")}; }
        }

        public static DecimalString BeamDoseSpecificationPoint
        {
            get { return new DecimalString {Tag = new Tag("300A0082")}; }
        }

        public static DecimalString BeamDose
        {
            get { return new DecimalString {Tag = new Tag("300A0084")}; }
        }

        public static DecimalString BeamMeterset
        {
            get { return new DecimalString {Tag = new Tag("300A0086")}; }
        }

        public static FloatingPointSingle BeamDosePointDepth
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0088")}; }
        }

        public static FloatingPointSingle BeamDosePointEquivalentDepth
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0089")}; }
        }

        public static FloatingPointSingle BeamDosePointSSD
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A008A")}; }
        }

        public static IntegerString NumberOfBrachyApplicationSetups
        {
            get { return new IntegerString {Tag = new Tag("300A00A0")}; }
        }

        public static DecimalString BrachyApplicationSetupDoseSpecificationPoint
        {
            get { return new DecimalString {Tag = new Tag("300A00A2")}; }
        }

        public static DecimalString BrachyApplicationSetupDose
        {
            get { return new DecimalString {Tag = new Tag("300A00A4")}; }
        }

        public static Sequence BeamSequence
        {
            get { return new Sequence {Tag = new Tag("300A00B0")}; }
        }

        public static ShortString TreatmentMachineName
        {
            get { return new ShortString {Tag = new Tag("300A00B2")}; }
        }

        public static CodeString PrimaryDosimeterUnit
        {
            get { return new CodeString {Tag = new Tag("300A00B3")}; }
        }

        public static DecimalString SourceAxisDistance
        {
            get { return new DecimalString {Tag = new Tag("300A00B4")}; }
        }

        public static Sequence BeamLimitingDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A00B6")}; }
        }

        public static CodeString RTBeamLimitingDeviceType
        {
            get { return new CodeString {Tag = new Tag("300A00B8")}; }
        }

        public static DecimalString SourceToBeamLimitingDeviceDistance
        {
            get { return new DecimalString {Tag = new Tag("300A00BA")}; }
        }

        public static FloatingPointSingle IsocenterToBeamLimitingDeviceDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A00BB")}; }
        }

        public static IntegerString NumberOfLeafJawPairs
        {
            get { return new IntegerString {Tag = new Tag("300A00BC")}; }
        }

        public static DecimalString LeafPositionBoundaries
        {
            get { return new DecimalString {Tag = new Tag("300A00BE")}; }
        }

        public static IntegerString BeamNumber
        {
            get { return new IntegerString {Tag = new Tag("300A00C0")}; }
        }

        public static LongString BeamName
        {
            get { return new LongString {Tag = new Tag("300A00C2")}; }
        }

        public static ShortText BeamDescription
        {
            get { return new ShortText {Tag = new Tag("300A00C3")}; }
        }

        public static CodeString BeamType
        {
            get { return new CodeString {Tag = new Tag("300A00C4")}; }
        }

        public static CodeString RadiationType
        {
            get { return new CodeString {Tag = new Tag("300A00C6")}; }
        }

        public static CodeString HighDoseTechniqueType
        {
            get { return new CodeString {Tag = new Tag("300A00C7")}; }
        }

        public static IntegerString ReferenceImageNumber
        {
            get { return new IntegerString {Tag = new Tag("300A00C8")}; }
        }

        public static Sequence PlannedVerificationImageSequence
        {
            get { return new Sequence {Tag = new Tag("300A00CA")}; }
        }

        public static LongString ImagingDeviceSpecificAcquisitionParameters
        {
            get { return new LongString {Tag = new Tag("300A00CC")}; }
        }

        public static CodeString TreatmentDeliveryType
        {
            get { return new CodeString {Tag = new Tag("300A00CE")}; }
        }

        public static IntegerString NumberOfWedges
        {
            get { return new IntegerString {Tag = new Tag("300A00D0")}; }
        }

        public static Sequence WedgeSequence
        {
            get { return new Sequence {Tag = new Tag("300A00D1")}; }
        }

        public static IntegerString WedgeNumber
        {
            get { return new IntegerString {Tag = new Tag("300A00D2")}; }
        }

        public static CodeString WedgeType
        {
            get { return new CodeString {Tag = new Tag("300A00D3")}; }
        }

        public static ShortString WedgeID
        {
            get { return new ShortString {Tag = new Tag("300A00D4")}; }
        }

        public static IntegerString WedgeAngle
        {
            get { return new IntegerString {Tag = new Tag("300A00D5")}; }
        }

        public static DecimalString WedgeFactor
        {
            get { return new DecimalString {Tag = new Tag("300A00D6")}; }
        }

        public static FloatingPointSingle TotalWedgeTrayWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A00D7")}; }
        }

        public static DecimalString WedgeOrientation
        {
            get { return new DecimalString {Tag = new Tag("300A00D8")}; }
        }

        public static FloatingPointSingle IsocenterToWedgeTrayDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A00D9")}; }
        }

        public static DecimalString SourceToWedgeTrayDistance
        {
            get { return new DecimalString {Tag = new Tag("300A00DA")}; }
        }

        public static FloatingPointSingle WedgeThinEdgePosition
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A00DB")}; }
        }

        public static ShortString BolusID
        {
            get { return new ShortString {Tag = new Tag("300A00DC")}; }
        }

        public static ShortText BolusDescription
        {
            get { return new ShortText {Tag = new Tag("300A00DD")}; }
        }

        public static IntegerString NumberOfCompensators
        {
            get { return new IntegerString {Tag = new Tag("300A00E0")}; }
        }

        public static ShortString MaterialID
        {
            get { return new ShortString {Tag = new Tag("300A00E1")}; }
        }

        public static DecimalString TotalCompensatorTrayFactor
        {
            get { return new DecimalString {Tag = new Tag("300A00E2")}; }
        }

        public static Sequence CompensatorSequence
        {
            get { return new Sequence {Tag = new Tag("300A00E3")}; }
        }

        public static IntegerString CompensatorNumber
        {
            get { return new IntegerString {Tag = new Tag("300A00E4")}; }
        }

        public static ShortString CompensatorID
        {
            get { return new ShortString {Tag = new Tag("300A00E5")}; }
        }

        public static DecimalString SourceToCompensatorTrayDistance
        {
            get { return new DecimalString {Tag = new Tag("300A00E6")}; }
        }

        public static IntegerString CompensatorRows
        {
            get { return new IntegerString {Tag = new Tag("300A00E7")}; }
        }

        public static IntegerString CompensatorColumns
        {
            get { return new IntegerString {Tag = new Tag("300A00E8")}; }
        }

        public static DecimalString CompensatorPixelSpacing
        {
            get { return new DecimalString {Tag = new Tag("300A00E9")}; }
        }

        public static DecimalString CompensatorPosition
        {
            get { return new DecimalString {Tag = new Tag("300A00EA")}; }
        }

        public static DecimalString CompensatorTransmissionData
        {
            get { return new DecimalString {Tag = new Tag("300A00EB")}; }
        }

        public static DecimalString CompensatorThicknessData
        {
            get { return new DecimalString {Tag = new Tag("300A00EC")}; }
        }

        public static IntegerString NumberOfBoli
        {
            get { return new IntegerString {Tag = new Tag("300A00ED")}; }
        }

        public static CodeString CompensatorType
        {
            get { return new CodeString {Tag = new Tag("300A00EE")}; }
        }

        public static IntegerString NumberOfBlocks
        {
            get { return new IntegerString {Tag = new Tag("300A00F0")}; }
        }

        public static DecimalString TotalBlockTrayFactor
        {
            get { return new DecimalString {Tag = new Tag("300A00F2")}; }
        }

        public static FloatingPointSingle TotalBlockTrayWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A00F3")}; }
        }

        public static Sequence BlockSequence
        {
            get { return new Sequence {Tag = new Tag("300A00F4")}; }
        }

        public static ShortString BlockTrayID
        {
            get { return new ShortString {Tag = new Tag("300A00F5")}; }
        }

        public static DecimalString SourceToBlockTrayDistance
        {
            get { return new DecimalString {Tag = new Tag("300A00F6")}; }
        }

        public static FloatingPointSingle IsocenterToBlockTrayDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A00F7")}; }
        }

        public static CodeString BlockType
        {
            get { return new CodeString {Tag = new Tag("300A00F8")}; }
        }

        public static LongString AccessoryCode
        {
            get { return new LongString {Tag = new Tag("300A00F9")}; }
        }

        public static CodeString BlockDivergence
        {
            get { return new CodeString {Tag = new Tag("300A00FA")}; }
        }

        public static CodeString BlockMountingPosition
        {
            get { return new CodeString {Tag = new Tag("300A00FB")}; }
        }

        public static IntegerString BlockNumber
        {
            get { return new IntegerString {Tag = new Tag("300A00FC")}; }
        }

        public static LongString BlockName
        {
            get { return new LongString {Tag = new Tag("300A00FE")}; }
        }

        public static DecimalString BlockThickness
        {
            get { return new DecimalString {Tag = new Tag("300A0100")}; }
        }

        public static DecimalString BlockTransmission
        {
            get { return new DecimalString {Tag = new Tag("300A0102")}; }
        }

        public static IntegerString BlockNumberOfPoints
        {
            get { return new IntegerString {Tag = new Tag("300A0104")}; }
        }

        public static DecimalString BlockData
        {
            get { return new DecimalString {Tag = new Tag("300A0106")}; }
        }

        public static Sequence ApplicatorSequence
        {
            get { return new Sequence {Tag = new Tag("300A0107")}; }
        }

        public static ShortString ApplicatorID
        {
            get { return new ShortString {Tag = new Tag("300A0108")}; }
        }

        public static CodeString ApplicatorType
        {
            get { return new CodeString {Tag = new Tag("300A0109")}; }
        }

        public static LongString ApplicatorDescription
        {
            get { return new LongString {Tag = new Tag("300A010A")}; }
        }

        public static DecimalString CumulativeDoseReferenceCoefficient
        {
            get { return new DecimalString {Tag = new Tag("300A010C")}; }
        }

        public static DecimalString FinalCumulativeMetersetWeight
        {
            get { return new DecimalString {Tag = new Tag("300A010E")}; }
        }

        public static IntegerString NumberOfControlPoints
        {
            get { return new IntegerString {Tag = new Tag("300A0110")}; }
        }

        public static Sequence ControlPointSequence
        {
            get { return new Sequence {Tag = new Tag("300A0111")}; }
        }

        public static IntegerString ControlPointIndex
        {
            get { return new IntegerString {Tag = new Tag("300A0112")}; }
        }

        public static DecimalString NominalBeamEnergy
        {
            get { return new DecimalString {Tag = new Tag("300A0114")}; }
        }

        public static DecimalString DoseRateSet
        {
            get { return new DecimalString {Tag = new Tag("300A0115")}; }
        }

        public static Sequence WedgePositionSequence
        {
            get { return new Sequence {Tag = new Tag("300A0116")}; }
        }

        public static CodeString WedgePosition
        {
            get { return new CodeString {Tag = new Tag("300A0118")}; }
        }

        public static Sequence BeamLimitingDevicePositionSequence
        {
            get { return new Sequence {Tag = new Tag("300A011A")}; }
        }

        public static DecimalString LeafJawPositions
        {
            get { return new DecimalString {Tag = new Tag("300A011C")}; }
        }

        public static DecimalString GantryAngle
        {
            get { return new DecimalString {Tag = new Tag("300A011E")}; }
        }

        public static CodeString GantryRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A011F")}; }
        }

        public static DecimalString BeamLimitingDeviceAngle
        {
            get { return new DecimalString {Tag = new Tag("300A0120")}; }
        }

        public static CodeString BeamLimitingDeviceRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A0121")}; }
        }

        public static DecimalString PatientSupportAngle
        {
            get { return new DecimalString {Tag = new Tag("300A0122")}; }
        }

        public static CodeString PatientSupportRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A0123")}; }
        }

        public static DecimalString TableTopEccentricAxisDistance
        {
            get { return new DecimalString {Tag = new Tag("300A0124")}; }
        }

        public static DecimalString TableTopEccentricAngle
        {
            get { return new DecimalString {Tag = new Tag("300A0125")}; }
        }

        public static CodeString TableTopEccentricRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A0126")}; }
        }

        public static DecimalString TableTopVerticalPosition
        {
            get { return new DecimalString {Tag = new Tag("300A0128")}; }
        }

        public static DecimalString TableTopLongitudinalPosition
        {
            get { return new DecimalString {Tag = new Tag("300A0129")}; }
        }

        public static DecimalString TableTopLateralPosition
        {
            get { return new DecimalString {Tag = new Tag("300A012A")}; }
        }

        public static DecimalString IsocenterPosition
        {
            get { return new DecimalString {Tag = new Tag("300A012C")}; }
        }

        public static DecimalString SurfaceEntryPoint
        {
            get { return new DecimalString {Tag = new Tag("300A012E")}; }
        }

        public static DecimalString SourceToSurfaceDistance
        {
            get { return new DecimalString {Tag = new Tag("300A0130")}; }
        }

        public static DecimalString CumulativeMetersetWeight
        {
            get { return new DecimalString {Tag = new Tag("300A0134")}; }
        }

        public static FloatingPointSingle TableTopPitchAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0140")}; }
        }

        public static CodeString TableTopPitchRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A0142")}; }
        }

        public static FloatingPointSingle TableTopRollAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0144")}; }
        }

        public static CodeString TableTopRollRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A0146")}; }
        }

        public static FloatingPointSingle HeadFixationAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0148")}; }
        }

        public static FloatingPointSingle GantryPitchAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A014A")}; }
        }

        public static CodeString GantryPitchRotationDirection
        {
            get { return new CodeString {Tag = new Tag("300A014C")}; }
        }

        public static FloatingPointSingle GantryPitchAngleTolerance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A014E")}; }
        }

        public static Sequence PatientSetupSequence
        {
            get { return new Sequence {Tag = new Tag("300A0180")}; }
        }

        public static IntegerString PatientSetupNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0182")}; }
        }

        public static LongString PatientSetupLabel
        {
            get { return new LongString {Tag = new Tag("300A0183")}; }
        }

        public static LongString PatientAdditionalPosition
        {
            get { return new LongString {Tag = new Tag("300A0184")}; }
        }

        public static Sequence FixationDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A0190")}; }
        }

        public static CodeString FixationDeviceType
        {
            get { return new CodeString {Tag = new Tag("300A0192")}; }
        }

        public static ShortString FixationDeviceLabel
        {
            get { return new ShortString {Tag = new Tag("300A0194")}; }
        }

        public static ShortText FixationDeviceDescription
        {
            get { return new ShortText {Tag = new Tag("300A0196")}; }
        }

        public static ShortString FixationDevicePosition
        {
            get { return new ShortString {Tag = new Tag("300A0198")}; }
        }

        public static FloatingPointSingle FixationDevicePitchAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0199")}; }
        }

        public static FloatingPointSingle FixationDeviceRollAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A019A")}; }
        }

        public static Sequence ShieldingDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A01A0")}; }
        }

        public static CodeString ShieldingDeviceType
        {
            get { return new CodeString {Tag = new Tag("300A01A2")}; }
        }

        public static ShortString ShieldingDeviceLabel
        {
            get { return new ShortString {Tag = new Tag("300A01A4")}; }
        }

        public static ShortText ShieldingDeviceDescription
        {
            get { return new ShortText {Tag = new Tag("300A01A6")}; }
        }

        public static ShortString ShieldingDevicePosition
        {
            get { return new ShortString {Tag = new Tag("300A01A8")}; }
        }

        public static CodeString SetupTechnique
        {
            get { return new CodeString {Tag = new Tag("300A01B0")}; }
        }

        public static ShortText SetupTechniqueDescription
        {
            get { return new ShortText {Tag = new Tag("300A01B2")}; }
        }

        public static Sequence SetupDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A01B4")}; }
        }

        public static CodeString SetupDeviceType
        {
            get { return new CodeString {Tag = new Tag("300A01B6")}; }
        }

        public static ShortString SetupDeviceLabel
        {
            get { return new ShortString {Tag = new Tag("300A01B8")}; }
        }

        public static ShortText SetupDeviceDescription
        {
            get { return new ShortText {Tag = new Tag("300A01BA")}; }
        }

        public static DecimalString SetupDeviceParameter
        {
            get { return new DecimalString {Tag = new Tag("300A01BC")}; }
        }

        public static ShortText SetupReferenceDescription
        {
            get { return new ShortText {Tag = new Tag("300A01D0")}; }
        }

        public static DecimalString TableTopVerticalSetupDisplacement
        {
            get { return new DecimalString {Tag = new Tag("300A01D2")}; }
        }

        public static DecimalString TableTopLongitudinalSetupDisplacement
        {
            get { return new DecimalString {Tag = new Tag("300A01D4")}; }
        }

        public static DecimalString TableTopLateralSetupDisplacement
        {
            get { return new DecimalString {Tag = new Tag("300A01D6")}; }
        }

        public static CodeString BrachyTreatmentTechnique
        {
            get { return new CodeString {Tag = new Tag("300A0200")}; }
        }

        public static CodeString BrachyTreatmentType
        {
            get { return new CodeString {Tag = new Tag("300A0202")}; }
        }

        public static Sequence TreatmentMachineSequence
        {
            get { return new Sequence {Tag = new Tag("300A0206")}; }
        }

        public static Sequence SourceSequence
        {
            get { return new Sequence {Tag = new Tag("300A0210")}; }
        }

        public static IntegerString SourceNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0212")}; }
        }

        public static CodeString SourceType
        {
            get { return new CodeString {Tag = new Tag("300A0214")}; }
        }

        public static LongString SourceManufacturer
        {
            get { return new LongString {Tag = new Tag("300A0216")}; }
        }

        public static DecimalString ActiveSourceDiameter
        {
            get { return new DecimalString {Tag = new Tag("300A0218")}; }
        }

        public static DecimalString ActiveSourceLength
        {
            get { return new DecimalString {Tag = new Tag("300A021A")}; }
        }

        public static DecimalString SourceEncapsulationNominalThickness
        {
            get { return new DecimalString {Tag = new Tag("300A0222")}; }
        }

        public static DecimalString SourceEncapsulationNominalTransmission
        {
            get { return new DecimalString {Tag = new Tag("300A0224")}; }
        }

        public static LongString SourceIsotopeName
        {
            get { return new LongString {Tag = new Tag("300A0226")}; }
        }

        public static DecimalString SourceIsotopeHalfLife
        {
            get { return new DecimalString {Tag = new Tag("300A0228")}; }
        }

        public static CodeString SourceStrengthUnits
        {
            get { return new CodeString {Tag = new Tag("300A0229")}; }
        }

        public static DecimalString ReferenceAirKermaRate
        {
            get { return new DecimalString {Tag = new Tag("300A022A")}; }
        }

        public static DecimalString SourceStrength
        {
            get { return new DecimalString {Tag = new Tag("300A022B")}; }
        }

        public static Date SourceStrengthReferenceDate
        {
            get { return new Date {Tag = new Tag("300A022C")}; }
        }

        public static Time SourceStrengthReferenceTime
        {
            get { return new Time {Tag = new Tag("300A022E")}; }
        }

        public static Sequence ApplicationSetupSequence
        {
            get { return new Sequence {Tag = new Tag("300A0230")}; }
        }

        public static CodeString ApplicationSetupType
        {
            get { return new CodeString {Tag = new Tag("300A0232")}; }
        }

        public static IntegerString ApplicationSetupNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0234")}; }
        }

        public static LongString ApplicationSetupName
        {
            get { return new LongString {Tag = new Tag("300A0236")}; }
        }

        public static LongString ApplicationSetupManufacturer
        {
            get { return new LongString {Tag = new Tag("300A0238")}; }
        }

        public static IntegerString TemplateNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0240")}; }
        }

        public static ShortString TemplateType
        {
            get { return new ShortString {Tag = new Tag("300A0242")}; }
        }

        public static LongString TemplateName
        {
            get { return new LongString {Tag = new Tag("300A0244")}; }
        }

        public static DecimalString TotalReferenceAirKerma
        {
            get { return new DecimalString {Tag = new Tag("300A0250")}; }
        }

        public static Sequence BrachyAccessoryDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A0260")}; }
        }

        public static IntegerString BrachyAccessoryDeviceNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0262")}; }
        }

        public static ShortString BrachyAccessoryDeviceID
        {
            get { return new ShortString {Tag = new Tag("300A0263")}; }
        }

        public static CodeString BrachyAccessoryDeviceType
        {
            get { return new CodeString {Tag = new Tag("300A0264")}; }
        }

        public static LongString BrachyAccessoryDeviceName
        {
            get { return new LongString {Tag = new Tag("300A0266")}; }
        }

        public static DecimalString BrachyAccessoryDeviceNominalThickness
        {
            get { return new DecimalString {Tag = new Tag("300A026A")}; }
        }

        public static DecimalString BrachyAccessoryDeviceNominalTransmission
        {
            get { return new DecimalString {Tag = new Tag("300A026C")}; }
        }

        public static Sequence ChannelSequence
        {
            get { return new Sequence {Tag = new Tag("300A0280")}; }
        }

        public static IntegerString ChannelNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0282")}; }
        }

        public static DecimalString ChannelLength
        {
            get { return new DecimalString {Tag = new Tag("300A0284")}; }
        }

        public static DecimalString ChannelTotalTime
        {
            get { return new DecimalString {Tag = new Tag("300A0286")}; }
        }

        public static CodeString SourceMovementType
        {
            get { return new CodeString {Tag = new Tag("300A0288")}; }
        }

        public static IntegerString NumberOfPulses
        {
            get { return new IntegerString {Tag = new Tag("300A028A")}; }
        }

        public static DecimalString PulseRepetitionInterval
        {
            get { return new DecimalString {Tag = new Tag("300A028C")}; }
        }

        public static IntegerString SourceApplicatorNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0290")}; }
        }

        public static ShortString SourceApplicatorID
        {
            get { return new ShortString {Tag = new Tag("300A0291")}; }
        }

        public static CodeString SourceApplicatorType
        {
            get { return new CodeString {Tag = new Tag("300A0292")}; }
        }

        public static LongString SourceApplicatorName
        {
            get { return new LongString {Tag = new Tag("300A0294")}; }
        }

        public static DecimalString SourceApplicatorLength
        {
            get { return new DecimalString {Tag = new Tag("300A0296")}; }
        }

        public static LongString SourceApplicatorManufacturer
        {
            get { return new LongString {Tag = new Tag("300A0298")}; }
        }

        public static DecimalString SourceApplicatorWallNominalThickness
        {
            get { return new DecimalString {Tag = new Tag("300A029C")}; }
        }

        public static DecimalString SourceApplicatorWallNominalTransmission
        {
            get { return new DecimalString {Tag = new Tag("300A029E")}; }
        }

        public static DecimalString SourceApplicatorStepSize
        {
            get { return new DecimalString {Tag = new Tag("300A02A0")}; }
        }

        public static IntegerString TransferTubeNumber
        {
            get { return new IntegerString {Tag = new Tag("300A02A2")}; }
        }

        public static DecimalString TransferTubeLength
        {
            get { return new DecimalString {Tag = new Tag("300A02A4")}; }
        }

        public static Sequence ChannelShieldSequence
        {
            get { return new Sequence {Tag = new Tag("300A02B0")}; }
        }

        public static IntegerString ChannelShieldNumber
        {
            get { return new IntegerString {Tag = new Tag("300A02B2")}; }
        }

        public static ShortString ChannelShieldID
        {
            get { return new ShortString {Tag = new Tag("300A02B3")}; }
        }

        public static LongString ChannelShieldName
        {
            get { return new LongString {Tag = new Tag("300A02B4")}; }
        }

        public static DecimalString ChannelShieldNominalThickness
        {
            get { return new DecimalString {Tag = new Tag("300A02B8")}; }
        }

        public static DecimalString ChannelShieldNominalTransmission
        {
            get { return new DecimalString {Tag = new Tag("300A02BA")}; }
        }

        public static DecimalString FinalCumulativeTimeWeight
        {
            get { return new DecimalString {Tag = new Tag("300A02C8")}; }
        }

        public static Sequence BrachyControlPointSequence
        {
            get { return new Sequence {Tag = new Tag("300A02D0")}; }
        }

        public static DecimalString ControlPointRelativePosition
        {
            get { return new DecimalString {Tag = new Tag("300A02D2")}; }
        }

        public static DecimalString ControlPoint3DPosition
        {
            get { return new DecimalString {Tag = new Tag("300A02D4")}; }
        }

        public static DecimalString CumulativeTimeWeight
        {
            get { return new DecimalString {Tag = new Tag("300A02D6")}; }
        }

        public static CodeString CompensatorDivergence
        {
            get { return new CodeString {Tag = new Tag("300A02E0")}; }
        }

        public static CodeString CompensatorMountingPosition
        {
            get { return new CodeString {Tag = new Tag("300A02E1")}; }
        }

        public static DecimalString SourceToCompensatorDistance
        {
            get { return new DecimalString {Tag = new Tag("300A02E2")}; }
        }

        public static FloatingPointSingle TotalCompensatorTrayWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A02E3")}; }
        }

        public static FloatingPointSingle IsocenterToCompensatorTrayDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A02E4")}; }
        }

        public static FloatingPointSingle CompensatorColumnOffset
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A02E5")}; }
        }

        public static FloatingPointSingle IsocenterToCompensatorDistances
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A02E6")}; }
        }

        public static FloatingPointSingle CompensatorRelativeStoppingPowerRatio
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A02E7")}; }
        }

        public static FloatingPointSingle CompensatorMillingToolDiameter
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A02E8")}; }
        }

        public static Sequence IonRangeCompensatorSequence
        {
            get { return new Sequence {Tag = new Tag("300A02EA")}; }
        }

        public static LongText CompensatorDescription
        {
            get { return new LongText {Tag = new Tag("300A02EB")}; }
        }

        public static IntegerString RadiationMassNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0302")}; }
        }

        public static IntegerString RadiationAtomicNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0304")}; }
        }

        public static SignedShort RadiationChargeState
        {
            get { return new SignedShort {Tag = new Tag("300A0306")}; }
        }

        public static CodeString ScanMode
        {
            get { return new CodeString {Tag = new Tag("300A0308")}; }
        }

        public static FloatingPointSingle VirtualSourceAxisDistances
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A030A")}; }
        }

        public static Sequence SnoutSequence
        {
            get { return new Sequence {Tag = new Tag("300A030C")}; }
        }

        public static FloatingPointSingle SnoutPosition
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A030D")}; }
        }

        public static ShortString SnoutID
        {
            get { return new ShortString {Tag = new Tag("300A030F")}; }
        }

        public static IntegerString NumberOfRangeShifters
        {
            get { return new IntegerString {Tag = new Tag("300A0312")}; }
        }

        public static Sequence RangeShifterSequence
        {
            get { return new Sequence {Tag = new Tag("300A0314")}; }
        }

        public static IntegerString RangeShifterNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0316")}; }
        }

        public static ShortString RangeShifterID
        {
            get { return new ShortString {Tag = new Tag("300A0318")}; }
        }

        public static CodeString RangeShifterType
        {
            get { return new CodeString {Tag = new Tag("300A0320")}; }
        }

        public static LongString RangeShifterDescription
        {
            get { return new LongString {Tag = new Tag("300A0322")}; }
        }

        public static IntegerString NumberOfLateralSpreadingDevices
        {
            get { return new IntegerString {Tag = new Tag("300A0330")}; }
        }

        public static Sequence LateralSpreadingDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A0332")}; }
        }

        public static IntegerString LateralSpreadingDeviceNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0334")}; }
        }

        public static ShortString LateralSpreadingDeviceID
        {
            get { return new ShortString {Tag = new Tag("300A0336")}; }
        }

        public static CodeString LateralSpreadingDeviceType
        {
            get { return new CodeString {Tag = new Tag("300A0338")}; }
        }

        public static LongString LateralSpreadingDeviceDescription
        {
            get { return new LongString {Tag = new Tag("300A033A")}; }
        }

        public static FloatingPointSingle LateralSpreadingDeviceWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A033C")}; }
        }

        public static IntegerString NumberOfRangeModulators
        {
            get { return new IntegerString {Tag = new Tag("300A0340")}; }
        }

        public static Sequence RangeModulatorSequence
        {
            get { return new Sequence {Tag = new Tag("300A0342")}; }
        }

        public static IntegerString RangeModulatorNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0344")}; }
        }

        public static ShortString RangeModulatorID
        {
            get { return new ShortString {Tag = new Tag("300A0346")}; }
        }

        public static CodeString RangeModulatorType
        {
            get { return new CodeString {Tag = new Tag("300A0348")}; }
        }

        public static LongString RangeModulatorDescription
        {
            get { return new LongString {Tag = new Tag("300A034A")}; }
        }

        public static ShortString BeamCurrentModulationID
        {
            get { return new ShortString {Tag = new Tag("300A034C")}; }
        }

        public static CodeString PatientSupportType
        {
            get { return new CodeString {Tag = new Tag("300A0350")}; }
        }

        public static ShortString PatientSupportID
        {
            get { return new ShortString {Tag = new Tag("300A0352")}; }
        }

        public static LongString PatientSupportAccessoryCode
        {
            get { return new LongString {Tag = new Tag("300A0354")}; }
        }

        public static FloatingPointSingle FixationLightAzimuthalAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0356")}; }
        }

        public static FloatingPointSingle FixationLightPolarAngle
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0358")}; }
        }

        public static FloatingPointSingle MetersetRate
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A035A")}; }
        }

        public static Sequence RangeShifterSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("300A0360")}; }
        }

        public static LongString RangeShifterSetting
        {
            get { return new LongString {Tag = new Tag("300A0362")}; }
        }

        public static FloatingPointSingle IsocenterToRangeShifterDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0364")}; }
        }

        public static FloatingPointSingle RangeShifterWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0366")}; }
        }

        public static Sequence LateralSpreadingDeviceSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("300A0370")}; }
        }

        public static LongString LateralSpreadingDeviceSetting
        {
            get { return new LongString {Tag = new Tag("300A0372")}; }
        }

        public static FloatingPointSingle IsocenterToLateralSpreadingDeviceDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0374")}; }
        }

        public static Sequence RangeModulatorSettingsSequence
        {
            get { return new Sequence {Tag = new Tag("300A0380")}; }
        }

        public static FloatingPointSingle RangeModulatorGatingStartValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0382")}; }
        }

        public static FloatingPointSingle RangeModulatorGatingStopValue
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0384")}; }
        }

        public static FloatingPointSingle RangeModulatorGatingStartWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0386")}; }
        }

        public static FloatingPointSingle RangeModulatorGatingStopWaterEquivalentThickness
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0388")}; }
        }

        public static FloatingPointSingle IsocenterToRangeModulatorDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A038A")}; }
        }

        public static ShortString ScanSpotTuneID
        {
            get { return new ShortString {Tag = new Tag("300A0390")}; }
        }

        public static IntegerString NumberOfScanSpotPositions
        {
            get { return new IntegerString {Tag = new Tag("300A0392")}; }
        }

        public static FloatingPointSingle ScanSpotPositionMap
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0394")}; }
        }

        public static FloatingPointSingle ScanSpotMetersetWeights
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0396")}; }
        }

        public static FloatingPointSingle ScanningSpotSize
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0398")}; }
        }

        public static IntegerString NumberOfPaintings
        {
            get { return new IntegerString {Tag = new Tag("300A039A")}; }
        }

        public static Sequence IonToleranceTableSequence
        {
            get { return new Sequence {Tag = new Tag("300A03A0")}; }
        }

        public static Sequence IonBeamSequence
        {
            get { return new Sequence {Tag = new Tag("300A03A2")}; }
        }

        public static Sequence IonBeamLimitingDeviceSequence
        {
            get { return new Sequence {Tag = new Tag("300A03A4")}; }
        }

        public static Sequence IonBlockSequence
        {
            get { return new Sequence {Tag = new Tag("300A03A6")}; }
        }

        public static Sequence IonControlPointSequence
        {
            get { return new Sequence {Tag = new Tag("300A03A8")}; }
        }

        public static Sequence IonWedgeSequence
        {
            get { return new Sequence {Tag = new Tag("300A03AA")}; }
        }

        public static Sequence IonWedgePositionSequence
        {
            get { return new Sequence {Tag = new Tag("300A03AC")}; }
        }

        public static Sequence ReferencedSetupImageSequence
        {
            get { return new Sequence {Tag = new Tag("300A0401")}; }
        }

        public static ShortText SetupImageComment
        {
            get { return new ShortText {Tag = new Tag("300A0402")}; }
        }

        public static Sequence MotionSynchronizationSequence
        {
            get { return new Sequence {Tag = new Tag("300A0410")}; }
        }

        public static FloatingPointSingle ControlPointOrientation
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0412")}; }
        }

        public static Sequence GeneralAccessorySequence
        {
            get { return new Sequence {Tag = new Tag("300A0420")}; }
        }

        public static ShortString GeneralAccessoryID
        {
            get { return new ShortString {Tag = new Tag("300A0421")}; }
        }

        public static ShortText GeneralAccessoryDescription
        {
            get { return new ShortText {Tag = new Tag("300A0422")}; }
        }

        public static CodeString GeneralAccessoryType
        {
            get { return new CodeString {Tag = new Tag("300A0423")}; }
        }

        public static IntegerString GeneralAccessoryNumber
        {
            get { return new IntegerString {Tag = new Tag("300A0424")}; }
        }

        public static Sequence ApplicatorGeometrySequence
        {
            get { return new Sequence {Tag = new Tag("300A0431")}; }
        }

        public static CodeString ApplicatorApertureShape
        {
            get { return new CodeString {Tag = new Tag("300A0432")}; }
        }

        public static FloatingPointSingle ApplicatorOpening
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0433")}; }
        }

        public static FloatingPointSingle ApplicatorOpeningX
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0434")}; }
        }

        public static FloatingPointSingle ApplicatorOpeningY
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0435")}; }
        }

        public static FloatingPointSingle SourceToApplicatorMountingPositionDistance
        {
            get { return new FloatingPointSingle {Tag = new Tag("300A0436")}; }
        }

        public static Sequence ReferencedRTPlanSequence
        {
            get { return new Sequence {Tag = new Tag("300C0002")}; }
        }

        public static Sequence ReferencedBeamSequence
        {
            get { return new Sequence {Tag = new Tag("300C0004")}; }
        }

        public static IntegerString ReferencedBeamNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0006")}; }
        }

        public static IntegerString ReferencedReferenceImageNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0007")}; }
        }

        public static DecimalString StartCumulativeMetersetWeight
        {
            get { return new DecimalString {Tag = new Tag("300C0008")}; }
        }

        public static DecimalString EndCumulativeMetersetWeight
        {
            get { return new DecimalString {Tag = new Tag("300C0009")}; }
        }

        public static Sequence ReferencedBrachyApplicationSetupSequence
        {
            get { return new Sequence {Tag = new Tag("300C000A")}; }
        }

        public static IntegerString ReferencedBrachyApplicationSetupNumber
        {
            get { return new IntegerString {Tag = new Tag("300C000C")}; }
        }

        public static IntegerString ReferencedSourceNumber
        {
            get { return new IntegerString {Tag = new Tag("300C000E")}; }
        }

        public static Sequence ReferencedFractionGroupSequence
        {
            get { return new Sequence {Tag = new Tag("300C0020")}; }
        }

        public static IntegerString ReferencedFractionGroupNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0022")}; }
        }

        public static Sequence ReferencedVerificationImageSequence
        {
            get { return new Sequence {Tag = new Tag("300C0040")}; }
        }

        public static Sequence ReferencedReferenceImageSequence
        {
            get { return new Sequence {Tag = new Tag("300C0042")}; }
        }

        public static Sequence ReferencedDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("300C0050")}; }
        }

        public static IntegerString ReferencedDoseReferenceNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0051")}; }
        }

        public static Sequence BrachyReferencedDoseReferenceSequence
        {
            get { return new Sequence {Tag = new Tag("300C0055")}; }
        }

        public static Sequence ReferencedStructureSetSequence
        {
            get { return new Sequence {Tag = new Tag("300C0060")}; }
        }

        public static IntegerString ReferencedPatientSetupNumber
        {
            get { return new IntegerString {Tag = new Tag("300C006A")}; }
        }

        public static Sequence ReferencedDoseSequence
        {
            get { return new Sequence {Tag = new Tag("300C0080")}; }
        }

        public static IntegerString ReferencedToleranceTableNumber
        {
            get { return new IntegerString {Tag = new Tag("300C00A0")}; }
        }

        public static Sequence ReferencedBolusSequence
        {
            get { return new Sequence {Tag = new Tag("300C00B0")}; }
        }

        public static IntegerString ReferencedWedgeNumber
        {
            get { return new IntegerString {Tag = new Tag("300C00C0")}; }
        }

        public static IntegerString ReferencedCompensatorNumber
        {
            get { return new IntegerString {Tag = new Tag("300C00D0")}; }
        }

        public static IntegerString ReferencedBlockNumber
        {
            get { return new IntegerString {Tag = new Tag("300C00E0")}; }
        }

        public static IntegerString ReferencedControlPointIndex
        {
            get { return new IntegerString {Tag = new Tag("300C00F0")}; }
        }

        public static Sequence ReferencedControlPointSequence
        {
            get { return new Sequence {Tag = new Tag("300C00F2")}; }
        }

        public static IntegerString ReferencedStartControlPointIndex
        {
            get { return new IntegerString {Tag = new Tag("300C00F4")}; }
        }

        public static IntegerString ReferencedStopControlPointIndex
        {
            get { return new IntegerString {Tag = new Tag("300C00F6")}; }
        }

        public static IntegerString ReferencedRangeShifterNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0100")}; }
        }

        public static IntegerString ReferencedLateralSpreadingDeviceNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0102")}; }
        }

        public static IntegerString ReferencedRangeModulatorNumber
        {
            get { return new IntegerString {Tag = new Tag("300C0104")}; }
        }

        public static CodeString ApprovalStatus
        {
            get { return new CodeString {Tag = new Tag("300E0002")}; }
        }

        public static Date ReviewDate
        {
            get { return new Date {Tag = new Tag("300E0004")}; }
        }

        public static Time ReviewTime
        {
            get { return new Time {Tag = new Tag("300E0005")}; }
        }

        public static PersonName ReviewerName
        {
            get { return new PersonName {Tag = new Tag("300E0008")}; }
        }

        public static LongText ArbitraryRetired
        {
            get { return new LongText {Tag = new Tag("40000010")}; }
        }

        public static LongText TextCommentsRetired
        {
            get { return new LongText {Tag = new Tag("40004000")}; }
        }

        public static ShortString ResultsIDRetired
        {
            get { return new ShortString {Tag = new Tag("40080040")}; }
        }

        public static LongString ResultsIDIssuerRetired
        {
            get { return new LongString {Tag = new Tag("40080042")}; }
        }

        public static Sequence ReferencedInterpretationSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("40080050")}; }
        }

        public static CodeString ReportProductionStatusTrialRetired
        {
            get { return new CodeString {Tag = new Tag("400800FF")}; }
        }

        public static Date InterpretationRecordedDateRetired
        {
            get { return new Date {Tag = new Tag("40080100")}; }
        }

        public static Time InterpretationRecordedTimeRetired
        {
            get { return new Time {Tag = new Tag("40080101")}; }
        }

        public static PersonName InterpretationRecorderRetired
        {
            get { return new PersonName {Tag = new Tag("40080102")}; }
        }

        public static LongString ReferenceToRecordedSoundRetired
        {
            get { return new LongString {Tag = new Tag("40080103")}; }
        }

        public static Date InterpretationTranscriptionDateRetired
        {
            get { return new Date {Tag = new Tag("40080108")}; }
        }

        public static Time InterpretationTranscriptionTimeRetired
        {
            get { return new Time {Tag = new Tag("40080109")}; }
        }

        public static PersonName InterpretationTranscriberRetired
        {
            get { return new PersonName {Tag = new Tag("4008010A")}; }
        }

        public static ShortText InterpretationTextRetired
        {
            get { return new ShortText {Tag = new Tag("4008010B")}; }
        }

        public static PersonName InterpretationAuthorRetired
        {
            get { return new PersonName {Tag = new Tag("4008010C")}; }
        }

        public static Sequence InterpretationApproverSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("40080111")}; }
        }

        public static Date InterpretationApprovalDateRetired
        {
            get { return new Date {Tag = new Tag("40080112")}; }
        }

        public static Time InterpretationApprovalTimeRetired
        {
            get { return new Time {Tag = new Tag("40080113")}; }
        }

        public static PersonName PhysicianApprovingInterpretationRetired
        {
            get { return new PersonName {Tag = new Tag("40080114")}; }
        }

        public static LongText InterpretationDiagnosisDescriptionRetired
        {
            get { return new LongText {Tag = new Tag("40080115")}; }
        }

        public static Sequence InterpretationDiagnosisCodeSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("40080117")}; }
        }

        public static Sequence ResultsDistributionListSequenceRetired
        {
            get { return new Sequence {Tag = new Tag("40080118")}; }
        }

        public static PersonName DistributionNameRetired
        {
            get { return new PersonName {Tag = new Tag("40080119")}; }
        }

        public static LongString DistributionAddressRetired
        {
            get { return new LongString {Tag = new Tag("4008011A")}; }
        }

        public static ShortString InterpretationIDRetired
        {
            get { return new ShortString {Tag = new Tag("40080200")}; }
        }

        public static LongString InterpretationIDIssuerRetired
        {
            get { return new LongString {Tag = new Tag("40080202")}; }
        }

        public static CodeString InterpretationTypeIDRetired
        {
            get { return new CodeString {Tag = new Tag("40080210")}; }
        }

        public static CodeString InterpretationStatusIDRetired
        {
            get { return new CodeString {Tag = new Tag("40080212")}; }
        }

        public static ShortText ImpressionsRetired
        {
            get { return new ShortText {Tag = new Tag("40080300")}; }
        }

        public static ShortText ResultsCommentsRetired
        {
            get { return new ShortText {Tag = new Tag("40084000")}; }
        }

        public static CodeString LowEnergyDetectors
        {
            get { return new CodeString {Tag = new Tag("40100001")}; }
        }

        public static CodeString HighEnergyDetectors
        {
            get { return new CodeString {Tag = new Tag("40100002")}; }
        }

        public static Sequence DetectorGeometrySequence
        {
            get { return new Sequence {Tag = new Tag("40100004")}; }
        }

        public static Sequence ThreatROIVoxelSequence
        {
            get { return new Sequence {Tag = new Tag("40101001")}; }
        }

        public static FloatingPointSingle ThreatROIBase
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101004")}; }
        }

        public static FloatingPointSingle ThreatROIExtents
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101005")}; }
        }

        public static OtherByteString ThreatROIBitmap
        {
            get { return new OtherByteString {Tag = new Tag("40101006")}; }
        }

        public static ShortString RouteSegmentID
        {
            get { return new ShortString {Tag = new Tag("40101007")}; }
        }

        public static CodeString GantryType
        {
            get { return new CodeString {Tag = new Tag("40101008")}; }
        }

        public static CodeString OOIOwnerType
        {
            get { return new CodeString {Tag = new Tag("40101009")}; }
        }

        public static Sequence RouteSegmentSequence
        {
            get { return new Sequence {Tag = new Tag("4010100A")}; }
        }

        public static UnsignedShort PotentialThreatObjectID
        {
            get { return new UnsignedShort {Tag = new Tag("40101010")}; }
        }

        public static Sequence ThreatSequence
        {
            get { return new Sequence {Tag = new Tag("40101011")}; }
        }

        public static CodeString ThreatCategory
        {
            get { return new CodeString {Tag = new Tag("40101012")}; }
        }

        public static LongText ThreatCategoryDescription
        {
            get { return new LongText {Tag = new Tag("40101013")}; }
        }

        public static CodeString ATDAbilityAssessment
        {
            get { return new CodeString {Tag = new Tag("40101014")}; }
        }

        public static CodeString ATDAssessmentFlag
        {
            get { return new CodeString {Tag = new Tag("40101015")}; }
        }

        public static FloatingPointSingle ATDAssessmentProbability
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101016")}; }
        }

        public static FloatingPointSingle Mass
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101017")}; }
        }

        public static FloatingPointSingle Density
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101018")}; }
        }

        public static FloatingPointSingle ZEffective
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101019")}; }
        }

        public static ShortString BoardingPassID
        {
            get { return new ShortString {Tag = new Tag("4010101A")}; }
        }

        public static FloatingPointSingle CenterOfMass
        {
            get { return new FloatingPointSingle {Tag = new Tag("4010101B")}; }
        }

        public static FloatingPointSingle CenterOfPTO
        {
            get { return new FloatingPointSingle {Tag = new Tag("4010101C")}; }
        }

        public static FloatingPointSingle BoundingPolygon
        {
            get { return new FloatingPointSingle {Tag = new Tag("4010101D")}; }
        }

        public static ShortString RouteSegmentStartLocationID
        {
            get { return new ShortString {Tag = new Tag("4010101E")}; }
        }

        public static ShortString RouteSegmentEndLocationID
        {
            get { return new ShortString {Tag = new Tag("4010101F")}; }
        }

        public static CodeString RouteSegmentLocationIDType
        {
            get { return new CodeString {Tag = new Tag("40101020")}; }
        }

        public static CodeString AbortReason
        {
            get { return new CodeString {Tag = new Tag("40101021")}; }
        }

        public static FloatingPointSingle VolumeOfPTO
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101023")}; }
        }

        public static CodeString AbortFlag
        {
            get { return new CodeString {Tag = new Tag("40101024")}; }
        }

        public static CodeString TDRType
        {
            get { return new CodeString {Tag = new Tag("40101027")}; }
        }

        public static CodeString InternationalRouteSegment
        {
            get { return new CodeString {Tag = new Tag("40101028")}; }
        }

        public static LongString ThreatDetectionAlgorithmandVersion
        {
            get { return new LongString {Tag = new Tag("40101029")}; }
        }

        public static ShortString AssignedLocation
        {
            get { return new ShortString {Tag = new Tag("4010102A")}; }
        }

        public static CodeString AlarmDecision
        {
            get { return new CodeString {Tag = new Tag("40101031")}; }
        }

        public static UnsignedShort NumberOfTotalObjects
        {
            get { return new UnsignedShort {Tag = new Tag("40101033")}; }
        }

        public static UnsignedShort NumberOfAlarmObjects
        {
            get { return new UnsignedShort {Tag = new Tag("40101034")}; }
        }

        public static Sequence PTORepresentationSequence
        {
            get { return new Sequence {Tag = new Tag("40101037")}; }
        }

        public static Sequence ATDAssessmentSequence
        {
            get { return new Sequence {Tag = new Tag("40101038")}; }
        }

        public static CodeString TIPType
        {
            get { return new CodeString {Tag = new Tag("40101039")}; }
        }

        public static CodeString DICOSVersion
        {
            get { return new CodeString {Tag = new Tag("4010103A")}; }
        }

        public static CodeString OOIType
        {
            get { return new CodeString {Tag = new Tag("40101042")}; }
        }

        public static FloatingPointSingle OOISize
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101043")}; }
        }

        public static CodeString AcquisitionStatus
        {
            get { return new CodeString {Tag = new Tag("40101044")}; }
        }

        public static Sequence BasisMaterialsCodeSequence
        {
            get { return new Sequence {Tag = new Tag("40101045")}; }
        }

        public static CodeString PhantomType
        {
            get { return new CodeString {Tag = new Tag("40101046")}; }
        }

        public static Sequence OOIOwnerSequence
        {
            get { return new Sequence {Tag = new Tag("40101047")}; }
        }

        public static CodeString ScanType
        {
            get { return new CodeString {Tag = new Tag("40101048")}; }
        }

        public static LongString ItineraryID
        {
            get { return new LongString {Tag = new Tag("40101051")}; }
        }

        public static ShortString ItineraryIDType
        {
            get { return new ShortString {Tag = new Tag("40101052")}; }
        }

        public static LongString ItineraryIDAssigningAuthority
        {
            get { return new LongString {Tag = new Tag("40101053")}; }
        }

        public static ShortString RouteID
        {
            get { return new ShortString {Tag = new Tag("40101054")}; }
        }

        public static ShortString RouteIDAssigningAuthority
        {
            get { return new ShortString {Tag = new Tag("40101055")}; }
        }

        public static CodeString InboundArrivalType
        {
            get { return new CodeString {Tag = new Tag("40101056")}; }
        }

        public static ShortString CarrierID
        {
            get { return new ShortString {Tag = new Tag("40101058")}; }
        }

        public static CodeString CarrierIDAssigningAuthority
        {
            get { return new CodeString {Tag = new Tag("40101059")}; }
        }

        public static FloatingPointSingle SourceOrientation
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101060")}; }
        }

        public static FloatingPointSingle SourcePosition
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101061")}; }
        }

        public static FloatingPointSingle BeltHeight
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101062")}; }
        }

        public static Sequence AlgorithmRoutingCodeSequence
        {
            get { return new Sequence {Tag = new Tag("40101064")}; }
        }

        public static CodeString TransportClassification
        {
            get { return new CodeString {Tag = new Tag("40101067")}; }
        }

        public static LongText OOITypeDescriptor
        {
            get { return new LongText {Tag = new Tag("40101068")}; }
        }

        public static FloatingPointSingle TotalProcessingTime
        {
            get { return new FloatingPointSingle {Tag = new Tag("40101069")}; }
        }

        public static OtherByteString DetectorCalibrationData
        {
            get { return new OtherByteString {Tag = new Tag("4010106C")}; }
        }

        public static Sequence MACParametersSequence
        {
            get { return new Sequence {Tag = new Tag("4FFE0001")}; }
        }

        public static UnsignedShort CurveDimensionsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0005")}; }
        }

        public static UnsignedShort NumberOfPointsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0010")}; }
        }

        public static CodeString TypeOfDataRetired
        {
            get { return new CodeString {Tag = new Tag("50xx0020")}; }
        }

        public static LongString CurveDescriptionRetired
        {
            get { return new LongString {Tag = new Tag("50xx0022")}; }
        }

        public static ShortString AxisUnitsRetired
        {
            get { return new ShortString {Tag = new Tag("50xx0030")}; }
        }

        public static ShortString AxisLabelsRetired
        {
            get { return new ShortString {Tag = new Tag("50xx0040")}; }
        }

        public static UnsignedShort DataValueRepresentationRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0103")}; }
        }

        public static UnsignedShort MinimumCoordinateValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0104")}; }
        }

        public static UnsignedShort MaximumCoordinateValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0105")}; }
        }

        public static ShortString CurveRangeRetired
        {
            get { return new ShortString {Tag = new Tag("50xx0106")}; }
        }

        public static UnsignedShort CurveDataDescriptorRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0110")}; }
        }

        public static UnsignedShort CoordinateStartValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0112")}; }
        }

        public static UnsignedShort CoordinateStepValueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx0114")}; }
        }

        public static CodeString CurveActivationLayerRetired
        {
            get { return new CodeString {Tag = new Tag("50xx1001")}; }
        }

        public static UnsignedShort AudioTypeRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx2000")}; }
        }

        public static UnsignedShort AudioSampleFormatRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx2002")}; }
        }

        public static UnsignedShort NumberOfChannelsRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx2004")}; }
        }

        public static UnsignedLong NumberOfSamplesRetired
        {
            get { return new UnsignedLong {Tag = new Tag("50xx2006")}; }
        }

        public static UnsignedLong SampleRateRetired
        {
            get { return new UnsignedLong {Tag = new Tag("50xx2008")}; }
        }

        public static UnsignedLong TotalTimeRetired
        {
            get { return new UnsignedLong {Tag = new Tag("50xx200A")}; }
        }

        public static OtherWordString AudioSampleDataRetired
        {
            get { return new OtherWordString {Tag = new Tag("50xx200C")}; }
        }

        public static LongText AudioCommentsRetired
        {
            get { return new LongText {Tag = new Tag("50xx200E")}; }
        }

        public static LongString CurveLabelRetired
        {
            get { return new LongString {Tag = new Tag("50xx2500")}; }
        }

        public static Sequence CurveReferencedOverlaySequenceRetired
        {
            get { return new Sequence {Tag = new Tag("50xx2600")}; }
        }

        public static UnsignedShort CurveReferencedOverlayGroupRetired
        {
            get { return new UnsignedShort {Tag = new Tag("50xx2610")}; }
        }

        public static OtherWordString CurveDataRetired
        {
            get { return new OtherWordString {Tag = new Tag("50xx3000")}; }
        }

        public static Sequence SharedFunctionalGroupsSequence
        {
            get { return new Sequence {Tag = new Tag("52009229")}; }
        }

        public static Sequence PerFrameFunctionalGroupsSequence
        {
            get { return new Sequence {Tag = new Tag("52009230")}; }
        }

        public static Sequence WaveformSequence
        {
            get { return new Sequence {Tag = new Tag("54000100")}; }
        }

        public static OtherByteString ChannelMinimumValue
        {
            get { return new OtherByteString {Tag = new Tag("54000110")}; }
        }

        public static OtherByteString ChannelMaximumValue
        {
            get { return new OtherByteString {Tag = new Tag("54000112")}; }
        }

        public static UnsignedShort WaveformBitsAllocated
        {
            get { return new UnsignedShort {Tag = new Tag("54001004")}; }
        }

        public static CodeString WaveformSampleInterpretation
        {
            get { return new CodeString {Tag = new Tag("54001006")}; }
        }

        public static OtherByteString WaveformPaddingValue
        {
            get { return new OtherByteString {Tag = new Tag("5400100A")}; }
        }

        public static OtherByteString WaveformData
        {
            get { return new OtherByteString {Tag = new Tag("54001010")}; }
        }

        public static OtherFloatString FirstOrderPhaseCorrectionAngle
        {
            get { return new OtherFloatString {Tag = new Tag("56000010")}; }
        }

        public static OtherFloatString SpectroscopyData
        {
            get { return new OtherFloatString {Tag = new Tag("56000020")}; }
        }

        public static UnsignedShort OverlayRows
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0010")}; }
        }

        public static UnsignedShort OverlayColumns
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0011")}; }
        }

        public static UnsignedShort OverlayPlanesRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0012")}; }
        }

        public static IntegerString NumberOfFramesInOverlay
        {
            get { return new IntegerString {Tag = new Tag("60xx0015")}; }
        }

        public static LongString OverlayDescription
        {
            get { return new LongString {Tag = new Tag("60xx0022")}; }
        }

        public static CodeString OverlayType
        {
            get { return new CodeString {Tag = new Tag("60xx0040")}; }
        }

        public static LongString OverlaySubtype
        {
            get { return new LongString {Tag = new Tag("60xx0045")}; }
        }

        public static SignedShort OverlayOrigin
        {
            get { return new SignedShort {Tag = new Tag("60xx0050")}; }
        }

        public static UnsignedShort ImageFrameOrigin
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0051")}; }
        }

        public static UnsignedShort OverlayPlaneOriginRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0052")}; }
        }

        public static CodeString OverlayCompressionCodeRetired
        {
            get { return new CodeString {Tag = new Tag("60xx0060")}; }
        }

        public static ShortString OverlayCompressionOriginatorRetired
        {
            get { return new ShortString {Tag = new Tag("60xx0061")}; }
        }

        public static ShortString OverlayCompressionLabelRetired
        {
            get { return new ShortString {Tag = new Tag("60xx0062")}; }
        }

        public static CodeString OverlayCompressionDescriptionRetired
        {
            get { return new CodeString {Tag = new Tag("60xx0063")}; }
        }

        public static AttributeTag OverlayCompressionStepPointersRetired
        {
            get { return new AttributeTag {Tag = new Tag("60xx0066")}; }
        }

        public static UnsignedShort OverlayRepeatIntervalRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0068")}; }
        }

        public static UnsignedShort OverlayBitsGroupedRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0069")}; }
        }

        public static UnsignedShort OverlayBitsAllocated
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0100")}; }
        }

        public static UnsignedShort OverlayBitPosition
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0102")}; }
        }

        public static CodeString OverlayFormatRetired
        {
            get { return new CodeString {Tag = new Tag("60xx0110")}; }
        }

        public static UnsignedShort OverlayLocationRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0200")}; }
        }

        public static CodeString OverlayCodeLabelRetired
        {
            get { return new CodeString {Tag = new Tag("60xx0800")}; }
        }

        public static UnsignedShort OverlayNumberOfTablesRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0802")}; }
        }

        public static AttributeTag OverlayCodeTableLocationRetired
        {
            get { return new AttributeTag {Tag = new Tag("60xx0803")}; }
        }

        public static UnsignedShort OverlayBitsForCodeWordRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx0804")}; }
        }

        public static CodeString OverlayActivationLayer
        {
            get { return new CodeString {Tag = new Tag("60xx1001")}; }
        }

        public static UnsignedShort OverlayDescriptorGrayRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1100")}; }
        }

        public static UnsignedShort OverlayDescriptorRedRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1101")}; }
        }

        public static UnsignedShort OverlayDescriptorGreenRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1102")}; }
        }

        public static UnsignedShort OverlayDescriptorBlueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1103")}; }
        }

        public static UnsignedShort OverlaysGrayRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1200")}; }
        }

        public static UnsignedShort OverlaysRedRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1201")}; }
        }

        public static UnsignedShort OverlaysGreenRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1202")}; }
        }

        public static UnsignedShort OverlaysBlueRetired
        {
            get { return new UnsignedShort {Tag = new Tag("60xx1203")}; }
        }

        public static IntegerString ROIArea
        {
            get { return new IntegerString {Tag = new Tag("60xx1301")}; }
        }

        public static DecimalString ROIMean
        {
            get { return new DecimalString {Tag = new Tag("60xx1302")}; }
        }

        public static DecimalString ROIStandardDeviation
        {
            get { return new DecimalString {Tag = new Tag("60xx1303")}; }
        }

        public static LongString OverlayLabel
        {
            get { return new LongString {Tag = new Tag("60xx1500")}; }
        }

        public static OtherByteString OverlayData
        {
            get { return new OtherByteString {Tag = new Tag("60xx3000")}; }
        }

        public static LongText OverlayCommentsRetired
        {
            get { return new LongText {Tag = new Tag("60xx4000")}; }
        }

        public static OtherWordString PixelData
        {
            get { return new OtherWordString {Tag = new Tag("7FE00010")}; }
        }

        public static OtherWordString CoefficientsSDVNRetired
        {
            get { return new OtherWordString {Tag = new Tag("7FE00020")}; }
        }

        public static OtherWordString CoefficientsSDHNRetired
        {
            get { return new OtherWordString {Tag = new Tag("7FE00030")}; }
        }

        public static OtherWordString CoefficientsSDDNRetired
        {
            get { return new OtherWordString {Tag = new Tag("7FE00040")}; }
        }

        public static OtherWordString VariablePixelDataRetired
        {
            get { return new OtherWordString {Tag = new Tag("7Fxx0010")}; }
        }

        public static UnsignedShort VariableNextDataGroupRetired
        {
            get { return new UnsignedShort {Tag = new Tag("7Fxx0011")}; }
        }

        public static OtherWordString VariableCoefficientsSDVNRetired
        {
            get { return new OtherWordString {Tag = new Tag("7Fxx0020")}; }
        }

        public static OtherWordString VariableCoefficientsSDHNRetired
        {
            get { return new OtherWordString {Tag = new Tag("7Fxx0030")}; }
        }

        public static OtherWordString VariableCoefficientsSDDNRetired
        {
            get { return new OtherWordString {Tag = new Tag("7Fxx0040")}; }
        }

        public static Sequence DigitalSignaturesSequence
        {
            get { return new Sequence {Tag = new Tag("FFFAFFFA")}; }
        }

        public static OtherByteString DataSetTrailingPadding
        {
            get { return new OtherByteString {Tag = new Tag("FFFCFFFC")}; }
        }
    }
}