using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060117A - .
/// </summary>
public class F060117A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YAAN8.
        /// </summary>
        public const string YAAN8 = "YAAN8";

        /// <summary>
        /// YAALRN15.
        /// </summary>
        public const string YAALRN15 = "YAALRN15";

        /// <summary>
        /// YAUSER.
        /// </summary>
        public const string YAUSER = "YAUSER";

        /// <summary>
        /// YAPID.
        /// </summary>
        public const string YAPID = "YAPID";

        /// <summary>
        /// YAJOBN.
        /// </summary>
        public const string YAJOBN = "YAJOBN";

        /// <summary>
        /// YAUPMJ.
        /// </summary>
        public const string YAUPMJ = "YAUPMJ";

        /// <summary>
        /// YAUPMT.
        /// </summary>
        public const string YAUPMT = "YAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F060117A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YAAN8", "YAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YAALRN15", "YAALRN15", JdeDataType.String, 30),
        new JdeField("YAUSER", "YAUSER", JdeDataType.String, 20),
        new JdeField("YAPID", "YAPID", JdeDataType.String, 20),
        new JdeField("YAJOBN", "YAJOBN", JdeDataType.String, 20),
        new JdeField("YAUPMJ", "YAUPMJ", JdeDataType.Numeric),
        new JdeField("YAUPMT", "YAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060117A_0", "Primary Key on YAAN8", new[] { "YAAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
