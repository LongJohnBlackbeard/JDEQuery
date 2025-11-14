using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0117 - .
/// </summary>
public class F0117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A8ADDZ.
        /// </summary>
        public const string A8ADDZ = "A8ADDZ";

        /// <summary>
        /// A8ADDS.
        /// </summary>
        public const string A8ADDS = "A8ADDS";

        /// <summary>
        /// A8CTY1.
        /// </summary>
        public const string A8CTY1 = "A8CTY1";

        /// <summary>
        /// A8COUN.
        /// </summary>
        public const string A8COUN = "A8COUN";

        /// <summary>
        /// A8CTR.
        /// </summary>
        public const string A8CTR = "A8CTR";

        /// <summary>
        /// A8CRTE.
        /// </summary>
        public const string A8CRTE = "A8CRTE";

        /// <summary>
        /// A8BKML.
        /// </summary>
        public const string A8BKML = "A8BKML";

        /// <summary>
        /// A8ADZ1.
        /// </summary>
        public const string A8ADZ1 = "A8ADZ1";

        /// <summary>
        /// A8USER.
        /// </summary>
        public const string A8USER = "A8USER";

        /// <summary>
        /// A8PID.
        /// </summary>
        public const string A8PID = "A8PID";

        /// <summary>
        /// A8UPMJ.
        /// </summary>
        public const string A8UPMJ = "A8UPMJ";

        /// <summary>
        /// A8UPMT.
        /// </summary>
        public const string A8UPMT = "A8UPMT";

        /// <summary>
        /// A8MKEY.
        /// </summary>
        public const string A8MKEY = "A8MKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F0117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A8ADDZ", "A8ADDZ", JdeDataType.String, 24, true, true),
        new JdeField("A8ADDS", "A8ADDS", JdeDataType.String, 6),
        new JdeField("A8CTY1", "A8CTY1", JdeDataType.String, 50, true, true),
        new JdeField("A8COUN", "A8COUN", JdeDataType.String, 50, true, true),
        new JdeField("A8CTR", "A8CTR", JdeDataType.String, 6),
        new JdeField("A8CRTE", "A8CRTE", JdeDataType.String, 8),
        new JdeField("A8BKML", "A8BKML", JdeDataType.String, 4),
        new JdeField("A8ADZ1", "A8ADZ1", JdeDataType.String, 24),
        new JdeField("A8USER", "A8USER", JdeDataType.String, 20),
        new JdeField("A8PID", "A8PID", JdeDataType.String, 20),
        new JdeField("A8UPMJ", "A8UPMJ", JdeDataType.Numeric),
        new JdeField("A8UPMT", "A8UPMT", JdeDataType.Numeric),
        new JdeField("A8MKEY", "A8MKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0117_0", "Primary Key on A8ADDZ, A8CTY1, A8COUN", new[] { "A8ADDZ", "A8CTY1", "A8COUN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0117_2", "Index on A8ADDZ", new[] { "A8ADDZ" }),
        new JdeIndex("F0117_3", "Index on A8CTY1, A8ADDS", new[] { "A8CTY1", "A8ADDS" })
    };
}
