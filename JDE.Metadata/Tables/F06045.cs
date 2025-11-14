using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06045 - .
/// </summary>
public class F06045 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BBDTAI.
        /// </summary>
        public const string BBDTAI = "BBDTAI";

        /// <summary>
        /// BBPHSD.
        /// </summary>
        public const string BBPHSD = "BBPHSD";

        /// <summary>
        /// BBEFDO.
        /// </summary>
        public const string BBEFDO = "BBEFDO";

        /// <summary>
        /// BBTRS.
        /// </summary>
        public const string BBTRS = "BBTRS";

        /// <summary>
        /// BBMETOW.
        /// </summary>
        public const string BBMETOW = "BBMETOW";

        /// <summary>
        /// BBPID.
        /// </summary>
        public const string BBPID = "BBPID";

        /// <summary>
        /// BBUSER.
        /// </summary>
        public const string BBUSER = "BBUSER";

        /// <summary>
        /// BBJOBN.
        /// </summary>
        public const string BBJOBN = "BBJOBN";

        /// <summary>
        /// BBUPMJ.
        /// </summary>
        public const string BBUPMJ = "BBUPMJ";

        /// <summary>
        /// BBRCD#.
        /// </summary>
        public const string BBRCD_ = "BBRCD#";

        /// <summary>
        /// BBUSTT.
        /// </summary>
        public const string BBUSTT = "BBUSTT";

        /// <summary>
        /// BBHSTD.
        /// </summary>
        public const string BBHSTD = "BBHSTD";
    }

    /// <inheritdoc />
    public override string TableName => "F06045";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BBDTAI", "BBDTAI", JdeDataType.String, 20, true, true),
        new JdeField("BBPHSD", "BBPHSD", JdeDataType.String, 60),
        new JdeField("BBEFDO", "BBEFDO", JdeDataType.Numeric),
        new JdeField("BBTRS", "BBTRS", JdeDataType.String, 6),
        new JdeField("BBMETOW", "BBMETOW", JdeDataType.String, 2),
        new JdeField("BBPID", "BBPID", JdeDataType.String, 20),
        new JdeField("BBUSER", "BBUSER", JdeDataType.String, 20),
        new JdeField("BBJOBN", "BBJOBN", JdeDataType.String, 20),
        new JdeField("BBUPMJ", "BBUPMJ", JdeDataType.Numeric),
        new JdeField("BBRCD#", "BBRCD#", JdeDataType.Numeric),
        new JdeField("BBUSTT", "BBUSTT", JdeDataType.String, 2),
        new JdeField("BBHSTD", "BBHSTD", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06045_0", "Primary Key on BBDTAI", new[] { "BBDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
