using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49040 - .
/// </summary>
public class F49040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VSVEHI.
        /// </summary>
        public const string VSVEHI = "VSVEHI";

        /// <summary>
        /// VSSTFN.
        /// </summary>
        public const string VSSTFN = "VSSTFN";

        /// <summary>
        /// VSJBCD.
        /// </summary>
        public const string VSJBCD = "VSJBCD";

        /// <summary>
        /// VSEFTJ.
        /// </summary>
        public const string VSEFTJ = "VSEFTJ";

        /// <summary>
        /// VSEXDJ.
        /// </summary>
        public const string VSEXDJ = "VSEXDJ";

        /// <summary>
        /// VSSHFT.
        /// </summary>
        public const string VSSHFT = "VSSHFT";

        /// <summary>
        /// VSMCU.
        /// </summary>
        public const string VSMCU = "VSMCU";

        /// <summary>
        /// VSUSER.
        /// </summary>
        public const string VSUSER = "VSUSER";

        /// <summary>
        /// VSPID.
        /// </summary>
        public const string VSPID = "VSPID";

        /// <summary>
        /// VSJOBN.
        /// </summary>
        public const string VSJOBN = "VSJOBN";

        /// <summary>
        /// VSUPMJ.
        /// </summary>
        public const string VSUPMJ = "VSUPMJ";

        /// <summary>
        /// VSTDAY.
        /// </summary>
        public const string VSTDAY = "VSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VSVEHI", "VSVEHI", JdeDataType.String, 24, true, true),
        new JdeField("VSSTFN", "VSSTFN", JdeDataType.Numeric, null, true, true),
        new JdeField("VSJBCD", "VSJBCD", JdeDataType.String, 12, true, true),
        new JdeField("VSEFTJ", "VSEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VSEXDJ", "VSEXDJ", JdeDataType.Numeric),
        new JdeField("VSSHFT", "VSSHFT", JdeDataType.String, 2, true, true),
        new JdeField("VSMCU", "VSMCU", JdeDataType.String, 24),
        new JdeField("VSUSER", "VSUSER", JdeDataType.String, 20),
        new JdeField("VSPID", "VSPID", JdeDataType.String, 20),
        new JdeField("VSJOBN", "VSJOBN", JdeDataType.String, 20),
        new JdeField("VSUPMJ", "VSUPMJ", JdeDataType.Numeric),
        new JdeField("VSTDAY", "VSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49040_0", "Primary Key on VSVEHI, VSEFTJ, VSSTFN, VSJBCD, VSSHFT", new[] { "VSVEHI", "VSEFTJ", "VSSTFN", "VSJBCD", "VSSHFT" }, isUnique: true, isPrimaryKey: true)
    };
}
