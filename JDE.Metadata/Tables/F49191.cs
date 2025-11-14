using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49191 - .
/// </summary>
public class F49191 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DSDCCD.
        /// </summary>
        public const string DSDCCD = "DSDCCD";

        /// <summary>
        /// DSDCT.
        /// </summary>
        public const string DSDCT = "DSDCT";

        /// <summary>
        /// DSPGM.
        /// </summary>
        public const string DSPGM = "DSPGM";

        /// <summary>
        /// DSVERS.
        /// </summary>
        public const string DSVERS = "DSVERS";

        /// <summary>
        /// DSSEQ.
        /// </summary>
        public const string DSSEQ = "DSSEQ";

        /// <summary>
        /// DSDCLV.
        /// </summary>
        public const string DSDCLV = "DSDCLV";

        /// <summary>
        /// DSPDDU.
        /// </summary>
        public const string DSPDDU = "DSPDDU";

        /// <summary>
        /// DSPIDU.
        /// </summary>
        public const string DSPIDU = "DSPIDU";

        /// <summary>
        /// DSDDRF.
        /// </summary>
        public const string DSDDRF = "DSDDRF";

        /// <summary>
        /// DSDRCF.
        /// </summary>
        public const string DSDRCF = "DSDRCF";

        /// <summary>
        /// DSIMSC.
        /// </summary>
        public const string DSIMSC = "DSIMSC";

        /// <summary>
        /// DSDFTU.
        /// </summary>
        public const string DSDFTU = "DSDFTU";

        /// <summary>
        /// DSPIDN.
        /// </summary>
        public const string DSPIDN = "DSPIDN";

        /// <summary>
        /// DSREFQ.
        /// </summary>
        public const string DSREFQ = "DSREFQ";

        /// <summary>
        /// DSURCD.
        /// </summary>
        public const string DSURCD = "DSURCD";

        /// <summary>
        /// DSURDT.
        /// </summary>
        public const string DSURDT = "DSURDT";

        /// <summary>
        /// DSURAT.
        /// </summary>
        public const string DSURAT = "DSURAT";

        /// <summary>
        /// DSURAB.
        /// </summary>
        public const string DSURAB = "DSURAB";

        /// <summary>
        /// DSURRF.
        /// </summary>
        public const string DSURRF = "DSURRF";

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
    public override string TableName => "F49191";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DSDCCD", "DSDCCD", JdeDataType.String, 8, true, true),
        new JdeField("DSDCT", "DSDCT", JdeDataType.String, 4),
        new JdeField("DSPGM", "DSPGM", JdeDataType.String, 20),
        new JdeField("DSVERS", "DSVERS", JdeDataType.String, 20),
        new JdeField("DSSEQ", "DSSEQ", JdeDataType.Numeric),
        new JdeField("DSDCLV", "DSDCLV", JdeDataType.String, 2),
        new JdeField("DSPDDU", "DSPDDU", JdeDataType.String, 2),
        new JdeField("DSPIDU", "DSPIDU", JdeDataType.String, 2),
        new JdeField("DSDDRF", "DSDDRF", JdeDataType.String, 2),
        new JdeField("DSDRCF", "DSDRCF", JdeDataType.String, 2),
        new JdeField("DSIMSC", "DSIMSC", JdeDataType.String, 2),
        new JdeField("DSDFTU", "DSDFTU", JdeDataType.String, 2),
        new JdeField("DSPIDN", "DSPIDN", JdeDataType.String, 64),
        new JdeField("DSREFQ", "DSREFQ", JdeDataType.String, 4),
        new JdeField("DSURCD", "DSURCD", JdeDataType.String, 4),
        new JdeField("DSURDT", "DSURDT", JdeDataType.Numeric),
        new JdeField("DSURAT", "DSURAT", JdeDataType.Numeric),
        new JdeField("DSURAB", "DSURAB", JdeDataType.Numeric),
        new JdeField("DSURRF", "DSURRF", JdeDataType.String, 30),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49191_0", "Primary Key on DSDCCD", new[] { "DSDCCD" }, isUnique: true, isPrimaryKey: true)
    };
}
