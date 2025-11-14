using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0070 - .
/// </summary>
public class F0070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CKCTR.
        /// </summary>
        public const string CKCTR = "CKCTR";

        /// <summary>
        /// CKADID.
        /// </summary>
        public const string CKADID = "CKADID";

        /// <summary>
        /// CKPOSC.
        /// </summary>
        public const string CKPOSC = "CKPOSC";

        /// <summary>
        /// CKSSAL.
        /// </summary>
        public const string CKSSAL = "CKSSAL";

        /// <summary>
        /// CKSSPL.
        /// </summary>
        public const string CKSSPL = "CKSSPL";

        /// <summary>
        /// CKATTN.
        /// </summary>
        public const string CKATTN = "CKATTN";

        /// <summary>
        /// CKATTP.
        /// </summary>
        public const string CKATTP = "CKATTP";

        /// <summary>
        /// CKCTRP.
        /// </summary>
        public const string CKCTRP = "CKCTRP";

        /// <summary>
        /// CKTPL.
        /// </summary>
        public const string CKTPL = "CKTPL";

        /// <summary>
        /// CKFRMT.
        /// </summary>
        public const string CKFRMT = "CKFRMT";

        /// <summary>
        /// CKDSEP.
        /// </summary>
        public const string CKDSEP = "CKDSEP";

        /// <summary>
        /// CKDECF.
        /// </summary>
        public const string CKDECF = "CKDECF";
    }

    /// <inheritdoc />
    public override string TableName => "F0070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CKCTR", "CKCTR", JdeDataType.String, 6, true, true),
        new JdeField("CKADID", "CKADID", JdeDataType.String, 4),
        new JdeField("CKPOSC", "CKPOSC", JdeDataType.String, 8),
        new JdeField("CKSSAL", "CKSSAL", JdeDataType.String, 12),
        new JdeField("CKSSPL", "CKSSPL", JdeDataType.String, 2),
        new JdeField("CKATTN", "CKATTN", JdeDataType.String, 20),
        new JdeField("CKATTP", "CKATTP", JdeDataType.String, 2),
        new JdeField("CKCTRP", "CKCTRP", JdeDataType.String, 2),
        new JdeField("CKTPL", "CKTPL", JdeDataType.String, 2),
        new JdeField("CKFRMT", "CKFRMT", JdeDataType.String, 6),
        new JdeField("CKDSEP", "CKDSEP", JdeDataType.String, 2),
        new JdeField("CKDECF", "CKDECF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0070_0", "Primary Key on CKCTR", new[] { "CKCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
