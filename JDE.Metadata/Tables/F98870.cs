using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F98870 - .
/// </summary>
public class F98870 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// POOBSERUID.
        /// </summary>
        public const string POOBSERUID = "POOBSERUID";

        /// <summary>
        /// POPINSTUID.
        /// </summary>
        public const string POPINSTUID = "POPINSTUID";

        /// <summary>
        /// POTRANDATA.
        /// </summary>
        public const string POTRANDATA = "POTRANDATA";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F98870";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POOBSERUID", "POOBSERUID", JdeDataType.String, 128, true, true),
        new JdeField("POPINSTUID", "POPINSTUID", JdeDataType.String, 128),
        new JdeField("POTRANDATA", "POTRANDATA", JdeDataType.String, 2048),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F98870_0", "Primary Key on POOBSERUID", new[] { "POOBSERUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F98870_2", "Index on POPINSTUID", new[] { "POPINSTUID" })
    };
}
