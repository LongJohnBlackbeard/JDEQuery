using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06148 - .
/// </summary>
public class F06148 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y_1AN8.
        /// </summary>
        public const string Y_1AN8 = "Y_1AN8";

        /// <summary>
        /// Y_1TARA.
        /// </summary>
        public const string Y_1TARA = "Y_1TARA";

        /// <summary>
        /// Y_1PDBA.
        /// </summary>
        public const string Y_1PDBA = "Y_1PDBA";

        /// <summary>
        /// Y_1DTEY.
        /// </summary>
        public const string Y_1DTEY = "Y_1DTEY";

        /// <summary>
        /// Y_1TAXX.
        /// </summary>
        public const string Y_1TAXX = "Y_1TAXX";

        /// <summary>
        /// Y_1HMCO.
        /// </summary>
        public const string Y_1HMCO = "Y_1HMCO";

        /// <summary>
        /// Y_1CTRY.
        /// </summary>
        public const string Y_1CTRY = "Y_1CTRY";

        /// <summary>
        /// Y_1DISO.
        /// </summary>
        public const string Y_1DISO = "Y_1DISO";

        /// <summary>
        /// Y_1GPAY.
        /// </summary>
        public const string Y_1GPAY = "Y_1GPAY";

        /// <summary>
        /// Y_1USER.
        /// </summary>
        public const string Y_1USER = "Y_1USER";

        /// <summary>
        /// Y_1PID.
        /// </summary>
        public const string Y_1PID = "Y_1PID";

        /// <summary>
        /// Y_1UPMJ.
        /// </summary>
        public const string Y_1UPMJ = "Y_1UPMJ";

        /// <summary>
        /// Y_1DTSP.
        /// </summary>
        public const string Y_1DTSP = "Y_1DTSP";
    }

    /// <inheritdoc />
    public override string TableName => "F06148";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y_1AN8", "Y_1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y_1TARA", "Y_1TARA", JdeDataType.String, 20, true, true),
        new JdeField("Y_1PDBA", "Y_1PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("Y_1DTEY", "Y_1DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("Y_1TAXX", "Y_1TAXX", JdeDataType.String, 40, true, true),
        new JdeField("Y_1HMCO", "Y_1HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y_1CTRY", "Y_1CTRY", JdeDataType.Numeric),
        new JdeField("Y_1DISO", "Y_1DISO", JdeDataType.String, 2),
        new JdeField("Y_1GPAY", "Y_1GPAY", JdeDataType.Numeric),
        new JdeField("Y_1USER", "Y_1USER", JdeDataType.String, 20),
        new JdeField("Y_1PID", "Y_1PID", JdeDataType.String, 20),
        new JdeField("Y_1UPMJ", "Y_1UPMJ", JdeDataType.Numeric),
        new JdeField("Y_1DTSP", "Y_1DTSP", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06148_0", "Primary Key on Y_1AN8, Y_1TARA, Y_1PDBA, Y_1DTEY, Y_1TAXX, Y_1HMCO", new[] { "Y_1AN8", "Y_1TARA", "Y_1PDBA", "Y_1DTEY", "Y_1TAXX", "Y_1HMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06148_2", "Index on Y_1AN8, Y_1PDBA, Y_1DTEY, Y_1TAXX, Y_1HMCO", new[] { "Y_1AN8", "Y_1PDBA", "Y_1DTEY", "Y_1TAXX", "Y_1HMCO" }),
        new JdeIndex("F06148_3", "Index on Y_1DTEY, Y_1HMCO, Y_1TARA, Y_1PDBA, Y_1AN8", new[] { "Y_1DTEY", "Y_1HMCO", "Y_1TARA", "Y_1PDBA", "Y_1AN8" }),
        new JdeIndex("F06148_4", "Index on Y_1AN8, Y_1TARA, Y_1DTEY, Y_1TAXX, Y_1HMCO", new[] { "Y_1AN8", "Y_1TARA", "Y_1DTEY", "Y_1TAXX", "Y_1HMCO" }),
        new JdeIndex("F06148_5", "Index on Y_1AN8, Y_1TARA, Y_1DTEY, Y_1HMCO, Y_1PDBA, Y_1TAXX", new[] { "Y_1AN8", "Y_1TARA", "Y_1DTEY", "Y_1HMCO", "Y_1PDBA", "Y_1TAXX" }),
        new JdeIndex("F06148_6", "Index on Y_1AN8, Y_1DTEY, Y_1CTRY", new[] { "Y_1AN8", "Y_1DTEY", "Y_1CTRY" })
    };
}
