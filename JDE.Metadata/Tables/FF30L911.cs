using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L911 - .
/// </summary>
public class FF30L911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDLNDSID.
        /// </summary>
        public const string LDLNDSID = "LDLNDSID";

        /// <summary>
        /// LDPROID.
        /// </summary>
        public const string LDPROID = "LDPROID";

        /// <summary>
        /// LDCELLID.
        /// </summary>
        public const string LDCELLID = "LDCELLID";

        /// <summary>
        /// LDFSCID.
        /// </summary>
        public const string LDFSCID = "LDFSCID";

        /// <summary>
        /// LDNUMSHFD.
        /// </summary>
        public const string LDNUMSHFD = "LDNUMSHFD";

        /// <summary>
        /// LDDFEPH.
        /// </summary>
        public const string LDDFEPH = "LDDFEPH";

        /// <summary>
        /// LDLNTAKT.
        /// </summary>
        public const string LDLNTAKT = "LDLNTAKT";

        /// <summary>
        /// LDDFATWL.
        /// </summary>
        public const string LDDFATWL = "LDDFATWL";

        /// <summary>
        /// LDDFATWM.
        /// </summary>
        public const string LDDFATWM = "LDDFATWM";

        /// <summary>
        /// LDLDNOMA.
        /// </summary>
        public const string LDLDNOMA = "LDLDNOMA";

        /// <summary>
        /// LDLDNOLA.
        /// </summary>
        public const string LDLDNOLA = "LDLDNOLA";

        /// <summary>
        /// LDLDNOMD.
        /// </summary>
        public const string LDLDNOMD = "LDLDNOMD";

        /// <summary>
        /// LDLDNOLD.
        /// </summary>
        public const string LDLDNOLD = "LDLDNOLD";

        /// <summary>
        /// LDCOPPC.
        /// </summary>
        public const string LDCOPPC = "LDCOPPC";

        /// <summary>
        /// LDLDOQ.
        /// </summary>
        public const string LDLDOQ = "LDLDOQ";

        /// <summary>
        /// LDCSCPC.
        /// </summary>
        public const string LDCSCPC = "LDCSCPC";

        /// <summary>
        /// LDLDSCQ.
        /// </summary>
        public const string LDLDSCQ = "LDLDSCQ";

        /// <summary>
        /// LDCTPPC.
        /// </summary>
        public const string LDCTPPC = "LDCTPPC";

        /// <summary>
        /// LDLDTQ.
        /// </summary>
        public const string LDLDTQ = "LDLDTQ";

        /// <summary>
        /// LDURCD.
        /// </summary>
        public const string LDURCD = "LDURCD";

        /// <summary>
        /// LDURDT.
        /// </summary>
        public const string LDURDT = "LDURDT";

        /// <summary>
        /// LDURAT.
        /// </summary>
        public const string LDURAT = "LDURAT";

        /// <summary>
        /// LDURAB.
        /// </summary>
        public const string LDURAB = "LDURAB";

        /// <summary>
        /// LDURRF.
        /// </summary>
        public const string LDURRF = "LDURRF";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDMKEY.
        /// </summary>
        public const string LDMKEY = "LDMKEY";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDUUPMJ.
        /// </summary>
        public const string LDUUPMJ = "LDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDLNDSID", "LDLNDSID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDPROID", "LDPROID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDCELLID", "LDCELLID", JdeDataType.Numeric, null, true, true),
        new JdeField("LDFSCID", "LDFSCID", JdeDataType.Numeric),
        new JdeField("LDNUMSHFD", "LDNUMSHFD", JdeDataType.Numeric),
        new JdeField("LDDFEPH", "LDDFEPH", JdeDataType.Numeric),
        new JdeField("LDLNTAKT", "LDLNTAKT", JdeDataType.Numeric),
        new JdeField("LDDFATWL", "LDDFATWL", JdeDataType.Numeric),
        new JdeField("LDDFATWM", "LDDFATWM", JdeDataType.Numeric),
        new JdeField("LDLDNOMA", "LDLDNOMA", JdeDataType.Numeric),
        new JdeField("LDLDNOLA", "LDLDNOLA", JdeDataType.Numeric),
        new JdeField("LDLDNOMD", "LDLDNOMD", JdeDataType.Numeric),
        new JdeField("LDLDNOLD", "LDLDNOLD", JdeDataType.Numeric),
        new JdeField("LDCOPPC", "LDCOPPC", JdeDataType.Numeric),
        new JdeField("LDLDOQ", "LDLDOQ", JdeDataType.Numeric),
        new JdeField("LDCSCPC", "LDCSCPC", JdeDataType.Numeric),
        new JdeField("LDLDSCQ", "LDLDSCQ", JdeDataType.Numeric),
        new JdeField("LDCTPPC", "LDCTPPC", JdeDataType.Numeric),
        new JdeField("LDLDTQ", "LDLDTQ", JdeDataType.Numeric),
        new JdeField("LDURCD", "LDURCD", JdeDataType.String, 4),
        new JdeField("LDURDT", "LDURDT", JdeDataType.Numeric),
        new JdeField("LDURAT", "LDURAT", JdeDataType.Numeric),
        new JdeField("LDURAB", "LDURAB", JdeDataType.Numeric),
        new JdeField("LDURRF", "LDURRF", JdeDataType.String, 30),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDMKEY", "LDMKEY", JdeDataType.String, 30),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDUUPMJ", "LDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L911_0", "Primary Key on LDLNDSID, LDPROID, LDCELLID", new[] { "LDLNDSID", "LDPROID", "LDCELLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L911_2", "Index on LDFSCID", new[] { "LDFSCID" }),
        new JdeIndex("FF30L911_3", "Index on LDLNDSID", new[] { "LDLNDSID" })
    };
}
