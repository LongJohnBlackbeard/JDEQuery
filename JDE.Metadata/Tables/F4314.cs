using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4314 - .
/// </summary>
public class F4314 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JMKCOO.
        /// </summary>
        public const string JMKCOO = "JMKCOO";

        /// <summary>
        /// JMDOCO.
        /// </summary>
        public const string JMDOCO = "JMDOCO";

        /// <summary>
        /// JMDCTO.
        /// </summary>
        public const string JMDCTO = "JMDCTO";

        /// <summary>
        /// JMLNID.
        /// </summary>
        public const string JMLNID = "JMLNID";

        /// <summary>
        /// JMPNTC.
        /// </summary>
        public const string JMPNTC = "JMPNTC";

        /// <summary>
        /// JMLINS.
        /// </summary>
        public const string JMLINS = "JMLINS";

        /// <summary>
        /// JMTXLN.
        /// </summary>
        public const string JMTXLN = "JMTXLN";
    }

    /// <inheritdoc />
    public override string TableName => "F4314";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JMKCOO", "JMKCOO", JdeDataType.String, 10, true, true),
        new JdeField("JMDOCO", "JMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("JMDCTO", "JMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("JMLNID", "JMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("JMPNTC", "JMPNTC", JdeDataType.String, 2),
        new JdeField("JMLINS", "JMLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("JMTXLN", "JMTXLN", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4314_0", "Primary Key on JMDOCO, JMDCTO, JMKCOO, JMLNID, JMLINS", new[] { "JMDOCO", "JMDCTO", "JMKCOO", "JMLNID", "JMLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
