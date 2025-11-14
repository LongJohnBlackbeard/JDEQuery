using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA142 - .
/// </summary>
public class F90CA142 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TYTERRID.
        /// </summary>
        public const string TYTERRID = "TYTERRID";

        /// <summary>
        /// TYBLGID.
        /// </summary>
        public const string TYBLGID = "TYBLGID";

        /// <summary>
        /// TYCFGSID.
        /// </summary>
        public const string TYCFGSID = "TYCFGSID";

        /// <summary>
        /// TYDESC.
        /// </summary>
        public const string TYDESC = "TYDESC";

        /// <summary>
        /// TYACTIND.
        /// </summary>
        public const string TYACTIND = "TYACTIND";

        /// <summary>
        /// TYUDTTM.
        /// </summary>
        public const string TYUDTTM = "TYUDTTM";

        /// <summary>
        /// TYUSER.
        /// </summary>
        public const string TYUSER = "TYUSER";

        /// <summary>
        /// TYENTDBY.
        /// </summary>
        public const string TYENTDBY = "TYENTDBY";

        /// <summary>
        /// TYEDATE.
        /// </summary>
        public const string TYEDATE = "TYEDATE";

        /// <summary>
        /// TYSTSUDT.
        /// </summary>
        public const string TYSTSUDT = "TYSTSUDT";

        /// <summary>
        /// TYPID.
        /// </summary>
        public const string TYPID = "TYPID";

        /// <summary>
        /// TYVID.
        /// </summary>
        public const string TYVID = "TYVID";

        /// <summary>
        /// TYMKEY.
        /// </summary>
        public const string TYMKEY = "TYMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA142";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TYTERRID", "TYTERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TYBLGID", "TYBLGID", JdeDataType.Numeric),
        new JdeField("TYCFGSID", "TYCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("TYDESC", "TYDESC", JdeDataType.String, 60),
        new JdeField("TYACTIND", "TYACTIND", JdeDataType.String, 2),
        new JdeField("TYUDTTM", "TYUDTTM", JdeDataType.Date),
        new JdeField("TYUSER", "TYUSER", JdeDataType.String, 20),
        new JdeField("TYENTDBY", "TYENTDBY", JdeDataType.Numeric),
        new JdeField("TYEDATE", "TYEDATE", JdeDataType.Date),
        new JdeField("TYSTSUDT", "TYSTSUDT", JdeDataType.Date),
        new JdeField("TYPID", "TYPID", JdeDataType.String, 20),
        new JdeField("TYVID", "TYVID", JdeDataType.String, 20),
        new JdeField("TYMKEY", "TYMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA142_0", "Primary Key on TYCFGSID, TYTERRID", new[] { "TYCFGSID", "TYTERRID" }, isUnique: true, isPrimaryKey: true)
    };
}
