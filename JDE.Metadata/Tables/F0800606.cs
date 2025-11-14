using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0800606 - .
/// </summary>
public class F0800606 : JdeTable
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
        /// JCRULEN.
        /// </summary>
        public const string JCRULEN = "JCRULEN";

        /// <summary>
        /// JCCMPE.
        /// </summary>
        public const string JCCMPE = "JCCMPE";

        /// <summary>
        /// JCCMPC.
        /// </summary>
        public const string JCCMPC = "JCCMPC";

        /// <summary>
        /// JCREQL.
        /// </summary>
        public const string JCREQL = "JCREQL";

        /// <summary>
        /// JCLOWC.
        /// </summary>
        public const string JCLOWC = "JCLOWC";

        /// <summary>
        /// JCHIGHC.
        /// </summary>
        public const string JCHIGHC = "JCHIGHC";

        /// <summary>
        /// JCLVWT.
        /// </summary>
        public const string JCLVWT = "JCLVWT";

        /// <summary>
        /// JCCOPTN.
        /// </summary>
        public const string JCCOPTN = "JCCOPTN";

        /// <summary>
        /// JCOTPS.
        /// </summary>
        public const string JCOTPS = "JCOTPS";

        /// <summary>
        /// JCPFMTH.
        /// </summary>
        public const string JCPFMTH = "JCPFMTH";

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

        /// <summary>
        /// JCACCOMP.
        /// </summary>
        public const string JCACCOMP = "JCACCOMP";
    }

    /// <inheritdoc />
    public override string TableName => "F0800606";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCJCC", "JCJCC", JdeDataType.String, 20),
        new JdeField("JCUKID", "JCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCEFTE", "JCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("JCRULEN", "JCRULEN", JdeDataType.Numeric, null, true, true),
        new JdeField("JCCMPE", "JCCMPE", JdeDataType.String, 6),
        new JdeField("JCCMPC", "JCCMPC", JdeDataType.String, 20),
        new JdeField("JCREQL", "JCREQL", JdeDataType.Numeric),
        new JdeField("JCLOWC", "JCLOWC", JdeDataType.Numeric),
        new JdeField("JCHIGHC", "JCHIGHC", JdeDataType.Numeric),
        new JdeField("JCLVWT", "JCLVWT", JdeDataType.Numeric),
        new JdeField("JCCOPTN", "JCCOPTN", JdeDataType.String, 6),
        new JdeField("JCOTPS", "JCOTPS", JdeDataType.String, 6, true, true),
        new JdeField("JCPFMTH", "JCPFMTH", JdeDataType.String, 2),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCJOBN", "JCJOBN", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric),
        new JdeField("JCACCOMP", "JCACCOMP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0800606_0", "Primary Key on JCUKID, JCEFTB, JCEFTE, JCRULEN, JCOTPS", new[] { "JCUKID", "JCEFTB", "JCEFTE", "JCRULEN", "JCOTPS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0800606_2", "Index on JCUKID, SYS_NC00021$, JCRULEN, JCOTPS", new[] { "JCUKID", "SYS_NC00021$", "JCRULEN", "JCOTPS" }),
        new JdeIndex("F0800606_3", "Index on JCUKID, SYS_NC00021$, SYS_NC00022$, SYS_NC00023$, JCOTPS", new[] { "JCUKID", "SYS_NC00021$", "SYS_NC00022$", "SYS_NC00023$", "JCOTPS" }),
        new JdeIndex("F0800606_4", "Index on JCUKID, SYS_NC00022$, JCRULEN, JCOTPS", new[] { "JCUKID", "SYS_NC00022$", "JCRULEN", "JCOTPS" }),
        new JdeIndex("F0800606_6", "Index on JCUKID, SYS_NC00024$, JCOTPS", new[] { "JCUKID", "SYS_NC00024$", "JCOTPS" }),
        new JdeIndex("F0800606_7", "Index on JCUKID, JCRULEN, JCOTPS", new[] { "JCUKID", "JCRULEN", "JCOTPS" })
    };
}
