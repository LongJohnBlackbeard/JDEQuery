using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40082 - .
/// </summary>
public class F40082 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACCO.
        /// </summary>
        public const string ACCO = "ACCO";

        /// <summary>
        /// ACTXA1.
        /// </summary>
        public const string ACTXA1 = "ACTXA1";

        /// <summary>
        /// ACEUTXACTR.
        /// </summary>
        public const string ACEUTXACTR = "ACEUTXACTR";

        /// <summary>
        /// ACUSER.
        /// </summary>
        public const string ACUSER = "ACUSER";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";

        /// <summary>
        /// ACUPMJ.
        /// </summary>
        public const string ACUPMJ = "ACUPMJ";

        /// <summary>
        /// ACUPMT.
        /// </summary>
        public const string ACUPMT = "ACUPMT";

        /// <summary>
        /// ACJOBN.
        /// </summary>
        public const string ACJOBN = "ACJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F40082";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACCO", "ACCO", JdeDataType.String, 10, true, true),
        new JdeField("ACTXA1", "ACTXA1", JdeDataType.String, 20, true, true),
        new JdeField("ACEUTXACTR", "ACEUTXACTR", JdeDataType.String, 6),
        new JdeField("ACUSER", "ACUSER", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20),
        new JdeField("ACUPMJ", "ACUPMJ", JdeDataType.Numeric),
        new JdeField("ACUPMT", "ACUPMT", JdeDataType.Numeric),
        new JdeField("ACJOBN", "ACJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40082_0", "Primary Key on ACCO, ACTXA1", new[] { "ACCO", "ACTXA1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40082_2", "Index on ACEUTXACTR", new[] { "ACEUTXACTR" })
    };
}
