using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H402 - .
/// </summary>
public class F76H402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LPPYID.
        /// </summary>
        public const string LPPYID = "LPPYID";

        /// <summary>
        /// LPRC5.
        /// </summary>
        public const string LPRC5 = "LPRC5";

        /// <summary>
        /// LPDOC.
        /// </summary>
        public const string LPDOC = "LPDOC";

        /// <summary>
        /// LPDCT.
        /// </summary>
        public const string LPDCT = "LPDCT";

        /// <summary>
        /// LPKCO.
        /// </summary>
        public const string LPKCO = "LPKCO";

        /// <summary>
        /// LPSFX.
        /// </summary>
        public const string LPSFX = "LPSFX";

        /// <summary>
        /// LPSFXE.
        /// </summary>
        public const string LPSFXE = "LPSFXE";

        /// <summary>
        /// LPH76WH.
        /// </summary>
        public const string LPH76WH = "LPH76WH";

        /// <summary>
        /// LPH76WNBR.
        /// </summary>
        public const string LPH76WNBR = "LPH76WNBR";

        /// <summary>
        /// LPH76FUC.
        /// </summary>
        public const string LPH76FUC = "LPH76FUC";

        /// <summary>
        /// LPH76FUD.
        /// </summary>
        public const string LPH76FUD = "LPH76FUD";

        /// <summary>
        /// LPH76FUF.
        /// </summary>
        public const string LPH76FUF = "LPH76FUF";

        /// <summary>
        /// LPH76FUR.
        /// </summary>
        public const string LPH76FUR = "LPH76FUR";

        /// <summary>
        /// LPUSER.
        /// </summary>
        public const string LPUSER = "LPUSER";

        /// <summary>
        /// LPPID.
        /// </summary>
        public const string LPPID = "LPPID";

        /// <summary>
        /// LPJOBN.
        /// </summary>
        public const string LPJOBN = "LPJOBN";

        /// <summary>
        /// LPUPMJ.
        /// </summary>
        public const string LPUPMJ = "LPUPMJ";

        /// <summary>
        /// LPUPMT.
        /// </summary>
        public const string LPUPMT = "LPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LPPYID", "LPPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("LPRC5", "LPRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("LPDOC", "LPDOC", JdeDataType.Numeric),
        new JdeField("LPDCT", "LPDCT", JdeDataType.String, 4),
        new JdeField("LPKCO", "LPKCO", JdeDataType.String, 10),
        new JdeField("LPSFX", "LPSFX", JdeDataType.String, 6),
        new JdeField("LPSFXE", "LPSFXE", JdeDataType.Numeric),
        new JdeField("LPH76WH", "LPH76WH", JdeDataType.String, 2),
        new JdeField("LPH76WNBR", "LPH76WNBR", JdeDataType.Numeric),
        new JdeField("LPH76FUC", "LPH76FUC", JdeDataType.String, 20),
        new JdeField("LPH76FUD", "LPH76FUD", JdeDataType.Numeric),
        new JdeField("LPH76FUF", "LPH76FUF", JdeDataType.String, 2),
        new JdeField("LPH76FUR", "LPH76FUR", JdeDataType.String, 30),
        new JdeField("LPUSER", "LPUSER", JdeDataType.String, 20),
        new JdeField("LPPID", "LPPID", JdeDataType.String, 20),
        new JdeField("LPJOBN", "LPJOBN", JdeDataType.String, 20),
        new JdeField("LPUPMJ", "LPUPMJ", JdeDataType.Numeric),
        new JdeField("LPUPMT", "LPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H402_0", "Primary Key on LPPYID, LPRC5", new[] { "LPPYID", "LPRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H402_2", "Index on LPDOC, LPDCT, LPKCO, LPSFX, LPSFXE", new[] { "LPDOC", "LPDCT", "LPKCO", "LPSFX", "LPSFXE" })
    };
}
