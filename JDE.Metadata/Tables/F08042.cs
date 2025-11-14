using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08042 - .
/// </summary>
public class F08042 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JWFILE.
        /// </summary>
        public const string JWFILE = "JWFILE";

        /// <summary>
        /// JWAN8.
        /// </summary>
        public const string JWAN8 = "JWAN8";

        /// <summary>
        /// JWDTAI.
        /// </summary>
        public const string JWDTAI = "JWDTAI";

        /// <summary>
        /// JWHSTD.
        /// </summary>
        public const string JWHSTD = "JWHSTD";

        /// <summary>
        /// JWUSER.
        /// </summary>
        public const string JWUSER = "JWUSER";

        /// <summary>
        /// JWEFTO.
        /// </summary>
        public const string JWEFTO = "JWEFTO";

        /// <summary>
        /// JWUPMJ.
        /// </summary>
        public const string JWUPMJ = "JWUPMJ";

        /// <summary>
        /// JWPID.
        /// </summary>
        public const string JWPID = "JWPID";

        /// <summary>
        /// JWTRS.
        /// </summary>
        public const string JWTRS = "JWTRS";

        /// <summary>
        /// JWSEQ#.
        /// </summary>
        public const string JWSEQ_ = "JWSEQ#";

        /// <summary>
        /// JWJOBN.
        /// </summary>
        public const string JWJOBN = "JWJOBN";

        /// <summary>
        /// JWHSTN.
        /// </summary>
        public const string JWHSTN = "JWHSTN";
    }

    /// <inheritdoc />
    public override string TableName => "F08042";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JWFILE", "JWFILE", JdeDataType.String, 20, true, true),
        new JdeField("JWAN8", "JWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JWDTAI", "JWDTAI", JdeDataType.String, 20, true, true),
        new JdeField("JWHSTD", "JWHSTD", JdeDataType.String, 60),
        new JdeField("JWUSER", "JWUSER", JdeDataType.String, 20),
        new JdeField("JWEFTO", "JWEFTO", JdeDataType.Numeric, null, true, true),
        new JdeField("JWUPMJ", "JWUPMJ", JdeDataType.Numeric),
        new JdeField("JWPID", "JWPID", JdeDataType.String, 20),
        new JdeField("JWTRS", "JWTRS", JdeDataType.String, 6),
        new JdeField("JWSEQ#", "JWSEQ#", JdeDataType.Numeric, null, true, true),
        new JdeField("JWJOBN", "JWJOBN", JdeDataType.String, 20),
        new JdeField("JWHSTN", "JWHSTN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08042_0", "Primary Key on JWFILE, JWAN8, JWDTAI, JWEFTO, JWSEQ#", new[] { "JWFILE", "JWAN8", "JWDTAI", "JWEFTO", "JWSEQ#" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08042_2", "Index on JWFILE, JWDTAI, JWAN8, SYS_NC00013$, JWSEQ#", new[] { "JWFILE", "JWDTAI", "JWAN8", "SYS_NC00013$", "JWSEQ#" }),
        new JdeIndex("F08042_3", "Index on JWFILE, JWAN8, JWDTAI, SYS_NC00013$, SYS_NC00014$", new[] { "JWFILE", "JWAN8", "JWDTAI", "SYS_NC00013$", "SYS_NC00014$" })
    };
}
