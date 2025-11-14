using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75J504 - .
/// </summary>
public class F75J504 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROCO.
        /// </summary>
        public const string ROCO = "ROCO";

        /// <summary>
        /// ROTXA1.
        /// </summary>
        public const string ROTXA1 = "ROTXA1";

        /// <summary>
        /// ROJ75ROPT.
        /// </summary>
        public const string ROJ75ROPT = "ROJ75ROPT";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROUPMT.
        /// </summary>
        public const string ROUPMT = "ROUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75J504";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROCO", "ROCO", JdeDataType.String, 10, true, true),
        new JdeField("ROTXA1", "ROTXA1", JdeDataType.String, 20, true, true),
        new JdeField("ROJ75ROPT", "ROJ75ROPT", JdeDataType.String, 2),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROUPMT", "ROUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75J504_0", "Primary Key on ROCO, ROTXA1", new[] { "ROCO", "ROTXA1" }, isUnique: true, isPrimaryKey: true)
    };
}
