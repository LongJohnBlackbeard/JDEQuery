using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48426 - .
/// </summary>
public class F48426 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STLNID.
        /// </summary>
        public const string STLNID = "STLNID";

        /// <summary>
        /// STCO.
        /// </summary>
        public const string STCO = "STCO";

        /// <summary>
        /// STMCU.
        /// </summary>
        public const string STMCU = "STMCU";

        /// <summary>
        /// STMCUS.
        /// </summary>
        public const string STMCUS = "STMCUS";

        /// <summary>
        /// STAN8O.
        /// </summary>
        public const string STAN8O = "STAN8O";

        /// <summary>
        /// STSBL.
        /// </summary>
        public const string STSBL = "STSBL";

        /// <summary>
        /// STSBLT.
        /// </summary>
        public const string STSBLT = "STSBLT";

        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STRP11.
        /// </summary>
        public const string STRP11 = "STRP11";

        /// <summary>
        /// STWR07.
        /// </summary>
        public const string STWR07 = "STWR07";

        /// <summary>
        /// STOBJ.
        /// </summary>
        public const string STOBJ = "STOBJ";

        /// <summary>
        /// STSUB.
        /// </summary>
        public const string STSUB = "STSUB";

        /// <summary>
        /// STRRF.
        /// </summary>
        public const string STRRF = "STRRF";

        /// <summary>
        /// STCONFD.
        /// </summary>
        public const string STCONFD = "STCONFD";

        /// <summary>
        /// STRDF.
        /// </summary>
        public const string STRDF = "STRDF";

        /// <summary>
        /// STVALFJ.
        /// </summary>
        public const string STVALFJ = "STVALFJ";

        /// <summary>
        /// STVALTJ.
        /// </summary>
        public const string STVALTJ = "STVALTJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F48426";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STLNID", "STLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("STCO", "STCO", JdeDataType.String, 10, true, true),
        new JdeField("STMCU", "STMCU", JdeDataType.String, 24),
        new JdeField("STMCUS", "STMCUS", JdeDataType.String, 24),
        new JdeField("STAN8O", "STAN8O", JdeDataType.Numeric),
        new JdeField("STSBL", "STSBL", JdeDataType.String, 16),
        new JdeField("STSBLT", "STSBLT", JdeDataType.String, 2),
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric),
        new JdeField("STRP11", "STRP11", JdeDataType.String, 6),
        new JdeField("STWR07", "STWR07", JdeDataType.String, 6),
        new JdeField("STOBJ", "STOBJ", JdeDataType.String, 12),
        new JdeField("STSUB", "STSUB", JdeDataType.String, 16),
        new JdeField("STRRF", "STRRF", JdeDataType.String, 2),
        new JdeField("STCONFD", "STCONFD", JdeDataType.Numeric),
        new JdeField("STRDF", "STRDF", JdeDataType.String, 2),
        new JdeField("STVALFJ", "STVALFJ", JdeDataType.Numeric),
        new JdeField("STVALTJ", "STVALTJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48426_0", "Primary Key on STCO, STLNID", new[] { "STCO", "STLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
