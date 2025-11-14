using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F157021 - .
/// </summary>
public class F157021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NGDOCO.
        /// </summary>
        public const string NGDOCO = "NGDOCO";

        /// <summary>
        /// NGAN8.
        /// </summary>
        public const string NGAN8 = "NGAN8";

        /// <summary>
        /// NGCLNO.
        /// </summary>
        public const string NGCLNO = "NGCLNO";

        /// <summary>
        /// NGDNUM.
        /// </summary>
        public const string NGDNUM = "NGDNUM";

        /// <summary>
        /// NGSEQN.
        /// </summary>
        public const string NGSEQN = "NGSEQN";

        /// <summary>
        /// NGDOFF.
        /// </summary>
        public const string NGDOFF = "NGDOFF";

        /// <summary>
        /// NGDDCS.
        /// </summary>
        public const string NGDDCS = "NGDDCS";

        /// <summary>
        /// NGADEC.
        /// </summary>
        public const string NGADEC = "NGADEC";

        /// <summary>
        /// NGDSAC.
        /// </summary>
        public const string NGDSAC = "NGDSAC";

        /// <summary>
        /// NGLSVR.
        /// </summary>
        public const string NGLSVR = "NGLSVR";

        /// <summary>
        /// NGURCD.
        /// </summary>
        public const string NGURCD = "NGURCD";

        /// <summary>
        /// NGURDT.
        /// </summary>
        public const string NGURDT = "NGURDT";

        /// <summary>
        /// NGURAT.
        /// </summary>
        public const string NGURAT = "NGURAT";

        /// <summary>
        /// NGURAB.
        /// </summary>
        public const string NGURAB = "NGURAB";

        /// <summary>
        /// NGURRF.
        /// </summary>
        public const string NGURRF = "NGURRF";

        /// <summary>
        /// NGUSER.
        /// </summary>
        public const string NGUSER = "NGUSER";

        /// <summary>
        /// NGPID.
        /// </summary>
        public const string NGPID = "NGPID";

        /// <summary>
        /// NGUPMJ.
        /// </summary>
        public const string NGUPMJ = "NGUPMJ";

        /// <summary>
        /// NGUPMT.
        /// </summary>
        public const string NGUPMT = "NGUPMT";

        /// <summary>
        /// NGJOBN.
        /// </summary>
        public const string NGJOBN = "NGJOBN";

        /// <summary>
        /// NGENTJ.
        /// </summary>
        public const string NGENTJ = "NGENTJ";

        /// <summary>
        /// NGTORG.
        /// </summary>
        public const string NGTORG = "NGTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F157021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NGDOCO", "NGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NGAN8", "NGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NGCLNO", "NGCLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NGDNUM", "NGDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("NGSEQN", "NGSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("NGDOFF", "NGDOFF", JdeDataType.Numeric),
        new JdeField("NGDDCS", "NGDDCS", JdeDataType.Numeric),
        new JdeField("NGADEC", "NGADEC", JdeDataType.String, 2),
        new JdeField("NGDSAC", "NGDSAC", JdeDataType.Numeric),
        new JdeField("NGLSVR", "NGLSVR", JdeDataType.Numeric),
        new JdeField("NGURCD", "NGURCD", JdeDataType.String, 4),
        new JdeField("NGURDT", "NGURDT", JdeDataType.Numeric),
        new JdeField("NGURAT", "NGURAT", JdeDataType.Numeric),
        new JdeField("NGURAB", "NGURAB", JdeDataType.Numeric),
        new JdeField("NGURRF", "NGURRF", JdeDataType.String, 30),
        new JdeField("NGUSER", "NGUSER", JdeDataType.String, 20),
        new JdeField("NGPID", "NGPID", JdeDataType.String, 20),
        new JdeField("NGUPMJ", "NGUPMJ", JdeDataType.Numeric),
        new JdeField("NGUPMT", "NGUPMT", JdeDataType.Numeric),
        new JdeField("NGJOBN", "NGJOBN", JdeDataType.String, 20),
        new JdeField("NGENTJ", "NGENTJ", JdeDataType.Numeric),
        new JdeField("NGTORG", "NGTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F157021_0", "Primary Key on NGDOCO, NGAN8, NGCLNO, NGDNUM, NGSEQN", new[] { "NGDOCO", "NGAN8", "NGCLNO", "NGDNUM", "NGSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F157021_2", "Index on NGDOCO, NGAN8, NGCLNO, NGDNUM, SYS_NC00023$", new[] { "NGDOCO", "NGAN8", "NGCLNO", "NGDNUM", "SYS_NC00023$" }),
        new JdeIndex("F157021_3", "Index on NGDOCO, NGAN8, NGCLNO, NGDNUM, NGLSVR", new[] { "NGDOCO", "NGAN8", "NGCLNO", "NGDNUM", "NGLSVR" })
    };
}
