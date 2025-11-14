using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3406 - .
/// </summary>
public class F3406 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRAN8.
        /// </summary>
        public const string CRAN8 = "CRAN8";

        /// <summary>
        /// CRITM.
        /// </summary>
        public const string CRITM = "CRITM";

        /// <summary>
        /// CRLITM.
        /// </summary>
        public const string CRLITM = "CRLITM";

        /// <summary>
        /// CRAITM.
        /// </summary>
        public const string CRAITM = "CRAITM";

        /// <summary>
        /// CRFCCR.
        /// </summary>
        public const string CRFCCR = "CRFCCR";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRTDAY.
        /// </summary>
        public const string CRTDAY = "CRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3406";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRAN8", "CRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CRITM", "CRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CRLITM", "CRLITM", JdeDataType.String, 50),
        new JdeField("CRAITM", "CRAITM", JdeDataType.String, 50),
        new JdeField("CRFCCR", "CRFCCR", JdeDataType.String, 2),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRTDAY", "CRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3406_0", "Primary Key on CRAN8, CRITM", new[] { "CRAN8", "CRITM" }, isUnique: true, isPrimaryKey: true)
    };
}
