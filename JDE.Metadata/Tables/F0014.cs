using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0014 - .
/// </summary>
public class F0014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNPTC.
        /// </summary>
        public const string PNPTC = "PNPTC";

        /// <summary>
        /// PNPTD.
        /// </summary>
        public const string PNPTD = "PNPTD";

        /// <summary>
        /// PNDCP.
        /// </summary>
        public const string PNDCP = "PNDCP";

        /// <summary>
        /// PNDCD.
        /// </summary>
        public const string PNDCD = "PNDCD";

        /// <summary>
        /// PNNDTP.
        /// </summary>
        public const string PNNDTP = "PNNDTP";

        /// <summary>
        /// PNDDJ.
        /// </summary>
        public const string PNDDJ = "PNDDJ";

        /// <summary>
        /// PNNSP.
        /// </summary>
        public const string PNNSP = "PNNSP";

        /// <summary>
        /// PNDTPA.
        /// </summary>
        public const string PNDTPA = "PNDTPA";

        /// <summary>
        /// PNEIR.
        /// </summary>
        public const string PNEIR = "PNEIR";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNUPMT.
        /// </summary>
        public const string PNUPMT = "PNUPMT";

        /// <summary>
        /// PNPXDM.
        /// </summary>
        public const string PNPXDM = "PNPXDM";

        /// <summary>
        /// PNPXDD.
        /// </summary>
        public const string PNPXDD = "PNPXDD";
    }

    /// <inheritdoc />
    public override string TableName => "F0014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNPTC", "PNPTC", JdeDataType.String, 6, true, true),
        new JdeField("PNPTD", "PNPTD", JdeDataType.String, 60),
        new JdeField("PNDCP", "PNDCP", JdeDataType.Numeric),
        new JdeField("PNDCD", "PNDCD", JdeDataType.Numeric),
        new JdeField("PNNDTP", "PNNDTP", JdeDataType.Numeric),
        new JdeField("PNDDJ", "PNDDJ", JdeDataType.Numeric),
        new JdeField("PNNSP", "PNNSP", JdeDataType.Numeric),
        new JdeField("PNDTPA", "PNDTPA", JdeDataType.Numeric),
        new JdeField("PNEIR", "PNEIR", JdeDataType.Numeric),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20),
        new JdeField("PNUPMT", "PNUPMT", JdeDataType.Numeric),
        new JdeField("PNPXDM", "PNPXDM", JdeDataType.Numeric),
        new JdeField("PNPXDD", "PNPXDD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0014_0", "Primary Key on PNPTC", new[] { "PNPTC" }, isUnique: true, isPrimaryKey: true)
    };
}
