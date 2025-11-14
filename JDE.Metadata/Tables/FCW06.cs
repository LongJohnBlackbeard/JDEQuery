using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW06 - .
/// </summary>
public class FCW06 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHC9COLL.
        /// </summary>
        public const string CHC9COLL = "CHC9COLL";

        /// <summary>
        /// CHC9SEAC.
        /// </summary>
        public const string CHC9SEAC = "CHC9SEAC";

        /// <summary>
        /// CHC9SEAY.
        /// </summary>
        public const string CHC9SEAY = "CHC9SEAY";

        /// <summary>
        /// CHC9DSC1.
        /// </summary>
        public const string CHC9DSC1 = "CHC9DSC1";

        /// <summary>
        /// CHC9CST.
        /// </summary>
        public const string CHC9CST = "CHC9CST";

        /// <summary>
        /// CHC9PRDJ.
        /// </summary>
        public const string CHC9PRDJ = "CHC9PRDJ";

        /// <summary>
        /// CHC9RFDJ1.
        /// </summary>
        public const string CHC9RFDJ1 = "CHC9RFDJ1";

        /// <summary>
        /// CHC9EADJ1.
        /// </summary>
        public const string CHC9EADJ1 = "CHC9EADJ1";

        /// <summary>
        /// CHC9LTDJ1.
        /// </summary>
        public const string CHC9LTDJ1 = "CHC9LTDJ1";

        /// <summary>
        /// CHC9RFDJ2.
        /// </summary>
        public const string CHC9RFDJ2 = "CHC9RFDJ2";

        /// <summary>
        /// CHC9EADJ2.
        /// </summary>
        public const string CHC9EADJ2 = "CHC9EADJ2";

        /// <summary>
        /// CHC9LTDJ2.
        /// </summary>
        public const string CHC9LTDJ2 = "CHC9LTDJ2";

        /// <summary>
        /// CHC9RFDJ3.
        /// </summary>
        public const string CHC9RFDJ3 = "CHC9RFDJ3";

        /// <summary>
        /// CHC9EADJ3.
        /// </summary>
        public const string CHC9EADJ3 = "CHC9EADJ3";

        /// <summary>
        /// CHC9LTDJ3.
        /// </summary>
        public const string CHC9LTDJ3 = "CHC9LTDJ3";

        /// <summary>
        /// CHC9RFDJ4.
        /// </summary>
        public const string CHC9RFDJ4 = "CHC9RFDJ4";

        /// <summary>
        /// CHC9EADJ4.
        /// </summary>
        public const string CHC9EADJ4 = "CHC9EADJ4";

        /// <summary>
        /// CHC9LTDJ4.
        /// </summary>
        public const string CHC9LTDJ4 = "CHC9LTDJ4";

        /// <summary>
        /// CHC9RFDJ5.
        /// </summary>
        public const string CHC9RFDJ5 = "CHC9RFDJ5";

        /// <summary>
        /// CHC9EADJ5.
        /// </summary>
        public const string CHC9EADJ5 = "CHC9EADJ5";

        /// <summary>
        /// CHC9LTDJ5.
        /// </summary>
        public const string CHC9LTDJ5 = "CHC9LTDJ5";
    }

    /// <inheritdoc />
    public override string TableName => "FCW06";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHC9COLL", "CHC9COLL", JdeDataType.String, 20, true, true),
        new JdeField("CHC9SEAC", "CHC9SEAC", JdeDataType.String, 4, true, true),
        new JdeField("CHC9SEAY", "CHC9SEAY", JdeDataType.String, 8, true, true),
        new JdeField("CHC9DSC1", "CHC9DSC1", JdeDataType.String, 60),
        new JdeField("CHC9CST", "CHC9CST", JdeDataType.String, 6),
        new JdeField("CHC9PRDJ", "CHC9PRDJ", JdeDataType.Numeric),
        new JdeField("CHC9RFDJ1", "CHC9RFDJ1", JdeDataType.Numeric),
        new JdeField("CHC9EADJ1", "CHC9EADJ1", JdeDataType.Numeric),
        new JdeField("CHC9LTDJ1", "CHC9LTDJ1", JdeDataType.Numeric),
        new JdeField("CHC9RFDJ2", "CHC9RFDJ2", JdeDataType.Numeric),
        new JdeField("CHC9EADJ2", "CHC9EADJ2", JdeDataType.Numeric),
        new JdeField("CHC9LTDJ2", "CHC9LTDJ2", JdeDataType.Numeric),
        new JdeField("CHC9RFDJ3", "CHC9RFDJ3", JdeDataType.Numeric),
        new JdeField("CHC9EADJ3", "CHC9EADJ3", JdeDataType.Numeric),
        new JdeField("CHC9LTDJ3", "CHC9LTDJ3", JdeDataType.Numeric),
        new JdeField("CHC9RFDJ4", "CHC9RFDJ4", JdeDataType.Numeric),
        new JdeField("CHC9EADJ4", "CHC9EADJ4", JdeDataType.Numeric),
        new JdeField("CHC9LTDJ4", "CHC9LTDJ4", JdeDataType.Numeric),
        new JdeField("CHC9RFDJ5", "CHC9RFDJ5", JdeDataType.Numeric),
        new JdeField("CHC9EADJ5", "CHC9EADJ5", JdeDataType.Numeric),
        new JdeField("CHC9LTDJ5", "CHC9LTDJ5", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW06_0", "Primary Key on CHC9COLL, CHC9SEAC, CHC9SEAY", new[] { "CHC9COLL", "CHC9SEAC", "CHC9SEAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW06_2", "Index on CHC9COLL, CHC9CST", new[] { "CHC9COLL", "CHC9CST" })
    };
}
