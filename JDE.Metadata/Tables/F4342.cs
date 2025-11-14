using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4342 - .
/// </summary>
public class F4342 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RKAN8.
        /// </summary>
        public const string RKAN8 = "RKAN8";

        /// <summary>
        /// RKAGSQ.
        /// </summary>
        public const string RKAGSQ = "RKAGSQ";

        /// <summary>
        /// RKITM.
        /// </summary>
        public const string RKITM = "RKITM";

        /// <summary>
        /// RKMCU.
        /// </summary>
        public const string RKMCU = "RKMCU";

        /// <summary>
        /// RKOBJ.
        /// </summary>
        public const string RKOBJ = "RKOBJ";

        /// <summary>
        /// RKSUB.
        /// </summary>
        public const string RKSUB = "RKSUB";

        /// <summary>
        /// RKPDP.
        /// </summary>
        public const string RKPDP = "RKPDP";
    }

    /// <inheritdoc />
    public override string TableName => "F4342";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RKAN8", "RKAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RKAGSQ", "RKAGSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RKITM", "RKITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RKMCU", "RKMCU", JdeDataType.String, 24, true, true),
        new JdeField("RKOBJ", "RKOBJ", JdeDataType.String, 12, true, true),
        new JdeField("RKSUB", "RKSUB", JdeDataType.String, 16, true, true),
        new JdeField("RKPDP", "RKPDP", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4342_0", "Primary Key on RKAN8, RKAGSQ, RKITM, RKMCU, RKOBJ, RKSUB, RKPDP", new[] { "RKAN8", "RKAGSQ", "RKITM", "RKMCU", "RKOBJ", "RKSUB", "RKPDP" }, isUnique: true, isPrimaryKey: true)
    };
}
