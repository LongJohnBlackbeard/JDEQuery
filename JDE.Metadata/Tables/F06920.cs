using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06920 - .
/// </summary>
public class F06920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YQHMCO.
        /// </summary>
        public const string YQHMCO = "YQHMCO";

        /// <summary>
        /// YQDTEY.
        /// </summary>
        public const string YQDTEY = "YQDTEY";

        /// <summary>
        /// YQBDCD.
        /// </summary>
        public const string YQBDCD = "YQBDCD";

        /// <summary>
        /// YQBDCT.
        /// </summary>
        public const string YQBDCT = "YQBDCT";

        /// <summary>
        /// YQBDPV.
        /// </summary>
        public const string YQBDPV = "YQBDPV";

        /// <summary>
        /// YQBDCN.
        /// </summary>
        public const string YQBDCN = "YQBDCN";

        /// <summary>
        /// YQBDCP.
        /// </summary>
        public const string YQBDCP = "YQBDCP";

        /// <summary>
        /// YQBDOT.
        /// </summary>
        public const string YQBDOT = "YQBDOT";

        /// <summary>
        /// YQBDOD.
        /// </summary>
        public const string YQBDOD = "YQBDOD";

        /// <summary>
        /// YQBDEP.
        /// </summary>
        public const string YQBDEP = "YQBDEP";

        /// <summary>
        /// YQBDED.
        /// </summary>
        public const string YQBDED = "YQBDED";

        /// <summary>
        /// YQBDTP.
        /// </summary>
        public const string YQBDTP = "YQBDTP";

        /// <summary>
        /// YQBDCB.
        /// </summary>
        public const string YQBDCB = "YQBDCB";

        /// <summary>
        /// YQBDDN.
        /// </summary>
        public const string YQBDDN = "YQBDDN";

        /// <summary>
        /// YQBDDD.
        /// </summary>
        public const string YQBDDD = "YQBDDD";

        /// <summary>
        /// YQBDDE.
        /// </summary>
        public const string YQBDDE = "YQBDDE";

        /// <summary>
        /// YQBDIG.
        /// </summary>
        public const string YQBDIG = "YQBDIG";

        /// <summary>
        /// YQBDIC.
        /// </summary>
        public const string YQBDIC = "YQBDIC";

        /// <summary>
        /// YQBDRF.
        /// </summary>
        public const string YQBDRF = "YQBDRF";

        /// <summary>
        /// YQBDTD.
        /// </summary>
        public const string YQBDTD = "YQBDTD";

        /// <summary>
        /// YQBDIR.
        /// </summary>
        public const string YQBDIR = "YQBDIR";

        /// <summary>
        /// YQEMPP.
        /// </summary>
        public const string YQEMPP = "YQEMPP";
    }

    /// <inheritdoc />
    public override string TableName => "F06920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YQHMCO", "YQHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YQDTEY", "YQDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YQBDCD", "YQBDCD", JdeDataType.String, 6, true, true),
        new JdeField("YQBDCT", "YQBDCT", JdeDataType.Numeric),
        new JdeField("YQBDPV", "YQBDPV", JdeDataType.Numeric),
        new JdeField("YQBDCN", "YQBDCN", JdeDataType.Numeric),
        new JdeField("YQBDCP", "YQBDCP", JdeDataType.Numeric),
        new JdeField("YQBDOT", "YQBDOT", JdeDataType.Numeric),
        new JdeField("YQBDOD", "YQBDOD", JdeDataType.Numeric),
        new JdeField("YQBDEP", "YQBDEP", JdeDataType.Numeric),
        new JdeField("YQBDED", "YQBDED", JdeDataType.Numeric),
        new JdeField("YQBDTP", "YQBDTP", JdeDataType.Numeric),
        new JdeField("YQBDCB", "YQBDCB", JdeDataType.Numeric),
        new JdeField("YQBDDN", "YQBDDN", JdeDataType.Numeric),
        new JdeField("YQBDDD", "YQBDDD", JdeDataType.Numeric),
        new JdeField("YQBDDE", "YQBDDE", JdeDataType.Numeric),
        new JdeField("YQBDIG", "YQBDIG", JdeDataType.Numeric),
        new JdeField("YQBDIC", "YQBDIC", JdeDataType.Numeric),
        new JdeField("YQBDRF", "YQBDRF", JdeDataType.Numeric),
        new JdeField("YQBDTD", "YQBDTD", JdeDataType.Numeric),
        new JdeField("YQBDIR", "YQBDIR", JdeDataType.Numeric),
        new JdeField("YQEMPP", "YQEMPP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06920_0", "Primary Key on YQHMCO, YQDTEY, YQBDCD", new[] { "YQHMCO", "YQDTEY", "YQBDCD" }, isUnique: true, isPrimaryKey: true)
    };
}
