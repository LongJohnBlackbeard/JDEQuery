using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98TC01 - .
/// </summary>
public class F98TC01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCMCU.
        /// </summary>
        public const string TCMCU = "TCMCU";

        /// <summary>
        /// TCITM.
        /// </summary>
        public const string TCITM = "TCITM";

        /// <summary>
        /// TCLOCN.
        /// </summary>
        public const string TCLOCN = "TCLOCN";

        /// <summary>
        /// TCLOTN.
        /// </summary>
        public const string TCLOTN = "TCLOTN";

        /// <summary>
        /// TCTX.
        /// </summary>
        public const string TCTX = "TCTX";

        /// <summary>
        /// TCSRCE.
        /// </summary>
        public const string TCSRCE = "TCSRCE";

        /// <summary>
        /// TCANBY.
        /// </summary>
        public const string TCANBY = "TCANBY";

        /// <summary>
        /// TCCSDJ.
        /// </summary>
        public const string TCCSDJ = "TCCSDJ";

        /// <summary>
        /// TCDLR.
        /// </summary>
        public const string TCDLR = "TCDLR";

        /// <summary>
        /// TCSTKT.
        /// </summary>
        public const string TCSTKT = "TCSTKT";

        /// <summary>
        /// TCCMGL.
        /// </summary>
        public const string TCCMGL = "TCCMGL";
    }

    /// <inheritdoc />
    public override string TableName => "F98TC01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCMCU", "TCMCU", JdeDataType.String, 24, true, true),
        new JdeField("TCITM", "TCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TCLOCN", "TCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("TCLOTN", "TCLOTN", JdeDataType.String, 60, true, true),
        new JdeField("TCTX", "TCTX", JdeDataType.String, 2),
        new JdeField("TCSRCE", "TCSRCE", JdeDataType.String, 2),
        new JdeField("TCANBY", "TCANBY", JdeDataType.Numeric),
        new JdeField("TCCSDJ", "TCCSDJ", JdeDataType.Numeric),
        new JdeField("TCDLR", "TCDLR", JdeDataType.Numeric),
        new JdeField("TCSTKT", "TCSTKT", JdeDataType.String, 2),
        new JdeField("TCCMGL", "TCCMGL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98TC01_0", "Primary Key on TCMCU, TCITM, TCLOCN, TCLOTN", new[] { "TCMCU", "TCITM", "TCLOCN", "TCLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
