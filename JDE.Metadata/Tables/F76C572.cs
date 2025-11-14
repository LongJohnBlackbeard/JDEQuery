using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C572 - .
/// </summary>
public class F76C572 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R2EF11.
        /// </summary>
        public const string R2EF11 = "R2EF11";

        /// <summary>
        /// R2C76RT.
        /// </summary>
        public const string R2C76RT = "R2C76RT";

        /// <summary>
        /// R2C76JCS.
        /// </summary>
        public const string R2C76JCS = "R2C76JCS";

        /// <summary>
        /// R2C76JCN.
        /// </summary>
        public const string R2C76JCN = "R2C76JCN";

        /// <summary>
        /// R2C76JCD.
        /// </summary>
        public const string R2C76JCD = "R2C76JCD";

        /// <summary>
        /// R2TAXC.
        /// </summary>
        public const string R2TAXC = "R2TAXC";

        /// <summary>
        /// R2C76JCA.
        /// </summary>
        public const string R2C76JCA = "R2C76JCA";

        /// <summary>
        /// R2C76JCB.
        /// </summary>
        public const string R2C76JCB = "R2C76JCB";

        /// <summary>
        /// R2C76JCI.
        /// </summary>
        public const string R2C76JCI = "R2C76JCI";

        /// <summary>
        /// R2C76CN1.
        /// </summary>
        public const string R2C76CN1 = "R2C76CN1";

        /// <summary>
        /// R2CBNK.
        /// </summary>
        public const string R2CBNK = "R2CBNK";

        /// <summary>
        /// R2C76DIR.
        /// </summary>
        public const string R2C76DIR = "R2C76DIR";

        /// <summary>
        /// R2C76MPO.
        /// </summary>
        public const string R2C76MPO = "R2C76MPO";
    }

    /// <inheritdoc />
    public override string TableName => "F76C572";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R2EF11", "R2EF11", JdeDataType.Numeric),
        new JdeField("R2C76RT", "R2C76RT", JdeDataType.String, 6, true, true),
        new JdeField("R2C76JCS", "R2C76JCS", JdeDataType.String, 6, true, true),
        new JdeField("R2C76JCN", "R2C76JCN", JdeDataType.Numeric, null, true, true),
        new JdeField("R2C76JCD", "R2C76JCD", JdeDataType.String, 2, true, true),
        new JdeField("R2TAXC", "R2TAXC", JdeDataType.String, 2, true, true),
        new JdeField("R2C76JCA", "R2C76JCA", JdeDataType.String, 120),
        new JdeField("R2C76JCB", "R2C76JCB", JdeDataType.Numeric),
        new JdeField("R2C76JCI", "R2C76JCI", JdeDataType.Numeric),
        new JdeField("R2C76CN1", "R2C76CN1", JdeDataType.Numeric),
        new JdeField("R2CBNK", "R2CBNK", JdeDataType.String, 40, true, true),
        new JdeField("R2C76DIR", "R2C76DIR", JdeDataType.String, 80),
        new JdeField("R2C76MPO", "R2C76MPO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C572_0", "Primary Key on R2CBNK, R2TAXC, R2C76RT, R2C76JCS, R2C76JCN, R2C76JCD", new[] { "R2CBNK", "R2TAXC", "R2C76RT", "R2C76JCS", "R2C76JCN", "R2C76JCD" }, isUnique: true, isPrimaryKey: true)
    };
}
