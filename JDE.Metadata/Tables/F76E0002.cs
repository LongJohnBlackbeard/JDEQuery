using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76E0002 - .
/// </summary>
public class F76E0002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEKYFN.
        /// </summary>
        public const string PEKYFN = "PEKYFN";

        /// <summary>
        /// PEKY.
        /// </summary>
        public const string PEKY = "PEKY";

        /// <summary>
        /// PEPLND.
        /// </summary>
        public const string PEPLND = "PEPLND";

        /// <summary>
        /// PEAA01.
        /// </summary>
        public const string PEAA01 = "PEAA01";

        /// <summary>
        /// PEAAF.
        /// </summary>
        public const string PEAAF = "PEAAF";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PEUPMT.
        /// </summary>
        public const string PEUPMT = "PEUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76E0002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEKYFN", "PEKYFN", JdeDataType.String, 20, true, true),
        new JdeField("PEKY", "PEKY", JdeDataType.String, 20, true, true),
        new JdeField("PEPLND", "PEPLND", JdeDataType.Numeric, null, true, true),
        new JdeField("PEAA01", "PEAA01", JdeDataType.String, 2),
        new JdeField("PEAAF", "PEAAF", JdeDataType.String, 2),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PEUPMT", "PEUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76E0002_0", "Primary Key on PEKYFN, PEKY, PEPLND", new[] { "PEKYFN", "PEKY", "PEPLND" }, isUnique: true, isPrimaryKey: true)
    };
}
