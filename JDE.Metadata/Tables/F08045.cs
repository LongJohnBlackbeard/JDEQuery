using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08045 - .
/// </summary>
public class F08045 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HTDTAI.
        /// </summary>
        public const string HTDTAI = "HTDTAI";

        /// <summary>
        /// HTETDT.
        /// </summary>
        public const string HTETDT = "HTETDT";

        /// <summary>
        /// HTTRS.
        /// </summary>
        public const string HTTRS = "HTTRS";

        /// <summary>
        /// HTEFTO.
        /// </summary>
        public const string HTEFTO = "HTEFTO";

        /// <summary>
        /// HTAN8.
        /// </summary>
        public const string HTAN8 = "HTAN8";

        /// <summary>
        /// HTEOT.
        /// </summary>
        public const string HTEOT = "HTEOT";

        /// <summary>
        /// HTUSER.
        /// </summary>
        public const string HTUSER = "HTUSER";

        /// <summary>
        /// HTPID.
        /// </summary>
        public const string HTPID = "HTPID";

        /// <summary>
        /// HTUPMJ.
        /// </summary>
        public const string HTUPMJ = "HTUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08045";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HTDTAI", "HTDTAI", JdeDataType.String, 20, true, true),
        new JdeField("HTETDT", "HTETDT", JdeDataType.String, 24, true, true),
        new JdeField("HTTRS", "HTTRS", JdeDataType.String, 6, true, true),
        new JdeField("HTEFTO", "HTEFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("HTAN8", "HTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HTEOT", "HTEOT", JdeDataType.String, 2),
        new JdeField("HTUSER", "HTUSER", JdeDataType.String, 20),
        new JdeField("HTPID", "HTPID", JdeDataType.String, 20),
        new JdeField("HTUPMJ", "HTUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08045_0", "Primary Key on HTDTAI, HTETDT, HTTRS, HTEFTO, HTAN8", new[] { "HTDTAI", "HTETDT", "HTTRS", "HTEFTO", "HTAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08045_3", "Index on HTDTAI, HTETDT, HTEFTO, SYS_NC00010$", new[] { "HTDTAI", "HTETDT", "HTEFTO", "SYS_NC00010$" }),
        new JdeIndex("F08045_4", "Index on HTAN8, HTDTAI, SYS_NC00011$", new[] { "HTAN8", "HTDTAI", "SYS_NC00011$" }),
        new JdeIndex("F08045_5", "Index on HTDTAI, HTEFTO, SYS_NC00012$, HTTRS", new[] { "HTDTAI", "HTEFTO", "SYS_NC00012$", "HTTRS" })
    };
}
