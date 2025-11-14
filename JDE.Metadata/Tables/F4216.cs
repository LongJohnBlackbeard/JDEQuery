using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4216 - .
/// </summary>
public class F4216 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XDDOCO.
        /// </summary>
        public const string XDDOCO = "XDDOCO";

        /// <summary>
        /// XDDCTO.
        /// </summary>
        public const string XDDCTO = "XDDCTO";

        /// <summary>
        /// XDKCOO.
        /// </summary>
        public const string XDKCOO = "XDKCOO";

        /// <summary>
        /// XDLNID.
        /// </summary>
        public const string XDLNID = "XDLNID";

        /// <summary>
        /// XDPLT.
        /// </summary>
        public const string XDPLT = "XDPLT";

        /// <summary>
        /// XDPAK.
        /// </summary>
        public const string XDPAK = "XDPAK";

        /// <summary>
        /// XDSCCN.
        /// </summary>
        public const string XDSCCN = "XDSCCN";

        /// <summary>
        /// XDSCCQ.
        /// </summary>
        public const string XDSCCQ = "XDSCCQ";

        /// <summary>
        /// XDSCUM.
        /// </summary>
        public const string XDSCUM = "XDSCUM";

        /// <summary>
        /// XDUPCN.
        /// </summary>
        public const string XDUPCN = "XDUPCN";

        /// <summary>
        /// XDUPQT.
        /// </summary>
        public const string XDUPQT = "XDUPQT";

        /// <summary>
        /// XDUPUM.
        /// </summary>
        public const string XDUPUM = "XDUPUM";

        /// <summary>
        /// XDEQTY.
        /// </summary>
        public const string XDEQTY = "XDEQTY";

        /// <summary>
        /// XDCNID.
        /// </summary>
        public const string XDCNID = "XDCNID";

        /// <summary>
        /// XDUSER.
        /// </summary>
        public const string XDUSER = "XDUSER";

        /// <summary>
        /// XDPID.
        /// </summary>
        public const string XDPID = "XDPID";

        /// <summary>
        /// XDJOBN.
        /// </summary>
        public const string XDJOBN = "XDJOBN";

        /// <summary>
        /// XDUPMJ.
        /// </summary>
        public const string XDUPMJ = "XDUPMJ";

        /// <summary>
        /// XDTDAY.
        /// </summary>
        public const string XDTDAY = "XDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4216";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XDDOCO", "XDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("XDDCTO", "XDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("XDKCOO", "XDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("XDLNID", "XDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("XDPLT", "XDPLT", JdeDataType.String, 36, true, true),
        new JdeField("XDPAK", "XDPAK", JdeDataType.String, 36, true, true),
        new JdeField("XDSCCN", "XDSCCN", JdeDataType.String, 28, true, true),
        new JdeField("XDSCCQ", "XDSCCQ", JdeDataType.Numeric),
        new JdeField("XDSCUM", "XDSCUM", JdeDataType.String, 4),
        new JdeField("XDUPCN", "XDUPCN", JdeDataType.String, 26, true, true),
        new JdeField("XDUPQT", "XDUPQT", JdeDataType.Numeric),
        new JdeField("XDUPUM", "XDUPUM", JdeDataType.String, 4),
        new JdeField("XDEQTY", "XDEQTY", JdeDataType.String, 10),
        new JdeField("XDCNID", "XDCNID", JdeDataType.String, 40, true, true),
        new JdeField("XDUSER", "XDUSER", JdeDataType.String, 20),
        new JdeField("XDPID", "XDPID", JdeDataType.String, 20),
        new JdeField("XDJOBN", "XDJOBN", JdeDataType.String, 20),
        new JdeField("XDUPMJ", "XDUPMJ", JdeDataType.Numeric),
        new JdeField("XDTDAY", "XDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4216_0", "Primary Key on XDDOCO, XDDCTO, XDKCOO, XDLNID, XDPLT, XDPAK, XDSCCN, XDUPCN, XDCNID", new[] { "XDDOCO", "XDDCTO", "XDKCOO", "XDLNID", "XDPLT", "XDPAK", "XDSCCN", "XDUPCN", "XDCNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4216_2", "Index on XDPLT, XDDOCO, XDDCTO, XDKCOO, XDLNID", new[] { "XDPLT", "XDDOCO", "XDDCTO", "XDKCOO", "XDLNID" }),
        new JdeIndex("F4216_3", "Index on XDPAK, XDDOCO, XDDCTO, XDKCOO, XDLNID", new[] { "XDPAK", "XDDOCO", "XDDCTO", "XDKCOO", "XDLNID" }),
        new JdeIndex("F4216_4", "Index on XDCNID, XDDOCO, XDDCTO, XDKCOO, XDLNID", new[] { "XDCNID", "XDDOCO", "XDDCTO", "XDKCOO", "XDLNID" })
    };
}
