using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06166 - .
/// </summary>
public class F06166 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YVAN8.
        /// </summary>
        public const string YVAN8 = "YVAN8";

        /// <summary>
        /// YVDOCM.
        /// </summary>
        public const string YVDOCM = "YVDOCM";

        /// <summary>
        /// YVCKCN.
        /// </summary>
        public const string YVCKCN = "YVCKCN";

        /// <summary>
        /// YVTARA.
        /// </summary>
        public const string YVTARA = "YVTARA";

        /// <summary>
        /// YVPTAX.
        /// </summary>
        public const string YVPTAX = "YVPTAX";

        /// <summary>
        /// YVSCOD.
        /// </summary>
        public const string YVSCOD = "YVSCOD";

        /// <summary>
        /// YVCE.
        /// </summary>
        public const string YVCE = "YVCE";

        /// <summary>
        /// YVG101.
        /// </summary>
        public const string YVG101 = "YVG101";

        /// <summary>
        /// YVG201.
        /// </summary>
        public const string YVG201 = "YVG201";

        /// <summary>
        /// YVG401.
        /// </summary>
        public const string YVG401 = "YVG401";

        /// <summary>
        /// YVG301.
        /// </summary>
        public const string YVG301 = "YVG301";

        /// <summary>
        /// YVHMO.
        /// </summary>
        public const string YVHMO = "YVHMO";

        /// <summary>
        /// YVPPNB.
        /// </summary>
        public const string YVPPNB = "YVPPNB";

        /// <summary>
        /// YVPPED.
        /// </summary>
        public const string YVPPED = "YVPPED";

        /// <summary>
        /// YVDTSP.
        /// </summary>
        public const string YVDTSP = "YVDTSP";

        /// <summary>
        /// YVCKDT.
        /// </summary>
        public const string YVCKDT = "YVCKDT";

        /// <summary>
        /// YVHMCO.
        /// </summary>
        public const string YVHMCO = "YVHMCO";

        /// <summary>
        /// YVTHTY.
        /// </summary>
        public const string YVTHTY = "YVTHTY";

        /// <summary>
        /// YVTAXX.
        /// </summary>
        public const string YVTAXX = "YVTAXX";
    }

    /// <inheritdoc />
    public override string TableName => "F06166";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YVAN8", "YVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YVDOCM", "YVDOCM", JdeDataType.Numeric),
        new JdeField("YVCKCN", "YVCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YVTARA", "YVTARA", JdeDataType.String, 20, true, true),
        new JdeField("YVPTAX", "YVPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YVSCOD", "YVSCOD", JdeDataType.String, 6),
        new JdeField("YVCE", "YVCE", JdeDataType.String, 2),
        new JdeField("YVG101", "YVG101", JdeDataType.Numeric),
        new JdeField("YVG201", "YVG201", JdeDataType.Numeric),
        new JdeField("YVG401", "YVG401", JdeDataType.Numeric),
        new JdeField("YVG301", "YVG301", JdeDataType.Numeric),
        new JdeField("YVHMO", "YVHMO", JdeDataType.Numeric),
        new JdeField("YVPPNB", "YVPPNB", JdeDataType.String, 6),
        new JdeField("YVPPED", "YVPPED", JdeDataType.Numeric),
        new JdeField("YVDTSP", "YVDTSP", JdeDataType.Numeric),
        new JdeField("YVCKDT", "YVCKDT", JdeDataType.Numeric),
        new JdeField("YVHMCO", "YVHMCO", JdeDataType.String, 10),
        new JdeField("YVTHTY", "YVTHTY", JdeDataType.String, 2, true, true),
        new JdeField("YVTAXX", "YVTAXX", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06166_0", "Primary Key on YVAN8, YVCKCN, YVTHTY, YVTARA, YVPTAX", new[] { "YVAN8", "YVCKCN", "YVTHTY", "YVTARA", "YVPTAX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06166_2", "Index on YVAN8, YVTARA, YVTHTY, YVPTAX, YVHMO, YVCKDT", new[] { "YVAN8", "YVTARA", "YVTHTY", "YVPTAX", "YVHMO", "YVCKDT" }),
        new JdeIndex("F06166_3", "Index on YVAN8, YVCKCN, YVTARA, YVPTAX", new[] { "YVAN8", "YVCKCN", "YVTARA", "YVPTAX" }),
        new JdeIndex("F06166_4", "Index on YVAN8, YVTARA, YVPTAX, YVHMO, YVCKDT", new[] { "YVAN8", "YVTARA", "YVPTAX", "YVHMO", "YVCKDT" }),
        new JdeIndex("F06166_5", "Index on YVAN8, YVCKDT, YVCKCN, YVTHTY, YVTARA, YVPTAX", new[] { "YVAN8", "YVCKDT", "YVCKCN", "YVTHTY", "YVTARA", "YVPTAX" }),
        new JdeIndex("F06166_6", "Index on YVAN8, YVTARA, YVPTAX, YVHMCO, YVTHTY", new[] { "YVAN8", "YVTARA", "YVPTAX", "YVHMCO", "YVTHTY" }),
        new JdeIndex("F06166_7", "Index on YVAN8, SYS_NC00020$, YVCKCN, YVTHTY, YVTARA, YVPTAX", new[] { "YVAN8", "SYS_NC00020$", "YVCKCN", "YVTHTY", "YVTARA", "YVPTAX" })
    };
}
