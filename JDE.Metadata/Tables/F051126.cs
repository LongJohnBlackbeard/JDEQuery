using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051126 - .
/// </summary>
public class F051126 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y6ANPA.
        /// </summary>
        public const string Y6ANPA = "Y6ANPA";

        /// <summary>
        /// Y6AN8.
        /// </summary>
        public const string Y6AN8 = "Y6AN8";

        /// <summary>
        /// Y6EFTO.
        /// </summary>
        public const string Y6EFTO = "Y6EFTO";

        /// <summary>
        /// Y6EFTE.
        /// </summary>
        public const string Y6EFTE = "Y6EFTE";

        /// <summary>
        /// Y6ESSDAUT.
        /// </summary>
        public const string Y6ESSDAUT = "Y6ESSDAUT";

        /// <summary>
        /// Y6USER.
        /// </summary>
        public const string Y6USER = "Y6USER";

        /// <summary>
        /// Y6PID.
        /// </summary>
        public const string Y6PID = "Y6PID";

        /// <summary>
        /// Y6JOBN.
        /// </summary>
        public const string Y6JOBN = "Y6JOBN";

        /// <summary>
        /// Y6UPMJ.
        /// </summary>
        public const string Y6UPMJ = "Y6UPMJ";

        /// <summary>
        /// Y6UPMT.
        /// </summary>
        public const string Y6UPMT = "Y6UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051126";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y6ANPA", "Y6ANPA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y6AN8", "Y6AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y6EFTO", "Y6EFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("Y6EFTE", "Y6EFTE", JdeDataType.Numeric),
        new JdeField("Y6ESSDAUT", "Y6ESSDAUT", JdeDataType.String, 2),
        new JdeField("Y6USER", "Y6USER", JdeDataType.String, 20),
        new JdeField("Y6PID", "Y6PID", JdeDataType.String, 20),
        new JdeField("Y6JOBN", "Y6JOBN", JdeDataType.String, 20),
        new JdeField("Y6UPMJ", "Y6UPMJ", JdeDataType.Numeric),
        new JdeField("Y6UPMT", "Y6UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051126_0", "Primary Key on Y6ANPA, Y6AN8, Y6EFTO", new[] { "Y6ANPA", "Y6AN8", "Y6EFTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F051126_2", "Index on Y6AN8, Y6EFTO, Y6EFTE", new[] { "Y6AN8", "Y6EFTO", "Y6EFTE" })
    };
}
