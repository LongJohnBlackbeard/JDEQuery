using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F750411 - .
/// </summary>
public class F750411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JXDOC.
        /// </summary>
        public const string JXDOC = "JXDOC";

        /// <summary>
        /// JXDCT.
        /// </summary>
        public const string JXDCT = "JXDCT";

        /// <summary>
        /// JXKCO.
        /// </summary>
        public const string JXKCO = "JXKCO";

        /// <summary>
        /// JXSFX.
        /// </summary>
        public const string JXSFX = "JXSFX";

        /// <summary>
        /// JXSFX0.
        /// </summary>
        public const string JXSFX0 = "JXSFX0";

        /// <summary>
        /// JXWTCJP.
        /// </summary>
        public const string JXWTCJP = "JXWTCJP";

        /// <summary>
        /// JXCO.
        /// </summary>
        public const string JXCO = "JXCO";

        /// <summary>
        /// JXAN8.
        /// </summary>
        public const string JXAN8 = "JXAN8";

        /// <summary>
        /// JXPYE.
        /// </summary>
        public const string JXPYE = "JXPYE";

        /// <summary>
        /// JXDIVJ.
        /// </summary>
        public const string JXDIVJ = "JXDIVJ";

        /// <summary>
        /// JXPYID.
        /// </summary>
        public const string JXPYID = "JXPYID";

        /// <summary>
        /// JXDCTM.
        /// </summary>
        public const string JXDCTM = "JXDCTM";

        /// <summary>
        /// JXDOCM.
        /// </summary>
        public const string JXDOCM = "JXDOCM";

        /// <summary>
        /// JXDMTJ.
        /// </summary>
        public const string JXDMTJ = "JXDMTJ";

        /// <summary>
        /// JXPAAP.
        /// </summary>
        public const string JXPAAP = "JXPAAP";

        /// <summary>
        /// JXATXA.
        /// </summary>
        public const string JXATXA = "JXATXA";

        /// <summary>
        /// JXAA.
        /// </summary>
        public const string JXAA = "JXAA";

        /// <summary>
        /// JXUSER.
        /// </summary>
        public const string JXUSER = "JXUSER";

        /// <summary>
        /// JXPID.
        /// </summary>
        public const string JXPID = "JXPID";

        /// <summary>
        /// JXUPMJ.
        /// </summary>
        public const string JXUPMJ = "JXUPMJ";

        /// <summary>
        /// JXJOBN.
        /// </summary>
        public const string JXJOBN = "JXJOBN";

        /// <summary>
        /// JXUPMT.
        /// </summary>
        public const string JXUPMT = "JXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F750411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JXDOC", "JXDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("JXDCT", "JXDCT", JdeDataType.String, 4, true, true),
        new JdeField("JXKCO", "JXKCO", JdeDataType.String, 10, true, true),
        new JdeField("JXSFX", "JXSFX", JdeDataType.String, 6, true, true),
        new JdeField("JXSFX0", "JXSFX0", JdeDataType.String, 6),
        new JdeField("JXWTCJP", "JXWTCJP", JdeDataType.String, 2),
        new JdeField("JXCO", "JXCO", JdeDataType.String, 10),
        new JdeField("JXAN8", "JXAN8", JdeDataType.Numeric),
        new JdeField("JXPYE", "JXPYE", JdeDataType.Numeric),
        new JdeField("JXDIVJ", "JXDIVJ", JdeDataType.Numeric),
        new JdeField("JXPYID", "JXPYID", JdeDataType.Numeric),
        new JdeField("JXDCTM", "JXDCTM", JdeDataType.String, 4),
        new JdeField("JXDOCM", "JXDOCM", JdeDataType.Numeric),
        new JdeField("JXDMTJ", "JXDMTJ", JdeDataType.Numeric),
        new JdeField("JXPAAP", "JXPAAP", JdeDataType.Numeric),
        new JdeField("JXATXA", "JXATXA", JdeDataType.Numeric),
        new JdeField("JXAA", "JXAA", JdeDataType.Numeric),
        new JdeField("JXUSER", "JXUSER", JdeDataType.String, 20),
        new JdeField("JXPID", "JXPID", JdeDataType.String, 20),
        new JdeField("JXUPMJ", "JXUPMJ", JdeDataType.Numeric),
        new JdeField("JXJOBN", "JXJOBN", JdeDataType.String, 20),
        new JdeField("JXUPMT", "JXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F750411_0", "Primary Key on JXDOC, JXDCT, JXKCO, JXSFX", new[] { "JXDOC", "JXDCT", "JXKCO", "JXSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F750411_2", "Unique Index on JXDOC, JXDCT, JXKCO, JXSFX0", new[] { "JXDOC", "JXDCT", "JXKCO", "JXSFX0" }, isUnique: true),
        new JdeIndex("F750411_3", "Index on JXDOC, JXDCT, JXKCO", new[] { "JXDOC", "JXDCT", "JXKCO" })
    };
}
