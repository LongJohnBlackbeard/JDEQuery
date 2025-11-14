using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800601 - .
/// </summary>
public class F0800601 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCORMCU.
        /// </summary>
        public const string JCORMCU = "JCORMCU";

        /// <summary>
        /// JCJBCD.
        /// </summary>
        public const string JCJBCD = "JCJBCD";

        /// <summary>
        /// JCJBST.
        /// </summary>
        public const string JCJBST = "JCJBST";

        /// <summary>
        /// JCEFTB.
        /// </summary>
        public const string JCEFTB = "JCEFTB";

        /// <summary>
        /// JCEFTE.
        /// </summary>
        public const string JCEFTE = "JCEFTE";

        /// <summary>
        /// JCOTPS.
        /// </summary>
        public const string JCOTPS = "JCOTPS";

        /// <summary>
        /// JCUSER.
        /// </summary>
        public const string JCUSER = "JCUSER";

        /// <summary>
        /// JCPID.
        /// </summary>
        public const string JCPID = "JCPID";

        /// <summary>
        /// JCJOBN.
        /// </summary>
        public const string JCJOBN = "JCJOBN";

        /// <summary>
        /// JCUPMJ.
        /// </summary>
        public const string JCUPMJ = "JCUPMJ";

        /// <summary>
        /// JCUPMT.
        /// </summary>
        public const string JCUPMT = "JCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0800601";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCORMCU", "JCORMCU", JdeDataType.String, 24, true, true),
        new JdeField("JCJBCD", "JCJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JCJBST", "JCJBST", JdeDataType.String, 8, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800601_0", "Primary Key on JCORMCU, JCJBCD, JCJBST, JCEFTB, JCEFTE, JCOTPS", new[] { "JCORMCU", "JCJBCD", "JCJBST", "JCEFTB", "JCEFTE", "JCOTPS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0800601_3", "Index on JCORMCU, JCJBCD, JCJBST, SYS_NC00012$, JCOTPS", new[] { "JCORMCU", "JCJBCD", "JCJBST", "SYS_NC00012$", "JCOTPS" }),
        new JdeIndex("F0800601_5", "Index on JCORMCU, JCJBCD, JCJBST, SYS_NC00013$, JCOTPS", new[] { "JCORMCU", "JCJBCD", "JCJBST", "SYS_NC00013$", "JCOTPS" }),
        new JdeIndex("F0800601_6", "Index on JCOTPS, JCORMCU, JCJBCD, JCJBST", new[] { "JCOTPS", "JCORMCU", "JCJBCD", "JCJBST" })
    };
}
