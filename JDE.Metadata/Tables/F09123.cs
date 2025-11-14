using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09123 - .
/// </summary>
public class F09123 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VNUKID.
        /// </summary>
        public const string VNUKID = "VNUKID";

        /// <summary>
        /// VNDOC.
        /// </summary>
        public const string VNDOC = "VNDOC";

        /// <summary>
        /// VNDCT.
        /// </summary>
        public const string VNDCT = "VNDCT";

        /// <summary>
        /// VNCO.
        /// </summary>
        public const string VNCO = "VNCO";

        /// <summary>
        /// VNDGJ.
        /// </summary>
        public const string VNDGJ = "VNDGJ";

        /// <summary>
        /// VNEXA.
        /// </summary>
        public const string VNEXA = "VNEXA";

        /// <summary>
        /// VNSDTE.
        /// </summary>
        public const string VNSDTE = "VNSDTE";

        /// <summary>
        /// VNRF.
        /// </summary>
        public const string VNRF = "VNRF";

        /// <summary>
        /// VNPOSG.
        /// </summary>
        public const string VNPOSG = "VNPOSG";

        /// <summary>
        /// VNSEN.
        /// </summary>
        public const string VNSEN = "VNSEN";

        /// <summary>
        /// VNHST.
        /// </summary>
        public const string VNHST = "VNHST";

        /// <summary>
        /// VNREVR.
        /// </summary>
        public const string VNREVR = "VNREVR";

        /// <summary>
        /// VNGCFL.
        /// </summary>
        public const string VNGCFL = "VNGCFL";

        /// <summary>
        /// VNSRCV.
        /// </summary>
        public const string VNSRCV = "VNSRCV";

        /// <summary>
        /// VNRFAC.
        /// </summary>
        public const string VNRFAC = "VNRFAC";

        /// <summary>
        /// VNFLT.
        /// </summary>
        public const string VNFLT = "VNFLT";

        /// <summary>
        /// VNSULF.
        /// </summary>
        public const string VNSULF = "VNSULF";

        /// <summary>
        /// VNUM.
        /// </summary>
        public const string VNUM = "VNUM";

        /// <summary>
        /// VNFMYIU.
        /// </summary>
        public const string VNFMYIU = "VNFMYIU";

        /// <summary>
        /// VNFPN.
        /// </summary>
        public const string VNFPN = "VNFPN";

        /// <summary>
        /// VNFFY.
        /// </summary>
        public const string VNFFY = "VNFFY";

        /// <summary>
        /// VNFCTY.
        /// </summary>
        public const string VNFCTY = "VNFCTY";

        /// <summary>
        /// VNGCAT.
        /// </summary>
        public const string VNGCAT = "VNGCAT";

        /// <summary>
        /// VNSPGS.
        /// </summary>
        public const string VNSPGS = "VNSPGS";

        /// <summary>
        /// VNSPIDV.
        /// </summary>
        public const string VNSPIDV = "VNSPIDV";

        /// <summary>
        /// VNBASV.
        /// </summary>
        public const string VNBASV = "VNBASV";

        /// <summary>
        /// VNBASR.
        /// </summary>
        public const string VNBASR = "VNBASR";

        /// <summary>
        /// VNBLT.
        /// </summary>
        public const string VNBLT = "VNBLT";

        /// <summary>
        /// VNBMYIU.
        /// </summary>
        public const string VNBMYIU = "VNBMYIU";

        /// <summary>
        /// VNBPNO.
        /// </summary>
        public const string VNBPNO = "VNBPNO";

        /// <summary>
        /// VNBFY.
        /// </summary>
        public const string VNBFY = "VNBFY";

        /// <summary>
        /// VNBCTR.
        /// </summary>
        public const string VNBCTR = "VNBCTR";

        /// <summary>
        /// VNBGAT.
        /// </summary>
        public const string VNBGAT = "VNBGAT";

        /// <summary>
        /// VNBPGS.
        /// </summary>
        public const string VNBPGS = "VNBPGS";

        /// <summary>
        /// VNBPIDV.
        /// </summary>
        public const string VNBPIDV = "VNBPIDV";

        /// <summary>
        /// VNALTA.
        /// </summary>
        public const string VNALTA = "VNALTA";

        /// <summary>
        /// VNDBUF.
        /// </summary>
        public const string VNDBUF = "VNDBUF";

        /// <summary>
        /// VNDEBU.
        /// </summary>
        public const string VNDEBU = "VNDEBU";

        /// <summary>
        /// VNOVERRDE.
        /// </summary>
        public const string VNOVERRDE = "VNOVERRDE";

        /// <summary>
        /// VNDOAF.
        /// </summary>
        public const string VNDOAF = "VNDOAF";

        /// <summary>
        /// VNAOBA.
        /// </summary>
        public const string VNAOBA = "VNAOBA";

        /// <summary>
        /// VNDSUF.
        /// </summary>
        public const string VNDSUF = "VNDSUF";

        /// <summary>
        /// VNASBA.
        /// </summary>
        public const string VNASBA = "VNASBA";

        /// <summary>
        /// VNDSLF.
        /// </summary>
        public const string VNDSLF = "VNDSLF";

        /// <summary>
        /// VNASBL.
        /// </summary>
        public const string VNASBL = "VNASBL";

        /// <summary>
        /// VNASBT.
        /// </summary>
        public const string VNASBT = "VNASBT";

        /// <summary>
        /// VNOFBF.
        /// </summary>
        public const string VNOFBF = "VNOFBF";

        /// <summary>
        /// VNOFBU.
        /// </summary>
        public const string VNOFBU = "VNOFBU";

        /// <summary>
        /// VNOOBF.
        /// </summary>
        public const string VNOOBF = "VNOOBF";

        /// <summary>
        /// VNOOBJ.
        /// </summary>
        public const string VNOOBJ = "VNOOBJ";

        /// <summary>
        /// VNOSUF.
        /// </summary>
        public const string VNOSUF = "VNOSUF";

        /// <summary>
        /// VNOSUB.
        /// </summary>
        public const string VNOSUB = "VNOSUB";

        /// <summary>
        /// VNOSBF.
        /// </summary>
        public const string VNOSBF = "VNOSBF";

        /// <summary>
        /// VNOSBL.
        /// </summary>
        public const string VNOSBL = "VNOSBL";

        /// <summary>
        /// VNOSBT.
        /// </summary>
        public const string VNOSBT = "VNOSBT";

        /// <summary>
        /// VNAN8.
        /// </summary>
        public const string VNAN8 = "VNAN8";

        /// <summary>
        /// VNAHBU.
        /// </summary>
        public const string VNAHBU = "VNAHBU";

        /// <summary>
        /// VNJBCD.
        /// </summary>
        public const string VNJBCD = "VNJBCD";

        /// <summary>
        /// VNJBST.
        /// </summary>
        public const string VNJBST = "VNJBST";

        /// <summary>
        /// VNJPGCF.
        /// </summary>
        public const string VNJPGCF = "VNJPGCF";

        /// <summary>
        /// VNPID.
        /// </summary>
        public const string VNPID = "VNPID";

        /// <summary>
        /// VNUSER.
        /// </summary>
        public const string VNUSER = "VNUSER";

        /// <summary>
        /// VNJOBN.
        /// </summary>
        public const string VNJOBN = "VNJOBN";

        /// <summary>
        /// VNUPMJ.
        /// </summary>
        public const string VNUPMJ = "VNUPMJ";

        /// <summary>
        /// VNUPMT.
        /// </summary>
        public const string VNUPMT = "VNUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09123";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VNUKID", "VNUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("VNDOC", "VNDOC", JdeDataType.Numeric),
        new JdeField("VNDCT", "VNDCT", JdeDataType.String, 4),
        new JdeField("VNCO", "VNCO", JdeDataType.String, 10),
        new JdeField("VNDGJ", "VNDGJ", JdeDataType.Numeric),
        new JdeField("VNEXA", "VNEXA", JdeDataType.String, 60),
        new JdeField("VNSDTE", "VNSDTE", JdeDataType.Numeric),
        new JdeField("VNRF", "VNRF", JdeDataType.String, 4),
        new JdeField("VNPOSG", "VNPOSG", JdeDataType.Numeric),
        new JdeField("VNSEN", "VNSEN", JdeDataType.Numeric),
        new JdeField("VNHST", "VNHST", JdeDataType.String, 2),
        new JdeField("VNREVR", "VNREVR", JdeDataType.String, 2),
        new JdeField("VNGCFL", "VNGCFL", JdeDataType.String, 2),
        new JdeField("VNSRCV", "VNSRCV", JdeDataType.String, 20),
        new JdeField("VNRFAC", "VNRFAC", JdeDataType.Numeric),
        new JdeField("VNFLT", "VNFLT", JdeDataType.String, 4),
        new JdeField("VNSULF", "VNSULF", JdeDataType.String, 2),
        new JdeField("VNUM", "VNUM", JdeDataType.String, 4),
        new JdeField("VNFMYIU", "VNFMYIU", JdeDataType.String, 2),
        new JdeField("VNFPN", "VNFPN", JdeDataType.Numeric),
        new JdeField("VNFFY", "VNFFY", JdeDataType.Numeric),
        new JdeField("VNFCTY", "VNFCTY", JdeDataType.Numeric),
        new JdeField("VNGCAT", "VNGCAT", JdeDataType.String, 2),
        new JdeField("VNSPGS", "VNSPGS", JdeDataType.String, 2),
        new JdeField("VNSPIDV", "VNSPIDV", JdeDataType.String, 20),
        new JdeField("VNBASV", "VNBASV", JdeDataType.String, 20),
        new JdeField("VNBASR", "VNBASR", JdeDataType.String, 4),
        new JdeField("VNBLT", "VNBLT", JdeDataType.String, 4),
        new JdeField("VNBMYIU", "VNBMYIU", JdeDataType.String, 2),
        new JdeField("VNBPNO", "VNBPNO", JdeDataType.Numeric),
        new JdeField("VNBFY", "VNBFY", JdeDataType.Numeric),
        new JdeField("VNBCTR", "VNBCTR", JdeDataType.Numeric),
        new JdeField("VNBGAT", "VNBGAT", JdeDataType.String, 2),
        new JdeField("VNBPGS", "VNBPGS", JdeDataType.String, 2),
        new JdeField("VNBPIDV", "VNBPIDV", JdeDataType.String, 20),
        new JdeField("VNALTA", "VNALTA", JdeDataType.String, 4),
        new JdeField("VNDBUF", "VNDBUF", JdeDataType.String, 2),
        new JdeField("VNDEBU", "VNDEBU", JdeDataType.String, 24),
        new JdeField("VNOVERRDE", "VNOVERRDE", JdeDataType.String, 10),
        new JdeField("VNDOAF", "VNDOAF", JdeDataType.String, 2),
        new JdeField("VNAOBA", "VNAOBA", JdeDataType.String, 12),
        new JdeField("VNDSUF", "VNDSUF", JdeDataType.String, 2),
        new JdeField("VNASBA", "VNASBA", JdeDataType.String, 16),
        new JdeField("VNDSLF", "VNDSLF", JdeDataType.String, 2),
        new JdeField("VNASBL", "VNASBL", JdeDataType.String, 16),
        new JdeField("VNASBT", "VNASBT", JdeDataType.String, 2),
        new JdeField("VNOFBF", "VNOFBF", JdeDataType.String, 2),
        new JdeField("VNOFBU", "VNOFBU", JdeDataType.String, 24),
        new JdeField("VNOOBF", "VNOOBF", JdeDataType.String, 2),
        new JdeField("VNOOBJ", "VNOOBJ", JdeDataType.String, 12),
        new JdeField("VNOSUF", "VNOSUF", JdeDataType.String, 2),
        new JdeField("VNOSUB", "VNOSUB", JdeDataType.String, 16),
        new JdeField("VNOSBF", "VNOSBF", JdeDataType.String, 2),
        new JdeField("VNOSBL", "VNOSBL", JdeDataType.String, 16),
        new JdeField("VNOSBT", "VNOSBT", JdeDataType.String, 2),
        new JdeField("VNAN8", "VNAN8", JdeDataType.Numeric),
        new JdeField("VNAHBU", "VNAHBU", JdeDataType.String, 24),
        new JdeField("VNJBCD", "VNJBCD", JdeDataType.String, 12),
        new JdeField("VNJBST", "VNJBST", JdeDataType.String, 8),
        new JdeField("VNJPGCF", "VNJPGCF", JdeDataType.String, 2),
        new JdeField("VNPID", "VNPID", JdeDataType.String, 20),
        new JdeField("VNUSER", "VNUSER", JdeDataType.String, 20),
        new JdeField("VNJOBN", "VNJOBN", JdeDataType.String, 20),
        new JdeField("VNUPMJ", "VNUPMJ", JdeDataType.Numeric),
        new JdeField("VNUPMT", "VNUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09123_0", "Primary Key on VNUKID", new[] { "VNUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09123_2", "Unique Index on VNDOC, VNDCT, VNCO", new[] { "VNDOC", "VNDCT", "VNCO" }, isUnique: true),
        new JdeIndex("F09123_3", "Index on VNPOSG, VNSEN", new[] { "VNPOSG", "VNSEN" })
    };
}
