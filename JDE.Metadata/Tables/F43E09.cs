using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E09 - .
/// </summary>
public class F43E09 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AASERK.
        /// </summary>
        public const string AASERK = "AASERK";

        /// <summary>
        /// AAPROCNAME.
        /// </summary>
        public const string AAPROCNAME = "AAPROCNAME";

        /// <summary>
        /// AADOCO.
        /// </summary>
        public const string AADOCO = "AADOCO";

        /// <summary>
        /// AADCTO.
        /// </summary>
        public const string AADCTO = "AADCTO";

        /// <summary>
        /// AAKCOO.
        /// </summary>
        public const string AAKCOO = "AAKCOO";

        /// <summary>
        /// AASFXO.
        /// </summary>
        public const string AASFXO = "AASFXO";

        /// <summary>
        /// AALNID.
        /// </summary>
        public const string AALNID = "AALNID";

        /// <summary>
        /// AAMCU.
        /// </summary>
        public const string AAMCU = "AAMCU";

        /// <summary>
        /// AAYN.
        /// </summary>
        public const string AAYN = "AAYN";

        /// <summary>
        /// AAAREQ.
        /// </summary>
        public const string AAAREQ = "AAAREQ";

        /// <summary>
        /// AATORG.
        /// </summary>
        public const string AATORG = "AATORG";

        /// <summary>
        /// AAANBY.
        /// </summary>
        public const string AAANBY = "AAANBY";

        /// <summary>
        /// AARPER.
        /// </summary>
        public const string AARPER = "AARPER";

        /// <summary>
        /// AAOSTP.
        /// </summary>
        public const string AAOSTP = "AAOSTP";

        /// <summary>
        /// AATRDJ.
        /// </summary>
        public const string AATRDJ = "AATRDJ";

        /// <summary>
        /// AARDB.
        /// </summary>
        public const string AARDB = "AARDB";

        /// <summary>
        /// AARDJ.
        /// </summary>
        public const string AARDJ = "AARDJ";

        /// <summary>
        /// AARDT.
        /// </summary>
        public const string AARDT = "AARDT";

        /// <summary>
        /// AACMDCDE.
        /// </summary>
        public const string AACMDCDE = "AACMDCDE";

        /// <summary>
        /// AAITM.
        /// </summary>
        public const string AAITM = "AAITM";

        /// <summary>
        /// AALITM.
        /// </summary>
        public const string AALITM = "AALITM";

        /// <summary>
        /// AAAITM.
        /// </summary>
        public const string AAAITM = "AAAITM";

        /// <summary>
        /// AACITM.
        /// </summary>
        public const string AACITM = "AACITM";

        /// <summary>
        /// AADSC1.
        /// </summary>
        public const string AADSC1 = "AADSC1";

        /// <summary>
        /// AADSC2.
        /// </summary>
        public const string AADSC2 = "AADSC2";

        /// <summary>
        /// AAUOM.
        /// </summary>
        public const string AAUOM = "AAUOM";

        /// <summary>
        /// AAUORG.
        /// </summary>
        public const string AAUORG = "AAUORG";

        /// <summary>
        /// AAOTOT.
        /// </summary>
        public const string AAOTOT = "AAOTOT";

        /// <summary>
        /// AAERHS.
        /// </summary>
        public const string AAERHS = "AAERHS";

        /// <summary>
        /// AANDLN.
        /// </summary>
        public const string AANDLN = "AANDLN";

        /// <summary>
        /// AANCLN.
        /// </summary>
        public const string AANCLN = "AANCLN";

        /// <summary>
        /// AAAEXP.
        /// </summary>
        public const string AAAEXP = "AAAEXP";

        /// <summary>
        /// AAERDS.
        /// </summary>
        public const string AAERDS = "AAERDS";

        /// <summary>
        /// AAERCA.
        /// </summary>
        public const string AAERCA = "AAERCA";

        /// <summary>
        /// AAERTYP.
        /// </summary>
        public const string AAERTYP = "AAERTYP";

        /// <summary>
        /// AAURCD.
        /// </summary>
        public const string AAURCD = "AAURCD";

        /// <summary>
        /// AAURDT.
        /// </summary>
        public const string AAURDT = "AAURDT";

        /// <summary>
        /// AAURAT.
        /// </summary>
        public const string AAURAT = "AAURAT";

        /// <summary>
        /// AAURAB.
        /// </summary>
        public const string AAURAB = "AAURAB";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AATDAY.
        /// </summary>
        public const string AATDAY = "AATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E09";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AASERK", "AASERK", JdeDataType.Numeric, null, true, true),
        new JdeField("AAPROCNAME", "AAPROCNAME", JdeDataType.String, 20),
        new JdeField("AADOCO", "AADOCO", JdeDataType.Numeric),
        new JdeField("AADCTO", "AADCTO", JdeDataType.String, 4),
        new JdeField("AAKCOO", "AAKCOO", JdeDataType.String, 10),
        new JdeField("AASFXO", "AASFXO", JdeDataType.String, 6),
        new JdeField("AALNID", "AALNID", JdeDataType.Numeric),
        new JdeField("AAMCU", "AAMCU", JdeDataType.String, 24),
        new JdeField("AAYN", "AAYN", JdeDataType.String, 2),
        new JdeField("AAAREQ", "AAAREQ", JdeDataType.Numeric),
        new JdeField("AATORG", "AATORG", JdeDataType.String, 20),
        new JdeField("AAANBY", "AAANBY", JdeDataType.Numeric),
        new JdeField("AARPER", "AARPER", JdeDataType.Numeric),
        new JdeField("AAOSTP", "AAOSTP", JdeDataType.String, 6),
        new JdeField("AATRDJ", "AATRDJ", JdeDataType.Numeric),
        new JdeField("AARDB", "AARDB", JdeDataType.String, 20),
        new JdeField("AARDJ", "AARDJ", JdeDataType.Numeric),
        new JdeField("AARDT", "AARDT", JdeDataType.Numeric),
        new JdeField("AACMDCDE", "AACMDCDE", JdeDataType.String, 30),
        new JdeField("AAITM", "AAITM", JdeDataType.Numeric),
        new JdeField("AALITM", "AALITM", JdeDataType.String, 50),
        new JdeField("AAAITM", "AAAITM", JdeDataType.String, 50),
        new JdeField("AACITM", "AACITM", JdeDataType.String, 50),
        new JdeField("AADSC1", "AADSC1", JdeDataType.String, 60),
        new JdeField("AADSC2", "AADSC2", JdeDataType.String, 60),
        new JdeField("AAUOM", "AAUOM", JdeDataType.String, 4),
        new JdeField("AAUORG", "AAUORG", JdeDataType.Numeric),
        new JdeField("AAOTOT", "AAOTOT", JdeDataType.Numeric),
        new JdeField("AAERHS", "AAERHS", JdeDataType.String, 24),
        new JdeField("AANDLN", "AANDLN", JdeDataType.Numeric),
        new JdeField("AANCLN", "AANCLN", JdeDataType.Numeric),
        new JdeField("AAAEXP", "AAAEXP", JdeDataType.Numeric),
        new JdeField("AAERDS", "AAERDS", JdeDataType.String, 24),
        new JdeField("AAERCA", "AAERCA", JdeDataType.String, 2),
        new JdeField("AAERTYP", "AAERTYP", JdeDataType.String, 2),
        new JdeField("AAURCD", "AAURCD", JdeDataType.String, 4),
        new JdeField("AAURDT", "AAURDT", JdeDataType.Numeric),
        new JdeField("AAURAT", "AAURAT", JdeDataType.Numeric),
        new JdeField("AAURAB", "AAURAB", JdeDataType.Numeric),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AATDAY", "AATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E09_0", "Primary Key on AASERK", new[] { "AASERK" }, isUnique: true, isPrimaryKey: true)
    };
}
