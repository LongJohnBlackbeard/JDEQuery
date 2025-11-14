using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I421 - .
/// </summary>
public class F75I421 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAACTB.
        /// </summary>
        public const string MAACTB = "MAACTB";

        /// <summary>
        /// MAACTNAME.
        /// </summary>
        public const string MAACTNAME = "MAACTNAME";

        /// <summary>
        /// MAAGGK.
        /// </summary>
        public const string MAAGGK = "MAAGGK";

        /// <summary>
        /// MAALPH.
        /// </summary>
        public const string MAALPH = "MAALPH";

        /// <summary>
        /// MAAA.
        /// </summary>
        public const string MAAA = "MAAA";

        /// <summary>
        /// MADT.
        /// </summary>
        public const string MADT = "MADT";

        /// <summary>
        /// MAUSER.
        /// </summary>
        public const string MAUSER = "MAUSER";

        /// <summary>
        /// MAJOBN.
        /// </summary>
        public const string MAJOBN = "MAJOBN";

        /// <summary>
        /// MAPID.
        /// </summary>
        public const string MAPID = "MAPID";

        /// <summary>
        /// MAUPMJ.
        /// </summary>
        public const string MAUPMJ = "MAUPMJ";

        /// <summary>
        /// MATDAY.
        /// </summary>
        public const string MATDAY = "MATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I421";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAACTB", "MAACTB", JdeDataType.String, 20, true, true),
        new JdeField("MAACTNAME", "MAACTNAME", JdeDataType.String, 20, true, true),
        new JdeField("MAAGGK", "MAAGGK", JdeDataType.String, 500),
        new JdeField("MAALPH", "MAALPH", JdeDataType.String, 80),
        new JdeField("MAAA", "MAAA", JdeDataType.Numeric),
        new JdeField("MADT", "MADT", JdeDataType.Numeric),
        new JdeField("MAUSER", "MAUSER", JdeDataType.String, 20),
        new JdeField("MAJOBN", "MAJOBN", JdeDataType.String, 20),
        new JdeField("MAPID", "MAPID", JdeDataType.String, 20),
        new JdeField("MAUPMJ", "MAUPMJ", JdeDataType.Numeric),
        new JdeField("MATDAY", "MATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I421_0", "Primary Key on MAACTB, MAACTNAME", new[] { "MAACTB", "MAACTNAME" }, isUnique: true, isPrimaryKey: true)
    };
}
