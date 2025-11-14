using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08366 - .
/// </summary>
public class F08366 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HYTSTN.
        /// </summary>
        public const string HYTSTN = "HYTSTN";

        /// <summary>
        /// HYTSTY.
        /// </summary>
        public const string HYTSTY = "HYTSTY";

        /// <summary>
        /// HYTSTT.
        /// </summary>
        public const string HYTSTT = "HYTSTT";

        /// <summary>
        /// HYCPYR.
        /// </summary>
        public const string HYCPYR = "HYCPYR";

        /// <summary>
        /// HYLIN.
        /// </summary>
        public const string HYLIN = "HYLIN";

        /// <summary>
        /// HYAOR1.
        /// </summary>
        public const string HYAOR1 = "HYAOR1";

        /// <summary>
        /// HYCMPL.
        /// </summary>
        public const string HYCMPL = "HYCMPL";

        /// <summary>
        /// HYGPAY.
        /// </summary>
        public const string HYGPAY = "HYGPAY";

        /// <summary>
        /// HYTPP.
        /// </summary>
        public const string HYTPP = "HYTPP";

        /// <summary>
        /// HYTPM.
        /// </summary>
        public const string HYTPM = "HYTPM";

        /// <summary>
        /// HYCTVL.
        /// </summary>
        public const string HYCTVL = "HYCTVL";

        /// <summary>
        /// HYEGNO.
        /// </summary>
        public const string HYEGNO = "HYEGNO";

        /// <summary>
        /// HYDTTC.
        /// </summary>
        public const string HYDTTC = "HYDTTC";

        /// <summary>
        /// HYDTCV.
        /// </summary>
        public const string HYDTCV = "HYDTCV";

        /// <summary>
        /// HYDTPC.
        /// </summary>
        public const string HYDTPC = "HYDTPC";

        /// <summary>
        /// HYEST.
        /// </summary>
        public const string HYEST = "HYEST";

        /// <summary>
        /// HYPAST.
        /// </summary>
        public const string HYPAST = "HYPAST";

        /// <summary>
        /// HYRT.
        /// </summary>
        public const string HYRT = "HYRT";

        /// <summary>
        /// HYDTKE.
        /// </summary>
        public const string HYDTKE = "HYDTKE";

        /// <summary>
        /// HYDTCT.
        /// </summary>
        public const string HYDTCT = "HYDTCT";

        /// <summary>
        /// HYDTD.
        /// </summary>
        public const string HYDTD = "HYDTD";

        /// <summary>
        /// HYTTAB.
        /// </summary>
        public const string HYTTAB = "HYTTAB";
    }

    /// <inheritdoc />
    public override string TableName => "F08366";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HYTSTN", "HYTSTN", JdeDataType.String, 16, true, true),
        new JdeField("HYTSTY", "HYTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("HYTSTT", "HYTSTT", JdeDataType.String, 2),
        new JdeField("HYCPYR", "HYCPYR", JdeDataType.String, 2),
        new JdeField("HYLIN", "HYLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("HYAOR1", "HYAOR1", JdeDataType.String, 6),
        new JdeField("HYCMPL", "HYCMPL", JdeDataType.Numeric),
        new JdeField("HYGPAY", "HYGPAY", JdeDataType.Numeric),
        new JdeField("HYTPP", "HYTPP", JdeDataType.Numeric),
        new JdeField("HYTPM", "HYTPM", JdeDataType.String, 2),
        new JdeField("HYCTVL", "HYCTVL", JdeDataType.String, 2),
        new JdeField("HYEGNO", "HYEGNO", JdeDataType.String, 8),
        new JdeField("HYDTTC", "HYDTTC", JdeDataType.String, 2),
        new JdeField("HYDTCV", "HYDTCV", JdeDataType.String, 2),
        new JdeField("HYDTPC", "HYDTPC", JdeDataType.String, 2),
        new JdeField("HYEST", "HYEST", JdeDataType.String, 2),
        new JdeField("HYPAST", "HYPAST", JdeDataType.String, 2),
        new JdeField("HYRT", "HYRT", JdeDataType.String, 4),
        new JdeField("HYDTKE", "HYDTKE", JdeDataType.String, 2),
        new JdeField("HYDTCT", "HYDTCT", JdeDataType.String, 2),
        new JdeField("HYDTD", "HYDTD", JdeDataType.String, 6),
        new JdeField("HYTTAB", "HYTTAB", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08366_0", "Primary Key on HYTSTN, HYTSTY, HYLIN", new[] { "HYTSTN", "HYTSTY", "HYLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
