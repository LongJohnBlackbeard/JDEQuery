using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08320B - .
/// </summary>
public class F08320B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPPLAN.
        /// </summary>
        public const string PPPLAN = "PPPLAN";

        /// <summary>
        /// PPAOPT.
        /// </summary>
        public const string PPAOPT = "PPAOPT";

        /// <summary>
        /// PPDS50.
        /// </summary>
        public const string PPDS50 = "PPDS50";

        /// <summary>
        /// PPEPFG.
        /// </summary>
        public const string PPEPFG = "PPEPFG";

        /// <summary>
        /// PPPCPF.
        /// </summary>
        public const string PPPCPF = "PPPCPF";

        /// <summary>
        /// PPMXDP.
        /// </summary>
        public const string PPMXDP = "PPMXDP";

        /// <summary>
        /// PPBGPP.
        /// </summary>
        public const string PPBGPP = "PPBGPP";

        /// <summary>
        /// PPUPMJ.
        /// </summary>
        public const string PPUPMJ = "PPUPMJ";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPTME0.
        /// </summary>
        public const string PPTME0 = "PPTME0";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPJOBN.
        /// </summary>
        public const string PPJOBN = "PPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08320B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPPLAN", "PPPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PPAOPT", "PPAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PPDS50", "PPDS50", JdeDataType.String, 100),
        new JdeField("PPEPFG", "PPEPFG", JdeDataType.String, 2),
        new JdeField("PPPCPF", "PPPCPF", JdeDataType.Numeric),
        new JdeField("PPMXDP", "PPMXDP", JdeDataType.Numeric),
        new JdeField("PPBGPP", "PPBGPP", JdeDataType.String, 2),
        new JdeField("PPUPMJ", "PPUPMJ", JdeDataType.Numeric),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPTME0", "PPTME0", JdeDataType.Numeric),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08320B_0", "Primary Key on PPPLAN, PPAOPT", new[] { "PPPLAN", "PPAOPT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08320B_2", "Index on PPPLAN, PPAOPT, PPMXDP", new[] { "PPPLAN", "PPAOPT", "PPMXDP" })
    };
}
