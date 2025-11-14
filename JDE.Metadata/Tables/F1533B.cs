using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1533B - .
/// </summary>
public class F1533B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NMDOCO.
        /// </summary>
        public const string NMDOCO = "NMDOCO";

        /// <summary>
        /// NMLSVR.
        /// </summary>
        public const string NMLSVR = "NMLSVR";

        /// <summary>
        /// NMDCTO.
        /// </summary>
        public const string NMDCTO = "NMDCTO";

        /// <summary>
        /// NMEPCL.
        /// </summary>
        public const string NMEPCL = "NMEPCL";

        /// <summary>
        /// NMAID.
        /// </summary>
        public const string NMAID = "NMAID";

        /// <summary>
        /// NMPCTP.
        /// </summary>
        public const string NMPCTP = "NMPCTP";

        /// <summary>
        /// NMEFTB.
        /// </summary>
        public const string NMEFTB = "NMEFTB";

        /// <summary>
        /// NMEFTE.
        /// </summary>
        public const string NMEFTE = "NMEFTE";

        /// <summary>
        /// NMADJL.
        /// </summary>
        public const string NMADJL = "NMADJL";

        /// <summary>
        /// NMLVLT.
        /// </summary>
        public const string NMLVLT = "NMLVLT";

        /// <summary>
        /// NMADJY.
        /// </summary>
        public const string NMADJY = "NMADJY";

        /// <summary>
        /// NMCLCY.
        /// </summary>
        public const string NMCLCY = "NMCLCY";

        /// <summary>
        /// NMURCD.
        /// </summary>
        public const string NMURCD = "NMURCD";

        /// <summary>
        /// NMURDT.
        /// </summary>
        public const string NMURDT = "NMURDT";

        /// <summary>
        /// NMURAT.
        /// </summary>
        public const string NMURAT = "NMURAT";

        /// <summary>
        /// NMURAB.
        /// </summary>
        public const string NMURAB = "NMURAB";

        /// <summary>
        /// NMURRF.
        /// </summary>
        public const string NMURRF = "NMURRF";

        /// <summary>
        /// NMENTJ.
        /// </summary>
        public const string NMENTJ = "NMENTJ";

        /// <summary>
        /// NMTORG.
        /// </summary>
        public const string NMTORG = "NMTORG";

        /// <summary>
        /// NMPID.
        /// </summary>
        public const string NMPID = "NMPID";

        /// <summary>
        /// NMUSER.
        /// </summary>
        public const string NMUSER = "NMUSER";

        /// <summary>
        /// NMUPMJ.
        /// </summary>
        public const string NMUPMJ = "NMUPMJ";

        /// <summary>
        /// NMUPMT.
        /// </summary>
        public const string NMUPMT = "NMUPMT";

        /// <summary>
        /// NMJOBN.
        /// </summary>
        public const string NMJOBN = "NMJOBN";

        /// <summary>
        /// NMADJB.
        /// </summary>
        public const string NMADJB = "NMADJB";

        /// <summary>
        /// NMAJSY.
        /// </summary>
        public const string NMAJSY = "NMAJSY";

        /// <summary>
        /// NMAJSM.
        /// </summary>
        public const string NMAJSM = "NMAJSM";

        /// <summary>
        /// NMADJE.
        /// </summary>
        public const string NMADJE = "NMADJE";

        /// <summary>
        /// NMCRCD.
        /// </summary>
        public const string NMCRCD = "NMCRCD";

        /// <summary>
        /// NMADJTY.
        /// </summary>
        public const string NMADJTY = "NMADJTY";

        /// <summary>
        /// NMMCU.
        /// </summary>
        public const string NMMCU = "NMMCU";

        /// <summary>
        /// NMUNIT.
        /// </summary>
        public const string NMUNIT = "NMUNIT";

        /// <summary>
        /// NMSBL.
        /// </summary>
        public const string NMSBL = "NMSBL";

        /// <summary>
        /// NMSBLT.
        /// </summary>
        public const string NMSBLT = "NMSBLT";

        /// <summary>
        /// NMCLAF.
        /// </summary>
        public const string NMCLAF = "NMCLAF";

        /// <summary>
        /// NMAFPL.
        /// </summary>
        public const string NMAFPL = "NMAFPL";

        /// <summary>
        /// NMADRN.
        /// </summary>
        public const string NMADRN = "NMADRN";

        /// <summary>
        /// NMBRAD.
        /// </summary>
        public const string NMBRAD = "NMBRAD";

        /// <summary>
        /// NMFERT.
        /// </summary>
        public const string NMFERT = "NMFERT";

        /// <summary>
        /// NMFEBS.
        /// </summary>
        public const string NMFEBS = "NMFEBS";

        /// <summary>
        /// NMEFAF.
        /// </summary>
        public const string NMEFAF = "NMEFAF";

        /// <summary>
        /// NMSTGU.
        /// </summary>
        public const string NMSTGU = "NMSTGU";

        /// <summary>
        /// NMGPCT.
        /// </summary>
        public const string NMGPCT = "NMGPCT";

        /// <summary>
        /// NMVPCTGU.
        /// </summary>
        public const string NMVPCTGU = "NMVPCTGU";

        /// <summary>
        /// NMOCTYPE.
        /// </summary>
        public const string NMOCTYPE = "NMOCTYPE";

        /// <summary>
        /// NMELRD.
        /// </summary>
        public const string NMELRD = "NMELRD";

        /// <summary>
        /// NMIOEP.
        /// </summary>
        public const string NMIOEP = "NMIOEP";

        /// <summary>
        /// NMIOEA.
        /// </summary>
        public const string NMIOEA = "NMIOEA";

        /// <summary>
        /// NMRMK.
        /// </summary>
        public const string NMRMK = "NMRMK";

        /// <summary>
        /// NMOBJ.
        /// </summary>
        public const string NMOBJ = "NMOBJ";

        /// <summary>
        /// NMSUB.
        /// </summary>
        public const string NMSUB = "NMSUB";

        /// <summary>
        /// NMBCI.
        /// </summary>
        public const string NMBCI = "NMBCI";
    }

    /// <inheritdoc />
    public override string TableName => "F1533B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NMDOCO", "NMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NMLSVR", "NMLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NMDCTO", "NMDCTO", JdeDataType.String, 4),
        new JdeField("NMEPCL", "NMEPCL", JdeDataType.String, 8, true, true),
        new JdeField("NMAID", "NMAID", JdeDataType.String, 16, true, true),
        new JdeField("NMPCTP", "NMPCTP", JdeDataType.Numeric),
        new JdeField("NMEFTB", "NMEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("NMEFTE", "NMEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("NMADJL", "NMADJL", JdeDataType.String, 2, true, true),
        new JdeField("NMLVLT", "NMLVLT", JdeDataType.String, 2, true, true),
        new JdeField("NMADJY", "NMADJY", JdeDataType.String, 2),
        new JdeField("NMCLCY", "NMCLCY", JdeDataType.String, 2),
        new JdeField("NMURCD", "NMURCD", JdeDataType.String, 4),
        new JdeField("NMURDT", "NMURDT", JdeDataType.Numeric),
        new JdeField("NMURAT", "NMURAT", JdeDataType.Numeric),
        new JdeField("NMURAB", "NMURAB", JdeDataType.Numeric),
        new JdeField("NMURRF", "NMURRF", JdeDataType.String, 30),
        new JdeField("NMENTJ", "NMENTJ", JdeDataType.Numeric),
        new JdeField("NMTORG", "NMTORG", JdeDataType.String, 20),
        new JdeField("NMPID", "NMPID", JdeDataType.String, 20),
        new JdeField("NMUSER", "NMUSER", JdeDataType.String, 20),
        new JdeField("NMUPMJ", "NMUPMJ", JdeDataType.Numeric),
        new JdeField("NMUPMT", "NMUPMT", JdeDataType.Numeric),
        new JdeField("NMJOBN", "NMJOBN", JdeDataType.String, 20),
        new JdeField("NMADJB", "NMADJB", JdeDataType.Numeric),
        new JdeField("NMAJSY", "NMAJSY", JdeDataType.Numeric),
        new JdeField("NMAJSM", "NMAJSM", JdeDataType.Numeric),
        new JdeField("NMADJE", "NMADJE", JdeDataType.Numeric),
        new JdeField("NMCRCD", "NMCRCD", JdeDataType.String, 6),
        new JdeField("NMADJTY", "NMADJTY", JdeDataType.String, 2, true, true),
        new JdeField("NMMCU", "NMMCU", JdeDataType.String, 24, true, true),
        new JdeField("NMUNIT", "NMUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NMSBL", "NMSBL", JdeDataType.String, 16),
        new JdeField("NMSBLT", "NMSBLT", JdeDataType.String, 2),
        new JdeField("NMCLAF", "NMCLAF", JdeDataType.Numeric),
        new JdeField("NMAFPL", "NMAFPL", JdeDataType.String, 2),
        new JdeField("NMADRN", "NMADRN", JdeDataType.String, 60),
        new JdeField("NMBRAD", "NMBRAD", JdeDataType.String, 8),
        new JdeField("NMFERT", "NMFERT", JdeDataType.Numeric),
        new JdeField("NMFEBS", "NMFEBS", JdeDataType.String, 2),
        new JdeField("NMEFAF", "NMEFAF", JdeDataType.String, 2),
        new JdeField("NMSTGU", "NMSTGU", JdeDataType.String, 2),
        new JdeField("NMGPCT", "NMGPCT", JdeDataType.Numeric),
        new JdeField("NMVPCTGU", "NMVPCTGU", JdeDataType.Numeric),
        new JdeField("NMOCTYPE", "NMOCTYPE", JdeDataType.String, 2),
        new JdeField("NMELRD", "NMELRD", JdeDataType.String, 2),
        new JdeField("NMIOEP", "NMIOEP", JdeDataType.Numeric),
        new JdeField("NMIOEA", "NMIOEA", JdeDataType.Numeric),
        new JdeField("NMRMK", "NMRMK", JdeDataType.String, 60),
        new JdeField("NMOBJ", "NMOBJ", JdeDataType.String, 12),
        new JdeField("NMSUB", "NMSUB", JdeDataType.String, 16),
        new JdeField("NMBCI", "NMBCI", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1533B_0", "Primary Key on NMDOCO, NMLSVR, NMADJL, NMADJTY, NMEPCL, NMMCU, NMUNIT, NMAID, NMLVLT, NMBCI, NMEFTB, NMEFTE", new[] { "NMDOCO", "NMLSVR", "NMADJL", "NMADJTY", "NMEPCL", "NMMCU", "NMUNIT", "NMAID", "NMLVLT", "NMBCI", "NMEFTB", "NMEFTE" }, isUnique: true, isPrimaryKey: true)
    };
}
