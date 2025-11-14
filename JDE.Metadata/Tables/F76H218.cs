using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H218 - .
/// </summary>
public class F76H218 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TDKCO.
        /// </summary>
        public const string TDKCO = "TDKCO";

        /// <summary>
        /// TDDCT.
        /// </summary>
        public const string TDDCT = "TDDCT";

        /// <summary>
        /// TDDOC.
        /// </summary>
        public const string TDDOC = "TDDOC";

        /// <summary>
        /// TDTXA1.
        /// </summary>
        public const string TDTXA1 = "TDTXA1";

        /// <summary>
        /// TDEXR1.
        /// </summary>
        public const string TDEXR1 = "TDEXR1";

        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDAG.
        /// </summary>
        public const string TDAG = "TDAG";

        /// <summary>
        /// TDATXN.
        /// </summary>
        public const string TDATXN = "TDATXN";

        /// <summary>
        /// TDATXA.
        /// </summary>
        public const string TDATXA = "TDATXA";

        /// <summary>
        /// TDSTAM.
        /// </summary>
        public const string TDSTAM = "TDSTAM";

        /// <summary>
        /// TDTXR1.
        /// </summary>
        public const string TDTXR1 = "TDTXR1";

        /// <summary>
        /// TDTXR2.
        /// </summary>
        public const string TDTXR2 = "TDTXR2";

        /// <summary>
        /// TDTXR3.
        /// </summary>
        public const string TDTXR3 = "TDTXR3";

        /// <summary>
        /// TDTXR4.
        /// </summary>
        public const string TDTXR4 = "TDTXR4";

        /// <summary>
        /// TDTXR5.
        /// </summary>
        public const string TDTXR5 = "TDTXR5";

        /// <summary>
        /// TDSTA1.
        /// </summary>
        public const string TDSTA1 = "TDSTA1";

        /// <summary>
        /// TDSTA2.
        /// </summary>
        public const string TDSTA2 = "TDSTA2";

        /// <summary>
        /// TDSTA3.
        /// </summary>
        public const string TDSTA3 = "TDSTA3";

        /// <summary>
        /// TDSTA4.
        /// </summary>
        public const string TDSTA4 = "TDSTA4";

        /// <summary>
        /// TDSTA5.
        /// </summary>
        public const string TDSTA5 = "TDSTA5";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDCRR.
        /// </summary>
        public const string TDCRR = "TDCRR";

        /// <summary>
        /// TDCRCM.
        /// </summary>
        public const string TDCRCM = "TDCRCM";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H218";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric),
        new JdeField("TDTXA1", "TDTXA1", JdeDataType.String, 20),
        new JdeField("TDEXR1", "TDEXR1", JdeDataType.String, 4),
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10),
        new JdeField("TDAG", "TDAG", JdeDataType.Numeric),
        new JdeField("TDATXN", "TDATXN", JdeDataType.Numeric),
        new JdeField("TDATXA", "TDATXA", JdeDataType.Numeric),
        new JdeField("TDSTAM", "TDSTAM", JdeDataType.Numeric),
        new JdeField("TDTXR1", "TDTXR1", JdeDataType.Numeric),
        new JdeField("TDTXR2", "TDTXR2", JdeDataType.Numeric),
        new JdeField("TDTXR3", "TDTXR3", JdeDataType.Numeric),
        new JdeField("TDTXR4", "TDTXR4", JdeDataType.Numeric),
        new JdeField("TDTXR5", "TDTXR5", JdeDataType.Numeric),
        new JdeField("TDSTA1", "TDSTA1", JdeDataType.Numeric),
        new JdeField("TDSTA2", "TDSTA2", JdeDataType.Numeric),
        new JdeField("TDSTA3", "TDSTA3", JdeDataType.Numeric),
        new JdeField("TDSTA4", "TDSTA4", JdeDataType.Numeric),
        new JdeField("TDSTA5", "TDSTA5", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDCRR", "TDCRR", JdeDataType.Numeric),
        new JdeField("TDCRCM", "TDCRCM", JdeDataType.String, 2),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H218_0", "Primary Key on TDKCOO, TDDCTO, TDDOCO, TDLNID", new[] { "TDKCOO", "TDDCTO", "TDDOCO", "TDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H218_2", "Index on TDKCO, TDDCT, TDDOC", new[] { "TDKCO", "TDDCT", "TDDOC" })
    };
}
