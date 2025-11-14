using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41512 - .
/// </summary>
public class F41512 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTMCU.
        /// </summary>
        public const string PTMCU = "PTMCU";

        /// <summary>
        /// PTITM.
        /// </summary>
        public const string PTITM = "PTITM";

        /// <summary>
        /// PTGLRN.
        /// </summary>
        public const string PTGLRN = "PTGLRN";

        /// <summary>
        /// PTDOC.
        /// </summary>
        public const string PTDOC = "PTDOC";

        /// <summary>
        /// PTDCT.
        /// </summary>
        public const string PTDCT = "PTDCT";

        /// <summary>
        /// PTKCO.
        /// </summary>
        public const string PTKCO = "PTKCO";

        /// <summary>
        /// PTJELN.
        /// </summary>
        public const string PTJELN = "PTJELN";

        /// <summary>
        /// PTKCOO.
        /// </summary>
        public const string PTKCOO = "PTKCOO";

        /// <summary>
        /// PTDOCO.
        /// </summary>
        public const string PTDOCO = "PTDOCO";

        /// <summary>
        /// PTDCTO.
        /// </summary>
        public const string PTDCTO = "PTDCTO";

        /// <summary>
        /// PTLNID.
        /// </summary>
        public const string PTLNID = "PTLNID";

        /// <summary>
        /// PTNLIN.
        /// </summary>
        public const string PTNLIN = "PTNLIN";

        /// <summary>
        /// PTLOCN.
        /// </summary>
        public const string PTLOCN = "PTLOCN";

        /// <summary>
        /// PTGLQT.
        /// </summary>
        public const string PTGLQT = "PTGLQT";

        /// <summary>
        /// PTBUM1.
        /// </summary>
        public const string PTBUM1 = "PTBUM1";

        /// <summary>
        /// PTGLRS.
        /// </summary>
        public const string PTGLRS = "PTGLRS";

        /// <summary>
        /// PTGLUP.
        /// </summary>
        public const string PTGLUP = "PTGLUP";

        /// <summary>
        /// PTTRDJ.
        /// </summary>
        public const string PTTRDJ = "PTTRDJ";

        /// <summary>
        /// PTTHDT.
        /// </summary>
        public const string PTTHDT = "PTTHDT";

        /// <summary>
        /// PTOPDT.
        /// </summary>
        public const string PTOPDT = "PTOPDT";

        /// <summary>
        /// PTOUTG.
        /// </summary>
        public const string PTOUTG = "PTOUTG";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTTDAY.
        /// </summary>
        public const string PTTDAY = "PTTDAY";

        /// <summary>
        /// PTURRF.
        /// </summary>
        public const string PTURRF = "PTURRF";

        /// <summary>
        /// PTURDT.
        /// </summary>
        public const string PTURDT = "PTURDT";

        /// <summary>
        /// PTURCD.
        /// </summary>
        public const string PTURCD = "PTURCD";

        /// <summary>
        /// PTURAT.
        /// </summary>
        public const string PTURAT = "PTURAT";

        /// <summary>
        /// PTURAB.
        /// </summary>
        public const string PTURAB = "PTURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F41512";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTMCU", "PTMCU", JdeDataType.String, 24),
        new JdeField("PTITM", "PTITM", JdeDataType.Numeric),
        new JdeField("PTGLRN", "PTGLRN", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDOC", "PTDOC", JdeDataType.Numeric),
        new JdeField("PTDCT", "PTDCT", JdeDataType.String, 4),
        new JdeField("PTKCO", "PTKCO", JdeDataType.String, 10),
        new JdeField("PTJELN", "PTJELN", JdeDataType.Numeric),
        new JdeField("PTKCOO", "PTKCOO", JdeDataType.String, 10),
        new JdeField("PTDOCO", "PTDOCO", JdeDataType.Numeric),
        new JdeField("PTDCTO", "PTDCTO", JdeDataType.String, 4),
        new JdeField("PTLNID", "PTLNID", JdeDataType.Numeric),
        new JdeField("PTNLIN", "PTNLIN", JdeDataType.Numeric),
        new JdeField("PTLOCN", "PTLOCN", JdeDataType.String, 40),
        new JdeField("PTGLQT", "PTGLQT", JdeDataType.Numeric),
        new JdeField("PTBUM1", "PTBUM1", JdeDataType.String, 4),
        new JdeField("PTGLRS", "PTGLRS", JdeDataType.String, 4),
        new JdeField("PTGLUP", "PTGLUP", JdeDataType.String, 2),
        new JdeField("PTTRDJ", "PTTRDJ", JdeDataType.Numeric),
        new JdeField("PTTHDT", "PTTHDT", JdeDataType.Numeric),
        new JdeField("PTOPDT", "PTOPDT", JdeDataType.Numeric),
        new JdeField("PTOUTG", "PTOUTG", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric),
        new JdeField("PTURRF", "PTURRF", JdeDataType.String, 30),
        new JdeField("PTURDT", "PTURDT", JdeDataType.Numeric),
        new JdeField("PTURCD", "PTURCD", JdeDataType.String, 4),
        new JdeField("PTURAT", "PTURAT", JdeDataType.Numeric),
        new JdeField("PTURAB", "PTURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41512_0", "Primary Key on PTGLRN", new[] { "PTGLRN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41512_2", "Index on PTDOC, PTDCT, PTKCO", new[] { "PTDOC", "PTDCT", "PTKCO" }),
        new JdeIndex("F41512_3", "Index on PTMCU, PTITM, PTTRDJ", new[] { "PTMCU", "PTITM", "PTTRDJ" }),
        new JdeIndex("F41512_4", "Index on PTITM, PTMCU, PTLOCN, PTGLRS, PTTRDJ", new[] { "PTITM", "PTMCU", "PTLOCN", "PTGLRS", "PTTRDJ" }),
        new JdeIndex("F41512_5", "Index on PTMCU, PTLOCN, PTITM, PTGLRS, PTTRDJ", new[] { "PTMCU", "PTLOCN", "PTITM", "PTGLRS", "PTTRDJ" }),
        new JdeIndex("F41512_6", "Index on PTTRDJ, PTGLRN", new[] { "PTTRDJ", "PTGLRN" }),
        new JdeIndex("F41512_7", "Index on PTDOC, PTDCT, PTKCO, PTDOCO, PTDCTO, PTKCOO, PTLNID, PTGLRS", new[] { "PTDOC", "PTDCT", "PTKCO", "PTDOCO", "PTDCTO", "PTKCOO", "PTLNID", "PTGLRS" })
    };
}
