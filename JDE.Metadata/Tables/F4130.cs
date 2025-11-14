using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4130 - .
/// </summary>
public class F4130 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MHCHNO.
        /// </summary>
        public const string MHCHNO = "MHCHNO";

        /// <summary>
        /// MHCSDESC.
        /// </summary>
        public const string MHCSDESC = "MHCSDESC";

        /// <summary>
        /// MHAN8.
        /// </summary>
        public const string MHAN8 = "MHAN8";

        /// <summary>
        /// MHSHAN.
        /// </summary>
        public const string MHSHAN = "MHSHAN";

        /// <summary>
        /// MHCONMCU.
        /// </summary>
        public const string MHCONMCU = "MHCONMCU";

        /// <summary>
        /// MHMCU.
        /// </summary>
        public const string MHMCU = "MHMCU";

        /// <summary>
        /// MHCSMAN8.
        /// </summary>
        public const string MHCSMAN8 = "MHCSMAN8";

        /// <summary>
        /// MHCCCAN8.
        /// </summary>
        public const string MHCCCAN8 = "MHCCCAN8";

        /// <summary>
        /// MHASN.
        /// </summary>
        public const string MHASN = "MHASN";

        /// <summary>
        /// MHVR01.
        /// </summary>
        public const string MHVR01 = "MHVR01";

        /// <summary>
        /// MHTRKIT.
        /// </summary>
        public const string MHTRKIT = "MHTRKIT";

        /// <summary>
        /// MHSTRDTJ.
        /// </summary>
        public const string MHSTRDTJ = "MHSTRDTJ";

        /// <summary>
        /// MHENDDTJ.
        /// </summary>
        public const string MHENDDTJ = "MHENDDTJ";

        /// <summary>
        /// MHLSTAUDJ.
        /// </summary>
        public const string MHLSTAUDJ = "MHLSTAUDJ";

        /// <summary>
        /// MHURCD.
        /// </summary>
        public const string MHURCD = "MHURCD";

        /// <summary>
        /// MHURDT.
        /// </summary>
        public const string MHURDT = "MHURDT";

        /// <summary>
        /// MHURAT.
        /// </summary>
        public const string MHURAT = "MHURAT";

        /// <summary>
        /// MHURAB.
        /// </summary>
        public const string MHURAB = "MHURAB";

        /// <summary>
        /// MHURRF.
        /// </summary>
        public const string MHURRF = "MHURRF";

        /// <summary>
        /// MHUSER.
        /// </summary>
        public const string MHUSER = "MHUSER";

        /// <summary>
        /// MHPID.
        /// </summary>
        public const string MHPID = "MHPID";

        /// <summary>
        /// MHMKEY.
        /// </summary>
        public const string MHMKEY = "MHMKEY";

        /// <summary>
        /// MHUTIME.
        /// </summary>
        public const string MHUTIME = "MHUTIME";

        /// <summary>
        /// MHCSQTY.
        /// </summary>
        public const string MHCSQTY = "MHCSQTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4130";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MHCHNO", "MHCHNO", JdeDataType.Numeric, null, true, true),
        new JdeField("MHCSDESC", "MHCSDESC", JdeDataType.String, 60),
        new JdeField("MHAN8", "MHAN8", JdeDataType.Numeric),
        new JdeField("MHSHAN", "MHSHAN", JdeDataType.Numeric),
        new JdeField("MHCONMCU", "MHCONMCU", JdeDataType.String, 24),
        new JdeField("MHMCU", "MHMCU", JdeDataType.String, 24),
        new JdeField("MHCSMAN8", "MHCSMAN8", JdeDataType.Numeric),
        new JdeField("MHCCCAN8", "MHCCCAN8", JdeDataType.Numeric),
        new JdeField("MHASN", "MHASN", JdeDataType.String, 16),
        new JdeField("MHVR01", "MHVR01", JdeDataType.String, 50),
        new JdeField("MHTRKIT", "MHTRKIT", JdeDataType.String, 2),
        new JdeField("MHSTRDTJ", "MHSTRDTJ", JdeDataType.Numeric),
        new JdeField("MHENDDTJ", "MHENDDTJ", JdeDataType.Numeric),
        new JdeField("MHLSTAUDJ", "MHLSTAUDJ", JdeDataType.Numeric),
        new JdeField("MHURCD", "MHURCD", JdeDataType.String, 4),
        new JdeField("MHURDT", "MHURDT", JdeDataType.Numeric),
        new JdeField("MHURAT", "MHURAT", JdeDataType.Numeric),
        new JdeField("MHURAB", "MHURAB", JdeDataType.Numeric),
        new JdeField("MHURRF", "MHURRF", JdeDataType.String, 30),
        new JdeField("MHUSER", "MHUSER", JdeDataType.String, 20),
        new JdeField("MHPID", "MHPID", JdeDataType.String, 20),
        new JdeField("MHMKEY", "MHMKEY", JdeDataType.String, 30),
        new JdeField("MHUTIME", "MHUTIME", JdeDataType.Date),
        new JdeField("MHCSQTY", "MHCSQTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4130_0", "Primary Key on MHCHNO", new[] { "MHCHNO" }, isUnique: true, isPrimaryKey: true)
    };
}
