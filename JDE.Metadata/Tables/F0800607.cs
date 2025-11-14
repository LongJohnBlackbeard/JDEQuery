using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800607 - .
/// </summary>
public class F0800607 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCOTPS.
        /// </summary>
        public const string JCOTPS = "JCOTPS";

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
    public override string TableName => "F0800607";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric),
        new JdeField("JCPUKID", "JCPUKID", JdeDataType.Numeric),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800607_0", "Primary Key on JCOTPS, JCJCC, JCEFTB, JCEFTE", new[] { "JCOTPS", "JCJCC", "JCEFTB", "JCEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0800607_2", "Index on JCOTPS, JCJCC, SYS_NC00012$", new[] { "JCOTPS", "JCJCC", "SYS_NC00012$" }),
        new JdeIndex("F0800607_4", "Index on JCOTPS, JCJCC, SYS_NC00013$", new[] { "JCOTPS", "JCJCC", "SYS_NC00013$" }),
        new JdeIndex("F0800607_5", "Index on JCOTPS, JCJCC", new[] { "JCOTPS", "JCJCC" })
    };
}
