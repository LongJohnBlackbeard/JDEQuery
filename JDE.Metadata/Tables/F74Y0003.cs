using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y0003 - .
/// </summary>
public class F74Y0003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITK74LECO.
        /// </summary>
        public const string ITK74LECO = "ITK74LECO";

        /// <summary>
        /// ITDCT.
        /// </summary>
        public const string ITDCT = "ITDCT";

        /// <summary>
        /// ITI74GEF.
        /// </summary>
        public const string ITI74GEF = "ITI74GEF";

        /// <summary>
        /// ITK74LEDT.
        /// </summary>
        public const string ITK74LEDT = "ITK74LEDT";

        /// <summary>
        /// ITUSER.
        /// </summary>
        public const string ITUSER = "ITUSER";

        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITUPMJ.
        /// </summary>
        public const string ITUPMJ = "ITUPMJ";

        /// <summary>
        /// ITUPMT.
        /// </summary>
        public const string ITUPMT = "ITUPMT";

        /// <summary>
        /// ITJOBN.
        /// </summary>
        public const string ITJOBN = "ITJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y0003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITK74LECO", "ITK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("ITDCT", "ITDCT", JdeDataType.String, 4, true, true),
        new JdeField("ITI74GEF", "ITI74GEF", JdeDataType.String, 2, true, true),
        new JdeField("ITK74LEDT", "ITK74LEDT", JdeDataType.String, 10),
        new JdeField("ITUSER", "ITUSER", JdeDataType.String, 20),
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20),
        new JdeField("ITUPMJ", "ITUPMJ", JdeDataType.Numeric),
        new JdeField("ITUPMT", "ITUPMT", JdeDataType.Numeric),
        new JdeField("ITJOBN", "ITJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y0003_0", "Primary Key on ITK74LECO, ITDCT, ITI74GEF", new[] { "ITK74LECO", "ITDCT", "ITI74GEF" }, isUnique: true, isPrimaryKey: true)
    };
}
