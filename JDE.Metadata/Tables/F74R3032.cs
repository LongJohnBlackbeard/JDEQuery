using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3032 - .
/// </summary>
public class F74R3032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HFKCO.
        /// </summary>
        public const string HFKCO = "HFKCO";

        /// <summary>
        /// HFDCT.
        /// </summary>
        public const string HFDCT = "HFDCT";

        /// <summary>
        /// HFDOC.
        /// </summary>
        public const string HFDOC = "HFDOC";

        /// <summary>
        /// HFR74GOS.
        /// </summary>
        public const string HFR74GOS = "HFR74GOS";

        /// <summary>
        /// HFR74ACC.
        /// </summary>
        public const string HFR74ACC = "HFR74ACC";

        /// <summary>
        /// HFR74CN.
        /// </summary>
        public const string HFR74CN = "HFR74CN";

        /// <summary>
        /// HFUSER.
        /// </summary>
        public const string HFUSER = "HFUSER";

        /// <summary>
        /// HFPID.
        /// </summary>
        public const string HFPID = "HFPID";

        /// <summary>
        /// HFJOBN.
        /// </summary>
        public const string HFJOBN = "HFJOBN";

        /// <summary>
        /// HFUPMT.
        /// </summary>
        public const string HFUPMT = "HFUPMT";

        /// <summary>
        /// HFUPMJ.
        /// </summary>
        public const string HFUPMJ = "HFUPMJ";

        /// <summary>
        /// HFURCD.
        /// </summary>
        public const string HFURCD = "HFURCD";

        /// <summary>
        /// HFURDT.
        /// </summary>
        public const string HFURDT = "HFURDT";

        /// <summary>
        /// HFURAT.
        /// </summary>
        public const string HFURAT = "HFURAT";

        /// <summary>
        /// HFURAB.
        /// </summary>
        public const string HFURAB = "HFURAB";

        /// <summary>
        /// HFURRF.
        /// </summary>
        public const string HFURRF = "HFURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HFKCO", "HFKCO", JdeDataType.String, 10, true, true),
        new JdeField("HFDCT", "HFDCT", JdeDataType.String, 4, true, true),
        new JdeField("HFDOC", "HFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("HFR74GOS", "HFR74GOS", JdeDataType.String, 2),
        new JdeField("HFR74ACC", "HFR74ACC", JdeDataType.String, 20),
        new JdeField("HFR74CN", "HFR74CN", JdeDataType.String, 200),
        new JdeField("HFUSER", "HFUSER", JdeDataType.String, 20),
        new JdeField("HFPID", "HFPID", JdeDataType.String, 20),
        new JdeField("HFJOBN", "HFJOBN", JdeDataType.String, 20),
        new JdeField("HFUPMT", "HFUPMT", JdeDataType.Numeric),
        new JdeField("HFUPMJ", "HFUPMJ", JdeDataType.Numeric),
        new JdeField("HFURCD", "HFURCD", JdeDataType.String, 4),
        new JdeField("HFURDT", "HFURDT", JdeDataType.Numeric),
        new JdeField("HFURAT", "HFURAT", JdeDataType.Numeric),
        new JdeField("HFURAB", "HFURAB", JdeDataType.Numeric),
        new JdeField("HFURRF", "HFURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3032_0", "Primary Key on HFKCO, HFDCT, HFDOC", new[] { "HFKCO", "HFDCT", "HFDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
