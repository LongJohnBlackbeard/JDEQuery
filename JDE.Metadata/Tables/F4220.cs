using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4220 - .
/// </summary>
public class F4220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWITM.
        /// </summary>
        public const string SWITM = "SWITM";

        /// <summary>
        /// SWLITM.
        /// </summary>
        public const string SWLITM = "SWLITM";

        /// <summary>
        /// SWAITM.
        /// </summary>
        public const string SWAITM = "SWAITM";

        /// <summary>
        /// SWDSC1.
        /// </summary>
        public const string SWDSC1 = "SWDSC1";

        /// <summary>
        /// SWDSC2.
        /// </summary>
        public const string SWDSC2 = "SWDSC2";

        /// <summary>
        /// SWDSC3.
        /// </summary>
        public const string SWDSC3 = "SWDSC3";

        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWLOTN.
        /// </summary>
        public const string SWLOTN = "SWLOTN";

        /// <summary>
        /// SWLOCN.
        /// </summary>
        public const string SWLOCN = "SWLOCN";

        /// <summary>
        /// SWAN8.
        /// </summary>
        public const string SWAN8 = "SWAN8";

        /// <summary>
        /// SWSHAN.
        /// </summary>
        public const string SWSHAN = "SWSHAN";

        /// <summary>
        /// SWKCOO.
        /// </summary>
        public const string SWKCOO = "SWKCOO";

        /// <summary>
        /// SWDOCO.
        /// </summary>
        public const string SWDOCO = "SWDOCO";

        /// <summary>
        /// SWDCTO.
        /// </summary>
        public const string SWDCTO = "SWDCTO";

        /// <summary>
        /// SWSFXO.
        /// </summary>
        public const string SWSFXO = "SWSFXO";

        /// <summary>
        /// SWLNID.
        /// </summary>
        public const string SWLNID = "SWLNID";

        /// <summary>
        /// SWORDJ.
        /// </summary>
        public const string SWORDJ = "SWORDJ";

        /// <summary>
        /// SWSHPJ.
        /// </summary>
        public const string SWSHPJ = "SWSHPJ";

        /// <summary>
        /// SWSRL1.
        /// </summary>
        public const string SWSRL1 = "SWSRL1";

        /// <summary>
        /// SWSRL2.
        /// </summary>
        public const string SWSRL2 = "SWSRL2";

        /// <summary>
        /// SWVEND.
        /// </summary>
        public const string SWVEND = "SWVEND";

        /// <summary>
        /// SWWARR.
        /// </summary>
        public const string SWWARR = "SWWARR";

        /// <summary>
        /// SWWARJ.
        /// </summary>
        public const string SWWARJ = "SWWARJ";

        /// <summary>
        /// SWWRLF.
        /// </summary>
        public const string SWWRLF = "SWWRLF";

        /// <summary>
        /// SWWEXP.
        /// </summary>
        public const string SWWEXP = "SWWEXP";

        /// <summary>
        /// SWDOCE.
        /// </summary>
        public const string SWDOCE = "SWDOCE";

        /// <summary>
        /// SWDCTE.
        /// </summary>
        public const string SWDCTE = "SWDCTE";

        /// <summary>
        /// SWWREM.
        /// </summary>
        public const string SWWREM = "SWWREM";

        /// <summary>
        /// SWDOCW.
        /// </summary>
        public const string SWDOCW = "SWDOCW";

        /// <summary>
        /// SWDCTR.
        /// </summary>
        public const string SWDCTR = "SWDCTR";

        /// <summary>
        /// SWSNCD.
        /// </summary>
        public const string SWSNCD = "SWSNCD";

        /// <summary>
        /// SWAISL.
        /// </summary>
        public const string SWAISL = "SWAISL";

        /// <summary>
        /// SWBIN.
        /// </summary>
        public const string SWBIN = "SWBIN";
    }

    /// <inheritdoc />
    public override string TableName => "F4220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWITM", "SWITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SWLITM", "SWLITM", JdeDataType.String, 50),
        new JdeField("SWAITM", "SWAITM", JdeDataType.String, 50),
        new JdeField("SWDSC1", "SWDSC1", JdeDataType.String, 60),
        new JdeField("SWDSC2", "SWDSC2", JdeDataType.String, 60),
        new JdeField("SWDSC3", "SWDSC3", JdeDataType.String, 60),
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24),
        new JdeField("SWLOTN", "SWLOTN", JdeDataType.String, 60),
        new JdeField("SWLOCN", "SWLOCN", JdeDataType.String, 40),
        new JdeField("SWAN8", "SWAN8", JdeDataType.Numeric),
        new JdeField("SWSHAN", "SWSHAN", JdeDataType.Numeric),
        new JdeField("SWKCOO", "SWKCOO", JdeDataType.String, 10),
        new JdeField("SWDOCO", "SWDOCO", JdeDataType.Numeric),
        new JdeField("SWDCTO", "SWDCTO", JdeDataType.String, 4),
        new JdeField("SWSFXO", "SWSFXO", JdeDataType.String, 6),
        new JdeField("SWLNID", "SWLNID", JdeDataType.Numeric),
        new JdeField("SWORDJ", "SWORDJ", JdeDataType.Numeric),
        new JdeField("SWSHPJ", "SWSHPJ", JdeDataType.Numeric),
        new JdeField("SWSRL1", "SWSRL1", JdeDataType.String, 60, true, true),
        new JdeField("SWSRL2", "SWSRL2", JdeDataType.String, 60),
        new JdeField("SWVEND", "SWVEND", JdeDataType.Numeric),
        new JdeField("SWWARR", "SWWARR", JdeDataType.String, 16),
        new JdeField("SWWARJ", "SWWARJ", JdeDataType.Numeric),
        new JdeField("SWWRLF", "SWWRLF", JdeDataType.Numeric),
        new JdeField("SWWEXP", "SWWEXP", JdeDataType.Numeric),
        new JdeField("SWDOCE", "SWDOCE", JdeDataType.Numeric),
        new JdeField("SWDCTE", "SWDCTE", JdeDataType.String, 4),
        new JdeField("SWWREM", "SWWREM", JdeDataType.Numeric),
        new JdeField("SWDOCW", "SWDOCW", JdeDataType.Numeric),
        new JdeField("SWDCTR", "SWDCTR", JdeDataType.String, 4),
        new JdeField("SWSNCD", "SWSNCD", JdeDataType.String, 4),
        new JdeField("SWAISL", "SWAISL", JdeDataType.String, 16),
        new JdeField("SWBIN", "SWBIN", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4220_0", "Primary Key on SWITM, SWSRL1", new[] { "SWITM", "SWSRL1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4220_2", "Index on SWSRL1, SWITM", new[] { "SWSRL1", "SWITM" }),
        new JdeIndex("F4220_3", "Index on SWSRL2, SWITM", new[] { "SWSRL2", "SWITM" }),
        new JdeIndex("F4220_4", "Index on SWAN8", new[] { "SWAN8" }),
        new JdeIndex("F4220_5", "Index on SWITM, SWDOCO, SWDCTO, SWKCOO, SWSFXO, SWLNID", new[] { "SWITM", "SWDOCO", "SWDCTO", "SWKCOO", "SWSFXO", "SWLNID" }),
        new JdeIndex("F4220_6", "Index on SWDOCO, SWDCTO, SWKCOO", new[] { "SWDOCO", "SWDCTO", "SWKCOO" })
    };
}
