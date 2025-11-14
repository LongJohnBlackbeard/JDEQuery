using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05403 - .
/// </summary>
public class F05403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRSSACTS.
        /// </summary>
        public const string PRSSACTS = "PRSSACTS";

        /// <summary>
        /// PRSSAGRP.
        /// </summary>
        public const string PRSSAGRP = "PRSSAGRP";

        /// <summary>
        /// PRSSGSEQ.
        /// </summary>
        public const string PRSSGSEQ = "PRSSGSEQ";

        /// <summary>
        /// PRSSAPOS.
        /// </summary>
        public const string PRSSAPOS = "PRSSAPOS";

        /// <summary>
        /// PRSSABEF.
        /// </summary>
        public const string PRSSABEF = "PRSSABEF";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRSSACTS", "PRSSACTS", JdeDataType.String, 20, true, true),
        new JdeField("PRSSAGRP", "PRSSAGRP", JdeDataType.String, 20),
        new JdeField("PRSSGSEQ", "PRSSGSEQ", JdeDataType.Numeric),
        new JdeField("PRSSAPOS", "PRSSAPOS", JdeDataType.Numeric),
        new JdeField("PRSSABEF", "PRSSABEF", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05403_0", "Primary Key on PRSSACTS", new[] { "PRSSACTS" }, isUnique: true, isPrimaryKey: true)
    };
}
