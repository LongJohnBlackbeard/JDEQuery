using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I104 - .
/// </summary>
public class F75I104 : JdeTable
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
        /// TDSFX.
        /// </summary>
        public const string TDSFX = "TDSFX";

        /// <summary>
        /// TDI75TDSR.
        /// </summary>
        public const string TDI75TDSR = "TDI75TDSR";

        /// <summary>
        /// TDI75FTX1.
        /// </summary>
        public const string TDI75FTX1 = "TDI75FTX1";

        /// <summary>
        /// TDI75FTX2.
        /// </summary>
        public const string TDI75FTX2 = "TDI75FTX2";

        /// <summary>
        /// TDI75TXR.
        /// </summary>
        public const string TDI75TXR = "TDI75TXR";

        /// <summary>
        /// TDAG.
        /// </summary>
        public const string TDAG = "TDAG";

        /// <summary>
        /// TDI75TAXA.
        /// </summary>
        public const string TDI75TAXA = "TDI75TAXA";

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

        /// <summary>
        /// TDTORG.
        /// </summary>
        public const string TDTORG = "TDTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10, true, true),
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10, true, true),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4, true, true),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TDSFX", "TDSFX", JdeDataType.String, 6, true, true),
        new JdeField("TDI75TDSR", "TDI75TDSR", JdeDataType.Numeric),
        new JdeField("TDI75FTX1", "TDI75FTX1", JdeDataType.Numeric),
        new JdeField("TDI75FTX2", "TDI75FTX2", JdeDataType.Numeric),
        new JdeField("TDI75TXR", "TDI75TXR", JdeDataType.Numeric),
        new JdeField("TDAG", "TDAG", JdeDataType.Numeric),
        new JdeField("TDI75TAXA", "TDI75TAXA", JdeDataType.Numeric),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDTORG", "TDTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I104_0", "Primary Key on TDCO, TDKCO, TDDCT, TDDOC, TDSFX", new[] { "TDCO", "TDKCO", "TDDCT", "TDDOC", "TDSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
