using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05430 - .
/// </summary>
public class F05430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UTEECD.
        /// </summary>
        public const string UTEECD = "UTEECD";

        /// <summary>
        /// UTDIVC.
        /// </summary>
        public const string UTDIVC = "UTDIVC";

        /// <summary>
        /// UTCO.
        /// </summary>
        public const string UTCO = "UTCO";

        /// <summary>
        /// UTCCPR.
        /// </summary>
        public const string UTCCPR = "UTCCPR";

        /// <summary>
        /// UTLNGP.
        /// </summary>
        public const string UTLNGP = "UTLNGP";

        /// <summary>
        /// UTOBNM.
        /// </summary>
        public const string UTOBNM = "UTOBNM";

        /// <summary>
        /// UTVTEXT.
        /// </summary>
        public const string UTVTEXT = "UTVTEXT";

        /// <summary>
        /// UTUSER.
        /// </summary>
        public const string UTUSER = "UTUSER";

        /// <summary>
        /// UTUPMJ.
        /// </summary>
        public const string UTUPMJ = "UTUPMJ";

        /// <summary>
        /// UTUPMT.
        /// </summary>
        public const string UTUPMT = "UTUPMT";

        /// <summary>
        /// UTJOBN.
        /// </summary>
        public const string UTJOBN = "UTJOBN";

        /// <summary>
        /// UTPID.
        /// </summary>
        public const string UTPID = "UTPID";
    }

    /// <inheritdoc />
    public override string TableName => "F05430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UTEECD", "UTEECD", JdeDataType.String, 6, true, true),
        new JdeField("UTDIVC", "UTDIVC", JdeDataType.String, 12, true, true),
        new JdeField("UTCO", "UTCO", JdeDataType.String, 10, true, true),
        new JdeField("UTCCPR", "UTCCPR", JdeDataType.String, 6, true, true),
        new JdeField("UTLNGP", "UTLNGP", JdeDataType.String, 4, true, true),
        new JdeField("UTOBNM", "UTOBNM", JdeDataType.String, 20, true, true),
        new JdeField("UTVTEXT", "UTVTEXT", JdeDataType.String, 2000),
        new JdeField("UTUSER", "UTUSER", JdeDataType.String, 20),
        new JdeField("UTUPMJ", "UTUPMJ", JdeDataType.Numeric),
        new JdeField("UTUPMT", "UTUPMT", JdeDataType.Numeric),
        new JdeField("UTJOBN", "UTJOBN", JdeDataType.String, 20),
        new JdeField("UTPID", "UTPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05430_0", "Primary Key on UTEECD, UTDIVC, UTCO, UTCCPR, UTLNGP, UTOBNM", new[] { "UTEECD", "UTDIVC", "UTCO", "UTCCPR", "UTLNGP", "UTOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
