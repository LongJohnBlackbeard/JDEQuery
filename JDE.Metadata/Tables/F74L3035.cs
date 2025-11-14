using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L3035 - .
/// </summary>
public class F74L3035 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// TDSEQ.
        /// </summary>
        public const string TDSEQ = "TDSEQ";

        /// <summary>
        /// TDL74TLVDT.
        /// </summary>
        public const string TDL74TLVDT = "TDL74TLVDT";

        /// <summary>
        /// TDTXA1.
        /// </summary>
        public const string TDTXA1 = "TDTXA1";

        /// <summary>
        /// TDK74TAXC.
        /// </summary>
        public const string TDK74TAXC = "TDK74TAXC";

        /// <summary>
        /// TDTA1.
        /// </summary>
        public const string TDTA1 = "TDTA1";

        /// <summary>
        /// TDITM.
        /// </summary>
        public const string TDITM = "TDITM";

        /// <summary>
        /// TDDESC.
        /// </summary>
        public const string TDDESC = "TDDESC";

        /// <summary>
        /// TDTXR1.
        /// </summary>
        public const string TDTXR1 = "TDTXR1";

        /// <summary>
        /// TDATXA.
        /// </summary>
        public const string TDATXA = "TDATXA";

        /// <summary>
        /// TDSTAM.
        /// </summary>
        public const string TDSTAM = "TDSTAM";

        /// <summary>
        /// TDATXN.
        /// </summary>
        public const string TDATXN = "TDATXN";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDTORG.
        /// </summary>
        public const string TDTORG = "TDTORG";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

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
    public override string TableName => "F74L3035";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10, true, true),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4, true, true),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TDSEQ", "TDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDL74TLVDT", "TDL74TLVDT", JdeDataType.String, 2, true, true),
        new JdeField("TDTXA1", "TDTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TDK74TAXC", "TDK74TAXC", JdeDataType.String, 20, true, true),
        new JdeField("TDTA1", "TDTA1", JdeDataType.Numeric),
        new JdeField("TDITM", "TDITM", JdeDataType.Numeric),
        new JdeField("TDDESC", "TDDESC", JdeDataType.String, 60),
        new JdeField("TDTXR1", "TDTXR1", JdeDataType.Numeric),
        new JdeField("TDATXA", "TDATXA", JdeDataType.Numeric),
        new JdeField("TDSTAM", "TDSTAM", JdeDataType.Numeric),
        new JdeField("TDATXN", "TDATXN", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDTORG", "TDTORG", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L3035_0", "Primary Key on TDKCO, TDDCT, TDDOC, TDSEQ, TDL74TLVDT, TDTXA1, TDK74TAXC", new[] { "TDKCO", "TDDCT", "TDDOC", "TDSEQ", "TDL74TLVDT", "TDTXA1", "TDK74TAXC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74L3035_2", "Index on TDL74TLVDT, TDTXA1, TDTA1", new[] { "TDL74TLVDT", "TDTXA1", "TDTA1" })
    };
}
