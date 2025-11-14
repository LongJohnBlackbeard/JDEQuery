using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0145 - .
/// </summary>
public class F75A0145 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZZICU.
        /// </summary>
        public const string ZZICU = "ZZICU";

        /// <summary>
        /// ZZLNID.
        /// </summary>
        public const string ZZLNID = "ZZLNID";

        /// <summary>
        /// ZZATOREC.
        /// </summary>
        public const string ZZATOREC = "ZZATOREC";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0145";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZZICU", "ZZICU", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZLNID", "ZZLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZZATOREC", "ZZATOREC", JdeDataType.String, 1256)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0145_0", "Primary Key on ZZICU, ZZLNID", new[] { "ZZICU", "ZZLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
