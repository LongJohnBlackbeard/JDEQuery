using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12841 - .
/// </summary>
public class F12841 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIEFTB.
        /// </summary>
        public const string RIEFTB = "RIEFTB";

        /// <summary>
        /// RIRVCD.
        /// </summary>
        public const string RIRVCD = "RIRVCD";

        /// <summary>
        /// RIRFAC.
        /// </summary>
        public const string RIRFAC = "RIRFAC";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RILCT.
        /// </summary>
        public const string RILCT = "RILCT";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";
    }

    /// <inheritdoc />
    public override string TableName => "F12841";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIEFTB", "RIEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("RIRVCD", "RIRVCD", JdeDataType.String, 6, true, true),
        new JdeField("RIRFAC", "RIRFAC", JdeDataType.Numeric),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RILCT", "RILCT", JdeDataType.Numeric),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12841_0", "Primary Key on RIRVCD, RIEFTB", new[] { "RIRVCD", "RIEFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F12841_2", "Index on SYS_NC00007$, SYS_NC00008$", new[] { "SYS_NC00007$", "SYS_NC00008$" })
    };
}
