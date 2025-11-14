using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085500 - .
/// </summary>
public class F085500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADPLAN.
        /// </summary>
        public const string ADPLAN = "ADPLAN";

        /// <summary>
        /// ADAOPT.
        /// </summary>
        public const string ADAOPT = "ADAOPT";

        /// <summary>
        /// ADRELA.
        /// </summary>
        public const string ADRELA = "ADRELA";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADJOBN.
        /// </summary>
        public const string ADJOBN = "ADJOBN";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F085500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADPLAN", "ADPLAN", JdeDataType.String, 16, true, true),
        new JdeField("ADAOPT", "ADAOPT", JdeDataType.String, 6, true, true),
        new JdeField("ADRELA", "ADRELA", JdeDataType.String, 2, true, true),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADJOBN", "ADJOBN", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085500_0", "Primary Key on ADPLAN, ADAOPT, ADRELA", new[] { "ADPLAN", "ADAOPT", "ADRELA" }, isUnique: true, isPrimaryKey: true)
    };
}
