using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06166A - .
/// </summary>
public class F06166A : JdeTable
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
        /// YVCKCN.
        /// </summary>
        public const string YVCKCN = "YVCKCN";

        /// <summary>
        /// YVTHTY.
        /// </summary>
        public const string YVTHTY = "YVTHTY";

        /// <summary>
        /// YVTARA.
        /// </summary>
        public const string YVTARA = "YVTARA";

        /// <summary>
        /// YVPTAX.
        /// </summary>
        public const string YVPTAX = "YVPTAX";

        /// <summary>
        /// YVSCDC.
        /// </summary>
        public const string YVSCDC = "YVSCDC";

        /// <summary>
        /// YVTACC.
        /// </summary>
        public const string YVTACC = "YVTACC";

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
        /// YVDOCM.
        /// </summary>
        public const string YVDOCM = "YVDOCM";

        /// <summary>
        /// YVSCOD.
        /// </summary>
        public const string YVSCOD = "YVSCOD";

        /// <summary>
        /// YVCE.
        /// </summary>
        public const string YVCE = "YVCE";

        /// <summary>
        /// YVHMO.
        /// </summary>
        public const string YVHMO = "YVHMO";

        /// <summary>
        /// YVPPNB.
        /// </summary>
        public const string YVPPNB = "YVPPNB";

        /// <summary>
        /// YVCKDT.
        /// </summary>
        public const string YVCKDT = "YVCKDT";

        /// <summary>
        /// YVPPED.
        /// </summary>
        public const string YVPPED = "YVPPED";

        /// <summary>
        /// YVHMCO.
        /// </summary>
        public const string YVHMCO = "YVHMCO";

        /// <summary>
        /// YVTAXX.
        /// </summary>
        public const string YVTAXX = "YVTAXX";

        /// <summary>
        /// YVDESC.
        /// </summary>
        public const string YVDESC = "YVDESC";

        /// <summary>
        /// YVDL01.
        /// </summary>
        public const string YVDL01 = "YVDL01";

        /// <summary>
        /// YVUPMJ.
        /// </summary>
        public const string YVUPMJ = "YVUPMJ";

        /// <summary>
        /// YVUPMT.
        /// </summary>
        public const string YVUPMT = "YVUPMT";

        /// <summary>
        /// YVPID.
        /// </summary>
        public const string YVPID = "YVPID";

        /// <summary>
        /// YVJOBN.
        /// </summary>
        public const string YVJOBN = "YVJOBN";

        /// <summary>
        /// YVUSER.
        /// </summary>
        public const string YVUSER = "YVUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F06166A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YVAN8", "YVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YVCKCN", "YVCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YVTHTY", "YVTHTY", JdeDataType.String, 2, true, true),
        new JdeField("YVTARA", "YVTARA", JdeDataType.String, 20, true, true),
        new JdeField("YVPTAX", "YVPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YVSCDC", "YVSCDC", JdeDataType.Numeric, null, true, true),
        new JdeField("YVTACC", "YVTACC", JdeDataType.String, 4, true, true),
        new JdeField("YVG101", "YVG101", JdeDataType.Numeric),
        new JdeField("YVG201", "YVG201", JdeDataType.Numeric),
        new JdeField("YVG401", "YVG401", JdeDataType.Numeric),
        new JdeField("YVG301", "YVG301", JdeDataType.Numeric),
        new JdeField("YVDOCM", "YVDOCM", JdeDataType.Numeric),
        new JdeField("YVSCOD", "YVSCOD", JdeDataType.String, 6),
        new JdeField("YVCE", "YVCE", JdeDataType.String, 2),
        new JdeField("YVHMO", "YVHMO", JdeDataType.Numeric),
        new JdeField("YVPPNB", "YVPPNB", JdeDataType.String, 6),
        new JdeField("YVCKDT", "YVCKDT", JdeDataType.Numeric),
        new JdeField("YVPPED", "YVPPED", JdeDataType.Numeric),
        new JdeField("YVHMCO", "YVHMCO", JdeDataType.String, 10),
        new JdeField("YVTAXX", "YVTAXX", JdeDataType.String, 40),
        new JdeField("YVDESC", "YVDESC", JdeDataType.String, 60),
        new JdeField("YVDL01", "YVDL01", JdeDataType.String, 60),
        new JdeField("YVUPMJ", "YVUPMJ", JdeDataType.Numeric),
        new JdeField("YVUPMT", "YVUPMT", JdeDataType.Numeric),
        new JdeField("YVPID", "YVPID", JdeDataType.String, 20),
        new JdeField("YVJOBN", "YVJOBN", JdeDataType.String, 20),
        new JdeField("YVUSER", "YVUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06166A_0", "Primary Key on YVAN8, YVCKCN, YVTHTY, YVTARA, YVPTAX, YVSCDC, YVTACC", new[] { "YVAN8", "YVCKCN", "YVTHTY", "YVTARA", "YVPTAX", "YVSCDC", "YVTACC" }, isUnique: true, isPrimaryKey: true)
    };
}
