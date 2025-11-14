using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41021 - .
/// </summary>
public class F41021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LIITM.
        /// </summary>
        public const string LIITM = "LIITM";

        /// <summary>
        /// LIMCU.
        /// </summary>
        public const string LIMCU = "LIMCU";

        /// <summary>
        /// LILOCN.
        /// </summary>
        public const string LILOCN = "LILOCN";

        /// <summary>
        /// LILOTN.
        /// </summary>
        public const string LILOTN = "LILOTN";

        /// <summary>
        /// LIPBIN.
        /// </summary>
        public const string LIPBIN = "LIPBIN";

        /// <summary>
        /// LIGLPT.
        /// </summary>
        public const string LIGLPT = "LIGLPT";

        /// <summary>
        /// LILOTS.
        /// </summary>
        public const string LILOTS = "LILOTS";

        /// <summary>
        /// LILRCJ.
        /// </summary>
        public const string LILRCJ = "LILRCJ";

        /// <summary>
        /// LIPQOH.
        /// </summary>
        public const string LIPQOH = "LIPQOH";

        /// <summary>
        /// LIPBCK.
        /// </summary>
        public const string LIPBCK = "LIPBCK";

        /// <summary>
        /// LIPREQ.
        /// </summary>
        public const string LIPREQ = "LIPREQ";

        /// <summary>
        /// LIQWBO.
        /// </summary>
        public const string LIQWBO = "LIQWBO";

        /// <summary>
        /// LIOT1P.
        /// </summary>
        public const string LIOT1P = "LIOT1P";

        /// <summary>
        /// LIOT2P.
        /// </summary>
        public const string LIOT2P = "LIOT2P";

        /// <summary>
        /// LIOT1A.
        /// </summary>
        public const string LIOT1A = "LIOT1A";

        /// <summary>
        /// LIHCOM.
        /// </summary>
        public const string LIHCOM = "LIHCOM";

        /// <summary>
        /// LIPCOM.
        /// </summary>
        public const string LIPCOM = "LIPCOM";

        /// <summary>
        /// LIFCOM.
        /// </summary>
        public const string LIFCOM = "LIFCOM";

        /// <summary>
        /// LIFUN1.
        /// </summary>
        public const string LIFUN1 = "LIFUN1";

        /// <summary>
        /// LIQOWO.
        /// </summary>
        public const string LIQOWO = "LIQOWO";

        /// <summary>
        /// LIQTTR.
        /// </summary>
        public const string LIQTTR = "LIQTTR";

        /// <summary>
        /// LIQTIN.
        /// </summary>
        public const string LIQTIN = "LIQTIN";

        /// <summary>
        /// LIQONL.
        /// </summary>
        public const string LIQONL = "LIQONL";

        /// <summary>
        /// LIQTRI.
        /// </summary>
        public const string LIQTRI = "LIQTRI";

        /// <summary>
        /// LIQTRO.
        /// </summary>
        public const string LIQTRO = "LIQTRO";

        /// <summary>
        /// LINCDJ.
        /// </summary>
        public const string LINCDJ = "LINCDJ";

        /// <summary>
        /// LIQTY1.
        /// </summary>
        public const string LIQTY1 = "LIQTY1";

        /// <summary>
        /// LIQTY2.
        /// </summary>
        public const string LIQTY2 = "LIQTY2";

        /// <summary>
        /// LIURAB.
        /// </summary>
        public const string LIURAB = "LIURAB";

        /// <summary>
        /// LIURRF.
        /// </summary>
        public const string LIURRF = "LIURRF";

        /// <summary>
        /// LIURAT.
        /// </summary>
        public const string LIURAT = "LIURAT";

        /// <summary>
        /// LIURCD.
        /// </summary>
        public const string LIURCD = "LIURCD";

        /// <summary>
        /// LIJOBN.
        /// </summary>
        public const string LIJOBN = "LIJOBN";

        /// <summary>
        /// LIPID.
        /// </summary>
        public const string LIPID = "LIPID";

        /// <summary>
        /// LIUPMJ.
        /// </summary>
        public const string LIUPMJ = "LIUPMJ";

        /// <summary>
        /// LIUSER.
        /// </summary>
        public const string LIUSER = "LIUSER";

        /// <summary>
        /// LITDAY.
        /// </summary>
        public const string LITDAY = "LITDAY";

        /// <summary>
        /// LIURDT.
        /// </summary>
        public const string LIURDT = "LIURDT";

        /// <summary>
        /// LIQTO1.
        /// </summary>
        public const string LIQTO1 = "LIQTO1";

        /// <summary>
        /// LIQTO2.
        /// </summary>
        public const string LIQTO2 = "LIQTO2";

        /// <summary>
        /// LIHCMS.
        /// </summary>
        public const string LIHCMS = "LIHCMS";

        /// <summary>
        /// LIPJCM.
        /// </summary>
        public const string LIPJCM = "LIPJCM";

        /// <summary>
        /// LIPJDM.
        /// </summary>
        public const string LIPJDM = "LIPJDM";

        /// <summary>
        /// LISCMS.
        /// </summary>
        public const string LISCMS = "LISCMS";

        /// <summary>
        /// LISIBW.
        /// </summary>
        public const string LISIBW = "LISIBW";

        /// <summary>
        /// LISOBW.
        /// </summary>
        public const string LISOBW = "LISOBW";

        /// <summary>
        /// LISQOH.
        /// </summary>
        public const string LISQOH = "LISQOH";

        /// <summary>
        /// LISQWO.
        /// </summary>
        public const string LISQWO = "LISQWO";

        /// <summary>
        /// LISREQ.
        /// </summary>
        public const string LISREQ = "LISREQ";

        /// <summary>
        /// LISWHC.
        /// </summary>
        public const string LISWHC = "LISWHC";

        /// <summary>
        /// LISWSC.
        /// </summary>
        public const string LISWSC = "LISWSC";

        /// <summary>
        /// LICHDF.
        /// </summary>
        public const string LICHDF = "LICHDF";

        /// <summary>
        /// LIWPDF.
        /// </summary>
        public const string LIWPDF = "LIWPDF";

        /// <summary>
        /// LICFGSID.
        /// </summary>
        public const string LICFGSID = "LICFGSID";
    }

    /// <inheritdoc />
    public override string TableName => "F41021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LIITM", "LIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LIMCU", "LIMCU", JdeDataType.String, 24, true, true),
        new JdeField("LILOCN", "LILOCN", JdeDataType.String, 40, true, true),
        new JdeField("LILOTN", "LILOTN", JdeDataType.String, 60, true, true),
        new JdeField("LIPBIN", "LIPBIN", JdeDataType.String, 2),
        new JdeField("LIGLPT", "LIGLPT", JdeDataType.String, 8),
        new JdeField("LILOTS", "LILOTS", JdeDataType.String, 2),
        new JdeField("LILRCJ", "LILRCJ", JdeDataType.Numeric),
        new JdeField("LIPQOH", "LIPQOH", JdeDataType.Numeric),
        new JdeField("LIPBCK", "LIPBCK", JdeDataType.Numeric),
        new JdeField("LIPREQ", "LIPREQ", JdeDataType.Numeric),
        new JdeField("LIQWBO", "LIQWBO", JdeDataType.Numeric),
        new JdeField("LIOT1P", "LIOT1P", JdeDataType.Numeric),
        new JdeField("LIOT2P", "LIOT2P", JdeDataType.Numeric),
        new JdeField("LIOT1A", "LIOT1A", JdeDataType.Numeric),
        new JdeField("LIHCOM", "LIHCOM", JdeDataType.Numeric),
        new JdeField("LIPCOM", "LIPCOM", JdeDataType.Numeric),
        new JdeField("LIFCOM", "LIFCOM", JdeDataType.Numeric),
        new JdeField("LIFUN1", "LIFUN1", JdeDataType.Numeric),
        new JdeField("LIQOWO", "LIQOWO", JdeDataType.Numeric),
        new JdeField("LIQTTR", "LIQTTR", JdeDataType.Numeric),
        new JdeField("LIQTIN", "LIQTIN", JdeDataType.Numeric),
        new JdeField("LIQONL", "LIQONL", JdeDataType.Numeric),
        new JdeField("LIQTRI", "LIQTRI", JdeDataType.Numeric),
        new JdeField("LIQTRO", "LIQTRO", JdeDataType.Numeric),
        new JdeField("LINCDJ", "LINCDJ", JdeDataType.Numeric),
        new JdeField("LIQTY1", "LIQTY1", JdeDataType.Numeric),
        new JdeField("LIQTY2", "LIQTY2", JdeDataType.Numeric),
        new JdeField("LIURAB", "LIURAB", JdeDataType.Numeric),
        new JdeField("LIURRF", "LIURRF", JdeDataType.String, 30),
        new JdeField("LIURAT", "LIURAT", JdeDataType.Numeric),
        new JdeField("LIURCD", "LIURCD", JdeDataType.String, 4),
        new JdeField("LIJOBN", "LIJOBN", JdeDataType.String, 20),
        new JdeField("LIPID", "LIPID", JdeDataType.String, 20),
        new JdeField("LIUPMJ", "LIUPMJ", JdeDataType.Numeric),
        new JdeField("LIUSER", "LIUSER", JdeDataType.String, 20),
        new JdeField("LITDAY", "LITDAY", JdeDataType.Numeric),
        new JdeField("LIURDT", "LIURDT", JdeDataType.Numeric),
        new JdeField("LIQTO1", "LIQTO1", JdeDataType.Numeric),
        new JdeField("LIQTO2", "LIQTO2", JdeDataType.Numeric),
        new JdeField("LIHCMS", "LIHCMS", JdeDataType.Numeric),
        new JdeField("LIPJCM", "LIPJCM", JdeDataType.Numeric),
        new JdeField("LIPJDM", "LIPJDM", JdeDataType.Numeric),
        new JdeField("LISCMS", "LISCMS", JdeDataType.Numeric),
        new JdeField("LISIBW", "LISIBW", JdeDataType.Numeric),
        new JdeField("LISOBW", "LISOBW", JdeDataType.Numeric),
        new JdeField("LISQOH", "LISQOH", JdeDataType.Numeric),
        new JdeField("LISQWO", "LISQWO", JdeDataType.Numeric),
        new JdeField("LISREQ", "LISREQ", JdeDataType.Numeric),
        new JdeField("LISWHC", "LISWHC", JdeDataType.Numeric),
        new JdeField("LISWSC", "LISWSC", JdeDataType.Numeric),
        new JdeField("LICHDF", "LICHDF", JdeDataType.String, 2),
        new JdeField("LIWPDF", "LIWPDF", JdeDataType.String, 2),
        new JdeField("LICFGSID", "LICFGSID", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41021_0", "Primary Key on LIITM, LIMCU, LILOCN, LILOTN", new[] { "LIITM", "LIMCU", "LILOCN", "LILOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41021_2", "Index on LIITM, LIMCU, LILOTN, LILOCN", new[] { "LIITM", "LIMCU", "LILOTN", "LILOCN" }),
        new JdeIndex("F41021_3", "Index on LIMCU, LILOCN, LIITM, LILOTN", new[] { "LIMCU", "LILOCN", "LIITM", "LILOTN" }),
        new JdeIndex("F41021_4", "Index on LIITM, LIMCU, LIPBIN, LIPQOH, LILOTN, LILOCN", new[] { "LIITM", "LIMCU", "LIPBIN", "LIPQOH", "LILOTN", "LILOCN" }),
        new JdeIndex("F41021_5", "Index on LILOTN, LIITM, LIMCU", new[] { "LILOTN", "LIITM", "LIMCU" }),
        new JdeIndex("F41021_6", "Index on LIITM, LIMCU, LILOTN, LILOCN, LIPBIN", new[] { "LIITM", "LIMCU", "LILOTN", "LILOCN", "LIPBIN" }),
        new JdeIndex("F41021_7", "Index on LIITM, LIMCU, LIPBIN", new[] { "LIITM", "LIMCU", "LIPBIN" })
    };
}
