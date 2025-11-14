using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I344 - .
/// </summary>
public class F75I344 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QBYEXU.
        /// </summary>
        public const string QBYEXU = "QBYEXU";

        /// <summary>
        /// QBBDSN.
        /// </summary>
        public const string QBBDSN = "QBBDSN";

        /// <summary>
        /// QBBDNO.
        /// </summary>
        public const string QBBDNO = "QBBDNO";

        /// <summary>
        /// QBBDDT.
        /// </summary>
        public const string QBBDDT = "QBBDDT";

        /// <summary>
        /// QBYARN.
        /// </summary>
        public const string QBYARN = "QBYARN";

        /// <summary>
        /// QBYARD.
        /// </summary>
        public const string QBYARD = "QBYARD";

        /// <summary>
        /// QBKCOO.
        /// </summary>
        public const string QBKCOO = "QBKCOO";

        /// <summary>
        /// QBDOCO.
        /// </summary>
        public const string QBDOCO = "QBDOCO";

        /// <summary>
        /// QBDCTO.
        /// </summary>
        public const string QBDCTO = "QBDCTO";

        /// <summary>
        /// QBKCO.
        /// </summary>
        public const string QBKCO = "QBKCO";

        /// <summary>
        /// QBDOC.
        /// </summary>
        public const string QBDOC = "QBDOC";

        /// <summary>
        /// QBDCT.
        /// </summary>
        public const string QBDCT = "QBDCT";

        /// <summary>
        /// QBYEXA.
        /// </summary>
        public const string QBYEXA = "QBYEXA";

        /// <summary>
        /// QBASVL.
        /// </summary>
        public const string QBASVL = "QBASVL";

        /// <summary>
        /// QBDES2.
        /// </summary>
        public const string QBDES2 = "QBDES2";

        /// <summary>
        /// QBXOPR.
        /// </summary>
        public const string QBXOPR = "QBXOPR";

        /// <summary>
        /// QBEDER.
        /// </summary>
        public const string QBEDER = "QBEDER";

        /// <summary>
        /// QBSHPJ.
        /// </summary>
        public const string QBSHPJ = "QBSHPJ";

        /// <summary>
        /// QBDATESUB.
        /// </summary>
        public const string QBDATESUB = "QBDATESUB";

        /// <summary>
        /// QBATDJ.
        /// </summary>
        public const string QBATDJ = "QBATDJ";

        /// <summary>
        /// QBREMK.
        /// </summary>
        public const string QBREMK = "QBREMK";

        /// <summary>
        /// QBPBAA.
        /// </summary>
        public const string QBPBAA = "QBPBAA";

        /// <summary>
        /// QBTORG.
        /// </summary>
        public const string QBTORG = "QBTORG";

        /// <summary>
        /// QBUSER.
        /// </summary>
        public const string QBUSER = "QBUSER";

        /// <summary>
        /// QBJOBN.
        /// </summary>
        public const string QBJOBN = "QBJOBN";

        /// <summary>
        /// QBPID.
        /// </summary>
        public const string QBPID = "QBPID";

        /// <summary>
        /// QBUPMJ.
        /// </summary>
        public const string QBUPMJ = "QBUPMJ";

        /// <summary>
        /// QBTDAY.
        /// </summary>
        public const string QBTDAY = "QBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I344";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QBYEXU", "QBYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QBBDSN", "QBBDSN", JdeDataType.String, 44, true, true),
        new JdeField("QBBDNO", "QBBDNO", JdeDataType.Numeric, null, true, true),
        new JdeField("QBBDDT", "QBBDDT", JdeDataType.Numeric),
        new JdeField("QBYARN", "QBYARN", JdeDataType.Numeric),
        new JdeField("QBYARD", "QBYARD", JdeDataType.Numeric),
        new JdeField("QBKCOO", "QBKCOO", JdeDataType.String, 10),
        new JdeField("QBDOCO", "QBDOCO", JdeDataType.Numeric),
        new JdeField("QBDCTO", "QBDCTO", JdeDataType.String, 4),
        new JdeField("QBKCO", "QBKCO", JdeDataType.String, 10),
        new JdeField("QBDOC", "QBDOC", JdeDataType.Numeric),
        new JdeField("QBDCT", "QBDCT", JdeDataType.String, 4),
        new JdeField("QBYEXA", "QBYEXA", JdeDataType.Numeric),
        new JdeField("QBASVL", "QBASVL", JdeDataType.Numeric),
        new JdeField("QBDES2", "QBDES2", JdeDataType.String, 70),
        new JdeField("QBXOPR", "QBXOPR", JdeDataType.String, 120),
        new JdeField("QBEDER", "QBEDER", JdeDataType.String, 2, true, true),
        new JdeField("QBSHPJ", "QBSHPJ", JdeDataType.Numeric),
        new JdeField("QBDATESUB", "QBDATESUB", JdeDataType.Numeric),
        new JdeField("QBATDJ", "QBATDJ", JdeDataType.Numeric),
        new JdeField("QBREMK", "QBREMK", JdeDataType.String, 60),
        new JdeField("QBPBAA", "QBPBAA", JdeDataType.Numeric),
        new JdeField("QBTORG", "QBTORG", JdeDataType.String, 20),
        new JdeField("QBUSER", "QBUSER", JdeDataType.String, 20),
        new JdeField("QBJOBN", "QBJOBN", JdeDataType.String, 20),
        new JdeField("QBPID", "QBPID", JdeDataType.String, 20),
        new JdeField("QBUPMJ", "QBUPMJ", JdeDataType.Numeric),
        new JdeField("QBTDAY", "QBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I344_0", "Primary Key on QBYEXU, QBBDSN, QBBDNO, QBEDER", new[] { "QBYEXU", "QBBDSN", "QBBDNO", "QBEDER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I344_2", "Index on QBYEXU, QBKCO, QBDOC, QBDCT", new[] { "QBYEXU", "QBKCO", "QBDOC", "QBDCT" }),
        new JdeIndex("F75I344_3", "Index on QBYEXU, QBBDSN, SYS_NC00029$", new[] { "QBYEXU", "QBBDSN", "SYS_NC00029$" })
    };
}
