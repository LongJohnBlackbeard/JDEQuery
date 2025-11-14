using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B30 - .
/// </summary>
public class F76B30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMCO.
        /// </summary>
        public const string MMCO = "MMCO";

        /// <summary>
        /// MMBRINM.
        /// </summary>
        public const string MMBRINM = "MMBRINM";

        /// <summary>
        /// MMBRDCTP.
        /// </summary>
        public const string MMBRDCTP = "MMBRDCTP";

        /// <summary>
        /// MMBRSSR.
        /// </summary>
        public const string MMBRSSR = "MMBRSSR";

        /// <summary>
        /// MMBRNNF.
        /// </summary>
        public const string MMBRNNF = "MMBRNNF";

        /// <summary>
        /// MMDTDO.
        /// </summary>
        public const string MMDTDO = "MMDTDO";

        /// <summary>
        /// MMAT1.
        /// </summary>
        public const string MMAT1 = "MMAT1";

        /// <summary>
        /// MMAN8.
        /// </summary>
        public const string MMAN8 = "MMAN8";

        /// <summary>
        /// MMINC.
        /// </summary>
        public const string MMINC = "MMINC";

        /// <summary>
        /// MMBRDTM.
        /// </summary>
        public const string MMBRDTM = "MMBRDTM";

        /// <summary>
        /// MMADTJ.
        /// </summary>
        public const string MMADTJ = "MMADTJ";

        /// <summary>
        /// MMAEXP.
        /// </summary>
        public const string MMAEXP = "MMAEXP";

        /// <summary>
        /// MMACTAA.
        /// </summary>
        public const string MMACTAA = "MMACTAA";

        /// <summary>
        /// MMDSCT.
        /// </summary>
        public const string MMDSCT = "MMDSCT";

        /// <summary>
        /// MMBRNNFR.
        /// </summary>
        public const string MMBRNNFR = "MMBRNNFR";

        /// <summary>
        /// MMBRSSRF.
        /// </summary>
        public const string MMBRSSRF = "MMBRSSRF";

        /// <summary>
        /// MMBIPR.
        /// </summary>
        public const string MMBIPR = "MMBIPR";

        /// <summary>
        /// MMBIPI.
        /// </summary>
        public const string MMBIPI = "MMBIPI";

        /// <summary>
        /// MMBRIES.
        /// </summary>
        public const string MMBRIES = "MMBRIES";

        /// <summary>
        /// MMBRIPIO.
        /// </summary>
        public const string MMBRIPIO = "MMBRIPIO";

        /// <summary>
        /// MMBRICF.
        /// </summary>
        public const string MMBRICF = "MMBRICF";

        /// <summary>
        /// MMBRNDI.
        /// </summary>
        public const string MMBRNDI = "MMBRNDI";

        /// <summary>
        /// MMCRTY.
        /// </summary>
        public const string MMCRTY = "MMCRTY";

        /// <summary>
        /// MMANCR.
        /// </summary>
        public const string MMANCR = "MMANCR";

        /// <summary>
        /// MMBRQTD.
        /// </summary>
        public const string MMBRQTD = "MMBRQTD";

        /// <summary>
        /// MMBRESV.
        /// </summary>
        public const string MMBRESV = "MMBRESV";

        /// <summary>
        /// MMBRPB.
        /// </summary>
        public const string MMBRPB = "MMBRPB";

        /// <summary>
        /// MMBRPL.
        /// </summary>
        public const string MMBRPL = "MMBRPL";

        /// <summary>
        /// MMFRTT.
        /// </summary>
        public const string MMFRTT = "MMFRTT";

        /// <summary>
        /// MM901.
        /// </summary>
        public const string MM901 = "MM901";

        /// <summary>
        /// MMSCRC.
        /// </summary>
        public const string MMSCRC = "MMSCRC";

        /// <summary>
        /// MMAMOT.
        /// </summary>
        public const string MMAMOT = "MMAMOT";

        /// <summary>
        /// MMBFRT.
        /// </summary>
        public const string MMBFRT = "MMBFRT";

        /// <summary>
        /// MMBRIDV.
        /// </summary>
        public const string MMBRIDV = "MMBRIDV";

        /// <summary>
        /// MMCSLF.
        /// </summary>
        public const string MMCSLF = "MMCSLF";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMEAP.
        /// </summary>
        public const string MMEAP = "MMEAP";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMUPMT.
        /// </summary>
        public const string MMUPMT = "MMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMCO", "MMCO", JdeDataType.String, 10, true, true),
        new JdeField("MMBRINM", "MMBRINM", JdeDataType.String, 2, true, true),
        new JdeField("MMBRDCTP", "MMBRDCTP", JdeDataType.String, 6),
        new JdeField("MMBRSSR", "MMBRSSR", JdeDataType.String, 10, true, true),
        new JdeField("MMBRNNF", "MMBRNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("MMDTDO", "MMDTDO", JdeDataType.Numeric),
        new JdeField("MMAT1", "MMAT1", JdeDataType.String, 6, true, true),
        new JdeField("MMAN8", "MMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MMINC", "MMINC", JdeDataType.String, 2),
        new JdeField("MMBRDTM", "MMBRDTM", JdeDataType.String, 4),
        new JdeField("MMADTJ", "MMADTJ", JdeDataType.Numeric),
        new JdeField("MMAEXP", "MMAEXP", JdeDataType.Numeric),
        new JdeField("MMACTAA", "MMACTAA", JdeDataType.Numeric),
        new JdeField("MMDSCT", "MMDSCT", JdeDataType.Numeric),
        new JdeField("MMBRNNFR", "MMBRNNFR", JdeDataType.Numeric),
        new JdeField("MMBRSSRF", "MMBRSSRF", JdeDataType.String, 10),
        new JdeField("MMBIPR", "MMBIPR", JdeDataType.Numeric),
        new JdeField("MMBIPI", "MMBIPI", JdeDataType.Numeric),
        new JdeField("MMBRIES", "MMBRIES", JdeDataType.String, 28),
        new JdeField("MMBRIPIO", "MMBRIPIO", JdeDataType.String, 90),
        new JdeField("MMBRICF", "MMBRICF", JdeDataType.String, 2),
        new JdeField("MMBRNDI", "MMBRNDI", JdeDataType.String, 24),
        new JdeField("MMCRTY", "MMCRTY", JdeDataType.String, 6),
        new JdeField("MMANCR", "MMANCR", JdeDataType.Numeric),
        new JdeField("MMBRQTD", "MMBRQTD", JdeDataType.Numeric),
        new JdeField("MMBRESV", "MMBRESV", JdeDataType.String, 30),
        new JdeField("MMBRPB", "MMBRPB", JdeDataType.Numeric),
        new JdeField("MMBRPL", "MMBRPL", JdeDataType.Numeric),
        new JdeField("MMFRTT", "MMFRTT", JdeDataType.String, 6),
        new JdeField("MM901", "MM901", JdeDataType.String, 6),
        new JdeField("MMSCRC", "MMSCRC", JdeDataType.Numeric),
        new JdeField("MMAMOT", "MMAMOT", JdeDataType.Numeric),
        new JdeField("MMBFRT", "MMBFRT", JdeDataType.Numeric),
        new JdeField("MMBRIDV", "MMBRIDV", JdeDataType.String, 16),
        new JdeField("MMCSLF", "MMCSLF", JdeDataType.String, 2),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMEAP", "MMEAP", JdeDataType.String, 20),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMUPMT", "MMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B30_0", "Primary Key on MMCO, MMBRINM, MMBRSSR, MMBRNNF, MMAT1, MMAN8", new[] { "MMCO", "MMBRINM", "MMBRSSR", "MMBRNNF", "MMAT1", "MMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
