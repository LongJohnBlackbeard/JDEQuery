using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q413 - .
/// </summary>
public class F43Q413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHEVNU.
        /// </summary>
        public const string RHEVNU = "RHEVNU";

        /// <summary>
        /// RHDCTO.
        /// </summary>
        public const string RHDCTO = "RHDCTO";

        /// <summary>
        /// RHKCOO.
        /// </summary>
        public const string RHKCOO = "RHKCOO";

        /// <summary>
        /// RHEVLN.
        /// </summary>
        public const string RHEVLN = "RHEVLN";

        /// <summary>
        /// RHBIDNUM.
        /// </summary>
        public const string RHBIDNUM = "RHBIDNUM";

        /// <summary>
        /// RHAN8.
        /// </summary>
        public const string RHAN8 = "RHAN8";

        /// <summary>
        /// RHBIDQN.
        /// </summary>
        public const string RHBIDQN = "RHBIDQN";

        /// <summary>
        /// RHPCPTN.
        /// </summary>
        public const string RHPCPTN = "RHPCPTN";

        /// <summary>
        /// RHPCPD.
        /// </summary>
        public const string RHPCPD = "RHPCPD";

        /// <summary>
        /// RHCMPUPRC.
        /// </summary>
        public const string RHCMPUPRC = "RHCMPUPRC";

        /// <summary>
        /// RHFCMPPRC.
        /// </summary>
        public const string RHFCMPPRC = "RHFCMPPRC";

        /// <summary>
        /// RHURCD.
        /// </summary>
        public const string RHURCD = "RHURCD";

        /// <summary>
        /// RHURDT.
        /// </summary>
        public const string RHURDT = "RHURDT";

        /// <summary>
        /// RHURAT.
        /// </summary>
        public const string RHURAT = "RHURAT";

        /// <summary>
        /// RHURAB.
        /// </summary>
        public const string RHURAB = "RHURAB";

        /// <summary>
        /// RHURRF.
        /// </summary>
        public const string RHURRF = "RHURRF";

        /// <summary>
        /// RHTORG.
        /// </summary>
        public const string RHTORG = "RHTORG";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHTDAY.
        /// </summary>
        public const string RHTDAY = "RHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHEVNU", "RHEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDCTO", "RHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RHKCOO", "RHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RHEVLN", "RHEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RHBIDNUM", "RHBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RHAN8", "RHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RHBIDQN", "RHBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RHPCPTN", "RHPCPTN", JdeDataType.Numeric, null, true, true),
        new JdeField("RHPCPD", "RHPCPD", JdeDataType.String, 80),
        new JdeField("RHCMPUPRC", "RHCMPUPRC", JdeDataType.Numeric),
        new JdeField("RHFCMPPRC", "RHFCMPPRC", JdeDataType.Numeric),
        new JdeField("RHURCD", "RHURCD", JdeDataType.String, 4),
        new JdeField("RHURDT", "RHURDT", JdeDataType.Numeric),
        new JdeField("RHURAT", "RHURAT", JdeDataType.Numeric),
        new JdeField("RHURAB", "RHURAB", JdeDataType.Numeric),
        new JdeField("RHURRF", "RHURRF", JdeDataType.String, 30),
        new JdeField("RHTORG", "RHTORG", JdeDataType.String, 20),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q413_0", "Primary Key on RHEVNU, RHDCTO, RHKCOO, RHEVLN, RHBIDNUM, RHAN8, RHBIDQN, RHPCPTN", new[] { "RHEVNU", "RHDCTO", "RHKCOO", "RHEVLN", "RHBIDNUM", "RHAN8", "RHBIDQN", "RHPCPTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q413_2", "Index on RHEVNU, RHDCTO, RHKCOO, RHBIDNUM, RHAN8", new[] { "RHEVNU", "RHDCTO", "RHKCOO", "RHBIDNUM", "RHAN8" }),
        new JdeIndex("F43Q413_3", "Index on RHEVNU, RHDCTO, RHKCOO, RHAN8, RHBIDNUM, RHEVLN, RHBIDQN, RHPCPTN", new[] { "RHEVNU", "RHDCTO", "RHKCOO", "RHAN8", "RHBIDNUM", "RHEVLN", "RHBIDQN", "RHPCPTN" })
    };
}
