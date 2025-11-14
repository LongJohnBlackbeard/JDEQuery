using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C577 - .
/// </summary>
public class F76C577 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCTR06.
        /// </summary>
        public const string CMCTR06 = "CMCTR06";

        /// <summary>
        /// CMC76RT.
        /// </summary>
        public const string CMC76RT = "CMC76RT";

        /// <summary>
        /// CMC76JCS.
        /// </summary>
        public const string CMC76JCS = "CMC76JCS";

        /// <summary>
        /// CMRT.
        /// </summary>
        public const string CMRT = "CMRT";

        /// <summary>
        /// CMC76JCN.
        /// </summary>
        public const string CMC76JCN = "CMC76JCN";

        /// <summary>
        /// CMC76JCA.
        /// </summary>
        public const string CMC76JCA = "CMC76JCA";

        /// <summary>
        /// CMC76JCB.
        /// </summary>
        public const string CMC76JCB = "CMC76JCB";

        /// <summary>
        /// CMC76JCI.
        /// </summary>
        public const string CMC76JCI = "CMC76JCI";

        /// <summary>
        /// CMC76CN1.
        /// </summary>
        public const string CMC76CN1 = "CMC76CN1";
    }

    /// <inheritdoc />
    public override string TableName => "F76C577";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCTR06", "CMCTR06", JdeDataType.Numeric, null, true, true),
        new JdeField("CMC76RT", "CMC76RT", JdeDataType.String, 6, true, true),
        new JdeField("CMC76JCS", "CMC76JCS", JdeDataType.String, 6, true, true),
        new JdeField("CMRT", "CMRT", JdeDataType.String, 4),
        new JdeField("CMC76JCN", "CMC76JCN", JdeDataType.Numeric),
        new JdeField("CMC76JCA", "CMC76JCA", JdeDataType.String, 120),
        new JdeField("CMC76JCB", "CMC76JCB", JdeDataType.Numeric),
        new JdeField("CMC76JCI", "CMC76JCI", JdeDataType.Numeric),
        new JdeField("CMC76CN1", "CMC76CN1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C577_0", "Primary Key on CMCTR06, CMC76RT, CMC76JCS", new[] { "CMCTR06", "CMC76RT", "CMC76JCS" }, isUnique: true, isPrimaryKey: true)
    };
}
