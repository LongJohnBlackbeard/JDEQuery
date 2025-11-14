using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0118 - .
/// </summary>
public class F0118 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A7UKID.
        /// </summary>
        public const string A7UKID = "A7UKID";

        /// <summary>
        /// A7ADDZ.
        /// </summary>
        public const string A7ADDZ = "A7ADDZ";

        /// <summary>
        /// A7ADD1.
        /// </summary>
        public const string A7ADD1 = "A7ADD1";

        /// <summary>
        /// A7ADD2.
        /// </summary>
        public const string A7ADD2 = "A7ADD2";

        /// <summary>
        /// A7ADD3.
        /// </summary>
        public const string A7ADD3 = "A7ADD3";

        /// <summary>
        /// A7ADD4.
        /// </summary>
        public const string A7ADD4 = "A7ADD4";

        /// <summary>
        /// A7USER.
        /// </summary>
        public const string A7USER = "A7USER";

        /// <summary>
        /// A7PID.
        /// </summary>
        public const string A7PID = "A7PID";

        /// <summary>
        /// A7UPMJ.
        /// </summary>
        public const string A7UPMJ = "A7UPMJ";

        /// <summary>
        /// A7UPMT.
        /// </summary>
        public const string A7UPMT = "A7UPMT";

        /// <summary>
        /// A7MKEY.
        /// </summary>
        public const string A7MKEY = "A7MKEY";

        /// <summary>
        /// A7CTY1.
        /// </summary>
        public const string A7CTY1 = "A7CTY1";

        /// <summary>
        /// A7COUN.
        /// </summary>
        public const string A7COUN = "A7COUN";
    }

    /// <inheritdoc />
    public override string TableName => "F0118";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A7UKID", "A7UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("A7ADDZ", "A7ADDZ", JdeDataType.String, 24),
        new JdeField("A7ADD1", "A7ADD1", JdeDataType.String, 80),
        new JdeField("A7ADD2", "A7ADD2", JdeDataType.String, 80),
        new JdeField("A7ADD3", "A7ADD3", JdeDataType.String, 80),
        new JdeField("A7ADD4", "A7ADD4", JdeDataType.String, 80),
        new JdeField("A7USER", "A7USER", JdeDataType.String, 20),
        new JdeField("A7PID", "A7PID", JdeDataType.String, 20),
        new JdeField("A7UPMJ", "A7UPMJ", JdeDataType.Numeric),
        new JdeField("A7UPMT", "A7UPMT", JdeDataType.Numeric),
        new JdeField("A7MKEY", "A7MKEY", JdeDataType.String, 30),
        new JdeField("A7CTY1", "A7CTY1", JdeDataType.String, 50),
        new JdeField("A7COUN", "A7COUN", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0118_0", "Primary Key on A7UKID", new[] { "A7UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0118_2", "Index on A7ADDZ, A7CTY1, A7COUN", new[] { "A7ADDZ", "A7CTY1", "A7COUN" })
    };
}
