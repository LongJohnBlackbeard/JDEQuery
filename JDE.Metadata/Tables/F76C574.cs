using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C574 - .
/// </summary>
public class F76C574 : JdeTable
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
        /// R2JELN.
        /// </summary>
        public const string R2JELN = "R2JELN";

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
        /// R2C76JCA.
        /// </summary>
        public const string R2C76JCA = "R2C76JCA";

        /// <summary>
        /// R2C76PRF.
        /// </summary>
        public const string R2C76PRF = "R2C76PRF";

        /// <summary>
        /// R2C76FT1.
        /// </summary>
        public const string R2C76FT1 = "R2C76FT1";

        /// <summary>
        /// R2DOC.
        /// </summary>
        public const string R2DOC = "R2DOC";

        /// <summary>
        /// R2CAEC.
        /// </summary>
        public const string R2CAEC = "R2CAEC";

        /// <summary>
        /// R2C76MPO.
        /// </summary>
        public const string R2C76MPO = "R2C76MPO";

        /// <summary>
        /// R2C76DIR.
        /// </summary>
        public const string R2C76DIR = "R2C76DIR";

        /// <summary>
        /// R2C76JCB.
        /// </summary>
        public const string R2C76JCB = "R2C76JCB";

        /// <summary>
        /// R2C76JCI.
        /// </summary>
        public const string R2C76JCI = "R2C76JCI";

        /// <summary>
        /// R2TAXC.
        /// </summary>
        public const string R2TAXC = "R2TAXC";
    }

    /// <inheritdoc />
    public override string TableName => "F76C574";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R2EF11", "R2EF11", JdeDataType.Numeric),
        new JdeField("R2JELN", "R2JELN", JdeDataType.Numeric, null, true, true),
        new JdeField("R2C76RT", "R2C76RT", JdeDataType.String, 6, true, true),
        new JdeField("R2C76JCS", "R2C76JCS", JdeDataType.String, 6, true, true),
        new JdeField("R2C76JCN", "R2C76JCN", JdeDataType.Numeric),
        new JdeField("R2C76JCD", "R2C76JCD", JdeDataType.String, 2),
        new JdeField("R2C76JCA", "R2C76JCA", JdeDataType.String, 120),
        new JdeField("R2C76PRF", "R2C76PRF", JdeDataType.String, 18),
        new JdeField("R2C76FT1", "R2C76FT1", JdeDataType.Numeric),
        new JdeField("R2DOC", "R2DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("R2CAEC", "R2CAEC", JdeDataType.Numeric),
        new JdeField("R2C76MPO", "R2C76MPO", JdeDataType.Numeric),
        new JdeField("R2C76DIR", "R2C76DIR", JdeDataType.String, 80),
        new JdeField("R2C76JCB", "R2C76JCB", JdeDataType.Numeric),
        new JdeField("R2C76JCI", "R2C76JCI", JdeDataType.Numeric),
        new JdeField("R2TAXC", "R2TAXC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C574_0", "Primary Key on R2JELN, R2DOC, R2C76RT, R2C76JCS", new[] { "R2JELN", "R2DOC", "R2C76RT", "R2C76JCS" }, isUnique: true, isPrimaryKey: true)
    };
}
