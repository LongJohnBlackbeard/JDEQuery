using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6205 - .
/// </summary>
public class F76H6205 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRH76LECO.
        /// </summary>
        public const string IRH76LECO = "IRH76LECO";

        /// <summary>
        /// IRCFY.
        /// </summary>
        public const string IRCFY = "IRCFY";

        /// <summary>
        /// IRFFP.
        /// </summary>
        public const string IRFFP = "IRFFP";

        /// <summary>
        /// IRITM.
        /// </summary>
        public const string IRITM = "IRITM";

        /// <summary>
        /// IRMCU.
        /// </summary>
        public const string IRMCU = "IRMCU";

        /// <summary>
        /// IRLOCN.
        /// </summary>
        public const string IRLOCN = "IRLOCN";

        /// <summary>
        /// IRLOTN.
        /// </summary>
        public const string IRLOTN = "IRLOTN";

        /// <summary>
        /// IRLEDG.
        /// </summary>
        public const string IRLEDG = "IRLEDG";

        /// <summary>
        /// IRGLPT.
        /// </summary>
        public const string IRGLPT = "IRGLPT";

        /// <summary>
        /// IRMCUS.
        /// </summary>
        public const string IRMCUS = "IRMCUS";

        /// <summary>
        /// IROBJ.
        /// </summary>
        public const string IROBJ = "IROBJ";

        /// <summary>
        /// IRSUB.
        /// </summary>
        public const string IRSUB = "IRSUB";

        /// <summary>
        /// IRNQ01.
        /// </summary>
        public const string IRNQ01 = "IRNQ01";

        /// <summary>
        /// IRUNCS.
        /// </summary>
        public const string IRUNCS = "IRUNCS";

        /// <summary>
        /// IRAN01.
        /// </summary>
        public const string IRAN01 = "IRAN01";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IRTDAY.
        /// </summary>
        public const string IRTDAY = "IRTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6205";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRH76LECO", "IRH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("IRCFY", "IRCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("IRFFP", "IRFFP", JdeDataType.Numeric, null, true, true),
        new JdeField("IRITM", "IRITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IRMCU", "IRMCU", JdeDataType.String, 24, true, true),
        new JdeField("IRLOCN", "IRLOCN", JdeDataType.String, 40, true, true),
        new JdeField("IRLOTN", "IRLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IRLEDG", "IRLEDG", JdeDataType.String, 4, true, true),
        new JdeField("IRGLPT", "IRGLPT", JdeDataType.String, 8, true, true),
        new JdeField("IRMCUS", "IRMCUS", JdeDataType.String, 24, true, true),
        new JdeField("IROBJ", "IROBJ", JdeDataType.String, 12),
        new JdeField("IRSUB", "IRSUB", JdeDataType.String, 16),
        new JdeField("IRNQ01", "IRNQ01", JdeDataType.Numeric),
        new JdeField("IRUNCS", "IRUNCS", JdeDataType.Numeric),
        new JdeField("IRAN01", "IRAN01", JdeDataType.Numeric),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRTDAY", "IRTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6205_0", "Primary Key on IRH76LECO, IRCFY, IRFFP, IRITM, IRMCU, IRLOCN, IRLOTN, IRLEDG, IRGLPT, IRMCUS", new[] { "IRH76LECO", "IRCFY", "IRFFP", "IRITM", "IRMCU", "IRLOCN", "IRLOTN", "IRLEDG", "IRGLPT", "IRMCUS" }, isUnique: true, isPrimaryKey: true)
    };
}
