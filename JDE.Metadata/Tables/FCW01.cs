using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW01 - .
/// </summary>
public class FCW01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STC9STRC.
        /// </summary>
        public const string STC9STRC = "STC9STRC";

        /// <summary>
        /// STC9LVNO.
        /// </summary>
        public const string STC9LVNO = "STC9LVNO";

        /// <summary>
        /// STC9LVTC.
        /// </summary>
        public const string STC9LVTC = "STC9LVTC";

        /// <summary>
        /// STC9SEPA.
        /// </summary>
        public const string STC9SEPA = "STC9SEPA";

        /// <summary>
        /// STC9SECD.
        /// </summary>
        public const string STC9SECD = "STC9SECD";

        /// <summary>
        /// STC9SQNO.
        /// </summary>
        public const string STC9SQNO = "STC9SQNO";

        /// <summary>
        /// STC9STKT.
        /// </summary>
        public const string STC9STKT = "STC9STKT";

        /// <summary>
        /// STC9MXLN.
        /// </summary>
        public const string STC9MXLN = "STC9MXLN";
    }

    /// <inheritdoc />
    public override string TableName => "FCW01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STC9STRC", "STC9STRC", JdeDataType.String, 6, true, true),
        new JdeField("STC9LVNO", "STC9LVNO", JdeDataType.Numeric, null, true, true),
        new JdeField("STC9LVTC", "STC9LVTC", JdeDataType.String, 6),
        new JdeField("STC9SEPA", "STC9SEPA", JdeDataType.String, 2),
        new JdeField("STC9SECD", "STC9SECD", JdeDataType.String, 2),
        new JdeField("STC9SQNO", "STC9SQNO", JdeDataType.Numeric),
        new JdeField("STC9STKT", "STC9STKT", JdeDataType.String, 2),
        new JdeField("STC9MXLN", "STC9MXLN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW01_0", "Primary Key on STC9STRC, STC9LVNO", new[] { "STC9STRC", "STC9LVNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW01_2", "Index on STC9STRC, SYS_NC00009$", new[] { "STC9STRC", "SYS_NC00009$" }),
        new JdeIndex("FCW01_3", "Index on STC9STRC, STC9LVTC", new[] { "STC9STRC", "STC9LVTC" })
    };
}
