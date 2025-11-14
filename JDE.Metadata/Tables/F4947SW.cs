using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4947SW - .
/// </summary>
public class F4947SW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWJOBS.
        /// </summary>
        public const string SWJOBS = "SWJOBS";

        /// <summary>
        /// SWCTID.
        /// </summary>
        public const string SWCTID = "SWCTID";

        /// <summary>
        /// SWSHPN.
        /// </summary>
        public const string SWSHPN = "SWSHPN";

        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWSSTS.
        /// </summary>
        public const string SWSSTS = "SWSSTS";

        /// <summary>
        /// SWDL01.
        /// </summary>
        public const string SWDL01 = "SWDL01";

        /// <summary>
        /// SWDRQJ.
        /// </summary>
        public const string SWDRQJ = "SWDRQJ";

        /// <summary>
        /// SWADDJ.
        /// </summary>
        public const string SWADDJ = "SWADDJ";

        /// <summary>
        /// SWADTM.
        /// </summary>
        public const string SWADTM = "SWADTM";

        /// <summary>
        /// SWDLDT.
        /// </summary>
        public const string SWDLDT = "SWDLDT";

        /// <summary>
        /// SWDLTM.
        /// </summary>
        public const string SWDLTM = "SWDLTM";

        /// <summary>
        /// SWCARS.
        /// </summary>
        public const string SWCARS = "SWCARS";

        /// <summary>
        /// SWALPH.
        /// </summary>
        public const string SWALPH = "SWALPH";

        /// <summary>
        /// SWMOT.
        /// </summary>
        public const string SWMOT = "SWMOT";

        /// <summary>
        /// SWFRTH.
        /// </summary>
        public const string SWFRTH = "SWFRTH";

        /// <summary>
        /// SWCRCD.
        /// </summary>
        public const string SWCRCD = "SWCRCD";

        /// <summary>
        /// SWFRCC.
        /// </summary>
        public const string SWFRCC = "SWFRCC";

        /// <summary>
        /// SWFRCF.
        /// </summary>
        public const string SWFRCF = "SWFRCF";

        /// <summary>
        /// SWCRDC.
        /// </summary>
        public const string SWCRDC = "SWCRDC";

        /// <summary>
        /// SWFRVC.
        /// </summary>
        public const string SWFRVC = "SWFRVC";

        /// <summary>
        /// SWFRVF.
        /// </summary>
        public const string SWFRVF = "SWFRVF";

        /// <summary>
        /// SWCRCP.
        /// </summary>
        public const string SWCRCP = "SWCRCP";

        /// <summary>
        /// SWAN8.
        /// </summary>
        public const string SWAN8 = "SWAN8";

        /// <summary>
        /// SWSHAN.
        /// </summary>
        public const string SWSHAN = "SWSHAN";

        /// <summary>
        /// SWORGN.
        /// </summary>
        public const string SWORGN = "SWORGN";

        /// <summary>
        /// SWNRTS.
        /// </summary>
        public const string SWNRTS = "SWNRTS";

        /// <summary>
        /// SWILEL.
        /// </summary>
        public const string SWILEL = "SWILEL";

        /// <summary>
        /// SWURCD.
        /// </summary>
        public const string SWURCD = "SWURCD";

        /// <summary>
        /// SWURRF.
        /// </summary>
        public const string SWURRF = "SWURRF";

        /// <summary>
        /// SWURAT.
        /// </summary>
        public const string SWURAT = "SWURAT";

        /// <summary>
        /// SWURAB.
        /// </summary>
        public const string SWURAB = "SWURAB";

        /// <summary>
        /// SWURDT.
        /// </summary>
        public const string SWURDT = "SWURDT";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWTDAY.
        /// </summary>
        public const string SWTDAY = "SWTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4947SW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWJOBS", "SWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SWCTID", "SWCTID", JdeDataType.String, 30, true, true),
        new JdeField("SWSHPN", "SWSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24),
        new JdeField("SWSSTS", "SWSSTS", JdeDataType.String, 4),
        new JdeField("SWDL01", "SWDL01", JdeDataType.String, 60),
        new JdeField("SWDRQJ", "SWDRQJ", JdeDataType.Numeric),
        new JdeField("SWADDJ", "SWADDJ", JdeDataType.Numeric),
        new JdeField("SWADTM", "SWADTM", JdeDataType.Numeric),
        new JdeField("SWDLDT", "SWDLDT", JdeDataType.Numeric),
        new JdeField("SWDLTM", "SWDLTM", JdeDataType.Numeric),
        new JdeField("SWCARS", "SWCARS", JdeDataType.Numeric),
        new JdeField("SWALPH", "SWALPH", JdeDataType.String, 80),
        new JdeField("SWMOT", "SWMOT", JdeDataType.String, 6),
        new JdeField("SWFRTH", "SWFRTH", JdeDataType.String, 6),
        new JdeField("SWCRCD", "SWCRCD", JdeDataType.String, 6),
        new JdeField("SWFRCC", "SWFRCC", JdeDataType.Numeric),
        new JdeField("SWFRCF", "SWFRCF", JdeDataType.Numeric),
        new JdeField("SWCRDC", "SWCRDC", JdeDataType.String, 6),
        new JdeField("SWFRVC", "SWFRVC", JdeDataType.Numeric),
        new JdeField("SWFRVF", "SWFRVF", JdeDataType.Numeric),
        new JdeField("SWCRCP", "SWCRCP", JdeDataType.String, 6),
        new JdeField("SWAN8", "SWAN8", JdeDataType.Numeric),
        new JdeField("SWSHAN", "SWSHAN", JdeDataType.Numeric),
        new JdeField("SWORGN", "SWORGN", JdeDataType.Numeric),
        new JdeField("SWNRTS", "SWNRTS", JdeDataType.Numeric),
        new JdeField("SWILEL", "SWILEL", JdeDataType.String, 2),
        new JdeField("SWURCD", "SWURCD", JdeDataType.String, 4),
        new JdeField("SWURRF", "SWURRF", JdeDataType.String, 30),
        new JdeField("SWURAT", "SWURAT", JdeDataType.Numeric),
        new JdeField("SWURAB", "SWURAB", JdeDataType.Numeric),
        new JdeField("SWURDT", "SWURDT", JdeDataType.Numeric),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWTDAY", "SWTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4947SW_0", "Primary Key on SWJOBS, SWCTID, SWSHPN", new[] { "SWJOBS", "SWCTID", "SWSHPN" }, isUnique: true, isPrimaryKey: true)
    };
}
