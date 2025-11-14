using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI91 - .
/// </summary>
public class F74UI91 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADJOBS.
        /// </summary>
        public const string ADJOBS = "ADJOBS";

        /// <summary>
        /// ADE74RENA.
        /// </summary>
        public const string ADE74RENA = "ADE74RENA";

        /// <summary>
        /// ADE74RSN.
        /// </summary>
        public const string ADE74RSN = "ADE74RSN";

        /// <summary>
        /// ADE74RRN.
        /// </summary>
        public const string ADE74RRN = "ADE74RRN";

        /// <summary>
        /// ADE74ASEQ.
        /// </summary>
        public const string ADE74ASEQ = "ADE74ASEQ";

        /// <summary>
        /// ADE74LASQ.
        /// </summary>
        public const string ADE74LASQ = "ADE74LASQ";

        /// <summary>
        /// ADAID.
        /// </summary>
        public const string ADAID = "ADAID";

        /// <summary>
        /// ADCO.
        /// </summary>
        public const string ADCO = "ADCO";

        /// <summary>
        /// ADANI.
        /// </summary>
        public const string ADANI = "ADANI";

        /// <summary>
        /// ADDL01.
        /// </summary>
        public const string ADDL01 = "ADDL01";

        /// <summary>
        /// ADMCU.
        /// </summary>
        public const string ADMCU = "ADMCU";

        /// <summary>
        /// ADOBJ.
        /// </summary>
        public const string ADOBJ = "ADOBJ";

        /// <summary>
        /// ADSUB.
        /// </summary>
        public const string ADSUB = "ADSUB";

        /// <summary>
        /// ADLDA.
        /// </summary>
        public const string ADLDA = "ADLDA";

        /// <summary>
        /// ADPEC.
        /// </summary>
        public const string ADPEC = "ADPEC";

        /// <summary>
        /// ADR021.
        /// </summary>
        public const string ADR021 = "ADR021";

        /// <summary>
        /// ADR022.
        /// </summary>
        public const string ADR022 = "ADR022";

        /// <summary>
        /// ADR023.
        /// </summary>
        public const string ADR023 = "ADR023";

        /// <summary>
        /// ADE74FUNC.
        /// </summary>
        public const string ADE74FUNC = "ADE74FUNC";

        /// <summary>
        /// ADE74ACT.
        /// </summary>
        public const string ADE74ACT = "ADE74ACT";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI91";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADJOBS", "ADJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ADE74RENA", "ADE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("ADE74RSN", "ADE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADE74RRN", "ADE74RRN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADE74ASEQ", "ADE74ASEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ADE74LASQ", "ADE74LASQ", JdeDataType.Numeric),
        new JdeField("ADAID", "ADAID", JdeDataType.String, 16),
        new JdeField("ADCO", "ADCO", JdeDataType.String, 10),
        new JdeField("ADANI", "ADANI", JdeDataType.String, 58),
        new JdeField("ADDL01", "ADDL01", JdeDataType.String, 60),
        new JdeField("ADMCU", "ADMCU", JdeDataType.String, 24),
        new JdeField("ADOBJ", "ADOBJ", JdeDataType.String, 12),
        new JdeField("ADSUB", "ADSUB", JdeDataType.String, 16),
        new JdeField("ADLDA", "ADLDA", JdeDataType.String, 2),
        new JdeField("ADPEC", "ADPEC", JdeDataType.String, 2),
        new JdeField("ADR021", "ADR021", JdeDataType.String, 20),
        new JdeField("ADR022", "ADR022", JdeDataType.String, 20),
        new JdeField("ADR023", "ADR023", JdeDataType.String, 20),
        new JdeField("ADE74FUNC", "ADE74FUNC", JdeDataType.String, 20),
        new JdeField("ADE74ACT", "ADE74ACT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI91_0", "Primary Key on ADJOBS, ADE74RENA, ADE74RSN, ADE74RRN, ADE74ASEQ", new[] { "ADJOBS", "ADE74RENA", "ADE74RSN", "ADE74RRN", "ADE74ASEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
