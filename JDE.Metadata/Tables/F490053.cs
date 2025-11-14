using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F490053 - .
/// </summary>
public class F490053 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZGCARS.
        /// </summary>
        public const string ZGCARS = "ZGCARS";

        /// <summary>
        /// ZGMOT.
        /// </summary>
        public const string ZGMOT = "ZGMOT";

        /// <summary>
        /// ZGDCCD.
        /// </summary>
        public const string ZGDCCD = "ZGDCCD";

        /// <summary>
        /// ZGOSEQ.
        /// </summary>
        public const string ZGOSEQ = "ZGOSEQ";

        /// <summary>
        /// ZGSPTL.
        /// </summary>
        public const string ZGSPTL = "ZGSPTL";

        /// <summary>
        /// ZGSPTV.
        /// </summary>
        public const string ZGSPTV = "ZGSPTV";

        /// <summary>
        /// ZGURCD.
        /// </summary>
        public const string ZGURCD = "ZGURCD";

        /// <summary>
        /// ZGURDT.
        /// </summary>
        public const string ZGURDT = "ZGURDT";

        /// <summary>
        /// ZGURAT.
        /// </summary>
        public const string ZGURAT = "ZGURAT";

        /// <summary>
        /// ZGURAB.
        /// </summary>
        public const string ZGURAB = "ZGURAB";

        /// <summary>
        /// ZGURRF.
        /// </summary>
        public const string ZGURRF = "ZGURRF";

        /// <summary>
        /// ZGUSER.
        /// </summary>
        public const string ZGUSER = "ZGUSER";

        /// <summary>
        /// ZGPID.
        /// </summary>
        public const string ZGPID = "ZGPID";

        /// <summary>
        /// ZGJOBN.
        /// </summary>
        public const string ZGJOBN = "ZGJOBN";

        /// <summary>
        /// ZGUPMJ.
        /// </summary>
        public const string ZGUPMJ = "ZGUPMJ";

        /// <summary>
        /// ZGTDAY.
        /// </summary>
        public const string ZGTDAY = "ZGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F490053";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZGCARS", "ZGCARS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGMOT", "ZGMOT", JdeDataType.String, 6, true, true),
        new JdeField("ZGDCCD", "ZGDCCD", JdeDataType.String, 8, true, true),
        new JdeField("ZGOSEQ", "ZGOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGSPTL", "ZGSPTL", JdeDataType.Numeric),
        new JdeField("ZGSPTV", "ZGSPTV", JdeDataType.String, 2),
        new JdeField("ZGURCD", "ZGURCD", JdeDataType.String, 4),
        new JdeField("ZGURDT", "ZGURDT", JdeDataType.Numeric),
        new JdeField("ZGURAT", "ZGURAT", JdeDataType.Numeric),
        new JdeField("ZGURAB", "ZGURAB", JdeDataType.Numeric),
        new JdeField("ZGURRF", "ZGURRF", JdeDataType.String, 30),
        new JdeField("ZGUSER", "ZGUSER", JdeDataType.String, 20),
        new JdeField("ZGPID", "ZGPID", JdeDataType.String, 20),
        new JdeField("ZGJOBN", "ZGJOBN", JdeDataType.String, 20),
        new JdeField("ZGUPMJ", "ZGUPMJ", JdeDataType.Numeric),
        new JdeField("ZGTDAY", "ZGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F490053_0", "Primary Key on ZGCARS, ZGMOT, ZGDCCD, ZGOSEQ", new[] { "ZGCARS", "ZGMOT", "ZGDCCD", "ZGOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F490053_2", "Index on SYS_NC00017$, SYS_NC00018$, SYS_NC00019$, SYS_NC00020$", new[] { "SYS_NC00017$", "SYS_NC00018$", "SYS_NC00019$", "SYS_NC00020$" }),
        new JdeIndex("F490053_3", "Index on ZGCARS, ZGMOT, ZGDCCD", new[] { "ZGCARS", "ZGMOT", "ZGDCCD" }),
        new JdeIndex("F490053_4", "Index on ZGCARS, ZGMOT, ZGDCCD, ZGSPTL", new[] { "ZGCARS", "ZGMOT", "ZGDCCD", "ZGSPTL" })
    };
}
