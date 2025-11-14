using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800611 - .
/// </summary>
public class F0800611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCJCC.
        /// </summary>
        public const string JCJCC = "JCJCC";

        /// <summary>
        /// JCUKID.
        /// </summary>
        public const string JCUKID = "JCUKID";

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
        /// JCINCLG.
        /// </summary>
        public const string JCINCLG = "JCINCLG";

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
    public override string TableName => "F0800611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JCINCLG", "JCINCLG", JdeDataType.Numeric),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800611_0", "Primary Key on JCUKID, JCEFTB, JCEFTE, JCOTPS", new[] { "JCUKID", "JCEFTB", "JCEFTE", "JCOTPS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0800611_2", "Index on JCUKID, SYS_NC00012$, JCOTPS", new[] { "JCUKID", "SYS_NC00012$", "JCOTPS" }),
        new JdeIndex("F0800611_4", "Index on JCOTPS, JCUKID", new[] { "JCOTPS", "JCUKID" })
    };
}
