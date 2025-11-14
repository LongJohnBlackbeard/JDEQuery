using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42160Z1 - .
/// </summary>
public class F42160Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S3EDUS.
        /// </summary>
        public const string S3EDUS = "S3EDUS";

        /// <summary>
        /// S3EDBT.
        /// </summary>
        public const string S3EDBT = "S3EDBT";

        /// <summary>
        /// S3EDTN.
        /// </summary>
        public const string S3EDTN = "S3EDTN";

        /// <summary>
        /// S3EDLN.
        /// </summary>
        public const string S3EDLN = "S3EDLN";

        /// <summary>
        /// S3EDCT.
        /// </summary>
        public const string S3EDCT = "S3EDCT";

        /// <summary>
        /// S3EDFT.
        /// </summary>
        public const string S3EDFT = "S3EDFT";

        /// <summary>
        /// S3EDDT.
        /// </summary>
        public const string S3EDDT = "S3EDDT";

        /// <summary>
        /// S3EDDL.
        /// </summary>
        public const string S3EDDL = "S3EDDL";

        /// <summary>
        /// S3EDSP.
        /// </summary>
        public const string S3EDSP = "S3EDSP";

        /// <summary>
        /// S3DOCO.
        /// </summary>
        public const string S3DOCO = "S3DOCO";

        /// <summary>
        /// S3DCTO.
        /// </summary>
        public const string S3DCTO = "S3DCTO";

        /// <summary>
        /// S3KCOO.
        /// </summary>
        public const string S3KCOO = "S3KCOO";

        /// <summary>
        /// S3SFXO.
        /// </summary>
        public const string S3SFXO = "S3SFXO";

        /// <summary>
        /// S3LNID.
        /// </summary>
        public const string S3LNID = "S3LNID";

        /// <summary>
        /// S3CMLN.
        /// </summary>
        public const string S3CMLN = "S3CMLN";

        /// <summary>
        /// S3SLSM.
        /// </summary>
        public const string S3SLSM = "S3SLSM";

        /// <summary>
        /// S3SLCM.
        /// </summary>
        public const string S3SLCM = "S3SLCM";

        /// <summary>
        /// S3FCA.
        /// </summary>
        public const string S3FCA = "S3FCA";

        /// <summary>
        /// S3APUN.
        /// </summary>
        public const string S3APUN = "S3APUN";

        /// <summary>
        /// S3CCTY.
        /// </summary>
        public const string S3CCTY = "S3CCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42160Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S3EDUS", "S3EDUS", JdeDataType.String, 20, true, true),
        new JdeField("S3EDBT", "S3EDBT", JdeDataType.String, 30, true, true),
        new JdeField("S3EDTN", "S3EDTN", JdeDataType.String, 44, true, true),
        new JdeField("S3EDLN", "S3EDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("S3EDCT", "S3EDCT", JdeDataType.String, 4),
        new JdeField("S3EDFT", "S3EDFT", JdeDataType.String, 20),
        new JdeField("S3EDDT", "S3EDDT", JdeDataType.Numeric),
        new JdeField("S3EDDL", "S3EDDL", JdeDataType.Numeric),
        new JdeField("S3EDSP", "S3EDSP", JdeDataType.String, 2),
        new JdeField("S3DOCO", "S3DOCO", JdeDataType.Numeric),
        new JdeField("S3DCTO", "S3DCTO", JdeDataType.String, 4),
        new JdeField("S3KCOO", "S3KCOO", JdeDataType.String, 10),
        new JdeField("S3SFXO", "S3SFXO", JdeDataType.String, 6),
        new JdeField("S3LNID", "S3LNID", JdeDataType.Numeric),
        new JdeField("S3CMLN", "S3CMLN", JdeDataType.Numeric),
        new JdeField("S3SLSM", "S3SLSM", JdeDataType.Numeric),
        new JdeField("S3SLCM", "S3SLCM", JdeDataType.Numeric),
        new JdeField("S3FCA", "S3FCA", JdeDataType.Numeric),
        new JdeField("S3APUN", "S3APUN", JdeDataType.Numeric),
        new JdeField("S3CCTY", "S3CCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42160Z1_0", "Primary Key on S3EDUS, S3EDBT, S3EDTN, S3EDLN", new[] { "S3EDUS", "S3EDBT", "S3EDTN", "S3EDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42160Z1_2", "Index on S3DOCO, S3DCTO, S3KCOO, S3EDUS, S3LNID", new[] { "S3DOCO", "S3DCTO", "S3KCOO", "S3EDUS", "S3LNID" }),
        new JdeIndex("F42160Z1_3", "Index on S3DOCO, S3DCTO, S3KCOO, S3LNID, S3EDUS", new[] { "S3DOCO", "S3DCTO", "S3KCOO", "S3LNID", "S3EDUS" })
    };
}
