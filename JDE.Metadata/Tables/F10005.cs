using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10005 - .
/// </summary>
public class F10005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GOSY.
        /// </summary>
        public const string GOSY = "GOSY";

        /// <summary>
        /// GORT.
        /// </summary>
        public const string GORT = "GORT";

        /// <summary>
        /// GOKY.
        /// </summary>
        public const string GOKY = "GOKY";

        /// <summary>
        /// GODL01.
        /// </summary>
        public const string GODL01 = "GODL01";

        /// <summary>
        /// GONAM.
        /// </summary>
        public const string GONAM = "GONAM";

        /// <summary>
        /// GOUSER.
        /// </summary>
        public const string GOUSER = "GOUSER";

        /// <summary>
        /// GOPID.
        /// </summary>
        public const string GOPID = "GOPID";

        /// <summary>
        /// GOUPMJ.
        /// </summary>
        public const string GOUPMJ = "GOUPMJ";

        /// <summary>
        /// GOJOBN.
        /// </summary>
        public const string GOJOBN = "GOJOBN";

        /// <summary>
        /// GOUPMT.
        /// </summary>
        public const string GOUPMT = "GOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F10005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GOSY", "GOSY", JdeDataType.String, 8, true, true),
        new JdeField("GORT", "GORT", JdeDataType.String, 4, true, true),
        new JdeField("GOKY", "GOKY", JdeDataType.String, 20, true, true),
        new JdeField("GODL01", "GODL01", JdeDataType.String, 60),
        new JdeField("GONAM", "GONAM", JdeDataType.String, 24, true, true),
        new JdeField("GOUSER", "GOUSER", JdeDataType.String, 20),
        new JdeField("GOPID", "GOPID", JdeDataType.String, 20),
        new JdeField("GOUPMJ", "GOUPMJ", JdeDataType.Numeric),
        new JdeField("GOJOBN", "GOJOBN", JdeDataType.String, 20),
        new JdeField("GOUPMT", "GOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10005_0", "Primary Key on GONAM, GOSY, GORT, GOKY", new[] { "GONAM", "GOSY", "GORT", "GOKY" }, isUnique: true, isPrimaryKey: true)
    };
}
