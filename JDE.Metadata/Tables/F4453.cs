using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4453 - .
/// </summary>
public class F4453 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JBMCUS.
        /// </summary>
        public const string JBMCUS = "JBMCUS";

        /// <summary>
        /// JBMCU.
        /// </summary>
        public const string JBMCU = "JBMCU";

        /// <summary>
        /// JBELEV.
        /// </summary>
        public const string JBELEV = "JBELEV";

        /// <summary>
        /// JBPL.
        /// </summary>
        public const string JBPL = "JBPL";

        /// <summary>
        /// JBTRCN.
        /// </summary>
        public const string JBTRCN = "JBTRCN";

        /// <summary>
        /// JBALOT.
        /// </summary>
        public const string JBALOT = "JBALOT";

        /// <summary>
        /// JBSEQ2.
        /// </summary>
        public const string JBSEQ2 = "JBSEQ2";

        /// <summary>
        /// JBADD1.
        /// </summary>
        public const string JBADD1 = "JBADD1";

        /// <summary>
        /// JBDL01.
        /// </summary>
        public const string JBDL01 = "JBDL01";

        /// <summary>
        /// JBUSD1.
        /// </summary>
        public const string JBUSD1 = "JBUSD1";

        /// <summary>
        /// JBUSD2.
        /// </summary>
        public const string JBUSD2 = "JBUSD2";

        /// <summary>
        /// JBSWG.
        /// </summary>
        public const string JBSWG = "JBSWG";

        /// <summary>
        /// JBDL02.
        /// </summary>
        public const string JBDL02 = "JBDL02";

        /// <summary>
        /// JBCO.
        /// </summary>
        public const string JBCO = "JBCO";

        /// <summary>
        /// JBPRJN.
        /// </summary>
        public const string JBPRJN = "JBPRJN";

        /// <summary>
        /// JBRLSN.
        /// </summary>
        public const string JBRLSN = "JBRLSN";

        /// <summary>
        /// JBDPTN.
        /// </summary>
        public const string JBDPTN = "JBDPTN";

        /// <summary>
        /// JBSBL.
        /// </summary>
        public const string JBSBL = "JBSBL";

        /// <summary>
        /// JBSBLT.
        /// </summary>
        public const string JBSBLT = "JBSBLT";

        /// <summary>
        /// JBLOTS.
        /// </summary>
        public const string JBLOTS = "JBLOTS";

        /// <summary>
        /// JBLTP.
        /// </summary>
        public const string JBLTP = "JBLTP";

        /// <summary>
        /// JBLPP.
        /// </summary>
        public const string JBLPP = "JBLPP";

        /// <summary>
        /// JBUSD5.
        /// </summary>
        public const string JBUSD5 = "JBUSD5";

        /// <summary>
        /// JBUSD6.
        /// </summary>
        public const string JBUSD6 = "JBUSD6";

        /// <summary>
        /// JBFD01.
        /// </summary>
        public const string JBFD01 = "JBFD01";

        /// <summary>
        /// JBRDJ.
        /// </summary>
        public const string JBRDJ = "JBRDJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4453";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JBMCUS", "JBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JBMCU", "JBMCU", JdeDataType.String, 24, true, true),
        new JdeField("JBELEV", "JBELEV", JdeDataType.String, 6),
        new JdeField("JBPL", "JBPL", JdeDataType.String, 8),
        new JdeField("JBTRCN", "JBTRCN", JdeDataType.String, 4, true, true),
        new JdeField("JBALOT", "JBALOT", JdeDataType.String, 8, true, true),
        new JdeField("JBSEQ2", "JBSEQ2", JdeDataType.Numeric),
        new JdeField("JBADD1", "JBADD1", JdeDataType.String, 80),
        new JdeField("JBDL01", "JBDL01", JdeDataType.String, 60),
        new JdeField("JBUSD1", "JBUSD1", JdeDataType.Numeric),
        new JdeField("JBUSD2", "JBUSD2", JdeDataType.Numeric),
        new JdeField("JBSWG", "JBSWG", JdeDataType.String, 2),
        new JdeField("JBDL02", "JBDL02", JdeDataType.String, 60),
        new JdeField("JBCO", "JBCO", JdeDataType.String, 10),
        new JdeField("JBPRJN", "JBPRJN", JdeDataType.String, 6),
        new JdeField("JBRLSN", "JBRLSN", JdeDataType.String, 6),
        new JdeField("JBDPTN", "JBDPTN", JdeDataType.String, 6),
        new JdeField("JBSBL", "JBSBL", JdeDataType.String, 16),
        new JdeField("JBSBLT", "JBSBLT", JdeDataType.String, 2),
        new JdeField("JBLOTS", "JBLOTS", JdeDataType.String, 2),
        new JdeField("JBLTP", "JBLTP", JdeDataType.Numeric),
        new JdeField("JBLPP", "JBLPP", JdeDataType.Numeric),
        new JdeField("JBUSD5", "JBUSD5", JdeDataType.Numeric),
        new JdeField("JBUSD6", "JBUSD6", JdeDataType.Numeric),
        new JdeField("JBFD01", "JBFD01", JdeDataType.String, 6),
        new JdeField("JBRDJ", "JBRDJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4453_0", "Primary Key on JBMCUS, JBMCU, JBTRCN, JBALOT", new[] { "JBMCUS", "JBMCU", "JBTRCN", "JBALOT" }, isUnique: true, isPrimaryKey: true)
    };
}
