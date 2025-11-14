using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4583 - .
/// </summary>
public class F76V4583 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDAN8.
        /// </summary>
        public const string TDAN8 = "TDAN8";

        /// <summary>
        /// TDAC07.
        /// </summary>
        public const string TDAC07 = "TDAC07";

        /// <summary>
        /// TDFY.
        /// </summary>
        public const string TDFY = "TDFY";

        /// <summary>
        /// TDPN.
        /// </summary>
        public const string TDPN = "TDPN";

        /// <summary>
        /// TDDCT.
        /// </summary>
        public const string TDDCT = "TDDCT";

        /// <summary>
        /// TDDOC.
        /// </summary>
        public const string TDDOC = "TDDOC";

        /// <summary>
        /// TDIRQ.
        /// </summary>
        public const string TDIRQ = "TDIRQ";

        /// <summary>
        /// TDIRBI.
        /// </summary>
        public const string TDIRBI = "TDIRBI";

        /// <summary>
        /// TDIRBF.
        /// </summary>
        public const string TDIRBF = "TDIRBF";

        /// <summary>
        /// TDIRRI.
        /// </summary>
        public const string TDIRRI = "TDIRRI";

        /// <summary>
        /// TDIRRF.
        /// </summary>
        public const string TDIRRF = "TDIRRF";

        /// <summary>
        /// TDUPMB.
        /// </summary>
        public const string TDUPMB = "TDUPMB";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76V4583";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10, true, true),
        new JdeField("TDAN8", "TDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TDAC07", "TDAC07", JdeDataType.String, 6, true, true),
        new JdeField("TDFY", "TDFY", JdeDataType.Numeric, null, true, true),
        new JdeField("TDPN", "TDPN", JdeDataType.Numeric, null, true, true),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4, true, true),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TDIRQ", "TDIRQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDIRBI", "TDIRBI", JdeDataType.Numeric),
        new JdeField("TDIRBF", "TDIRBF", JdeDataType.Numeric),
        new JdeField("TDIRRI", "TDIRRI", JdeDataType.Numeric),
        new JdeField("TDIRRF", "TDIRRF", JdeDataType.Numeric),
        new JdeField("TDUPMB", "TDUPMB", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4583_0", "Primary Key on TDCO, TDAN8, TDAC07, TDFY, TDPN, TDDCT, TDDOC, TDIRQ", new[] { "TDCO", "TDAN8", "TDAC07", "TDFY", "TDPN", "TDDCT", "TDDOC", "TDIRQ" }, isUnique: true, isPrimaryKey: true)
    };
}
