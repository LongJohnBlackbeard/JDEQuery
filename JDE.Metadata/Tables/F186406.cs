using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186406 - .
/// </summary>
public class F186406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OLLRSORID.
        /// </summary>
        public const string OLLRSORID = "OLLRSORID";

        /// <summary>
        /// OLLRSORSID.
        /// </summary>
        public const string OLLRSORSID = "OLLRSORSID";

        /// <summary>
        /// OLUSER.
        /// </summary>
        public const string OLUSER = "OLUSER";

        /// <summary>
        /// OLPID.
        /// </summary>
        public const string OLPID = "OLPID";

        /// <summary>
        /// OLJOBN.
        /// </summary>
        public const string OLJOBN = "OLJOBN";

        /// <summary>
        /// OLUPMJ.
        /// </summary>
        public const string OLUPMJ = "OLUPMJ";

        /// <summary>
        /// OLTDAY.
        /// </summary>
        public const string OLTDAY = "OLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OLLRSORID", "OLLRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("OLLRSORSID", "OLLRSORSID", JdeDataType.Numeric),
        new JdeField("OLUSER", "OLUSER", JdeDataType.String, 20),
        new JdeField("OLPID", "OLPID", JdeDataType.String, 20),
        new JdeField("OLJOBN", "OLJOBN", JdeDataType.String, 20),
        new JdeField("OLUPMJ", "OLUPMJ", JdeDataType.Numeric),
        new JdeField("OLTDAY", "OLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186406_0", "Primary Key on OLLRSORID", new[] { "OLLRSORID" }, isUnique: true, isPrimaryKey: true)
    };
}
