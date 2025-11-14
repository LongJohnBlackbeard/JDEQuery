using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A180 - .
/// </summary>
public class F34A180 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RRTRT.
        /// </summary>
        public const string RRTRT = "RRTRT";

        /// <summary>
        /// RRKIT.
        /// </summary>
        public const string RRKIT = "RRKIT";

        /// <summary>
        /// RRMMCU.
        /// </summary>
        public const string RRMMCU = "RRMMCU";

        /// <summary>
        /// RRLINE.
        /// </summary>
        public const string RRLINE = "RRLINE";

        /// <summary>
        /// RROPSQ.
        /// </summary>
        public const string RROPSQ = "RROPSQ";

        /// <summary>
        /// RREFFF.
        /// </summary>
        public const string RREFFF = "RREFFF";

        /// <summary>
        /// RRBQTY.
        /// </summary>
        public const string RRBQTY = "RRBQTY";

        /// <summary>
        /// RROPSC.
        /// </summary>
        public const string RROPSC = "RROPSC";

        /// <summary>
        /// RRMCU.
        /// </summary>
        public const string RRMCU = "RRMCU";

        /// <summary>
        /// RRRSETID.
        /// </summary>
        public const string RRRSETID = "RRRSETID";

        /// <summary>
        /// RRRSETD.
        /// </summary>
        public const string RRRSETD = "RRRSETD";

        /// <summary>
        /// RRDURYN.
        /// </summary>
        public const string RRDURYN = "RRDURYN";

        /// <summary>
        /// RRLOTMYN.
        /// </summary>
        public const string RRLOTMYN = "RRLOTMYN";

        /// <summary>
        /// RRURCD.
        /// </summary>
        public const string RRURCD = "RRURCD";

        /// <summary>
        /// RRURDT.
        /// </summary>
        public const string RRURDT = "RRURDT";

        /// <summary>
        /// RRURAT.
        /// </summary>
        public const string RRURAT = "RRURAT";

        /// <summary>
        /// RRURAB.
        /// </summary>
        public const string RRURAB = "RRURAB";

        /// <summary>
        /// RRURRF.
        /// </summary>
        public const string RRURRF = "RRURRF";

        /// <summary>
        /// RRUSER.
        /// </summary>
        public const string RRUSER = "RRUSER";

        /// <summary>
        /// RRMKEY.
        /// </summary>
        public const string RRMKEY = "RRMKEY";

        /// <summary>
        /// RRPID.
        /// </summary>
        public const string RRPID = "RRPID";

        /// <summary>
        /// RRUUPMJ.
        /// </summary>
        public const string RRUUPMJ = "RRUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F34A180";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RRTRT", "RRTRT", JdeDataType.String, 6, true, true),
        new JdeField("RRKIT", "RRKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("RRMMCU", "RRMMCU", JdeDataType.String, 24, true, true),
        new JdeField("RRLINE", "RRLINE", JdeDataType.String, 24, true, true),
        new JdeField("RROPSQ", "RROPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RREFFF", "RREFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("RRBQTY", "RRBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("RROPSC", "RROPSC", JdeDataType.String, 4, true, true),
        new JdeField("RRMCU", "RRMCU", JdeDataType.String, 24, true, true),
        new JdeField("RRRSETID", "RRRSETID", JdeDataType.String, 20, true, true),
        new JdeField("RRRSETD", "RRRSETD", JdeDataType.String, 50),
        new JdeField("RRDURYN", "RRDURYN", JdeDataType.Numeric),
        new JdeField("RRLOTMYN", "RRLOTMYN", JdeDataType.Numeric),
        new JdeField("RRURCD", "RRURCD", JdeDataType.String, 4),
        new JdeField("RRURDT", "RRURDT", JdeDataType.Numeric),
        new JdeField("RRURAT", "RRURAT", JdeDataType.Numeric),
        new JdeField("RRURAB", "RRURAB", JdeDataType.Numeric),
        new JdeField("RRURRF", "RRURRF", JdeDataType.String, 30),
        new JdeField("RRUSER", "RRUSER", JdeDataType.String, 20),
        new JdeField("RRMKEY", "RRMKEY", JdeDataType.String, 30),
        new JdeField("RRPID", "RRPID", JdeDataType.String, 20),
        new JdeField("RRUUPMJ", "RRUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A180_0", "Primary Key on RRTRT, RRKIT, RRMMCU, RRLINE, RROPSQ, RREFFF, RRBQTY, RROPSC, RRMCU, RRRSETID", new[] { "RRTRT", "RRKIT", "RRMMCU", "RRLINE", "RROPSQ", "RREFFF", "RRBQTY", "RROPSC", "RRMCU", "RRRSETID" }, isUnique: true, isPrimaryKey: true)
    };
}
