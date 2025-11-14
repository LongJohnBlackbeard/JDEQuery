using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F071073 - .
/// </summary>
public class F071073 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3AN8.
        /// </summary>
        public const string J3AN8 = "J3AN8";

        /// <summary>
        /// J3PDBA.
        /// </summary>
        public const string J3PDBA = "J3PDBA";

        /// <summary>
        /// J3WANO.
        /// </summary>
        public const string J3WANO = "J3WANO";

        /// <summary>
        /// J3RTAM.
        /// </summary>
        public const string J3RTAM = "J3RTAM";

        /// <summary>
        /// J3DEDW.
        /// </summary>
        public const string J3DEDW = "J3DEDW";

        /// <summary>
        /// J3DESQ.
        /// </summary>
        public const string J3DESQ = "J3DESQ";

        /// <summary>
        /// J3USER.
        /// </summary>
        public const string J3USER = "J3USER";

        /// <summary>
        /// J3PID.
        /// </summary>
        public const string J3PID = "J3PID";

        /// <summary>
        /// J3JOBN.
        /// </summary>
        public const string J3JOBN = "J3JOBN";

        /// <summary>
        /// J3UPMJ.
        /// </summary>
        public const string J3UPMJ = "J3UPMJ";

        /// <summary>
        /// J3UPMT.
        /// </summary>
        public const string J3UPMT = "J3UPMT";

        /// <summary>
        /// J3INCF.
        /// </summary>
        public const string J3INCF = "J3INCF";
    }

    /// <inheritdoc />
    public override string TableName => "F071073";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3AN8", "J3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J3PDBA", "J3PDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("J3WANO", "J3WANO", JdeDataType.Numeric, null, true, true),
        new JdeField("J3RTAM", "J3RTAM", JdeDataType.Numeric),
        new JdeField("J3DEDW", "J3DEDW", JdeDataType.String, 2),
        new JdeField("J3DESQ", "J3DESQ", JdeDataType.String, 2),
        new JdeField("J3USER", "J3USER", JdeDataType.String, 20),
        new JdeField("J3PID", "J3PID", JdeDataType.String, 20),
        new JdeField("J3JOBN", "J3JOBN", JdeDataType.String, 20),
        new JdeField("J3UPMJ", "J3UPMJ", JdeDataType.Numeric),
        new JdeField("J3UPMT", "J3UPMT", JdeDataType.Numeric),
        new JdeField("J3INCF", "J3INCF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F071073_0", "Primary Key on J3AN8, J3PDBA, J3WANO", new[] { "J3AN8", "J3PDBA", "J3WANO" }, isUnique: true, isPrimaryKey: true)
    };
}
