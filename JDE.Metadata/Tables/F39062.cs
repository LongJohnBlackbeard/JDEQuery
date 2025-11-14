using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39062 - .
/// </summary>
public class F39062 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STCRCD.
        /// </summary>
        public const string STCRCD = "STCRCD";

        /// <summary>
        /// STSVVM.
        /// </summary>
        public const string STSVVM = "STSVVM";

        /// <summary>
        /// STSVYR.
        /// </summary>
        public const string STSVYR = "STSVYR";

        /// <summary>
        /// STPNC.
        /// </summary>
        public const string STPNC = "STPNC";

        /// <summary>
        /// STITPL.
        /// </summary>
        public const string STITPL = "STITPL";

        /// <summary>
        /// STITM.
        /// </summary>
        public const string STITM = "STITM";

        /// <summary>
        /// STCO.
        /// </summary>
        public const string STCO = "STCO";

        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STRCPD.
        /// </summary>
        public const string STRCPD = "STRCPD";

        /// <summary>
        /// STUKID.
        /// </summary>
        public const string STUKID = "STUKID";

        /// <summary>
        /// STLDEP.
        /// </summary>
        public const string STLDEP = "STLDEP";

        /// <summary>
        /// STUOM.
        /// </summary>
        public const string STUOM = "STUOM";

        /// <summary>
        /// STORQY.
        /// </summary>
        public const string STORQY = "STORQY";

        /// <summary>
        /// STAMC3.
        /// </summary>
        public const string STAMC3 = "STAMC3";

        /// <summary>
        /// STCRQT.
        /// </summary>
        public const string STCRQT = "STCRQT";

        /// <summary>
        /// STCRAM.
        /// </summary>
        public const string STCRAM = "STCRAM";

        /// <summary>
        /// STALQT.
        /// </summary>
        public const string STALQT = "STALQT";

        /// <summary>
        /// STALAM.
        /// </summary>
        public const string STALAM = "STALAM";

        /// <summary>
        /// STALDA.
        /// </summary>
        public const string STALDA = "STALDA";

        /// <summary>
        /// STPSFL.
        /// </summary>
        public const string STPSFL = "STPSFL";

        /// <summary>
        /// STCRR.
        /// </summary>
        public const string STCRR = "STCRR";

        /// <summary>
        /// STSVQT.
        /// </summary>
        public const string STSVQT = "STSVQT";

        /// <summary>
        /// STSVUM.
        /// </summary>
        public const string STSVUM = "STSVUM";

        /// <summary>
        /// STSVDT.
        /// </summary>
        public const string STSVDT = "STSVDT";

        /// <summary>
        /// STSVFU.
        /// </summary>
        public const string STSVFU = "STSVFU";

        /// <summary>
        /// STSVF1.
        /// </summary>
        public const string STSVF1 = "STSVF1";

        /// <summary>
        /// STSVF2.
        /// </summary>
        public const string STSVF2 = "STSVF2";

        /// <summary>
        /// STSVF3.
        /// </summary>
        public const string STSVF3 = "STSVF3";

        /// <summary>
        /// STSVF4.
        /// </summary>
        public const string STSVF4 = "STSVF4";

        /// <summary>
        /// STSVF5.
        /// </summary>
        public const string STSVF5 = "STSVF5";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STTDAY.
        /// </summary>
        public const string STTDAY = "STTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F39062";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STCRCD", "STCRCD", JdeDataType.String, 6, true, true),
        new JdeField("STSVVM", "STSVVM", JdeDataType.String, 4, true, true),
        new JdeField("STSVYR", "STSVYR", JdeDataType.Numeric, null, true, true),
        new JdeField("STPNC", "STPNC", JdeDataType.Numeric, null, true, true),
        new JdeField("STITPL", "STITPL", JdeDataType.String, 20, true, true),
        new JdeField("STITM", "STITM", JdeDataType.Numeric, null, true, true),
        new JdeField("STCO", "STCO", JdeDataType.String, 10, true, true),
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24, true, true),
        new JdeField("STRCPD", "STRCPD", JdeDataType.Numeric, null, true, true),
        new JdeField("STUKID", "STUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("STLDEP", "STLDEP", JdeDataType.String, 2),
        new JdeField("STUOM", "STUOM", JdeDataType.String, 4),
        new JdeField("STORQY", "STORQY", JdeDataType.Numeric),
        new JdeField("STAMC3", "STAMC3", JdeDataType.Numeric),
        new JdeField("STCRQT", "STCRQT", JdeDataType.Numeric),
        new JdeField("STCRAM", "STCRAM", JdeDataType.Numeric),
        new JdeField("STALQT", "STALQT", JdeDataType.Numeric),
        new JdeField("STALAM", "STALAM", JdeDataType.Numeric),
        new JdeField("STALDA", "STALDA", JdeDataType.Numeric),
        new JdeField("STPSFL", "STPSFL", JdeDataType.String, 2),
        new JdeField("STCRR", "STCRR", JdeDataType.Numeric),
        new JdeField("STSVQT", "STSVQT", JdeDataType.Numeric),
        new JdeField("STSVUM", "STSVUM", JdeDataType.String, 4),
        new JdeField("STSVDT", "STSVDT", JdeDataType.Numeric),
        new JdeField("STSVFU", "STSVFU", JdeDataType.String, 4),
        new JdeField("STSVF1", "STSVF1", JdeDataType.String, 2),
        new JdeField("STSVF2", "STSVF2", JdeDataType.String, 2),
        new JdeField("STSVF3", "STSVF3", JdeDataType.String, 2),
        new JdeField("STSVF4", "STSVF4", JdeDataType.String, 2),
        new JdeField("STSVF5", "STSVF5", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STTDAY", "STTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39062_0", "Primary Key on STCRCD, STSVVM, STSVYR, STPNC, STITPL, STITM, STCO, STMCU, STRCPD, STUKID", new[] { "STCRCD", "STSVVM", "STSVYR", "STPNC", "STITPL", "STITM", "STCO", "STMCU", "STRCPD", "STUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F39062_1", "Index on STCRCD, STSVVM, STSVYR, STPNC, STITPL, STITM, STCO, STMCU, STRCPD", new[] { "STCRCD", "STSVVM", "STSVYR", "STPNC", "STITPL", "STITM", "STCO", "STMCU", "STRCPD" }),
        new JdeIndex("F39062_3", "Index on STCRCD, STSVVM, SYS_NC00036$, SYS_NC00037$, STITPL, STITM, STCO, STMCU, SYS_NC00038$, STUKID", new[] { "STCRCD", "STSVVM", "SYS_NC00036$", "SYS_NC00037$", "STITPL", "STITM", "STCO", "STMCU", "SYS_NC00038$", "STUKID" }),
        new JdeIndex("F39062_4", "Index on STCRCD, STSVVM, STITPL, STITM, STCO, STMCU, STSVYR, STPNC", new[] { "STCRCD", "STSVVM", "STITPL", "STITM", "STCO", "STMCU", "STSVYR", "STPNC" })
    };
}
