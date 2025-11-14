using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08021 - .
/// </summary>
public class F08021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YYSY.
        /// </summary>
        public const string YYSY = "YYSY";

        /// <summary>
        /// YYRT.
        /// </summary>
        public const string YYRT = "YYRT";

        /// <summary>
        /// YYKY.
        /// </summary>
        public const string YYKY = "YYKY";

        /// <summary>
        /// YYCEVM.
        /// </summary>
        public const string YYCEVM = "YYCEVM";

        /// <summary>
        /// YYCEAB.
        /// </summary>
        public const string YYCEAB = "YYCEAB";

        /// <summary>
        /// YYCEPR.
        /// </summary>
        public const string YYCEPR = "YYCEPR";

        /// <summary>
        /// YYCEES.
        /// </summary>
        public const string YYCEES = "YYCEES";
    }

    /// <inheritdoc />
    public override string TableName => "F08021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YYSY", "YYSY", JdeDataType.String, 8, true, true),
        new JdeField("YYRT", "YYRT", JdeDataType.String, 4, true, true),
        new JdeField("YYKY", "YYKY", JdeDataType.String, 20, true, true),
        new JdeField("YYCEVM", "YYCEVM", JdeDataType.String, 2),
        new JdeField("YYCEAB", "YYCEAB", JdeDataType.String, 2),
        new JdeField("YYCEPR", "YYCEPR", JdeDataType.String, 2),
        new JdeField("YYCEES", "YYCEES", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08021_0", "Primary Key on YYSY, YYRT, YYKY", new[] { "YYSY", "YYRT", "YYKY" }, isUnique: true, isPrimaryKey: true)
    };
}
