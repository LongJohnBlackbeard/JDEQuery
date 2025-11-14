using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V101Z - .
/// </summary>
public class F76V101Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZWEDUS.
        /// </summary>
        public const string ZWEDUS = "ZWEDUS";

        /// <summary>
        /// ZWEDBT.
        /// </summary>
        public const string ZWEDBT = "ZWEDBT";

        /// <summary>
        /// ZWEDTN.
        /// </summary>
        public const string ZWEDTN = "ZWEDTN";

        /// <summary>
        /// ZWEDLN.
        /// </summary>
        public const string ZWEDLN = "ZWEDLN";

        /// <summary>
        /// ZWAN8.
        /// </summary>
        public const string ZWAN8 = "ZWAN8";

        /// <summary>
        /// ZWV76ISLR.
        /// </summary>
        public const string ZWV76ISLR = "ZWV76ISLR";

        /// <summary>
        /// ZWV76MUNW.
        /// </summary>
        public const string ZWV76MUNW = "ZWV76MUNW";

        /// <summary>
        /// ZWV76VATW.
        /// </summary>
        public const string ZWV76VATW = "ZWV76VATW";

        /// <summary>
        /// ZWV76ISFC.
        /// </summary>
        public const string ZWV76ISFC = "ZWV76ISFC";

        /// <summary>
        /// ZWURAT.
        /// </summary>
        public const string ZWURAT = "ZWURAT";

        /// <summary>
        /// ZWV76SUTY.
        /// </summary>
        public const string ZWV76SUTY = "ZWV76SUTY";

        /// <summary>
        /// ZWV76PETY.
        /// </summary>
        public const string ZWV76PETY = "ZWV76PETY";

        /// <summary>
        /// ZWURAB.
        /// </summary>
        public const string ZWURAB = "ZWURAB";

        /// <summary>
        /// ZWURCD.
        /// </summary>
        public const string ZWURCD = "ZWURCD";

        /// <summary>
        /// ZWURDT.
        /// </summary>
        public const string ZWURDT = "ZWURDT";

        /// <summary>
        /// ZWURRF.
        /// </summary>
        public const string ZWURRF = "ZWURRF";

        /// <summary>
        /// ZWUSER.
        /// </summary>
        public const string ZWUSER = "ZWUSER";

        /// <summary>
        /// ZWPID.
        /// </summary>
        public const string ZWPID = "ZWPID";

        /// <summary>
        /// ZWJOBN.
        /// </summary>
        public const string ZWJOBN = "ZWJOBN";

        /// <summary>
        /// ZWUPMJ.
        /// </summary>
        public const string ZWUPMJ = "ZWUPMJ";

        /// <summary>
        /// ZWUPMT.
        /// </summary>
        public const string ZWUPMT = "ZWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V101Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZWEDUS", "ZWEDUS", JdeDataType.String, 20, true, true),
        new JdeField("ZWEDBT", "ZWEDBT", JdeDataType.String, 30, true, true),
        new JdeField("ZWEDTN", "ZWEDTN", JdeDataType.String, 44, true, true),
        new JdeField("ZWEDLN", "ZWEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZWAN8", "ZWAN8", JdeDataType.Numeric),
        new JdeField("ZWV76ISLR", "ZWV76ISLR", JdeDataType.String, 6),
        new JdeField("ZWV76MUNW", "ZWV76MUNW", JdeDataType.String, 2),
        new JdeField("ZWV76VATW", "ZWV76VATW", JdeDataType.String, 6),
        new JdeField("ZWV76ISFC", "ZWV76ISFC", JdeDataType.String, 2),
        new JdeField("ZWURAT", "ZWURAT", JdeDataType.Numeric),
        new JdeField("ZWV76SUTY", "ZWV76SUTY", JdeDataType.String, 6),
        new JdeField("ZWV76PETY", "ZWV76PETY", JdeDataType.String, 6),
        new JdeField("ZWURAB", "ZWURAB", JdeDataType.Numeric),
        new JdeField("ZWURCD", "ZWURCD", JdeDataType.String, 4),
        new JdeField("ZWURDT", "ZWURDT", JdeDataType.Numeric),
        new JdeField("ZWURRF", "ZWURRF", JdeDataType.String, 30),
        new JdeField("ZWUSER", "ZWUSER", JdeDataType.String, 20),
        new JdeField("ZWPID", "ZWPID", JdeDataType.String, 20),
        new JdeField("ZWJOBN", "ZWJOBN", JdeDataType.String, 20),
        new JdeField("ZWUPMJ", "ZWUPMJ", JdeDataType.Numeric),
        new JdeField("ZWUPMT", "ZWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V101Z_0", "Primary Key on ZWEDUS, ZWEDBT, ZWEDTN, ZWEDLN", new[] { "ZWEDUS", "ZWEDBT", "ZWEDTN", "ZWEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
