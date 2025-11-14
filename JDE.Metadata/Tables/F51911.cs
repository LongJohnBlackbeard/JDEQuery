using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51911 - .
/// </summary>
public class F51911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GKDCT.
        /// </summary>
        public const string GKDCT = "GKDCT";

        /// <summary>
        /// GKDOC.
        /// </summary>
        public const string GKDOC = "GKDOC";

        /// <summary>
        /// GKDGJ.
        /// </summary>
        public const string GKDGJ = "GKDGJ";

        /// <summary>
        /// GKJELN.
        /// </summary>
        public const string GKJELN = "GKJELN";

        /// <summary>
        /// GKCO.
        /// </summary>
        public const string GKCO = "GKCO";

        /// <summary>
        /// GKMCU.
        /// </summary>
        public const string GKMCU = "GKMCU";

        /// <summary>
        /// GKSUB.
        /// </summary>
        public const string GKSUB = "GKSUB";

        /// <summary>
        /// GKOBJ.
        /// </summary>
        public const string GKOBJ = "GKOBJ";

        /// <summary>
        /// GKSBL.
        /// </summary>
        public const string GKSBL = "GKSBL";

        /// <summary>
        /// GKSBLT.
        /// </summary>
        public const string GKSBLT = "GKSBLT";

        /// <summary>
        /// GKAID.
        /// </summary>
        public const string GKAID = "GKAID";

        /// <summary>
        /// GKAN8.
        /// </summary>
        public const string GKAN8 = "GKAN8";

        /// <summary>
        /// GKDOCO.
        /// </summary>
        public const string GKDOCO = "GKDOCO";

        /// <summary>
        /// GKDRST.
        /// </summary>
        public const string GKDRST = "GKDRST";

        /// <summary>
        /// GKICU.
        /// </summary>
        public const string GKICU = "GKICU";

        /// <summary>
        /// GKDICJ.
        /// </summary>
        public const string GKDICJ = "GKDICJ";

        /// <summary>
        /// GKAA.
        /// </summary>
        public const string GKAA = "GKAA";

        /// <summary>
        /// GKUSER.
        /// </summary>
        public const string GKUSER = "GKUSER";

        /// <summary>
        /// GKUPMJ.
        /// </summary>
        public const string GKUPMJ = "GKUPMJ";

        /// <summary>
        /// GKPID.
        /// </summary>
        public const string GKPID = "GKPID";

        /// <summary>
        /// GKJOBN.
        /// </summary>
        public const string GKJOBN = "GKJOBN";

        /// <summary>
        /// GKUPMT.
        /// </summary>
        public const string GKUPMT = "GKUPMT";

        /// <summary>
        /// GKKCO.
        /// </summary>
        public const string GKKCO = "GKKCO";
    }

    /// <inheritdoc />
    public override string TableName => "F51911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GKDCT", "GKDCT", JdeDataType.String, 4, true, true),
        new JdeField("GKDOC", "GKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GKDGJ", "GKDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("GKJELN", "GKJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("GKCO", "GKCO", JdeDataType.String, 10),
        new JdeField("GKMCU", "GKMCU", JdeDataType.String, 24),
        new JdeField("GKSUB", "GKSUB", JdeDataType.String, 16),
        new JdeField("GKOBJ", "GKOBJ", JdeDataType.String, 12),
        new JdeField("GKSBL", "GKSBL", JdeDataType.String, 16),
        new JdeField("GKSBLT", "GKSBLT", JdeDataType.String, 2),
        new JdeField("GKAID", "GKAID", JdeDataType.String, 16),
        new JdeField("GKAN8", "GKAN8", JdeDataType.Numeric),
        new JdeField("GKDOCO", "GKDOCO", JdeDataType.Numeric),
        new JdeField("GKDRST", "GKDRST", JdeDataType.String, 2),
        new JdeField("GKICU", "GKICU", JdeDataType.Numeric),
        new JdeField("GKDICJ", "GKDICJ", JdeDataType.Numeric),
        new JdeField("GKAA", "GKAA", JdeDataType.Numeric),
        new JdeField("GKUSER", "GKUSER", JdeDataType.String, 20),
        new JdeField("GKUPMJ", "GKUPMJ", JdeDataType.Numeric),
        new JdeField("GKPID", "GKPID", JdeDataType.String, 20),
        new JdeField("GKJOBN", "GKJOBN", JdeDataType.String, 20),
        new JdeField("GKUPMT", "GKUPMT", JdeDataType.Numeric),
        new JdeField("GKKCO", "GKKCO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51911_0", "Primary Key on GKDCT, GKDOC, GKKCO, GKDGJ, GKJELN", new[] { "GKDCT", "GKDOC", "GKKCO", "GKDGJ", "GKJELN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51911_10", "Index on GKMCU, GKICU", new[] { "GKMCU", "GKICU" }),
        new JdeIndex("F51911_12", "Index on GKMCU, GKDICJ", new[] { "GKMCU", "GKDICJ" }),
        new JdeIndex("F51911_13", "Index on GKDGJ, GKMCU, GKDRST, GKICU, GKDICJ", new[] { "GKDGJ", "GKMCU", "GKDRST", "GKICU", "GKDICJ" }),
        new JdeIndex("F51911_14", "Index on GKDRST, GKMCU, GKDCT, GKDOC, GKKCO, GKDGJ, GKJELN", new[] { "GKDRST", "GKMCU", "GKDCT", "GKDOC", "GKKCO", "GKDGJ", "GKJELN" }),
        new JdeIndex("F51911_15", "Index on GKDRST", new[] { "GKDRST" }),
        new JdeIndex("F51911_2", "Index on GKMCU, GKSUB, GKOBJ", new[] { "GKMCU", "GKSUB", "GKOBJ" }),
        new JdeIndex("F51911_3", "Index on GKAID", new[] { "GKAID" })
    };
}
