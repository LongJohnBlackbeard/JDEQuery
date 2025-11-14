using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A405 - .
/// </summary>
public class F76A405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEAN8.
        /// </summary>
        public const string SEAN8 = "SEAN8";

        /// <summary>
        /// SECO.
        /// </summary>
        public const string SECO = "SECO";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEJOBN.
        /// </summary>
        public const string SEJOBN = "SEJOBN";

        /// <summary>
        /// SEUPMJ.
        /// </summary>
        public const string SEUPMJ = "SEUPMJ";

        /// <summary>
        /// SEUPMT.
        /// </summary>
        public const string SEUPMT = "SEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEAN8", "SEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SECO", "SECO", JdeDataType.String, 10, true, true),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A405_0", "Primary Key on SEAN8, SECO", new[] { "SEAN8", "SECO" }, isUnique: true, isPrimaryKey: true)
    };
}
