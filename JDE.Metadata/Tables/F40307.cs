using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40307 - .
/// </summary>
public class F40307 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LAAN8.
        /// </summary>
        public const string LAAN8 = "LAAN8";

        /// <summary>
        /// LACS07.
        /// </summary>
        public const string LACS07 = "LACS07";

        /// <summary>
        /// LAITM.
        /// </summary>
        public const string LAITM = "LAITM";

        /// <summary>
        /// LAIT07.
        /// </summary>
        public const string LAIT07 = "LAIT07";

        /// <summary>
        /// LAEFTJ.
        /// </summary>
        public const string LAEFTJ = "LAEFTJ";

        /// <summary>
        /// LAEXDJ.
        /// </summary>
        public const string LAEXDJ = "LAEXDJ";

        /// <summary>
        /// LAMNQ.
        /// </summary>
        public const string LAMNQ = "LAMNQ";

        /// <summary>
        /// LAMXQ.
        /// </summary>
        public const string LAMXQ = "LAMXQ";

        /// <summary>
        /// LAUOM.
        /// </summary>
        public const string LAUOM = "LAUOM";

        /// <summary>
        /// LATXID.
        /// </summary>
        public const string LATXID = "LATXID";

        /// <summary>
        /// LASTPR.
        /// </summary>
        public const string LASTPR = "LASTPR";

        /// <summary>
        /// LAALCM.
        /// </summary>
        public const string LAALCM = "LAALCM";

        /// <summary>
        /// LAOUOM.
        /// </summary>
        public const string LAOUOM = "LAOUOM";

        /// <summary>
        /// LAQLIM.
        /// </summary>
        public const string LAQLIM = "LAQLIM";

        /// <summary>
        /// LAPCPA.
        /// </summary>
        public const string LAPCPA = "LAPCPA";

        /// <summary>
        /// LAQPOL.
        /// </summary>
        public const string LAQPOL = "LAQPOL";

        /// <summary>
        /// LAQSLD.
        /// </summary>
        public const string LAQSLD = "LAQSLD";

        /// <summary>
        /// LAURCD.
        /// </summary>
        public const string LAURCD = "LAURCD";

        /// <summary>
        /// LAURDT.
        /// </summary>
        public const string LAURDT = "LAURDT";

        /// <summary>
        /// LAURAT.
        /// </summary>
        public const string LAURAT = "LAURAT";

        /// <summary>
        /// LAURAB.
        /// </summary>
        public const string LAURAB = "LAURAB";

        /// <summary>
        /// LAURRF.
        /// </summary>
        public const string LAURRF = "LAURRF";

        /// <summary>
        /// LAUSER.
        /// </summary>
        public const string LAUSER = "LAUSER";

        /// <summary>
        /// LAPID.
        /// </summary>
        public const string LAPID = "LAPID";

        /// <summary>
        /// LAJOBN.
        /// </summary>
        public const string LAJOBN = "LAJOBN";

        /// <summary>
        /// LAUPMJ.
        /// </summary>
        public const string LAUPMJ = "LAUPMJ";

        /// <summary>
        /// LATDAY.
        /// </summary>
        public const string LATDAY = "LATDAY";

        /// <summary>
        /// LAOSEQ.
        /// </summary>
        public const string LAOSEQ = "LAOSEQ";

        /// <summary>
        /// LAMCU.
        /// </summary>
        public const string LAMCU = "LAMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F40307";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LAAN8", "LAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LACS07", "LACS07", JdeDataType.String, 16, true, true),
        new JdeField("LAITM", "LAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LAIT07", "LAIT07", JdeDataType.String, 16, true, true),
        new JdeField("LAEFTJ", "LAEFTJ", JdeDataType.Numeric),
        new JdeField("LAEXDJ", "LAEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("LAMNQ", "LAMNQ", JdeDataType.Numeric),
        new JdeField("LAMXQ", "LAMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("LAUOM", "LAUOM", JdeDataType.String, 4, true, true),
        new JdeField("LATXID", "LATXID", JdeDataType.Numeric),
        new JdeField("LASTPR", "LASTPR", JdeDataType.String, 2),
        new JdeField("LAALCM", "LAALCM", JdeDataType.String, 2),
        new JdeField("LAOUOM", "LAOUOM", JdeDataType.String, 4),
        new JdeField("LAQLIM", "LAQLIM", JdeDataType.Numeric),
        new JdeField("LAPCPA", "LAPCPA", JdeDataType.Numeric),
        new JdeField("LAQPOL", "LAQPOL", JdeDataType.Numeric),
        new JdeField("LAQSLD", "LAQSLD", JdeDataType.Numeric),
        new JdeField("LAURCD", "LAURCD", JdeDataType.String, 4),
        new JdeField("LAURDT", "LAURDT", JdeDataType.Numeric),
        new JdeField("LAURAT", "LAURAT", JdeDataType.Numeric),
        new JdeField("LAURAB", "LAURAB", JdeDataType.Numeric),
        new JdeField("LAURRF", "LAURRF", JdeDataType.String, 30),
        new JdeField("LAUSER", "LAUSER", JdeDataType.String, 20),
        new JdeField("LAPID", "LAPID", JdeDataType.String, 20),
        new JdeField("LAJOBN", "LAJOBN", JdeDataType.String, 20),
        new JdeField("LAUPMJ", "LAUPMJ", JdeDataType.Numeric),
        new JdeField("LATDAY", "LATDAY", JdeDataType.Numeric),
        new JdeField("LAOSEQ", "LAOSEQ", JdeDataType.Numeric),
        new JdeField("LAMCU", "LAMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40307_0", "Primary Key on LAAN8, LACS07, LAITM, LAIT07, LAEXDJ, LAUOM, LAMXQ", new[] { "LAAN8", "LACS07", "LAITM", "LAIT07", "LAEXDJ", "LAUOM", "LAMXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
