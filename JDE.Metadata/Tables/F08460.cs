using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08460 - .
/// </summary>
public class F08460 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R7PSTCAT.
        /// </summary>
        public const string R7PSTCAT = "R7PSTCAT";

        /// <summary>
        /// R7WZSTP.
        /// </summary>
        public const string R7WZSTP = "R7WZSTP";

        /// <summary>
        /// R7LNGP.
        /// </summary>
        public const string R7LNGP = "R7LNGP";

        /// <summary>
        /// R7STPORD.
        /// </summary>
        public const string R7STPORD = "R7STPORD";

        /// <summary>
        /// R7HIDE.
        /// </summary>
        public const string R7HIDE = "R7HIDE";

        /// <summary>
        /// R7PID.
        /// </summary>
        public const string R7PID = "R7PID";

        /// <summary>
        /// R7USER.
        /// </summary>
        public const string R7USER = "R7USER";

        /// <summary>
        /// R7MKEY.
        /// </summary>
        public const string R7MKEY = "R7MKEY";

        /// <summary>
        /// R7UPMJ.
        /// </summary>
        public const string R7UPMJ = "R7UPMJ";

        /// <summary>
        /// R7UPMT.
        /// </summary>
        public const string R7UPMT = "R7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08460";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R7PSTCAT", "R7PSTCAT", JdeDataType.String, 20, true, true),
        new JdeField("R7WZSTP", "R7WZSTP", JdeDataType.String, 20, true, true),
        new JdeField("R7LNGP", "R7LNGP", JdeDataType.String, 4, true, true),
        new JdeField("R7STPORD", "R7STPORD", JdeDataType.Numeric),
        new JdeField("R7HIDE", "R7HIDE", JdeDataType.String, 2),
        new JdeField("R7PID", "R7PID", JdeDataType.String, 20),
        new JdeField("R7USER", "R7USER", JdeDataType.String, 20),
        new JdeField("R7MKEY", "R7MKEY", JdeDataType.String, 30),
        new JdeField("R7UPMJ", "R7UPMJ", JdeDataType.Numeric),
        new JdeField("R7UPMT", "R7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08460_0", "Primary Key on R7PSTCAT, R7WZSTP, R7LNGP", new[] { "R7PSTCAT", "R7WZSTP", "R7LNGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08460_2", "Index on R7PSTCAT, R7LNGP", new[] { "R7PSTCAT", "R7LNGP" }),
        new JdeIndex("F08460_3", "Index on R7PSTCAT, R7STPORD", new[] { "R7PSTCAT", "R7STPORD" })
    };
}
