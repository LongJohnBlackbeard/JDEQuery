using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F082002 - .
/// </summary>
public class F082002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YVSRVW.
        /// </summary>
        public const string YVSRVW = "YVSRVW";

        /// <summary>
        /// YVDL01.
        /// </summary>
        public const string YVDL01 = "YVDL01";

        /// <summary>
        /// YVCCPR.
        /// </summary>
        public const string YVCCPR = "YVCCPR";

        /// <summary>
        /// YVTNOE.
        /// </summary>
        public const string YVTNOE = "YVTNOE";

        /// <summary>
        /// YVSAL.
        /// </summary>
        public const string YVSAL = "YVSAL";

        /// <summary>
        /// YVSALN.
        /// </summary>
        public const string YVSALN = "YVSALN";

        /// <summary>
        /// YVOWAMS.
        /// </summary>
        public const string YVOWAMS = "YVOWAMS";

        /// <summary>
        /// YVWGST.
        /// </summary>
        public const string YVWGST = "YVWGST";

        /// <summary>
        /// YVBOEN.
        /// </summary>
        public const string YVBOEN = "YVBOEN";

        /// <summary>
        /// YVEFD.
        /// </summary>
        public const string YVEFD = "YVEFD";

        /// <summary>
        /// YVEFDI.
        /// </summary>
        public const string YVEFDI = "YVEFDI";

        /// <summary>
        /// YVRGCD.
        /// </summary>
        public const string YVRGCD = "YVRGCD";

        /// <summary>
        /// YVUSER.
        /// </summary>
        public const string YVUSER = "YVUSER";

        /// <summary>
        /// YVPID.
        /// </summary>
        public const string YVPID = "YVPID";

        /// <summary>
        /// YVJOBN.
        /// </summary>
        public const string YVJOBN = "YVJOBN";

        /// <summary>
        /// YVUPMJ.
        /// </summary>
        public const string YVUPMJ = "YVUPMJ";

        /// <summary>
        /// YVTDAY.
        /// </summary>
        public const string YVTDAY = "YVTDAY";

        /// <summary>
        /// YVDEF.
        /// </summary>
        public const string YVDEF = "YVDEF";
    }

    /// <inheritdoc />
    public override string TableName => "F082002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YVSRVW", "YVSRVW", JdeDataType.String, 12, true, true),
        new JdeField("YVDL01", "YVDL01", JdeDataType.String, 60),
        new JdeField("YVCCPR", "YVCCPR", JdeDataType.String, 6, true, true),
        new JdeField("YVTNOE", "YVTNOE", JdeDataType.Numeric),
        new JdeField("YVSAL", "YVSAL", JdeDataType.Numeric),
        new JdeField("YVSALN", "YVSALN", JdeDataType.Numeric),
        new JdeField("YVOWAMS", "YVOWAMS", JdeDataType.Numeric),
        new JdeField("YVWGST", "YVWGST", JdeDataType.String, 2),
        new JdeField("YVBOEN", "YVBOEN", JdeDataType.String, 2),
        new JdeField("YVEFD", "YVEFD", JdeDataType.Numeric),
        new JdeField("YVEFDI", "YVEFDI", JdeDataType.String, 20),
        new JdeField("YVRGCD", "YVRGCD", JdeDataType.Numeric),
        new JdeField("YVUSER", "YVUSER", JdeDataType.String, 20),
        new JdeField("YVPID", "YVPID", JdeDataType.String, 20),
        new JdeField("YVJOBN", "YVJOBN", JdeDataType.String, 20),
        new JdeField("YVUPMJ", "YVUPMJ", JdeDataType.Numeric),
        new JdeField("YVTDAY", "YVTDAY", JdeDataType.Numeric),
        new JdeField("YVDEF", "YVDEF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F082002_0", "Primary Key on YVSRVW, YVCCPR", new[] { "YVSRVW", "YVCCPR" }, isUnique: true, isPrimaryKey: true)
    };
}
