using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06013 - .
/// </summary>
public class F06013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YEAN8.
        /// </summary>
        public const string YEAN8 = "YEAN8";

        /// <summary>
        /// YETYPP.
        /// </summary>
        public const string YETYPP = "YETYPP";

        /// <summary>
        /// YEDTFR.
        /// </summary>
        public const string YEDTFR = "YEDTFR";

        /// <summary>
        /// YEDTTO.
        /// </summary>
        public const string YEDTTO = "YEDTTO";

        /// <summary>
        /// YEEXPL.
        /// </summary>
        public const string YEEXPL = "YEEXPL";

        /// <summary>
        /// YEUSER.
        /// </summary>
        public const string YEUSER = "YEUSER";

        /// <summary>
        /// YEPID.
        /// </summary>
        public const string YEPID = "YEPID";

        /// <summary>
        /// YEUPMJ.
        /// </summary>
        public const string YEUPMJ = "YEUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YEAN8", "YEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YETYPP", "YETYPP", JdeDataType.String, 10, true, true),
        new JdeField("YEDTFR", "YEDTFR", JdeDataType.Numeric, null, true, true),
        new JdeField("YEDTTO", "YEDTTO", JdeDataType.Numeric),
        new JdeField("YEEXPL", "YEEXPL", JdeDataType.String, 2400),
        new JdeField("YEUSER", "YEUSER", JdeDataType.String, 20),
        new JdeField("YEPID", "YEPID", JdeDataType.String, 20),
        new JdeField("YEUPMJ", "YEUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06013_0", "Primary Key on YEAN8, YETYPP, YEDTFR", new[] { "YEAN8", "YETYPP", "YEDTFR" }, isUnique: true, isPrimaryKey: true)
    };
}
