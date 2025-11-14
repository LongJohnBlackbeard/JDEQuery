using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T011 - .
/// </summary>
public class F75T011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDEAP.
        /// </summary>
        public const string GDEAP = "GDEAP";

        /// <summary>
        /// GDVER.
        /// </summary>
        public const string GDVER = "GDVER";

        /// <summary>
        /// GD75TDCT.
        /// </summary>
        public const string GD75TDCT = "GD75TDCT";

        /// <summary>
        /// GD75TGFC.
        /// </summary>
        public const string GD75TGFC = "GD75TGFC";

        /// <summary>
        /// GDUSER.
        /// </summary>
        public const string GDUSER = "GDUSER";

        /// <summary>
        /// GDJOBN.
        /// </summary>
        public const string GDJOBN = "GDJOBN";

        /// <summary>
        /// GDPID.
        /// </summary>
        public const string GDPID = "GDPID";

        /// <summary>
        /// GDUPMJ.
        /// </summary>
        public const string GDUPMJ = "GDUPMJ";

        /// <summary>
        /// GDTDAY.
        /// </summary>
        public const string GDTDAY = "GDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDEAP", "GDEAP", JdeDataType.String, 20, true, true),
        new JdeField("GDVER", "GDVER", JdeDataType.String, 20, true, true),
        new JdeField("GD75TDCT", "GD75TDCT", JdeDataType.String, 6),
        new JdeField("GD75TGFC", "GD75TGFC", JdeDataType.String, 4),
        new JdeField("GDUSER", "GDUSER", JdeDataType.String, 20),
        new JdeField("GDJOBN", "GDJOBN", JdeDataType.String, 20),
        new JdeField("GDPID", "GDPID", JdeDataType.String, 20),
        new JdeField("GDUPMJ", "GDUPMJ", JdeDataType.Numeric),
        new JdeField("GDTDAY", "GDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T011_0", "Primary Key on GDEAP, GDVER", new[] { "GDEAP", "GDVER" }, isUnique: true, isPrimaryKey: true)
    };
}
