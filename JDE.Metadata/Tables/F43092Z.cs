using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43092Z - .
/// </summary>
public class F43092Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PVCTID.
        /// </summary>
        public const string PVCTID = "PVCTID";

        /// <summary>
        /// PVJOBS.
        /// </summary>
        public const string PVJOBS = "PVJOBS";

        /// <summary>
        /// PVUSER.
        /// </summary>
        public const string PVUSER = "PVUSER";

        /// <summary>
        /// PVPID.
        /// </summary>
        public const string PVPID = "PVPID";

        /// <summary>
        /// PVDISF.
        /// </summary>
        public const string PVDISF = "PVDISF";

        /// <summary>
        /// PVDOCO.
        /// </summary>
        public const string PVDOCO = "PVDOCO";

        /// <summary>
        /// PVDCTO.
        /// </summary>
        public const string PVDCTO = "PVDCTO";

        /// <summary>
        /// PVKCOO.
        /// </summary>
        public const string PVKCOO = "PVKCOO";

        /// <summary>
        /// PVSFXO.
        /// </summary>
        public const string PVSFXO = "PVSFXO";

        /// <summary>
        /// PVLNID.
        /// </summary>
        public const string PVLNID = "PVLNID";

        /// <summary>
        /// PVNLIN.
        /// </summary>
        public const string PVNLIN = "PVNLIN";

        /// <summary>
        /// PVUOM.
        /// </summary>
        public const string PVUOM = "PVUOM";

        /// <summary>
        /// PVOPRS.
        /// </summary>
        public const string PVOPRS = "PVOPRS";

        /// <summary>
        /// PVOSTO.
        /// </summary>
        public const string PVOSTO = "PVOSTO";

        /// <summary>
        /// PVRVS.
        /// </summary>
        public const string PVRVS = "PVRVS";

        /// <summary>
        /// PVICU.
        /// </summary>
        public const string PVICU = "PVICU";

        /// <summary>
        /// PVICUT.
        /// </summary>
        public const string PVICUT = "PVICUT";

        /// <summary>
        /// PVBST.
        /// </summary>
        public const string PVBST = "PVBST";

        /// <summary>
        /// PVDICJ.
        /// </summary>
        public const string PVDICJ = "PVDICJ";

        /// <summary>
        /// PVDGL.
        /// </summary>
        public const string PVDGL = "PVDGL";

        /// <summary>
        /// PVRCDJ.
        /// </summary>
        public const string PVRCDJ = "PVRCDJ";

        /// <summary>
        /// PVCRRM.
        /// </summary>
        public const string PVCRRM = "PVCRRM";

        /// <summary>
        /// PVCNV1.
        /// </summary>
        public const string PVCNV1 = "PVCNV1";

        /// <summary>
        /// PVCNV2.
        /// </summary>
        public const string PVCNV2 = "PVCNV2";

        /// <summary>
        /// PVQTYM.
        /// </summary>
        public const string PVQTYM = "PVQTYM";

        /// <summary>
        /// PVQTYO.
        /// </summary>
        public const string PVQTYO = "PVQTYO";

        /// <summary>
        /// PVQTYA.
        /// </summary>
        public const string PVQTYA = "PVQTYA";

        /// <summary>
        /// PVQTYJ.
        /// </summary>
        public const string PVQTYJ = "PVQTYJ";

        /// <summary>
        /// PVQTYR.
        /// </summary>
        public const string PVQTYR = "PVQTYR";

        /// <summary>
        /// PVQTYW.
        /// </summary>
        public const string PVQTYW = "PVQTYW";

        /// <summary>
        /// PVQTYC.
        /// </summary>
        public const string PVQTYC = "PVQTYC";

        /// <summary>
        /// PVRCD.
        /// </summary>
        public const string PVRCD = "PVRCD";

        /// <summary>
        /// PVRCDOW1.
        /// </summary>
        public const string PVRCDOW1 = "PVRCDOW1";

        /// <summary>
        /// PVRCDOW2.
        /// </summary>
        public const string PVRCDOW2 = "PVRCDOW2";

        /// <summary>
        /// PVRCDOW3.
        /// </summary>
        public const string PVRCDOW3 = "PVRCDOW3";

        /// <summary>
        /// PVRCDOW4.
        /// </summary>
        public const string PVRCDOW4 = "PVRCDOW4";

        /// <summary>
        /// PVRPL.
        /// </summary>
        public const string PVRPL = "PVRPL";

        /// <summary>
        /// PVRPLOW1.
        /// </summary>
        public const string PVRPLOW1 = "PVRPLOW1";

        /// <summary>
        /// PVRPLOW2.
        /// </summary>
        public const string PVRPLOW2 = "PVRPLOW2";

        /// <summary>
        /// PVRPLOW3.
        /// </summary>
        public const string PVRPLOW3 = "PVRPLOW3";

        /// <summary>
        /// PVRPLOW4.
        /// </summary>
        public const string PVRPLOW4 = "PVRPLOW4";

        /// <summary>
        /// PVITM.
        /// </summary>
        public const string PVITM = "PVITM";

        /// <summary>
        /// PVOPRC.
        /// </summary>
        public const string PVOPRC = "PVOPRC";

        /// <summary>
        /// PVOPRT.
        /// </summary>
        public const string PVOPRT = "PVOPRT";

        /// <summary>
        /// PVDOC.
        /// </summary>
        public const string PVDOC = "PVDOC";

        /// <summary>
        /// PVUPMJ.
        /// </summary>
        public const string PVUPMJ = "PVUPMJ";

        /// <summary>
        /// PVPOLN.
        /// </summary>
        public const string PVPOLN = "PVPOLN";

        /// <summary>
        /// PVTDAY.
        /// </summary>
        public const string PVTDAY = "PVTDAY";

        /// <summary>
        /// PVOWGLEL.
        /// </summary>
        public const string PVOWGLEL = "PVOWGLEL";

        /// <summary>
        /// PVPEID.
        /// </summary>
        public const string PVPEID = "PVPEID";

        /// <summary>
        /// PVTCID.
        /// </summary>
        public const string PVTCID = "PVTCID";

        /// <summary>
        /// PVPRRC.
        /// </summary>
        public const string PVPRRC = "PVPRRC";

        /// <summary>
        /// PVQTY.
        /// </summary>
        public const string PVQTY = "PVQTY";

        /// <summary>
        /// PVJEL5.
        /// </summary>
        public const string PVJEL5 = "PVJEL5";

        /// <summary>
        /// PVJEL0.
        /// </summary>
        public const string PVJEL0 = "PVJEL0";

        /// <summary>
        /// PVJELNNMBR.
        /// </summary>
        public const string PVJELNNMBR = "PVJELNNMBR";

        /// <summary>
        /// PVJELE.
        /// </summary>
        public const string PVJELE = "PVJELE";

        /// <summary>
        /// PVVANI.
        /// </summary>
        public const string PVVANI = "PVVANI";
    }

    /// <inheritdoc />
    public override string TableName => "F43092Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PVCTID", "PVCTID", JdeDataType.String, 30, true, true),
        new JdeField("PVJOBS", "PVJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PVUSER", "PVUSER", JdeDataType.String, 20),
        new JdeField("PVPID", "PVPID", JdeDataType.String, 20),
        new JdeField("PVDISF", "PVDISF", JdeDataType.String, 2),
        new JdeField("PVDOCO", "PVDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PVDCTO", "PVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PVKCOO", "PVKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PVSFXO", "PVSFXO", JdeDataType.String, 6),
        new JdeField("PVLNID", "PVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PVNLIN", "PVNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PVUOM", "PVUOM", JdeDataType.String, 4, true, true),
        new JdeField("PVOPRS", "PVOPRS", JdeDataType.Numeric, null, true, true),
        new JdeField("PVOSTO", "PVOSTO", JdeDataType.Numeric, null, true, true),
        new JdeField("PVRVS", "PVRVS", JdeDataType.String, 2),
        new JdeField("PVICU", "PVICU", JdeDataType.Numeric),
        new JdeField("PVICUT", "PVICUT", JdeDataType.String, 4),
        new JdeField("PVBST", "PVBST", JdeDataType.String, 2),
        new JdeField("PVDICJ", "PVDICJ", JdeDataType.Numeric),
        new JdeField("PVDGL", "PVDGL", JdeDataType.Numeric),
        new JdeField("PVRCDJ", "PVRCDJ", JdeDataType.Numeric),
        new JdeField("PVCRRM", "PVCRRM", JdeDataType.String, 2),
        new JdeField("PVCNV1", "PVCNV1", JdeDataType.Numeric),
        new JdeField("PVCNV2", "PVCNV2", JdeDataType.Numeric),
        new JdeField("PVQTYM", "PVQTYM", JdeDataType.Numeric),
        new JdeField("PVQTYO", "PVQTYO", JdeDataType.Numeric),
        new JdeField("PVQTYA", "PVQTYA", JdeDataType.Numeric),
        new JdeField("PVQTYJ", "PVQTYJ", JdeDataType.Numeric),
        new JdeField("PVQTYR", "PVQTYR", JdeDataType.Numeric),
        new JdeField("PVQTYW", "PVQTYW", JdeDataType.Numeric),
        new JdeField("PVQTYC", "PVQTYC", JdeDataType.Numeric),
        new JdeField("PVRCD", "PVRCD", JdeDataType.String, 6),
        new JdeField("PVRCDOW1", "PVRCDOW1", JdeDataType.String, 6),
        new JdeField("PVRCDOW2", "PVRCDOW2", JdeDataType.String, 6),
        new JdeField("PVRCDOW3", "PVRCDOW3", JdeDataType.String, 6),
        new JdeField("PVRCDOW4", "PVRCDOW4", JdeDataType.String, 6),
        new JdeField("PVRPL", "PVRPL", JdeDataType.String, 2),
        new JdeField("PVRPLOW1", "PVRPLOW1", JdeDataType.String, 2),
        new JdeField("PVRPLOW2", "PVRPLOW2", JdeDataType.String, 2),
        new JdeField("PVRPLOW3", "PVRPLOW3", JdeDataType.String, 2),
        new JdeField("PVRPLOW4", "PVRPLOW4", JdeDataType.String, 2),
        new JdeField("PVITM", "PVITM", JdeDataType.Numeric),
        new JdeField("PVOPRC", "PVOPRC", JdeDataType.String, 8),
        new JdeField("PVOPRT", "PVOPRT", JdeDataType.String, 8),
        new JdeField("PVDOC", "PVDOC", JdeDataType.Numeric),
        new JdeField("PVUPMJ", "PVUPMJ", JdeDataType.Numeric),
        new JdeField("PVPOLN", "PVPOLN", JdeDataType.Numeric),
        new JdeField("PVTDAY", "PVTDAY", JdeDataType.Numeric),
        new JdeField("PVOWGLEL", "PVOWGLEL", JdeDataType.String, 2),
        new JdeField("PVPEID", "PVPEID", JdeDataType.Numeric),
        new JdeField("PVTCID", "PVTCID", JdeDataType.Numeric),
        new JdeField("PVPRRC", "PVPRRC", JdeDataType.Numeric),
        new JdeField("PVQTY", "PVQTY", JdeDataType.Numeric),
        new JdeField("PVJEL5", "PVJEL5", JdeDataType.Numeric),
        new JdeField("PVJEL0", "PVJEL0", JdeDataType.Numeric),
        new JdeField("PVJELNNMBR", "PVJELNNMBR", JdeDataType.Numeric),
        new JdeField("PVJELE", "PVJELE", JdeDataType.Numeric),
        new JdeField("PVVANI", "PVVANI", JdeDataType.String, 58)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43092Z_0", "Primary Key on PVCTID, PVJOBS, PVDOCO, PVDCTO, PVKCOO, PVLNID, PVNLIN, PVUOM, PVOPRS, PVOSTO", new[] { "PVCTID", "PVJOBS", "PVDOCO", "PVDCTO", "PVKCOO", "PVLNID", "PVNLIN", "PVUOM", "PVOPRS", "PVOSTO" }, isUnique: true, isPrimaryKey: true)
    };
}
