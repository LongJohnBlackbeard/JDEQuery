using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5214 - .
/// </summary>
public class F5214 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A4DOCO.
        /// </summary>
        public const string A4DOCO = "A4DOCO";

        /// <summary>
        /// A4DCTO.
        /// </summary>
        public const string A4DCTO = "A4DCTO";

        /// <summary>
        /// A4KCOO.
        /// </summary>
        public const string A4KCOO = "A4KCOO";

        /// <summary>
        /// A4COCH.
        /// </summary>
        public const string A4COCH = "A4COCH";

        /// <summary>
        /// A4LNID.
        /// </summary>
        public const string A4LNID = "A4LNID";

        /// <summary>
        /// A4OPIM.
        /// </summary>
        public const string A4OPIM = "A4OPIM";

        /// <summary>
        /// A4CCOD.
        /// </summary>
        public const string A4CCOD = "A4CCOD";

        /// <summary>
        /// A4PDBA.
        /// </summary>
        public const string A4PDBA = "A4PDBA";

        /// <summary>
        /// A4PTAX.
        /// </summary>
        public const string A4PTAX = "A4PTAX";

        /// <summary>
        /// A4USER.
        /// </summary>
        public const string A4USER = "A4USER";

        /// <summary>
        /// A4JOBN.
        /// </summary>
        public const string A4JOBN = "A4JOBN";

        /// <summary>
        /// A4PID.
        /// </summary>
        public const string A4PID = "A4PID";

        /// <summary>
        /// A4UPMJ.
        /// </summary>
        public const string A4UPMJ = "A4UPMJ";

        /// <summary>
        /// A4UPMT.
        /// </summary>
        public const string A4UPMT = "A4UPMT";

        /// <summary>
        /// A4NBILL.
        /// </summary>
        public const string A4NBILL = "A4NBILL";
    }

    /// <inheritdoc />
    public override string TableName => "F5214";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A4DOCO", "A4DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("A4DCTO", "A4DCTO", JdeDataType.String, 4, true, true),
        new JdeField("A4KCOO", "A4KCOO", JdeDataType.String, 10, true, true),
        new JdeField("A4COCH", "A4COCH", JdeDataType.String, 6, true, true),
        new JdeField("A4LNID", "A4LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("A4OPIM", "A4OPIM", JdeDataType.String, 30),
        new JdeField("A4CCOD", "A4CCOD", JdeDataType.String, 10, true, true),
        new JdeField("A4PDBA", "A4PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("A4PTAX", "A4PTAX", JdeDataType.String, 4, true, true),
        new JdeField("A4USER", "A4USER", JdeDataType.String, 20),
        new JdeField("A4JOBN", "A4JOBN", JdeDataType.String, 20),
        new JdeField("A4PID", "A4PID", JdeDataType.String, 20),
        new JdeField("A4UPMJ", "A4UPMJ", JdeDataType.Numeric),
        new JdeField("A4UPMT", "A4UPMT", JdeDataType.Numeric),
        new JdeField("A4NBILL", "A4NBILL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5214_0", "Primary Key on A4CCOD, A4PDBA, A4PTAX, A4DOCO, A4DCTO, A4KCOO, A4COCH, A4LNID", new[] { "A4CCOD", "A4PDBA", "A4PTAX", "A4DOCO", "A4DCTO", "A4KCOO", "A4COCH", "A4LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5214_2", "Index on A4DOCO, A4DCTO, A4KCOO, A4COCH, A4LNID, A4CCOD, A4PDBA, A4PTAX", new[] { "A4DOCO", "A4DCTO", "A4KCOO", "A4COCH", "A4LNID", "A4CCOD", "A4PDBA", "A4PTAX" })
    };
}
