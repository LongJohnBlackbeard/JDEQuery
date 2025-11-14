using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10UI520 - .
/// </summary>
public class F10UI520 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWUDCCF.
        /// </summary>
        public const string CWUDCCF = "CWUDCCF";

        /// <summary>
        /// CWLIN.
        /// </summary>
        public const string CWLIN = "CWLIN";

        /// <summary>
        /// CWDCF01.
        /// </summary>
        public const string CWDCF01 = "CWDCF01";

        /// <summary>
        /// CWAA.
        /// </summary>
        public const string CWAA = "CWAA";

        /// <summary>
        /// CWLT.
        /// </summary>
        public const string CWLT = "CWLT";

        /// <summary>
        /// CWCRCX.
        /// </summary>
        public const string CWCRCX = "CWCRCX";

        /// <summary>
        /// CWUSER.
        /// </summary>
        public const string CWUSER = "CWUSER";

        /// <summary>
        /// CWJOBN.
        /// </summary>
        public const string CWJOBN = "CWJOBN";

        /// <summary>
        /// CWJOBS.
        /// </summary>
        public const string CWJOBS = "CWJOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F10UI520";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWUDCCF", "CWUDCCF", JdeDataType.String, 20, true, true),
        new JdeField("CWLIN", "CWLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("CWDCF01", "CWDCF01", JdeDataType.String, 120),
        new JdeField("CWAA", "CWAA", JdeDataType.Numeric),
        new JdeField("CWLT", "CWLT", JdeDataType.String, 4),
        new JdeField("CWCRCX", "CWCRCX", JdeDataType.String, 6),
        new JdeField("CWUSER", "CWUSER", JdeDataType.String, 20, true, true),
        new JdeField("CWJOBN", "CWJOBN", JdeDataType.String, 20, true, true),
        new JdeField("CWJOBS", "CWJOBS", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10UI520_0", "Primary Key on CWUDCCF, CWLIN, CWUSER, CWJOBN, CWJOBS", new[] { "CWUDCCF", "CWLIN", "CWUSER", "CWJOBN", "CWJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
