using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI34 - .
/// </summary>
public class F76HUI34 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ORJOBS.
        /// </summary>
        public const string ORJOBS = "ORJOBS";

        /// <summary>
        /// ORCTID.
        /// </summary>
        public const string ORCTID = "ORCTID";

        /// <summary>
        /// ORKCOO.
        /// </summary>
        public const string ORKCOO = "ORKCOO";

        /// <summary>
        /// ORDCTO.
        /// </summary>
        public const string ORDCTO = "ORDCTO";

        /// <summary>
        /// ORDOCO.
        /// </summary>
        public const string ORDOCO = "ORDOCO";

        /// <summary>
        /// ORKCO.
        /// </summary>
        public const string ORKCO = "ORKCO";

        /// <summary>
        /// ORDCT.
        /// </summary>
        public const string ORDCT = "ORDCT";

        /// <summary>
        /// ORDOC.
        /// </summary>
        public const string ORDOC = "ORDOC";

        /// <summary>
        /// ORACTI.
        /// </summary>
        public const string ORACTI = "ORACTI";
    }

    /// <inheritdoc />
    public override string TableName => "F76HUI34";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ORJOBS", "ORJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ORCTID", "ORCTID", JdeDataType.String, 30, true, true),
        new JdeField("ORKCOO", "ORKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ORDCTO", "ORDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ORDOCO", "ORDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ORKCO", "ORKCO", JdeDataType.String, 10, true, true),
        new JdeField("ORDCT", "ORDCT", JdeDataType.String, 4, true, true),
        new JdeField("ORDOC", "ORDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ORACTI", "ORACTI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI34_0", "Primary Key on ORJOBS, ORCTID, ORKCOO, ORDCTO, ORDOCO, ORKCO, ORDCT, ORDOC", new[] { "ORJOBS", "ORCTID", "ORKCOO", "ORDCTO", "ORDOCO", "ORKCO", "ORDCT", "ORDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
