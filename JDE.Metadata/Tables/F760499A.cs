using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F760499A - .
/// </summary>
public class F760499A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K8PST.
        /// </summary>
        public const string K8PST = "K8PST";

        /// <summary>
        /// K8AN8.
        /// </summary>
        public const string K8AN8 = "K8AN8";

        /// <summary>
        /// K8DMTJ.
        /// </summary>
        public const string K8DMTJ = "K8DMTJ";

        /// <summary>
        /// K8DOC.
        /// </summary>
        public const string K8DOC = "K8DOC";

        /// <summary>
        /// K8AA.
        /// </summary>
        public const string K8AA = "K8AA";

        /// <summary>
        /// K8DCTM.
        /// </summary>
        public const string K8DCTM = "K8DCTM";

        /// <summary>
        /// K8DOCM.
        /// </summary>
        public const string K8DOCM = "K8DOCM";

        /// <summary>
        /// K8AID.
        /// </summary>
        public const string K8AID = "K8AID";

        /// <summary>
        /// K8A007.
        /// </summary>
        public const string K8A007 = "K8A007";

        /// <summary>
        /// K8SFX.
        /// </summary>
        public const string K8SFX = "K8SFX";

        /// <summary>
        /// K8HDC.
        /// </summary>
        public const string K8HDC = "K8HDC";

        /// <summary>
        /// K8CKC.
        /// </summary>
        public const string K8CKC = "K8CKC";

        /// <summary>
        /// K8DORE.
        /// </summary>
        public const string K8DORE = "K8DORE";

        /// <summary>
        /// K8CO.
        /// </summary>
        public const string K8CO = "K8CO";
    }

    /// <inheritdoc />
    public override string TableName => "F760499A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K8PST", "K8PST", JdeDataType.String, 2, true, true),
        new JdeField("K8AN8", "K8AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("K8DMTJ", "K8DMTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("K8DOC", "K8DOC", JdeDataType.Numeric),
        new JdeField("K8AA", "K8AA", JdeDataType.Numeric),
        new JdeField("K8DCTM", "K8DCTM", JdeDataType.String, 4),
        new JdeField("K8DOCM", "K8DOCM", JdeDataType.Numeric),
        new JdeField("K8AID", "K8AID", JdeDataType.String, 16),
        new JdeField("K8A007", "K8A007", JdeDataType.String, 6, true, true),
        new JdeField("K8SFX", "K8SFX", JdeDataType.String, 6, true, true),
        new JdeField("K8HDC", "K8HDC", JdeDataType.Numeric),
        new JdeField("K8CKC", "K8CKC", JdeDataType.Numeric),
        new JdeField("K8DORE", "K8DORE", JdeDataType.Numeric, null, true, true),
        new JdeField("K8CO", "K8CO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F760499A_0", "Primary Key on K8CO, K8PST, K8AN8, K8DMTJ, K8DORE, K8A007, K8SFX", new[] { "K8CO", "K8PST", "K8AN8", "K8DMTJ", "K8DORE", "K8A007", "K8SFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F760499A_2", "Index on K8DCTM, K8DOCM, K8AID, K8A007, K8AN8", new[] { "K8DCTM", "K8DOCM", "K8AID", "K8A007", "K8AN8" }),
        new JdeIndex("F760499A_3", "Index on K8PST, K8AN8, K8DCTM, K8DOCM, K8AID", new[] { "K8PST", "K8AN8", "K8DCTM", "K8DOCM", "K8AID" })
    };
}
