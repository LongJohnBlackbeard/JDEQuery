using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B423 - .
/// </summary>
public class F03B423 : JdeTable
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
        /// TCDCTO.
        /// </summary>
        public const string TCDCTO = "TCDCTO";

        /// <summary>
        /// TCLNTY.
        /// </summary>
        public const string TCLNTY = "TCLNTY";

        /// <summary>
        /// TCEMCU.
        /// </summary>
        public const string TCEMCU = "TCEMCU";

        /// <summary>
        /// TCBSFH.
        /// </summary>
        public const string TCBSFH = "TCBSFH";

        /// <summary>
        /// TCSHAN.
        /// </summary>
        public const string TCSHAN = "TCSHAN";

        /// <summary>
        /// TCAN8.
        /// </summary>
        public const string TCAN8 = "TCAN8";

        /// <summary>
        /// TCSHCTR.
        /// </summary>
        public const string TCSHCTR = "TCSHCTR";

        /// <summary>
        /// TCSOCTR.
        /// </summary>
        public const string TCSOCTR = "TCSOCTR";

        /// <summary>
        /// TCSTCTR.
        /// </summary>
        public const string TCSTCTR = "TCSTCTR";

        /// <summary>
        /// TCACV1.
        /// </summary>
        public const string TCACV1 = "TCACV1";

        /// <summary>
        /// TCACV2.
        /// </summary>
        public const string TCACV2 = "TCACV2";

        /// <summary>
        /// TCFRTH.
        /// </summary>
        public const string TCFRTH = "TCFRTH";

        /// <summary>
        /// TCCARS.
        /// </summary>
        public const string TCCARS = "TCCARS";

        /// <summary>
        /// TCMOT.
        /// </summary>
        public const string TCMOT = "TCMOT";

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
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F03B423";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCCO", "TCCO", JdeDataType.String, 10, true, true),
        new JdeField("TCLNID", "TCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TCDCTO", "TCDCTO", JdeDataType.String, 4),
        new JdeField("TCLNTY", "TCLNTY", JdeDataType.String, 4),
        new JdeField("TCEMCU", "TCEMCU", JdeDataType.String, 24),
        new JdeField("TCBSFH", "TCBSFH", JdeDataType.Numeric),
        new JdeField("TCSHAN", "TCSHAN", JdeDataType.Numeric),
        new JdeField("TCAN8", "TCAN8", JdeDataType.Numeric),
        new JdeField("TCSHCTR", "TCSHCTR", JdeDataType.String, 6),
        new JdeField("TCSOCTR", "TCSOCTR", JdeDataType.String, 6),
        new JdeField("TCSTCTR", "TCSTCTR", JdeDataType.String, 6),
        new JdeField("TCACV1", "TCACV1", JdeDataType.String, 6),
        new JdeField("TCACV2", "TCACV2", JdeDataType.String, 6),
        new JdeField("TCFRTH", "TCFRTH", JdeDataType.String, 6),
        new JdeField("TCCARS", "TCCARS", JdeDataType.Numeric),
        new JdeField("TCMOT", "TCMOT", JdeDataType.String, 6),
        new JdeField("TCRRF", "TCRRF", JdeDataType.String, 2),
        new JdeField("TCCONFD", "TCCONFD", JdeDataType.Numeric),
        new JdeField("TCRDF", "TCRDF", JdeDataType.String, 2),
        new JdeField("TCVALFJ", "TCVALFJ", JdeDataType.Numeric),
        new JdeField("TCVALTJ", "TCVALTJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B423_0", "Primary Key on TCCO, TCLNID", new[] { "TCCO", "TCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
