using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F89LU004 - .
/// </summary>
public class F89LU004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRCRMPRIORID.
        /// </summary>
        public const string PRCRMPRIORID = "PRCRMPRIORID";

        /// <summary>
        /// PRPRIORDESC.
        /// </summary>
        public const string PRPRIORDESC = "PRPRIORDESC";

        /// <summary>
        /// PRCUSTPRIO.
        /// </summary>
        public const string PRCUSTPRIO = "PRCUSTPRIO";

        /// <summary>
        /// PRPRIOR.
        /// </summary>
        public const string PRPRIOR = "PRPRIOR";

        /// <summary>
        /// PRMATH08.
        /// </summary>
        public const string PRMATH08 = "PRMATH08";
    }

    /// <inheritdoc />
    public override string TableName => "F89LU004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRCRMPRIORID", "PRCRMPRIORID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRPRIORDESC", "PRPRIORDESC", JdeDataType.String, 100),
        new JdeField("PRCUSTPRIO", "PRCUSTPRIO", JdeDataType.String, 50),
        new JdeField("PRPRIOR", "PRPRIOR", JdeDataType.String, 4),
        new JdeField("PRMATH08", "PRMATH08", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F89LU004_0", "Primary Key on PRCRMPRIORID", new[] { "PRCRMPRIORID" }, isUnique: true, isPrimaryKey: true)
    };
}
