using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3018 - .
/// </summary>
public class F3018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KPCALCID.
        /// </summary>
        public const string KPCALCID = "KPCALCID";

        /// <summary>
        /// KPKID1.
        /// </summary>
        public const string KPKID1 = "KPKID1";

        /// <summary>
        /// KPDL01.
        /// </summary>
        public const string KPDL01 = "KPDL01";

        /// <summary>
        /// KPNUMP3.
        /// </summary>
        public const string KPNUMP3 = "KPNUMP3";

        /// <summary>
        /// KPNDAYS.
        /// </summary>
        public const string KPNDAYS = "KPNDAYS";

        /// <summary>
        /// KPDY01.
        /// </summary>
        public const string KPDY01 = "KPDY01";

        /// <summary>
        /// KPLTFL.
        /// </summary>
        public const string KPLTFL = "KPLTFL";

        /// <summary>
        /// KPLDAY.
        /// </summary>
        public const string KPLDAY = "KPLDAY";

        /// <summary>
        /// KPVSPC.
        /// </summary>
        public const string KPVSPC = "KPVSPC";

        /// <summary>
        /// KPUPC.
        /// </summary>
        public const string KPUPC = "KPUPC";

        /// <summary>
        /// KPBUM9.
        /// </summary>
        public const string KPBUM9 = "KPBUM9";

        /// <summary>
        /// KPCNTS.
        /// </summary>
        public const string KPCNTS = "KPCNTS";

        /// <summary>
        /// KPBUM5.
        /// </summary>
        public const string KPBUM5 = "KPBUM5";

        /// <summary>
        /// KPSAFE.
        /// </summary>
        public const string KPSAFE = "KPSAFE";

        /// <summary>
        /// KPBUM6.
        /// </summary>
        public const string KPBUM6 = "KPBUM6";

        /// <summary>
        /// KPKMQTY.
        /// </summary>
        public const string KPKMQTY = "KPKMQTY";

        /// <summary>
        /// KPBUM7.
        /// </summary>
        public const string KPBUM7 = "KPBUM7";

        /// <summary>
        /// KPKMXQT.
        /// </summary>
        public const string KPKMXQT = "KPKMXQT";

        /// <summary>
        /// KPBUM8.
        /// </summary>
        public const string KPBUM8 = "KPBUM8";

        /// <summary>
        /// KPPCDS.
        /// </summary>
        public const string KPPCDS = "KPPCDS";

        /// <summary>
        /// KPKMCRD.
        /// </summary>
        public const string KPKMCRD = "KPKMCRD";

        /// <summary>
        /// KPKMXCD.
        /// </summary>
        public const string KPKMXCD = "KPKMXCD";

        /// <summary>
        /// KPMATH01.
        /// </summary>
        public const string KPMATH01 = "KPMATH01";

        /// <summary>
        /// KPMATH02.
        /// </summary>
        public const string KPMATH02 = "KPMATH02";

        /// <summary>
        /// KPMATH03.
        /// </summary>
        public const string KPMATH03 = "KPMATH03";

        /// <summary>
        /// KPUSER.
        /// </summary>
        public const string KPUSER = "KPUSER";

        /// <summary>
        /// KPPID.
        /// </summary>
        public const string KPPID = "KPPID";

        /// <summary>
        /// KPMKEY.
        /// </summary>
        public const string KPMKEY = "KPMKEY";

        /// <summary>
        /// KPUPMJ.
        /// </summary>
        public const string KPUPMJ = "KPUPMJ";

        /// <summary>
        /// KPUPMT.
        /// </summary>
        public const string KPUPMT = "KPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F3018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KPCALCID", "KPCALCID", JdeDataType.String, 20, true, true),
        new JdeField("KPKID1", "KPKID1", JdeDataType.Numeric, null, true, true),
        new JdeField("KPDL01", "KPDL01", JdeDataType.String, 60),
        new JdeField("KPNUMP3", "KPNUMP3", JdeDataType.Numeric),
        new JdeField("KPNDAYS", "KPNDAYS", JdeDataType.Numeric),
        new JdeField("KPDY01", "KPDY01", JdeDataType.Numeric),
        new JdeField("KPLTFL", "KPLTFL", JdeDataType.Numeric),
        new JdeField("KPLDAY", "KPLDAY", JdeDataType.Numeric),
        new JdeField("KPVSPC", "KPVSPC", JdeDataType.Numeric),
        new JdeField("KPUPC", "KPUPC", JdeDataType.Numeric),
        new JdeField("KPBUM9", "KPBUM9", JdeDataType.String, 4),
        new JdeField("KPCNTS", "KPCNTS", JdeDataType.Numeric),
        new JdeField("KPBUM5", "KPBUM5", JdeDataType.String, 4),
        new JdeField("KPSAFE", "KPSAFE", JdeDataType.Numeric),
        new JdeField("KPBUM6", "KPBUM6", JdeDataType.String, 4),
        new JdeField("KPKMQTY", "KPKMQTY", JdeDataType.Numeric),
        new JdeField("KPBUM7", "KPBUM7", JdeDataType.String, 4),
        new JdeField("KPKMXQT", "KPKMXQT", JdeDataType.Numeric),
        new JdeField("KPBUM8", "KPBUM8", JdeDataType.String, 4),
        new JdeField("KPPCDS", "KPPCDS", JdeDataType.Numeric),
        new JdeField("KPKMCRD", "KPKMCRD", JdeDataType.Numeric),
        new JdeField("KPKMXCD", "KPKMXCD", JdeDataType.Numeric),
        new JdeField("KPMATH01", "KPMATH01", JdeDataType.Numeric),
        new JdeField("KPMATH02", "KPMATH02", JdeDataType.Numeric),
        new JdeField("KPMATH03", "KPMATH03", JdeDataType.Numeric),
        new JdeField("KPUSER", "KPUSER", JdeDataType.String, 20),
        new JdeField("KPPID", "KPPID", JdeDataType.String, 20),
        new JdeField("KPMKEY", "KPMKEY", JdeDataType.String, 30),
        new JdeField("KPUPMJ", "KPUPMJ", JdeDataType.Numeric),
        new JdeField("KPUPMT", "KPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3018_0", "Primary Key on KPCALCID, KPKID1", new[] { "KPCALCID", "KPKID1" }, isUnique: true, isPrimaryKey: true)
    };
}
