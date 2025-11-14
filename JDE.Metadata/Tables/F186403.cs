using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186403 - .
/// </summary>
public class F186403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OALRSORID.
        /// </summary>
        public const string OALRSORID = "OALRSORID";

        /// <summary>
        /// OALRSOAP.
        /// </summary>
        public const string OALRSOAP = "OALRSOAP";

        /// <summary>
        /// OALRSOH.
        /// </summary>
        public const string OALRSOH = "OALRSOH";

        /// <summary>
        /// OALRSOCTM.
        /// </summary>
        public const string OALRSOCTM = "OALRSOCTM";

        /// <summary>
        /// OALRSNPTF.
        /// </summary>
        public const string OALRSNPTF = "OALRSNPTF";

        /// <summary>
        /// OALRSNPT.
        /// </summary>
        public const string OALRSNPT = "OALRSNPT";

        /// <summary>
        /// OALRSNHRF.
        /// </summary>
        public const string OALRSNHRF = "OALRSNHRF";

        /// <summary>
        /// OALRSNHRZ.
        /// </summary>
        public const string OALRSNHRZ = "OALRSNHRZ";

        /// <summary>
        /// OALRSPTIF.
        /// </summary>
        public const string OALRSPTIF = "OALRSPTIF";

        /// <summary>
        /// OAUSER.
        /// </summary>
        public const string OAUSER = "OAUSER";

        /// <summary>
        /// OAPID.
        /// </summary>
        public const string OAPID = "OAPID";

        /// <summary>
        /// OAJOBN.
        /// </summary>
        public const string OAJOBN = "OAJOBN";

        /// <summary>
        /// OAUPMJ.
        /// </summary>
        public const string OAUPMJ = "OAUPMJ";

        /// <summary>
        /// OATDAY.
        /// </summary>
        public const string OATDAY = "OATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F186403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OALRSORID", "OALRSORID", JdeDataType.Numeric, null, true, true),
        new JdeField("OALRSOAP", "OALRSOAP", JdeDataType.Numeric),
        new JdeField("OALRSOH", "OALRSOH", JdeDataType.Numeric),
        new JdeField("OALRSOCTM", "OALRSOCTM", JdeDataType.String, 20),
        new JdeField("OALRSNPTF", "OALRSNPTF", JdeDataType.String, 2),
        new JdeField("OALRSNPT", "OALRSNPT", JdeDataType.Numeric),
        new JdeField("OALRSNHRF", "OALRSNHRF", JdeDataType.String, 2),
        new JdeField("OALRSNHRZ", "OALRSNHRZ", JdeDataType.String, 510),
        new JdeField("OALRSPTIF", "OALRSPTIF", JdeDataType.String, 2),
        new JdeField("OAUSER", "OAUSER", JdeDataType.String, 20),
        new JdeField("OAPID", "OAPID", JdeDataType.String, 20),
        new JdeField("OAJOBN", "OAJOBN", JdeDataType.String, 20),
        new JdeField("OAUPMJ", "OAUPMJ", JdeDataType.Numeric),
        new JdeField("OATDAY", "OATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186403_0", "Primary Key on OALRSORID", new[] { "OALRSORID" }, isUnique: true, isPrimaryKey: true)
    };
}
