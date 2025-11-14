using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15701 - .
/// </summary>
public class F15701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NKDOCO.
        /// </summary>
        public const string NKDOCO = "NKDOCO";

        /// <summary>
        /// NKAN8.
        /// </summary>
        public const string NKAN8 = "NKAN8";

        /// <summary>
        /// NKCLNO.
        /// </summary>
        public const string NKCLNO = "NKCLNO";

        /// <summary>
        /// NKOPTY.
        /// </summary>
        public const string NKOPTY = "NKOPTY";

        /// <summary>
        /// NKODET.
        /// </summary>
        public const string NKODET = "NKODET";

        /// <summary>
        /// NKDNUM.
        /// </summary>
        public const string NKDNUM = "NKDNUM";

        /// <summary>
        /// NKSEQN.
        /// </summary>
        public const string NKSEQN = "NKSEQN";

        /// <summary>
        /// NKDOFF.
        /// </summary>
        public const string NKDOFF = "NKDOFF";

        /// <summary>
        /// NKADEC.
        /// </summary>
        public const string NKADEC = "NKADEC";

        /// <summary>
        /// NKDDCS.
        /// </summary>
        public const string NKDDCS = "NKDDCS";

        /// <summary>
        /// NKDSAC.
        /// </summary>
        public const string NKDSAC = "NKDSAC";

        /// <summary>
        /// NKLSVR.
        /// </summary>
        public const string NKLSVR = "NKLSVR";

        /// <summary>
        /// NKURCD.
        /// </summary>
        public const string NKURCD = "NKURCD";

        /// <summary>
        /// NKURDT.
        /// </summary>
        public const string NKURDT = "NKURDT";

        /// <summary>
        /// NKURAT.
        /// </summary>
        public const string NKURAT = "NKURAT";

        /// <summary>
        /// NKURAB.
        /// </summary>
        public const string NKURAB = "NKURAB";

        /// <summary>
        /// NKURRF.
        /// </summary>
        public const string NKURRF = "NKURRF";

        /// <summary>
        /// NKUSER.
        /// </summary>
        public const string NKUSER = "NKUSER";

        /// <summary>
        /// NKPID.
        /// </summary>
        public const string NKPID = "NKPID";

        /// <summary>
        /// NKUPMJ.
        /// </summary>
        public const string NKUPMJ = "NKUPMJ";

        /// <summary>
        /// NKUPMT.
        /// </summary>
        public const string NKUPMT = "NKUPMT";

        /// <summary>
        /// NKJOBN.
        /// </summary>
        public const string NKJOBN = "NKJOBN";

        /// <summary>
        /// NKENTJ.
        /// </summary>
        public const string NKENTJ = "NKENTJ";

        /// <summary>
        /// NKTORG.
        /// </summary>
        public const string NKTORG = "NKTORG";

        /// <summary>
        /// NKHIER.
        /// </summary>
        public const string NKHIER = "NKHIER";
    }

    /// <inheritdoc />
    public override string TableName => "F15701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NKDOCO", "NKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NKAN8", "NKAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NKCLNO", "NKCLNO", JdeDataType.Numeric, null, true, true),
        new JdeField("NKOPTY", "NKOPTY", JdeDataType.String, 8, true, true),
        new JdeField("NKODET", "NKODET", JdeDataType.String, 20, true, true),
        new JdeField("NKDNUM", "NKDNUM", JdeDataType.Numeric),
        new JdeField("NKSEQN", "NKSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("NKDOFF", "NKDOFF", JdeDataType.Numeric),
        new JdeField("NKADEC", "NKADEC", JdeDataType.String, 2),
        new JdeField("NKDDCS", "NKDDCS", JdeDataType.Numeric),
        new JdeField("NKDSAC", "NKDSAC", JdeDataType.Numeric),
        new JdeField("NKLSVR", "NKLSVR", JdeDataType.Numeric),
        new JdeField("NKURCD", "NKURCD", JdeDataType.String, 4),
        new JdeField("NKURDT", "NKURDT", JdeDataType.Numeric),
        new JdeField("NKURAT", "NKURAT", JdeDataType.Numeric),
        new JdeField("NKURAB", "NKURAB", JdeDataType.Numeric),
        new JdeField("NKURRF", "NKURRF", JdeDataType.String, 30),
        new JdeField("NKUSER", "NKUSER", JdeDataType.String, 20),
        new JdeField("NKPID", "NKPID", JdeDataType.String, 20),
        new JdeField("NKUPMJ", "NKUPMJ", JdeDataType.Numeric),
        new JdeField("NKUPMT", "NKUPMT", JdeDataType.Numeric),
        new JdeField("NKJOBN", "NKJOBN", JdeDataType.String, 20),
        new JdeField("NKENTJ", "NKENTJ", JdeDataType.Numeric),
        new JdeField("NKTORG", "NKTORG", JdeDataType.String, 20),
        new JdeField("NKHIER", "NKHIER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15701_0", "Primary Key on NKDOCO, NKAN8, NKCLNO, NKOPTY, NKODET, NKSEQN", new[] { "NKDOCO", "NKAN8", "NKCLNO", "NKOPTY", "NKODET", "NKSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15701_2", "Index on NKDOCO, NKAN8, NKCLNO, NKOPTY, NKODET, SYS_NC00026$", new[] { "NKDOCO", "NKAN8", "NKCLNO", "NKOPTY", "NKODET", "SYS_NC00026$" }),
        new JdeIndex("F15701_3", "Index on NKDOCO, NKAN8, NKCLNO, NKLSVR", new[] { "NKDOCO", "NKAN8", "NKCLNO", "NKLSVR" })
    };
}
