using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740001 - .
/// </summary>
public class F740001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SEUKID.
        /// </summary>
        public const string SEUKID = "SEUKID";

        /// <summary>
        /// SEK74SEPA.
        /// </summary>
        public const string SEK74SEPA = "SEK74SEPA";

        /// <summary>
        /// SEUSER.
        /// </summary>
        public const string SEUSER = "SEUSER";

        /// <summary>
        /// SEPID.
        /// </summary>
        public const string SEPID = "SEPID";

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
    public override string TableName => "F740001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SEUKID", "SEUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SEK74SEPA", "SEK74SEPA", JdeDataType.String, 2),
        new JdeField("SEUSER", "SEUSER", JdeDataType.String, 20),
        new JdeField("SEPID", "SEPID", JdeDataType.String, 20),
        new JdeField("SEJOBN", "SEJOBN", JdeDataType.String, 20),
        new JdeField("SEUPMJ", "SEUPMJ", JdeDataType.Numeric),
        new JdeField("SEUPMT", "SEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740001_0", "Primary Key on SEUKID", new[] { "SEUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
