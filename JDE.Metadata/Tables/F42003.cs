using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42003 - .
/// </summary>
public class F42003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RESLS.
        /// </summary>
        public const string RESLS = "RESLS";

        /// <summary>
        /// RESLSP.
        /// </summary>
        public const string RESLSP = "RESLSP";

        /// <summary>
        /// RERPCT.
        /// </summary>
        public const string RERPCT = "RERPCT";

        /// <summary>
        /// RECEFJ.
        /// </summary>
        public const string RECEFJ = "RECEFJ";

        /// <summary>
        /// RECXPJ.
        /// </summary>
        public const string RECXPJ = "RECXPJ";

        /// <summary>
        /// RECOMB.
        /// </summary>
        public const string RECOMB = "RECOMB";

        /// <summary>
        /// RELNOR.
        /// </summary>
        public const string RELNOR = "RELNOR";

        /// <summary>
        /// REDESC.
        /// </summary>
        public const string REDESC = "REDESC";
    }

    /// <inheritdoc />
    public override string TableName => "F42003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RESLS", "RESLS", JdeDataType.Numeric, null, true, true),
        new JdeField("RESLSP", "RESLSP", JdeDataType.Numeric, null, true, true),
        new JdeField("RERPCT", "RERPCT", JdeDataType.Numeric),
        new JdeField("RECEFJ", "RECEFJ", JdeDataType.Numeric),
        new JdeField("RECXPJ", "RECXPJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RECOMB", "RECOMB", JdeDataType.String, 2),
        new JdeField("RELNOR", "RELNOR", JdeDataType.String, 2),
        new JdeField("REDESC", "REDESC", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42003_0", "Primary Key on RESLS, RESLSP, RECXPJ", new[] { "RESLS", "RESLSP", "RECXPJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42003_2", "Index on RESLS", new[] { "RESLS" })
    };
}
