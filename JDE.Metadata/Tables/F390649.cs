using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F390649 - .
/// </summary>
public class F390649 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSCRCD.
        /// </summary>
        public const string DSCRCD = "DSCRCD";

        /// <summary>
        /// DSSVYR.
        /// </summary>
        public const string DSSVYR = "DSSVYR";

        /// <summary>
        /// DSPNC.
        /// </summary>
        public const string DSPNC = "DSPNC";

        /// <summary>
        /// DSDCT.
        /// </summary>
        public const string DSDCT = "DSDCT";

        /// <summary>
        /// DSITPL.
        /// </summary>
        public const string DSITPL = "DSITPL";

        /// <summary>
        /// DSITM.
        /// </summary>
        public const string DSITM = "DSITM";

        /// <summary>
        /// DSCO.
        /// </summary>
        public const string DSCO = "DSCO";

        /// <summary>
        /// DSMCU.
        /// </summary>
        public const string DSMCU = "DSMCU";

        /// <summary>
        /// DSUOM.
        /// </summary>
        public const string DSUOM = "DSUOM";

        /// <summary>
        /// DSCRQT.
        /// </summary>
        public const string DSCRQT = "DSCRQT";

        /// <summary>
        /// DSCRRA.
        /// </summary>
        public const string DSCRRA = "DSCRRA";

        /// <summary>
        /// DSTNTP.
        /// </summary>
        public const string DSTNTP = "DSTNTP";

        /// <summary>
        /// DSSVQT.
        /// </summary>
        public const string DSSVQT = "DSSVQT";

        /// <summary>
        /// DSSVUM.
        /// </summary>
        public const string DSSVUM = "DSSVUM";

        /// <summary>
        /// DSSVDT.
        /// </summary>
        public const string DSSVDT = "DSSVDT";

        /// <summary>
        /// DSSVFU.
        /// </summary>
        public const string DSSVFU = "DSSVFU";

        /// <summary>
        /// DSSVF1.
        /// </summary>
        public const string DSSVF1 = "DSSVF1";

        /// <summary>
        /// DSSVF2.
        /// </summary>
        public const string DSSVF2 = "DSSVF2";

        /// <summary>
        /// DSSVF3.
        /// </summary>
        public const string DSSVF3 = "DSSVF3";

        /// <summary>
        /// DSSVF4.
        /// </summary>
        public const string DSSVF4 = "DSSVF4";

        /// <summary>
        /// DSSVF5.
        /// </summary>
        public const string DSSVF5 = "DSSVF5";

        /// <summary>
        /// DSUSER.
        /// </summary>
        public const string DSUSER = "DSUSER";

        /// <summary>
        /// DSPID.
        /// </summary>
        public const string DSPID = "DSPID";

        /// <summary>
        /// DSJOBN.
        /// </summary>
        public const string DSJOBN = "DSJOBN";

        /// <summary>
        /// DSUPMJ.
        /// </summary>
        public const string DSUPMJ = "DSUPMJ";

        /// <summary>
        /// DSTDAY.
        /// </summary>
        public const string DSTDAY = "DSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F390649";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSCRCD", "DSCRCD", JdeDataType.String, 6, true, true),
        new JdeField("DSSVYR", "DSSVYR", JdeDataType.Numeric, null, true, true),
        new JdeField("DSPNC", "DSPNC", JdeDataType.Numeric, null, true, true),
        new JdeField("DSDCT", "DSDCT", JdeDataType.String, 4, true, true),
        new JdeField("DSITPL", "DSITPL", JdeDataType.String, 20, true, true),
        new JdeField("DSITM", "DSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("DSCO", "DSCO", JdeDataType.String, 10, true, true),
        new JdeField("DSMCU", "DSMCU", JdeDataType.String, 24, true, true),
        new JdeField("DSUOM", "DSUOM", JdeDataType.String, 4),
        new JdeField("DSCRQT", "DSCRQT", JdeDataType.Numeric),
        new JdeField("DSCRRA", "DSCRRA", JdeDataType.Numeric),
        new JdeField("DSTNTP", "DSTNTP", JdeDataType.String, 2, true, true),
        new JdeField("DSSVQT", "DSSVQT", JdeDataType.Numeric),
        new JdeField("DSSVUM", "DSSVUM", JdeDataType.String, 4),
        new JdeField("DSSVDT", "DSSVDT", JdeDataType.Numeric),
        new JdeField("DSSVFU", "DSSVFU", JdeDataType.String, 4),
        new JdeField("DSSVF1", "DSSVF1", JdeDataType.String, 2),
        new JdeField("DSSVF2", "DSSVF2", JdeDataType.String, 2),
        new JdeField("DSSVF3", "DSSVF3", JdeDataType.String, 2),
        new JdeField("DSSVF4", "DSSVF4", JdeDataType.String, 2),
        new JdeField("DSSVF5", "DSSVF5", JdeDataType.String, 2),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F390649_0", "Primary Key on DSCRCD, DSSVYR, DSPNC, DSDCT, DSITPL, DSITM, DSCO, DSMCU, DSTNTP", new[] { "DSCRCD", "DSSVYR", "DSPNC", "DSDCT", "DSITPL", "DSITM", "DSCO", "DSMCU", "DSTNTP" }, isUnique: true, isPrimaryKey: true)
    };
}
