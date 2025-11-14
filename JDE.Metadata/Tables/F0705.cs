using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0705 - .
/// </summary>
public class F0705 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J_1AN8.
        /// </summary>
        public const string J_1AN8 = "J_1AN8";

        /// <summary>
        /// J_1PDBA.
        /// </summary>
        public const string J_1PDBA = "J_1PDBA";

        /// <summary>
        /// J_1WANO.
        /// </summary>
        public const string J_1WANO = "J_1WANO";

        /// <summary>
        /// J_1DTEY.
        /// </summary>
        public const string J_1DTEY = "J_1DTEY";

        /// <summary>
        /// J_1HMO.
        /// </summary>
        public const string J_1HMO = "J_1HMO";

        /// <summary>
        /// J_1PPP.
        /// </summary>
        public const string J_1PPP = "J_1PPP";

        /// <summary>
        /// J_1TAXX.
        /// </summary>
        public const string J_1TAXX = "J_1TAXX";

        /// <summary>
        /// J_1HMCO.
        /// </summary>
        public const string J_1HMCO = "J_1HMCO";

        /// <summary>
        /// J_1GPA.
        /// </summary>
        public const string J_1GPA = "J_1GPA";

        /// <summary>
        /// J_1CKCN.
        /// </summary>
        public const string J_1CKCN = "J_1CKCN";

        /// <summary>
        /// J_1RTAM.
        /// </summary>
        public const string J_1RTAM = "J_1RTAM";

        /// <summary>
        /// J_1PID.
        /// </summary>
        public const string J_1PID = "J_1PID";

        /// <summary>
        /// J_1USER.
        /// </summary>
        public const string J_1USER = "J_1USER";

        /// <summary>
        /// J_1UPMJ.
        /// </summary>
        public const string J_1UPMJ = "J_1UPMJ";

        /// <summary>
        /// J_1UPMT.
        /// </summary>
        public const string J_1UPMT = "J_1UPMT";

        /// <summary>
        /// J_1JOBN.
        /// </summary>
        public const string J_1JOBN = "J_1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0705";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J_1AN8", "J_1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1PDBA", "J_1PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1WANO", "J_1WANO", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1DTEY", "J_1DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1HMO", "J_1HMO", JdeDataType.Numeric, null, true, true),
        new JdeField("J_1PPP", "J_1PPP", JdeDataType.String, 2, true, true),
        new JdeField("J_1TAXX", "J_1TAXX", JdeDataType.String, 40, true, true),
        new JdeField("J_1HMCO", "J_1HMCO", JdeDataType.String, 10, true, true),
        new JdeField("J_1GPA", "J_1GPA", JdeDataType.Numeric),
        new JdeField("J_1CKCN", "J_1CKCN", JdeDataType.Numeric),
        new JdeField("J_1RTAM", "J_1RTAM", JdeDataType.Numeric),
        new JdeField("J_1PID", "J_1PID", JdeDataType.String, 20),
        new JdeField("J_1USER", "J_1USER", JdeDataType.String, 20),
        new JdeField("J_1UPMJ", "J_1UPMJ", JdeDataType.Numeric),
        new JdeField("J_1UPMT", "J_1UPMT", JdeDataType.Numeric),
        new JdeField("J_1JOBN", "J_1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0705_0", "Primary Key on J_1AN8, J_1PDBA, J_1WANO, J_1DTEY, J_1HMO, J_1PPP, J_1TAXX, J_1HMCO", new[] { "J_1AN8", "J_1PDBA", "J_1WANO", "J_1DTEY", "J_1HMO", "J_1PPP", "J_1TAXX", "J_1HMCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0705_2", "Index on J_1AN8, J_1PDBA, J_1WANO, J_1DTEY, J_1HMO, J_1PPP, J_1TAXX, J_1CKCN, J_1HMCO", new[] { "J_1AN8", "J_1PDBA", "J_1WANO", "J_1DTEY", "J_1HMO", "J_1PPP", "J_1TAXX", "J_1CKCN", "J_1HMCO" }),
        new JdeIndex("F0705_3", "Index on J_1CKCN", new[] { "J_1CKCN" }),
        new JdeIndex("F0705_4", "Index on J_1AN8, J_1CKCN, J_1PDBA, J_1WANO, J_1TAXX, J_1HMCO", new[] { "J_1AN8", "J_1CKCN", "J_1PDBA", "J_1WANO", "J_1TAXX", "J_1HMCO" })
    };
}
