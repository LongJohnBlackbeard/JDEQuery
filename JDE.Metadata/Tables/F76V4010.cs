using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4010 - .
/// </summary>
public class F76V4010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISCO.
        /// </summary>
        public const string ISCO = "ISCO";

        /// <summary>
        /// ISEFFF.
        /// </summary>
        public const string ISEFFF = "ISEFFF";

        /// <summary>
        /// ISEFFT.
        /// </summary>
        public const string ISEFFT = "ISEFFT";

        /// <summary>
        /// ISAA.
        /// </summary>
        public const string ISAA = "ISAA";

        /// <summary>
        /// ISUSER.
        /// </summary>
        public const string ISUSER = "ISUSER";

        /// <summary>
        /// ISPID.
        /// </summary>
        public const string ISPID = "ISPID";

        /// <summary>
        /// ISJOBN.
        /// </summary>
        public const string ISJOBN = "ISJOBN";

        /// <summary>
        /// ISUPMJ.
        /// </summary>
        public const string ISUPMJ = "ISUPMJ";

        /// <summary>
        /// ISUPMT.
        /// </summary>
        public const string ISUPMT = "ISUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISCO", "ISCO", JdeDataType.String, 10, true, true),
        new JdeField("ISEFFF", "ISEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("ISEFFT", "ISEFFT", JdeDataType.Numeric, null, true, true),
        new JdeField("ISAA", "ISAA", JdeDataType.Numeric),
        new JdeField("ISUSER", "ISUSER", JdeDataType.String, 20),
        new JdeField("ISPID", "ISPID", JdeDataType.String, 20),
        new JdeField("ISJOBN", "ISJOBN", JdeDataType.String, 20),
        new JdeField("ISUPMJ", "ISUPMJ", JdeDataType.Numeric),
        new JdeField("ISUPMT", "ISUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4010_0", "Primary Key on ISCO, ISEFFF, ISEFFT", new[] { "ISCO", "ISEFFF", "ISEFFT" }, isUnique: true, isPrimaryKey: true)
    };
}
