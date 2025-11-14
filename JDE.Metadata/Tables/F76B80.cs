using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B80 - .
/// </summary>
public class F76B80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDUPDJ.
        /// </summary>
        public const string CDUPDJ = "CDUPDJ";

        /// <summary>
        /// CDBRNTB.
        /// </summary>
        public const string CDBRNTB = "CDBRNTB";

        /// <summary>
        /// CDBRCUT.
        /// </summary>
        public const string CDBRCUT = "CDBRCUT";

        /// <summary>
        /// CDBRCUD.
        /// </summary>
        public const string CDBRCUD = "CDBRCUD";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDEAP.
        /// </summary>
        public const string CDEAP = "CDEAP";

        /// <summary>
        /// CDJOBN.
        /// </summary>
        public const string CDJOBN = "CDJOBN";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDUPDJ", "CDUPDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDBRNTB", "CDBRNTB", JdeDataType.String, 4, true, true),
        new JdeField("CDBRCUT", "CDBRCUT", JdeDataType.String, 70, true, true),
        new JdeField("CDBRCUD", "CDBRCUD", JdeDataType.String, 90),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDEAP", "CDEAP", JdeDataType.String, 20),
        new JdeField("CDJOBN", "CDJOBN", JdeDataType.String, 20),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B80_0", "Primary Key on CDBRNTB, CDBRCUT, CDUPDJ", new[] { "CDBRNTB", "CDBRCUT", "CDUPDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B80_2", "Index on CDBRNTB, CDBRCUT", new[] { "CDBRNTB", "CDBRCUT" })
    };
}
