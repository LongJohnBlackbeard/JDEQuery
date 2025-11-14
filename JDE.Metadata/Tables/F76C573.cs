using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C573 - .
/// </summary>
public class F76C573 : JdeTable
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
        /// R2C76NOE.
        /// </summary>
        public const string R2C76NOE = "R2C76NOE";

        /// <summary>
        /// R2C76DIR.
        /// </summary>
        public const string R2C76DIR = "R2C76DIR";

        /// <summary>
        /// R2C76MPO.
        /// </summary>
        public const string R2C76MPO = "R2C76MPO";

        /// <summary>
        /// R2C76JCB.
        /// </summary>
        public const string R2C76JCB = "R2C76JCB";

        /// <summary>
        /// R2C76TPF.
        /// </summary>
        public const string R2C76TPF = "R2C76TPF";

        /// <summary>
        /// R2C76PRF.
        /// </summary>
        public const string R2C76PRF = "R2C76PRF";

        /// <summary>
        /// R2C76FT1.
        /// </summary>
        public const string R2C76FT1 = "R2C76FT1";

        /// <summary>
        /// R2C76FT2.
        /// </summary>
        public const string R2C76FT2 = "R2C76FT2";
    }

    /// <inheritdoc />
    public override string TableName => "F76C573";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R2EF11", "R2EF11", JdeDataType.Numeric),
        new JdeField("R2C76RT", "R2C76RT", JdeDataType.String, 6, true, true),
        new JdeField("R2C76JCS", "R2C76JCS", JdeDataType.String, 6, true, true),
        new JdeField("R2C76NOE", "R2C76NOE", JdeDataType.String, 30),
        new JdeField("R2C76DIR", "R2C76DIR", JdeDataType.String, 80),
        new JdeField("R2C76MPO", "R2C76MPO", JdeDataType.Numeric),
        new JdeField("R2C76JCB", "R2C76JCB", JdeDataType.Numeric),
        new JdeField("R2C76TPF", "R2C76TPF", JdeDataType.Numeric),
        new JdeField("R2C76PRF", "R2C76PRF", JdeDataType.String, 18, true, true),
        new JdeField("R2C76FT1", "R2C76FT1", JdeDataType.Numeric, null, true, true),
        new JdeField("R2C76FT2", "R2C76FT2", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C573_0", "Primary Key on R2C76RT, R2C76JCS, R2C76PRF, R2C76FT1, R2C76FT2", new[] { "R2C76RT", "R2C76JCS", "R2C76PRF", "R2C76FT1", "R2C76FT2" }, isUnique: true, isPrimaryKey: true)
    };
}
