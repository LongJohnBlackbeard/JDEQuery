using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B51 - .
/// </summary>
public class F76H3B51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDH76LOPN.
        /// </summary>
        public const string LDH76LOPN = "LDH76LOPN";

        /// <summary>
        /// LDH76LECO.
        /// </summary>
        public const string LDH76LECO = "LDH76LECO";

        /// <summary>
        /// LDH76LEDT.
        /// </summary>
        public const string LDH76LEDT = "LDH76LEDT";

        /// <summary>
        /// LDH76EMS.
        /// </summary>
        public const string LDH76EMS = "LDH76EMS";

        /// <summary>
        /// LDKCO.
        /// </summary>
        public const string LDKCO = "LDKCO";

        /// <summary>
        /// LDDCT.
        /// </summary>
        public const string LDDCT = "LDDCT";

        /// <summary>
        /// LDDOC.
        /// </summary>
        public const string LDDOC = "LDDOC";

        /// <summary>
        /// LDH76LIST.
        /// </summary>
        public const string LDH76LIST = "LDH76LIST";

        /// <summary>
        /// LDH76FUC.
        /// </summary>
        public const string LDH76FUC = "LDH76FUC";

        /// <summary>
        /// LDH76FUD.
        /// </summary>
        public const string LDH76FUD = "LDH76FUD";

        /// <summary>
        /// LDH76FUR.
        /// </summary>
        public const string LDH76FUR = "LDH76FUR";

        /// <summary>
        /// LDH76FUA.
        /// </summary>
        public const string LDH76FUA = "LDH76FUA";

        /// <summary>
        /// LDH76FUF.
        /// </summary>
        public const string LDH76FUF = "LDH76FUF";

        /// <summary>
        /// LDH76LPDT.
        /// </summary>
        public const string LDH76LPDT = "LDH76LPDT";

        /// <summary>
        /// LDH76LPTI.
        /// </summary>
        public const string LDH76LPTI = "LDH76LPTI";

        /// <summary>
        /// LDTORG.
        /// </summary>
        public const string LDTORG = "LDTORG";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDUPMT.
        /// </summary>
        public const string LDUPMT = "LDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDH76LOPN", "LDH76LOPN", JdeDataType.Numeric, null, true, true),
        new JdeField("LDH76LECO", "LDH76LECO", JdeDataType.String, 10, true, true),
        new JdeField("LDH76LEDT", "LDH76LEDT", JdeDataType.String, 6, true, true),
        new JdeField("LDH76EMS", "LDH76EMS", JdeDataType.String, 8, true, true),
        new JdeField("LDKCO", "LDKCO", JdeDataType.String, 10, true, true),
        new JdeField("LDDCT", "LDDCT", JdeDataType.String, 4, true, true),
        new JdeField("LDDOC", "LDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("LDH76LIST", "LDH76LIST", JdeDataType.String, 2),
        new JdeField("LDH76FUC", "LDH76FUC", JdeDataType.String, 20),
        new JdeField("LDH76FUD", "LDH76FUD", JdeDataType.Numeric),
        new JdeField("LDH76FUR", "LDH76FUR", JdeDataType.String, 30),
        new JdeField("LDH76FUA", "LDH76FUA", JdeDataType.Numeric),
        new JdeField("LDH76FUF", "LDH76FUF", JdeDataType.String, 2),
        new JdeField("LDH76LPDT", "LDH76LPDT", JdeDataType.Numeric),
        new JdeField("LDH76LPTI", "LDH76LPTI", JdeDataType.Numeric),
        new JdeField("LDTORG", "LDTORG", JdeDataType.String, 20),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDUPMT", "LDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B51_0", "Primary Key on LDH76LOPN, LDH76LECO, LDH76LEDT, LDH76EMS, LDKCO, LDDCT, LDDOC", new[] { "LDH76LOPN", "LDH76LECO", "LDH76LEDT", "LDH76EMS", "LDKCO", "LDDCT", "LDDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H3B51_2", "Index on LDKCO, LDDCT, LDDOC, LDH76LOPN", new[] { "LDKCO", "LDDCT", "LDDOC", "LDH76LOPN" }),
        new JdeIndex("F76H3B51_3", "Index on LDH76LOPN, LDH76LECO, LDH76LEDT, LDH76EMS, LDH76LIST", new[] { "LDH76LOPN", "LDH76LECO", "LDH76LEDT", "LDH76EMS", "LDH76LIST" })
    };
}
