using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800604 - .
/// </summary>
public class F0800604 : JdeTable
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
        /// JCJCC.
        /// </summary>
        public const string JCJCC = "JCJCC";

        /// <summary>
        /// JCEFTB.
        /// </summary>
        public const string JCEFTB = "JCEFTB";

        /// <summary>
        /// JCEFTE.
        /// </summary>
        public const string JCEFTE = "JCEFTE";

        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";

        /// <summary>
        /// JCPUKID.
        /// </summary>
        public const string JCPUKID = "JCPUKID";

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
    public override string TableName => "F0800604";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCORMCU", "JCORMCU", JdeDataType.String, 24, true, true),
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric),
        new JdeField("JCPUKID", "JCPUKID", JdeDataType.Numeric),
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
        new JdeIndex("F0800604_0", "Primary Key on JCORMCU, JCJCC, JCEFTB, JCEFTE, JCOTPS", new[] { "JCORMCU", "JCJCC", "JCEFTB", "JCEFTE", "JCOTPS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0800604_2", "Index on JCORMCU, JCJCC, SYS_NC00014$, JCOTPS", new[] { "JCORMCU", "JCJCC", "SYS_NC00014$", "JCOTPS" }),
        new JdeIndex("F0800604_4", "Index on JCORMCU, JCJCC, SYS_NC00013$, JCOTPS", new[] { "JCORMCU", "JCJCC", "SYS_NC00013$", "JCOTPS" }),
        new JdeIndex("F0800604_5", "Index on JCOTPS, JCORMCU, JCJCC", new[] { "JCOTPS", "JCORMCU", "JCJCC" })
    };
}
