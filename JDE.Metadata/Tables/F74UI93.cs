using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UI93 - .
/// </summary>
public class F74UI93 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDJOBS.
        /// </summary>
        public const string CDJOBS = "CDJOBS";

        /// <summary>
        /// CDE74RENA.
        /// </summary>
        public const string CDE74RENA = "CDE74RENA";

        /// <summary>
        /// CDE74RSN.
        /// </summary>
        public const string CDE74RSN = "CDE74RSN";

        /// <summary>
        /// CDE74RRN.
        /// </summary>
        public const string CDE74RRN = "CDE74RRN";

        /// <summary>
        /// CDE74CSEQ.
        /// </summary>
        public const string CDE74CSEQ = "CDE74CSEQ";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDCO.
        /// </summary>
        public const string CDCO = "CDCO";
    }

    /// <inheritdoc />
    public override string TableName => "F74UI93";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDJOBS", "CDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CDE74RENA", "CDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("CDE74RSN", "CDE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDE74RRN", "CDE74RRN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDE74CSEQ", "CDE74CSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24),
        new JdeField("CDCO", "CDCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UI93_0", "Primary Key on CDJOBS, CDE74RENA, CDE74RSN, CDE74RRN, CDE74CSEQ", new[] { "CDJOBS", "CDE74RENA", "CDE74RSN", "CDE74RRN", "CDE74CSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74UI93_2", "Index on CDJOBS, CDE74RENA, CDE74RSN, CDE74RRN, SYS_NC00008$", new[] { "CDJOBS", "CDE74RENA", "CDE74RSN", "CDE74RRN", "SYS_NC00008$" })
    };
}
