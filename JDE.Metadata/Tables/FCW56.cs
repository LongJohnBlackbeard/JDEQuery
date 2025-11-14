using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW56 - .
/// </summary>
public class FCW56 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDC9MOSA.
        /// </summary>
        public const string MDC9MOSA = "MDC9MOSA";

        /// <summary>
        /// MDLNID.
        /// </summary>
        public const string MDLNID = "MDLNID";

        /// <summary>
        /// MDC9COLL.
        /// </summary>
        public const string MDC9COLL = "MDC9COLL";

        /// <summary>
        /// MDC9SEAC.
        /// </summary>
        public const string MDC9SEAC = "MDC9SEAC";

        /// <summary>
        /// MDC9SEAY.
        /// </summary>
        public const string MDC9SEAY = "MDC9SEAY";

        /// <summary>
        /// MDC9LVL1.
        /// </summary>
        public const string MDC9LVL1 = "MDC9LVL1";

        /// <summary>
        /// MDC9LVL2.
        /// </summary>
        public const string MDC9LVL2 = "MDC9LVL2";

        /// <summary>
        /// MDC9LVL3.
        /// </summary>
        public const string MDC9LVL3 = "MDC9LVL3";

        /// <summary>
        /// MDC9LVL4.
        /// </summary>
        public const string MDC9LVL4 = "MDC9LVL4";

        /// <summary>
        /// MDC9LVL5.
        /// </summary>
        public const string MDC9LVL5 = "MDC9LVL5";

        /// <summary>
        /// MDC9ITM.
        /// </summary>
        public const string MDC9ITM = "MDC9ITM";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDJOBN.
        /// </summary>
        public const string MDJOBN = "MDJOBN";

        /// <summary>
        /// MDUPMJ.
        /// </summary>
        public const string MDUPMJ = "MDUPMJ";

        /// <summary>
        /// MDTDAY.
        /// </summary>
        public const string MDTDAY = "MDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW56";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDC9MOSA", "MDC9MOSA", JdeDataType.String, 20, true, true),
        new JdeField("MDLNID", "MDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("MDC9COLL", "MDC9COLL", JdeDataType.String, 20),
        new JdeField("MDC9SEAC", "MDC9SEAC", JdeDataType.String, 4),
        new JdeField("MDC9SEAY", "MDC9SEAY", JdeDataType.String, 8),
        new JdeField("MDC9LVL1", "MDC9LVL1", JdeDataType.String, 12),
        new JdeField("MDC9LVL2", "MDC9LVL2", JdeDataType.String, 12),
        new JdeField("MDC9LVL3", "MDC9LVL3", JdeDataType.String, 12),
        new JdeField("MDC9LVL4", "MDC9LVL4", JdeDataType.String, 12),
        new JdeField("MDC9LVL5", "MDC9LVL5", JdeDataType.String, 12),
        new JdeField("MDC9ITM", "MDC9ITM", JdeDataType.Numeric),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDJOBN", "MDJOBN", JdeDataType.String, 20),
        new JdeField("MDUPMJ", "MDUPMJ", JdeDataType.Numeric),
        new JdeField("MDTDAY", "MDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW56_0", "Primary Key on MDC9MOSA, MDLNID", new[] { "MDC9MOSA", "MDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW56_2", "Index on MDC9MOSA, MDC9COLL, MDC9SEAC, MDC9SEAY, MDC9LVL1, MDC9LVL2, MDC9LVL3, MDC9LVL4, MDC9LVL5, MDC9ITM", new[] { "MDC9MOSA", "MDC9COLL", "MDC9SEAC", "MDC9SEAY", "MDC9LVL1", "MDC9LVL2", "MDC9LVL3", "MDC9LVL4", "MDC9LVL5", "MDC9ITM" })
    };
}
