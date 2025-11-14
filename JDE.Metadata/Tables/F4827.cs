using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4827 - .
/// </summary>
public class F4827 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W5DCTO.
        /// </summary>
        public const string W5DCTO = "W5DCTO";

        /// <summary>
        /// W5TYPS.
        /// </summary>
        public const string W5TYPS = "W5TYPS";

        /// <summary>
        /// W5APRT.
        /// </summary>
        public const string W5APRT = "W5APRT";

        /// <summary>
        /// W5SRST.
        /// </summary>
        public const string W5SRST = "W5SRST";

        /// <summary>
        /// W5SEQ.
        /// </summary>
        public const string W5SEQ = "W5SEQ";

        /// <summary>
        /// W5AA.
        /// </summary>
        public const string W5AA = "W5AA";

        /// <summary>
        /// W5AN8.
        /// </summary>
        public const string W5AN8 = "W5AN8";

        /// <summary>
        /// W5SRJS.
        /// </summary>
        public const string W5SRJS = "W5SRJS";

        /// <summary>
        /// W5JOBN.
        /// </summary>
        public const string W5JOBN = "W5JOBN";

        /// <summary>
        /// W5PID.
        /// </summary>
        public const string W5PID = "W5PID";

        /// <summary>
        /// W5UPMJ.
        /// </summary>
        public const string W5UPMJ = "W5UPMJ";

        /// <summary>
        /// W5UPMT.
        /// </summary>
        public const string W5UPMT = "W5UPMT";

        /// <summary>
        /// W5USER.
        /// </summary>
        public const string W5USER = "W5USER";
    }

    /// <inheritdoc />
    public override string TableName => "F4827";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W5DCTO", "W5DCTO", JdeDataType.String, 4, true, true),
        new JdeField("W5TYPS", "W5TYPS", JdeDataType.String, 2, true, true),
        new JdeField("W5APRT", "W5APRT", JdeDataType.String, 6, true, true),
        new JdeField("W5SRST", "W5SRST", JdeDataType.String, 4, true, true),
        new JdeField("W5SEQ", "W5SEQ", JdeDataType.Numeric),
        new JdeField("W5AA", "W5AA", JdeDataType.Numeric),
        new JdeField("W5AN8", "W5AN8", JdeDataType.Numeric),
        new JdeField("W5SRJS", "W5SRJS", JdeDataType.String, 4),
        new JdeField("W5JOBN", "W5JOBN", JdeDataType.String, 20),
        new JdeField("W5PID", "W5PID", JdeDataType.String, 20),
        new JdeField("W5UPMJ", "W5UPMJ", JdeDataType.Numeric),
        new JdeField("W5UPMT", "W5UPMT", JdeDataType.Numeric),
        new JdeField("W5USER", "W5USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4827_0", "Primary Key on W5DCTO, W5TYPS, W5APRT, W5SRST", new[] { "W5DCTO", "W5TYPS", "W5APRT", "W5SRST" }, isUnique: true, isPrimaryKey: true)
    };
}
