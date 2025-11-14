using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B130 - .
/// </summary>
public class F31B130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMWVID.
        /// </summary>
        public const string CMWVID = "CMWVID";

        /// <summary>
        /// CMCONNM.
        /// </summary>
        public const string CMCONNM = "CMCONNM";

        /// <summary>
        /// CMCONDESC.
        /// </summary>
        public const string CMCONDESC = "CMCONDESC";

        /// <summary>
        /// CMCONTYP.
        /// </summary>
        public const string CMCONTYP = "CMCONTYP";

        /// <summary>
        /// CMCONCAP.
        /// </summary>
        public const string CMCONCAP = "CMCONCAP";

        /// <summary>
        /// CMCONCPUOM.
        /// </summary>
        public const string CMCONCPUOM = "CMCONCPUOM";

        /// <summary>
        /// CMWCRTR.
        /// </summary>
        public const string CMWCRTR = "CMWCRTR";

        /// <summary>
        /// CMCONCAT1.
        /// </summary>
        public const string CMCONCAT1 = "CMCONCAT1";

        /// <summary>
        /// CMCONCAT2.
        /// </summary>
        public const string CMCONCAT2 = "CMCONCAT2";

        /// <summary>
        /// CMCONCAT3.
        /// </summary>
        public const string CMCONCAT3 = "CMCONCAT3";

        /// <summary>
        /// CMCONCAT4.
        /// </summary>
        public const string CMCONCAT4 = "CMCONCAT4";

        /// <summary>
        /// CMCONCAT5.
        /// </summary>
        public const string CMCONCAT5 = "CMCONCAT5";

        /// <summary>
        /// CMWCD.
        /// </summary>
        public const string CMWCD = "CMWCD";

        /// <summary>
        /// CMWMDT.
        /// </summary>
        public const string CMWMDT = "CMWMDT";

        /// <summary>
        /// CMWAB.
        /// </summary>
        public const string CMWAB = "CMWAB";

        /// <summary>
        /// CMWNUM.
        /// </summary>
        public const string CMWNUM = "CMWNUM";

        /// <summary>
        /// CMWRF.
        /// </summary>
        public const string CMWRF = "CMWRF";

        /// <summary>
        /// CMURAT.
        /// </summary>
        public const string CMURAT = "CMURAT";

        /// <summary>
        /// CMURCD.
        /// </summary>
        public const string CMURCD = "CMURCD";

        /// <summary>
        /// CMURDT.
        /// </summary>
        public const string CMURDT = "CMURDT";

        /// <summary>
        /// CMURAB.
        /// </summary>
        public const string CMURAB = "CMURAB";

        /// <summary>
        /// CMURRF.
        /// </summary>
        public const string CMURRF = "CMURRF";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMTDAY.
        /// </summary>
        public const string CMTDAY = "CMTDAY";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMWVID", "CMWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCONNM", "CMCONNM", JdeDataType.String, 30),
        new JdeField("CMCONDESC", "CMCONDESC", JdeDataType.String, 80),
        new JdeField("CMCONTYP", "CMCONTYP", JdeDataType.String, 8),
        new JdeField("CMCONCAP", "CMCONCAP", JdeDataType.Numeric),
        new JdeField("CMCONCPUOM", "CMCONCPUOM", JdeDataType.String, 4),
        new JdeField("CMWCRTR", "CMWCRTR", JdeDataType.Numeric),
        new JdeField("CMCONCAT1", "CMCONCAT1", JdeDataType.String, 20),
        new JdeField("CMCONCAT2", "CMCONCAT2", JdeDataType.String, 20),
        new JdeField("CMCONCAT3", "CMCONCAT3", JdeDataType.String, 20),
        new JdeField("CMCONCAT4", "CMCONCAT4", JdeDataType.String, 40),
        new JdeField("CMCONCAT5", "CMCONCAT5", JdeDataType.String, 20),
        new JdeField("CMWCD", "CMWCD", JdeDataType.String, 6),
        new JdeField("CMWMDT", "CMWMDT", JdeDataType.Numeric),
        new JdeField("CMWAB", "CMWAB", JdeDataType.Numeric),
        new JdeField("CMWNUM", "CMWNUM", JdeDataType.Numeric),
        new JdeField("CMWRF", "CMWRF", JdeDataType.String, 60),
        new JdeField("CMURAT", "CMURAT", JdeDataType.Numeric),
        new JdeField("CMURCD", "CMURCD", JdeDataType.String, 4),
        new JdeField("CMURDT", "CMURDT", JdeDataType.Numeric),
        new JdeField("CMURAB", "CMURAB", JdeDataType.Numeric),
        new JdeField("CMURRF", "CMURRF", JdeDataType.String, 30),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMTDAY", "CMTDAY", JdeDataType.Numeric),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B130_0", "Primary Key on CMWVID", new[] { "CMWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B130_2", "Index on CMCONNM", new[] { "CMCONNM" }),
        new JdeIndex("F31B130_3", "Index on CMCONTYP", new[] { "CMCONTYP" })
    };
}
