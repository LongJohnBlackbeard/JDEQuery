using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4343 - .
/// </summary>
public class F4343 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHMCU.
        /// </summary>
        public const string RHMCU = "RHMCU";

        /// <summary>
        /// RHAN8.
        /// </summary>
        public const string RHAN8 = "RHAN8";

        /// <summary>
        /// RHAGSQ.
        /// </summary>
        public const string RHAGSQ = "RHAGSQ";

        /// <summary>
        /// RHKCOO.
        /// </summary>
        public const string RHKCOO = "RHKCOO";

        /// <summary>
        /// RHDOCO.
        /// </summary>
        public const string RHDOCO = "RHDOCO";

        /// <summary>
        /// RHDCTO.
        /// </summary>
        public const string RHDCTO = "RHDCTO";

        /// <summary>
        /// RHSFXO.
        /// </summary>
        public const string RHSFXO = "RHSFXO";

        /// <summary>
        /// RHLNID.
        /// </summary>
        public const string RHLNID = "RHLNID";

        /// <summary>
        /// RHRBTC.
        /// </summary>
        public const string RHRBTC = "RHRBTC";

        /// <summary>
        /// RHCO.
        /// </summary>
        public const string RHCO = "RHCO";

        /// <summary>
        /// RHITM.
        /// </summary>
        public const string RHITM = "RHITM";

        /// <summary>
        /// RHOMCU.
        /// </summary>
        public const string RHOMCU = "RHOMCU";

        /// <summary>
        /// RHOBJ.
        /// </summary>
        public const string RHOBJ = "RHOBJ";

        /// <summary>
        /// RHSUB.
        /// </summary>
        public const string RHSUB = "RHSUB";

        /// <summary>
        /// RHPDP.
        /// </summary>
        public const string RHPDP = "RHPDP";

        /// <summary>
        /// RHUOM.
        /// </summary>
        public const string RHUOM = "RHUOM";

        /// <summary>
        /// RHUOM3.
        /// </summary>
        public const string RHUOM3 = "RHUOM3";

        /// <summary>
        /// RHUORG.
        /// </summary>
        public const string RHUORG = "RHUORG";

        /// <summary>
        /// RHCRCD.
        /// </summary>
        public const string RHCRCD = "RHCRCD";

        /// <summary>
        /// RHCRR.
        /// </summary>
        public const string RHCRR = "RHCRR";

        /// <summary>
        /// RHPRRC.
        /// </summary>
        public const string RHPRRC = "RHPRRC";

        /// <summary>
        /// RHAEXP.
        /// </summary>
        public const string RHAEXP = "RHAEXP";

        /// <summary>
        /// RHFRRC.
        /// </summary>
        public const string RHFRRC = "RHFRRC";

        /// <summary>
        /// RHFEA.
        /// </summary>
        public const string RHFEA = "RHFEA";

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
    public override string TableName => "F4343";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHMCU", "RHMCU", JdeDataType.String, 24),
        new JdeField("RHAN8", "RHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RHAGSQ", "RHAGSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RHKCOO", "RHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RHDOCO", "RHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RHDCTO", "RHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RHSFXO", "RHSFXO", JdeDataType.String, 6),
        new JdeField("RHLNID", "RHLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHRBTC", "RHRBTC", JdeDataType.String, 2),
        new JdeField("RHCO", "RHCO", JdeDataType.String, 10),
        new JdeField("RHITM", "RHITM", JdeDataType.Numeric),
        new JdeField("RHOMCU", "RHOMCU", JdeDataType.String, 24),
        new JdeField("RHOBJ", "RHOBJ", JdeDataType.String, 12),
        new JdeField("RHSUB", "RHSUB", JdeDataType.String, 16),
        new JdeField("RHPDP", "RHPDP", JdeDataType.String, 6),
        new JdeField("RHUOM", "RHUOM", JdeDataType.String, 4),
        new JdeField("RHUOM3", "RHUOM3", JdeDataType.String, 4),
        new JdeField("RHUORG", "RHUORG", JdeDataType.Numeric),
        new JdeField("RHCRCD", "RHCRCD", JdeDataType.String, 6),
        new JdeField("RHCRR", "RHCRR", JdeDataType.Numeric),
        new JdeField("RHPRRC", "RHPRRC", JdeDataType.Numeric),
        new JdeField("RHAEXP", "RHAEXP", JdeDataType.Numeric),
        new JdeField("RHFRRC", "RHFRRC", JdeDataType.Numeric),
        new JdeField("RHFEA", "RHFEA", JdeDataType.Numeric),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHTDAY", "RHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4343_0", "Primary Key on RHAN8, RHAGSQ, RHDCTO, RHDOCO, RHKCOO, RHLNID", new[] { "RHAN8", "RHAGSQ", "RHDCTO", "RHDOCO", "RHKCOO", "RHLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
