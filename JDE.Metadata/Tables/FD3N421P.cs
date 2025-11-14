using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FD3N421P - .
/// </summary>
public class FD3N421P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHCNID.
        /// </summary>
        public const string SHCNID = "SHCNID";

        /// <summary>
        /// SHITM.
        /// </summary>
        public const string SHITM = "SHITM";

        /// <summary>
        /// SHLOTN.
        /// </summary>
        public const string SHLOTN = "SHLOTN";

        /// <summary>
        /// SHDOCO.
        /// </summary>
        public const string SHDOCO = "SHDOCO";

        /// <summary>
        /// SHDCTO.
        /// </summary>
        public const string SHDCTO = "SHDCTO";

        /// <summary>
        /// SHLNID.
        /// </summary>
        public const string SHLNID = "SHLNID";

        /// <summary>
        /// SHSOQS.
        /// </summary>
        public const string SHSOQS = "SHSOQS";

        /// <summary>
        /// SHUM.
        /// </summary>
        public const string SHUM = "SHUM";

        /// <summary>
        /// SHPTUPUSER.
        /// </summary>
        public const string SHPTUPUSER = "SHPTUPUSER";

        /// <summary>
        /// SHPTUPDTTM.
        /// </summary>
        public const string SHPTUPDTTM = "SHPTUPDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "FD3N421P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHCNID", "SHCNID", JdeDataType.String, 40, true, true),
        new JdeField("SHITM", "SHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SHLOTN", "SHLOTN", JdeDataType.String, 60, true, true),
        new JdeField("SHDOCO", "SHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SHDCTO", "SHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SHLNID", "SHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SHSOQS", "SHSOQS", JdeDataType.Numeric),
        new JdeField("SHUM", "SHUM", JdeDataType.String, 4),
        new JdeField("SHPTUPUSER", "SHPTUPUSER", JdeDataType.String, 32),
        new JdeField("SHPTUPDTTM", "SHPTUPDTTM", JdeDataType.String, 28)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FD3N421P_0", "Primary Key on SHCNID, SHITM, SHLOTN, SHDOCO, SHDCTO, SHLNID", new[] { "SHCNID", "SHITM", "SHLOTN", "SHDOCO", "SHDCTO", "SHLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
