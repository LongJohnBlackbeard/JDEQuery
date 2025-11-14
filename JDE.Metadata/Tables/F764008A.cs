using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F764008A - .
/// </summary>
public class F764008A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TQTXA1.
        /// </summary>
        public const string TQTXA1 = "TQTXA1";

        /// <summary>
        /// TQITM.
        /// </summary>
        public const string TQITM = "TQITM";

        /// <summary>
        /// TQEFDJ.
        /// </summary>
        public const string TQEFDJ = "TQEFDJ";

        /// <summary>
        /// TQATR6.
        /// </summary>
        public const string TQATR6 = "TQATR6";

        /// <summary>
        /// TQATA6.
        /// </summary>
        public const string TQATA6 = "TQATA6";

        /// <summary>
        /// TQATR7.
        /// </summary>
        public const string TQATR7 = "TQATR7";

        /// <summary>
        /// TQATA7.
        /// </summary>
        public const string TQATA7 = "TQATA7";

        /// <summary>
        /// TQATR8.
        /// </summary>
        public const string TQATR8 = "TQATR8";

        /// <summary>
        /// TQATA8.
        /// </summary>
        public const string TQATA8 = "TQATA8";

        /// <summary>
        /// TQATR9.
        /// </summary>
        public const string TQATR9 = "TQATR9";

        /// <summary>
        /// TQATA9.
        /// </summary>
        public const string TQATA9 = "TQATA9";

        /// <summary>
        /// TQATR0.
        /// </summary>
        public const string TQATR0 = "TQATR0";

        /// <summary>
        /// TQATA0.
        /// </summary>
        public const string TQATA0 = "TQATA0";

        /// <summary>
        /// TQAGL6.
        /// </summary>
        public const string TQAGL6 = "TQAGL6";

        /// <summary>
        /// TQAGL7.
        /// </summary>
        public const string TQAGL7 = "TQAGL7";

        /// <summary>
        /// TQAGL8.
        /// </summary>
        public const string TQAGL8 = "TQAGL8";

        /// <summary>
        /// TQAGL9.
        /// </summary>
        public const string TQAGL9 = "TQAGL9";

        /// <summary>
        /// TQAGL0.
        /// </summary>
        public const string TQAGL0 = "TQAGL0";

        /// <summary>
        /// TQATM1.
        /// </summary>
        public const string TQATM1 = "TQATM1";

        /// <summary>
        /// TQATM2.
        /// </summary>
        public const string TQATM2 = "TQATM2";

        /// <summary>
        /// TQATM3.
        /// </summary>
        public const string TQATM3 = "TQATM3";

        /// <summary>
        /// TQATM4.
        /// </summary>
        public const string TQATM4 = "TQATM4";

        /// <summary>
        /// TQATM5.
        /// </summary>
        public const string TQATM5 = "TQATM5";

        /// <summary>
        /// TQATM6.
        /// </summary>
        public const string TQATM6 = "TQATM6";

        /// <summary>
        /// TQATM7.
        /// </summary>
        public const string TQATM7 = "TQATM7";

        /// <summary>
        /// TQATM8.
        /// </summary>
        public const string TQATM8 = "TQATM8";

        /// <summary>
        /// TQATM9.
        /// </summary>
        public const string TQATM9 = "TQATM9";

        /// <summary>
        /// TQATM0.
        /// </summary>
        public const string TQATM0 = "TQATM0";

        /// <summary>
        /// TQATS1.
        /// </summary>
        public const string TQATS1 = "TQATS1";

        /// <summary>
        /// TQATS2.
        /// </summary>
        public const string TQATS2 = "TQATS2";

        /// <summary>
        /// TQATS3.
        /// </summary>
        public const string TQATS3 = "TQATS3";

        /// <summary>
        /// TQATS4.
        /// </summary>
        public const string TQATS4 = "TQATS4";

        /// <summary>
        /// TQATS5.
        /// </summary>
        public const string TQATS5 = "TQATS5";

        /// <summary>
        /// TQATS6.
        /// </summary>
        public const string TQATS6 = "TQATS6";

        /// <summary>
        /// TQATS7.
        /// </summary>
        public const string TQATS7 = "TQATS7";

        /// <summary>
        /// TQATS8.
        /// </summary>
        public const string TQATS8 = "TQATS8";

        /// <summary>
        /// TQATS9.
        /// </summary>
        public const string TQATS9 = "TQATS9";

        /// <summary>
        /// TQATS0.
        /// </summary>
        public const string TQATS0 = "TQATS0";

        /// <summary>
        /// TQADE1.
        /// </summary>
        public const string TQADE1 = "TQADE1";

        /// <summary>
        /// TQADE2.
        /// </summary>
        public const string TQADE2 = "TQADE2";

        /// <summary>
        /// TQADE3.
        /// </summary>
        public const string TQADE3 = "TQADE3";

        /// <summary>
        /// TQADE4.
        /// </summary>
        public const string TQADE4 = "TQADE4";

        /// <summary>
        /// TQADE5.
        /// </summary>
        public const string TQADE5 = "TQADE5";

        /// <summary>
        /// TQADE6.
        /// </summary>
        public const string TQADE6 = "TQADE6";

        /// <summary>
        /// TQADE7.
        /// </summary>
        public const string TQADE7 = "TQADE7";

        /// <summary>
        /// TQADE8.
        /// </summary>
        public const string TQADE8 = "TQADE8";

        /// <summary>
        /// TQADE9.
        /// </summary>
        public const string TQADE9 = "TQADE9";

        /// <summary>
        /// TQADE0.
        /// </summary>
        public const string TQADE0 = "TQADE0";

        /// <summary>
        /// TQARBF.
        /// </summary>
        public const string TQARBF = "TQARBF";

        /// <summary>
        /// TQARBR.
        /// </summary>
        public const string TQARBR = "TQARBR";

        /// <summary>
        /// TQABO1.
        /// </summary>
        public const string TQABO1 = "TQABO1";

        /// <summary>
        /// TQABO2.
        /// </summary>
        public const string TQABO2 = "TQABO2";

        /// <summary>
        /// TQABO3.
        /// </summary>
        public const string TQABO3 = "TQABO3";

        /// <summary>
        /// TQABO4.
        /// </summary>
        public const string TQABO4 = "TQABO4";

        /// <summary>
        /// TQABO5.
        /// </summary>
        public const string TQABO5 = "TQABO5";

        /// <summary>
        /// TQABO6.
        /// </summary>
        public const string TQABO6 = "TQABO6";

        /// <summary>
        /// TQABO7.
        /// </summary>
        public const string TQABO7 = "TQABO7";

        /// <summary>
        /// TQABO8.
        /// </summary>
        public const string TQABO8 = "TQABO8";

        /// <summary>
        /// TQABO9.
        /// </summary>
        public const string TQABO9 = "TQABO9";

        /// <summary>
        /// TQABO0.
        /// </summary>
        public const string TQABO0 = "TQABO0";

        /// <summary>
        /// TQURAB.
        /// </summary>
        public const string TQURAB = "TQURAB";

        /// <summary>
        /// TQURAT.
        /// </summary>
        public const string TQURAT = "TQURAT";

        /// <summary>
        /// TQURCD.
        /// </summary>
        public const string TQURCD = "TQURCD";

        /// <summary>
        /// TQURDT.
        /// </summary>
        public const string TQURDT = "TQURDT";

        /// <summary>
        /// TQURRF.
        /// </summary>
        public const string TQURRF = "TQURRF";

        /// <summary>
        /// TQUSER.
        /// </summary>
        public const string TQUSER = "TQUSER";

        /// <summary>
        /// TQPID.
        /// </summary>
        public const string TQPID = "TQPID";

        /// <summary>
        /// TQUPMJ.
        /// </summary>
        public const string TQUPMJ = "TQUPMJ";

        /// <summary>
        /// TQUPMT.
        /// </summary>
        public const string TQUPMT = "TQUPMT";

        /// <summary>
        /// TQJOBN.
        /// </summary>
        public const string TQJOBN = "TQJOBN";

        /// <summary>
        /// TQCRCD.
        /// </summary>
        public const string TQCRCD = "TQCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F764008A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TQTXA1", "TQTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TQITM", "TQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TQEFDJ", "TQEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TQATR6", "TQATR6", JdeDataType.Numeric),
        new JdeField("TQATA6", "TQATA6", JdeDataType.Numeric),
        new JdeField("TQATR7", "TQATR7", JdeDataType.Numeric),
        new JdeField("TQATA7", "TQATA7", JdeDataType.Numeric),
        new JdeField("TQATR8", "TQATR8", JdeDataType.Numeric),
        new JdeField("TQATA8", "TQATA8", JdeDataType.Numeric),
        new JdeField("TQATR9", "TQATR9", JdeDataType.Numeric),
        new JdeField("TQATA9", "TQATA9", JdeDataType.Numeric),
        new JdeField("TQATR0", "TQATR0", JdeDataType.Numeric),
        new JdeField("TQATA0", "TQATA0", JdeDataType.Numeric),
        new JdeField("TQAGL6", "TQAGL6", JdeDataType.String, 8),
        new JdeField("TQAGL7", "TQAGL7", JdeDataType.String, 8),
        new JdeField("TQAGL8", "TQAGL8", JdeDataType.String, 8),
        new JdeField("TQAGL9", "TQAGL9", JdeDataType.String, 8),
        new JdeField("TQAGL0", "TQAGL0", JdeDataType.String, 8),
        new JdeField("TQATM1", "TQATM1", JdeDataType.Numeric),
        new JdeField("TQATM2", "TQATM2", JdeDataType.Numeric),
        new JdeField("TQATM3", "TQATM3", JdeDataType.Numeric),
        new JdeField("TQATM4", "TQATM4", JdeDataType.Numeric),
        new JdeField("TQATM5", "TQATM5", JdeDataType.Numeric),
        new JdeField("TQATM6", "TQATM6", JdeDataType.Numeric),
        new JdeField("TQATM7", "TQATM7", JdeDataType.Numeric),
        new JdeField("TQATM8", "TQATM8", JdeDataType.Numeric),
        new JdeField("TQATM9", "TQATM9", JdeDataType.Numeric),
        new JdeField("TQATM0", "TQATM0", JdeDataType.Numeric),
        new JdeField("TQATS1", "TQATS1", JdeDataType.String, 2),
        new JdeField("TQATS2", "TQATS2", JdeDataType.String, 2),
        new JdeField("TQATS3", "TQATS3", JdeDataType.String, 2),
        new JdeField("TQATS4", "TQATS4", JdeDataType.String, 2),
        new JdeField("TQATS5", "TQATS5", JdeDataType.String, 2),
        new JdeField("TQATS6", "TQATS6", JdeDataType.String, 2),
        new JdeField("TQATS7", "TQATS7", JdeDataType.String, 2),
        new JdeField("TQATS8", "TQATS8", JdeDataType.String, 2),
        new JdeField("TQATS9", "TQATS9", JdeDataType.String, 2),
        new JdeField("TQATS0", "TQATS0", JdeDataType.String, 2),
        new JdeField("TQADE1", "TQADE1", JdeDataType.String, 2),
        new JdeField("TQADE2", "TQADE2", JdeDataType.String, 2),
        new JdeField("TQADE3", "TQADE3", JdeDataType.String, 2),
        new JdeField("TQADE4", "TQADE4", JdeDataType.String, 2),
        new JdeField("TQADE5", "TQADE5", JdeDataType.String, 2),
        new JdeField("TQADE6", "TQADE6", JdeDataType.String, 2),
        new JdeField("TQADE7", "TQADE7", JdeDataType.String, 2),
        new JdeField("TQADE8", "TQADE8", JdeDataType.String, 2),
        new JdeField("TQADE9", "TQADE9", JdeDataType.String, 2),
        new JdeField("TQADE0", "TQADE0", JdeDataType.String, 2),
        new JdeField("TQARBF", "TQARBF", JdeDataType.String, 2),
        new JdeField("TQARBR", "TQARBR", JdeDataType.String, 2),
        new JdeField("TQABO1", "TQABO1", JdeDataType.Numeric),
        new JdeField("TQABO2", "TQABO2", JdeDataType.Numeric),
        new JdeField("TQABO3", "TQABO3", JdeDataType.Numeric),
        new JdeField("TQABO4", "TQABO4", JdeDataType.Numeric),
        new JdeField("TQABO5", "TQABO5", JdeDataType.Numeric),
        new JdeField("TQABO6", "TQABO6", JdeDataType.Numeric),
        new JdeField("TQABO7", "TQABO7", JdeDataType.Numeric),
        new JdeField("TQABO8", "TQABO8", JdeDataType.Numeric),
        new JdeField("TQABO9", "TQABO9", JdeDataType.Numeric),
        new JdeField("TQABO0", "TQABO0", JdeDataType.Numeric),
        new JdeField("TQURAB", "TQURAB", JdeDataType.Numeric),
        new JdeField("TQURAT", "TQURAT", JdeDataType.Numeric),
        new JdeField("TQURCD", "TQURCD", JdeDataType.String, 4),
        new JdeField("TQURDT", "TQURDT", JdeDataType.Numeric),
        new JdeField("TQURRF", "TQURRF", JdeDataType.String, 30),
        new JdeField("TQUSER", "TQUSER", JdeDataType.String, 20),
        new JdeField("TQPID", "TQPID", JdeDataType.String, 20),
        new JdeField("TQUPMJ", "TQUPMJ", JdeDataType.Numeric),
        new JdeField("TQUPMT", "TQUPMT", JdeDataType.Numeric),
        new JdeField("TQJOBN", "TQJOBN", JdeDataType.String, 20),
        new JdeField("TQCRCD", "TQCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F764008A_0", "Primary Key on TQTXA1, TQITM, TQEFDJ", new[] { "TQTXA1", "TQITM", "TQEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
