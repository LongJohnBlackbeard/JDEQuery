using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76BUI80 - .
/// </summary>
public class F76BUI80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRB76ATCT.
        /// </summary>
        public const string CRB76ATCT = "CRB76ATCT";

        /// <summary>
        /// CRB76BLCK.
        /// </summary>
        public const string CRB76BLCK = "CRB76BLCK";

        /// <summary>
        /// CRB76RECD.
        /// </summary>
        public const string CRB76RECD = "CRB76RECD";

        /// <summary>
        /// CRB76FPTY.
        /// </summary>
        public const string CRB76FPTY = "CRB76FPTY";

        /// <summary>
        /// CRB76CIR.
        /// </summary>
        public const string CRB76CIR = "CRB76CIR";

        /// <summary>
        /// CRB76COR.
        /// </summary>
        public const string CRB76COR = "CRB76COR";

        /// <summary>
        /// CRB76CAR.
        /// </summary>
        public const string CRB76CAR = "CRB76CAR";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76BUI80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRB76ATCT", "CRB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("CRB76BLCK", "CRB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("CRB76RECD", "CRB76RECD", JdeDataType.String, 8, true, true),
        new JdeField("CRB76FPTY", "CRB76FPTY", JdeDataType.String, 2, true, true),
        new JdeField("CRB76CIR", "CRB76CIR", JdeDataType.String, 4),
        new JdeField("CRB76COR", "CRB76COR", JdeDataType.String, 4),
        new JdeField("CRB76CAR", "CRB76CAR", JdeDataType.String, 4),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76BUI80_0", "Primary Key on CRB76ATCT, CRB76BLCK, CRB76RECD, CRB76FPTY", new[] { "CRB76ATCT", "CRB76BLCK", "CRB76RECD", "CRB76FPTY" }, isUnique: true, isPrimaryKey: true)
    };
}
