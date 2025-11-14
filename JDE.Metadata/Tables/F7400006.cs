using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400006 - .
/// </summary>
public class F7400006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDKCO.
        /// </summary>
        public const string PDKCO = "PDKCO";

        /// <summary>
        /// PDDCT.
        /// </summary>
        public const string PDDCT = "PDDCT";

        /// <summary>
        /// PDDOC.
        /// </summary>
        public const string PDDOC = "PDDOC";

        /// <summary>
        /// PDSFX.
        /// </summary>
        public const string PDSFX = "PDSFX";

        /// <summary>
        /// PDPYID.
        /// </summary>
        public const string PDPYID = "PDPYID";

        /// <summary>
        /// PDRC5.
        /// </summary>
        public const string PDRC5 = "PDRC5";

        /// <summary>
        /// PDK74LAC.
        /// </summary>
        public const string PDK74LAC = "PDK74LAC";

        /// <summary>
        /// PDVOD.
        /// </summary>
        public const string PDVOD = "PDVOD";

        /// <summary>
        /// PDK74PDO.
        /// </summary>
        public const string PDK74PDO = "PDK74PDO";

        /// <summary>
        /// PDSY.
        /// </summary>
        public const string PDSY = "PDSY";

        /// <summary>
        /// PDCRTJ.
        /// </summary>
        public const string PDCRTJ = "PDCRTJ";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7400006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDKCO", "PDKCO", JdeDataType.String, 10, true, true),
        new JdeField("PDDCT", "PDDCT", JdeDataType.String, 4, true, true),
        new JdeField("PDDOC", "PDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSFX", "PDSFX", JdeDataType.String, 6, true, true),
        new JdeField("PDPYID", "PDPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDRC5", "PDRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("PDK74LAC", "PDK74LAC", JdeDataType.String, 16, true, true),
        new JdeField("PDVOD", "PDVOD", JdeDataType.String, 2),
        new JdeField("PDK74PDO", "PDK74PDO", JdeDataType.String, 2),
        new JdeField("PDSY", "PDSY", JdeDataType.String, 8),
        new JdeField("PDCRTJ", "PDCRTJ", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400006_0", "Primary Key on PDKCO, PDDCT, PDDOC, PDSFX, PDPYID, PDRC5, PDK74LAC", new[] { "PDKCO", "PDDCT", "PDDOC", "PDSFX", "PDPYID", "PDRC5", "PDK74LAC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7400006_2", "Index on PDKCO, PDDCT, PDDOC, PDK74LAC, PDSFX", new[] { "PDKCO", "PDDCT", "PDDOC", "PDK74LAC", "PDSFX" }),
        new JdeIndex("F7400006_3", "Index on PDPYID, PDRC5, PDK74LAC", new[] { "PDPYID", "PDRC5", "PDK74LAC" })
    };
}
