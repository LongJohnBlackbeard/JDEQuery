using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42150Z1 - .
/// </summary>
public class F42150Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S2EDUS.
        /// </summary>
        public const string S2EDUS = "S2EDUS";

        /// <summary>
        /// S2EDBT.
        /// </summary>
        public const string S2EDBT = "S2EDBT";

        /// <summary>
        /// S2EDTN.
        /// </summary>
        public const string S2EDTN = "S2EDTN";

        /// <summary>
        /// S2EDLN.
        /// </summary>
        public const string S2EDLN = "S2EDLN";

        /// <summary>
        /// S2EDCT.
        /// </summary>
        public const string S2EDCT = "S2EDCT";

        /// <summary>
        /// S2EDFT.
        /// </summary>
        public const string S2EDFT = "S2EDFT";

        /// <summary>
        /// S2EDDT.
        /// </summary>
        public const string S2EDDT = "S2EDDT";

        /// <summary>
        /// S2EDDL.
        /// </summary>
        public const string S2EDDL = "S2EDDL";

        /// <summary>
        /// S2EDSP.
        /// </summary>
        public const string S2EDSP = "S2EDSP";

        /// <summary>
        /// S2DOCO.
        /// </summary>
        public const string S2DOCO = "S2DOCO";

        /// <summary>
        /// S2DCTO.
        /// </summary>
        public const string S2DCTO = "S2DCTO";

        /// <summary>
        /// S2KCOO.
        /// </summary>
        public const string S2KCOO = "S2KCOO";

        /// <summary>
        /// S2CMLN.
        /// </summary>
        public const string S2CMLN = "S2CMLN";

        /// <summary>
        /// S2SLSM.
        /// </summary>
        public const string S2SLSM = "S2SLSM";

        /// <summary>
        /// S2SLCM.
        /// </summary>
        public const string S2SLCM = "S2SLCM";

        /// <summary>
        /// S2FCA.
        /// </summary>
        public const string S2FCA = "S2FCA";

        /// <summary>
        /// S2APUN.
        /// </summary>
        public const string S2APUN = "S2APUN";

        /// <summary>
        /// S2CCTY.
        /// </summary>
        public const string S2CCTY = "S2CCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42150Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S2EDUS", "S2EDUS", JdeDataType.String, 20, true, true),
        new JdeField("S2EDBT", "S2EDBT", JdeDataType.String, 30, true, true),
        new JdeField("S2EDTN", "S2EDTN", JdeDataType.String, 44, true, true),
        new JdeField("S2EDLN", "S2EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S2EDCT", "S2EDCT", JdeDataType.String, 4),
        new JdeField("S2EDFT", "S2EDFT", JdeDataType.String, 20),
        new JdeField("S2EDDT", "S2EDDT", JdeDataType.Numeric),
        new JdeField("S2EDDL", "S2EDDL", JdeDataType.Numeric),
        new JdeField("S2EDSP", "S2EDSP", JdeDataType.String, 2),
        new JdeField("S2DOCO", "S2DOCO", JdeDataType.Numeric),
        new JdeField("S2DCTO", "S2DCTO", JdeDataType.String, 4),
        new JdeField("S2KCOO", "S2KCOO", JdeDataType.String, 10),
        new JdeField("S2CMLN", "S2CMLN", JdeDataType.Numeric),
        new JdeField("S2SLSM", "S2SLSM", JdeDataType.Numeric),
        new JdeField("S2SLCM", "S2SLCM", JdeDataType.Numeric),
        new JdeField("S2FCA", "S2FCA", JdeDataType.Numeric),
        new JdeField("S2APUN", "S2APUN", JdeDataType.Numeric),
        new JdeField("S2CCTY", "S2CCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42150Z1_0", "Primary Key on S2EDUS, S2EDBT, S2EDTN, S2EDLN", new[] { "S2EDUS", "S2EDBT", "S2EDTN", "S2EDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42150Z1_2", "Index on S2DOCO, S2DCTO, S2KCOO, S2EDUS", new[] { "S2DOCO", "S2DCTO", "S2KCOO", "S2EDUS" })
    };
}
