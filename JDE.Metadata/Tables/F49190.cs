using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49190 - .
/// </summary>
public class F49190 : JdeTable
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

        /// <summary>
        /// DSDRCF.
        /// </summary>
        public const string DSDRCF = "DSDRCF";

        /// <summary>
        /// DSDRGF.
        /// </summary>
        public const string DSDRGF = "DSDRGF";

        /// <summary>
        /// DSPIDN.
        /// </summary>
        public const string DSPIDN = "DSPIDN";

        /// <summary>
        /// DSREFQ.
        /// </summary>
        public const string DSREFQ = "DSREFQ";
    }

    /// <inheritdoc />
    public override string TableName => "F49190";

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
        new JdeField("DSPDDU", "DSPDDU", JdeDataType.String, 2),
        new JdeField("DSPIDU", "DSPIDU", JdeDataType.String, 2),
        new JdeField("DSDDRF", "DSDDRF", JdeDataType.String, 2),
        new JdeField("DSUSER", "DSUSER", JdeDataType.String, 20),
        new JdeField("DSPID", "DSPID", JdeDataType.String, 20),
        new JdeField("DSJOBN", "DSJOBN", JdeDataType.String, 20),
        new JdeField("DSUPMJ", "DSUPMJ", JdeDataType.Numeric),
        new JdeField("DSTDAY", "DSTDAY", JdeDataType.Numeric),
        new JdeField("DSDRCF", "DSDRCF", JdeDataType.String, 2),
        new JdeField("DSDRGF", "DSDRGF", JdeDataType.String, 2),
        new JdeField("DSPIDN", "DSPIDN", JdeDataType.String, 64),
        new JdeField("DSREFQ", "DSREFQ", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49190_0", "Primary Key on DSDCCD", new[] { "DSDCCD" }, isUnique: true, isPrimaryKey: true)
    };
}
