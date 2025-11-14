using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L114 - .
/// </summary>
public class F15L114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDMCU.
        /// </summary>
        public const string EDMCU = "EDMCU";

        /// <summary>
        /// EDEPRD.
        /// </summary>
        public const string EDEPRD = "EDEPRD";

        /// <summary>
        /// EDRVNB.
        /// </summary>
        public const string EDRVNB = "EDRVNB";

        /// <summary>
        /// EDSEQ.
        /// </summary>
        public const string EDSEQ = "EDSEQ";

        /// <summary>
        /// EDEPCL.
        /// </summary>
        public const string EDEPCL = "EDEPCL";

        /// <summary>
        /// EDEPCD.
        /// </summary>
        public const string EDEPCD = "EDEPCD";

        /// <summary>
        /// EDGLC.
        /// </summary>
        public const string EDGLC = "EDGLC";

        /// <summary>
        /// EDBSEX.
        /// </summary>
        public const string EDBSEX = "EDBSEX";

        /// <summary>
        /// EDSFDN.
        /// </summary>
        public const string EDSFDN = "EDSFDN";

        /// <summary>
        /// EDTEXR.
        /// </summary>
        public const string EDTEXR = "EDTEXR";

        /// <summary>
        /// EDAEPA.
        /// </summary>
        public const string EDAEPA = "EDAEPA";

        /// <summary>
        /// EDGRPA.
        /// </summary>
        public const string EDGRPA = "EDGRPA";

        /// <summary>
        /// EDABYO.
        /// </summary>
        public const string EDABYO = "EDABYO";

        /// <summary>
        /// EDURCD.
        /// </summary>
        public const string EDURCD = "EDURCD";

        /// <summary>
        /// EDURDT.
        /// </summary>
        public const string EDURDT = "EDURDT";

        /// <summary>
        /// EDURAT.
        /// </summary>
        public const string EDURAT = "EDURAT";

        /// <summary>
        /// EDURAB.
        /// </summary>
        public const string EDURAB = "EDURAB";

        /// <summary>
        /// EDURRF.
        /// </summary>
        public const string EDURRF = "EDURRF";

        /// <summary>
        /// EDTORG.
        /// </summary>
        public const string EDTORG = "EDTORG";

        /// <summary>
        /// EDENTJ.
        /// </summary>
        public const string EDENTJ = "EDENTJ";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDECMA.
        /// </summary>
        public const string EDECMA = "EDECMA";

        /// <summary>
        /// EDGPCT.
        /// </summary>
        public const string EDGPCT = "EDGPCT";

        /// <summary>
        /// EDEXAPSF.
        /// </summary>
        public const string EDEXAPSF = "EDEXAPSF";

        /// <summary>
        /// EDEXGPA.
        /// </summary>
        public const string EDEXGPA = "EDEXGPA";

        /// <summary>
        /// EDBRAF.
        /// </summary>
        public const string EDBRAF = "EDBRAF";

        /// <summary>
        /// EDFERA.
        /// </summary>
        public const string EDFERA = "EDFERA";

        /// <summary>
        /// EDFEBA.
        /// </summary>
        public const string EDFEBA = "EDFEBA";
    }

    /// <inheritdoc />
    public override string TableName => "F15L114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDMCU", "EDMCU", JdeDataType.String, 24, true, true),
        new JdeField("EDEPRD", "EDEPRD", JdeDataType.String, 20, true, true),
        new JdeField("EDRVNB", "EDRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("EDSEQ", "EDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("EDEPCL", "EDEPCL", JdeDataType.String, 8),
        new JdeField("EDEPCD", "EDEPCD", JdeDataType.String, 4),
        new JdeField("EDGLC", "EDGLC", JdeDataType.String, 8),
        new JdeField("EDBSEX", "EDBSEX", JdeDataType.Numeric),
        new JdeField("EDSFDN", "EDSFDN", JdeDataType.String, 20),
        new JdeField("EDTEXR", "EDTEXR", JdeDataType.String, 20),
        new JdeField("EDAEPA", "EDAEPA", JdeDataType.Numeric),
        new JdeField("EDGRPA", "EDGRPA", JdeDataType.String, 20),
        new JdeField("EDABYO", "EDABYO", JdeDataType.Numeric),
        new JdeField("EDURCD", "EDURCD", JdeDataType.String, 4),
        new JdeField("EDURDT", "EDURDT", JdeDataType.Numeric),
        new JdeField("EDURAT", "EDURAT", JdeDataType.Numeric),
        new JdeField("EDURAB", "EDURAB", JdeDataType.Numeric),
        new JdeField("EDURRF", "EDURRF", JdeDataType.String, 30),
        new JdeField("EDTORG", "EDTORG", JdeDataType.String, 20),
        new JdeField("EDENTJ", "EDENTJ", JdeDataType.Numeric),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDECMA", "EDECMA", JdeDataType.String, 2),
        new JdeField("EDGPCT", "EDGPCT", JdeDataType.Numeric),
        new JdeField("EDEXAPSF", "EDEXAPSF", JdeDataType.Numeric),
        new JdeField("EDEXGPA", "EDEXGPA", JdeDataType.String, 20),
        new JdeField("EDBRAF", "EDBRAF", JdeDataType.String, 8),
        new JdeField("EDFERA", "EDFERA", JdeDataType.Numeric),
        new JdeField("EDFEBA", "EDFEBA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L114_0", "Primary Key on EDMCU, EDEPRD, EDRVNB, EDSEQ", new[] { "EDMCU", "EDEPRD", "EDRVNB", "EDSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15L114_2", "Index on EDMCU, EDRVNB, EDECMA", new[] { "EDMCU", "EDRVNB", "EDECMA" })
    };
}
