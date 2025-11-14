using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08591 - .
/// </summary>
public class F08591 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H5ABF.
        /// </summary>
        public const string H5ABF = "H5ABF";

        /// <summary>
        /// H5DL01.
        /// </summary>
        public const string H5DL01 = "H5DL01";

        /// <summary>
        /// H5DC.
        /// </summary>
        public const string H5DC = "H5DC";

        /// <summary>
        /// H5LDBA.
        /// </summary>
        public const string H5LDBA = "H5LDBA";

        /// <summary>
        /// H5UBS.
        /// </summary>
        public const string H5UBS = "H5UBS";

        /// <summary>
        /// H5AAC.
        /// </summary>
        public const string H5AAC = "H5AAC";

        /// <summary>
        /// H5PRG3.
        /// </summary>
        public const string H5PRG3 = "H5PRG3";

        /// <summary>
        /// H5PRG4.
        /// </summary>
        public const string H5PRG4 = "H5PRG4";

        /// <summary>
        /// H5PRG5.
        /// </summary>
        public const string H5PRG5 = "H5PRG5";

        /// <summary>
        /// H5FAPR.
        /// </summary>
        public const string H5FAPR = "H5FAPR";
    }

    /// <inheritdoc />
    public override string TableName => "F08591";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H5ABF", "H5ABF", JdeDataType.Numeric, null, true, true),
        new JdeField("H5DL01", "H5DL01", JdeDataType.String, 60),
        new JdeField("H5DC", "H5DC", JdeDataType.String, 80),
        new JdeField("H5LDBA", "H5LDBA", JdeDataType.Numeric),
        new JdeField("H5UBS", "H5UBS", JdeDataType.String, 2),
        new JdeField("H5AAC", "H5AAC", JdeDataType.String, 2),
        new JdeField("H5PRG3", "H5PRG3", JdeDataType.String, 20),
        new JdeField("H5PRG4", "H5PRG4", JdeDataType.String, 20),
        new JdeField("H5PRG5", "H5PRG5", JdeDataType.String, 20),
        new JdeField("H5FAPR", "H5FAPR", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08591_0", "Primary Key on H5ABF", new[] { "H5ABF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08591_2", "Index on H5DC", new[] { "H5DC" })
    };
}
