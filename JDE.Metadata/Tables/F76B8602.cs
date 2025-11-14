using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B8602 - .
/// </summary>
public class F76B8602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRUKID.
        /// </summary>
        public const string PRUKID = "PRUKID";

        /// <summary>
        /// PRMCU.
        /// </summary>
        public const string PRMCU = "PRMCU";

        /// <summary>
        /// PROBJ.
        /// </summary>
        public const string PROBJ = "PROBJ";

        /// <summary>
        /// PRSUB.
        /// </summary>
        public const string PRSUB = "PRSUB";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRDGJ.
        /// </summary>
        public const string PRDGJ = "PRDGJ";

        /// <summary>
        /// PRRMK.
        /// </summary>
        public const string PRRMK = "PRRMK";

        /// <summary>
        /// PRPAAP.
        /// </summary>
        public const string PRPAAP = "PRPAAP";

        /// <summary>
        /// PROPBR.
        /// </summary>
        public const string PROPBR = "PROPBR";

        /// <summary>
        /// PRDTBR.
        /// </summary>
        public const string PRDTBR = "PRDTBR";

        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRAG.
        /// </summary>
        public const string PRAG = "PRAG";

        /// <summary>
        /// PRDIVJ.
        /// </summary>
        public const string PRDIVJ = "PRDIVJ";

        /// <summary>
        /// PRDDJ.
        /// </summary>
        public const string PRDDJ = "PRDDJ";

        /// <summary>
        /// PRICU.
        /// </summary>
        public const string PRICU = "PRICU";

        /// <summary>
        /// PRVINV.
        /// </summary>
        public const string PRVINV = "PRVINV";

        /// <summary>
        /// PRDCT.
        /// </summary>
        public const string PRDCT = "PRDCT";

        /// <summary>
        /// PRKCO.
        /// </summary>
        public const string PRKCO = "PRKCO";

        /// <summary>
        /// PRSFX.
        /// </summary>
        public const string PRSFX = "PRSFX";

        /// <summary>
        /// PRPYID.
        /// </summary>
        public const string PRPYID = "PRPYID";

        /// <summary>
        /// PRRC5.
        /// </summary>
        public const string PRRC5 = "PRRC5";

        /// <summary>
        /// PRCO.
        /// </summary>
        public const string PRCO = "PRCO";

        /// <summary>
        /// PRRDOR.
        /// </summary>
        public const string PRRDOR = "PRRDOR";

        /// <summary>
        /// PRARAP.
        /// </summary>
        public const string PRARAP = "PRARAP";

        /// <summary>
        /// PRTORG.
        /// </summary>
        public const string PRTORG = "PRTORG";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B8602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRUKID", "PRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRMCU", "PRMCU", JdeDataType.String, 24),
        new JdeField("PROBJ", "PROBJ", JdeDataType.String, 12),
        new JdeField("PRSUB", "PRSUB", JdeDataType.String, 16),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric),
        new JdeField("PRDGJ", "PRDGJ", JdeDataType.Numeric),
        new JdeField("PRRMK", "PRRMK", JdeDataType.String, 60),
        new JdeField("PRPAAP", "PRPAAP", JdeDataType.Numeric),
        new JdeField("PROPBR", "PROPBR", JdeDataType.String, 2),
        new JdeField("PRDTBR", "PRDTBR", JdeDataType.String, 6),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric),
        new JdeField("PRAG", "PRAG", JdeDataType.Numeric),
        new JdeField("PRDIVJ", "PRDIVJ", JdeDataType.Numeric),
        new JdeField("PRDDJ", "PRDDJ", JdeDataType.Numeric),
        new JdeField("PRICU", "PRICU", JdeDataType.Numeric),
        new JdeField("PRVINV", "PRVINV", JdeDataType.String, 50),
        new JdeField("PRDCT", "PRDCT", JdeDataType.String, 4),
        new JdeField("PRKCO", "PRKCO", JdeDataType.String, 10),
        new JdeField("PRSFX", "PRSFX", JdeDataType.String, 6),
        new JdeField("PRPYID", "PRPYID", JdeDataType.Numeric),
        new JdeField("PRRC5", "PRRC5", JdeDataType.Numeric),
        new JdeField("PRCO", "PRCO", JdeDataType.String, 10),
        new JdeField("PRRDOR", "PRRDOR", JdeDataType.String, 2),
        new JdeField("PRARAP", "PRARAP", JdeDataType.String, 2),
        new JdeField("PRTORG", "PRTORG", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B8602_0", "Primary Key on PRUKID", new[] { "PRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B8602_2", "Index on PRDOC, PRDCT, PRKCO, PRSFX, PRPYID, PRRC5", new[] { "PRDOC", "PRDCT", "PRKCO", "PRSFX", "PRPYID", "PRRC5" }),
        new JdeIndex("F76B8602_3", "Index on PRDOC, PRDCT, PRKCO, PRSFX, PRARAP, PRRDOR", new[] { "PRDOC", "PRDCT", "PRKCO", "PRSFX", "PRARAP", "PRRDOR" }),
        new JdeIndex("F76B8602_4", "Index on PRPYID, PRRC5, PRARAP, PRRDOR", new[] { "PRPYID", "PRRC5", "PRARAP", "PRRDOR" })
    };
}
