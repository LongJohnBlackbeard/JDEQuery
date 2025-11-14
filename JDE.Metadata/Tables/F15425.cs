using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15425 - .
/// </summary>
public class F15425 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCCO.
        /// </summary>
        public const string TCCO = "TCCO";

        /// <summary>
        /// TCLNID.
        /// </summary>
        public const string TCLNID = "TCLNID";

        /// <summary>
        /// TCDOCO.
        /// </summary>
        public const string TCDOCO = "TCDOCO";

        /// <summary>
        /// TCLSVR.
        /// </summary>
        public const string TCLSVR = "TCLSVR";

        /// <summary>
        /// TCGENT.
        /// </summary>
        public const string TCGENT = "TCGENT";

        /// <summary>
        /// TCGLC.
        /// </summary>
        public const string TCGLC = "TCGLC";

        /// <summary>
        /// TCTRAN.
        /// </summary>
        public const string TCTRAN = "TCTRAN";

        /// <summary>
        /// TCMCU.
        /// </summary>
        public const string TCMCU = "TCMCU";

        /// <summary>
        /// TCUNIT.
        /// </summary>
        public const string TCUNIT = "TCUNIT";

        /// <summary>
        /// TCUTTY.
        /// </summary>
        public const string TCUTTY = "TCUTTY";

        /// <summary>
        /// TCAN8.
        /// </summary>
        public const string TCAN8 = "TCAN8";

        /// <summary>
        /// TCAN8J.
        /// </summary>
        public const string TCAN8J = "TCAN8J";

        /// <summary>
        /// TCDBAN.
        /// </summary>
        public const string TCDBAN = "TCDBAN";

        /// <summary>
        /// TCMCUS.
        /// </summary>
        public const string TCMCUS = "TCMCUS";

        /// <summary>
        /// TCOBJ.
        /// </summary>
        public const string TCOBJ = "TCOBJ";

        /// <summary>
        /// TCSUB.
        /// </summary>
        public const string TCSUB = "TCSUB";

        /// <summary>
        /// TCSBL.
        /// </summary>
        public const string TCSBL = "TCSBL";

        /// <summary>
        /// TCSBLT.
        /// </summary>
        public const string TCSBLT = "TCSBLT";

        /// <summary>
        /// TCRRCC1.
        /// </summary>
        public const string TCRRCC1 = "TCRRCC1";

        /// <summary>
        /// TCRRCC2.
        /// </summary>
        public const string TCRRCC2 = "TCRRCC2";

        /// <summary>
        /// TCRRCC3.
        /// </summary>
        public const string TCRRCC3 = "TCRRCC3";

        /// <summary>
        /// TCRRCC4.
        /// </summary>
        public const string TCRRCC4 = "TCRRCC4";

        /// <summary>
        /// TCRRCC5.
        /// </summary>
        public const string TCRRCC5 = "TCRRCC5";

        /// <summary>
        /// TCRRF.
        /// </summary>
        public const string TCRRF = "TCRRF";

        /// <summary>
        /// TCCONFD.
        /// </summary>
        public const string TCCONFD = "TCCONFD";

        /// <summary>
        /// TCRDF.
        /// </summary>
        public const string TCRDF = "TCRDF";

        /// <summary>
        /// TCVALFJ.
        /// </summary>
        public const string TCVALFJ = "TCVALFJ";

        /// <summary>
        /// TCVALTJ.
        /// </summary>
        public const string TCVALTJ = "TCVALTJ";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCMKEY.
        /// </summary>
        public const string TCMKEY = "TCMKEY";

        /// <summary>
        /// TCLSET.
        /// </summary>
        public const string TCLSET = "TCLSET";
    }

    /// <inheritdoc />
    public override string TableName => "F15425";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCCO", "TCCO", JdeDataType.String, 10, true, true),
        new JdeField("TCLNID", "TCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TCDOCO", "TCDOCO", JdeDataType.Numeric),
        new JdeField("TCLSVR", "TCLSVR", JdeDataType.Numeric),
        new JdeField("TCGENT", "TCGENT", JdeDataType.String, 2),
        new JdeField("TCGLC", "TCGLC", JdeDataType.String, 8),
        new JdeField("TCTRAN", "TCTRAN", JdeDataType.String, 2),
        new JdeField("TCMCU", "TCMCU", JdeDataType.String, 24),
        new JdeField("TCUNIT", "TCUNIT", JdeDataType.String, 16),
        new JdeField("TCUTTY", "TCUTTY", JdeDataType.String, 10),
        new JdeField("TCAN8", "TCAN8", JdeDataType.Numeric),
        new JdeField("TCAN8J", "TCAN8J", JdeDataType.Numeric),
        new JdeField("TCDBAN", "TCDBAN", JdeDataType.Numeric),
        new JdeField("TCMCUS", "TCMCUS", JdeDataType.String, 24),
        new JdeField("TCOBJ", "TCOBJ", JdeDataType.String, 12),
        new JdeField("TCSUB", "TCSUB", JdeDataType.String, 16),
        new JdeField("TCSBL", "TCSBL", JdeDataType.String, 16),
        new JdeField("TCSBLT", "TCSBLT", JdeDataType.String, 2),
        new JdeField("TCRRCC1", "TCRRCC1", JdeDataType.String, 20),
        new JdeField("TCRRCC2", "TCRRCC2", JdeDataType.String, 20),
        new JdeField("TCRRCC3", "TCRRCC3", JdeDataType.String, 20),
        new JdeField("TCRRCC4", "TCRRCC4", JdeDataType.String, 20),
        new JdeField("TCRRCC5", "TCRRCC5", JdeDataType.String, 20),
        new JdeField("TCRRF", "TCRRF", JdeDataType.String, 2),
        new JdeField("TCCONFD", "TCCONFD", JdeDataType.Numeric),
        new JdeField("TCRDF", "TCRDF", JdeDataType.String, 2),
        new JdeField("TCVALFJ", "TCVALFJ", JdeDataType.Numeric),
        new JdeField("TCVALTJ", "TCVALTJ", JdeDataType.Numeric),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCMKEY", "TCMKEY", JdeDataType.String, 30),
        new JdeField("TCLSET", "TCLSET", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15425_0", "Primary Key on TCCO, TCLNID", new[] { "TCCO", "TCLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15425_2", "Index on TCCO, SYS_NC00035$", new[] { "TCCO", "SYS_NC00035$" })
    };
}
