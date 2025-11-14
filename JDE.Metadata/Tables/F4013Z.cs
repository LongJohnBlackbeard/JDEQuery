using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4013Z - .
/// </summary>
public class F4013Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KSEDOC.
        /// </summary>
        public const string KSEDOC = "KSEDOC";

        /// <summary>
        /// KSEDCT.
        /// </summary>
        public const string KSEDCT = "KSEDCT";

        /// <summary>
        /// KSEKCO.
        /// </summary>
        public const string KSEKCO = "KSEKCO";

        /// <summary>
        /// KSKTLN.
        /// </summary>
        public const string KSKTLN = "KSKTLN";

        /// <summary>
        /// KSITM.
        /// </summary>
        public const string KSITM = "KSITM";

        /// <summary>
        /// KSCPNT.
        /// </summary>
        public const string KSCPNT = "KSCPNT";

        /// <summary>
        /// KSKIT.
        /// </summary>
        public const string KSKIT = "KSKIT";

        /// <summary>
        /// KSSOQS.
        /// </summary>
        public const string KSSOQS = "KSSOQS";

        /// <summary>
        /// KSSOBK.
        /// </summary>
        public const string KSSOBK = "KSSOBK";

        /// <summary>
        /// KSEDLN.
        /// </summary>
        public const string KSEDLN = "KSEDLN";

        /// <summary>
        /// KSDRQJ.
        /// </summary>
        public const string KSDRQJ = "KSDRQJ";

        /// <summary>
        /// KSUPRC.
        /// </summary>
        public const string KSUPRC = "KSUPRC";

        /// <summary>
        /// KSUNCS.
        /// </summary>
        public const string KSUNCS = "KSUNCS";

        /// <summary>
        /// KSUOM.
        /// </summary>
        public const string KSUOM = "KSUOM";

        /// <summary>
        /// KSUOM4.
        /// </summary>
        public const string KSUOM4 = "KSUOM4";

        /// <summary>
        /// KSUORG.
        /// </summary>
        public const string KSUORG = "KSUORG";

        /// <summary>
        /// KSCMCU.
        /// </summary>
        public const string KSCMCU = "KSCMCU";

        /// <summary>
        /// KSACTN.
        /// </summary>
        public const string KSACTN = "KSACTN";

        /// <summary>
        /// KSLNTY.
        /// </summary>
        public const string KSLNTY = "KSLNTY";

        /// <summary>
        /// KSLTTR.
        /// </summary>
        public const string KSLTTR = "KSLTTR";

        /// <summary>
        /// KSNXTR.
        /// </summary>
        public const string KSNXTR = "KSNXTR";
    }

    /// <inheritdoc />
    public override string TableName => "F4013Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KSEDOC", "KSEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("KSEDCT", "KSEDCT", JdeDataType.String, 4, true, true),
        new JdeField("KSEKCO", "KSEKCO", JdeDataType.String, 10, true, true),
        new JdeField("KSKTLN", "KSKTLN", JdeDataType.Numeric, null, true, true),
        new JdeField("KSITM", "KSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("KSCPNT", "KSCPNT", JdeDataType.Numeric, null, true, true),
        new JdeField("KSKIT", "KSKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("KSSOQS", "KSSOQS", JdeDataType.Numeric),
        new JdeField("KSSOBK", "KSSOBK", JdeDataType.Numeric),
        new JdeField("KSEDLN", "KSEDLN", JdeDataType.Numeric),
        new JdeField("KSDRQJ", "KSDRQJ", JdeDataType.Numeric),
        new JdeField("KSUPRC", "KSUPRC", JdeDataType.Numeric),
        new JdeField("KSUNCS", "KSUNCS", JdeDataType.Numeric),
        new JdeField("KSUOM", "KSUOM", JdeDataType.String, 4),
        new JdeField("KSUOM4", "KSUOM4", JdeDataType.String, 4),
        new JdeField("KSUORG", "KSUORG", JdeDataType.Numeric),
        new JdeField("KSCMCU", "KSCMCU", JdeDataType.String, 24),
        new JdeField("KSACTN", "KSACTN", JdeDataType.String, 2),
        new JdeField("KSLNTY", "KSLNTY", JdeDataType.String, 4),
        new JdeField("KSLTTR", "KSLTTR", JdeDataType.String, 6),
        new JdeField("KSNXTR", "KSNXTR", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4013Z_0", "Primary Key on KSEDOC, KSEDCT, KSEKCO, KSKTLN, KSITM, KSCPNT, KSKIT", new[] { "KSEDOC", "KSEDCT", "KSEKCO", "KSKTLN", "KSITM", "KSCPNT", "KSKIT" }, isUnique: true, isPrimaryKey: true)
    };
}
