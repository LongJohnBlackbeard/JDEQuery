using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76422 - .
/// </summary>
public class F76422 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SJDOCO.
        /// </summary>
        public const string SJDOCO = "SJDOCO";

        /// <summary>
        /// SJDCTO.
        /// </summary>
        public const string SJDCTO = "SJDCTO";

        /// <summary>
        /// SJKCOO.
        /// </summary>
        public const string SJKCOO = "SJKCOO";

        /// <summary>
        /// SJSFXO.
        /// </summary>
        public const string SJSFXO = "SJSFXO";

        /// <summary>
        /// SJLNID.
        /// </summary>
        public const string SJLNID = "SJLNID";

        /// <summary>
        /// SJBNOP.
        /// </summary>
        public const string SJBNOP = "SJBNOP";

        /// <summary>
        /// SJBSOP.
        /// </summary>
        public const string SJBSOP = "SJBSOP";

        /// <summary>
        /// SJBCTF.
        /// </summary>
        public const string SJBCTF = "SJBCTF";

        /// <summary>
        /// SJBCLF.
        /// </summary>
        public const string SJBCLF = "SJBCLF";

        /// <summary>
        /// SJBIST.
        /// </summary>
        public const string SJBIST = "SJBIST";

        /// <summary>
        /// SJBORI.
        /// </summary>
        public const string SJBORI = "SJBORI";

        /// <summary>
        /// SJBCFC.
        /// </summary>
        public const string SJBCFC = "SJBCFC";

        /// <summary>
        /// SJBINM.
        /// </summary>
        public const string SJBINM = "SJBINM";

        /// <summary>
        /// SJB76CPLN.
        /// </summary>
        public const string SJB76CPLN = "SJB76CPLN";

        /// <summary>
        /// SJEV01.
        /// </summary>
        public const string SJEV01 = "SJEV01";

        /// <summary>
        /// SJFUTMN1.
        /// </summary>
        public const string SJFUTMN1 = "SJFUTMN1";

        /// <summary>
        /// SJFUTMN2.
        /// </summary>
        public const string SJFUTMN2 = "SJFUTMN2";

        /// <summary>
        /// SJFUTMN3.
        /// </summary>
        public const string SJFUTMN3 = "SJFUTMN3";

        /// <summary>
        /// SJFUTSTG1.
        /// </summary>
        public const string SJFUTSTG1 = "SJFUTSTG1";

        /// <summary>
        /// SJFUTSTG2.
        /// </summary>
        public const string SJFUTSTG2 = "SJFUTSTG2";

        /// <summary>
        /// SJFUTSTG3.
        /// </summary>
        public const string SJFUTSTG3 = "SJFUTSTG3";

        /// <summary>
        /// SJFUTDJ1.
        /// </summary>
        public const string SJFUTDJ1 = "SJFUTDJ1";

        /// <summary>
        /// SJFUTDJ2.
        /// </summary>
        public const string SJFUTDJ2 = "SJFUTDJ2";

        /// <summary>
        /// SJFUTDJ3.
        /// </summary>
        public const string SJFUTDJ3 = "SJFUTDJ3";

        /// <summary>
        /// SJFUTCHR1.
        /// </summary>
        public const string SJFUTCHR1 = "SJFUTCHR1";

        /// <summary>
        /// SJFUTCHR2.
        /// </summary>
        public const string SJFUTCHR2 = "SJFUTCHR2";

        /// <summary>
        /// SJFUTCHR3.
        /// </summary>
        public const string SJFUTCHR3 = "SJFUTCHR3";

        /// <summary>
        /// SJURCD.
        /// </summary>
        public const string SJURCD = "SJURCD";

        /// <summary>
        /// SJURDT.
        /// </summary>
        public const string SJURDT = "SJURDT";

        /// <summary>
        /// SJURAT.
        /// </summary>
        public const string SJURAT = "SJURAT";

        /// <summary>
        /// SJURAB.
        /// </summary>
        public const string SJURAB = "SJURAB";

        /// <summary>
        /// SJURRF.
        /// </summary>
        public const string SJURRF = "SJURRF";

        /// <summary>
        /// SJUSER.
        /// </summary>
        public const string SJUSER = "SJUSER";

        /// <summary>
        /// SJPID.
        /// </summary>
        public const string SJPID = "SJPID";

        /// <summary>
        /// SJJOBN.
        /// </summary>
        public const string SJJOBN = "SJJOBN";

        /// <summary>
        /// SJUPMJ.
        /// </summary>
        public const string SJUPMJ = "SJUPMJ";

        /// <summary>
        /// SJTDAY.
        /// </summary>
        public const string SJTDAY = "SJTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76422";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SJDOCO", "SJDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SJDCTO", "SJDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SJKCOO", "SJKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SJSFXO", "SJSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SJLNID", "SJLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SJBNOP", "SJBNOP", JdeDataType.Numeric),
        new JdeField("SJBSOP", "SJBSOP", JdeDataType.String, 4),
        new JdeField("SJBCTF", "SJBCTF", JdeDataType.String, 4),
        new JdeField("SJBCLF", "SJBCLF", JdeDataType.String, 20),
        new JdeField("SJBIST", "SJBIST", JdeDataType.String, 2),
        new JdeField("SJBORI", "SJBORI", JdeDataType.String, 2),
        new JdeField("SJBCFC", "SJBCFC", JdeDataType.String, 6),
        new JdeField("SJBINM", "SJBINM", JdeDataType.String, 20),
        new JdeField("SJB76CPLN", "SJB76CPLN", JdeDataType.Numeric),
        new JdeField("SJEV01", "SJEV01", JdeDataType.String, 2),
        new JdeField("SJFUTMN1", "SJFUTMN1", JdeDataType.Numeric),
        new JdeField("SJFUTMN2", "SJFUTMN2", JdeDataType.Numeric),
        new JdeField("SJFUTMN3", "SJFUTMN3", JdeDataType.Numeric),
        new JdeField("SJFUTSTG1", "SJFUTSTG1", JdeDataType.String, 100),
        new JdeField("SJFUTSTG2", "SJFUTSTG2", JdeDataType.String, 100),
        new JdeField("SJFUTSTG3", "SJFUTSTG3", JdeDataType.String, 100),
        new JdeField("SJFUTDJ1", "SJFUTDJ1", JdeDataType.Numeric),
        new JdeField("SJFUTDJ2", "SJFUTDJ2", JdeDataType.Numeric),
        new JdeField("SJFUTDJ3", "SJFUTDJ3", JdeDataType.Numeric),
        new JdeField("SJFUTCHR1", "SJFUTCHR1", JdeDataType.String, 2),
        new JdeField("SJFUTCHR2", "SJFUTCHR2", JdeDataType.String, 2),
        new JdeField("SJFUTCHR3", "SJFUTCHR3", JdeDataType.String, 2),
        new JdeField("SJURCD", "SJURCD", JdeDataType.String, 4),
        new JdeField("SJURDT", "SJURDT", JdeDataType.Numeric),
        new JdeField("SJURAT", "SJURAT", JdeDataType.Numeric),
        new JdeField("SJURAB", "SJURAB", JdeDataType.Numeric),
        new JdeField("SJURRF", "SJURRF", JdeDataType.String, 30),
        new JdeField("SJUSER", "SJUSER", JdeDataType.String, 20),
        new JdeField("SJPID", "SJPID", JdeDataType.String, 20),
        new JdeField("SJJOBN", "SJJOBN", JdeDataType.String, 20),
        new JdeField("SJUPMJ", "SJUPMJ", JdeDataType.Numeric),
        new JdeField("SJTDAY", "SJTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76422_0", "Primary Key on SJDOCO, SJDCTO, SJKCOO, SJSFXO, SJLNID", new[] { "SJDOCO", "SJDCTO", "SJKCOO", "SJSFXO", "SJLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
