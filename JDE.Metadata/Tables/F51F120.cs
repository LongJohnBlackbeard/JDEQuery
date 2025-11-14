using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F120 - .
/// </summary>
public class F51F120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QK51FFID.
        /// </summary>
        public const string QK51FFID = "QK51FFID";

        /// <summary>
        /// QK51FFHID.
        /// </summary>
        public const string QK51FFHID = "QK51FFHID";

        /// <summary>
        /// QKMCU.
        /// </summary>
        public const string QKMCU = "QKMCU";

        /// <summary>
        /// QK51FNAME.
        /// </summary>
        public const string QK51FNAME = "QK51FNAME";

        /// <summary>
        /// QK51FSTATS.
        /// </summary>
        public const string QK51FSTATS = "QK51FSTATS";

        /// <summary>
        /// QK51FFBD.
        /// </summary>
        public const string QK51FFBD = "QK51FFBD";

        /// <summary>
        /// QK51FFBT.
        /// </summary>
        public const string QK51FFBT = "QK51FFBT";

        /// <summary>
        /// QKDGJ.
        /// </summary>
        public const string QKDGJ = "QKDGJ";

        /// <summary>
        /// QK51FPF.
        /// </summary>
        public const string QK51FPF = "QK51FPF";

        /// <summary>
        /// QKTORG.
        /// </summary>
        public const string QKTORG = "QKTORG";

        /// <summary>
        /// QKENTJ.
        /// </summary>
        public const string QKENTJ = "QKENTJ";

        /// <summary>
        /// QKTENT.
        /// </summary>
        public const string QKTENT = "QKTENT";

        /// <summary>
        /// QKUSER.
        /// </summary>
        public const string QKUSER = "QKUSER";

        /// <summary>
        /// QKUPMJ.
        /// </summary>
        public const string QKUPMJ = "QKUPMJ";

        /// <summary>
        /// QKUPMT.
        /// </summary>
        public const string QKUPMT = "QKUPMT";

        /// <summary>
        /// QKJOBN.
        /// </summary>
        public const string QKJOBN = "QKJOBN";

        /// <summary>
        /// QKPID.
        /// </summary>
        public const string QKPID = "QKPID";

        /// <summary>
        /// QKMKEY.
        /// </summary>
        public const string QKMKEY = "QKMKEY";

        /// <summary>
        /// QKPN.
        /// </summary>
        public const string QKPN = "QKPN";

        /// <summary>
        /// QKFY.
        /// </summary>
        public const string QKFY = "QKFY";

        /// <summary>
        /// QKCTRY.
        /// </summary>
        public const string QKCTRY = "QKCTRY";
    }

    /// <inheritdoc />
    public override string TableName => "F51F120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QK51FFID", "QK51FFID", JdeDataType.Numeric, null, true, true),
        new JdeField("QK51FFHID", "QK51FFHID", JdeDataType.Numeric, null, true, true),
        new JdeField("QKMCU", "QKMCU", JdeDataType.String, 24),
        new JdeField("QK51FNAME", "QK51FNAME", JdeDataType.String, 60),
        new JdeField("QK51FSTATS", "QK51FSTATS", JdeDataType.String, 4),
        new JdeField("QK51FFBD", "QK51FFBD", JdeDataType.Numeric),
        new JdeField("QK51FFBT", "QK51FFBT", JdeDataType.Numeric),
        new JdeField("QKDGJ", "QKDGJ", JdeDataType.Numeric),
        new JdeField("QK51FPF", "QK51FPF", JdeDataType.String, 2),
        new JdeField("QKTORG", "QKTORG", JdeDataType.String, 20),
        new JdeField("QKENTJ", "QKENTJ", JdeDataType.Numeric),
        new JdeField("QKTENT", "QKTENT", JdeDataType.Numeric),
        new JdeField("QKUSER", "QKUSER", JdeDataType.String, 20),
        new JdeField("QKUPMJ", "QKUPMJ", JdeDataType.Numeric),
        new JdeField("QKUPMT", "QKUPMT", JdeDataType.Numeric),
        new JdeField("QKJOBN", "QKJOBN", JdeDataType.String, 20),
        new JdeField("QKPID", "QKPID", JdeDataType.String, 20),
        new JdeField("QKMKEY", "QKMKEY", JdeDataType.String, 30),
        new JdeField("QKPN", "QKPN", JdeDataType.Numeric),
        new JdeField("QKFY", "QKFY", JdeDataType.Numeric),
        new JdeField("QKCTRY", "QKCTRY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F120_0", "Primary Key on QK51FFID, QK51FFHID", new[] { "QK51FFID", "QK51FFHID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51F120_2", "Index on SYS_NC00022$, QKMCU, SYS_NC00023$", new[] { "SYS_NC00022$", "QKMCU", "SYS_NC00023$" })
    };
}
